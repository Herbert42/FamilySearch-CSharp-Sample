﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FamilySearch.Api.Ft;
using Gx.Atom;
using Gx.Rs.Api;
using Gx.Rs.Api.Util;

namespace FamilySearchSample
{
    public partial class PersonSearch : Form
    {
        /// <summary>
        /// FamilyTree Object to be used in this form.
        /// </summary>
        private FamilySearchFamilyTree FamilyTree { get; set; }

        public PersonSearch(FamilySearchFamilyTree ft)
        {
            InitializeComponent();

            //Save ft (familytree object) for use in this form.
            //Assumption: ft is initialized and ready to be used.
            FamilyTree = ft;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Remember cursor and change to wait-cursor.
            var cursorState = Cursor;
            Cursor = Cursors.WaitCursor;

            //Hack Vorsicht hard coded.
            lblErrorMessage.Text = "No Error.";
             
            try
            {
                //Put together a search query.
                GedcomxPersonSearchQueryBuilder query = new GedcomxPersonSearchQueryBuilder()

                //Set all on the form available Parameter for query.
                //Note: This is just a sample of available Parameters'
                .GivenName(txtGivenName.Text)
                .Surname(txtSurname.Text)
                .BirthDate(txtBirthDate.Text)
                .FatherGivenName(txtFatherGivenName.Text)
                .FatherSurname(txtFatherSurname.Text)
                .FatherBirthDate(txtFatherBirthDate.Text)
                .MotherGivenName(txtMotherGivenName.Text)
                .MotherSurname(txtMotherSurname.Text)
                .MotherBirthDate(txtMotherBirthDate.Text);
                       
                //Search the collection.
                PersonSearchResultsState resultsSearchPersons = FamilyTree.SearchForPersons(query);

                //Show results on Form.
                DisplayPersonSearchResults(resultsSearchPersons);
                 
            }
            catch (Exception myError)
            {
                //report error to error label
                lblErrorMessage.Text = myError.Message.ToString();
            }
            finally
            {
                // Restore Cursor.
                Cursor = cursorState;
            }
        }

        /// <summary>
        /// Displays information found by a person search.
        /// </summary>
        /// <param name="searchResults">Result state of a SearchForPersons search.</param>
        private void DisplayPersonSearchResults(PersonSearchResultsState searchResults)
        {
            //Declare a person.
            PersonState person;

            //Clear ResultBox.
            ResultBox.Items.Clear();

            //Search through the result list.
            foreach (Entry singleEntry in searchResults.Results.Entries ?? new List<Entry>())
            {
                //Get a person
                person = searchResults.ReadPerson(singleEntry);

                //Display some person info
                ResultBox.Items.Add(person.Person.DisplayExtension.Name + " "
                    + person.Person.Id);

                //Display it right away, we are inpatient.
                ResultBox.Update();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}