namespace Office_Management_Board
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.EmployeeToHome = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeLogInButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.EmployeeSignUpButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.EmployeeSignUpPasswordBox = new System.Windows.Forms.TextBox();
            this.EmployeeSignUpNID = new System.Windows.Forms.TextBox();
            this.SignUPEmployeeBrancheName = new System.Windows.Forms.ComboBox();
            this.EmployeeSignUpUsernameBox = new System.Windows.Forms.TextBox();
            this.EmployeeLogInPassword = new System.Windows.Forms.TextBox();
            this.EmployeeLogInNid = new System.Windows.Forms.TextBox();
            this.LogInEmployeeBrunchName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeToHome)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // EmployeeToHome
            // 
            this.EmployeeToHome.BackColor = System.Drawing.Color.SeaGreen;
            this.EmployeeToHome.Image = ((System.Drawing.Image)(resources.GetObject("EmployeeToHome.Image")));
            this.EmployeeToHome.Location = new System.Drawing.Point(12, 12);
            this.EmployeeToHome.Name = "EmployeeToHome";
            this.EmployeeToHome.Size = new System.Drawing.Size(50, 50);
            this.EmployeeToHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EmployeeToHome.TabIndex = 9;
            this.EmployeeToHome.TabStop = false;
            this.EmployeeToHome.Click += new System.EventHandler(this.EmployeeToHome_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(775, 70);
            this.label1.TabIndex = 8;
            this.label1.Text = "Employee";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeLogInButton
            // 
            this.EmployeeLogInButton.Active = false;
            this.EmployeeLogInButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.EmployeeLogInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.EmployeeLogInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EmployeeLogInButton.BorderRadius = 5;
            this.EmployeeLogInButton.ButtonText = "LOG IN";
            this.EmployeeLogInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmployeeLogInButton.DisabledColor = System.Drawing.Color.Gray;
            this.EmployeeLogInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeLogInButton.Iconcolor = System.Drawing.Color.Transparent;
            this.EmployeeLogInButton.Iconimage = null;
            this.EmployeeLogInButton.Iconimage_right = null;
            this.EmployeeLogInButton.Iconimage_right_Selected = null;
            this.EmployeeLogInButton.Iconimage_Selected = null;
            this.EmployeeLogInButton.IconMarginLeft = 0;
            this.EmployeeLogInButton.IconMarginRight = 0;
            this.EmployeeLogInButton.IconRightVisible = true;
            this.EmployeeLogInButton.IconRightZoom = 0D;
            this.EmployeeLogInButton.IconVisible = true;
            this.EmployeeLogInButton.IconZoom = 90D;
            this.EmployeeLogInButton.IsTab = false;
            this.EmployeeLogInButton.Location = new System.Drawing.Point(400, 423);
            this.EmployeeLogInButton.Margin = new System.Windows.Forms.Padding(8);
            this.EmployeeLogInButton.Name = "EmployeeLogInButton";
            this.EmployeeLogInButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.EmployeeLogInButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.EmployeeLogInButton.OnHoverTextColor = System.Drawing.Color.White;
            this.EmployeeLogInButton.selected = false;
            this.EmployeeLogInButton.Size = new System.Drawing.Size(361, 50);
            this.EmployeeLogInButton.TabIndex = 18;
            this.EmployeeLogInButton.Text = "LOG IN";
            this.EmployeeLogInButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EmployeeLogInButton.Textcolor = System.Drawing.Color.White;
            this.EmployeeLogInButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeLogInButton.Click += new System.EventHandler(this.EmployeeLogInButton_Click);
            // 
            // EmployeeSignUpButton
            // 
            this.EmployeeSignUpButton.Active = false;
            this.EmployeeSignUpButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.EmployeeSignUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.EmployeeSignUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EmployeeSignUpButton.BorderRadius = 5;
            this.EmployeeSignUpButton.ButtonText = "SIGN UP";
            this.EmployeeSignUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmployeeSignUpButton.DisabledColor = System.Drawing.Color.Gray;
            this.EmployeeSignUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeSignUpButton.Iconcolor = System.Drawing.Color.Transparent;
            this.EmployeeSignUpButton.Iconimage = null;
            this.EmployeeSignUpButton.Iconimage_right = null;
            this.EmployeeSignUpButton.Iconimage_right_Selected = null;
            this.EmployeeSignUpButton.Iconimage_Selected = null;
            this.EmployeeSignUpButton.IconMarginLeft = 0;
            this.EmployeeSignUpButton.IconMarginRight = 0;
            this.EmployeeSignUpButton.IconRightVisible = true;
            this.EmployeeSignUpButton.IconRightZoom = 0D;
            this.EmployeeSignUpButton.IconVisible = true;
            this.EmployeeSignUpButton.IconZoom = 90D;
            this.EmployeeSignUpButton.IsTab = false;
            this.EmployeeSignUpButton.Location = new System.Drawing.Point(12, 423);
            this.EmployeeSignUpButton.Margin = new System.Windows.Forms.Padding(8);
            this.EmployeeSignUpButton.Name = "EmployeeSignUpButton";
            this.EmployeeSignUpButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.EmployeeSignUpButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.EmployeeSignUpButton.OnHoverTextColor = System.Drawing.Color.White;
            this.EmployeeSignUpButton.selected = false;
            this.EmployeeSignUpButton.Size = new System.Drawing.Size(361, 50);
            this.EmployeeSignUpButton.TabIndex = 14;
            this.EmployeeSignUpButton.Text = "SIGN UP";
            this.EmployeeSignUpButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EmployeeSignUpButton.Textcolor = System.Drawing.Color.White;
            this.EmployeeSignUpButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeSignUpButton.Click += new System.EventHandler(this.EmployeeSignUpButton_Click);
            // 
            // EmployeeSignUpPasswordBox
            // 
            this.EmployeeSignUpPasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.EmployeeSignUpPasswordBox.Font = new System.Drawing.Font("Microsoft JhengHei Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeSignUpPasswordBox.ForeColor = System.Drawing.Color.White;
            this.EmployeeSignUpPasswordBox.Location = new System.Drawing.Point(12, 343);
            this.EmployeeSignUpPasswordBox.Multiline = true;
            this.EmployeeSignUpPasswordBox.Name = "EmployeeSignUpPasswordBox";
            this.EmployeeSignUpPasswordBox.Size = new System.Drawing.Size(361, 50);
            this.EmployeeSignUpPasswordBox.TabIndex = 22;
            this.EmployeeSignUpPasswordBox.Text = "Password";
            // 
            // EmployeeSignUpNID
            // 
            this.EmployeeSignUpNID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.EmployeeSignUpNID.Font = new System.Drawing.Font("Microsoft JhengHei Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeSignUpNID.ForeColor = System.Drawing.Color.White;
            this.EmployeeSignUpNID.Location = new System.Drawing.Point(12, 286);
            this.EmployeeSignUpNID.Multiline = true;
            this.EmployeeSignUpNID.Name = "EmployeeSignUpNID";
            this.EmployeeSignUpNID.Size = new System.Drawing.Size(361, 50);
            this.EmployeeSignUpNID.TabIndex = 21;
            this.EmployeeSignUpNID.Text = "Employee NID";
            // 
            // SignUPEmployeeBrancheName
            // 
            this.SignUPEmployeeBrancheName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.SignUPEmployeeBrancheName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUPEmployeeBrancheName.Font = new System.Drawing.Font("Microsoft JhengHei Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUPEmployeeBrancheName.ForeColor = System.Drawing.Color.White;
            this.SignUPEmployeeBrancheName.FormattingEnabled = true;
            this.SignUPEmployeeBrancheName.Items.AddRange(new object[] {
            "Mirpur",
            "Dhanmondi",
            "Uttara",
            "Gazipur",
            "Savar",
            "Tangail",
            "Tongi",
            "Jamalpur"});
            this.SignUPEmployeeBrancheName.Location = new System.Drawing.Point(12, 176);
            this.SignUPEmployeeBrancheName.Name = "SignUPEmployeeBrancheName";
            this.SignUPEmployeeBrancheName.Size = new System.Drawing.Size(361, 37);
            this.SignUPEmployeeBrancheName.TabIndex = 20;
            this.SignUPEmployeeBrancheName.Text = "Brunch Name";
            // 
            // EmployeeSignUpUsernameBox
            // 
            this.EmployeeSignUpUsernameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.EmployeeSignUpUsernameBox.Font = new System.Drawing.Font("Microsoft JhengHei Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeSignUpUsernameBox.ForeColor = System.Drawing.Color.White;
            this.EmployeeSignUpUsernameBox.Location = new System.Drawing.Point(12, 230);
            this.EmployeeSignUpUsernameBox.Multiline = true;
            this.EmployeeSignUpUsernameBox.Name = "EmployeeSignUpUsernameBox";
            this.EmployeeSignUpUsernameBox.Size = new System.Drawing.Size(361, 50);
            this.EmployeeSignUpUsernameBox.TabIndex = 19;
            this.EmployeeSignUpUsernameBox.Text = "Employee Name";
            // 
            // EmployeeLogInPassword
            // 
            this.EmployeeLogInPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.EmployeeLogInPassword.Font = new System.Drawing.Font("Microsoft JhengHei Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeLogInPassword.ForeColor = System.Drawing.Color.White;
            this.EmployeeLogInPassword.Location = new System.Drawing.Point(400, 286);
            this.EmployeeLogInPassword.Multiline = true;
            this.EmployeeLogInPassword.Name = "EmployeeLogInPassword";
            this.EmployeeLogInPassword.Size = new System.Drawing.Size(361, 50);
            this.EmployeeLogInPassword.TabIndex = 25;
            this.EmployeeLogInPassword.Text = "Password";
            // 
            // EmployeeLogInNid
            // 
            this.EmployeeLogInNid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.EmployeeLogInNid.Font = new System.Drawing.Font("Microsoft JhengHei Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeLogInNid.ForeColor = System.Drawing.Color.White;
            this.EmployeeLogInNid.Location = new System.Drawing.Point(400, 230);
            this.EmployeeLogInNid.Multiline = true;
            this.EmployeeLogInNid.Name = "EmployeeLogInNid";
            this.EmployeeLogInNid.Size = new System.Drawing.Size(361, 50);
            this.EmployeeLogInNid.TabIndex = 24;
            this.EmployeeLogInNid.Text = "Employee NID";
            // 
            // LogInEmployeeBrunchName
            // 
            this.LogInEmployeeBrunchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.LogInEmployeeBrunchName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInEmployeeBrunchName.Font = new System.Drawing.Font("Microsoft JhengHei Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInEmployeeBrunchName.ForeColor = System.Drawing.Color.White;
            this.LogInEmployeeBrunchName.FormattingEnabled = true;
            this.LogInEmployeeBrunchName.Items.AddRange(new object[] {
            "Mirpur",
            "Dhanmondi",
            "Uttara",
            "Gazipur",
            "Savar",
            "Tangail",
            "Tongi",
            "Jamalpur"});
            this.LogInEmployeeBrunchName.Location = new System.Drawing.Point(400, 176);
            this.LogInEmployeeBrunchName.Name = "LogInEmployeeBrunchName";
            this.LogInEmployeeBrunchName.Size = new System.Drawing.Size(361, 37);
            this.LogInEmployeeBrunchName.TabIndex = 23;
            this.LogInEmployeeBrunchName.Text = "Brunch Name";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(775, 488);
            this.Controls.Add(this.EmployeeLogInPassword);
            this.Controls.Add(this.EmployeeLogInNid);
            this.Controls.Add(this.LogInEmployeeBrunchName);
            this.Controls.Add(this.EmployeeSignUpPasswordBox);
            this.Controls.Add(this.EmployeeSignUpNID);
            this.Controls.Add(this.SignUPEmployeeBrancheName);
            this.Controls.Add(this.EmployeeSignUpUsernameBox);
            this.Controls.Add(this.EmployeeLogInButton);
            this.Controls.Add(this.EmployeeSignUpButton);
            this.Controls.Add(this.EmployeeToHome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeToHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox EmployeeToHome;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton EmployeeLogInButton;
        private Bunifu.Framework.UI.BunifuFlatButton EmployeeSignUpButton;
        private System.Windows.Forms.TextBox EmployeeSignUpPasswordBox;
        private System.Windows.Forms.TextBox EmployeeSignUpNID;
        private System.Windows.Forms.ComboBox SignUPEmployeeBrancheName;
        private System.Windows.Forms.TextBox EmployeeSignUpUsernameBox;
        private System.Windows.Forms.TextBox EmployeeLogInPassword;
        private System.Windows.Forms.TextBox EmployeeLogInNid;
        private System.Windows.Forms.ComboBox LogInEmployeeBrunchName;
    }
}