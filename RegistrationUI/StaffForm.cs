using Office_Management_Board.AttendenceUI;
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

namespace Office_Management_Board
{
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }
        Staff s = new Staff();
        public static string StaffNid, BrunchName;
        static string myconstring = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;

        private void StaffToHome_Click(object sender, EventArgs e)
        {
            new LogInForm().Show();
            this.Hide();
        }

        private void StaffSignUpButton_Click(object sender, EventArgs e)
        {
            signup();
        }

        public void signup()
        {
            s.brunchname = StaffSignUpBrunchname.Text.Trim();
            s.staffname = StaffSignUpUsernameBox.Text.Trim();
            s.staffnid = StaffSignUpNid.Text.Trim();
            s.password = StaffSignUpPasswordBox.Text.Trim();

            bool success = s.insertStaff(s);

            if (success == true)
            {
                MessageBox.Show("Compleate");
            }
            else
            {
                MessageBox.Show("Sign Up Failed.");
            }
        }

        private void StaffLogInButton_Click(object sender, EventArgs e)
        {
            login();
        }

        public void login()
        {
            StaffNid = StaffLoginNid.Text.Trim();
            BrunchName = StaffLogInBrunchname.Text.Trim();
            SqlConnection conn = new SqlConnection(myconstring);
            string sql = "Select * from Staff Where Brunch_Name = '" + StaffLogInBrunchname.Text.Trim() + "' and Staff_NID = '" + StaffLoginNid.Text.Trim() + "' and Password = '" + StaffLogInPasswordBox.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                StaffHome sh = new StaffHome();
                this.Visible = false;
                sh.Visible = true;
            }
            else
            {
                MessageBox.Show("Wrong! Nid and Password");
            }
        }


    }
}
