namespace FamilySearchSample
{
    partial class PersonFamily
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
            this.components = new System.ComponentModel.Container();
            this.btnReadPersonFamilyById = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonId = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.listBoxDisplayFacts = new System.Windows.Forms.ListBox();
            this.toolTipHerbys = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnReadPersonFamilyById
            // 
            this.btnReadPersonFamilyById.Location = new System.Drawing.Point(337, 6);
            this.btnReadPersonFamilyById.Name = "btnReadPersonFamilyById";
            this.btnReadPersonFamilyById.Size = new System.Drawing.Size(75, 20);
            this.btnReadPersonFamilyById.TabIndex = 6;
            this.btnReadPersonFamilyById.Text = "Retrieve";
            this.btnReadPersonFamilyById.UseVisualStyleBackColor = true;
            this.btnReadPersonFamilyById.Click += new System.EventHandler(this.btnReadPersonFamilyById_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Person ID, then press \"Retrieve\"";
            // 
            // txtPersonId
            // 
            this.txtPersonId.Location = new System.Drawing.Point(209, 6);
            this.txtPersonId.Name = "txtPersonId";
            this.txtPersonId.Size = new System.Drawing.Size(100, 20);
            this.txtPersonId.TabIndex = 4;
            this.toolTipHerbys.SetToolTip(this.txtPersonId, "Enter a Person ID, then click \"Retrieve\".");
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(15, 326);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 41;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(381, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Location = new System.Drawing.Point(418, 13);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(105, 13);
            this.lblErrorMessage.TabIndex = 42;
            this.lblErrorMessage.Text = "No current message.";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Location = new System.Drawing.Point(12, 43);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(18, 13);
            this.lblPersonID.TabIndex = 43;
            this.lblPersonID.Text = "ID";
            // 
            // listBoxDisplayFacts
            // 
            this.listBoxDisplayFacts.FormattingEnabled = true;
            this.listBoxDisplayFacts.Location = new System.Drawing.Point(15, 74);
            this.listBoxDisplayFacts.Name = "listBoxDisplayFacts";
            this.listBoxDisplayFacts.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxDisplayFacts.Size = new System.Drawing.Size(508, 225);
            this.listBoxDisplayFacts.TabIndex = 44;
            // 
            // PersonFamily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(567, 426);
            this.Controls.Add(this.listBoxDisplayFacts);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReadPersonFamilyById);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPersonId);
            this.Name = "PersonFamily";
            this.Text = "Person Family";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadPersonFamilyById;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersonId;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.ListBox listBoxDisplayFacts;
        private System.Windows.Forms.ToolTip toolTipHerbys;
    }
}