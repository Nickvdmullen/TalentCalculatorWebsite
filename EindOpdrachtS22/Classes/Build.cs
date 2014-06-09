namespace EindopdrachtS22.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class Build
    {
        Classes.DBControl Database = new Classes.DBControl();

        public string BuildName { get; private set; }
        public string Author { get; private set; }
        public string SelectedClass { get; private set; }
        public string SelectedSpec { get; private set; }
        public List<string> SelectedSpells { get; private set; }

        public Build()
        {
            SelectedSpells = new List<string>();
        }

        public List<string> UpdateBuild()
        {
            List<string> returnBuild = new List<string>();
            returnBuild.Add(SelectedClass);
            returnBuild.Add(SelectedSpec);
            returnBuild.AddRange(SelectedSpells);
            return returnBuild;
        }

        public void AddClass(string name)
        {
            this.SelectedClass = name;
        }

        public void AddSpec(string Spec)
        {
            this.SelectedSpec = Spec;
        }

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

        public void ResetBuild()
        {
            this.SelectedClass = "";
            this.SelectedSpec = "";
            this.SelectedSpells.Clear();
            this.SelectedSpells.Add("");
        }

        public void AddNames(string name,string author)
        {
            this.BuildName = name;
            this.Author = author;
        }
        public void SaveBuild()
        {
            Database.SaveBuild(this);
        }

    }
}