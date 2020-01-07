namespace ExecutableWindows
{
    partial class DatabaseSettings
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
            this.TbPath = new System.Windows.Forms.TextBox();
            this.BtnDirectory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExport = new System.Windows.Forms.Button();
            this.CheckRemap = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TbPath
            // 
            this.TbPath.Location = new System.Drawing.Point(99, 28);
            this.TbPath.Name = "TbPath";
            this.TbPath.Size = new System.Drawing.Size(315, 20);
            this.TbPath.TabIndex = 0;
            // 
            // BtnDirectory
            // 
            this.BtnDirectory.Location = new System.Drawing.Point(12, 26);
            this.BtnDirectory.Name = "BtnDirectory";
            this.BtnDirectory.Size = new System.Drawing.Size(75, 23);
            this.BtnDirectory.TabIndex = 1;
            this.BtnDirectory.Text = "Directory";
            this.BtnDirectory.UseVisualStyleBackColor = true;
            this.BtnDirectory.Click += new System.EventHandler(this.BtnDirectory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path";
            // 
            // BtnExport
            // 
            this.BtnExport.Location = new System.Drawing.Point(338, 54);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(75, 23);
            this.BtnExport.TabIndex = 3;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // CheckRemap
            // 
            this.CheckRemap.AutoSize = true;
            this.CheckRemap.Location = new System.Drawing.Point(141, 58);
            this.CheckRemap.Name = "CheckRemap";
            this.CheckRemap.Size = new System.Drawing.Size(157, 17);
            this.CheckRemap.TabIndex = 4;
            this.CheckRemap.Text = "Remap to new Destination?";
            this.CheckRemap.UseVisualStyleBackColor = true;
            // 
            // DatabaseSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 88);
            this.Controls.Add(this.CheckRemap);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDirectory);
            this.Controls.Add(this.TbPath);
            this.Name = "DatabaseSettings";
            this.Text = "DatabaseSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbPath;
        private System.Windows.Forms.Button BtnDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.CheckBox CheckRemap;
    }
}