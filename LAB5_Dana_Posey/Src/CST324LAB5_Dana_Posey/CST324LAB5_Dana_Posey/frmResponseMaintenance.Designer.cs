namespace CST324LAB5_Dana_Posey
{
    partial class frmResponseMaintenance
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
            System.Windows.Forms.Label responseIDLabel;
            System.Windows.Forms.Label respondentIDLabel;
            System.Windows.Forms.Label surveyDateLabel;
            System.Windows.Forms.Label answer1Label;
            System.Windows.Forms.Label answer2Label;
            System.Windows.Forms.Label answer3Label;
            System.Windows.Forms.Label answer4Label;
            System.Windows.Forms.Label answer5Label;
            System.Windows.Forms.Label answer6Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResponseMaintenance));
            this.bicycleStoresCorpDataSet = new CST324LAB5_Dana_Posey.BicycleStoresCorpDataSet();
            this.responsesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.responsesTableAdapter = new CST324LAB5_Dana_Posey.BicycleStoresCorpDataSetTableAdapters.ResponsesTableAdapter();
            this.tableAdapterManager = new CST324LAB5_Dana_Posey.BicycleStoresCorpDataSetTableAdapters.TableAdapterManager();
            this.responsesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtResponseID = new System.Windows.Forms.TextBox();
            this.txtRespondentID = new System.Windows.Forms.TextBox();
            this.surveyDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.answer1TextBox = new System.Windows.Forms.TextBox();
            this.answer2TextBox = new System.Windows.Forms.TextBox();
            this.answer3TextBox = new System.Windows.Forms.TextBox();
            this.answer4TextBox = new System.Windows.Forms.TextBox();
            this.answer5TextBox = new System.Windows.Forms.TextBox();
            this.answer6TextBox = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            responseIDLabel = new System.Windows.Forms.Label();
            respondentIDLabel = new System.Windows.Forms.Label();
            surveyDateLabel = new System.Windows.Forms.Label();
            answer1Label = new System.Windows.Forms.Label();
            answer2Label = new System.Windows.Forms.Label();
            answer3Label = new System.Windows.Forms.Label();
            answer4Label = new System.Windows.Forms.Label();
            answer5Label = new System.Windows.Forms.Label();
            answer6Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bicycleStoresCorpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsesBindingNavigator)).BeginInit();
            this.responsesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // responseIDLabel
            // 
            responseIDLabel.AutoSize = true;
            responseIDLabel.Location = new System.Drawing.Point(12, 41);
            responseIDLabel.Name = "responseIDLabel";
            responseIDLabel.Size = new System.Drawing.Size(72, 13);
            responseIDLabel.TabIndex = 1;
            responseIDLabel.Text = "Response ID:";
            // 
            // respondentIDLabel
            // 
            respondentIDLabel.AutoSize = true;
            respondentIDLabel.Location = new System.Drawing.Point(205, 41);
            respondentIDLabel.Name = "respondentIDLabel";
            respondentIDLabel.Size = new System.Drawing.Size(82, 13);
            respondentIDLabel.TabIndex = 3;
            respondentIDLabel.Text = "Respondent ID:";
            // 
            // surveyDateLabel
            // 
            surveyDateLabel.AutoSize = true;
            surveyDateLabel.Location = new System.Drawing.Point(411, 41);
            surveyDateLabel.Name = "surveyDateLabel";
            surveyDateLabel.Size = new System.Drawing.Size(69, 13);
            surveyDateLabel.TabIndex = 5;
            surveyDateLabel.Text = "Survey Date:";
            // 
            // answer1Label
            // 
            answer1Label.AutoSize = true;
            answer1Label.Location = new System.Drawing.Point(12, 75);
            answer1Label.Name = "answer1Label";
            answer1Label.Size = new System.Drawing.Size(51, 13);
            answer1Label.TabIndex = 7;
            answer1Label.Text = "Answer1:";
            // 
            // answer2Label
            // 
            answer2Label.AutoSize = true;
            answer2Label.Location = new System.Drawing.Point(12, 134);
            answer2Label.Name = "answer2Label";
            answer2Label.Size = new System.Drawing.Size(51, 13);
            answer2Label.TabIndex = 9;
            answer2Label.Text = "Answer2:";
            // 
            // answer3Label
            // 
            answer3Label.AutoSize = true;
            answer3Label.Location = new System.Drawing.Point(12, 193);
            answer3Label.Name = "answer3Label";
            answer3Label.Size = new System.Drawing.Size(51, 13);
            answer3Label.TabIndex = 11;
            answer3Label.Text = "Answer3:";
            // 
            // answer4Label
            // 
            answer4Label.AutoSize = true;
            answer4Label.Location = new System.Drawing.Point(12, 252);
            answer4Label.Name = "answer4Label";
            answer4Label.Size = new System.Drawing.Size(51, 13);
            answer4Label.TabIndex = 13;
            answer4Label.Text = "Answer4:";
            // 
            // answer5Label
            // 
            answer5Label.AutoSize = true;
            answer5Label.Location = new System.Drawing.Point(12, 311);
            answer5Label.Name = "answer5Label";
            answer5Label.Size = new System.Drawing.Size(51, 13);
            answer5Label.TabIndex = 15;
            answer5Label.Text = "Answer5:";
            // 
            // answer6Label
            // 
            answer6Label.AutoSize = true;
            answer6Label.Location = new System.Drawing.Point(12, 370);
            answer6Label.Name = "answer6Label";
            answer6Label.Size = new System.Drawing.Size(51, 13);
            answer6Label.TabIndex = 17;
            answer6Label.Text = "Answer6:";
            // 
            // bicycleStoresCorpDataSet
            // 
            this.bicycleStoresCorpDataSet.DataSetName = "BicycleStoresCorpDataSet";
            this.bicycleStoresCorpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // responsesBindingSource
            // 
            this.responsesBindingSource.DataMember = "Responses";
            this.responsesBindingSource.DataSource = this.bicycleStoresCorpDataSet;
            // 
            // responsesTableAdapter
            // 
            this.responsesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RespondentsTableAdapter = null;
            this.tableAdapterManager.ResponsesTableAdapter = this.responsesTableAdapter;
            this.tableAdapterManager.UpdateOrder = CST324LAB5_Dana_Posey.BicycleStoresCorpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // responsesBindingNavigator
            // 
            this.responsesBindingNavigator.AddNewItem = null;
            this.responsesBindingNavigator.BindingSource = this.responsesBindingSource;
            this.responsesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.responsesBindingNavigator.DeleteItem = null;
            this.responsesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.responsesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.responsesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.responsesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.responsesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.responsesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.responsesBindingNavigator.Name = "responsesBindingNavigator";
            this.responsesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.responsesBindingNavigator.Size = new System.Drawing.Size(722, 25);
            this.responsesBindingNavigator.TabIndex = 0;
            this.responsesBindingNavigator.Text = "bindingNavigator1";
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
            // txtResponseID
            // 
            this.txtResponseID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.responsesBindingSource, "ResponseID", true));
            this.txtResponseID.Enabled = false;
            this.txtResponseID.Location = new System.Drawing.Point(100, 38);
            this.txtResponseID.Name = "txtResponseID";
            this.txtResponseID.Size = new System.Drawing.Size(84, 20);
            this.txtResponseID.TabIndex = 2;
            this.txtResponseID.TabStop = false;
            // 
            // txtRespondentID
            // 
            this.txtRespondentID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.responsesBindingSource, "RespondentID", true));
            this.txtRespondentID.Enabled = false;
            this.txtRespondentID.Location = new System.Drawing.Point(293, 38);
            this.txtRespondentID.Name = "txtRespondentID";
            this.txtRespondentID.Size = new System.Drawing.Size(84, 20);
            this.txtRespondentID.TabIndex = 4;
            this.txtRespondentID.TabStop = false;
            // 
            // surveyDateDateTimePicker
            // 
            this.surveyDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.responsesBindingSource, "SurveyDate", true));
            this.surveyDateDateTimePicker.Enabled = false;
            this.surveyDateDateTimePicker.Location = new System.Drawing.Point(499, 37);
            this.surveyDateDateTimePicker.Name = "surveyDateDateTimePicker";
            this.surveyDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.surveyDateDateTimePicker.TabIndex = 6;
            this.surveyDateDateTimePicker.TabStop = false;
            // 
            // answer1TextBox
            // 
            this.answer1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.responsesBindingSource, "Answer1", true));
            this.answer1TextBox.Location = new System.Drawing.Point(100, 72);
            this.answer1TextBox.Multiline = true;
            this.answer1TextBox.Name = "answer1TextBox";
            this.answer1TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.answer1TextBox.Size = new System.Drawing.Size(599, 49);
            this.answer1TextBox.TabIndex = 8;
            // 
            // answer2TextBox
            // 
            this.answer2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.responsesBindingSource, "Answer2", true));
            this.answer2TextBox.Location = new System.Drawing.Point(100, 131);
            this.answer2TextBox.Multiline = true;
            this.answer2TextBox.Name = "answer2TextBox";
            this.answer2TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.answer2TextBox.Size = new System.Drawing.Size(599, 49);
            this.answer2TextBox.TabIndex = 10;
            // 
            // answer3TextBox
            // 
            this.answer3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.responsesBindingSource, "Answer3", true));
            this.answer3TextBox.Location = new System.Drawing.Point(100, 190);
            this.answer3TextBox.Multiline = true;
            this.answer3TextBox.Name = "answer3TextBox";
            this.answer3TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.answer3TextBox.Size = new System.Drawing.Size(599, 49);
            this.answer3TextBox.TabIndex = 12;
            // 
            // answer4TextBox
            // 
            this.answer4TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.responsesBindingSource, "Answer4", true));
            this.answer4TextBox.Location = new System.Drawing.Point(100, 249);
            this.answer4TextBox.Multiline = true;
            this.answer4TextBox.Name = "answer4TextBox";
            this.answer4TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.answer4TextBox.Size = new System.Drawing.Size(599, 49);
            this.answer4TextBox.TabIndex = 14;
            // 
            // answer5TextBox
            // 
            this.answer5TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.responsesBindingSource, "Answer5", true));
            this.answer5TextBox.Location = new System.Drawing.Point(100, 308);
            this.answer5TextBox.Multiline = true;
            this.answer5TextBox.Name = "answer5TextBox";
            this.answer5TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.answer5TextBox.Size = new System.Drawing.Size(599, 49);
            this.answer5TextBox.TabIndex = 16;
            // 
            // answer6TextBox
            // 
            this.answer6TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.responsesBindingSource, "Answer6", true));
            this.answer6TextBox.Location = new System.Drawing.Point(100, 367);
            this.answer6TextBox.Multiline = true;
            this.answer6TextBox.Name = "answer6TextBox";
            this.answer6TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.answer6TextBox.Size = new System.Drawing.Size(599, 49);
            this.answer6TextBox.TabIndex = 18;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(624, 432);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(543, 432);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmResponseMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 467);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(responseIDLabel);
            this.Controls.Add(this.txtResponseID);
            this.Controls.Add(respondentIDLabel);
            this.Controls.Add(this.txtRespondentID);
            this.Controls.Add(surveyDateLabel);
            this.Controls.Add(this.surveyDateDateTimePicker);
            this.Controls.Add(answer1Label);
            this.Controls.Add(this.answer1TextBox);
            this.Controls.Add(answer2Label);
            this.Controls.Add(this.answer2TextBox);
            this.Controls.Add(answer3Label);
            this.Controls.Add(this.answer3TextBox);
            this.Controls.Add(answer4Label);
            this.Controls.Add(this.answer4TextBox);
            this.Controls.Add(answer5Label);
            this.Controls.Add(this.answer5TextBox);
            this.Controls.Add(answer6Label);
            this.Controls.Add(this.answer6TextBox);
            this.Controls.Add(this.responsesBindingNavigator);
            this.Name = "frmResponseMaintenance";
            this.Text = "frmResponseMaintenance";
            this.Load += new System.EventHandler(this.frmResponseMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bicycleStoresCorpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsesBindingNavigator)).EndInit();
            this.responsesBindingNavigator.ResumeLayout(false);
            this.responsesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BicycleStoresCorpDataSet bicycleStoresCorpDataSet;
        private System.Windows.Forms.BindingSource responsesBindingSource;
        private BicycleStoresCorpDataSetTableAdapters.ResponsesTableAdapter responsesTableAdapter;
        private BicycleStoresCorpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator responsesBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox txtResponseID;
        private System.Windows.Forms.TextBox txtRespondentID;
        private System.Windows.Forms.DateTimePicker surveyDateDateTimePicker;
        private System.Windows.Forms.TextBox answer1TextBox;
        private System.Windows.Forms.TextBox answer2TextBox;
        private System.Windows.Forms.TextBox answer3TextBox;
        private System.Windows.Forms.TextBox answer4TextBox;
        private System.Windows.Forms.TextBox answer5TextBox;
        private System.Windows.Forms.TextBox answer6TextBox;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
    }
}