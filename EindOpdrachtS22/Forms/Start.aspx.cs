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
        // Creates an instance of the class DBControl ----------------------------------------------------------------
        DBControl database = new DBControl();
        
        // Pageload event, Gets the saved builds from the database and sets them as datasource for the dropdownlist --
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

        // A button that when clicked redirects you to the FormCreate ------------------------------------------------
        protected void btnStartNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:2780/Forms/FormCreate.aspx");
        }


        // A button that gets the selected item from the dropdownlist and puts it in the URL, then redirects you to --
        // View.aspx with the selected build in the URL --------------------------------------------------------------
        protected void btnStartLoad_Click(object sender, EventArgs e)
        {
            string buildname = dllBuilds.SelectedItem.ToString();
            string URL = "http://localhost:2780/Forms/View.aspx" + "?name="+buildname;
            Response.Redirect(URL);
        }

       
        
    }
}