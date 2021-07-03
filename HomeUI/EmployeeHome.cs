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

namespace Office_Management_Board.HomeUI
{
    public partial class EmployeeHome : Form
    {
        public EmployeeHome()
        {
            InitializeComponent();
        }
        Attandence a = new Attandence();
        static string myconstring = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;

        private void EmployeeHome_Load(object sender, EventArgs e)
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
            }
            catch (Exception)
            {

            }
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            add();

        }

        public void reload()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM EmployeeAttendence WHERE Employee_NID = '" + EmployeeForm.EmployeeNid + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            EmployeeAttandanceGrid.DataSource = dt;
        }

        public bool PevDate()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            string sql = "Select * from EmployeeAttendence Where Date = '" + DateTime.Now.ToShortDateString() + "' and Employee_NID = '" + EmployeeForm.EmployeeNid + "'";
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
            a.EmployeeNid = EmployeeForm.EmployeeNid;
            a.status = "true";

            bool success = a.insertEmployeeAttandence(a);

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

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LogInForm().ShowDialog();
        }
    }
}
