using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThemeMasterSiteMapDemo
{
	public partial class Contact : System.Web.UI.Page
	{
        // Contact.aspx.cs
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "Thanks for contacting us, " + txtName.Text + "!";
        }

    }
}