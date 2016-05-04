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
using Gx.Rs.Api;

namespace FamilySearchSample
{
    public partial class PersonById : Form
    {

        public FamilySearchFamilyTree p_Ft { get; set; }

        //Get a authenticated familytree as parameter
        public PersonById(FamilySearchFamilyTree ft)
        {
            InitializeComponent();

            //save ft (familytree object) for use in this form
            //assumption: ft is initialized and ready to be used
            p_Ft = ft;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnRetriveById_Click(object sender, EventArgs e)
        {
            //try to display person info
            if (txtPersonId.Text == "")
            {
                lblErrorMessage.Text = "Please enter a Person ID.";
            }
            else
            {
                //copy ID to label
                lblPersonID.Text = txtPersonId.Text;

                //first clear old results (if any)
                clearAllTextBoxes(this.Controls);

                //display person's data
                //bool result not needed at this point. Intended for future extensions
                bool displayResult = displayPersonByIdData(lblPersonID.Text);
            }
        }

        /// <summary>
        /// Display person data for PersonById Form. Displays error message as needed.
        /// </summary>
        /// <param name="personID">ID for person to find</param>
        /// <returns>true if successful, false otherwise</returns>
        private bool displayPersonByIdData(string personID)
        {
            //prepare Person
            PersonState myPerson;

            try
            {
                //try to read Person by ID
                myPerson = p_Ft.ReadPersonById(personID);
            }
            catch (Exception myError)
            {
                //display error
                lblErrorMessage.Text = myError.Message.ToString();

                //return false for failure
                return false;
            }

            //be on the safe side
            if (myPerson.Person != null)
            {
                //person found, display some info about Person
                txtGender.Text = myPerson.Person.DisplayExtension.Gender;
                chkLiving.Checked = myPerson.Person.Living;
                txtLivespan.Text = myPerson.Person.DisplayExtension.Lifespan;
                txtBirthDate.Text = myPerson.Person.DisplayExtension.BirthDate;
                txtBirthPlace.Text = myPerson.Person.DisplayExtension.BirthPlace;
                txtDeathDate.Text = myPerson.Person.DisplayExtension.DeathDate;
                txtDeathPlace.Text = myPerson.Person.DisplayExtension.DeathPlace;
                txtFullName.Text = myPerson.Person.DisplayExtension.Name;

                //todo Clean this up
                ////count of 1 is expected?, display for educational purpose
                //lblErrorMessage.Text = "Count of Names: " + myPerson.Person.Names.Count;

                //to avoid hard coded indices :
                //Note: If more than one name, last name found is displayed. 
                foreach (var name in myPerson.Person.Names)
                {
                    //display Lang
                    txtLang.Text = name.Lang;

                    //Display name parts
                    foreach (var part in name.NameForm.Parts)
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

                //try to find Birth under Facts
                foreach (var myFact in myPerson.Person.Facts)
                {
                    // Fact a Birth Fact?
                    if (myFact.KnownType == Gx.Types.FactType.Birth)
                    {
                        //Birth info found, display it
                        txtDateOriginal.Text = myFact.Date.Original;
                        txtDateFormal.Text = myFact.Date.Formal;

                        //make sure List is not empty
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
                //no peron found return false for failure
                return false;
            }

            //We are done: success
            return true;
        }

        /// <summary>
        /// Recursively clear Text in all textboxes, regardless where they are on the form.
        /// </summary>
        /// <param name="parentObject">Collection of controls</param>
        private void clearAllTextBoxes(Control.ControlCollection parentObject)
        {
            foreach (Control childObject in parentObject)
            {
                //See if we have a textBox
                TextBox childTextBox = childObject as TextBox;

                if (childTextBox != null)
                    //TextBox found
                    childTextBox.Clear();
                else
                    //Not a textBox, keep looking
                    clearAllTextBoxes(childObject.Controls);
            }
        }
    }
}
