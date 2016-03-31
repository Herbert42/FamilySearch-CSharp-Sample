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

            //save ft for use in this form
            p_Ft = ft;
           
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnRetriveById_Click(object sender, EventArgs e)
        {
            if (txtPersonId.Text == "")
            {
                lblErrorMessage.Text = "Please enter a Person ID.";
            }
            else
            {
                bool displayResult = displayPersonByIdData(txtPersonId.Text);
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
                //person found
                //display gender
                txtGender.Text = myPerson.Person.DisplayExtension.Gender;

                //todo display more
               
            }
            else
            {
                //no peron found return false for failure
                return false;
            }

            //We are done: success
            return true;
        }
    }
}
