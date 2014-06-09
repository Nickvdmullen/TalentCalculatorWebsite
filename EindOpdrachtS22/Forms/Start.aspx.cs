namespace EindOpdrachtS22.Forms
{
    using EindopdrachtS22.Classes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class Start : System.Web.UI.Page
    {
        DBControl database = new DBControl();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> resources = database.GetBuilds();
            foreach (string build in resources)
            {
                if(build != "0")
                {
                    dllBuilds.Items.Add(build);
                }
            }
        }

        protected void btnStartNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:2780/Forms/FormCreate.aspx");
        }

        protected void btnStartLoad_Click(object sender, EventArgs e)
        {
            string buildname = dllBuilds.SelectedItem.ToString();
            string URL = "http://localhost:2780/Forms/View.aspx" + "?name="+buildname;
            Response.Redirect(URL);
        }

       
        
    }
}