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
    public partial class AdminChoice : Form
    {
        public AdminChoice()
        {
            InitializeComponent();
        }
        Projects p = new Projects();
        public static string ManagerNid;
        public static string ManagerBrunch;
        static string myconstring = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;


        public void InsertNewProject()
        {
            p.title = ProjectTitle.Text.Trim();
            p.description = ProjectDescription.Text.Trim();
            p.tag = ProjectTAg.Text.Trim();
            p.duration = ProjectDuration.Text.Trim();

            bool success = p.insertProject(p);

            if (success == true)
            {
                MessageBox.Show("Project Added");
            }
            else
            {
                MessageBox.Show("Try Again! Failed");
            }
        }

        public void UpdateOnGoingProject()
        {
            p.title = ModifyTitle.Text.Trim();
            p.description = ModifyDescription.Text.Trim();
            p.tag = ModifyTag.Text.Trim();
            p.duration = ModifyProjectDuration.Text.Trim();
            bool success = p.updateProject(p);

            if (success == true)
            {
                MessageBox.Show("Projects info. Updated!");
            }
            else
            {
                MessageBox.Show("Try Again! Failed.");
            }
        }


        private void AddProjectButton_Click(object sender, EventArgs e)
        {
            InsertNewProject();
        }

        private void AdminChoice_Load(object sender, EventArgs e)
        {
            //ModifyProjectDuration.Text = "Completing Date: " + DateTime.Now.ToShortDateString() + "";
            NewProjects();
            AllProjects();
        }
        public void NewProjects()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Projects WHERE ManagerNID = '" + ManagerForm.ManagerNid + "' and Status='OnGoing'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            NewProjectGrid.DataSource = dt;
        }

        public void AllProjects()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Projects WHERE ManagerNID = '" + ManagerForm.ManagerNid + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            AllProjectPrid.DataSource = dt;
        }

        private void AllProjectPrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        { 
            int rowIndex = e.RowIndex;

            ModifyTitle.Text = AllProjectPrid.Rows[rowIndex].Cells[1].Value.ToString();
            ModifyDescription.Text = AllProjectPrid.Rows[rowIndex].Cells[2].Value.ToString();
            ModifyTag.Text = AllProjectPrid.Rows[rowIndex].Cells[3].Value.ToString();
            ModifyProjectDuration.Text = AllProjectPrid.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void ConfirmModificationButton_Click(object sender, EventArgs e)
        {
            UpdateOnGoingProject();
        }


    }
}
