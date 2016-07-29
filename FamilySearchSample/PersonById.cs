using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FamilySearch.Api.Ft;
using Gx.Rs.Api;

namespace FamilySearchSample
{
    public partial class PersonById : Form
    {
        /// <summary>
        /// FamilyTree Object to be used in this form.
        /// </summary>
        private FamilySearchFamilyTree FamilyTree { get; set; }

        //Setup Form and save Familytree object.
        public PersonById(FamilySearchFamilyTree originalFamilyTree)
        {
            InitializeComponent();

            //Save originalFamilyTree  for use in this form
            //Assumption: originalFamilyTree is initialized and ready to be used
            FamilyTree = originalFamilyTree;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnRetriveById_Click(object sender, EventArgs e)
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

                //First clear old results (if any)
                HerbsTools.ClearAllTextBoxes(this.Controls);

                //Display person's data
                //bool result not needed at this point. Intended for future extensions
                bool displayResult = DisplayPersonByIdData(lblPersonID.Text);
            }

            // Restore Cursor.
            Cursor = cursorState;
        }

        /// <summary>
        /// Display person data for PersonById Form. Displays error message as needed.
        /// </summary>
        /// <param name="personID">ID for person to find</param>
        /// <returns>true if successful, false otherwise</returns>
        private bool DisplayPersonByIdData(string personID)
        {
            //Prepare Person
            PersonState myPerson;

            try
            {
                //Try to read Person by ID
                myPerson = FamilyTree.ReadPersonById(personID);
            }
            catch (Exception myError)
            {
                //Display error.
                lblErrorMessage.Text = myError.Message.ToString();

                //Return false for failure.
                return false;
            }

            //Be on the safe side.
            if (myPerson.Person != null)
            {
                //Person found, display some info about Person.
                DisplayExtensionData(myPerson);

                //Display name parts of person.
                DisplayNameParts(myPerson);

                //Display person's Birth facts.
                DisplayBirthFacts(myPerson);
            }
            else
            {
                //No person found return false for failure.
                return false;
            }
            //We are done: success.
            return true;
        }

        /// <summary>
        /// Display Person's Display Extensions.
        /// </summary>
        /// <param name="displayPerson">Person to be displayed.</param>
        private void DisplayExtensionData(PersonState displayPerson)
        {
            //Display selected Info about person.
            txtGender.Text = displayPerson.Person.DisplayExtension.Gender;
            chkLiving.Checked = displayPerson.Person.Living;
            txtLivespan.Text = displayPerson.Person.DisplayExtension.Lifespan;
            txtBirthDate.Text = displayPerson.Person.DisplayExtension.BirthDate;
            txtBirthPlace.Text = displayPerson.Person.DisplayExtension.BirthPlace;
            txtDeathDate.Text = displayPerson.Person.DisplayExtension.DeathDate;
            txtDeathPlace.Text = displayPerson.Person.DisplayExtension.DeathPlace;
            txtFullName.Text = displayPerson.Person.DisplayExtension.Name;
        }

        /// <summary>
        /// Display Person's Name Parts.
        /// </summary>
        /// <param name="displayPerson">Person to be displayed.</param>
        private void DisplayNameParts(PersonState displayPerson)
        {
            //Note: If more than one name, last name found is displayed. 
            foreach (var name in displayPerson.Person.Names ?? new List<Gx.Conclusion.Name>())
            {
                //Display Lang
                txtLang.Text = name.Lang;

                //Display name parts
                foreach (var part in name.NameForm.Parts ?? new List<Gx.Conclusion.NamePart>())
                {
                    if (part.KnownType == Gx.Types.NamePartType.Given)
                    {
                        txtGivenName.Text = part.Value;
                    }
                    if (part.KnownType == Gx.Types.NamePartType.Surname)
                    {
                        txtSurname.Text = part.Value;
                    }
                }
            }
        }

        /// <summary>
        /// Display person's birth facts.
        /// </summary>
        /// <param name="displayPerson">Person to be displayed.</param>
        private void DisplayBirthFacts(PersonState displayPerson)
        {
            //Try to find Birth under Facts.
            foreach (var myFact in displayPerson.Person.Facts ?? new List<Gx.Conclusion.Fact>())
            {
                //Fact a Birth Fact?
                if (myFact.KnownType == Gx.Types.FactType.Birth)
                {
                    //Birth info found, display it.
                    txtDateOriginal.Text = myFact.Date.Original;
                    txtDateFormal.Text = myFact.Date.Formal;

                    //Make sure List is not empty.
                    if (myFact.Date.NormalizedExtensions.Any())
                    {
                        //Hack Vorsicht: hard coded.
                        txtDateNormalized.Text = myFact.Date.NormalizedExtensions[0].Value;
                    }
                }
            }
        }
    }
}
