namespace FileAdding
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
            this.TbFilename.Location = new System.Drawing.Point(12, 80);
            this.TbFilename.Name = "TbFilename";
            this.TbFilename.Size = new System.Drawing.Size(248, 20);
            this.TbFilename.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Custom File Name";
            // 
            // LblFilePath
            // 
            this.LblFilePath.AutoSize = true;
            this.LblFilePath.Location = new System.Drawing.Point(9, 103);
            this.LblFilePath.Name = "LblFilePath";
            this.LblFilePath.Size = new System.Drawing.Size(35, 13);
            this.LblFilePath.TabIndex = 8;
            this.LblFilePath.Text = "label5";
            // 
            // BtnAddFile
            // 
            this.BtnAddFile.Location = new System.Drawing.Point(266, 78);
            this.BtnAddFile.Name = "BtnAddFile";
            this.BtnAddFile.Size = new System.Drawing.Size(118, 23);
            this.BtnAddFile.TabIndex = 9;
            this.BtnAddFile.Text = "Add File";
            this.BtnAddFile.UseVisualStyleBackColor = true;
            this.BtnAddFile.Click += new System.EventHandler(this.BtnAddFile_Click);
            // 
            // FileAdder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 116);
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
    }
}

