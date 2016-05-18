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
    public partial class PersonFamily : Form
    {

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
                HerbsTools.clearAllTextBoxes(this.Controls);

                //display person's data
                //bool result not needed at this point. Intended for future extensions
                bool displayResult = displayPersonsFamilyByID(lblPersonID.Text);
            }
        }

        private bool displayPersonsFamilyByID(string personID)
        {
            //Prepare Person.
            FamilyTreePersonState myPerson;

            //Prepare Parents
            PersonParentsState myParents;

            //First Clear Listbox
            listBoxDisplayFacts.Items.Clear();

            try
            {
                //try to read Person by ID
                myPerson = p_Ft.ReadPersonWithRelationshipsById(personID);
            }
            catch (Exception myError)
            {
                //Display error
                lblErrorMessage.Text = myError.Message.ToString();

                //Return false for failure
                return false;
            }

            //Be on the save side.
            if (myPerson.Person != null)
            {
                listBoxDisplayFacts.Items.Add("Family Facts for " + personID
                    + " (" + myPerson.Person.DisplayExtension.Name + ")");

                //Get the parents
                myParents = myPerson.ReadParents();

                //look in myParents Persons for parents names and dates
                //myParents.Persons = list of parents
                // change this to "??"
                if (myParents.Persons != null)
                {
                    //Cycle through
                    foreach (var person in myParents.Persons)
                    {
                        if (person.Gender.KnownType == Gx.Types.GenderType.Male)
                        {
                            //Father found.
                            listBoxDisplayFacts.Items.Add("Father: " + person.Id
                                + " (" + person.DisplayExtension.Name + ")"
                                + " Lifespan " + person.DisplayExtension.Lifespan);

                            foreach (var relationship in myPerson.ChildAndParentsRelationships ?? new List<Gx.Fs.Tree.ChildAndParentsRelationship>())
                            {
                                listBoxDisplayFacts.Items.Add("Father rescource ID: " + relationship.Father.ResourceId);
                                foreach (var aFact in relationship.FatherFacts ?? new List<Gx.Conclusion.Fact>())
                                {
                                    listBoxDisplayFacts.Items.Add(aFact.KnownType.ToString());
                                }
                            }
                        }

                        if (person.Gender.KnownType == Gx.Types.GenderType.Female)
                        {
                            //Mother found.
                            listBoxDisplayFacts.Items.Add("Mother: " + person.Id
                                + " (" + person.DisplayExtension.Name + ")"
                                + " Lifespan " + person.DisplayExtension.Lifespan
                                );

                            foreach (var relationship in myPerson.ChildAndParentsRelationships ?? new List<Gx.Fs.Tree.ChildAndParentsRelationship>())
                            {
                                listBoxDisplayFacts.Items.Add("Mother rescource ID: " + relationship.Mother.ResourceId);
                                foreach (var aFact in relationship.MotherFacts ?? new List<Gx.Conclusion.Fact>())
                                {
                                    listBoxDisplayFacts.Items.Add(aFact.KnownType.ToString());
                                }
                            }
                        }
                    }
                }
            }

            //We are done: success
            return true;

        }
    }
}
