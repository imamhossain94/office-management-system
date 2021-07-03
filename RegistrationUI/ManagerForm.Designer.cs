namespace Office_Management_Board
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ManagerToHome = new System.Windows.Forms.PictureBox();
            this.ManagerSignUpButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LogInManagerButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SignUPManagerName = new System.Windows.Forms.TextBox();
            this.SignUPManagerBrancheName = new System.Windows.Forms.ComboBox();
            this.LogInManagerBrunchName = new System.Windows.Forms.ComboBox();
            this.SignUPManagerNID = new System.Windows.Forms.TextBox();
            this.LogINManagerNID = new System.Windows.Forms.TextBox();
            this.SignUPManagerPassword = new System.Windows.Forms.TextBox();
            this.LogInManagerPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerToHome)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
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
            this.label1.TabIndex = 1;
            this.label1.Text = "Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManagerToHome
            // 
            this.ManagerToHome.BackColor = System.Drawing.Color.SeaGreen;
            this.ManagerToHome.Image = ((System.Drawing.Image)(resources.GetObject("ManagerToHome.Image")));
            this.ManagerToHome.Location = new System.Drawing.Point(13, 12);
            this.ManagerToHome.Name = "ManagerToHome";
            this.ManagerToHome.Size = new System.Drawing.Size(50, 50);
            this.ManagerToHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ManagerToHome.TabIndex = 2;
            this.ManagerToHome.TabStop = false;
            this.ManagerToHome.Click += new System.EventHandler(this.ManagerToHome_Click);
            // 
            // ManagerSignUpButton
            // 
            this.ManagerSignUpButton.Active = false;
            this.ManagerSignUpButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ManagerSignUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ManagerSignUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ManagerSignUpButton.BorderRadius = 5;
            this.ManagerSignUpButton.ButtonText = "SIGN UP";
            this.ManagerSignUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManagerSignUpButton.DisabledColor = System.Drawing.Color.Gray;
            this.ManagerSignUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerSignUpButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ManagerSignUpButton.Iconimage = null;
            this.ManagerSignUpButton.Iconimage_right = null;
            this.ManagerSignUpButton.Iconimage_right_Selected = null;
            this.ManagerSignUpButton.Iconimage_Selected = null;
            this.ManagerSignUpButton.IconMarginLeft = 0;
            this.ManagerSignUpButton.IconMarginRight = 0;
            this.ManagerSignUpButton.IconRightVisible = true;
            this.ManagerSignUpButton.IconRightZoom = 0D;
            this.ManagerSignUpButton.IconVisible = true;
            this.ManagerSignUpButton.IconZoom = 90D;
            this.ManagerSignUpButton.IsTab = false;
            this.ManagerSignUpButton.Location = new System.Drawing.Point(12, 421);
            this.ManagerSignUpButton.Margin = new System.Windows.Forms.Padding(8);
            this.ManagerSignUpButton.Name = "ManagerSignUpButton";
            this.ManagerSignUpButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ManagerSignUpButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ManagerSignUpButton.OnHoverTextColor = System.Drawing.Color.White;
            this.ManagerSignUpButton.selected = false;
            this.ManagerSignUpButton.Size = new System.Drawing.Size(361, 50);
            this.ManagerSignUpButton.TabIndex = 6;
            this.ManagerSignUpButton.Text = "SIGN UP";
            this.ManagerSignUpButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ManagerSignUpButton.Textcolor = System.Drawing.Color.White;
            this.ManagerSignUpButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerSignUpButton.Click += new System.EventHandler(this.ManagerSignUpButton_Click);
            // 
            // LogInManagerButton
            // 
            this.LogInManagerButton.Active = false;
            this.LogInManagerButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.LogInManagerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.LogInManagerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogInManagerButton.BorderRadius = 5;
            this.LogInManagerButton.ButtonText = "LOG IN";
            this.LogInManagerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInManagerButton.DisabledColor = System.Drawing.Color.Gray;
            this.LogInManagerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInManagerButton.Iconcolor = System.Drawing.Color.Transparent;
            this.LogInManagerButton.Iconimage = null;
            this.LogInManagerButton.Iconimage_right = null;
            this.LogInManagerButton.Iconimage_right_Selected = null;
            this.LogInManagerButton.Iconimage_Selected = null;
            this.LogInManagerButton.IconMarginLeft = 0;
            this.LogInManagerButton.IconMarginRight = 0;
            this.LogInManagerButton.IconRightVisible = true;
            this.LogInManagerButton.IconRightZoom = 0D;
            this.LogInManagerButton.IconVisible = true;
            this.LogInManagerButton.IconZoom = 90D;
            this.LogInManagerButton.IsTab = false;
            this.LogInManagerButton.Location = new System.Drawing.Point(400, 421);
            this.LogInManagerButton.Margin = new System.Windows.Forms.Padding(8);
            this.LogInManagerButton.Name = "LogInManagerButton";
            this.LogInManagerButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.LogInManagerButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.LogInManagerButton.OnHoverTextColor = System.Drawing.Color.White;
            this.LogInManagerButton.selected = false;
            this.LogInManagerButton.Size = new System.Drawing.Size(361, 50);
            this.LogInManagerButton.TabIndex = 10;
            this.LogInManagerButton.Text = "LOG IN";
            this.LogInManagerButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogInManagerButton.Textcolor = System.Drawing.Color.White;
            this.LogInManagerButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInManagerButton.Click += new System.EventHandler(this.LogInManagerButton_Click);
            // 
            // SignUPManagerName
            // 
            this.SignUPManagerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.SignUPManagerName.Font = new System.Drawing.Font("Microsoft JhengHei Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUPManagerName.ForeColor = System.Drawing.Color.White;
            this.SignUPManagerName.Location = new System.Drawing.Point(13, 230);
            this.SignUPManagerName.Multiline = true;
            this.SignUPManagerName.Name = "SignUPManagerName";
            this.SignUPManagerName.Size = new System.Drawing.Size(361, 50);
            this.SignUPManagerName.TabIndex = 11;
            this.SignUPManagerName.Text = "Manager Name";
            // 
            // SignUPManagerBrancheName
            // 
            this.SignUPManagerBrancheName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.SignUPManagerBrancheName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUPManagerBrancheName.Font = new System.Drawing.Font("Microsoft JhengHei Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUPManagerBrancheName.ForeColor = System.Drawing.Color.White;
            this.SignUPManagerBrancheName.FormattingEnabled = true;
            this.SignUPManagerBrancheName.Items.AddRange(new object[] {
            "Mirpur",
            "Dhanmondi",
            "Uttara",
            "Gazipur",
            "Savar",
            "Tangail",
            "Tongi",
            "Jamalpur"});
            this.SignUPManagerBrancheName.Location = new System.Drawing.Point(13, 176);
            this.SignUPManagerBrancheName.Name = "SignUPManagerBrancheName";
            this.SignUPManagerBrancheName.Size = new System.Drawing.Size(361, 37);
            this.SignUPManagerBrancheName.TabIndex = 12;
            this.SignUPManagerBrancheName.Text = "Brunch Name";
            // 
            // LogInManagerBrunchName
            // 
            this.LogInManagerBrunchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.LogInManagerBrunchName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInManagerBrunchName.Font = new System.Drawing.Font("Microsoft JhengHei Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInManagerBrunchName.ForeColor = System.Drawing.Color.White;
            this.LogInManagerBrunchName.FormattingEnabled = true;
            this.LogInManagerBrunchName.Items.AddRange(new object[] {
            "Mirpur",
            "Dhanmondi",
            "Uttara",
            "Gazipur",
            "Savar",
            "Tangail",
            "Tongi",
            "Jamalpur"});
            this.LogInManagerBrunchName.Location = new System.Drawing.Point(400, 176);
            this.LogInManagerBrunchName.Name = "LogInManagerBrunchName";
            this.LogInManagerBrunchName.Size = new System.Drawing.Size(361, 37);
            this.LogInManagerBrunchName.TabIndex = 13;
            this.LogInManagerBrunchName.Text = "Brunch Name";
            // 
            // SignUPManagerNID
            // 
            this.SignUPManagerNID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.SignUPManagerNID.Font = new System.Drawing.Font("Microsoft JhengHei Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUPManagerNID.ForeColor = System.Drawing.Color.White;
            this.SignUPManagerNID.Location = new System.Drawing.Point(13, 286);
            this.SignUPManagerNID.Multiline = true;
            this.SignUPManagerNID.Name = "SignUPManagerNID";
            this.SignUPManagerNID.Size = new System.Drawing.Size(361, 50);
            this.SignUPManagerNID.TabIndex = 15;
            this.SignUPManagerNID.Text = "Manager NID";
            // 
            // LogINManagerNID
            // 
            this.LogINManagerNID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.LogINManagerNID.Font = new System.Drawing.Font("Microsoft JhengHei Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogINManagerNID.ForeColor = System.Drawing.Color.White;
            this.LogINManagerNID.Location = new System.Drawing.Point(400, 230);
            this.LogINManagerNID.Multiline = true;
            this.LogINManagerNID.Name = "LogINManagerNID";
            this.LogINManagerNID.Size = new System.Drawing.Size(361, 50);
            this.LogINManagerNID.TabIndex = 16;
            this.LogINManagerNID.Text = "Manager NID";
            // 
            // SignUPManagerPassword
            // 
            this.SignUPManagerPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.SignUPManagerPassword.Font = new System.Drawing.Font("Microsoft JhengHei Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUPManagerPassword.ForeColor = System.Drawing.Color.White;
            this.SignUPManagerPassword.Location = new System.Drawing.Point(13, 343);
            this.SignUPManagerPassword.Multiline = true;
            this.SignUPManagerPassword.Name = "SignUPManagerPassword";
            this.SignUPManagerPassword.Size = new System.Drawing.Size(361, 50);
            this.SignUPManagerPassword.TabIndex = 17;
            this.SignUPManagerPassword.Text = "Password";
            // 
            // LogInManagerPassword
            // 
            this.LogInManagerPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.LogInManagerPassword.Font = new System.Drawing.Font("Microsoft JhengHei Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInManagerPassword.ForeColor = System.Drawing.Color.White;
            this.LogInManagerPassword.Location = new System.Drawing.Point(400, 286);
            this.LogInManagerPassword.Multiline = true;
            this.LogInManagerPassword.Name = "LogInManagerPassword";
            this.LogInManagerPassword.Size = new System.Drawing.Size(361, 50);
            this.LogInManagerPassword.TabIndex = 18;
            this.LogInManagerPassword.Text = "Password";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(775, 488);
            this.Controls.Add(this.LogInManagerPassword);
            this.Controls.Add(this.SignUPManagerPassword);
            this.Controls.Add(this.LogINManagerNID);
            this.Controls.Add(this.SignUPManagerNID);
            this.Controls.Add(this.LogInManagerBrunchName);
            this.Controls.Add(this.SignUPManagerBrancheName);
            this.Controls.Add(this.SignUPManagerName);
            this.Controls.Add(this.LogInManagerButton);
            this.Controls.Add(this.ManagerSignUpButton);
            this.Controls.Add(this.ManagerToHome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ManagerToHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox ManagerToHome;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton ManagerSignUpButton;
        private Bunifu.Framework.UI.BunifuFlatButton LogInManagerButton;
        private System.Windows.Forms.TextBox SignUPManagerName;
        private System.Windows.Forms.ComboBox LogInManagerBrunchName;
        private System.Windows.Forms.ComboBox SignUPManagerBrancheName;
        private System.Windows.Forms.TextBox LogInManagerPassword;
        private System.Windows.Forms.TextBox SignUPManagerPassword;
        private System.Windows.Forms.TextBox LogINManagerNID;
        private System.Windows.Forms.TextBox SignUPManagerNID;
    }
}