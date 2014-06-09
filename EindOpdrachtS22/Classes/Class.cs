namespace EindopdrachtS22.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class Class
    {
        Classes.DBControl Database = new Classes.DBControl();

        public string Name { get; private set; }
        public string Tooltip { get; private set; }
        public string imgURL { get; private set; }
        public string[] PossibleSpecs = new string[3];

        public Class(string name)
        {
            this.Name = name;
            this.PossibleSpecs = Database.GetSpecialization(this);
            this.Tooltip = Database.GetToolTip(this);
            
        }


    }
}