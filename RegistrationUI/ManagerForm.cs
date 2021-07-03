using Office_Management_Board.Classes;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Office_Management_Board
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }
        Manager m = new Manager();
        public static string ManagerNid;
        public static string ManagerBrunch;
        static string myconstring = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;

        private void ManagerToHome_Click(object sender, EventArgs e)
        {
            new LogInForm().Show();
            this.Hide();
        }

        private void LogInManagerButton_Click(object sender, EventArgs e)
        {
            login();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            ControlClasses x = new ControlClasses();
            x.SetComboBoxHeight(SignUPManagerBrancheName.Handle,30);
            x.SetComboBoxHeight(LogInManagerBrunchName.Handle, 30);
        }

        private void ManagerSignUpButton_Click(object sender, EventArgs e)
        {
            signup();
        }

        public void signup()
        {
            m.brunchname = SignUPManagerBrancheName.Text;
            m.managername = SignUPManagerName.Text;
            m.managernid = SignUPManagerNID.Text;
            m.password = SignUPManagerPassword.Text;
            bool success = m.insertManager(m);

            if (success == true)
            {
                MessageBox.Show("Sign Up Compleate");
            }
            else
            {
                MessageBox.Show("Sign Up Failed.");
            }
        }

        public void login()
        {
            ManagerNid = LogINManagerNID.Text.Trim();
            ManagerBrunch = LogInManagerBrunchName.Text.Trim();
            SqlConnection conn = new SqlConnection(myconstring);
            string sql = "Select * from Manager Where Brunch_Name = '"+ LogInManagerBrunchName.Text.Trim() + "' and Manager_NID = '" + LogINManagerNID.Text.Trim() + "' and Password = '" + LogInManagerPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                ManagerHomecs mh = new ManagerHomecs();
                this.Visible = false;
                mh.Visible = true;
            }
            else
            {
                MessageBox.Show("Wrong! Nid and Password");
            }
        }


    }
}
