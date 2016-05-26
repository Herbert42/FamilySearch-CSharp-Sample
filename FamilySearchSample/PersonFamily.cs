﻿using System;
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
        /// <param name="personID">Person ID whose parents are examined</param>
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
        /// Main procedure to display some Facts about a Persons Family on the form.
        /// </summary>
        /// <param name="pPerson">Person whose family is to be displayed</param>
        private void showFamilyFacts(FamilyTreePersonState pPerson)
        {
            //Define Parents
            PersonParentsState myParents;

            //Get a headline out.
            listBoxDisplayFacts.Items.Add("Family Facts for " + pPerson.Person.Id
                + " (" + pPerson.Person.DisplayExtension.Name + ")"
                + " Lifespan " + pPerson.Person.DisplayExtension.Lifespan);

            //Add a little separation after displaying headline.
            listBoxDisplayFacts.Items.Add(" ");

            //Get the parents.
            myParents = pPerson.ReadParents();

            //Look in myParents.Persons for parents, names, and dates.
            foreach (var parentFound in myParents.Persons ?? new List<Person>())
            {
                //Display all Father Facts on the form.
                displayAllFatherFacts(parentFound, pPerson);

                //Display all Mother Facts on the form.
                displayAllMotherFacts(parentFound, pPerson);
            }
        }

        /// <summary>
        /// Display all Father Facts
        /// </summary>
        /// <param name="parentFound">A parent that ws found.</param>
        /// <param name="pFTPerson">The original Familytree Person.</param>
        private void displayAllFatherFacts(Person parentFound, FamilyTreePersonState pFTPerson)
        {
            //Look at Father Facts only
            if (parentFound.Gender.KnownType == GenderType.Male)
            {
                //Show Father headline.
                listBoxDisplayFacts.Items.Add("Father: " + parentFound.Id
                    + " (" + parentFound.DisplayExtension.Name + ")"
                    + " Lifespan " + parentFound.DisplayExtension.Lifespan);

                //Read Relationships.
                foreach (var relationship in pFTPerson.ChildAndParentsRelationships ?? new List<ChildAndParentsRelationship>())
                {
                    //Display Father Relationship facts on form.
                    displayFatherRelationship(relationship);
                }
                //Add a little separation after displaying facts.
                listBoxDisplayFacts.Items.Add(" ");
            }
        }

        /// <summary>
        /// Displays all Mother Facts.
        /// </summary>
        /// <param name="parentFound">A parent that was found.</param>
        /// <param name="pFtPerson">The original Familytree Person.</param>
        private void displayAllMotherFacts(Person parentFound, FamilyTreePersonState pFtPerson)
        {
            //Look at Mother Facts only
            if (parentFound.Gender.KnownType == GenderType.Female)
            {
                //Show Mother headline.
                listBoxDisplayFacts.Items.Add("Mother: " + parentFound.Id
                    + " (" + parentFound.DisplayExtension.Name + ")"
                    + " Lifespan " + parentFound.DisplayExtension.Lifespan
                    );

                //Read Relationships.
                foreach (var relationship in pFtPerson.ChildAndParentsRelationships ?? new List<ChildAndParentsRelationship>())
                {
                    //Display Mother Relationship facts on form.
                    displayMotherRelationship(relationship);
                }
                //Add a little separation after displaying facts.
                listBoxDisplayFacts.Items.Add(" ");
            }
        }

        /// <summary>
        /// Display Father Relationship facts.
        /// </summary>
        /// <param name="pRelationship">Relationship of Father.</param>
        private void displayFatherRelationship(ChildAndParentsRelationship pRelationship)
        {
            //Show Father ID.
            listBoxDisplayFacts.Items.Add("Father rescource ID: " + pRelationship.Father.ResourceId);

            //Show Relationship.
            foreach (var aFact in pRelationship.FatherFacts ?? new List<Fact>())
            {
                listBoxDisplayFacts.Items.Add(aFact.KnownType.ToString());
            }
        }

        /// <summary>
        /// Display Mother Relationship facts.
        /// </summary>
        /// <param name="pRelationship">Relationship of Mother</param>
        private void displayMotherRelationship(ChildAndParentsRelationship pRelationship)
        {
            //Show Mother ID.
            listBoxDisplayFacts.Items.Add("Mother rescource ID: " + pRelationship.Mother.ResourceId);

            //Show Relationship.
            foreach (var aFact in pRelationship.MotherFacts ?? new List<Fact>())
            {
                listBoxDisplayFacts.Items.Add(aFact.KnownType.ToString());
            }
        }

    }
}
