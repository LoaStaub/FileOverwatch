namespace ExecutableWindows.ListForms
{
    partial class Emails
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
            this.TvEmails = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnSendMail = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TvEmails)).BeginInit();
            this.SuspendLayout();
            // 
            // TvEmails
            // 
            this.TvEmails.AllColumns.Add(this.olvColumn1);
            this.TvEmails.AllColumns.Add(this.olvColumn2);
            this.TvEmails.AllColumns.Add(this.olvColumn3);
            this.TvEmails.AllColumns.Add(this.olvColumn4);
            this.TvEmails.CellEditUseWholeCell = false;
            this.TvEmails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4});
            this.TvEmails.Cursor = System.Windows.Forms.Cursors.Default;
            this.TvEmails.HideSelection = false;
            this.TvEmails.Location = new System.Drawing.Point(12, 49);
            this.TvEmails.Name = "TvEmails";
            this.TvEmails.Size = new System.Drawing.Size(652, 401);
            this.TvEmails.TabIndex = 0;
            this.TvEmails.UseCompatibleStateImageBehavior = false;
            this.TvEmails.View = System.Windows.Forms.View.Details;
            this.TvEmails.SelectionChanged += new System.EventHandler(this.TvEmails_SelectionChanged);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Id";
            this.olvColumn1.Text = "Id";
            this.olvColumn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Mail";
            this.olvColumn2.Text = "MailAdress";
            this.olvColumn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "CreateDate";
            this.olvColumn3.Text = "Create Date";
            this.olvColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Description";
            this.olvColumn4.Text = "Description";
            this.olvColumn4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbEmail
            // 
            this.TbEmail.Location = new System.Drawing.Point(57, 12);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(166, 20);
            this.TbEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "E-Mail:";
            // 
            // TbDescription
            // 
            this.TbDescription.Location = new System.Drawing.Point(297, 12);
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.Size = new System.Drawing.Size(188, 20);
            this.TbDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description:";
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(605, 10);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(59, 23);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(491, 10);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(47, 23);
            this.BtnNew.TabIndex = 6;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnSendMail
            // 
            this.BtnSendMail.Location = new System.Drawing.Point(589, 456);
            this.BtnSendMail.Name = "BtnSendMail";
            this.BtnSendMail.Size = new System.Drawing.Size(75, 23);
            this.BtnSendMail.TabIndex = 7;
            this.BtnSendMail.Text = "Send Mail";
            this.BtnSendMail.UseVisualStyleBackColor = true;
            this.BtnSendMail.Click += new System.EventHandler(this.BtnSendMail_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(544, 10);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(55, 23);
            this.BtnDelete.TabIndex = 8;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Emails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 485);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSendMail);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbEmail);
            this.Controls.Add(this.TvEmails);
            this.Name = "Emails";
            this.Text = "Emails";
            this.Load += new System.EventHandler(this.Emails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TvEmails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView TvEmails;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnSendMail;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private System.Windows.Forms.Button BtnDelete;
    }
}