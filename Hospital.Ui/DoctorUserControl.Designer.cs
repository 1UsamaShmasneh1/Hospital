namespace Hospital.Ui
{
    partial class DoctorUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.patientsDataGridView = new System.Windows.Forms.DataGridView();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.doctorTapButton = new System.Windows.Forms.Button();
            this.nurseTapButton = new System.Windows.Forms.Button();
            this.secretaryTapButton = new System.Windows.Forms.Button();
            this.genderLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.identityNumberLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.identityNumberLabel1 = new System.Windows.Forms.Label();
            this.lastnameLabel1 = new System.Windows.Forms.Label();
            this.firstnameLabel1 = new System.Windows.Forms.Label();
            this.manuePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.doctorPanel = new System.Windows.Forms.Panel();
            this.doctorDetailsPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.medicalAdviceLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.medicalAdviceEditButton = new System.Windows.Forms.Button();
            this.medicalAdviceSaveButton = new System.Windows.Forms.Button();
            this.diseaseDiagnosisLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.medicationButton = new System.Windows.Forms.Button();
            this.diseaseDiagnosisEditButton = new System.Windows.Forms.Button();
            this.diseaseDiagnosisSaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.manuePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.doctorPanel.SuspendLayout();
            this.doctorDetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientsDataGridView
            // 
            this.patientsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.patientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDataGridView.Location = new System.Drawing.Point(4, 45);
            this.patientsDataGridView.Name = "patientsDataGridView";
            this.patientsDataGridView.RowTemplate.Height = 25;
            this.patientsDataGridView.Size = new System.Drawing.Size(168, 468);
            this.patientsDataGridView.TabIndex = 0;
            this.patientsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientsDataGridView_CellContentClick);
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(3, 12);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(38, 15);
            this.employeeNameLabel.TabIndex = 1;
            this.employeeNameLabel.Text = "label1";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(45, 39);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(91, 35);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Tag = "logout";
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.CommonClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.doctorTapButton);
            this.panel2.Controls.Add(this.nurseTapButton);
            this.panel2.Controls.Add(this.secretaryTapButton);
            this.panel2.Controls.Add(this.genderLabel);
            this.panel2.Controls.Add(this.dateOfBirthLabel);
            this.panel2.Controls.Add(this.identityNumberLabel);
            this.panel2.Controls.Add(this.lastnameLabel);
            this.panel2.Controls.Add(this.firstnameLabel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.identityNumberLabel1);
            this.panel2.Controls.Add(this.lastnameLabel1);
            this.panel2.Controls.Add(this.firstnameLabel1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 153);
            this.panel2.TabIndex = 13;
            // 
            // doctorTapButton
            // 
            this.doctorTapButton.Location = new System.Drawing.Point(313, 127);
            this.doctorTapButton.Name = "doctorTapButton";
            this.doctorTapButton.Size = new System.Drawing.Size(149, 23);
            this.doctorTapButton.TabIndex = 28;
            this.doctorTapButton.Tag = "doctor tap";
            this.doctorTapButton.Text = "Doctor tap";
            this.doctorTapButton.UseVisualStyleBackColor = true;
            this.doctorTapButton.Click += new System.EventHandler(this.CommonClick);
            // 
            // nurseTapButton
            // 
            this.nurseTapButton.Location = new System.Drawing.Point(158, 127);
            this.nurseTapButton.Name = "nurseTapButton";
            this.nurseTapButton.Size = new System.Drawing.Size(149, 23);
            this.nurseTapButton.TabIndex = 27;
            this.nurseTapButton.Tag = "nurse tap";
            this.nurseTapButton.Text = "Nurse tap";
            this.nurseTapButton.UseVisualStyleBackColor = true;
            this.nurseTapButton.Click += new System.EventHandler(this.CommonClick);
            // 
            // secretaryTapButton
            // 
            this.secretaryTapButton.Location = new System.Drawing.Point(3, 127);
            this.secretaryTapButton.Name = "secretaryTapButton";
            this.secretaryTapButton.Size = new System.Drawing.Size(149, 23);
            this.secretaryTapButton.TabIndex = 26;
            this.secretaryTapButton.Tag = "secretary tap";
            this.secretaryTapButton.Text = "Secretary tap";
            this.secretaryTapButton.UseVisualStyleBackColor = true;
            this.secretaryTapButton.Click += new System.EventHandler(this.CommonClick);
            // 
            // genderLabel
            // 
            this.genderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.genderLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genderLabel.Location = new System.Drawing.Point(131, 88);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(106, 24);
            this.genderLabel.TabIndex = 22;
            this.genderLabel.Tag = "clearable";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateOfBirthLabel.Location = new System.Drawing.Point(496, 50);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(183, 24);
            this.dateOfBirthLabel.TabIndex = 21;
            this.dateOfBirthLabel.Tag = "clearable";
            // 
            // identityNumberLabel
            // 
            this.identityNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.identityNumberLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.identityNumberLabel.Location = new System.Drawing.Point(209, 52);
            this.identityNumberLabel.Name = "identityNumberLabel";
            this.identityNumberLabel.Size = new System.Drawing.Size(145, 24);
            this.identityNumberLabel.TabIndex = 20;
            this.identityNumberLabel.Tag = "clearable";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lastnameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastnameLabel.Location = new System.Drawing.Point(476, 14);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(220, 24);
            this.lastnameLabel.TabIndex = 19;
            this.lastnameLabel.Tag = "clearable";
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.firstnameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstnameLabel.Location = new System.Drawing.Point(154, 14);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(183, 24);
            this.firstnameLabel.TabIndex = 18;
            this.firstnameLabel.Tag = "clearable";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(46, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Gender:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(368, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Date of birth:";
            // 
            // identityNumberLabel1
            // 
            this.identityNumberLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.identityNumberLabel1.Location = new System.Drawing.Point(46, 48);
            this.identityNumberLabel1.Name = "identityNumberLabel1";
            this.identityNumberLabel1.Size = new System.Drawing.Size(157, 29);
            this.identityNumberLabel1.TabIndex = 15;
            this.identityNumberLabel1.Text = "Identity number:";
            // 
            // lastnameLabel1
            // 
            this.lastnameLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastnameLabel1.Location = new System.Drawing.Point(368, 10);
            this.lastnameLabel1.Name = "lastnameLabel1";
            this.lastnameLabel1.Size = new System.Drawing.Size(102, 29);
            this.lastnameLabel1.TabIndex = 14;
            this.lastnameLabel1.Text = "Lastname:";
            // 
            // firstnameLabel1
            // 
            this.firstnameLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstnameLabel1.Location = new System.Drawing.Point(46, 10);
            this.firstnameLabel1.Name = "firstnameLabel1";
            this.firstnameLabel1.Size = new System.Drawing.Size(102, 29);
            this.firstnameLabel1.TabIndex = 13;
            this.firstnameLabel1.Text = "Firstname:";
            // 
            // manuePanel
            // 
            this.manuePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.manuePanel.Controls.Add(this.employeeNameLabel);
            this.manuePanel.Controls.Add(this.logoutButton);
            this.manuePanel.Location = new System.Drawing.Point(788, 3);
            this.manuePanel.Name = "manuePanel";
            this.manuePanel.Size = new System.Drawing.Size(174, 79);
            this.manuePanel.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.patientsDataGridView);
            this.panel1.Location = new System.Drawing.Point(788, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 520);
            this.panel1.TabIndex = 12;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(4, 16);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(168, 23);
            this.searchTextBox.TabIndex = 35;
            this.searchTextBox.Tag = "ssearchTextBox";
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // doctorPanel
            // 
            this.doctorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.doctorPanel.Controls.Add(this.doctorDetailsPanel);
            this.doctorPanel.Location = new System.Drawing.Point(8, 162);
            this.doctorPanel.Name = "doctorPanel";
            this.doctorPanel.Size = new System.Drawing.Size(774, 437);
            this.doctorPanel.TabIndex = 14;
            // 
            // doctorDetailsPanel
            // 
            this.doctorDetailsPanel.Controls.Add(this.backButton);
            this.doctorDetailsPanel.Controls.Add(this.medicalAdviceLabel);
            this.doctorDetailsPanel.Controls.Add(this.label15);
            this.doctorDetailsPanel.Controls.Add(this.medicalAdviceEditButton);
            this.doctorDetailsPanel.Controls.Add(this.medicalAdviceSaveButton);
            this.doctorDetailsPanel.Controls.Add(this.diseaseDiagnosisLabel);
            this.doctorDetailsPanel.Controls.Add(this.label7);
            this.doctorDetailsPanel.Controls.Add(this.removeButton);
            this.doctorDetailsPanel.Controls.Add(this.refreshButton);
            this.doctorDetailsPanel.Controls.Add(this.medicationButton);
            this.doctorDetailsPanel.Controls.Add(this.diseaseDiagnosisEditButton);
            this.doctorDetailsPanel.Controls.Add(this.diseaseDiagnosisSaveButton);
            this.doctorDetailsPanel.Location = new System.Drawing.Point(3, 3);
            this.doctorDetailsPanel.Name = "doctorDetailsPanel";
            this.doctorDetailsPanel.Size = new System.Drawing.Size(769, 432);
            this.doctorDetailsPanel.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(336, 384);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(56, 43);
            this.backButton.TabIndex = 44;
            this.backButton.Tag = "backButton";
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.CommonClick);
            // 
            // medicalAdviceLabel
            // 
            this.medicalAdviceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.medicalAdviceLabel.Location = new System.Drawing.Point(5, 232);
            this.medicalAdviceLabel.Name = "medicalAdviceLabel";
            this.medicalAdviceLabel.Size = new System.Drawing.Size(764, 146);
            this.medicalAdviceLabel.TabIndex = 43;
            this.medicalAdviceLabel.Tag = "clearable";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(0, 202);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 15);
            this.label15.TabIndex = 42;
            this.label15.Text = "Medical advice:";
            // 
            // medicalAdviceEditButton
            // 
            this.medicalAdviceEditButton.Location = new System.Drawing.Point(108, 198);
            this.medicalAdviceEditButton.Name = "medicalAdviceEditButton";
            this.medicalAdviceEditButton.Size = new System.Drawing.Size(41, 23);
            this.medicalAdviceEditButton.TabIndex = 40;
            this.medicalAdviceEditButton.Tag = "medicalAdviceEditButton";
            this.medicalAdviceEditButton.Text = "Edit";
            this.medicalAdviceEditButton.UseVisualStyleBackColor = true;
            this.medicalAdviceEditButton.Click += new System.EventHandler(this.EditSaveClick);
            // 
            // medicalAdviceSaveButton
            // 
            this.medicalAdviceSaveButton.Location = new System.Drawing.Point(155, 198);
            this.medicalAdviceSaveButton.Name = "medicalAdviceSaveButton";
            this.medicalAdviceSaveButton.Size = new System.Drawing.Size(41, 23);
            this.medicalAdviceSaveButton.TabIndex = 41;
            this.medicalAdviceSaveButton.Tag = "medicalAdviceSaveButton";
            this.medicalAdviceSaveButton.Text = "Save";
            this.medicalAdviceSaveButton.UseVisualStyleBackColor = true;
            this.medicalAdviceSaveButton.Click += new System.EventHandler(this.EditSaveClick);
            // 
            // diseaseDiagnosisLabel
            // 
            this.diseaseDiagnosisLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.diseaseDiagnosisLabel.Location = new System.Drawing.Point(5, 37);
            this.diseaseDiagnosisLabel.Name = "diseaseDiagnosisLabel";
            this.diseaseDiagnosisLabel.Size = new System.Drawing.Size(764, 146);
            this.diseaseDiagnosisLabel.TabIndex = 39;
            this.diseaseDiagnosisLabel.Tag = "clearable";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "Disease diagnosis:";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(398, 384);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(149, 43);
            this.removeButton.TabIndex = 35;
            this.removeButton.Tag = "remove";
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.CommonClick);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(708, 386);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(56, 43);
            this.refreshButton.TabIndex = 37;
            this.refreshButton.Tag = "refresh";
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.CommonClick);
            // 
            // medicationButton
            // 
            this.medicationButton.Location = new System.Drawing.Point(553, 384);
            this.medicationButton.Name = "medicationButton";
            this.medicationButton.Size = new System.Drawing.Size(149, 43);
            this.medicationButton.TabIndex = 36;
            this.medicationButton.Tag = "medication tap";
            this.medicationButton.Text = "Medicine tap";
            this.medicationButton.UseVisualStyleBackColor = true;
            this.medicationButton.Click += new System.EventHandler(this.CommonClick);
            // 
            // diseaseDiagnosisEditButton
            // 
            this.diseaseDiagnosisEditButton.Location = new System.Drawing.Point(108, 3);
            this.diseaseDiagnosisEditButton.Name = "diseaseDiagnosisEditButton";
            this.diseaseDiagnosisEditButton.Size = new System.Drawing.Size(41, 23);
            this.diseaseDiagnosisEditButton.TabIndex = 33;
            this.diseaseDiagnosisEditButton.Tag = "diseaseDiagnosisEditButton";
            this.diseaseDiagnosisEditButton.Text = "Edit";
            this.diseaseDiagnosisEditButton.UseVisualStyleBackColor = true;
            this.diseaseDiagnosisEditButton.Click += new System.EventHandler(this.EditSaveClick);
            // 
            // diseaseDiagnosisSaveButton
            // 
            this.diseaseDiagnosisSaveButton.Location = new System.Drawing.Point(155, 3);
            this.diseaseDiagnosisSaveButton.Name = "diseaseDiagnosisSaveButton";
            this.diseaseDiagnosisSaveButton.Size = new System.Drawing.Size(41, 23);
            this.diseaseDiagnosisSaveButton.TabIndex = 34;
            this.diseaseDiagnosisSaveButton.Tag = "diseaseDiagnosisSaveButton";
            this.diseaseDiagnosisSaveButton.Text = "Save";
            this.diseaseDiagnosisSaveButton.UseVisualStyleBackColor = true;
            this.diseaseDiagnosisSaveButton.Click += new System.EventHandler(this.EditSaveClick);
            // 
            // DoctorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.doctorPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.manuePanel);
            this.Controls.Add(this.panel1);
            this.Name = "DoctorUserControl";
            this.Size = new System.Drawing.Size(970, 608);
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.manuePanel.ResumeLayout(false);
            this.manuePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.doctorPanel.ResumeLayout(false);
            this.doctorDetailsPanel.ResumeLayout(false);
            this.doctorDetailsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView patientsDataGridView;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button nurseTapButton;
        private System.Windows.Forms.Button secretaryTapButton;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label identityNumberLabel;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label identityNumberLabel1;
        private System.Windows.Forms.Label lastnameLabel1;
        private System.Windows.Forms.Label firstnameLabel1;
        private System.Windows.Forms.Panel manuePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button doctorTapButton;
        private System.Windows.Forms.Panel doctorPanel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Panel doctorDetailsPanel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label medicalAdviceLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button medicalAdviceEditButton;
        private System.Windows.Forms.Button medicalAdviceSaveButton;
        private System.Windows.Forms.Label diseaseDiagnosisLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button medicationButton;
        private System.Windows.Forms.Button diseaseDiagnosisEditButton;
        private System.Windows.Forms.Button diseaseDiagnosisSaveButton;
    }
}
