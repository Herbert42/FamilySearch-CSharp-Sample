namespace FamilySearchSample
{
    partial class PersonSearch
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtGivenName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtFatherGivenName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFatherSurname = new System.Windows.Forms.TextBox();
            this.txtFatherBirthDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMotherBirthDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMotherSurname = new System.Windows.Forms.TextBox();
            this.txtMotherGivenName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(563, 412);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type in the information you have, then click Search.";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(12, 65);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(140, 20);
            this.txtSurname.TabIndex = 4;
            // 
            // txtGivenName
            // 
            this.txtGivenName.Location = new System.Drawing.Point(171, 65);
            this.txtGivenName.Name = "txtGivenName";
            this.txtGivenName.Size = new System.Drawing.Size(140, 20);
            this.txtGivenName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Given Name (John)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Surname (Smith)";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 207);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Location = new System.Drawing.Point(272, 13);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(49, 13);
            this.lblErrorMessage.TabIndex = 9;
            this.lblErrorMessage.Text = "No Error.";
            // 
            // ResultBox
            // 
            this.ResultBox.FormattingEnabled = true;
            this.ResultBox.Location = new System.Drawing.Point(12, 247);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(458, 134);
            this.ResultBox.TabIndex = 10;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 412);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtFatherGivenName
            // 
            this.txtFatherGivenName.Location = new System.Drawing.Point(171, 115);
            this.txtFatherGivenName.Name = "txtFatherGivenName";
            this.txtFatherGivenName.Size = new System.Drawing.Size(140, 20);
            this.txtFatherGivenName.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Father\'s Given Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Father\'s Surname";
            // 
            // txtFatherSurname
            // 
            this.txtFatherSurname.Location = new System.Drawing.Point(12, 115);
            this.txtFatherSurname.Name = "txtFatherSurname";
            this.txtFatherSurname.Size = new System.Drawing.Size(140, 20);
            this.txtFatherSurname.TabIndex = 14;
            // 
            // txtFatherBirthDate
            // 
            this.txtFatherBirthDate.Location = new System.Drawing.Point(330, 115);
            this.txtFatherBirthDate.Name = "txtFatherBirthDate";
            this.txtFatherBirthDate.Size = new System.Drawing.Size(140, 20);
            this.txtFatherBirthDate.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Father\'s Birth Date";
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(330, 65);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(140, 20);
            this.txtBirthDate.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Birth Date (1 January 1911)";
            // 
            // txtMotherBirthDate
            // 
            this.txtMotherBirthDate.Location = new System.Drawing.Point(330, 167);
            this.txtMotherBirthDate.Name = "txtMotherBirthDate";
            this.txtMotherBirthDate.Size = new System.Drawing.Size(140, 20);
            this.txtMotherBirthDate.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Mother\'s Birth Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Mother\'s Surname";
            // 
            // txtMotherSurname
            // 
            this.txtMotherSurname.Location = new System.Drawing.Point(12, 167);
            this.txtMotherSurname.Name = "txtMotherSurname";
            this.txtMotherSurname.Size = new System.Drawing.Size(140, 20);
            this.txtMotherSurname.TabIndex = 22;
            // 
            // txtMotherGivenName
            // 
            this.txtMotherGivenName.Location = new System.Drawing.Point(171, 167);
            this.txtMotherGivenName.Name = "txtMotherGivenName";
            this.txtMotherGivenName.Size = new System.Drawing.Size(140, 20);
            this.txtMotherGivenName.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(168, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Mother\'s Given Name";
            // 
            // PersonSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(650, 447);
            this.Controls.Add(this.txtMotherBirthDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMotherSurname);
            this.Controls.Add(this.txtMotherGivenName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFatherBirthDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFatherSurname);
            this.Controls.Add(this.txtFatherGivenName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGivenName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Name = "PersonSearch";
            this.Text = "Person Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtGivenName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.ListBox ResultBox;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtFatherGivenName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFatherSurname;
        private System.Windows.Forms.TextBox txtFatherBirthDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMotherBirthDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMotherSurname;
        private System.Windows.Forms.TextBox txtMotherGivenName;
        private System.Windows.Forms.Label label10;
    }
}