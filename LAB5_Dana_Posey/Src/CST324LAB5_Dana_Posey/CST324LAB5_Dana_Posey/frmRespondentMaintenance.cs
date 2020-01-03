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
    public partial class frmRespondentMaintenance : Form
    {
        public frmRespondentMaintenance()
        {
            InitializeComponent();
        }

        private void respondentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.respondentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bicycleStoresCorpDataSet);

        }

        private void frmSurveyMaintenance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bicycleStoresCorpDataSet.Responses' table. You can move, or remove it, as needed.
            this.responsesTableAdapter.Fill(this.bicycleStoresCorpDataSet.Responses);
            // TODO: This line of code loads data into the 'bicycleStoresCorpDataSet.Respondents' table. You can move, or remove it, as needed.
            this.respondentsTableAdapter.Fill(this.bicycleStoresCorpDataSet.Respondents);

        }

        private void btnViewSurvey_Click(object sender, EventArgs e)
        {
            frmResponseMaintenance responseMaintenanceForm = new frmResponseMaintenance();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
