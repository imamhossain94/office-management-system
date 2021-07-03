using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Office_Management_Board.Classes
{
    class Employee
    {
        public string brunchname { get; set; }
        public string employeename { get; set; }
        public string employeenid { get; set; }
        public string password { get; set; }

        static string myconstring = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;

        public bool insertEmployee(Employee log)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconstring);

            string sql = "INSERT INTO Employee(Employee_NID,Brunch_Name,Employee_Name,Password) values(@ENID,@BN,@EN,@PASS)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@BN", log.brunchname);
            cmd.Parameters.AddWithValue("@EN", log.employeename);
            cmd.Parameters.AddWithValue("@ENID", log.employeenid);
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
