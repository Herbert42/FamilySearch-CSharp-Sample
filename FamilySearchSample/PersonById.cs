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
    }
}
