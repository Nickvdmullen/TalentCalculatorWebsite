using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EindOpdrachtS22.Tests
{
    public partial class Load : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string test = "1";
            string test2 = "3";
            Session.Add("test", test);
            Session.Add("test", test2);
            FillPage();
        }

        private void FillPage()
        {

            string build = (string)Session["test"];
            List<string> choice = new List<string>();
            choice.Add(build);

            if (Session["test"] != null)
            {
                 foreach(String item in choice)
                 {
                    int Choice = Convert.ToInt32(item);

                    switch (Choice)
                    {
                        //Classes
                        case 1: ImageButton1.BorderColor = Color.Lime;
                            break;
                        case 2: ImageButton2.BorderColor = Color.Lime;
                            break;
                        case 3: ImageButton3.BorderColor = Color.Lime;
                            break;
                      
                        //empty

                    }
                }
            }
        }

    }
}