namespace EindopdrachtS22.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class Build
    {
        // creates an instance of the DBControl class ----------------------------------------------------------------------
        Classes.DBControl Database = new Classes.DBControl();

        // public attributes -----------------------------------------------------------------------------------------------
        public string BuildName { get; private set; }
        public string Author { get; private set; }
        public string SelectedClass { get; private set; }
        public string SelectedSpec { get; private set; }
        public List<string> SelectedSpells { get; private set; }


        // Constructor of this class ---------------------------------------------------------------------------------------
        public Build()
        {
            SelectedSpells = new List<string>();
        }

        // A method that returns the data that is currently in this instance -----------------------------------------------
        public List<string> UpdateBuild()
        {
            List<string> returnBuild = new List<string>();
            returnBuild.Add(SelectedClass);
            returnBuild.Add(SelectedSpec);
            returnBuild.AddRange(SelectedSpells);
            return returnBuild;
        }


        // A method for adding a selection to this instance -----------------------------------------------------------------
        public void AddClass(string name)
        {
            this.SelectedClass = name;
        }

        // A method for adding a selection to this instance -----------------------------------------------------------------
        public void AddSpec(string Spec)
        {
            this.SelectedSpec = Spec;
        }

        // A method for adding a spell and puts it in the correct position in the list  --------------------------------------
        // There is a 0 for security so it doesn't give a null error when run for the first time -----------------------------
        public void AddSpell(string spell, int position)
        {
            switch(position)
            {
                case 0:   SelectedSpells.Add("0");
                          SelectedSpells[0] = spell;
                          break;
                case 1: SelectedSpells.Add("0");
                          SelectedSpells[1] = spell;
                          break;
                case 2: SelectedSpells.Add("0");
                          SelectedSpells[2] = spell;
                          break;
                case 3: SelectedSpells.Add("0");
                          SelectedSpells[3] = spell;
                          break;
                case 4: SelectedSpells.Add("0");
                          SelectedSpells[4] = spell;
                          break;
                case 5: SelectedSpells.Add("0");
                          SelectedSpells[5] = spell;
                          break;
            }
       }

        // A method that resets this instance --------------------------------------------------------------------------------
        public void ResetBuild()
        {
            this.SelectedClass = "";
            this.SelectedSpec = "";
            this.SelectedSpells.Clear();
            this.SelectedSpells.Add("");
        }

        // A method that adds Buildname and the author's name to the instance ------------------------------------------------
        public void AddNames(string name,string author)
        {
            this.BuildName = name;
            this.Author = author;
        }

        // A method that save this instance to the database ------------------------------------------------------------------
        public void SaveBuild()
        {
            Database.SaveBuild(this);
        }

    }
}