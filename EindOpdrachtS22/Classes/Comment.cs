namespace EindopdrachtS22.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    
    public class Comment
    {
        // Creates an instance of the class DBControl --------------------------------------------------------------------
        DBControl database = new DBControl();

        //Public attributes of this class --------------------------------------------------------------------------------
        public string CommentID { get; set; }
        public string BuildName { get; set; }
        public string Comments  { get; set; }
        
        //The constructor of this class ----------------------------------------------------------------------------------
        public Comment()
        {

        }

        // A method for sending the comment to the database --------------------------------------------------------------
        private void SendComment(string id,string buildname ,string comment)
        {
            database.addComment(id, buildname, comment);
        }

    }
}