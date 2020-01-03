namespace CST324LAB5_Dana_Posey
{
    partial class frmRespondentMaintenance
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
            System.Windows.Forms.Label respondentIDLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label emailAddressLabel;
            System.Windows.Forms.Label addressLine1Label;
            System.Windows.Forms.Label addressLine2Label;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label lastSurveyLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRespondentMaintenance));
            this.bicycleStoresCorpDataSet = new CST324LAB5_Dana_Posey.BicycleStoresCorpDataSet();
            this.respondentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.respondentsTableAdapter = new CST324LAB5_Dana_Posey.BicycleStoresCorpDataSetTableAdapters.RespondentsTableAdapter();
            this.tableAdapterManager = new CST324LAB5_Dana_Posey.BicycleStoresCorpDataSetTableAdapters.TableAdapterManager();
            this.responsesTableAdapter = new CST324LAB5_Dana_Posey.BicycleStoresCorpDataSetTableAdapters.ResponsesTableAdapter();
            this.respondentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.respondentIDTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.addressLine1TextBox = new System.Windows.Forms.TextBox();
            this.addressLine2TextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateAbbrTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.lastSurveyTextBox = new System.Windows.Forms.TextBox();
            this.responsesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnViewSurvey = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            respondentIDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            emailAddressLabel = new System.Windows.Forms.Label();
            addressLine1Label = new System.Windows.Forms.Label();
            addressLine2Label = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            lastSurveyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bicycleStoresCorpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.respondentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.respondentsBindingNavigator)).BeginInit();
            this.respondentsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.responsesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // respondentIDLabel
            // 
            respondentIDLabel.AutoSize = true;
            respondentIDLabel.Location = new System.Drawing.Point(12, 36);
            respondentIDLabel.Name = "respondentIDLabel";
            respondentIDLabel.Size = new System.Drawing.Size(82, 13);
            respondentIDLabel.TabIndex = 1;
            respondentIDLabel.Text = "Respondent ID:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(12, 62);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(12, 88);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // emailAddressLabel
            // 
            emailAddressLabel.AutoSize = true;
            emailAddressLabel.Location = new System.Drawing.Point(12, 114);
            emailAddressLabel.Name = "emailAddressLabel";
            emailAddressLabel.Size = new System.Drawing.Size(76, 13);
            emailAddressLabel.TabIndex = 7;
            emailAddressLabel.Text = "Email Address:";
            // 
            // addressLine1Label
            // 
            addressLine1Label.AutoSize = true;
            addressLine1Label.Location = new System.Drawing.Point(12, 140);
            addressLine1Label.Name = "addressLine1Label";
            addressLine1Label.Size = new System.Drawing.Size(77, 13);
            addressLine1Label.TabIndex = 9;
            addressLine1Label.Text = "Address Line1:";
            // 
            // addressLine2Label
            // 
            addressLine2Label.AutoSize = true;
            addressLine2Label.Location = new System.Drawing.Point(12, 166);
            addressLine2Label.Name = "addressLine2Label";
            addressLine2Label.Size = new System.Drawing.Size(77, 13);
            addressLine2Label.TabIndex = 11;
            addressLine2Label.Text = "Address Line2:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(12, 192);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(62, 13);
            cityLabel.TabIndex = 13;
            cityLabel.Text = "City/St/Zip:";
            // 
            // lastSurveyLabel
            // 
            lastSurveyLabel.AutoSize = true;
            lastSurveyLabel.Location = new System.Drawing.Point(233, 36);
            lastSurveyLabel.Name = "lastSurveyLabel";
            lastSurveyLabel.Size = new System.Drawing.Size(66, 13);
            lastSurveyLabel.TabIndex = 19;
            lastSurveyLabel.Text = "Last Survey:";
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
            // respondentsBindingNavigator
            // 
            this.respondentsBindingNavigator.AddNewItem = null;
            this.respondentsBindingNavigator.BindingSource = this.respondentsBindingSource;
            this.respondentsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.respondentsBindingNavigator.DeleteItem = null;
            this.respondentsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.respondentsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.respondentsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.respondentsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.respondentsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.respondentsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.respondentsBindingNavigator.Name = "respondentsBindingNavigator";
            this.respondentsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.respondentsBindingNavigator.Size = new System.Drawing.Size(439, 25);
            this.respondentsBindingNavigator.TabIndex = 0;
            this.respondentsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // respondentIDTextBox
            // 
            this.respondentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respondentsBindingSource, "RespondentID", true));
            this.respondentIDTextBox.Location = new System.Drawing.Point(100, 33);
            this.respondentIDTextBox.Name = "respondentIDTextBox";
            this.respondentIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.respondentIDTextBox.TabIndex = 2;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respondentsBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(100, 59);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(321, 20);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respondentsBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(100, 85);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(321, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respondentsBindingSource, "EmailAddress", true));
            this.emailAddressTextBox.Location = new System.Drawing.Point(100, 111);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(321, 20);
            this.emailAddressTextBox.TabIndex = 8;
            // 
            // addressLine1TextBox
            // 
            this.addressLine1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respondentsBindingSource, "AddressLine1", true));
            this.addressLine1TextBox.Location = new System.Drawing.Point(100, 137);
            this.addressLine1TextBox.Name = "addressLine1TextBox";
            this.addressLine1TextBox.Size = new System.Drawing.Size(321, 20);
            this.addressLine1TextBox.TabIndex = 10;
            // 
            // addressLine2TextBox
            // 
            this.addressLine2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respondentsBindingSource, "AddressLine2", true));
            this.addressLine2TextBox.Location = new System.Drawing.Point(100, 163);
            this.addressLine2TextBox.Name = "addressLine2TextBox";
            this.addressLine2TextBox.Size = new System.Drawing.Size(321, 20);
            this.addressLine2TextBox.TabIndex = 12;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respondentsBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(100, 189);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(176, 20);
            this.cityTextBox.TabIndex = 14;
            // 
            // stateAbbrTextBox
            // 
            this.stateAbbrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respondentsBindingSource, "StateAbbr", true));
            this.stateAbbrTextBox.Location = new System.Drawing.Point(282, 189);
            this.stateAbbrTextBox.Name = "stateAbbrTextBox";
            this.stateAbbrTextBox.Size = new System.Drawing.Size(38, 20);
            this.stateAbbrTextBox.TabIndex = 16;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respondentsBindingSource, "ZipCode", true));
            this.zipCodeTextBox.Location = new System.Drawing.Point(326, 189);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(95, 20);
            this.zipCodeTextBox.TabIndex = 18;
            // 
            // lastSurveyTextBox
            // 
            this.lastSurveyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.respondentsBindingSource, "LastSurvey", true));
            this.lastSurveyTextBox.Location = new System.Drawing.Point(321, 33);
            this.lastSurveyTextBox.Name = "lastSurveyTextBox";
            this.lastSurveyTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastSurveyTextBox.TabIndex = 20;
            // 
            // responsesBindingSource
            // 
            this.responsesBindingSource.DataMember = "Responses";
            this.responsesBindingSource.DataSource = this.bicycleStoresCorpDataSet;
            // 
            // btnViewSurvey
            // 
            this.btnViewSurvey.Location = new System.Drawing.Point(15, 222);
            this.btnViewSurvey.Name = "btnViewSurvey";
            this.btnViewSurvey.Size = new System.Drawing.Size(131, 23);
            this.btnViewSurvey.TabIndex = 21;
            this.btnViewSurvey.Text = "View Survey Answers";
            this.btnViewSurvey.UseVisualStyleBackColor = true;
            this.btnViewSurvey.Click += new System.EventHandler(this.btnViewSurvey_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(152, 222);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(107, 23);
            this.btnSaveChanges.TabIndex = 22;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(265, 222);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(346, 222);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmRespondentMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 257);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnViewSurvey);
            this.Controls.Add(respondentIDLabel);
            this.Controls.Add(this.respondentIDTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(emailAddressLabel);
            this.Controls.Add(this.emailAddressTextBox);
            this.Controls.Add(addressLine1Label);
            this.Controls.Add(this.addressLine1TextBox);
            this.Controls.Add(addressLine2Label);
            this.Controls.Add(this.addressLine2TextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.stateAbbrTextBox);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(lastSurveyLabel);
            this.Controls.Add(this.lastSurveyTextBox);
            this.Controls.Add(this.respondentsBindingNavigator);
            this.Name = "frmRespondentMaintenance";
            this.Text = "Responent Maintenance";
            this.Load += new System.EventHandler(this.frmSurveyMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bicycleStoresCorpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.respondentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.respondentsBindingNavigator)).EndInit();
            this.respondentsBindingNavigator.ResumeLayout(false);
            this.respondentsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.responsesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BicycleStoresCorpDataSet bicycleStoresCorpDataSet;
        private System.Windows.Forms.BindingSource respondentsBindingSource;
        private BicycleStoresCorpDataSetTableAdapters.RespondentsTableAdapter respondentsTableAdapter;
        private BicycleStoresCorpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator respondentsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox respondentIDTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.TextBox addressLine1TextBox;
        private System.Windows.Forms.TextBox addressLine2TextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateAbbrTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.TextBox lastSurveyTextBox;
        private BicycleStoresCorpDataSetTableAdapters.ResponsesTableAdapter responsesTableAdapter;
        private System.Windows.Forms.BindingSource responsesBindingSource;
        private System.Windows.Forms.Button btnViewSurvey;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
    }
}