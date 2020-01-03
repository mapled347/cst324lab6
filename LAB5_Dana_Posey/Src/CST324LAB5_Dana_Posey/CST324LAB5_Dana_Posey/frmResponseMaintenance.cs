using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST324LAB5_Dana_Posey
{
    public partial class frmResponseMaintenance : Form
    {
        public frmResponseMaintenance()
        {
            InitializeComponent();
        }

        private void responsesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.responsesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bicycleStoresCorpDataSet);

        }

        private void frmResponseMaintenance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bicycleStoresCorpDataSet.Responses' table. You can move, or remove it, as needed.
            this.responsesTableAdapter.Fill(this.bicycleStoresCorpDataSet.Responses);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ResponsesDB.DeleteResponse(Convert.ToInt32(txtResponseID.Text)))
            {
                MessageBox.Show("Response has been deleted.", "DELETED!");
            }
            else
            {
                MessageBox.Show("Response could not be deleted.", "ERROR!");
                return;
            }
        }
    }
}
