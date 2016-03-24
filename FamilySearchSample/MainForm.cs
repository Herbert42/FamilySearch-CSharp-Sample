using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FamilySearch.Api.Ft;

namespace FamilySearchSample
{
    public partial class MainForm : Form
    {
        //global Family search tree
        FamilySearchFamilyTree ft;

        //Use the Sandbox
        bool useSandbox = true;

        //Save Userinput-ID Password and developer Key as properties
        public string aUserID { get; set; }
        public string aPassword { get; set; }
        public string aDeveloperKey { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAuthenticate_Click(object sender, EventArgs e)
        {
            using (var myform = new Authentication())
            {
                //Show authentication dialog
                if (myform.ShowDialog() == DialogResult.OK)
                {
                    //Save values
                    aUserID = myform.resultUserId;
                    aPassword = myform.resultPassword;
                    aDeveloperKey = myform.resultDeveloperKey;

                    //Try to authenticate
                    if (authenticateMe(aUserID, aPassword, aDeveloperKey))
                    {
                        //Display accrss token
                        txtToken.Text = ft.CurrentAccessToken;
                    }
                }
            }
        }

        // ==============================================================================================

        /// <summary>
        /// Enable Buttons, normally done after successful authentication.
        /// </summary>
        public void enableButtons()
        {

        }

        /// <summary>
        /// Authenticate Familytree Object
        /// </summary>
        /// <param name="pUserID">User ID from input</param>
        /// <param name="pPassword">Password from user input</param>
        /// <param name="pDeveloperKey">Developer Key from user input</param>
        public bool authenticateMe(string pUserID, string pPassword, string pDeveloperKey)
        {
            //We start with Wait Cursor
            Cursor.Current = Cursors.WaitCursor;

            //initialize the Family Tree Objects
            ft = new FamilySearchFamilyTree(useSandbox);

            try
            {
                //try to authenticate
                ft.AuthenticateViaOAuth2Password(pUserID, pPassword, pDeveloperKey);

                //switch on buttons
                enableButtons();

                //resture cursor
                Cursor.Current = Cursors.Default;

                //indicate success
                return true;
            }
            catch (Exception myError)
            {
                //Display Error Message
                txtToken.Text = "Error " + myError.Message.ToString();

                //resture cursor
                Cursor.Current = Cursors.Default;

                //indicate authentication unsuccessful
                return false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
