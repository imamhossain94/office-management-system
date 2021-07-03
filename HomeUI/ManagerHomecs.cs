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
    public partial class ManagerHomecs : Form
    {
        public ManagerHomecs()
        {
            InitializeComponent();
        }

        static string myconstring = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        public static int size, size2;
        public int[] Array, Array2;

        public void GetFormInPanel(object FormInP)
        {
            if (this.GetFromInPanel.Controls.Count > 0)
                this.GetFromInPanel.Controls.RemoveAt(0);
            Form fh = FormInP as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.GetFromInPanel.Controls.Add(fh);
            this.GetFromInPanel.Tag = fh;
            fh.Show();
        }
        private void ManagerToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LogInForm().ShowDialog();
        }

        private void ProjectPic_Click(object sender, EventArgs e)
        {
            GetFormInPanel(new DeshBoard());
        }

        private void AdminChoicePic_Click(object sender, EventArgs e)
        {
            GetFormInPanel(new AdminChoice());
        }

        private int countEmployee()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Employee where Brunch_Name='" + ManagerForm.ManagerBrunch + "'");
            cmd.Connection = conn;
            conn.Open();
            object fn1 = cmd.ExecuteScalar();
            conn.Close();
            int fn = Convert.ToInt32(fn1);
            return fn;
        }

        private int countEmployeeAttandence()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM EmployeeAttendence where Brunch_Name='" + ManagerForm.ManagerBrunch + "' and Date='" + DateTime.Now.ToShortDateString() + "'");
            cmd.Connection = conn;
            conn.Open();
            object fn1 = cmd.ExecuteScalar();
            conn.Close();
            int fn = Convert.ToInt32(fn1);
            return fn;
        }

        private int countStaff()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Staff where Brunch_Name='" + ManagerForm.ManagerBrunch + "'");
            cmd.Connection = conn;
            conn.Open();
            object fn1 = cmd.ExecuteScalar();
            conn.Close();
            int fn = Convert.ToInt32(fn1);
            return fn;
        }

        private int countStaffAttandence()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM StaffAttendence where Brunch_Name='" + ManagerForm.ManagerBrunch + "' and Date='" + DateTime.Now.ToShortDateString() + "'");
            cmd.Connection = conn;
            conn.Open();
            object fn1 = cmd.ExecuteScalar();
            conn.Close();
            int fn = Convert.ToInt32(fn1);
            return fn;
        }

        private int countProject()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Projects where ManagerNID='" + ManagerForm.ManagerNid + "'");
            cmd.Connection = conn;
            conn.Open();
            object fn1 = cmd.ExecuteScalar();
            conn.Close();
            int fn = Convert.ToInt32(fn1);
            return fn;
        }

        private int countOnProject()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Projects where ManagerNID='" + ManagerForm.ManagerNid + "' and Status='OnGoing'");
            cmd.Connection = conn;
            conn.Open();
            object fn1 = cmd.ExecuteScalar();
            conn.Close();
            int fn = Convert.ToInt32(fn1);
            return fn;
        }

        private int countCompProject()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Projects where ManagerNID='" + ManagerForm.ManagerNid + "' and Status='OK'");
            cmd.Connection = conn;
            conn.Open();
            object fn1 = cmd.ExecuteScalar();
            conn.Close();
            int fn = Convert.ToInt32(fn1);
            return fn;
        }
        
        //Load Employee----------------------------Dinamicaly----

        public int AllEmployee()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("select ID from Employee where Brunch_Name='" + ManagerForm.ManagerBrunch + "'");
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                Array[i] = Convert.ToInt32(reader.GetValue(0));
                i++;
            }
            reader.Close();
            int count = 0;
            for (i = 0; i < Array.Length; i++)
            {
                if (Array[i] < 0)
                    count++;
            }
            return count;
        }

        public string EmpName(int i)
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd1 = new SqlCommand("Select Employee_Name from Employee Where Brunch_Name='" + ManagerForm.ManagerBrunch + "' and ID='"+i+"'");
            cmd1.Connection = conn;
            conn.Open();
            string val1 = (string)cmd1.ExecuteScalar();
            conn.Close();
            return val1;
        }

        


        Panel CreatePanel(int i)
        {
            Panel p = new Panel();
            //p.Controls.Add(CreateButton(i));
            //p.Controls.Add(CreateLabel(i));
            //be.ApplyElipse(p, 10);
            p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            //p.Location = new System.Drawing.Point(10, 10);
            //p.BackColor = Color.Brown;
            p.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            p.Name = "add_tenant_pnl" + i;
            p.Text = EmpName(i);
            p.Size = new System.Drawing.Size(220, 47);
            p.TabIndex = 0;
            return p;
        }

        Label CreateLabel(int i)
        {
            Label p = new Label();
            p.Size = new System.Drawing.Size(100, 30);
            p.Cursor = System.Windows.Forms.Cursors.Hand;
            p.Font = new System.Drawing.Font("Dosis", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            p.ForeColor = System.Drawing.Color.White;
            p.Location = new System.Drawing.Point( 5, 5);
            p.Name = "add_tenant_lbl" + i;
            p.Size = new System.Drawing.Size(200, 30);
            p.TabIndex = 51;
            p.Text = EmpName(i);
            p.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            return p;
        }

        //Load Staff----------------------------Dinamicaly----

        public int AllStaff()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("select ID from Staff where Brunch_Name='" + ManagerForm.ManagerBrunch + "'");
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                Array2[i] = Convert.ToInt32(reader.GetValue(0));
                i++;
            }
            reader.Close();
            int count = 0;
            for (i = 0; i < Array2.Length; i++)
            {
                if (Array2[i] < 0)
                    count++;
            }
            return count;
        }

        public string StafName(int i)
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd1 = new SqlCommand("Select Staff_Name from Staff Where Brunch_Name='" + ManagerForm.ManagerBrunch + "' and ID='" + i + "'");
            cmd1.Connection = conn;
            conn.Open();
            string val1 = (string)cmd1.ExecuteScalar();
            conn.Close();
            return val1;
        }

        Panel CreatePanelS(int i)
        {
            Panel p = new Panel();
            //p.Controls.Add(CreateButton(i));
            //p.Controls.Add(CreateLabel(i));
            //be.ApplyElipse(p, 10);
            p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            //p.Location = new System.Drawing.Point(10, 10);
            //p.BackColor = Color.Brown;
            p.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            p.Name = "add_tenant_pnl" + i;
            p.Text = StafName(i);
            p.Size = new System.Drawing.Size(220, 47);
            p.TabIndex = 0;
            return p;
        }

        Label CreateLabelS(int i)
        {
            Label p = new Label();
            p.Size = new System.Drawing.Size(100, 30);
            p.Cursor = System.Windows.Forms.Cursors.Hand;
            p.Font = new System.Drawing.Font("Dosis", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            p.ForeColor = System.Drawing.Color.White;
            p.Location = new System.Drawing.Point(5, 5);
            p.Name = "add_tenant_lbl" + i;
            p.Size = new System.Drawing.Size(200, 30);
            p.TabIndex = 51;
            p.Text = StafName(i);
            p.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            return p;
        }

        private void ManagerHomecs_Load(object sender, EventArgs e)
        {
            // dont touch 
            EmployeeFlowLayout.AutoScroll = false;
            EmployeeFlowLayout.VerticalScroll.Enabled = false;
            EmployeeFlowLayout.VerticalScroll.Visible = false;
            EmployeeFlowLayout.VerticalScroll.Maximum = 0;
            EmployeeFlowLayout.HorizontalScroll.Maximum = 0;
            EmployeeFlowLayout.AutoScroll = true;
            StaffFlowLayout.AutoScroll = false;
            StaffFlowLayout.VerticalScroll.Enabled = false;
            StaffFlowLayout.VerticalScroll.Visible = false;
            StaffFlowLayout.VerticalScroll.Maximum = 0;
            StaffFlowLayout.HorizontalScroll.Maximum = 0;
            StaffFlowLayout.AutoScroll = true;

            TotalEmployee.Text = countEmployee().ToString();
            TotalStaff.Text = countStaff().ToString();
            TotalProject.Text = countProject().ToString();
            AttendenceCount.Text = "E:"+countEmployeeAttandence()+" "+"S:"+ countStaffAttandence() + "";
            ProjectCount.Text = "R:" + countOnProject() + " " + "C:" + countCompProject() + "";

            GetFormInPanel(new DeshBoard());

            size = countEmployee();
            Array = new int[size];
            AllEmployee();
            for (int i = 0; i < Array.Length; i++)
            {
                Label l = CreateLabel(Array[i]);
                Panel p = CreatePanel(Array[i]);
                p.Controls.Add(l);
                EmployeeFlowLayout.Controls.Add(p);
                //b.Click += new System.EventHandler(ButtonClick);
                p.Click += new System.EventHandler(PanelClick);
                l.Click += new System.EventHandler(LabelClick);

            }
        
            size2 = countStaff();
            Array2 = new int[size2];
            AllStaff();
            for (int i = 0; i < Array2.Length; i++)
            {
                Label l = CreateLabelS(Array2[i]);
                Panel p = CreatePanelS(Array2[i]);
                p.Controls.Add(l);
                StaffFlowLayout.Controls.Add(p);
                //b.Click += new System.EventHandler(ButtonClick);
                p.Click += new System.EventHandler(PanelClick);
                l.Click += new System.EventHandler(LabelClick);

            }
        }


        // Dinamic control clicking event 

        void PanelClick(Object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            string x = p.Text;
            MessageBox.Show("Ask Dev to include this feature");

        }

        void LabelClick(Object sender, EventArgs e)
        {
            Label l = (Label)sender;
            string x = l.Text;
            MessageBox.Show("Ask Dev to include this feature");
        }






    }
}
