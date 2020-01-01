namespace ExecutableWindows
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
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TvEmails)).BeginInit();
            this.SuspendLayout();
            // 
            // TvEmails
            // 
            this.TvEmails.CellEditUseWholeCell = false;
            this.TvEmails.HideSelection = false;
            this.TvEmails.Location = new System.Drawing.Point(12, 49);
            this.TvEmails.Name = "TvEmails";
            this.TvEmails.Size = new System.Drawing.Size(591, 401);
            this.TvEmails.TabIndex = 0;
            this.TvEmails.UseCompatibleStateImageBehavior = false;
            this.TvEmails.View = System.Windows.Forms.View.Details;
            this.TvEmails.SelectionChanged += new System.EventHandler(this.TvEmails_SelectionChanged);
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
            this.BtnEdit.Location = new System.Drawing.Point(544, 10);
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
            // Emails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 477);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbEmail);
            this.Controls.Add(this.TvEmails);
            this.Name = "Emails";
            this.Text = "Emails";
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
    }
}