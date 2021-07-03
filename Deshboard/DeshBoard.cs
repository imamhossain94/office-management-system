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
    public partial class DeshBoard : Form
    {
        public DeshBoard()
        {
            InitializeComponent();
        }
        static string myconstring = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;


        public void CompleteProject()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Projects WHERE ManagerNID = '" + ManagerForm.ManagerNid + "' and Status='OK'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CompleteProjectDataGrid.DataSource = dt;
        }

        public void OnGoingProject()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Projects WHERE ManagerNID = '" + ManagerForm.ManagerNid + "' and Status='OnGoing'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            OnGoingProjectDataGrid.DataSource = dt;
        }

        private void DeshBoard_Load(object sender, EventArgs e)
        {
            CompleteProject();
            OnGoingProject();
        }
    }
}
