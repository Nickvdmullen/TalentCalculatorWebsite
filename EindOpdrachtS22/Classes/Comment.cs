namespace EindopdrachtS22.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    
    public class Comment
    {
        public string CommentID { get; set; }
        public string BuildName { get; set; }
        public string Comments { get; set; }
        

        public Comment()
        {
            
        }

        private void SendComment()
        {
            // Send insert to Database;
        }

    }
}