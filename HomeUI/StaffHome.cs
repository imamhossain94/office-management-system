using Office_Management_Board.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Office_Management_Board.AttendenceUI
{
    public partial class StaffHome : Form
    {
        public StaffHome()
        {
            InitializeComponent();
        }
        Attandence a = new Attandence();
        static string myconstring = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;

        private void StaffHome_Load(object sender, EventArgs e)
        {
            dateTime.Text = DateTime.Now.ToShortDateString();
            try
            {
                if (PevDate() == false)
                {
                    CheckButton.Enabled = true;
                }
                else
                {
                    CheckButton.Enabled = false;
                }
                reload();
            }catch(Exception)
            {

            }
            
        }

        public void reload()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM StaffAttendence WHERE Staff_NID = '" + StaffForm.StaffNid + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            StaffAttandanceGrid.DataSource = dt;
        }

        public bool PevDate()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            string sql = "Select * from StaffAttendence Where Date = '" + DateTime.Now.ToShortDateString() + "' and Staff_NID = '" + StaffForm.StaffNid + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                 return true;
            }
            else
            {
                return false;
            }
        }


        public void add()
        {
            a.StaffNid = StaffForm.StaffNid;
            a.status = "true";

            bool success = a.insertStaffAttandence(a);

            if (success == true)
            {
                CheckButton.Enabled = false;
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("Try Again!");
            }
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            add();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LogInForm().ShowDialog();
        }
    }
}
