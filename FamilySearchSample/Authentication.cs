using System;
using System.Windows.Forms;

namespace FamilySearchSample
{
    public partial class Authentication : Form
    {
        public string resultUserId { get; set; }
        public string resultPassword { get; set; }
        public string resultDeveloperKey { get; set; }
 
        public Authentication()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Save values to properties
            resultUserId = txtUserId.Text;
            resultPassword = txtPassword.Text;
            resultDeveloperKey = txtDeveloperKey.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
