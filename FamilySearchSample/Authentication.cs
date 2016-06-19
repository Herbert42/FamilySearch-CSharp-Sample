using System;
using System.Windows.Forms;

namespace FamilySearchSample
{
    public partial class UserAuthentication : Form
    {
        public string ResultUserId { get; set; }
        public string ResultPassword { get; set; }
        public string ResultDeveloperKey { get; set; }
 
        public UserAuthentication()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Save values to properties
            ResultUserId = txtUserId.Text;
            ResultPassword = txtPassword.Text;
            ResultDeveloperKey = txtDeveloperKey.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
