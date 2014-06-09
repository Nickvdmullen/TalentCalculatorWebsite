using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EindopdrachtS22.Classes;

namespace EindOpdrachtS22.Tests
{
    public partial class StartTest : System.Web.UI.Page
    {
        DBControl database = new DBControl();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> resources = database.GetBuilds();
            foreach (string build in resources)
            {
                if (build != "0")
                {
                    DropDownList1.Items.Add(build);
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = "Succes";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string buildname = DropDownList1.SelectedItem.ToString();
            Label1.Text = "Succes";
        }
    }
}