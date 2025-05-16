using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.UI;

namespace Web_Practical_10
{
    public partial class WebForm1 : Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            // Clear previous error messages
            lblPhone.Text = lblEmail.Text = lblPassword.Text = lblConfirmPassword.Text = lblHobby.Text = lblBranch.Text = "";

            // Phone Number Check
            if (TextBox3.Text.Length != 10 || !TextBox3.Text.All(char.IsDigit))
            {
                lblPhone.Text = "Phone number must be exactly 10 digits.";
                isValid = false;
            }

            // Email Format
            if (!Regex.IsMatch(TextBox6.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lblEmail.Text = "Invalid email format.";
                isValid = false;
            }

            // Password strength
            string password = TextBox4.Text;
            if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=!]).{6,}$"))
            {
                lblPassword.Text = "Weak password: Must contain upper, lower, digit, and special char.";
                isValid = false;
            }

            // Confirm password
            if (TextBox4.Text != TextBox5.Text)
            {
                lblConfirmPassword.Text = "Passwords do not match.";
                isValid = false;
            }

            // Branch
            if (DropDownList1.SelectedValue == "--Select Branch--")
            {
                lblBranch.Text = "Please select a branch.";
                isValid = false;
            }

            // Hobbies
            if (!CheckBox1.Checked && !CheckBox2.Checked)
            {
                lblHobby.Text = "Please select at least one hobby.";
                isValid = false;
            }

            // Final result
            if (isValid)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Registration successful!');", true);
                // Additional logic like DB save can go here
            }
        }
    }
}
