using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FamilySearch.Api.Ft;
using Gx.Rs.Api;
using Gx.Conclusion;
using Gx.Fs.Tree;
using Gx.Types;

namespace FamilySearchSample
{
    public partial class PersonFamily : Form
    {
        /// <summary>
        /// FamilyTree Object to be used in this form.
        /// </summary>
        public FamilySearchFamilyTree p_Ft { get; set; }

        /// <summary>
        /// Initialize PersonFamily form.
        /// </summary>
        /// <param name="ft">Familytree Object, expected to be initialized.</param>
        public PersonFamily(FamilySearchFamilyTree ft)
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

        private void btnReadPersonFamilyById_Click(object sender, EventArgs e)
        {
            //Reset Message label.
            lblErrorMessage.Text = "No current message.";

            //Try to display person info.
            if (txtPersonId.Text == "")
            {
                lblErrorMessage.Text = "Please enter a Person ID.";
            }
            else
            {
                //Copy ID to label. This way it is visible and saved.
                lblPersonID.Text = txtPersonId.Text;

                //First clear old results (if any)
                HerbsTools.clearAllTextBoxes(this.Controls);

                //Display person's data.
                //Boolean result not needed at this point. Intended for future extensions.
                bool displayResult = displayPersonsFamilyByID(lblPersonID.Text);

                //todo use displayResult for message lable if you evaluate displayResult. 
            }
        }

        /// <summary>
        /// Display FamilyFacts of a person by ID.
        /// </summary>
        /// <param name="personID"></param>
        /// <returns>True if successful, false otherwise.</returns>
        private bool displayPersonsFamilyByID(string personID)
        {
            //Prepare Person.
            FamilyTreePersonState myPerson;
           
            //First Clear Listbox, making room for new Facts.
            listBoxDisplayFacts.Items.Clear();

            try
            {
                //Try to read Person by ID.
                myPerson = p_Ft.ReadPersonWithRelationshipsById(personID);
            }
            catch (Exception myError)
            {
                //Display error
                lblErrorMessage.Text = myError.Message.ToString();

                //Return false for failure.
                return false;
            }

            //Do we actually have a person?
            if (myPerson.Person != null)
            {
                //Show Facts on Form.
                showFamilyFacts(myPerson);
            }

            //We are done: success.
            return true;
        }

        /// <summary>
        /// Display some Facts about a Persons Family on the form.
        /// </summary>
        /// <param name="pPerson">Person to be displayed</param>
        private void showFamilyFacts(FamilyTreePersonState pPerson)
        {
            //Define Parents
            PersonParentsState myParents;

            //Get a headline out.
            listBoxDisplayFacts.Items.Add("Family Facts for " + pPerson.Person.Id
                + " (" + pPerson.Person.DisplayExtension.Name + ")");

            //Get the parents.
            myParents = pPerson.ReadParents();

            //look in myParents.Persons for parents names and dates.
            foreach (var person in myParents.Persons ?? new List<Person>())
            {
                //Handle Father.
                if (person.Gender.KnownType == GenderType.Male)
                {
                    //Father found.
                    listBoxDisplayFacts.Items.Add("Father: " + person.Id
                        + " (" + person.DisplayExtension.Name + ")"
                        + " Lifespan " + person.DisplayExtension.Lifespan);

                    //Read Relationships.
                    foreach (var relationship in pPerson.ChildAndParentsRelationships ?? new List<ChildAndParentsRelationship>())
                    {
                        //Show Father ID.
                        listBoxDisplayFacts.Items.Add("Father rescource ID: " + relationship.Father.ResourceId);

                        //Show Relationship.
                        foreach (var aFact in relationship.FatherFacts ?? new List<Fact>())
                        {
                            listBoxDisplayFacts.Items.Add(aFact.KnownType.ToString());
                        }
                    }
                }

                //Handle Mother.
                if (person.Gender.KnownType == GenderType.Female)
                {
                    //Mother found.
                    listBoxDisplayFacts.Items.Add("Mother: " + person.Id
                        + " (" + person.DisplayExtension.Name + ")"
                        + " Lifespan " + person.DisplayExtension.Lifespan
                        );

                    //Read Relationships.
                    foreach (var relationship in pPerson.ChildAndParentsRelationships ?? new List<ChildAndParentsRelationship>())
                    {
                        //Show Mother ID.
                        listBoxDisplayFacts.Items.Add("Mother rescource ID: " + relationship.Mother.ResourceId);

                        //Read Relationships.
                        foreach (var aFact in relationship.MotherFacts ?? new List<Fact>())
                        {
                            listBoxDisplayFacts.Items.Add(aFact.KnownType.ToString());
                        }
                    }
                }
            }
        }

    }
}
