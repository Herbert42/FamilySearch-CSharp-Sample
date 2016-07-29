
using System;
using System.Windows.Forms;
using FamilySearch.Api.Ft;
using Gx.Rs.Api;
using Gx.Rs.Api.Options;
using Gx.Rs.Api.Util;

namespace FamilySearchSample
{
    public partial class PersonAncestry : Form
    {
        /// <summary>
        /// FamilyTree Object to be used in this form.
        /// </summary>
        private FamilySearchFamilyTree FamilyTree { get; set; }

        public PersonAncestry(FamilySearchFamilyTree originalFamilyTree)
        {
            InitializeComponent();

            //Save originalFamilyTree for use in this form
            //Assumption: originalFamilyTree is initialized and ready to be used
            FamilyTree = originalFamilyTree;
        }

        private void btnReadPersonAncestry_Click(object sender, System.EventArgs e)
        {
            //Remember cursor and change to wait-cursor.
            var cursorState = Cursor;
            Cursor = Cursors.WaitCursor;

            //Try to display person info
            if (string.IsNullOrEmpty(txtPersonId.Text))
            {
                lblErrorMessage.Text = "Please enter a Person ID.";
            }
            else
            {
                //Copy ID to label
                lblPersonID.Text = txtPersonId.Text;

                //Display person's data.
                //Boolean result not needed at this point. Intended for future extensions.
                bool displayResult = displayPersonsAncestry(lblPersonID.Text);
            }

            //Restore Cursor.
            Cursor = cursorState;
        }

        /// <summary>
        /// Main procedure to display ancestry of a person
        /// </summary>
        /// <param name="personID">Id of target person.</param>
        /// <returns>True if successful, false otherwise.</returns>
        private bool displayPersonsAncestry(string personID)
        {
            //Declare an Ancestry.
            AncestryResultsState myAncestry;
            //Declare a Person
            PersonState myPerson;
            //Number of generations to retrieve.
            const int countOfGenerations = 5;

            try
            {  
                //Get Target Person.
                myPerson = FamilyTree.ReadPersonById(personID);

                //Read that person's ancestry.
                myAncestry = myPerson.ReadAncestry(QueryParameter.Generations(countOfGenerations));
            }
            catch (Exception myError)
            {
                //Display error.
                lblErrorMessage.Text = myError.Message.ToString();

                //Return false for failure.
                return false;
            }

            //Do we have ancestry?
            if (myAncestry != null)
            {
                //Display Ancestry
                showAncestryOnForm(myAncestry, countOfGenerations);
            }

            //We are done: success.
            return true;
        }

        /// <summary>
        ///   Display Ancestry on Form.
        /// </summary>
        /// <param name="ancestryToExtract">Ancestry result to be examined.</param>
        /// <param name="numberOfGenerations">Count of generations.</param>
        private void showAncestryOnForm(AncestryResultsState ancestryToExtract, int numberOfGenerations)
        {   
            //Clear old output.
            listBoxDisplayAncestry.Items.Clear();

            //With numberOfGenerations Generatons, the proband being number 1, we have a max of
            //((2 to the power of numberOfGenerations) - 1) Ahnen-Numbers (Ancestry Numbers)
            for (int index = 1; index <= Math.Pow(2, numberOfGenerations) - 1; index++)
            {
                //Define an Ancestor as Node.
                AncestryTree.AncestryNode anAncestor;

                //Look for Ancestor.
                anAncestor = ancestryToExtract.Tree.GetAncestor(index);

                //Did we get one?
                if (anAncestor != null)
                {
                    //Display some selected Info of Ancestor found.
                    listBoxDisplayAncestry.Items.Add(anAncestor.Person.Id + " "
                            + anAncestor.Person.DisplayExtension.Name + " "
                            + anAncestor.Person.DisplayExtension.AscendancyNumber);
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
