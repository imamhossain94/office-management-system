using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Office_Management_Board.Classes
{
    class Projects
    {
        public string title { get; set; }
        public string description { get; set; }
        public string tag { get; set; }
        public string duration { get; set; }
        public string status { get; set; }

        static string myconstring = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;

        public bool insertProject(Projects log)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconstring);

            string sql = "INSERT INTO Projects(ManagerNID,Title,Description,Tag,Duration,Status,StartingTime) values(@ManagerNID,@title,@description,@tag,@duration,@status,@StartingTime)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ManagerNID", ManagerForm.ManagerNid);
            cmd.Parameters.AddWithValue("@title", log.title);
            cmd.Parameters.AddWithValue("@description", log.description);
            cmd.Parameters.AddWithValue("@tag", log.tag);
            cmd.Parameters.AddWithValue("@duration", log.duration);
            cmd.Parameters.AddWithValue("@status", "OnGoing");
            cmd.Parameters.AddWithValue("@StartingTime", DateTime.Now.ToShortDateString());

            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                success = true;
            }
            else
            {
                success = false;
            }
            conn.Close();
            return success;
        }

        public bool updateProject(Projects log)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconstring);

            string sql = "UPDATE Projects SET ManagerNID=@ManagerNID,Title=@title,Description=@description,Tag=@tag,Duration=@duration,Status=@status,EndTime=@EndTime where Title=@title";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ManagerNID", ManagerForm.ManagerNid);
            cmd.Parameters.AddWithValue("@title", log.title);
            cmd.Parameters.AddWithValue("@description", log.description);
            cmd.Parameters.AddWithValue("@tag", log.tag);
            cmd.Parameters.AddWithValue("@duration", log.duration);
            cmd.Parameters.AddWithValue("@status", "OK");
            cmd.Parameters.AddWithValue("@EndTime", DateTime.Now.ToShortDateString());

            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                success = true;
            }
            else
            {
                success = false;
            }
            conn.Close();
            return success;
        }




    }
}
