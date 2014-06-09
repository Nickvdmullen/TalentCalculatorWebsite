namespace EindopdrachtS22.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Data.OleDb;

    public class DBControl
    {
        private OleDbConnection connection;
        private string accesconnectionstring;

        public DBControl()
        {
            string pad;
            string provider;
            string applicatiepad;


            provider = "Provider=Microsoft.ACE.OLEDB.12.0";

            applicatiepad = HttpContext.Current.Request.PhysicalApplicationPath.Substring(0, HttpContext.Current.Request.PhysicalApplicationPath.LastIndexOf("\\"));

            pad = "Data Source=" + applicatiepad + "\\DataBase11.accdb";

            accesconnectionstring = provider + ";" + pad;

            connection = new OleDbConnection(accesconnectionstring);
        }

        public void Open()
        {
            try
            {
                connection.Open();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Could not connect Database: " + exception.Message);
            }

        }

        public void Close()
        {
            try
            {
                connection.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Could not close Database: " + exception.Message);
            }
        }

        public List<string> GetBuilds()
        {
            Open();
            string sql = "SELECT BuildName FROM [Build]";
            OleDbCommand Command = new OleDbCommand(sql, connection);
            List<string> ReceivedBuilds = new List<string>();
            try
            {
                OleDbDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    string buildName = Convert.ToString(Reader["BuildName"]);

                    ReceivedBuilds.Add(buildName);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Could not execute reader: " + exception);
            }
            Close();
            return ReceivedBuilds;
        }

        public List<string> GetBuild(string BuildName)
        {
            Open();
            string sql = "SELECT * From [BUILD] where Buildname ='" + BuildName + "'";
            OleDbCommand Command = new OleDbCommand(sql, connection);
            List<string> ReceivedBuild = new List<string>();

            try
            {
                OleDbDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    ReceivedBuild.Add(Reader[1].ToString());
                    ReceivedBuild.Add(Reader[2].ToString());
                    ReceivedBuild.Add(Reader[3].ToString());
                    ReceivedBuild.Add(Reader[4].ToString());
                    ReceivedBuild.Add(Reader[5].ToString());
                    ReceivedBuild.Add(Reader[6].ToString());
                    ReceivedBuild.Add(Reader[7].ToString());
                    ReceivedBuild.Add(Reader[8].ToString());
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Could not execute reader: " + exception.Message);
            }
            Close();
            return ReceivedBuild;
        }


        public List<string> GetToolTips(Class Class)
        {
            Open();

            string sql = "SELECT TOOLTIP FROM SPECIALIZATION WHERE CLASSNAME = " + Class.Name;
            OleDbCommand Command = new OleDbCommand(sql, connection);
            List<string> mytooltips = new List<string>();

            try
            {
                OleDbDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    mytooltips.Add(Convert.ToString(Reader["TOOLTIP"]));
                }
            }
            catch
            {

            }
            Close();
            return mytooltips;
        }

        public string GetToolTip(Class Class)
        {
            Open();
            string sql = "SELECT TOOLTIP FROM CLASS WHERE CLASSNAME = " + Class.Name;
            OleDbCommand Command = new OleDbCommand(sql, connection);
            string Tooltip = "";

            try
            {
                OleDbDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    Tooltip = Reader["TOOLTIP"].ToString();
                }
            }
            catch
            {

            }
            return Tooltip;
        }

        public string[] GetSpecialization(Class Class)
        {
            Open();
            string name = Class.Name;
            string sql = "SELECT TOOLTIP FROM SPECIALIZATION WHERE CLASSNAME = " + name;
            OleDbCommand Command = new OleDbCommand(sql, connection);
            string[] mySpecs = new string[3];

            try
            {
                OleDbDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    if (mySpecs[0] == null)
                    {
                        mySpecs[0] = (Convert.ToString(Reader["TOOLTIP"]));
                    }
                    else if (mySpecs[1] == null)
                    {
                        mySpecs[1] = (Convert.ToString(Reader["TOOLTIP"]));
                    }
                    else if (mySpecs[2] == null)
                    {
                        mySpecs[2] = (Convert.ToString(Reader["TOOLTIP"]));
                    }
                }
            }
            catch
            {

            }
            Close();
            return mySpecs;
        }

        public void SaveBuild(Build build)
        {
            Open();
            string Buildname = build.BuildName;
            string Author = build.Author;
            string Class = build.SelectedClass;
            string Spec = build.SelectedSpec;
            string Spell1 = null;
            string Spell2 = null;
            string Spell3 = null;
            string Spell4 = null;
            string Spell5 = null;
            string Spell6 = null;

            foreach (string spell in build.SelectedSpells)
            {
                if (Spell1 == null)
                {
                    Spell1 = spell;
                }
                else if (Spell2 == null)
                {
                    Spell2 = spell;
                }
                else if (Spell3 == null)
                {
                    Spell3 = spell;
                }
                else if (Spell4 == null)
                {
                    Spell4 = spell;
                }
                else if (Spell5 == null)
                {
                    Spell5 = spell;
                }
                else if (Spell6 == null)
                {
                    Spell6 = spell;
                }
            }

            try
            {
                OleDbConnection myconnection = new OleDbConnection(accesconnectionstring);
                /*Command.Parameters.AddWithValue("@BuildName", Buildname);
                Command.Parameters.AddWithValue("@BuildAuthor", Author);
                Command.Parameters.AddWithValue("@Class", Class);
                Command.Parameters.AddWithValue("@Spec", Spec);
                Command.Parameters.AddWithValue("@Spell1", Spell1);
                Command.Parameters.AddWithValue("@Spell2", Spell2);
                Command.Parameters.AddWithValue("@Spell3", Spell3);
                Command.Parameters.AddWithValue("@Spell4", Spell4);
                Command.Parameters.AddWithValue("@Spell5", Spell5);
                Command.Parameters.AddWithValue("@Spell6", Spell6);

                Command.Connection = connection;
                Command.ExecuteNonQuery();*/

                OleDbCommand Command = myconnection.CreateCommand();
                myconnection.Open();
                Command.CommandText = "INSERT INTO Build ([BuildName],[Author],[Class],[Spec],[Spell1],[Spell2],[Spell3],[Spell4],[Spell5],[Spell6])" +
                    "VALUES('" + Buildname + "','" + Author + "','" + Class + "','" + Spec + "','" + Spell1 + "','" + Spell2 + "','" + Spell3 + "','" + Spell4 + "','" + Spell5 + "','" + Spell6 + "')";
                Command.ExecuteNonQuery();
            }
            catch
            {

            }
            Close();
        }

        public List<Comment> GetDataSource(string BuildName)
        {
            Open();
            string sql = "SELECT * FROM COMMENT WHERE BUILDNAME = " + BuildName;
            OleDbCommand Command = new OleDbCommand(sql, connection);
            List<Comment> MyComments = new List<Comment>();
            try
            {
                OleDbDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    Comment newComment = new Classes.Comment();
                    newComment.CommentID = reader[0].ToString();
                    newComment.BuildName = reader[1].ToString();
                    newComment.Comments = reader[2].ToString();
                    MyComments.Add(newComment);
                }
                return MyComments;
            }
            catch
            {
                throw;
            }
            finally
            {
                Close();
            }
        }

    }
}