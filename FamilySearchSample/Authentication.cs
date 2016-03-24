using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.resultUserId = txtUserId.Text;
            this.resultPassword = txtPassword.Text;
            this.resultDeveloperKey = txtDeveloperKey.Text;
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
