namespace ExecutableWindows.ListForms
{
    partial class Homepages
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
            this.TvPages = new BrightIdeasSoftware.ObjectListView();
            this.TbLink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbDescription = new System.Windows.Forms.TextBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnOpenPage = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TvPages)).BeginInit();
            this.SuspendLayout();
            // 
            // TvPages
            // 
            this.TvPages.CellEditUseWholeCell = false;
            this.TvPages.Cursor = System.Windows.Forms.Cursors.Default;
            this.TvPages.HideSelection = false;
            this.TvPages.Location = new System.Drawing.Point(12, 41);
            this.TvPages.Name = "TvPages";
            this.TvPages.Size = new System.Drawing.Size(661, 366);
            this.TvPages.TabIndex = 0;
            this.TvPages.UseCompatibleStateImageBehavior = false;
            this.TvPages.View = System.Windows.Forms.View.Details;
            this.TvPages.SelectedIndexChanged += new System.EventHandler(this.TvPages_SelectedIndexChanged);
            // 
            // TbLink
            // 
            this.TbLink.Location = new System.Drawing.Point(48, 12);
            this.TbLink.Name = "TbLink";
            this.TbLink.Size = new System.Drawing.Size(192, 20);
            this.TbLink.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Link:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description:";
            // 
            // TbDescription
            // 
            this.TbDescription.Location = new System.Drawing.Point(315, 12);
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.Size = new System.Drawing.Size(188, 20);
            this.TbDescription.TabIndex = 4;
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(509, 10);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(47, 23);
            this.BtnNew.TabIndex = 8;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(614, 10);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(59, 23);
            this.BtnEdit.TabIndex = 7;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnOpenPage
            // 
            this.BtnOpenPage.Location = new System.Drawing.Point(598, 413);
            this.BtnOpenPage.Name = "BtnOpenPage";
            this.BtnOpenPage.Size = new System.Drawing.Size(75, 23);
            this.BtnOpenPage.TabIndex = 9;
            this.BtnOpenPage.Text = "Open Page";
            this.BtnOpenPage.UseVisualStyleBackColor = true;
            this.BtnOpenPage.Click += new System.EventHandler(this.BtnOpenPage_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(562, 10);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(46, 23);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Homepages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 442);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnOpenPage);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.TbDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbLink);
            this.Controls.Add(this.TvPages);
            this.Name = "Homepages";
            this.Text = "Homepages";
            this.Load += new System.EventHandler(this.Homepages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TvPages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView TvPages;
        private System.Windows.Forms.TextBox TbLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbDescription;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnOpenPage;
        private System.Windows.Forms.Button BtnDelete;
    }
}