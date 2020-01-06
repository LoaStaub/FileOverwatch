namespace ExecutableWindows
{
    partial class FileAdder
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.CbOrganizations = new System.Windows.Forms.ComboBox();
            this.CbGroups = new System.Windows.Forms.ComboBox();
            this.CbMember = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbFilename = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAddFile = new System.Windows.Forms.Button();
            this.CbFileOverhead = new System.Windows.Forms.ComboBox();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.TbFilepath = new System.Windows.Forms.TextBox();
            this.BtnNewFilegroup = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TbDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CbOrganizations
            // 
            this.CbOrganizations.FormattingEnabled = true;
            this.CbOrganizations.Location = new System.Drawing.Point(12, 29);
            this.CbOrganizations.Name = "CbOrganizations";
            this.CbOrganizations.Size = new System.Drawing.Size(121, 21);
            this.CbOrganizations.TabIndex = 0;
            this.CbOrganizations.SelectedIndexChanged += new System.EventHandler(this.CbOrganizations_SelectedIndexChanged);
            // 
            // CbGroups
            // 
            this.CbGroups.FormattingEnabled = true;
            this.CbGroups.Location = new System.Drawing.Point(139, 29);
            this.CbGroups.Name = "CbGroups";
            this.CbGroups.Size = new System.Drawing.Size(121, 21);
            this.CbGroups.TabIndex = 1;
            this.CbGroups.SelectedIndexChanged += new System.EventHandler(this.CbGroups_SelectedIndexChanged);
            // 
            // CbMember
            // 
            this.CbMember.FormattingEnabled = true;
            this.CbMember.Location = new System.Drawing.Point(266, 29);
            this.CbMember.Name = "CbMember";
            this.CbMember.Size = new System.Drawing.Size(121, 21);
            this.CbMember.TabIndex = 2;
            this.CbMember.SelectedIndexChanged += new System.EventHandler(this.CbMember_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Organization";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Member";
            // 
            // TbFilename
            // 
            this.TbFilename.Location = new System.Drawing.Point(12, 138);
            this.TbFilename.Name = "TbFilename";
            this.TbFilename.Size = new System.Drawing.Size(375, 20);
            this.TbFilename.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Custom File Name";
            // 
            // BtnAddFile
            // 
            this.BtnAddFile.Location = new System.Drawing.Point(269, 177);
            this.BtnAddFile.Name = "BtnAddFile";
            this.BtnAddFile.Size = new System.Drawing.Size(118, 83);
            this.BtnAddFile.TabIndex = 9;
            this.BtnAddFile.Text = "Add File";
            this.BtnAddFile.UseVisualStyleBackColor = true;
            this.BtnAddFile.Click += new System.EventHandler(this.BtnAddFile_Click);
            // 
            // CbFileOverhead
            // 
            this.CbFileOverhead.FormattingEnabled = true;
            this.CbFileOverhead.Location = new System.Drawing.Point(73, 85);
            this.CbFileOverhead.Margin = new System.Windows.Forms.Padding(2);
            this.CbFileOverhead.Name = "CbFileOverhead";
            this.CbFileOverhead.Size = new System.Drawing.Size(311, 21);
            this.CbFileOverhead.TabIndex = 12;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(12, 58);
            this.BtnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(56, 19);
            this.BtnBrowse.TabIndex = 14;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // TbFilepath
            // 
            this.TbFilepath.Location = new System.Drawing.Point(73, 58);
            this.TbFilepath.Margin = new System.Windows.Forms.Padding(2);
            this.TbFilepath.Name = "TbFilepath";
            this.TbFilepath.Size = new System.Drawing.Size(312, 20);
            this.TbFilepath.TabIndex = 15;
            // 
            // BtnNewFilegroup
            // 
            this.BtnNewFilegroup.Location = new System.Drawing.Point(139, 110);
            this.BtnNewFilegroup.Name = "BtnNewFilegroup";
            this.BtnNewFilegroup.Size = new System.Drawing.Size(192, 23);
            this.BtnNewFilegroup.TabIndex = 16;
            this.BtnNewFilegroup.Text = "New Filegroup";
            this.BtnNewFilegroup.UseVisualStyleBackColor = true;
            this.BtnNewFilegroup.Click += new System.EventHandler(this.BtnNewFilegroup_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Filegroup:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Description";
            // 
            // TbDescription
            // 
            this.TbDescription.Location = new System.Drawing.Point(12, 177);
            this.TbDescription.Multiline = true;
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.Size = new System.Drawing.Size(248, 83);
            this.TbDescription.TabIndex = 18;
            // 
            // FileAdder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 272);
            this.Controls.Add(this.TbDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnNewFilegroup);
            this.Controls.Add(this.TbFilepath);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CbFileOverhead);
            this.Controls.Add(this.BtnAddFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbFilename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbMember);
            this.Controls.Add(this.CbGroups);
            this.Controls.Add(this.CbOrganizations);
            this.Name = "FileAdder";
            this.Text = "File Adding";
            this.Load += new System.EventHandler(this.FileAdder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbOrganizations;
        private System.Windows.Forms.ComboBox CbGroups;
        private System.Windows.Forms.ComboBox CbMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbFilename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnAddFile;
        private System.Windows.Forms.ComboBox CbFileOverhead;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.TextBox TbFilepath;
        private System.Windows.Forms.Button BtnNewFilegroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbDescription;
    }
}

