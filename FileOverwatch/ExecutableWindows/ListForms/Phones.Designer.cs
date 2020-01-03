﻿namespace ExecutableWindows.ListForms
{
    partial class Phones
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
            this.TvPhonenumbers = new BrightIdeasSoftware.ObjectListView();
            this.BtnCall = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.TbDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbNumber = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TbCountryFlag = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TvPhonenumbers)).BeginInit();
            this.SuspendLayout();
            // 
            // TvPhonenumbers
            // 
            this.TvPhonenumbers.CellEditUseWholeCell = false;
            this.TvPhonenumbers.Cursor = System.Windows.Forms.Cursors.Default;
            this.TvPhonenumbers.HideSelection = false;
            this.TvPhonenumbers.Location = new System.Drawing.Point(12, 42);
            this.TvPhonenumbers.Name = "TvPhonenumbers";
            this.TvPhonenumbers.Size = new System.Drawing.Size(662, 374);
            this.TvPhonenumbers.TabIndex = 0;
            this.TvPhonenumbers.UseCompatibleStateImageBehavior = false;
            this.TvPhonenumbers.View = System.Windows.Forms.View.Details;
            this.TvPhonenumbers.SelectedIndexChanged += new System.EventHandler(this.TvPhonenumbers_SelectedIndexChanged);
            // 
            // BtnCall
            // 
            this.BtnCall.Location = new System.Drawing.Point(599, 422);
            this.BtnCall.Name = "BtnCall";
            this.BtnCall.Size = new System.Drawing.Size(75, 23);
            this.BtnCall.TabIndex = 1;
            this.BtnCall.Text = "Call";
            this.BtnCall.UseVisualStyleBackColor = true;
            this.BtnCall.Click += new System.EventHandler(this.BtnCall_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(507, 14);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(47, 23);
            this.BtnNew.TabIndex = 14;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(615, 14);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(59, 23);
            this.BtnEdit.TabIndex = 13;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // TbDescription
            // 
            this.TbDescription.Location = new System.Drawing.Point(331, 16);
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.Size = new System.Drawing.Size(170, 20);
            this.TbDescription.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Number:";
            // 
            // TbNumber
            // 
            this.TbNumber.Location = new System.Drawing.Point(163, 16);
            this.TbNumber.Name = "TbNumber";
            this.TbNumber.Size = new System.Drawing.Size(93, 20);
            this.TbNumber.TabIndex = 9;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(560, 14);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(49, 23);
            this.BtnDelete.TabIndex = 15;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Flag:";
            // 
            // TbCountryFlag
            // 
            this.TbCountryFlag.Location = new System.Drawing.Point(48, 16);
            this.TbCountryFlag.Name = "TbCountryFlag";
            this.TbCountryFlag.Size = new System.Drawing.Size(56, 20);
            this.TbCountryFlag.TabIndex = 17;
            // 
            // Phones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 453);
            this.Controls.Add(this.TbCountryFlag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.TbDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbNumber);
            this.Controls.Add(this.BtnCall);
            this.Controls.Add(this.TvPhonenumbers);
            this.Name = "Phones";
            this.Text = "Phones";
            ((System.ComponentModel.ISupportInitialize)(this.TvPhonenumbers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView TvPhonenumbers;
        private System.Windows.Forms.Button BtnCall;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.TextBox TbDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbNumber;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbCountryFlag;
    }
}