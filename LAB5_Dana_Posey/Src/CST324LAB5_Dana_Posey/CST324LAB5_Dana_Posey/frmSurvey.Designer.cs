namespace CST324LAB5_Dana_Posey
{
    partial class frmSurvey
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label emailAddressLabel;
            System.Windows.Forms.Label addressLine1Label;
            System.Windows.Forms.Label addressLine2Label;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label answer1Label;
            System.Windows.Forms.Label answer2Label;
            System.Windows.Forms.Label answer3Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSurvey));
            System.Windows.Forms.Label answer4Label;
            System.Windows.Forms.Label answer5Label;
            System.Windows.Forms.Label answer6Label;
            this.bicycleStoresCorpDataSet = new CST324LAB5_Dana_Posey.BicycleStoresCorpDataSet();
            this.respondentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.respondentsTableAdapter = new CST324LAB5_Dana_Posey.BicycleStoresCorpDataSetTableAdapters.RespondentsTableAdapter();
            this.tableAdapterManager = new CST324LAB5_Dana_Posey.BicycleStoresCorpDataSetTableAdapters.TableAdapterManager();
            this.responsesTableAdapter = new CST324LAB5_Dana_Posey.BicycleStoresCorpDataSetTableAdapters.ResponsesTableAdapter();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStateAbbr = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtAnswer1 = new System.Windows.Forms.TextBox();
            this.responsesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.txtAnswer3 = new System.Windows.Forms.TextBox();
            this.txtAnswer4 = new System.Windows.Forms.TextBox();
            this.txtAnswer5 = new System.Windows.Forms.TextBox();
            this.txtAnswer6 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            emailAddressLabel = new System.Windows.Forms.Label();
            addressLine1Label = new System.Windows.Forms.Label();
            addressLine2Label = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            answer1Label = new System.Windows.Forms.Label();
            answer2Label = new System.Windows.Forms.Label();
            answer3Label = new System.Windows.Forms.Label();
            answer4Label = new System.Windows.Forms.Label();
            answer5Label = new System.Windows.Forms.Label();
            answer6Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bicycleStoresCorpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.respondentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(12, 50);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(248, 50);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // emailAddressLabel
            // 
            emailAddressLabel.AutoSize = true;
            emailAddressLabel.Location = new System.Drawing.Point(12, 24);
            emailAddressLabel.Name = "emailAddressLabel";
            emailAddressLabel.Size = new System.Drawing.Size(76, 13);
            emailAddressLabel.TabIndex = 7;
            emailAddressLabel.Text = "Email Address:";
            // 
            // addressLine1Label
            // 
            addressLine1Label.AutoSize = true;
            addressLine1Label.Location = new System.Drawing.Point(12, 76);
            addressLine1Label.Name = "addressLine1Label";
            addressLine1Label.Size = new System.Drawing.Size(77, 13);
            addressLine1Label.TabIndex = 9;
            addressLine1Label.Text = "Address Line1:";
            // 
            // addressLine2Label
            // 
            addressLine2Label.AutoSize = true;
            addressLine2Label.Location = new System.Drawing.Point(12, 102);
            addressLine2Label.Name = "addressLine2Label";
            addressLine2Label.Size = new System.Drawing.Size(77, 13);
            addressLine2Label.TabIndex = 11;
            addressLine2Label.Text = "Address Line2:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(12, 128);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(66, 13);
            cityLabel.TabIndex = 13;
            cityLabel.Text = "City/ST/Zip:";
            // 
            // answer1Label
            // 
            answer1Label.AutoSize = true;
            answer1Label.Location = new System.Drawing.Point(12, 200);
            answer1Label.Name = "answer1Label";
            answer1Label.Size = new System.Drawing.Size(933, 13);
            answer1Label.TabIndex = 27;
            answer1Label.Text = "Q1) How would you describe your shop? How might you categorize it? Would you say " +
    "that this bike shop is high-end, more neighborhood or family focused, or do you " +
    "serve a very  specific clientele?";
            // 
            // answer2Label
            // 
            answer2Label.AutoSize = true;
            answer2Label.Location = new System.Drawing.Point(12, 285);
            answer2Label.Name = "answer2Label";
            answer2Label.Size = new System.Drawing.Size(525, 13);
            answer2Label.TabIndex = 29;
            answer2Label.Text = "Q2) What role do you see a bike shop like this playing in the community? Is it mo" +
    "re than just retail and service?";
            // 
            // answer3Label
            // 
            answer3Label.AutoSize = true;
            answer3Label.Location = new System.Drawing.Point(12, 370);
            answer3Label.Name = "answer3Label";
            answer3Label.Size = new System.Drawing.Size(1213, 13);
            answer3Label.TabIndex = 31;
            answer3Label.Text = resources.GetString("answer3Label.Text");
            // 
            // answer4Label
            // 
            answer4Label.AutoSize = true;
            answer4Label.Location = new System.Drawing.Point(12, 455);
            answer4Label.Name = "answer4Label";
            answer4Label.Size = new System.Drawing.Size(861, 13);
            answer4Label.TabIndex = 33;
            answer4Label.Text = "Q4) Do any of your regular customers come in just for conversation? Do they use t" +
    "he shop space as a hangout, or to meet up before or after bike rides? If so, ple" +
    "ase give an example.";
            // 
            // answer5Label
            // 
            answer5Label.AutoSize = true;
            answer5Label.Location = new System.Drawing.Point(12, 540);
            answer5Label.Name = "answer5Label";
            answer5Label.Size = new System.Drawing.Size(832, 13);
            answer5Label.TabIndex = 35;
            answer5Label.Text = "Q5) What do you see as the major bicycle-related challenges or concerns for your " +
    "customers/neighborhood? Are you or your shop engaged in finding a solution to th" +
    "is problem?";
            // 
            // answer6Label
            // 
            answer6Label.AutoSize = true;
            answer6Label.Location = new System.Drawing.Point(12, 625);
            answer6Label.Name = "answer6Label";
            answer6Label.Size = new System.Drawing.Size(261, 13);
            answer6Label.TabIndex = 37;
            answer6Label.Text = "Q6) Is there anything else you\'d like to add? (Optional)";
            // 
            // bicycleStoresCorpDataSet
            // 
            this.bicycleStoresCorpDataSet.DataSetName = "BicycleStoresCorpDataSet";
            this.bicycleStoresCorpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // respondentsBindingSource
            // 
            this.respondentsBindingSource.DataMember = "Respondents";
            this.respondentsBindingSource.DataSource = this.bicycleStoresCorpDataSet;
            // 
            // respondentsTableAdapter
            // 
            this.respondentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RespondentsTableAdapter = this.respondentsTableAdapter;
            this.tableAdapterManager.ResponsesTableAdapter = this.responsesTableAdapter;
            this.tableAdapterManager.UpdateOrder = CST324LAB5_Dana_Posey.BicycleStoresCorpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // responsesTableAdapter
            // 
            this.responsesTableAdapter.ClearBeforeFill = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respondentsBindingSource, "FirstName", true));
            this.txtFirstName.Location = new System.Drawing.Point(100, 47);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(142, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respondentsBindingSource, "LastName", true));
            this.txtLastName.Location = new System.Drawing.Point(324, 47);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respondentsBindingSource, "EmailAddress", true));
            this.txtEmailAddress.Location = new System.Drawing.Point(100, 21);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(424, 20);
            this.txtEmailAddress.TabIndex = 0;
            this.txtEmailAddress.TextChanged += new System.EventHandler(this.txtEmailAddress_TextChanged);
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respondentsBindingSource, "AddressLine1", true));
            this.txtAddressLine1.Location = new System.Drawing.Point(100, 73);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(424, 20);
            this.txtAddressLine1.TabIndex = 4;
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respondentsBindingSource, "AddressLine2", true));
            this.txtAddressLine2.Location = new System.Drawing.Point(100, 99);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(424, 20);
            this.txtAddressLine2.TabIndex = 5;
            // 
            // txtCity
            // 
            this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respondentsBindingSource, "City", true));
            this.txtCity.Location = new System.Drawing.Point(100, 125);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(217, 20);
            this.txtCity.TabIndex = 6;
            // 
            // txtStateAbbr
            // 
            this.txtStateAbbr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respondentsBindingSource, "StateAbbr", true));
            this.txtStateAbbr.Location = new System.Drawing.Point(323, 125);
            this.txtStateAbbr.Name = "txtStateAbbr";
            this.txtStateAbbr.Size = new System.Drawing.Size(57, 20);
            this.txtStateAbbr.TabIndex = 7;
            // 
            // txtZip
            // 
            this.txtZip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respondentsBindingSource, "ZipCode", true));
            this.txtZip.Location = new System.Drawing.Point(386, 125);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(138, 20);
            this.txtZip.TabIndex = 8;
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.responsesBindingSource, "Answer1", true));
            this.txtAnswer1.Location = new System.Drawing.Point(15, 216);
            this.txtAnswer1.Multiline = true;
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnswer1.Size = new System.Drawing.Size(1210, 66);
            this.txtAnswer1.TabIndex = 9;
            this.txtAnswer1.TextChanged += new System.EventHandler(this.txtAnswer1_TextChanged);
            // 
            // responsesBindingSource
            // 
            this.responsesBindingSource.DataMember = "FK__Responses__Respo__3A81B327";
            this.responsesBindingSource.DataSource = this.respondentsBindingSource;
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.responsesBindingSource, "Answer2", true));
            this.txtAnswer2.Location = new System.Drawing.Point(15, 301);
            this.txtAnswer2.Multiline = true;
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnswer2.Size = new System.Drawing.Size(1210, 66);
            this.txtAnswer2.TabIndex = 10;
            this.txtAnswer2.TextChanged += new System.EventHandler(this.txtAnswer2_TextChanged);
            // 
            // txtAnswer3
            // 
            this.txtAnswer3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.responsesBindingSource, "Answer3", true));
            this.txtAnswer3.Location = new System.Drawing.Point(15, 386);
            this.txtAnswer3.Multiline = true;
            this.txtAnswer3.Name = "txtAnswer3";
            this.txtAnswer3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnswer3.Size = new System.Drawing.Size(1210, 66);
            this.txtAnswer3.TabIndex = 11;
            this.txtAnswer3.TextChanged += new System.EventHandler(this.txtAnswer3_TextChanged);
            // 
            // txtAnswer4
            // 
            this.txtAnswer4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.responsesBindingSource, "Answer4", true));
            this.txtAnswer4.Location = new System.Drawing.Point(15, 471);
            this.txtAnswer4.Multiline = true;
            this.txtAnswer4.Name = "txtAnswer4";
            this.txtAnswer4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnswer4.Size = new System.Drawing.Size(1210, 66);
            this.txtAnswer4.TabIndex = 12;
            this.txtAnswer4.TextChanged += new System.EventHandler(this.txtAnswer4_TextChanged);
            // 
            // txtAnswer5
            // 
            this.txtAnswer5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.responsesBindingSource, "Answer5", true));
            this.txtAnswer5.Location = new System.Drawing.Point(15, 556);
            this.txtAnswer5.Multiline = true;
            this.txtAnswer5.Name = "txtAnswer5";
            this.txtAnswer5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnswer5.Size = new System.Drawing.Size(1210, 66);
            this.txtAnswer5.TabIndex = 13;
            this.txtAnswer5.TextChanged += new System.EventHandler(this.txtAnswer5_TextChanged);
            // 
            // txtAnswer6
            // 
            this.txtAnswer6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.responsesBindingSource, "Answer6", true));
            this.txtAnswer6.Location = new System.Drawing.Point(15, 641);
            this.txtAnswer6.Multiline = true;
            this.txtAnswer6.Name = "txtAnswer6";
            this.txtAnswer6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnswer6.Size = new System.Drawing.Size(1210, 66);
            this.txtAnswer6.TabIndex = 14;
            this.txtAnswer6.TextChanged += new System.EventHandler(this.answer6TextBox_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1149, 721);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(1048, 721);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(14, 721);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 38;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // frmSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 756);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(answer1Label);
            this.Controls.Add(this.txtAnswer1);
            this.Controls.Add(answer2Label);
            this.Controls.Add(this.txtAnswer2);
            this.Controls.Add(answer3Label);
            this.Controls.Add(this.txtAnswer3);
            this.Controls.Add(answer4Label);
            this.Controls.Add(this.txtAnswer4);
            this.Controls.Add(answer5Label);
            this.Controls.Add(this.txtAnswer5);
            this.Controls.Add(answer6Label);
            this.Controls.Add(this.txtAnswer6);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(emailAddressLabel);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(addressLine1Label);
            this.Controls.Add(this.txtAddressLine1);
            this.Controls.Add(addressLine2Label);
            this.Controls.Add(this.txtAddressLine2);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtStateAbbr);
            this.Controls.Add(this.txtZip);
            this.Name = "frmSurvey";
            this.Text = "Bicycle Stores Corp Survey";
            this.Load += new System.EventHandler(this.Survey_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bicycleStoresCorpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.respondentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BicycleStoresCorpDataSet bicycleStoresCorpDataSet;
        private System.Windows.Forms.BindingSource respondentsBindingSource;
        private BicycleStoresCorpDataSetTableAdapters.RespondentsTableAdapter respondentsTableAdapter;
        private BicycleStoresCorpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BicycleStoresCorpDataSetTableAdapters.ResponsesTableAdapter responsesTableAdapter;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStateAbbr;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.BindingSource responsesBindingSource;
        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.TextBox txtAnswer3;
        private System.Windows.Forms.TextBox txtAnswer4;
        private System.Windows.Forms.TextBox txtAnswer5;
        private System.Windows.Forms.TextBox txtAnswer6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnAdmin;
    }
}

