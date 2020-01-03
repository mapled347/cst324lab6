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
    public partial class frmSurvey : Form
    {
        public frmSurvey()
        {
            InitializeComponent();
        }

        private Respondent respondent = new Respondent();
        private Response response = new Response();

        private void respondentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.respondentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bicycleStoresCorpDataSet);

        }

        private void Survey_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bicycleStoresCorpDataSet.Responses' table. You can move, or remove it, as needed.
            this.responsesTableAdapter.Fill(this.bicycleStoresCorpDataSet.Responses);
            // TODO: This line of code loads data into the 'bicycleStoresCorpDataSet.Respondents' table. You can move, or remove it, as needed.
            // this.respondentsTableAdapter.Fill(this.bicycleStoresCorpDataSet.Respondents);

        }


        private void txtAnswer1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnswer2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnswer3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnswer4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnswer5_TextChanged(object sender, EventArgs e)
        {

        }

        private void answer6TextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit the survey without submitting?", "Cancel Survey", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Kill Survey
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                // Go back to survey
                return;
            }
        }

        private void txtEmailAddress_TextChanged(object sender, EventArgs e)
        {
            // see if email exists in respondents table
            if (RespondentsDB.EmailExists(txtEmailAddress.Text))
            {
                GetRespondent(txtEmailAddress.Text);
                DateTime nextSurveyDate = respondent.LastSurvey.AddYears(1);
                DisplayRespondent();
                DisableRespondentForm();
                txtAnswer1.Focus();
                
                // if email exists, look up the LastSurveyDate to see if a survey was taken in the last year
                // if the email took a survey in the last year, throw a message and tell the survey taker they cannot complete another survey for n days
                // and fill in the fields with the last survey's answers
                if (!RespondentsDB.CheckLastSurveyDate(txtEmailAddress.Text))
                {
                    MessageBox.Show("It has been less than a year since you responded to this survey. Please come back after " + nextSurveyDate.ToString() + "!", "Oops!");
                    GetResponse(GetLastResponseID(respondent.RespondentID));
                    DisplayResponses();
                    DisableResponseForm();
                }
                // if it has been over a year, continue
                else return;
            }
            // if email doesn't exist, continue
            else return;
        }

        private int GetLastRespondentID()
        {
            try
            {
                return RespondentsDB.GetLastRespondentID();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                return 0;
            }
        }

        private void GetRespondent(string email)
        {
            try
            {
                respondent = RespondentsDB.GetRespondent(email);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private int GetLastResponseID(int respondentID)
        {
            try
            {
               return ResponsesDB.GetLastResponseID(respondentID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
               return 0;
            }
        }

        private void GetResponse(int responseID)
        {
            try
            {
                response = ResponsesDB.GetResponse(responseID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void DisplayRespondent()
        {
            txtFirstName.Text = respondent.FirstName;
            txtLastName.Text = respondent.LastName;
            txtAddressLine1.Text = respondent.AddressLine1;
            txtAddressLine2.Text = respondent.AddressLine2;
            txtCity.Text = respondent.City;
            txtStateAbbr.Text = respondent.StateAbbr;
            txtZip.Text = respondent.ZipCode;            
        }

        private void DisableRespondentForm()
        {
            txtEmailAddress.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtAddressLine1.Enabled = false;
            txtAddressLine2.Enabled = false;
            txtCity.Enabled = false;
            txtStateAbbr.Enabled = false;
            txtZip.Enabled = false;
        }

        private void DisplayResponses()
        {
            txtAnswer1.Text = response.Answer1;
            txtAnswer2.Text = response.Answer2;
            txtAnswer3.Text = response.Answer3;
            txtAnswer4.Text = response.Answer4;
            txtAnswer5.Text = response.Answer5;
            txtAnswer6.Text = response.Answer6;
        }

        private void DisableResponseForm()
        {
            txtAnswer1.Enabled = false;
            txtAnswer2.Enabled = false;
            txtAnswer3.Enabled = false;
            txtAnswer4.Enabled = false;
            txtAnswer5.Enabled = false;
            txtAnswer6.Enabled = false;
        }

        private bool ValidateData()
        {
            return
                Validator.IsPresent(txtEmailAddress, "Email Address") &&
                Validator.IsPresent(txtFirstName, "First Name") &&
                Validator.IsPresent(txtLastName, "Last Name") &&
                Validator.IsPresent(txtAddressLine1, "Address Line 1") &&
                Validator.IsPresent(txtCity, "City") &&
                Validator.IsPresent(txtStateAbbr, "State Abbr") &&
                Validator.IsPresent(txtZip, "Zip Code") &&
                Validator.IsPresent(txtAnswer1, "Answer 1") &&
                Validator.IsPresent(txtAnswer2, "Answer 2") &&
                Validator.IsPresent(txtAnswer3, "Answer 3") &&
                Validator.IsPresent(txtAnswer4, "Answer 4") &&
                Validator.IsPresent(txtAnswer5, "Answer 5");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                this.PutRespondent(respondent);
                try
                {
                    if (!RespondentsDB.AddRespondent(respondent))
                    {
                        MessageBox.Show("This email already exists. Submitting new answers.",
                            "Database Message");
                        this.DialogResult = DialogResult.OK;

                        int respondentID = RespondentsDB.GetRespondentID(respondent.EmailAddress);
                        PutResponse(response, respondentID);
                        if (!ResponsesDB.AddResponse(response))
                        {
                            MessageBox.Show("There was some database error.", "ERROR!");
                        }
                        else
                        {
                            MessageBox.Show("Responses submitted! Thank you!", "YAY!");
                            this.DialogResult = DialogResult.OK;
                            ClearDataForm();
                        }
                    }
                    else
                    {
                        int respondentID = GetLastRespondentID();
                        PutResponse(response, respondentID);
                        if (!ResponsesDB.AddResponse(response))
                        {
                            MessageBox.Show("There was some database error.", "ERROR!");
                        }
                        else
                        {
                            MessageBox.Show("Responses submitted! Thank you!", "YAY!");
                            this.DialogResult = DialogResult.OK;
                            ClearDataForm();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            
        }

        private void ClearDataForm()
        {
            txtEmailAddress.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddressLine1.Clear();
            txtAddressLine2.Clear();
            txtCity.Clear();
            txtStateAbbr.Clear();
            txtZip.Clear();
            txtAnswer1.Clear();
            txtAnswer2.Clear();
            txtAnswer3.Clear();
            txtAnswer4.Clear();
            txtAnswer5.Clear();
            txtAnswer6.Clear();
        }

        private void PutResponse(Response response, int respondentID)
        {
            response.RespondentID = respondentID;
            response.Answer1 = txtAnswer1.Text;
            response.Answer2 = txtAnswer2.Text;
            response.Answer3 = txtAnswer3.Text;
            response.Answer4 = txtAnswer4.Text;
            response.Answer5 = txtAnswer5.Text;
            response.Answer6 = txtAnswer6.Text;
        }

        private void PutRespondent(Respondent respondent)
        {
            respondent.EmailAddress = txtEmailAddress.Text;
            respondent.FirstName = txtFirstName.Text;
            respondent.LastName = txtLastName.Text;
            respondent.AddressLine1 = txtAddressLine1.Text;
            respondent.AddressLine2 = txtAddressLine2.Text;
            respondent.City = txtCity.Text;
            respondent.StateAbbr = txtStateAbbr.Text;
            respondent.ZipCode = txtZip.Text;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdminLogin adminLoginForm = new frmAdminLogin();
            adminLoginForm.ShowDialog();
        }
    }
}
