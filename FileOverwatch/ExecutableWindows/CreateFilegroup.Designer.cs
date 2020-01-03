namespace ExecutableWindows
{
    partial class CreateFilegroup
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
            this.CbOrganizations = new System.Windows.Forms.ComboBox();
            this.CbGroups = new System.Windows.Forms.ComboBox();
            this.CbMembers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TbDescription = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAbort = new System.Windows.Forms.Button();
            this.TbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CbOrganizations
            // 
            this.CbOrganizations.FormattingEnabled = true;
            this.CbOrganizations.Location = new System.Drawing.Point(87, 12);
            this.CbOrganizations.Name = "CbOrganizations";
            this.CbOrganizations.Size = new System.Drawing.Size(121, 21);
            this.CbOrganizations.TabIndex = 0;
            this.CbOrganizations.SelectedIndexChanged += new System.EventHandler(this.CbOrganizations_SelectedIndexChanged);
            // 
            // CbGroups
            // 
            this.CbGroups.FormattingEnabled = true;
            this.CbGroups.Location = new System.Drawing.Point(87, 39);
            this.CbGroups.Name = "CbGroups";
            this.CbGroups.Size = new System.Drawing.Size(121, 21);
            this.CbGroups.TabIndex = 1;
            this.CbGroups.SelectedIndexChanged += new System.EventHandler(this.CbGroups_SelectedIndexChanged);
            // 
            // CbMembers
            // 
            this.CbMembers.FormattingEnabled = true;
            this.CbMembers.Location = new System.Drawing.Point(87, 66);
            this.CbMembers.Name = "CbMembers";
            this.CbMembers.Size = new System.Drawing.Size(121, 21);
            this.CbMembers.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Organization:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Group:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Member:";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(309, 120);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(193, 23);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TbDescription
            // 
            this.TbDescription.Location = new System.Drawing.Point(224, 38);
            this.TbDescription.Multiline = true;
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.Size = new System.Drawing.Size(273, 75);
            this.TbDescription.TabIndex = 7;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(194, 120);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 8;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAbort
            // 
            this.BtnAbort.Location = new System.Drawing.Point(15, 120);
            this.BtnAbort.Name = "BtnAbort";
            this.BtnAbort.Size = new System.Drawing.Size(102, 23);
            this.BtnAbort.TabIndex = 9;
            this.BtnAbort.Text = "Abort";
            this.BtnAbort.UseVisualStyleBackColor = true;
            this.BtnAbort.Click += new System.EventHandler(this.BtnAbort_Click);
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(87, 93);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(121, 20);
            this.TbName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Description:";
            // 
            // CreateFilegroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 145);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.BtnAbort);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.TbDescription);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbMembers);
            this.Controls.Add(this.CbGroups);
            this.Controls.Add(this.CbOrganizations);
            this.Name = "CreateFilegroup";
            this.Text = "CreateFilegroup";
            this.Load += new System.EventHandler(this.CreateFilegroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbOrganizations;
        private System.Windows.Forms.ComboBox CbGroups;
        private System.Windows.Forms.ComboBox CbMembers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TbDescription;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAbort;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}