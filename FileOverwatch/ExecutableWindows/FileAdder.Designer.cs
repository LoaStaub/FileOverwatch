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
            this.LblFilePath = new System.Windows.Forms.Label();
            this.BtnAddFile = new System.Windows.Forms.Button();
            this.CbType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbFileOverhead = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.TbFilepath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CbOrganizations
            // 
            this.CbOrganizations.FormattingEnabled = true;
            this.CbOrganizations.Location = new System.Drawing.Point(16, 36);
            this.CbOrganizations.Margin = new System.Windows.Forms.Padding(4);
            this.CbOrganizations.Name = "CbOrganizations";
            this.CbOrganizations.Size = new System.Drawing.Size(160, 24);
            this.CbOrganizations.TabIndex = 0;
            this.CbOrganizations.SelectedIndexChanged += new System.EventHandler(this.CbOrganizations_SelectedIndexChanged);
            // 
            // CbGroups
            // 
            this.CbGroups.FormattingEnabled = true;
            this.CbGroups.Location = new System.Drawing.Point(185, 36);
            this.CbGroups.Margin = new System.Windows.Forms.Padding(4);
            this.CbGroups.Name = "CbGroups";
            this.CbGroups.Size = new System.Drawing.Size(160, 24);
            this.CbGroups.TabIndex = 1;
            this.CbGroups.SelectedIndexChanged += new System.EventHandler(this.CbGroups_SelectedIndexChanged);
            // 
            // CbMember
            // 
            this.CbMember.FormattingEnabled = true;
            this.CbMember.Location = new System.Drawing.Point(355, 36);
            this.CbMember.Margin = new System.Windows.Forms.Padding(4);
            this.CbMember.Name = "CbMember";
            this.CbMember.Size = new System.Drawing.Size(160, 24);
            this.CbMember.TabIndex = 2;
            this.CbMember.SelectedIndexChanged += new System.EventHandler(this.CbMember_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Organization";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Member";
            // 
            // TbFilename
            // 
            this.TbFilename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TbFilename.Location = new System.Drawing.Point(16, 171);
            this.TbFilename.Margin = new System.Windows.Forms.Padding(4);
            this.TbFilename.Name = "TbFilename";
            this.TbFilename.Size = new System.Drawing.Size(329, 22);
            this.TbFilename.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Custom File Name";
            // 
            // LblFilePath
            // 
            this.LblFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblFilePath.AutoSize = true;
            this.LblFilePath.Location = new System.Drawing.Point(12, 200);
            this.LblFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFilePath.Name = "LblFilePath";
            this.LblFilePath.Size = new System.Drawing.Size(46, 17);
            this.LblFilePath.TabIndex = 8;
            this.LblFilePath.Text = "label5";
            // 
            // BtnAddFile
            // 
            this.BtnAddFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAddFile.Location = new System.Drawing.Point(355, 169);
            this.BtnAddFile.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAddFile.Name = "BtnAddFile";
            this.BtnAddFile.Size = new System.Drawing.Size(157, 28);
            this.BtnAddFile.TabIndex = 9;
            this.BtnAddFile.Text = "Add File";
            this.BtnAddFile.UseVisualStyleBackColor = true;
            this.BtnAddFile.Click += new System.EventHandler(this.BtnAddFile_Click);
            // 
            // CbType
            // 
            this.CbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CbType.FormattingEnabled = true;
            this.CbType.Location = new System.Drawing.Point(80, 106);
            this.CbType.Name = "CbType";
            this.CbType.Size = new System.Drawing.Size(96, 24);
            this.CbType.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Filetype:";
            // 
            // CbFileOverhead
            // 
            this.CbFileOverhead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CbFileOverhead.FormattingEnabled = true;
            this.CbFileOverhead.Location = new System.Drawing.Point(260, 106);
            this.CbFileOverhead.Name = "CbFileOverhead";
            this.CbFileOverhead.Size = new System.Drawing.Size(180, 24);
            this.CbFileOverhead.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Filegroup:";
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(16, 72);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(75, 23);
            this.BtnBrowse.TabIndex = 14;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // TbFilepath
            // 
            this.TbFilepath.Location = new System.Drawing.Point(97, 72);
            this.TbFilepath.Name = "TbFilepath";
            this.TbFilepath.Size = new System.Drawing.Size(415, 22);
            this.TbFilepath.TabIndex = 15;
            this.TbFilepath.TextChanged += new System.EventHandler(this.TbFilepath_TextChanged);
            // 
            // FileAdder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 218);
            this.Controls.Add(this.TbFilepath);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CbFileOverhead);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbType);
            this.Controls.Add(this.BtnAddFile);
            this.Controls.Add(this.LblFilePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbFilename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbMember);
            this.Controls.Add(this.CbGroups);
            this.Controls.Add(this.CbOrganizations);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label LblFilePath;
        private System.Windows.Forms.Button BtnAddFile;
        private System.Windows.Forms.ComboBox CbType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbFileOverhead;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.TextBox TbFilepath;
    }
}

