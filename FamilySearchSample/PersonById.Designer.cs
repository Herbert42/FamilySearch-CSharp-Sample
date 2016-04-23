namespace FamilySearchSample
{
    partial class PersonById
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
            this.txtPersonId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRetriveById = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.txtLivespan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkLiving = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.txtBirthPlace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDeathDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDeathPlace = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGivenName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLang = new System.Windows.Forms.TextBox();
            this.txtDateOriginal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDataForLabel = new System.Windows.Forms.Label();
            this.txtDateFormal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDateNormalized = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPersonId
            // 
            this.txtPersonId.Location = new System.Drawing.Point(205, 12);
            this.txtPersonId.Name = "txtPersonId";
            this.txtPersonId.Size = new System.Drawing.Size(100, 20);
            this.txtPersonId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Person ID, then press \"Retrive\"";
            // 
            // btnRetriveById
            // 
            this.btnRetriveById.Location = new System.Drawing.Point(333, 12);
            this.btnRetriveById.Name = "btnRetriveById";
            this.btnRetriveById.Size = new System.Drawing.Size(75, 20);
            this.btnRetriveById.TabIndex = 3;
            this.btnRetriveById.Text = "Retrieve";
            this.btnRetriveById.UseVisualStyleBackColor = true;
            this.btnRetriveById.Click += new System.EventHandler(this.btnRetriveById_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(433, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 374);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gender";
            // 
            // txtGender
            // 
            this.txtGender.Enabled = false;
            this.txtGender.Location = new System.Drawing.Point(10, 85);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 20);
            this.txtGender.TabIndex = 7;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Location = new System.Drawing.Point(437, 15);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(105, 13);
            this.lblErrorMessage.TabIndex = 8;
            this.lblErrorMessage.Text = "No current message.";
            // 
            // txtLivespan
            // 
            this.txtLivespan.Enabled = false;
            this.txtLivespan.Location = new System.Drawing.Point(130, 85);
            this.txtLivespan.Name = "txtLivespan";
            this.txtLivespan.Size = new System.Drawing.Size(120, 20);
            this.txtLivespan.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lifespan";
            // 
            // chkLiving
            // 
            this.chkLiving.AutoSize = true;
            this.chkLiving.Enabled = false;
            this.chkLiving.Location = new System.Drawing.Point(277, 87);
            this.chkLiving.Name = "chkLiving";
            this.chkLiving.Size = new System.Drawing.Size(54, 17);
            this.chkLiving.TabIndex = 12;
            this.chkLiving.Text = "Living";
            this.chkLiving.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Birth Date";
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Enabled = false;
            this.txtBirthDate.Location = new System.Drawing.Point(10, 128);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(114, 20);
            this.txtBirthDate.TabIndex = 14;
            // 
            // txtBirthPlace
            // 
            this.txtBirthPlace.Enabled = false;
            this.txtBirthPlace.Location = new System.Drawing.Point(130, 129);
            this.txtBirthPlace.Name = "txtBirthPlace";
            this.txtBirthPlace.Size = new System.Drawing.Size(160, 20);
            this.txtBirthPlace.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Bitrh Place";
            // 
            // txtDeathDate
            // 
            this.txtDeathDate.Enabled = false;
            this.txtDeathDate.Location = new System.Drawing.Point(299, 129);
            this.txtDeathDate.Name = "txtDeathDate";
            this.txtDeathDate.Size = new System.Drawing.Size(114, 20);
            this.txtDeathDate.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Death Date";
            // 
            // txtDeathPlace
            // 
            this.txtDeathPlace.Enabled = false;
            this.txtDeathPlace.Location = new System.Drawing.Point(425, 129);
            this.txtDeathPlace.Name = "txtDeathPlace";
            this.txtDeathPlace.Size = new System.Drawing.Size(160, 20);
            this.txtDeathPlace.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Death Place";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Names";
            // 
            // txtFullName
            // 
            this.txtFullName.Enabled = false;
            this.txtFullName.Location = new System.Drawing.Point(10, 195);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(114, 20);
            this.txtFullName.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Full Text";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(130, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Given";
            // 
            // txtGivenName
            // 
            this.txtGivenName.Enabled = false;
            this.txtGivenName.Location = new System.Drawing.Point(130, 195);
            this.txtGivenName.Name = "txtGivenName";
            this.txtGivenName.Size = new System.Drawing.Size(114, 20);
            this.txtGivenName.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(299, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Enabled = false;
            this.txtSurname.Location = new System.Drawing.Point(299, 195);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(114, 20);
            this.txtSurname.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(425, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Lang";
            // 
            // txtLang
            // 
            this.txtLang.Enabled = false;
            this.txtLang.Location = new System.Drawing.Point(425, 195);
            this.txtLang.Name = "txtLang";
            this.txtLang.Size = new System.Drawing.Size(114, 20);
            this.txtLang.TabIndex = 28;
            // 
            // txtDateOriginal
            // 
            this.txtDateOriginal.Enabled = false;
            this.txtDateOriginal.Location = new System.Drawing.Point(11, 268);
            this.txtDateOriginal.Name = "txtDateOriginal";
            this.txtDateOriginal.Size = new System.Drawing.Size(114, 20);
            this.txtDateOriginal.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Date - Original";
            // 
            // lblDataForLabel
            // 
            this.lblDataForLabel.AutoSize = true;
            this.lblDataForLabel.Location = new System.Drawing.Point(8, 45);
            this.lblDataForLabel.Name = "lblDataForLabel";
            this.lblDataForLabel.Size = new System.Drawing.Size(18, 13);
            this.lblDataForLabel.TabIndex = 32;
            this.lblDataForLabel.Text = "ID";
            // 
            // txtDateFormal
            // 
            this.txtDateFormal.Enabled = false;
            this.txtDateFormal.Location = new System.Drawing.Point(131, 268);
            this.txtDateFormal.Name = "txtDateFormal";
            this.txtDateFormal.Size = new System.Drawing.Size(114, 20);
            this.txtDateFormal.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(131, 252);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Date - Formal";
            // 
            // txtDateNormalized
            // 
            this.txtDateNormalized.Enabled = false;
            this.txtDateNormalized.Location = new System.Drawing.Point(251, 268);
            this.txtDateNormalized.Name = "txtDateNormalized";
            this.txtDateNormalized.Size = new System.Drawing.Size(114, 20);
            this.txtDateNormalized.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(251, 252);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Date - Normalized";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 233);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Facts";
            // 
            // PersonById
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(664, 409);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtDateNormalized);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtDateFormal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblDataForLabel);
            this.Controls.Add(this.txtDateOriginal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtLang);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtGivenName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDeathPlace);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDeathDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBirthPlace);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkLiving);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLivespan);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRetriveById);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPersonId);
            this.Name = "PersonById";
            this.Text = "PersonById";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPersonId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRetriveById;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.TextBox txtLivespan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkLiving;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.TextBox txtBirthPlace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDeathDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDeathPlace;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGivenName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLang;
        private System.Windows.Forms.TextBox txtDateOriginal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblDataForLabel;
        private System.Windows.Forms.TextBox txtDateFormal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDateNormalized;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}