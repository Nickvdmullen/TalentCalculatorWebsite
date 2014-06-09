using EindopdrachtS22.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EindOpdrachtS22.Tests
{
    public partial class Comment : System.Web.UI.Page
    {
        DBControl database = new DBControl();
        List<string> Build = new List<string>();
        Build myBuild = new Build();
        string BuildName;
        protected void Page_Load(object sender, EventArgs e)
        {
            BuildName = "Test";
            Build = database.GetBuild(BuildName);
            GridView1.DataSource = database.GetDataSource(myBuild.BuildName);
            GridView1.DataBind();
        }
    }
}