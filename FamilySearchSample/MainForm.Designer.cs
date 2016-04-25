namespace FamilySearchSample
{
    partial class MainForm
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
            this.btnAuthenticate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFindById = new System.Windows.Forms.Button();
            this.btnCurrentUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Authentication: You need to sign in before using this app.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Click Authenticate to begin";
            // 
            // btnAuthenticate
            // 
            this.btnAuthenticate.Location = new System.Drawing.Point(12, 47);
            this.btnAuthenticate.Name = "btnAuthenticate";
            this.btnAuthenticate.Size = new System.Drawing.Size(168, 30);
            this.btnAuthenticate.TabIndex = 2;
            this.btnAuthenticate.Text = "Authenticate";
            this.btnAuthenticate.UseVisualStyleBackColor = true;
            this.btnAuthenticate.Click += new System.EventHandler(this.btnAuthenticate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Token";
            // 
            // txtToken
            // 
            this.txtToken.Enabled = false;
            this.txtToken.Location = new System.Drawing.Point(209, 47);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(464, 20);
            this.txtToken.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 325);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFindById
            // 
            this.btnFindById.Enabled = false;
            this.btnFindById.Location = new System.Drawing.Point(13, 83);
            this.btnFindById.Name = "btnFindById";
            this.btnFindById.Size = new System.Drawing.Size(167, 30);
            this.btnFindById.TabIndex = 6;
            this.btnFindById.Text = "Find Person by ID";
            this.btnFindById.UseVisualStyleBackColor = true;
            this.btnFindById.Click += new System.EventHandler(this.btnFindById_Click);
            // 
            // btnCurrentUser
            // 
            this.btnCurrentUser.Enabled = false;
            this.btnCurrentUser.Location = new System.Drawing.Point(13, 119);
            this.btnCurrentUser.Name = "btnCurrentUser";
            this.btnCurrentUser.Size = new System.Drawing.Size(167, 30);
            this.btnCurrentUser.TabIndex = 7;
            this.btnCurrentUser.Text = "Current User";
            this.btnCurrentUser.UseVisualStyleBackColor = true;
            this.btnCurrentUser.Click += new System.EventHandler(this.btnCurrentUser_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(696, 360);
            this.Controls.Add(this.btnCurrentUser);
            this.Controls.Add(this.btnFindById);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAuthenticate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Family Search C# SDK Sample App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAuthenticate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFindById;
        private System.Windows.Forms.Button btnCurrentUser;
    }
}

