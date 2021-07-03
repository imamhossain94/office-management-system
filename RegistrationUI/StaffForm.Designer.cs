namespace Office_Management_Board
{
    partial class StaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.StaffToHome = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StaffLogInButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.StaffSignUpButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.StaffSignUpPasswordBox = new System.Windows.Forms.TextBox();
            this.StaffSignUpNid = new System.Windows.Forms.TextBox();
            this.StaffSignUpBrunchname = new System.Windows.Forms.ComboBox();
            this.StaffSignUpUsernameBox = new System.Windows.Forms.TextBox();
            this.StaffLogInPasswordBox = new System.Windows.Forms.TextBox();
            this.StaffLoginNid = new System.Windows.Forms.TextBox();
            this.StaffLogInBrunchname = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.StaffToHome)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // StaffToHome
            // 
            this.StaffToHome.BackColor = System.Drawing.Color.SeaGreen;
            this.StaffToHome.Image = ((System.Drawing.Image)(resources.GetObject("StaffToHome.Image")));
            this.StaffToHome.Location = new System.Drawing.Point(12, 12);
            this.StaffToHome.Name = "StaffToHome";
            this.StaffToHome.Size = new System.Drawing.Size(50, 50);
            this.StaffToHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StaffToHome.TabIndex = 16;
            this.StaffToHome.TabStop = false;
            this.StaffToHome.Click += new System.EventHandler(this.StaffToHome_Click);
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
            this.label1.TabIndex = 15;
            this.label1.Text = "Staff";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StaffLogInButton
            // 
            this.StaffLogInButton.Active = false;
            this.StaffLogInButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.StaffLogInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.StaffLogInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StaffLogInButton.BorderRadius = 5;
            this.StaffLogInButton.ButtonText = "LOG IN";
            this.StaffLogInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StaffLogInButton.DisabledColor = System.Drawing.Color.Gray;
            this.StaffLogInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffLogInButton.Iconcolor = System.Drawing.Color.Transparent;
            this.StaffLogInButton.Iconimage = null;
            this.StaffLogInButton.Iconimage_right = null;
            this.StaffLogInButton.Iconimage_right_Selected = null;
            this.StaffLogInButton.Iconimage_Selected = null;
            this.StaffLogInButton.IconMarginLeft = 0;
            this.StaffLogInButton.IconMarginRight = 0;
            this.StaffLogInButton.IconRightVisible = true;
            this.StaffLogInButton.IconRightZoom = 0D;
            this.StaffLogInButton.IconVisible = true;
            this.StaffLogInButton.IconZoom = 90D;
            this.StaffLogInButton.IsTab = false;
            this.StaffLogInButton.Location = new System.Drawing.Point(400, 422);
            this.StaffLogInButton.Margin = new System.Windows.Forms.Padding(8);
            this.StaffLogInButton.Name = "StaffLogInButton";
            this.StaffLogInButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.StaffLogInButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.StaffLogInButton.OnHoverTextColor = System.Drawing.Color.White;
            this.StaffLogInButton.selected = false;
            this.StaffLogInButton.Size = new System.Drawing.Size(361, 50);
            this.StaffLogInButton.TabIndex = 24;
            this.StaffLogInButton.Text = "LOG IN";
            this.StaffLogInButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StaffLogInButton.Textcolor = System.Drawing.Color.White;
            this.StaffLogInButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffLogInButton.Click += new System.EventHandler(this.StaffLogInButton_Click);
            // 
            // StaffSignUpButton
            // 
            this.StaffSignUpButton.Active = false;
            this.StaffSignUpButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.StaffSignUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.StaffSignUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StaffSignUpButton.BorderRadius = 5;
            this.StaffSignUpButton.ButtonText = "SIGN UP";
            this.StaffSignUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StaffSignUpButton.DisabledColor = System.Drawing.Color.Gray;
            this.StaffSignUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffSignUpButton.Iconcolor = System.Drawing.Color.Transparent;
            this.StaffSignUpButton.Iconimage = null;
            this.StaffSignUpButton.Iconimage_right = null;
            this.StaffSignUpButton.Iconimage_right_Selected = null;
            this.StaffSignUpButton.Iconimage_Selected = null;
            this.StaffSignUpButton.IconMarginLeft = 0;
            this.StaffSignUpButton.IconMarginRight = 0;
            this.StaffSignUpButton.IconRightVisible = true;
            this.StaffSignUpButton.IconRightZoom = 0D;
            this.StaffSignUpButton.IconVisible = true;
            this.StaffSignUpButton.IconZoom = 90D;
            this.StaffSignUpButton.IsTab = false;
            this.StaffSignUpButton.Location = new System.Drawing.Point(12, 422);
            this.StaffSignUpButton.Margin = new System.Windows.Forms.Padding(8);
            this.StaffSignUpButton.Name = "StaffSignUpButton";
            this.StaffSignUpButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.StaffSignUpButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.StaffSignUpButton.OnHoverTextColor = System.Drawing.Color.White;
            this.StaffSignUpButton.selected = false;
            this.StaffSignUpButton.Size = new System.Drawing.Size(361, 50);
            this.StaffSignUpButton.TabIndex = 20;
            this.StaffSignUpButton.Text = "SIGN UP";
            this.StaffSignUpButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StaffSignUpButton.Textcolor = System.Drawing.Color.White;
            this.StaffSignUpButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffSignUpButton.Click += new System.EventHandler(this.StaffSignUpButton_Click);
            // 
            // StaffSignUpPasswordBox
            // 
            this.StaffSignUpPasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.StaffSignUpPasswordBox.Font = new System.Drawing.Font("Microsoft JhengHei Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffSignUpPasswordBox.ForeColor = System.Drawing.Color.White;
            this.StaffSignUpPasswordBox.Location = new System.Drawing.Point(12, 343);
            this.StaffSignUpPasswordBox.Multiline = true;
            this.StaffSignUpPasswordBox.Name = "StaffSignUpPasswordBox";
            this.StaffSignUpPasswordBox.Size = new System.Drawing.Size(361, 50);
            this.StaffSignUpPasswordBox.TabIndex = 28;
            this.StaffSignUpPasswordBox.Text = "Password";
            // 
            // StaffSignUpNid
            // 
            this.StaffSignUpNid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.StaffSignUpNid.Font = new System.Drawing.Font("Microsoft JhengHei Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffSignUpNid.ForeColor = System.Drawing.Color.White;
            this.StaffSignUpNid.Location = new System.Drawing.Point(12, 286);
            this.StaffSignUpNid.Multiline = true;
            this.StaffSignUpNid.Name = "StaffSignUpNid";
            this.StaffSignUpNid.Size = new System.Drawing.Size(361, 50);
            this.StaffSignUpNid.TabIndex = 27;
            this.StaffSignUpNid.Text = "Staff NID";
            // 
            // StaffSignUpBrunchname
            // 
            this.StaffSignUpBrunchname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.StaffSignUpBrunchname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffSignUpBrunchname.Font = new System.Drawing.Font("Microsoft JhengHei Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffSignUpBrunchname.ForeColor = System.Drawing.Color.White;
            this.StaffSignUpBrunchname.FormattingEnabled = true;
            this.StaffSignUpBrunchname.Items.AddRange(new object[] {
            "Mirpur",
            "Dhanmondi",
            "Uttara",
            "Gazipur",
            "Savar",
            "Tangail",
            "Tongi",
            "Jamalpur"});
            this.StaffSignUpBrunchname.Location = new System.Drawing.Point(12, 176);
            this.StaffSignUpBrunchname.Name = "StaffSignUpBrunchname";
            this.StaffSignUpBrunchname.Size = new System.Drawing.Size(361, 37);
            this.StaffSignUpBrunchname.TabIndex = 26;
            this.StaffSignUpBrunchname.Text = "Brunch Name";
            // 
            // StaffSignUpUsernameBox
            // 
            this.StaffSignUpUsernameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.StaffSignUpUsernameBox.Font = new System.Drawing.Font("Microsoft JhengHei Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffSignUpUsernameBox.ForeColor = System.Drawing.Color.White;
            this.StaffSignUpUsernameBox.Location = new System.Drawing.Point(12, 230);
            this.StaffSignUpUsernameBox.Multiline = true;
            this.StaffSignUpUsernameBox.Name = "StaffSignUpUsernameBox";
            this.StaffSignUpUsernameBox.Size = new System.Drawing.Size(361, 50);
            this.StaffSignUpUsernameBox.TabIndex = 25;
            this.StaffSignUpUsernameBox.Text = "Staff Name";
            // 
            // StaffLogInPasswordBox
            // 
            this.StaffLogInPasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.StaffLogInPasswordBox.Font = new System.Drawing.Font("Microsoft JhengHei Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffLogInPasswordBox.ForeColor = System.Drawing.Color.White;
            this.StaffLogInPasswordBox.Location = new System.Drawing.Point(400, 286);
            this.StaffLogInPasswordBox.Multiline = true;
            this.StaffLogInPasswordBox.Name = "StaffLogInPasswordBox";
            this.StaffLogInPasswordBox.Size = new System.Drawing.Size(361, 50);
            this.StaffLogInPasswordBox.TabIndex = 31;
            this.StaffLogInPasswordBox.Text = "Password";
            // 
            // StaffLoginNid
            // 
            this.StaffLoginNid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.StaffLoginNid.Font = new System.Drawing.Font("Microsoft JhengHei Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffLoginNid.ForeColor = System.Drawing.Color.White;
            this.StaffLoginNid.Location = new System.Drawing.Point(400, 230);
            this.StaffLoginNid.Multiline = true;
            this.StaffLoginNid.Name = "StaffLoginNid";
            this.StaffLoginNid.Size = new System.Drawing.Size(361, 50);
            this.StaffLoginNid.TabIndex = 30;
            this.StaffLoginNid.Text = "Staff NID";
            // 
            // StaffLogInBrunchname
            // 
            this.StaffLogInBrunchname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.StaffLogInBrunchname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffLogInBrunchname.Font = new System.Drawing.Font("Microsoft JhengHei Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffLogInBrunchname.ForeColor = System.Drawing.Color.White;
            this.StaffLogInBrunchname.FormattingEnabled = true;
            this.StaffLogInBrunchname.Items.AddRange(new object[] {
            "Mirpur",
            "Dhanmondi",
            "Uttara",
            "Gazipur",
            "Savar",
            "Tangail",
            "Tongi",
            "Jamalpur"});
            this.StaffLogInBrunchname.Location = new System.Drawing.Point(400, 176);
            this.StaffLogInBrunchname.Name = "StaffLogInBrunchname";
            this.StaffLogInBrunchname.Size = new System.Drawing.Size(361, 37);
            this.StaffLogInBrunchname.TabIndex = 29;
            this.StaffLogInBrunchname.Text = "Brunch Name";
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(775, 488);
            this.Controls.Add(this.StaffLogInPasswordBox);
            this.Controls.Add(this.StaffLoginNid);
            this.Controls.Add(this.StaffLogInBrunchname);
            this.Controls.Add(this.StaffSignUpPasswordBox);
            this.Controls.Add(this.StaffSignUpNid);
            this.Controls.Add(this.StaffSignUpBrunchname);
            this.Controls.Add(this.StaffSignUpUsernameBox);
            this.Controls.Add(this.StaffLogInButton);
            this.Controls.Add(this.StaffSignUpButton);
            this.Controls.Add(this.StaffToHome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffForm";
            ((System.ComponentModel.ISupportInitialize)(this.StaffToHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox StaffToHome;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton StaffLogInButton;
        private Bunifu.Framework.UI.BunifuFlatButton StaffSignUpButton;
        private System.Windows.Forms.TextBox StaffSignUpPasswordBox;
        private System.Windows.Forms.TextBox StaffSignUpNid;
        private System.Windows.Forms.ComboBox StaffSignUpBrunchname;
        private System.Windows.Forms.TextBox StaffSignUpUsernameBox;
        private System.Windows.Forms.TextBox StaffLogInPasswordBox;
        private System.Windows.Forms.TextBox StaffLoginNid;
        private System.Windows.Forms.ComboBox StaffLogInBrunchname;
    }
}