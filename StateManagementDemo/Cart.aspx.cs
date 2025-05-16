using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementDemo
{
	public partial class Cart : System.Web.UI.Page
	{
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cart"] != null)
            {
                List<string> cart = (List<string>)Session["cart"];
                bltCart.DataSource = cart;
                bltCart.DataBind();
            }
            else
            {
                bltCart.Items.Add("Cart is empty.");
            }

            if (Request.Cookies["lastItem"] != null)
            {
                lblLastItem.Text = "Last item you added was: " + Request.Cookies["lastItem"].Value;
            }
        }

    }
}