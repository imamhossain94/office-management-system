using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Office_Management_Board.Classes
{
    class Manager
    {
        public string brunchname { get; set; }
        public string managername { get; set; }
        public string managernid { get; set; }
        public string password { get; set; }

        static string myconstring = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;

        public bool insertManager(Manager log)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconstring);

            string sql = "INSERT INTO Manager(Manager_NID,Brunch_Name,Manager_Name,Password) values(@MNID,@BN,@MN,@PASS)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@BN", log.brunchname);
            cmd.Parameters.AddWithValue("@MN", log.managername);
            cmd.Parameters.AddWithValue("@MNID", log.managernid);
            cmd.Parameters.AddWithValue("@PASS", log.password);
            
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
