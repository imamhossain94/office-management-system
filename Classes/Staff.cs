using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Office_Management_Board.Classes
{
    class Staff
    {
        public string brunchname { get; set; }
        public string staffname { get; set; }
        public string staffnid { get; set; }
        public string password { get; set; }

        static string myconstring = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;

        public bool insertStaff(Staff log)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconstring);

            string sql = "INSERT INTO Staff(Staff_NID,Brunch_Name,Staff_Name,Password) values(@SNID,@BN,@SN,@PASS)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@BN", log.brunchname);
            cmd.Parameters.AddWithValue("@SN", log.staffname);
            cmd.Parameters.AddWithValue("@SNID", log.staffnid);
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
