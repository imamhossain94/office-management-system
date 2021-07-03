namespace Office_Management_Board
{
    partial class AdminChoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProjectDuration = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.AddProjectButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ProjectTAg = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ProjectDescription = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ProjectTitle = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewProjectGrid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ModifyProjectDuration = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ConfirmModificationButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ModifyTag = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ModifyDescription = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ModifyTitle = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.AllProjectPrid = new System.Windows.Forms.DataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewProjectGrid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllProjectPrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.ProjectDuration);
            this.panel1.Controls.Add(this.AddProjectButton);
            this.panel1.Controls.Add(this.ProjectTAg);
            this.panel1.Controls.Add(this.ProjectDescription);
            this.panel1.Controls.Add(this.ProjectTitle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NewProjectGrid);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 670);
            this.panel1.TabIndex = 0;
            // 
            // ProjectDuration
            // 
            this.ProjectDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ProjectDuration.BorderColorFocused = System.Drawing.Color.White;
            this.ProjectDuration.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.ProjectDuration.BorderColorMouseHover = System.Drawing.Color.RoyalBlue;
            this.ProjectDuration.BorderThickness = 3;
            this.ProjectDuration.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ProjectDuration.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProjectDuration.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ProjectDuration.ForeColor = System.Drawing.Color.White;
            this.ProjectDuration.isPassword = false;
            this.ProjectDuration.Location = new System.Drawing.Point(116, 267);
            this.ProjectDuration.Margin = new System.Windows.Forms.Padding(4);
            this.ProjectDuration.MaxLength = 32767;
            this.ProjectDuration.Name = "ProjectDuration";
            this.ProjectDuration.Size = new System.Drawing.Size(361, 50);
            this.ProjectDuration.TabIndex = 19;
            this.ProjectDuration.Text = "Duration:";
            this.ProjectDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AddProjectButton
            // 
            this.AddProjectButton.Active = false;
            this.AddProjectButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.AddProjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.AddProjectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddProjectButton.BorderRadius = 5;
            this.AddProjectButton.ButtonText = "Add This Project";
            this.AddProjectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProjectButton.DisabledColor = System.Drawing.Color.Gray;
            this.AddProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProjectButton.Iconcolor = System.Drawing.Color.Transparent;
            this.AddProjectButton.Iconimage = null;
            this.AddProjectButton.Iconimage_right = null;
            this.AddProjectButton.Iconimage_right_Selected = null;
            this.AddProjectButton.Iconimage_Selected = null;
            this.AddProjectButton.IconMarginLeft = 0;
            this.AddProjectButton.IconMarginRight = 0;
            this.AddProjectButton.IconRightVisible = true;
            this.AddProjectButton.IconRightZoom = 0D;
            this.AddProjectButton.IconVisible = true;
            this.AddProjectButton.IconZoom = 90D;
            this.AddProjectButton.IsTab = false;
            this.AddProjectButton.Location = new System.Drawing.Point(116, 329);
            this.AddProjectButton.Margin = new System.Windows.Forms.Padding(8);
            this.AddProjectButton.Name = "AddProjectButton";
            this.AddProjectButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.AddProjectButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.AddProjectButton.OnHoverTextColor = System.Drawing.Color.White;
            this.AddProjectButton.selected = false;
            this.AddProjectButton.Size = new System.Drawing.Size(361, 50);
            this.AddProjectButton.TabIndex = 11;
            this.AddProjectButton.Text = "Add This Project";
            this.AddProjectButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddProjectButton.Textcolor = System.Drawing.Color.White;
            this.AddProjectButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProjectButton.Click += new System.EventHandler(this.AddProjectButton_Click);
            // 
            // ProjectTAg
            // 
            this.ProjectTAg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ProjectTAg.BorderColorFocused = System.Drawing.Color.White;
            this.ProjectTAg.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.ProjectTAg.BorderColorMouseHover = System.Drawing.Color.RoyalBlue;
            this.ProjectTAg.BorderThickness = 3;
            this.ProjectTAg.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ProjectTAg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProjectTAg.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ProjectTAg.ForeColor = System.Drawing.Color.White;
            this.ProjectTAg.isPassword = false;
            this.ProjectTAg.Location = new System.Drawing.Point(116, 209);
            this.ProjectTAg.Margin = new System.Windows.Forms.Padding(4);
            this.ProjectTAg.MaxLength = 32767;
            this.ProjectTAg.Name = "ProjectTAg";
            this.ProjectTAg.Size = new System.Drawing.Size(361, 50);
            this.ProjectTAg.TabIndex = 10;
            this.ProjectTAg.Text = "Tag: ";
            this.ProjectTAg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ProjectDescription
            // 
            this.ProjectDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ProjectDescription.BorderColorFocused = System.Drawing.Color.White;
            this.ProjectDescription.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.ProjectDescription.BorderColorMouseHover = System.Drawing.Color.RoyalBlue;
            this.ProjectDescription.BorderThickness = 3;
            this.ProjectDescription.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ProjectDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProjectDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ProjectDescription.ForeColor = System.Drawing.Color.White;
            this.ProjectDescription.isPassword = false;
            this.ProjectDescription.Location = new System.Drawing.Point(116, 151);
            this.ProjectDescription.Margin = new System.Windows.Forms.Padding(4);
            this.ProjectDescription.MaxLength = 32767;
            this.ProjectDescription.Name = "ProjectDescription";
            this.ProjectDescription.Size = new System.Drawing.Size(361, 50);
            this.ProjectDescription.TabIndex = 9;
            this.ProjectDescription.Text = "Description:";
            this.ProjectDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ProjectTitle
            // 
            this.ProjectTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ProjectTitle.BorderColorFocused = System.Drawing.Color.White;
            this.ProjectTitle.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.ProjectTitle.BorderColorMouseHover = System.Drawing.Color.RoyalBlue;
            this.ProjectTitle.BorderThickness = 3;
            this.ProjectTitle.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ProjectTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProjectTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ProjectTitle.ForeColor = System.Drawing.Color.White;
            this.ProjectTitle.isPassword = false;
            this.ProjectTitle.Location = new System.Drawing.Point(116, 93);
            this.ProjectTitle.Margin = new System.Windows.Forms.Padding(4);
            this.ProjectTitle.MaxLength = 32767;
            this.ProjectTitle.Name = "ProjectTitle";
            this.ProjectTitle.Size = new System.Drawing.Size(361, 50);
            this.ProjectTitle.TabIndex = 8;
            this.ProjectTitle.Text = "Title:";
            this.ProjectTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 70);
            this.label1.TabIndex = 7;
            this.label1.Text = "Create New Project";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewProjectGrid
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.NewProjectGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.NewProjectGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.NewProjectGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.NewProjectGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewProjectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NewProjectGrid.Location = new System.Drawing.Point(12, 401);
            this.NewProjectGrid.Name = "NewProjectGrid";
            this.NewProjectGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.NewProjectGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.NewProjectGrid.RowTemplate.Height = 24;
            this.NewProjectGrid.Size = new System.Drawing.Size(563, 257);
            this.NewProjectGrid.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.Controls.Add(this.ModifyProjectDuration);
            this.panel2.Controls.Add(this.ConfirmModificationButton);
            this.panel2.Controls.Add(this.ModifyTag);
            this.panel2.Controls.Add(this.ModifyDescription);
            this.panel2.Controls.Add(this.ModifyTitle);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.AllProjectPrid);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(643, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 670);
            this.panel2.TabIndex = 1;
            // 
            // ModifyProjectDuration
            // 
            this.ModifyProjectDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ModifyProjectDuration.BorderColorFocused = System.Drawing.Color.White;
            this.ModifyProjectDuration.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.ModifyProjectDuration.BorderColorMouseHover = System.Drawing.Color.RoyalBlue;
            this.ModifyProjectDuration.BorderThickness = 3;
            this.ModifyProjectDuration.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ModifyProjectDuration.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ModifyProjectDuration.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ModifyProjectDuration.ForeColor = System.Drawing.Color.White;
            this.ModifyProjectDuration.isPassword = false;
            this.ModifyProjectDuration.Location = new System.Drawing.Point(119, 267);
            this.ModifyProjectDuration.Margin = new System.Windows.Forms.Padding(4);
            this.ModifyProjectDuration.MaxLength = 32767;
            this.ModifyProjectDuration.Name = "ModifyProjectDuration";
            this.ModifyProjectDuration.Size = new System.Drawing.Size(361, 50);
            this.ModifyProjectDuration.TabIndex = 18;
            this.ModifyProjectDuration.Text = "Completing Date:";
            this.ModifyProjectDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ConfirmModificationButton
            // 
            this.ConfirmModificationButton.Active = false;
            this.ConfirmModificationButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ConfirmModificationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ConfirmModificationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConfirmModificationButton.BorderRadius = 5;
            this.ConfirmModificationButton.ButtonText = "Save";
            this.ConfirmModificationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmModificationButton.DisabledColor = System.Drawing.Color.Gray;
            this.ConfirmModificationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmModificationButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ConfirmModificationButton.Iconimage = null;
            this.ConfirmModificationButton.Iconimage_right = null;
            this.ConfirmModificationButton.Iconimage_right_Selected = null;
            this.ConfirmModificationButton.Iconimage_Selected = null;
            this.ConfirmModificationButton.IconMarginLeft = 0;
            this.ConfirmModificationButton.IconMarginRight = 0;
            this.ConfirmModificationButton.IconRightVisible = true;
            this.ConfirmModificationButton.IconRightZoom = 0D;
            this.ConfirmModificationButton.IconVisible = true;
            this.ConfirmModificationButton.IconZoom = 90D;
            this.ConfirmModificationButton.IsTab = false;
            this.ConfirmModificationButton.Location = new System.Drawing.Point(119, 329);
            this.ConfirmModificationButton.Margin = new System.Windows.Forms.Padding(8);
            this.ConfirmModificationButton.Name = "ConfirmModificationButton";
            this.ConfirmModificationButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ConfirmModificationButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ConfirmModificationButton.OnHoverTextColor = System.Drawing.Color.White;
            this.ConfirmModificationButton.selected = false;
            this.ConfirmModificationButton.Size = new System.Drawing.Size(361, 50);
            this.ConfirmModificationButton.TabIndex = 16;
            this.ConfirmModificationButton.Text = "Save";
            this.ConfirmModificationButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ConfirmModificationButton.Textcolor = System.Drawing.Color.White;
            this.ConfirmModificationButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmModificationButton.Click += new System.EventHandler(this.ConfirmModificationButton_Click);
            // 
            // ModifyTag
            // 
            this.ModifyTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ModifyTag.BorderColorFocused = System.Drawing.Color.White;
            this.ModifyTag.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.ModifyTag.BorderColorMouseHover = System.Drawing.Color.RoyalBlue;
            this.ModifyTag.BorderThickness = 3;
            this.ModifyTag.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ModifyTag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ModifyTag.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ModifyTag.ForeColor = System.Drawing.Color.White;
            this.ModifyTag.isPassword = false;
            this.ModifyTag.Location = new System.Drawing.Point(119, 209);
            this.ModifyTag.Margin = new System.Windows.Forms.Padding(4);
            this.ModifyTag.MaxLength = 32767;
            this.ModifyTag.Name = "ModifyTag";
            this.ModifyTag.Size = new System.Drawing.Size(361, 50);
            this.ModifyTag.TabIndex = 15;
            this.ModifyTag.Text = "Tag: ";
            this.ModifyTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ModifyDescription
            // 
            this.ModifyDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ModifyDescription.BorderColorFocused = System.Drawing.Color.White;
            this.ModifyDescription.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.ModifyDescription.BorderColorMouseHover = System.Drawing.Color.RoyalBlue;
            this.ModifyDescription.BorderThickness = 3;
            this.ModifyDescription.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ModifyDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ModifyDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ModifyDescription.ForeColor = System.Drawing.Color.White;
            this.ModifyDescription.isPassword = false;
            this.ModifyDescription.Location = new System.Drawing.Point(119, 151);
            this.ModifyDescription.Margin = new System.Windows.Forms.Padding(4);
            this.ModifyDescription.MaxLength = 32767;
            this.ModifyDescription.Name = "ModifyDescription";
            this.ModifyDescription.Size = new System.Drawing.Size(361, 50);
            this.ModifyDescription.TabIndex = 14;
            this.ModifyDescription.Text = "Description:";
            this.ModifyDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ModifyTitle
            // 
            this.ModifyTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ModifyTitle.BorderColorFocused = System.Drawing.Color.White;
            this.ModifyTitle.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.ModifyTitle.BorderColorMouseHover = System.Drawing.Color.RoyalBlue;
            this.ModifyTitle.BorderThickness = 3;
            this.ModifyTitle.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ModifyTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ModifyTitle.Enabled = false;
            this.ModifyTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ModifyTitle.ForeColor = System.Drawing.Color.White;
            this.ModifyTitle.isPassword = false;
            this.ModifyTitle.Location = new System.Drawing.Point(119, 93);
            this.ModifyTitle.Margin = new System.Windows.Forms.Padding(4);
            this.ModifyTitle.MaxLength = 32767;
            this.ModifyTitle.Name = "ModifyTitle";
            this.ModifyTitle.Size = new System.Drawing.Size(361, 50);
            this.ModifyTitle.TabIndex = 13;
            this.ModifyTitle.Text = "Title:";
            this.ModifyTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(595, 70);
            this.label2.TabIndex = 7;
            this.label2.Text = "Modify Project";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AllProjectPrid
            // 
            this.AllProjectPrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.AllProjectPrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.AllProjectPrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AllProjectPrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllProjectPrid.Location = new System.Drawing.Point(18, 401);
            this.AllProjectPrid.Name = "AllProjectPrid";
            this.AllProjectPrid.RowHeadersWidth = 51;
            this.AllProjectPrid.RowTemplate.Height = 24;
            this.AllProjectPrid.Size = new System.Drawing.Size(563, 257);
            this.AllProjectPrid.TabIndex = 21;
            this.AllProjectPrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AllProjectPrid_RowHeaderMouseClick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.NewProjectGrid;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.AllProjectPrid;
            // 
            // AdminChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1250, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminChoice";
            this.Text = "AdminChoice";
            this.Load += new System.EventHandler(this.AdminChoice_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NewProjectGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AllProjectPrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton AddProjectButton;
        private Bunifu.Framework.UI.BunifuMetroTextbox ProjectTAg;
        private Bunifu.Framework.UI.BunifuMetroTextbox ProjectDescription;
        private Bunifu.Framework.UI.BunifuMetroTextbox ProjectTitle;
        private Bunifu.Framework.UI.BunifuFlatButton ConfirmModificationButton;
        private Bunifu.Framework.UI.BunifuMetroTextbox ModifyTag;
        private Bunifu.Framework.UI.BunifuMetroTextbox ModifyDescription;
        private Bunifu.Framework.UI.BunifuMetroTextbox ModifyTitle;
        private Bunifu.Framework.UI.BunifuMetroTextbox ProjectDuration;
        private Bunifu.Framework.UI.BunifuMetroTextbox ModifyProjectDuration;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.DataGridView NewProjectGrid;
        private System.Windows.Forms.DataGridView AllProjectPrid;
    }
}