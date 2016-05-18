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
        //Family search tree
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
                        //Display access token
                        txtToken.Text = ft.CurrentAccessToken;
                    }
                }
            }
        }

        /// <summary>
        /// Enable Buttons, normally done after successful authentication.
        /// </summary>
        public void enableButtons()
        {
            btnFindById.Enabled = true;
            btnCurrentUser.Enabled = true;
            btnReadPersonFamily.Enabled = true;
        }

        /// <summary>
        /// Authenticate Familytree Object.
        /// </summary>
        /// <returns> True if authentication was successful, false otherwise</returns>
        /// <param name="pUserID">User ID from input</param>
        /// <param name="pPassword">Password from user input</param>
        /// <param name="pDeveloperKey">Developer Key from user input</param>
        private bool authenticateMe(string pUserID, string pPassword, string pDeveloperKey)
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

                //restore cursor
                Cursor.Current = Cursors.Default;

                //indicate authentication unsuccessful
                return false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFindById_Click(object sender, EventArgs e)
        {
            using (var myForm = new PersonById(ft))
            {
                //dont care about return result at this point
                myForm.ShowDialog();
            }
        }

        private void btnCurrentUser_Click(object sender, EventArgs e)
        {
            using (var myCurrentUserForm = new CurrentUser(ft))
            {
                //We start with Wait Cursor
                Cursor.Current = Cursors.WaitCursor;

                //See if we can collect and prepare data on form
                if (myCurrentUserForm.prepareData())
                {
                    //Display Data. Dont care about return result at this point (again)
                    myCurrentUserForm.ShowDialog();
                }
                //todo else give some feedback

                //Restore Cursor
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnReadPersonFamily_Click(object sender, EventArgs e)
        {
            using (var myReadPersonsFamilyForm = new PersonFamily(ft))
            {
                //dont care about return result at this point
                myReadPersonsFamilyForm.ShowDialog();
            }
        }
    }
}
