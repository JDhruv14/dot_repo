using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThemeMasterSiteMapDemo
{
	public partial class Home : System.Web.UI.Page
	{
        protected void Page_Load(object sender, EventArgs e)
        {
            lblDate.Text = "Today's Date: " + DateTime.Now.ToString("dddd, dd MMMM yyyy");

            if (!IsPostBack)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Name");
                dt.Columns.Add("Email");
                dt.Rows.Add("Dhruv", "dhruv@gmail.com");
                dt.Rows.Add("Jaradi", "jaradi@yahoo.com");

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

    }
}