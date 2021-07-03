using Office_Management_Board.Classes;
using Office_Management_Board.HomeUI;
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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }
        Employee e = new Employee();
        public static string EmployeeNid, BrunchName;
        static string myconstring = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;

        private void EmployeeToHome_Click(object sender, EventArgs e)
        {
            new LogInForm().Show();
            this.Hide();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            ControlClasses x = new ControlClasses();
            x.SetComboBoxHeight(SignUPEmployeeBrancheName.Handle, 30);
            x.SetComboBoxHeight(LogInEmployeeBrunchName.Handle, 30);
        }

        private void EmployeeSignUpButton_Click(object sender, EventArgs e)
        {
            signup();
        }

        public void signup()
        {
            e.brunchname = SignUPEmployeeBrancheName.Text.Trim();
            e.employeename = EmployeeSignUpUsernameBox.Text.Trim();
            e.employeenid = EmployeeSignUpNID.Text.Trim();
            e.password = EmployeeSignUpPasswordBox.Text.Trim();
            bool success = e.insertEmployee(e);

            if (success == true)
            {
                MessageBox.Show("Sign Up Compleate");
            }
            else
            {
                MessageBox.Show("Sign Up Failed.");
            }
        }

        private void EmployeeLogInButton_Click(object sender, EventArgs e)
        {
            login();
        }

        public void login()
        {
            EmployeeNid = EmployeeLogInNid.Text.Trim();
            BrunchName = LogInEmployeeBrunchName.Text.Trim();
            SqlConnection conn = new SqlConnection(myconstring);
            string sql = "Select * from Employee Where Brunch_Name = '" + LogInEmployeeBrunchName.Text.Trim() + "' and Employee_NID = '" + EmployeeLogInNid.Text.Trim() + "' and Password = '" + EmployeeLogInPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                EmployeeHome eh = new EmployeeHome();
                this.Visible = false;
                eh.Visible = true;
            }
            else
            {
                MessageBox.Show("Wrong! Nid and Password");
            }
        }
    }
}
