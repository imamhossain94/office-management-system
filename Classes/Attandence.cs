using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Office_Management_Board.Classes
{
    class Attandence
    {

        public string status { get; set; }
        public string EmployeeNid { get; set; }
        public string StaffNid { get; set; }

        static string myconstring = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;

        public bool insertStaffAttandence(Attandence log)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconstring);

            string sql = "INSERT INTO StaffAttendence(Date,Staff_NID,Status,Time,Brunch_Name) values(@Date,@StaffNid,@Status,@Time,@BN)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Date", DateTime.Now.ToShortDateString());
            cmd.Parameters.AddWithValue("@Status", log.status);
            cmd.Parameters.AddWithValue("@Time", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@StaffNid", log.StaffNid);//Brunch_Name
            cmd.Parameters.AddWithValue("@BN", StaffForm.BrunchName);

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

        public bool insertEmployeeAttandence(Attandence log)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconstring);

            string sql = "INSERT INTO EmployeeAttendence(Date,Employee_NID,Status,Time,Brunch_Name) values(@Date,@EmployeeNid,@Status,@Time,@BN)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Date", DateTime.Now.ToShortDateString());
            cmd.Parameters.AddWithValue("@Status", log.status);
            cmd.Parameters.AddWithValue("@Time", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@EmployeeNid", log.EmployeeNid);
            cmd.Parameters.AddWithValue("@BN", EmployeeForm.BrunchName);

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
