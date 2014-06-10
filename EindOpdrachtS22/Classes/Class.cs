namespace EindopdrachtS22.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class Class
    {
        // creates an instance of the class DBControl --------------------------------------------------------------------
        Classes.DBControl Database = new Classes.DBControl();

        // Public attributes of this instance ----------------------------------------------------------------------------
        public string Name { get; private set; }
        public string Tooltip { get; private set; }
        public string imgURL { get; private set; }
        public string[] PossibleSpecs = new string[3];


        // The constructor of this class ---------------------------------------------------------------------------------
        public Class(string name)
        {
            this.Name = name;
            this.PossibleSpecs = Database.GetSpecialization(this);
            this.Tooltip = Database.GetToolTip(this);
            
        }


    }
}