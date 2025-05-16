using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementDemo
{
	public partial class Shop : System.Web.UI.Page
	{
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && ViewState["selectedItem"] != null)
            {
                ddlItems.SelectedValue = ViewState["selectedItem"].ToString();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string item = ddlItems.SelectedItem.Text;

            // Save selected item in ViewState
            ViewState["selectedItem"] = item;

            // Store in session cart (List<string>)
            if (Session["cart"] == null)
            {
                Session["cart"] = new List<string>();
            }

            List<string> cart = (List<string>)Session["cart"];
            cart.Add(item);

            // Optional: Save last item in cookie
            HttpCookie lastItem = new HttpCookie("lastItem", item);
            lastItem.Expires = DateTime.Now.AddMinutes(10);
            Response.Cookies.Add(lastItem);

            lblMessage.Text = item + " added to cart!";
        }

    }
}