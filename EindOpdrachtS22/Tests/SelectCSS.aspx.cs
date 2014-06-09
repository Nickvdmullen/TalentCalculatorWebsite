using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EindopdrachtS22.Classes;
using System.Drawing;

namespace EindOpdrachtS22.Tests
{
    public partial class Test2 : System.Web.UI.Page
    {
        Build myBuild = new Build();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton1.BorderColor = Color.Lime;
            ImageButton2.BorderColor = Color.Black;
            Label1.Text = "Succes selected 1";
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton2.BorderColor = Color.Lime;
            ImageButton1.BorderColor = Color.Black;
            Label1.Text = "Succes selected 2";
        }
    }
}