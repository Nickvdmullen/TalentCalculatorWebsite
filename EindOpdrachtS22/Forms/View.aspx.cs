namespace EindOpdrachtS22.Forms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using EindopdrachtS22.Classes;
    using System.Drawing;
    public partial class View : System.Web.UI.Page
    {

        // Creates an instance of the class DBControl,Build and properties -----------------------------------------------
        DBControl database = new DBControl();
        List<String> Build = new List<string>();
        Build myBuild = new Build();
        string BuildName;

        //Page_load event that gets the buildname from the URL, then gets the information from database, fill the page ---
        //from the data received from database, and sets the datasource of the gridview ----------------------------------
        protected void Page_Load(object sender, EventArgs e)
        {
            BuildName = Request.QueryString["name"];
            Build = database.GetBuild(BuildName);
            FillPage();
            Check();
            GridView1.DataSource = database.GetDataSource(myBuild.BuildName);
            GridView1.DataBind();
        }

        // Sets the datasource for the gridview and binds it -------------------------------------------------------------
        protected void pnlViewBuild_PreRender(object sender,EventArgs e)
        {
            GridView1.DataSource = database.GetDataSource(myBuild.BuildName);
            GridView1.DataBind();
        }

        // A method that rebuilds the page from the data gotten out of the session, it resets the colors of the borders to  -
        // black, then goes through the list<string> and changes the color of the bordercolor to lime for each item in the  -
        // list. ------------------------------------------------------------------------------------------------------------
        private void FillPage()
        {
                foreach (string choice in Build)
                {
                    if (choice == null)
                    {
                        return;
                    }
                    int Choice = Convert.ToInt32(choice);

                    switch (Choice)
                    {
                        //Classes
                        case 1: imgDeathKnight.BorderColor = Color.Lime;
                            break;
                        case 2: imgDruid.BorderColor = Color.Lime;
                            break;
                        case 4: imgMage.BorderColor = Color.Lime;
                            break;
                        case 5: imgMonk.BorderColor = Color.Lime;
                            break;
                        case 6: imgPaladin.BorderColor = Color.Lime;
                            break;
                        case 7: imgPriest.BorderColor = Color.Lime;
                            break;
                        case 3: imgHunter.BorderColor = Color.Lime;
                            break;
                        case 9: imgShaman.BorderColor = Color.Lime;
                            break;
                        case 8: imgRogue.BorderColor = Color.Lime;
                            break;
                        case 11: imgWarrior.BorderColor = Color.Lime;
                            break;
                        case 10: imgWarlock.BorderColor = Color.Lime;
                            break;
                        //Specialization
                        case 12: ImageSpec1.BorderColor = Color.Lime;
                            break;
                        case 13: ImageSpec2.BorderColor = Color.Lime;
                            break;
                        case 14: ImageSpec3.BorderColor = Color.Lime;
                            break;
                        //15
                        case 15: ImageSpell1.BorderColor = Color.Lime;
                            break;
                        case 16: ImageSpell2.BorderColor = Color.Lime;
                            break;
                        case 17: ImageSpell3.BorderColor = Color.Lime;
                            break;
                        //30
                        case 18: ImageSpell4.BorderColor = Color.Lime;
                            break;
                        case 19: ImageSpell5.BorderColor = Color.Lime;
                            break;
                        case 20: ImageSpell6.BorderColor = Color.Lime;
                            break;
                        //45
                        case 21: ImageSpell7.BorderColor = Color.Lime;
                            break;
                        case 22: ImageSpell8.BorderColor = Color.Lime;
                            break;
                        case 23: ImageSpell9.BorderColor = Color.Lime;
                            break;
                        //60
                        case 24: ImageSpell10.BorderColor = Color.Lime;
                            break;
                        case 25: ImageSpell11.BorderColor = Color.Lime;
                            break;
                        case 26: ImageSpell12.BorderColor = Color.Lime;
                            break;
                        //75
                        case 27: ImageSpell13.BorderColor = Color.Lime;
                            break;
                        case 28: ImageSpell14.BorderColor = Color.Lime;
                            break;
                        case 29: ImageSpell15.BorderColor = Color.Lime;
                            break;
                        //90
                        case 30: ImageSpell16.BorderColor = Color.Lime;
                            break;
                        case 31: ImageSpell17.BorderColor = Color.Lime;
                            break;
                        case 32: ImageSpell18.BorderColor = Color.Lime;
                            break;
                        //empty

                    }
                }
            }

        // A method that rebuilds the page from the data gotten out of the session, it resets the colors of the borders to  ----
        // black, then goes through the list<string> and changes the color of the bordercolor to lime for each item in the  ----
        // list. ---------------------------------------------------------------------------------------------------------------
        private void Check()
        {
            int counter = 0;
            foreach (string item in Build)
                {
                    
                    if (myBuild.SelectedClass == null)
                    {
                        myBuild.AddClass(item);
                    }
                    else if (myBuild.SelectedSpec == null)
                    {
                        myBuild.AddSpec(item);
                    }
                    else if (myBuild.SelectedSpells.Count < 7)
                    {
                        myBuild.AddSpell(item,counter);
                        counter++;
                        
                    }

                }
            }

        // A button that resets the instance of build and clears the session, then redirects you back to start.aspx ------------
        protected void btnViewBack_Click(object sender, EventArgs e)
        {
            myBuild.ResetBuild();
            Session.RemoveAll();
            Response.Redirect("http://localhost:2780/Forms/Start.aspx", false);
        }
        }
    }
