namespace ExecutableWindows.SettingForms
{
    partial class DatabaseBackupSettings
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
            this.BtnPath = new System.Windows.Forms.Button();
            this.TbPath = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPath
            // 
            this.BtnPath.Location = new System.Drawing.Point(12, 12);
            this.BtnPath.Name = "BtnPath";
            this.BtnPath.Size = new System.Drawing.Size(75, 23);
            this.BtnPath.TabIndex = 0;
            this.BtnPath.Text = "Path";
            this.BtnPath.UseVisualStyleBackColor = true;
            this.BtnPath.Click += new System.EventHandler(this.BtnPath_Click);
            // 
            // TbPath
            // 
            this.TbPath.Location = new System.Drawing.Point(93, 14);
            this.TbPath.Name = "TbPath";
            this.TbPath.Size = new System.Drawing.Size(249, 20);
            this.TbPath.TabIndex = 1;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(267, 40);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // DatabaseBackupSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 67);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TbPath);
            this.Controls.Add(this.BtnPath);
            this.Name = "DatabaseBackupSettings";
            this.Text = "DatabaseBackupSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPath;
        private System.Windows.Forms.TextBox TbPath;
        private System.Windows.Forms.Button BtnSave;
    }
}