using System;
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
        private FamilySearchFamilyTree p_Ft { get; set; }

        //Setup Form and save Familytree object.
        public CurrentUser(FamilySearchFamilyTree ft)
        {
            InitializeComponent();

            //Save ft (familytree object) for use in this form.
            //Assumption: ft is initialized and ready to be used.
            p_Ft = ft;
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
                myPerson = p_Ft.ReadPersonById(personID);
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
                txtGender.Text = myPerson.Person.DisplayExtension.Gender;
                chkLiving.Checked = myPerson.Person.Living;
                txtLivespan.Text = myPerson.Person.DisplayExtension.Lifespan;
                txtBirthDate.Text = myPerson.Person.DisplayExtension.BirthDate;
                txtBirthPlace.Text = myPerson.Person.DisplayExtension.BirthPlace;
                txtDeathDate.Text = myPerson.Person.DisplayExtension.DeathDate;
                txtDeathPlace.Text = myPerson.Person.DisplayExtension.DeathPlace;
                txtFullName.Text = myPerson.Person.DisplayExtension.Name;

                //Count of 1 is expected?
                //Note: If more than one name, last name found is displayed. 
                foreach (var name in myPerson.Person.Names ?? new List<Gx.Conclusion.Name>())
                {
                    //Display Lang.
                    txtLang.Text = name.Lang;

                    //Display name parts.
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

                //Try to find Birth under Facts
                foreach (var myFact in myPerson.Person.Facts ?? new List<Gx.Conclusion.Fact>())
                {
                    // Fact a Birth Fact?
                    if (myFact.KnownType == Gx.Types.FactType.Birth)
                    {
                        //Birth info found, display it.
                        txtDateOriginal.Text = myFact.Date.Original;
                        txtDateFormal.Text = myFact.Date.Formal;

                        //Make sure List is not empty.
                        if (myFact.Date.NormalizedExtensions.Any())
                        {
                            //Hack Vorsicht: hard coded
                            txtDateNormalized.Text = myFact.Date.NormalizedExtensions[0].Value;
                        }
                    }
                }
            }
            else
            {
                //No person found, return false for failure.
                return false;
            }

            //We are done: success
            return true;
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
                myUser = p_Ft.ReadCurrentUser();
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
