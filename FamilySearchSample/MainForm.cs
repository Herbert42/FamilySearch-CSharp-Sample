﻿using System;
using System.Windows.Forms;
using FamilySearch.Api.Ft;

namespace FamilySearchSample
{
    public partial class MainForm : Form
    {
        //Family search tree.
        FamilySearchFamilyTree demoFamilyTree;

        //Use the Sandbox.
        bool useSandbox = true;

        //Save User ID, Password, and developer Key as properties.
        public string MyUserId { get; set; }
        public string MyPassword { get; set; }
        public string MyDeveloperKey { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAuthenticate_Click(object sender, EventArgs e)
        {
            using (var myform = new UserAuthentication())
            {
                //Show authentication dialog.
                if (myform.ShowDialog() == DialogResult.OK)
                {
                    //Save values.
                    MyUserId = myform.ResultUserId;
                    MyPassword = myform.ResultPassword;
                    MyDeveloperKey = myform.ResultDeveloperKey;

                    //Try to authenticate.
                    if (authenticateMe(MyUserId, MyPassword, MyDeveloperKey))
                    {
                        //Display access token.
                        txtToken.Text = demoFamilyTree.CurrentAccessToken;
                    }
                }
            }
        }

        /// <summary>
        /// Enable Buttons, normally done after successful authentication.
        /// </summary>
        public void EnableButtons()
        {
            btnFindById.Enabled = true;
            btnCurrentUser.Enabled = true;
            btnReadPersonFamily.Enabled = true;
            btnPersonSearch.Enabled = true;
            btnPersonAncestry.Enabled = true;
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
            //We start with Wait Cursor.
            Cursor.Current = Cursors.WaitCursor;

            //Initialize the Family Tree Objects.
            demoFamilyTree = new FamilySearchFamilyTree(useSandbox);

            try
            {
                //Try to authenticate.
                demoFamilyTree.AuthenticateViaOAuth2Password(pUserID, pPassword, pDeveloperKey);

                //Switch on buttons.
                EnableButtons();

                //Indicate success.
                return true;
            }
            catch (Exception myError)
            {
                //Display Error Message.
                txtToken.Text = "Error " + myError.Message.ToString();

                //Indicate authentication unsuccessful.
                return false;
            }
            finally
            {
                //Restore cursor.
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFindById_Click(object sender, EventArgs e)
        {
            using (var myForm = new PersonById(demoFamilyTree))
            {
                //Don't care about return result at this point.
                myForm.ShowDialog();
            }
        }

        private void btnCurrentUser_Click(object sender, EventArgs e)
        {
            using (var myCurrentUserForm = new CurrentUser(demoFamilyTree))
            {
                //We start with Wait Cursor.
                Cursor.Current = Cursors.WaitCursor;

                //See if we can collect and prepare data on form.
                if (myCurrentUserForm.PrepareData())
                {
                    //Display Data. Dont care about return result at this point (again).
                    myCurrentUserForm.ShowDialog();
                }

                //Restore Cursor
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnReadPersonFamily_Click(object sender, EventArgs e)
        {
            using (var myReadPersonsFamilyForm = new PersonFamily(demoFamilyTree))
            {
                //Don't care about return result at this point.
                myReadPersonsFamilyForm.ShowDialog();
            }
        }

        private void btnPersonSearch_Click(object sender, EventArgs e)
        {
            using (var myPersonSearchForm = new PersonSearch(demoFamilyTree))
            {                       
                //Again, don't care about return result at this point.
                myPersonSearchForm.ShowDialog();
            }
        }

        private void btnPersonAncestry_Click(object sender, EventArgs e)
        {
            using (var myPersonAncestrySearchForm = new PersonAncestry(demoFamilyTree))
            {
                //Again, don't care about return result at this point.
                myPersonAncestrySearchForm.ShowDialog();
            }
        }
    }
}
