namespace ExecutableWindows.ListForms
{
    partial class DoYouMean
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGroup = new System.Windows.Forms.Button();
            this.BtnMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which one do you want?";
            // 
            // BtnGroup
            // 
            this.BtnGroup.Location = new System.Drawing.Point(15, 25);
            this.BtnGroup.Name = "BtnGroup";
            this.BtnGroup.Size = new System.Drawing.Size(123, 23);
            this.BtnGroup.TabIndex = 1;
            this.BtnGroup.Text = "Group";
            this.BtnGroup.UseVisualStyleBackColor = true;
            this.BtnGroup.Click += new System.EventHandler(this.BtnGroup_Click);
            // 
            // BtnMember
            // 
            this.BtnMember.Location = new System.Drawing.Point(15, 54);
            this.BtnMember.Name = "BtnMember";
            this.BtnMember.Size = new System.Drawing.Size(123, 23);
            this.BtnMember.TabIndex = 2;
            this.BtnMember.Text = "Member";
            this.BtnMember.UseVisualStyleBackColor = true;
            this.BtnMember.Click += new System.EventHandler(this.BtnMember_Click);
            // 
            // DoYouMean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 85);
            this.Controls.Add(this.BtnMember);
            this.Controls.Add(this.BtnGroup);
            this.Controls.Add(this.label1);
            this.Name = "DoYouMean";
            this.Text = "DoYouMean";
            this.Load += new System.EventHandler(this.DoYouMean_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGroup;
        private System.Windows.Forms.Button BtnMember;
    }
}