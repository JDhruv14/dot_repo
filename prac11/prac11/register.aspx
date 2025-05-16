<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="prac11.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Form</title>
    <style>
        body {
    font-family: Arial, sans-serif;
    background-color: #f4f4f4;
    margin: 0;
    padding: 20px;
}

element.style
{
    margin-bottom: 10px;
}
h2 {
    color: #333;
    text-align: center; /* Center the heading */
}
nav {
    text-align: center;
    margin-bottom: 20px;
}

nav ul {
list-style-type: none;
padding: 0;
}

nav ul li {
display: inline;
margin: 0 15px;
}

nav ul li a {
text-decoration: none;
color: #5cb85c;
}

nav ul li a:hover {
text-decoration: underline;
}

form {
    background-color: white; /* White background for the form */
    border-radius: 8px; /* Rounded corners */
    box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1); /* Subtle shadow */
    padding: 20px; /* Padding inside the form */
    max-width: 400px; /* Maximum width of the form */
    margin: auto; /* Center the form horizontally */
}

input[type="text"], input[type="password"] {
    width: 100%; /* Full width of the form */
    padding: 10px;
    margin: 10px 0; /* Increased margin for better spacing */
    border: 1px solid #ccc; /* Light border */
    border-radius: 4px; /* Rounded corners for input fields */
    box-sizing: border-box; /* Include padding and border in element's total width and height */
}

    input[type="text"]:focus, input[type="password"]:focus 
    {
        border-color: #5cb85c; /* Change border color on focus */
        outline: none; /* Remove default outline */
    }

button {
    width: 100%; /* Full width of the form */
    padding: 10px 15px;
    background-color: #5cb85c;
    color: white;
    border: none;
    border-radius: 4px; /* Rounded corners for the button */
    cursor: pointer;
    font-size: 16px; /* Increase font size */
    transition: background-color 0.3s; /* Smooth transition for background color */
}

    button:hover {
        background-color: #4cae4c; /* Darker green on hover */
    }

.alert {
    color: red; /* Red color for error messages */
    text-align: center; /* Center the alert message */
    margin-top: 10px; /* Margin above the alert */
}

    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Registration Form</h2>
            <asp:Label ID="lblName" runat="server" Text="Name:" AssociatedControlID="txtName"></asp:Label><br />
            <asp:TextBox ID="txtName" runat="server" placeholder="Enter your name"></asp:TextBox><br />

            <asp:Label ID="lblEmail" runat="server" Text="Email:" AssociatedControlID="txtEmail"></asp:Label><br />
            <asp:TextBox ID="txtEmail" runat="server" placeholder="Enter your email"></asp:TextBox><br />

            <asp:Label ID="lblPhoneNo" runat="server" Text="Phone No:" AssociatedControlID="txtPhoneNo"></asp:Label><br />
            <asp:TextBox ID="txtPhoneNo" runat="server" placeholder="Enter your phone number"></asp:TextBox><br />

            <asp:Label ID="lblPassword" runat="server" Text="Password:" AssociatedControlID="txtPassword"></asp:Label><br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Enter your password"></asp:TextBox><br />

            <asp:Label ID="lblConfirmPassword" runat="server" Text="Confirm Password:" AssociatedControlID="txtConfirmPassword"></asp:Label><br />
            <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" placeholder="Confirm your password"></asp:TextBox>
            <br />
            <br />
            <br />

            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>