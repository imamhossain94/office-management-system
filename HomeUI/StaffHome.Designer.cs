namespace Office_Management_Board.AttendenceUI
{
    partial class StaffHome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffHome));
            this.TopBar = new System.Windows.Forms.Label();
            this.StaffAttandanceGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.CheckButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SearchBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LogoutButton = new System.Windows.Forms.PictureBox();
            this.dateTime = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.StaffAttandanceGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutButton)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.SeaGreen;
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopBar.ForeColor = System.Drawing.Color.White;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(1000, 50);
            this.TopBar.TabIndex = 3;
            this.TopBar.Text = "Staff";
            this.TopBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StaffAttandanceGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StaffAttandanceGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StaffAttandanceGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StaffAttandanceGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.StaffAttandanceGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StaffAttandanceGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StaffAttandanceGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StaffAttandanceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffAttandanceGrid.DoubleBuffered = true;
            this.StaffAttandanceGrid.EnableHeadersVisualStyles = false;
            this.StaffAttandanceGrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.StaffAttandanceGrid.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.StaffAttandanceGrid.Location = new System.Drawing.Point(13, 141);
            this.StaffAttandanceGrid.Name = "StaffAttandanceGrid";
            this.StaffAttandanceGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.StaffAttandanceGrid.RowHeadersWidth = 51;
            this.StaffAttandanceGrid.RowTemplate.Height = 24;
            this.StaffAttandanceGrid.Size = new System.Drawing.Size(975, 547);
            this.StaffAttandanceGrid.TabIndex = 5;
            // 
            // CheckButton
            // 
            this.CheckButton.Active = false;
            this.CheckButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.CheckButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.CheckButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CheckButton.BorderRadius = 5;
            this.CheckButton.ButtonText = "Daily Check";
            this.CheckButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckButton.DisabledColor = System.Drawing.Color.Gray;
            this.CheckButton.Iconcolor = System.Drawing.Color.Transparent;
            this.CheckButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("CheckButton.Iconimage")));
            this.CheckButton.Iconimage_right = null;
            this.CheckButton.Iconimage_right_Selected = null;
            this.CheckButton.Iconimage_Selected = null;
            this.CheckButton.IconMarginLeft = 0;
            this.CheckButton.IconMarginRight = 0;
            this.CheckButton.IconRightVisible = true;
            this.CheckButton.IconRightZoom = 0D;
            this.CheckButton.IconVisible = true;
            this.CheckButton.IconZoom = 90D;
            this.CheckButton.IsTab = false;
            this.CheckButton.Location = new System.Drawing.Point(13, 74);
            this.CheckButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.CheckButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.CheckButton.OnHoverTextColor = System.Drawing.Color.White;
            this.CheckButton.selected = false;
            this.CheckButton.Size = new System.Drawing.Size(220, 45);
            this.CheckButton.TabIndex = 6;
            this.CheckButton.Text = "Daily Check";
            this.CheckButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheckButton.Textcolor = System.Drawing.Color.White;
            this.CheckButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.SeaGreen;
            this.SearchBox.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.SearchBox.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.SearchBox.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.SearchBox.BorderThickness = 3;
            this.SearchBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ForeColor = System.Drawing.Color.White;
            this.SearchBox.isPassword = false;
            this.SearchBox.Location = new System.Drawing.Point(531, 74);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBox.MaxLength = 32767;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(457, 45);
            this.SearchBox.TabIndex = 7;
            this.SearchBox.Text = "Search";
            this.SearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.SearchBox;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.TopBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutButton.BackColor = System.Drawing.Color.SeaGreen;
            this.LogoutButton.Image = ((System.Drawing.Image)(resources.GetObject("LogoutButton.Image")));
            this.LogoutButton.Location = new System.Drawing.Point(948, 5);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(45, 45);
            this.LogoutButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoutButton.TabIndex = 44;
            this.LogoutButton.TabStop = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // dateTime
            // 
            this.dateTime.Active = false;
            this.dateTime.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dateTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dateTime.BorderRadius = 5;
            this.dateTime.ButtonText = "mm/dd/yyyy";
            this.dateTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTime.DisabledColor = System.Drawing.Color.Gray;
            this.dateTime.Iconcolor = System.Drawing.Color.Transparent;
            this.dateTime.Iconimage = ((System.Drawing.Image)(resources.GetObject("dateTime.Iconimage")));
            this.dateTime.Iconimage_right = null;
            this.dateTime.Iconimage_right_Selected = null;
            this.dateTime.Iconimage_Selected = null;
            this.dateTime.IconMarginLeft = 0;
            this.dateTime.IconMarginRight = 0;
            this.dateTime.IconRightVisible = true;
            this.dateTime.IconRightZoom = 0D;
            this.dateTime.IconVisible = true;
            this.dateTime.IconZoom = 90D;
            this.dateTime.IsTab = false;
            this.dateTime.Location = new System.Drawing.Point(241, 74);
            this.dateTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTime.Name = "dateTime";
            this.dateTime.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dateTime.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.dateTime.OnHoverTextColor = System.Drawing.Color.White;
            this.dateTime.selected = false;
            this.dateTime.Size = new System.Drawing.Size(220, 45);
            this.dateTime.TabIndex = 45;
            this.dateTime.Text = "mm/dd/yyyy";
            this.dateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateTime.Textcolor = System.Drawing.Color.White;
            this.dateTime.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // StaffHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.StaffAttandanceGrid);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffHome";
            this.Load += new System.EventHandler(this.StaffHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StaffAttandanceGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TopBar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid StaffAttandanceGrid;
        private Bunifu.Framework.UI.BunifuFlatButton CheckButton;
        private Bunifu.Framework.UI.BunifuMetroTextbox SearchBox;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox LogoutButton;
        private Bunifu.Framework.UI.BunifuFlatButton dateTime;
    }
}