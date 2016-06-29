
using System.Windows.Forms;
using FamilySearch.Api.Ft;

namespace FamilySearchSample
{
    public partial class frmPersonAncestry : Form
    {
        /// <summary>
        /// FamilyTree Object to be used in this form.
        /// </summary>
        private FamilySearchFamilyTree p_Ft { get; set; }

        public frmPersonAncestry(FamilySearchFamilyTree ft)
        {
            InitializeComponent();

            //Save ft (familytree object) for use in this form
            //Assumption: ft is initialized and ready to be used
            p_Ft = ft;
        }
    }
}
