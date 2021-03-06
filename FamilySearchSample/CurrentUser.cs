﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FamilySearch.Api;
using FamilySearch.Api.Ft;
using Gx.Rs.Api;

namespace FamilySearchSample
{
    public partial class CurrentUser : Form
    {
        //Provide FamilyTree object as property.
        private FamilySearchFamilyTree FamilyTree { get; set; }

        //Setup Form and save Familytree object.
        public CurrentUser(FamilySearchFamilyTree originalFamilyTree)
        {
            InitializeComponent();

            //Save originalFamilyTree for use in this form.
            //Assumption: originalFamilyTree is initialized and ready to be used.
            FamilyTree = originalFamilyTree;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Display person data for PersonById Form. Displays error message as needed.
        /// </summary>
        /// <param name="personID">ID for person to find.</param>
        /// <returns>true if successful, false otherwise.</returns>
        private bool displayPersonByIdData(string personID)
        {
            //Define local helper variable.
            PersonState myPerson;

            try
            {
                //Try to read Person by ID.
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
                //No person found, return false for failure.
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

                    //Make sure List contains  any elements.
                    if (myFact.Date.NormalizedExtensions.Any())
                    {
                        //Hack Vorsicht: hard coded. Only interested in the first element.
                        txtDateNormalized.Text = myFact.Date.NormalizedExtensions[0].Value;
                    }
                }
            }
        }

        /// <summary>
        /// Collect data and display on form. Done before calling showDialog.
        /// Entry Point before form is displayed.
        /// </summary>
        /// <returns>true if successful, false otherwise.</returns>
        public bool PrepareData()
        {
            //Define local helper variable.
            UserState myUser;

            try
            {
                //Get current user.
                myUser = FamilyTree.ReadCurrentUser();
            }
            catch
            {
                //Return false for failure.
                return false;
            }

            //Write ID from user profile to label.
            lblUserID.Text = myUser.User.PersonId;

            //Clear old results (if any).
            HerbsTools.ClearAllTextBoxes(Controls);

            //Display person's data.
            //bool result not needed at this point. Intended for future extensions.
            bool displayResult = displayPersonByIdData(lblUserID.Text);

            //Report: action was unsuccessful.
            return true;
        }
    }
}
