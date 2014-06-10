namespace EindOpdrachtS22.Forms
{
    using EindopdrachtS22.Classes;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class FormCreate : System.Web.UI.Page
    {
        // Creates and instance of build ---------------------------------------------------------------------------------
        Build myBuild = new Build();

        // Loads pages ---------------------------------------------------------------------------------------------------
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // All buttons named ibtnName create an instance of the class Class, get the tooltips from the database, adds the -
        // selection to the instance of Build, adds it in the session and as last point triggers the method for rebuilding-
        // the page with the new changes made -----------------------------------------------------------------------------

        protected void ibtnDeathKnight_Click(object sender, ImageClickEventArgs e)
        {
            Class DeathKnight = new Class("1");
            SetToolTips(DeathKnight.PossibleSpecs);
            ibtnDeathKnight.ToolTip = DeathKnight.Tooltip;
            myBuild.AddClass(DeathKnight.Name);
            Session.Add("Build", myBuild.UpdateBuild());
            FillPage();
        }
     
        protected void ibtnDruid_Click(object sender, ImageClickEventArgs e)
        {
            Class Druid = new Class("2");
            SetToolTips(Druid.PossibleSpecs);
            ibtnDruid.ToolTip = Druid.Tooltip;
            myBuild.AddClass(Druid.Name);
            Session.Add("Build",myBuild.UpdateBuild());
            FillPage();
        }

        protected void ibtnHunter_Click(object sender, ImageClickEventArgs e)
        {
            Class Hunter = new Class("3");
            SetToolTips(Hunter.PossibleSpecs);
            ibtnDruid.ToolTip = Hunter.Tooltip;
            myBuild.AddClass(Hunter.Name);
            Session.Add("Build", myBuild.UpdateBuild());
            FillPage();
        }

        protected void ibtnMage_Click(object sender, ImageClickEventArgs e)
        {
            Class Mage = new Class("4");
            SetToolTips(Mage.PossibleSpecs);
            ibtnDruid.ToolTip = Mage.Tooltip;
            myBuild.AddClass(Mage.Name);
            Session.Add("Build", myBuild.UpdateBuild());
            FillPage();
        }

        protected void ibtnMonk_Click(object sender, ImageClickEventArgs e)
        {
            Class Monk = new Class("5");
            SetToolTips(Monk.PossibleSpecs);
            ibtnDruid.ToolTip = Monk.Tooltip;
            myBuild.AddClass(Monk.Name);
            Session.Add("Build", myBuild.UpdateBuild());
            FillPage();
        }

        protected void ibtnPaladin_Click(object sender, ImageClickEventArgs e)
        {
            Class Paladin = new Class("6");
            SetToolTips(Paladin.PossibleSpecs);
            ibtnDruid.ToolTip = Paladin.Tooltip;
            myBuild.AddClass(Paladin.Name);
            Session.Add("Build", myBuild.UpdateBuild());
            FillPage();
        }

        protected void ibtnPriest_Click(object sender, ImageClickEventArgs e)
        {
            Class Priest = new Class("7");
            SetToolTips(Priest.PossibleSpecs);
            ibtnDruid.ToolTip = Priest.Tooltip;
            myBuild.AddClass(Priest.Name);
            Session.Add("Build", myBuild.UpdateBuild());
            FillPage();
        }

        protected void ibtnRogue_Click(object sender, ImageClickEventArgs e)
        {
            Class Rogue = new Class("8");
            SetToolTips(Rogue.PossibleSpecs);
            ibtnDruid.ToolTip = Rogue.Tooltip;
            myBuild.AddClass(Rogue.Name);
            Session.Add("Build", myBuild.UpdateBuild());
            FillPage();
        }

        protected void ibtnShaman_Click(object sender, ImageClickEventArgs e)
        {
            Class Shaman = new Class("9");
            SetToolTips(Shaman.PossibleSpecs);
            ibtnDruid.ToolTip = Shaman.Tooltip;
            myBuild.AddClass(Shaman.Name);
            Session.Add("Build", myBuild.UpdateBuild());
            FillPage();
        }

        protected void ibtnWarlock_Click(object sender, ImageClickEventArgs e)
        {
            Class Warlock = new Class("10");
            SetToolTips(Warlock.PossibleSpecs);
            ibtnDruid.ToolTip = Warlock.Tooltip;
            myBuild.AddClass(Warlock.Name);
            Session.Add("Build", myBuild.UpdateBuild());
            FillPage();
        }

        protected void ibtnWarrior_Click(object sender, ImageClickEventArgs e)
        {
            Class Warrior = new Class("11");
            SetToolTips(Warrior.PossibleSpecs);
            ibtnWarrior.ToolTip = Warrior.Tooltip;
            myBuild.AddClass(Warrior.Name);
            Session.Add("Build", myBuild.UpdateBuild());
            FillPage();
        }
        // All buttons named ibtnSpec use the method Check, add the selected spec to the instance of Build,adds it to the-------
        // session, and calls the method that rebuilds the webpage with changes made. ------------------------------------------

        protected void ibtnSpec1_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpec("12");
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpec2_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpec("13");
            Session.Add("Build", myBuild.UpdateBuild());
            FillPage();
        }

        protected void ibtnSpec3_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpec("14");
            Session.Add("Build", myBuild.UpdateBuild());
            FillPage();
        }


        // All buttons below here that have the name ibtnSpell# calls the method check, adds de selected spell to the instance -
        // from Build at the correct position,adds it to the session and calls the method to rebuild the pages with the new    -
        // changes. ------------------------------------------------------------------------------------------------------------
        protected void ibtnSpell1_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("15",0);
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell2_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("16",0);
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell3_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("17",0);
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell4_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("18",1);
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell5_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("19",1);
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell6_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("20",1);
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell7_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("21",2);
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell8_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("22",2);
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell9_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("23",2);
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell10_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("24",3);
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell11_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("25",3);
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell12_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("26",3);
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();

        }

        protected void ibtnSpell13_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("27",4);
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell14_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("28",4);
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell15_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("29",4);
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell16_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("30",5);
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell17_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("31",5);
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell18_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("32",5);
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        // Gets a string[] and sets the tooltips of the specbuttons to the text within the array. ------------------------------
        private void SetToolTips(string[] specs)
        {
            ibtnSpec1.ToolTip = specs[0];
            ibtnSpec2.ToolTip = specs[1];
            ibtnSpec3.ToolTip = specs[2];
        }


        // A method that checks session that the instance of Build has the correct spec loaded in it ---------------------------
        private void Check()
        {
            if (Session["Build"] != null)
            {
                List<string> Choices = (List<string>)Session["Build"];
                int counter = 0;
                foreach (string item in Choices)
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
        }

        // A method that rebuilds the page from the data gotten out of the session, it resets the colors of the borders to  ----
        // black, then goes through the list<string> and changes the color of the bordercolor to lime for each item in the  ----
        // list. ---------------------------------------------------------------------------------------------------------------
        private void FillPage()
        {

            List<string> Build = (List<string>)Session["Build"];

            if (Session["Build"] != null)
            {
                ibtnDeathKnight.BorderColor = Color.Black;
                ibtnDruid.BorderColor = Color.Black;
                ibtnRogue.BorderColor = Color.Black;
                ibtnMage.BorderColor = Color.Black;
                ibtnMonk.BorderColor = Color.Black;
                ibtnPriest.BorderColor = Color.Black;
                ibtnHunter.BorderColor = Color.Black;
                ibtnShaman.BorderColor = Color.Black;
                ibtnWarlock.BorderColor = Color.Black;
                ibtnWarrior.BorderColor = Color.Black;
                ibtnPaladin.BorderColor = Color.Black;

                ibtnSpec1.BorderColor = Color.Black;
                ibtnSpec2.BorderColor = Color.Black;
                ibtnSpec3.BorderColor = Color.Black;

                ibtnSpell1.BorderColor = Color.Black;
                ibtnSpell2.BorderColor = Color.Black;
                ibtnSpell3.BorderColor = Color.Black;

                ibtnSpell4.BorderColor = Color.Black;
                ibtnSpell5.BorderColor = Color.Black;
                ibtnSpell6.BorderColor = Color.Black;

                ibtnSpell7.BorderColor = Color.Black;
                ibtnSpell8.BorderColor = Color.Black;
                ibtnSpell9.BorderColor = Color.Black;

                ibtnSpell10.BorderColor = Color.Black;
                ibtnSpell11.BorderColor = Color.Black;
                ibtnSpell12.BorderColor = Color.Black;

                ibtnSpell13.BorderColor = Color.Black;
                ibtnSpell14.BorderColor = Color.Black;
                ibtnSpell15.BorderColor = Color.Black;

                ibtnSpell16.BorderColor = Color.Black;
                ibtnSpell17.BorderColor = Color.Black;
                ibtnSpell18.BorderColor = Color.Black;

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
                        case 1: ibtnDeathKnight.BorderColor = Color.Lime;
                            break;
                        case 2: ibtnDruid.BorderColor = Color.Lime;
                            break;
                        case 4: ibtnMage.BorderColor = Color.Lime;
                            break;
                        case 5: ibtnMonk.BorderColor = Color.Lime;
                            break;
                        case 6: ibtnPaladin.BorderColor = Color.Lime;
                            break;
                        case 7: ibtnPriest.BorderColor = Color.Lime;
                            break;
                        case 3: ibtnHunter.BorderColor = Color.Lime;
                            break;
                        case 9: ibtnShaman.BorderColor = Color.Lime;
                            break;
                        case 8: ibtnRogue.BorderColor = Color.Lime;
                            break;
                        case 11: ibtnWarrior.BorderColor = Color.Lime;
                            break;
                        case 10: ibtnWarlock.BorderColor = Color.Lime;
                            break;
                        //Specialization
                        case 12: ibtnSpec1.BorderColor = Color.Lime;
                            break;
                        case 13: ibtnSpec2.BorderColor = Color.Lime;
                            break;
                        case 14: ibtnSpec3.BorderColor = Color.Lime;
                            break;
                        //15
                        case 15: ibtnSpell1.BorderColor = Color.Lime;
                            break;
                        case 16: ibtnSpell2.BorderColor = Color.Lime;
                            break;
                        case 17: ibtnSpell3.BorderColor = Color.Lime;
                            break;
                        //30
                        case 18: ibtnSpell4.BorderColor = Color.Lime;
                            break;
                        case 19: ibtnSpell5.BorderColor = Color.Lime;
                            break;
                        case 20: ibtnSpell6.BorderColor = Color.Lime;
                            break;
                        //45
                        case 21: ibtnSpell7.BorderColor = Color.Lime;
                            break;
                        case 22: ibtnSpell8.BorderColor = Color.Lime;
                            break;
                        case 23: ibtnSpell9.BorderColor = Color.Lime;
                            break;
                        //60
                        case 24: ibtnSpell10.BorderColor = Color.Lime;
                            break;
                        case 25: ibtnSpell11.BorderColor = Color.Lime;
                            break;
                        case 26: ibtnSpell12.BorderColor = Color.Lime;
                            break;
                        //75
                        case 27: ibtnSpell13.BorderColor = Color.Lime;
                            break;
                        case 28: ibtnSpell14.BorderColor = Color.Lime;
                            break;
                        case 29: ibtnSpell15.BorderColor = Color.Lime;
                            break;
                        //90
                        case 30: ibtnSpell16.BorderColor = Color.Lime;
                            break;
                        case 31: ibtnSpell17.BorderColor = Color.Lime;
                            break;
                        case 32: ibtnSpell18.BorderColor = Color.Lime;
                            break;
                        //empty

                    }
                }
            }
        }

        // A button that adds the Buildname and authorsname to the instance of Build and saves the build you made to the    ----
        // database ------------------------------------------------------------------------------------------------------------
        protected void btnSave_Click(object sender, EventArgs e)
        {
            myBuild.AddNames(txtBuildName.Text, txtBuildAuthor.Text);
            Check();
            myBuild.SaveBuild();
        }


        // A button that resets Build, empties the session and returns you to the form Start.aspx ------------------------------
        protected void btnBack_Click(object sender, EventArgs e)
        {
            myBuild.ResetBuild();
            Session.RemoveAll();
            Response.Redirect("http://localhost:2780/Forms/Start.aspx",false);
        }

    }
}