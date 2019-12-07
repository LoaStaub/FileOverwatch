using System.Windows.Forms;

namespace Executable
{
    partial class CreateOrganization
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
            this.label2 = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.TbType = new System.Windows.Forms.TextBox();
            this.TbDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbState = new System.Windows.Forms.TextBox();
            this.TbCountry = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TbHouseNumber = new System.Windows.Forms.TextBox();
            this.TbStreet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TbCity = new System.Windows.Forms.TextBox();
            this.TbZipCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PbImage = new System.Windows.Forms.PictureBox();
            this.BtnUploadPicture = new System.Windows.Forms.Button();
            this.BtnDeletePicture = new System.Windows.Forms.Button();
            this.BtnAbort = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.DtpFounded = new System.Windows.Forms.DateTimePicker();
            this.BtnEmails = new System.Windows.Forms.Button();
            this.BtnGroups = new System.Windows.Forms.Button();
            this.BtnHomepages = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnMembers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type:";
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(75, 6);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(269, 20);
            this.TbName.TabIndex = 5;
            // 
            // TbType
            // 
            this.TbType.Location = new System.Drawing.Point(75, 32);
            this.TbType.Name = "TbType";
            this.TbType.Size = new System.Drawing.Size(100, 20);
            this.TbType.TabIndex = 6;
            // 
            // TbDescription
            // 
            this.TbDescription.Location = new System.Drawing.Point(15, 189);
            this.TbDescription.Multiline = true;
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.Size = new System.Drawing.Size(523, 144);
            this.TbDescription.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Founded:";
            // 
            // TbState
            // 
            this.TbState.Location = new System.Drawing.Point(222, 58);
            this.TbState.Name = "TbState";
            this.TbState.Size = new System.Drawing.Size(122, 20);
            this.TbState.TabIndex = 14;
            // 
            // TbCountry
            // 
            this.TbCountry.Location = new System.Drawing.Point(75, 58);
            this.TbCountry.Name = "TbCountry";
            this.TbCountry.Size = new System.Drawing.Size(100, 20);
            this.TbCountry.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "State:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Country:";
            // 
            // TbHouseNumber
            // 
            this.TbHouseNumber.Location = new System.Drawing.Point(244, 110);
            this.TbHouseNumber.Name = "TbHouseNumber";
            this.TbHouseNumber.Size = new System.Drawing.Size(54, 20);
            this.TbHouseNumber.TabIndex = 22;
            // 
            // TbStreet
            // 
            this.TbStreet.Location = new System.Drawing.Point(75, 110);
            this.TbStreet.Name = "TbStreet";
            this.TbStreet.Size = new System.Drawing.Size(141, 20);
            this.TbStreet.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(222, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Nr:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Street:";
            // 
            // TbCity
            // 
            this.TbCity.Location = new System.Drawing.Point(193, 84);
            this.TbCity.Name = "TbCity";
            this.TbCity.Size = new System.Drawing.Size(151, 20);
            this.TbCity.TabIndex = 18;
            // 
            // TbZipCode
            // 
            this.TbZipCode.Location = new System.Drawing.Point(75, 84);
            this.TbZipCode.Name = "TbZipCode";
            this.TbZipCode.Size = new System.Drawing.Size(70, 20);
            this.TbZipCode.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(160, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "City:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Zip Code:";
            // 
            // PbImage
            // 
            this.PbImage.Location = new System.Drawing.Point(350, 6);
            this.PbImage.Name = "PbImage";
            this.PbImage.Size = new System.Drawing.Size(188, 124);
            this.PbImage.TabIndex = 23;
            this.PbImage.TabStop = false;
            this.PbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            // 
            // BtnUploadPicture
            // 
            this.BtnUploadPicture.Location = new System.Drawing.Point(350, 136);
            this.BtnUploadPicture.Name = "BtnUploadPicture";
            this.BtnUploadPicture.Size = new System.Drawing.Size(90, 47);
            this.BtnUploadPicture.TabIndex = 24;
            this.BtnUploadPicture.Text = "Upload Picture";
            this.BtnUploadPicture.UseVisualStyleBackColor = true;
            this.BtnUploadPicture.Click += new System.EventHandler(this.BtnUploadPicture_Click);
            // 
            // BtnDeletePicture
            // 
            this.BtnDeletePicture.Location = new System.Drawing.Point(448, 136);
            this.BtnDeletePicture.Name = "BtnDeletePicture";
            this.BtnDeletePicture.Size = new System.Drawing.Size(90, 47);
            this.BtnDeletePicture.TabIndex = 25;
            this.BtnDeletePicture.Text = "Delete Picture";
            this.BtnDeletePicture.UseVisualStyleBackColor = true;
            this.BtnDeletePicture.Click += new System.EventHandler(this.BtnDeletePicture_Click);
            // 
            // BtnAbort
            // 
            this.BtnAbort.Location = new System.Drawing.Point(15, 339);
            this.BtnAbort.Name = "BtnAbort";
            this.BtnAbort.Size = new System.Drawing.Size(75, 23);
            this.BtnAbort.TabIndex = 26;
            this.BtnAbort.Text = "Abort";
            this.BtnAbort.UseVisualStyleBackColor = true;
            this.BtnAbort.Click += new System.EventHandler(this.BtnAbort_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(244, 339);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 27;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(448, 339);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(90, 23);
            this.BtnSave.TabIndex = 28;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // DtpFounded
            // 
            this.DtpFounded.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFounded.Location = new System.Drawing.Point(239, 32);
            this.DtpFounded.Name = "DtpFounded";
            this.DtpFounded.Size = new System.Drawing.Size(105, 20);
            this.DtpFounded.TabIndex = 29;
            // 
            // BtnEmails
            // 
            this.BtnEmails.Location = new System.Drawing.Point(75, 147);
            this.BtnEmails.Name = "BtnEmails";
            this.BtnEmails.Size = new System.Drawing.Size(46, 23);
            this.BtnEmails.TabIndex = 30;
            this.BtnEmails.Text = "Emails";
            this.BtnEmails.UseVisualStyleBackColor = true;
            this.BtnEmails.Click += new System.EventHandler(this.BtnEmails_Click);
            // 
            // BtnGroups
            // 
            this.BtnGroups.Location = new System.Drawing.Point(127, 147);
            this.BtnGroups.Name = "BtnGroups";
            this.BtnGroups.Size = new System.Drawing.Size(52, 23);
            this.BtnGroups.TabIndex = 31;
            this.BtnGroups.Text = "Groups";
            this.BtnGroups.UseVisualStyleBackColor = true;
            this.BtnGroups.Click += new System.EventHandler(this.BtnGroups_Click);
            // 
            // BtnHomepages
            // 
            this.BtnHomepages.Location = new System.Drawing.Point(185, 147);
            this.BtnHomepages.Name = "BtnHomepages";
            this.BtnHomepages.Size = new System.Drawing.Size(74, 23);
            this.BtnHomepages.TabIndex = 32;
            this.BtnHomepages.Text = "Homepages";
            this.BtnHomepages.UseVisualStyleBackColor = true;
            this.BtnHomepages.Click += new System.EventHandler(this.BtnHomepages_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Manage";
            // 
            // BtnMembers
            // 
            this.BtnMembers.Location = new System.Drawing.Point(269, 147);
            this.BtnMembers.Name = "BtnMembers";
            this.BtnMembers.Size = new System.Drawing.Size(59, 23);
            this.BtnMembers.TabIndex = 34;
            this.BtnMembers.Text = "Members";
            this.BtnMembers.UseVisualStyleBackColor = true;
            this.BtnMembers.Click += new System.EventHandler(this.BtnMembers_Click);
            // 
            // CreateOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 368);
            this.Controls.Add(this.BtnMembers);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnHomepages);
            this.Controls.Add(this.BtnGroups);
            this.Controls.Add(this.BtnEmails);
            this.Controls.Add(this.DtpFounded);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAbort);
            this.Controls.Add(this.BtnDeletePicture);
            this.Controls.Add(this.BtnUploadPicture);
            this.Controls.Add(this.PbImage);
            this.Controls.Add(this.TbHouseNumber);
            this.Controls.Add(this.TbStreet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TbCity);
            this.Controls.Add(this.TbZipCode);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TbState);
            this.Controls.Add(this.TbCountry);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TbDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbType);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateOrganization";
            this.Text = "Create Organization";
            this.Load += new System.EventHandler(this.CreateOrganization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.TextBox TbType;
        private System.Windows.Forms.TextBox TbDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbState;
        private System.Windows.Forms.TextBox TbCountry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbHouseNumber;
        private System.Windows.Forms.TextBox TbStreet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TbCity;
        private System.Windows.Forms.TextBox TbZipCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox PbImage;
        private System.Windows.Forms.Button BtnUploadPicture;
        private System.Windows.Forms.Button BtnDeletePicture;
        private System.Windows.Forms.Button BtnAbort;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.DateTimePicker DtpFounded;
        private System.Windows.Forms.Button BtnEmails;
        private System.Windows.Forms.Button BtnGroups;
        private System.Windows.Forms.Button BtnHomepages;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnMembers;
    }
}