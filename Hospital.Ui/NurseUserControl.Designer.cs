namespace Hospital.Ui
{
    partial class NurseUserControl
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
            this.removeButton = new System.Windows.Forms.Button();
            this.sendToDoctorButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.patientsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bloodPressureSaveButton = new System.Windows.Forms.Button();
            this.bloodPressureEditButton = new System.Windows.Forms.Button();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.manuePanel = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.detailesNursePanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.sensitivesSaveButton = new System.Windows.Forms.Button();
            this.sensitivesEditButton = new System.Windows.Forms.Button();
            this.sensitivesLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.isSmokingSaveButton = new System.Windows.Forms.Button();
            this.isSmokingEditButton = new System.Windows.Forms.Button();
            this.isSmokingLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.urineTestSaveButton = new System.Windows.Forms.Button();
            this.urineTestEditButton = new System.Windows.Forms.Button();
            this.bloodTestSaveBtton = new System.Windows.Forms.Button();
            this.bloodTestEditButton = new System.Windows.Forms.Button();
            this.oxginInBloodSaveButton = new System.Windows.Forms.Button();
            this.oxginInBloodEditButton = new System.Windows.Forms.Button();
            this.heartbeatSaveButton = new System.Windows.Forms.Button();
            this.heartbeatEditButton = new System.Windows.Forms.Button();
            this.heatSaveButton = new System.Windows.Forms.Button();
            this.heatEditButton = new System.Windows.Forms.Button();
            this.oxginInBloodLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.heartbeatLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.heatLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bloodBressureLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.urineTestLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bloodTestLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.manuePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.detailesNursePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(401, 387);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(149, 43);
            this.removeButton.TabIndex = 23;
            this.removeButton.Tag = "remove";
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.CommonClick);
            // 
            // sendToDoctorButton
            // 
            this.sendToDoctorButton.Location = new System.Drawing.Point(556, 387);
            this.sendToDoctorButton.Name = "sendToDoctorButton";
            this.sendToDoctorButton.Size = new System.Drawing.Size(149, 43);
            this.sendToDoctorButton.TabIndex = 24;
            this.sendToDoctorButton.Tag = "sendToDoctor";
            this.sendToDoctorButton.Text = "Send to doctor";
            this.sendToDoctorButton.UseVisualStyleBackColor = true;
            this.sendToDoctorButton.Click += new System.EventHandler(this.CommonClick);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(711, 387);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(56, 43);
            this.refreshButton.TabIndex = 25;
            this.refreshButton.Tag = "refresh";
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.CommonClick);
            // 
            // patientsDataGridView
            // 
            this.patientsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.patientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDataGridView.Location = new System.Drawing.Point(4, 3);
            this.patientsDataGridView.Name = "patientsDataGridView";
            this.patientsDataGridView.RowTemplate.Height = 25;
            this.patientsDataGridView.Size = new System.Drawing.Size(168, 509);
            this.patientsDataGridView.TabIndex = 0;
            this.patientsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientsDataGridView_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.patientsDataGridView);
            this.panel1.Location = new System.Drawing.Point(788, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 520);
            this.panel1.TabIndex = 8;
            // 
            // bloodPressureSaveButton
            // 
            this.bloodPressureSaveButton.Location = new System.Drawing.Point(144, 7);
            this.bloodPressureSaveButton.Name = "bloodPressureSaveButton";
            this.bloodPressureSaveButton.Size = new System.Drawing.Size(41, 23);
            this.bloodPressureSaveButton.TabIndex = 18;
            this.bloodPressureSaveButton.Tag = "bloodPressureSaveButton";
            this.bloodPressureSaveButton.Text = "Save";
            this.bloodPressureSaveButton.UseVisualStyleBackColor = true;
            this.bloodPressureSaveButton.Click += new System.EventHandler(this.EditSaveClick);
            // 
            // bloodPressureEditButton
            // 
            this.bloodPressureEditButton.Location = new System.Drawing.Point(97, 7);
            this.bloodPressureEditButton.Name = "bloodPressureEditButton";
            this.bloodPressureEditButton.Size = new System.Drawing.Size(41, 23);
            this.bloodPressureEditButton.TabIndex = 17;
            this.bloodPressureEditButton.Tag = "bloodPressureEditButton";
            this.bloodPressureEditButton.Text = "Edit";
            this.bloodPressureEditButton.UseVisualStyleBackColor = true;
            this.bloodPressureEditButton.Click += new System.EventHandler(this.EditSaveClick);
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
            // manuePanel
            // 
            this.manuePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.manuePanel.Controls.Add(this.employeeNameLabel);
            this.manuePanel.Controls.Add(this.logoutButton);
            this.manuePanel.Location = new System.Drawing.Point(788, 3);
            this.manuePanel.Name = "manuePanel";
            this.manuePanel.Size = new System.Drawing.Size(174, 79);
            this.manuePanel.TabIndex = 6;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(46, 39);
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
            this.panel2.TabIndex = 9;
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
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateOfBirthLabel.Location = new System.Drawing.Point(496, 50);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(183, 24);
            this.dateOfBirthLabel.TabIndex = 21;
            // 
            // identityNumberLabel
            // 
            this.identityNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.identityNumberLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.identityNumberLabel.Location = new System.Drawing.Point(209, 52);
            this.identityNumberLabel.Name = "identityNumberLabel";
            this.identityNumberLabel.Size = new System.Drawing.Size(145, 24);
            this.identityNumberLabel.TabIndex = 20;
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lastnameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastnameLabel.Location = new System.Drawing.Point(476, 14);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(220, 24);
            this.lastnameLabel.TabIndex = 19;
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.firstnameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstnameLabel.Location = new System.Drawing.Point(154, 14);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(183, 24);
            this.firstnameLabel.TabIndex = 18;
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
            // detailesNursePanel
            // 
            this.detailesNursePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.detailesNursePanel.Controls.Add(this.backButton);
            this.detailesNursePanel.Controls.Add(this.sensitivesSaveButton);
            this.detailesNursePanel.Controls.Add(this.sensitivesEditButton);
            this.detailesNursePanel.Controls.Add(this.sensitivesLabel);
            this.detailesNursePanel.Controls.Add(this.label13);
            this.detailesNursePanel.Controls.Add(this.isSmokingSaveButton);
            this.detailesNursePanel.Controls.Add(this.isSmokingEditButton);
            this.detailesNursePanel.Controls.Add(this.isSmokingLabel);
            this.detailesNursePanel.Controls.Add(this.label12);
            this.detailesNursePanel.Controls.Add(this.urineTestSaveButton);
            this.detailesNursePanel.Controls.Add(this.urineTestEditButton);
            this.detailesNursePanel.Controls.Add(this.bloodTestSaveBtton);
            this.detailesNursePanel.Controls.Add(this.bloodTestEditButton);
            this.detailesNursePanel.Controls.Add(this.oxginInBloodSaveButton);
            this.detailesNursePanel.Controls.Add(this.oxginInBloodEditButton);
            this.detailesNursePanel.Controls.Add(this.heartbeatSaveButton);
            this.detailesNursePanel.Controls.Add(this.heartbeatEditButton);
            this.detailesNursePanel.Controls.Add(this.heatSaveButton);
            this.detailesNursePanel.Controls.Add(this.heatEditButton);
            this.detailesNursePanel.Controls.Add(this.oxginInBloodLabel);
            this.detailesNursePanel.Controls.Add(this.label11);
            this.detailesNursePanel.Controls.Add(this.bloodPressureSaveButton);
            this.detailesNursePanel.Controls.Add(this.heartbeatLabel);
            this.detailesNursePanel.Controls.Add(this.label10);
            this.detailesNursePanel.Controls.Add(this.bloodPressureEditButton);
            this.detailesNursePanel.Controls.Add(this.heatLabel);
            this.detailesNursePanel.Controls.Add(this.label9);
            this.detailesNursePanel.Controls.Add(this.bloodBressureLabel);
            this.detailesNursePanel.Controls.Add(this.label6);
            this.detailesNursePanel.Controls.Add(this.urineTestLabel);
            this.detailesNursePanel.Controls.Add(this.label8);
            this.detailesNursePanel.Controls.Add(this.bloodTestLabel);
            this.detailesNursePanel.Controls.Add(this.label5);
            this.detailesNursePanel.Controls.Add(this.removeButton);
            this.detailesNursePanel.Controls.Add(this.refreshButton);
            this.detailesNursePanel.Controls.Add(this.sendToDoctorButton);
            this.detailesNursePanel.Location = new System.Drawing.Point(8, 162);
            this.detailesNursePanel.Name = "detailesNursePanel";
            this.detailesNursePanel.Size = new System.Drawing.Size(774, 437);
            this.detailesNursePanel.TabIndex = 10;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(339, 387);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(56, 43);
            this.backButton.TabIndex = 56;
            this.backButton.Tag = "backButton";
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.CommonClick);
            // 
            // sensitivesSaveButton
            // 
            this.sensitivesSaveButton.Location = new System.Drawing.Point(657, 79);
            this.sensitivesSaveButton.Name = "sensitivesSaveButton";
            this.sensitivesSaveButton.Size = new System.Drawing.Size(41, 23);
            this.sensitivesSaveButton.TabIndex = 55;
            this.sensitivesSaveButton.Tag = "sensitivesSaveButton";
            this.sensitivesSaveButton.Text = "Save";
            this.sensitivesSaveButton.UseVisualStyleBackColor = true;
            this.sensitivesSaveButton.Click += new System.EventHandler(this.EditSaveClick);
            // 
            // sensitivesEditButton
            // 
            this.sensitivesEditButton.Location = new System.Drawing.Point(610, 79);
            this.sensitivesEditButton.Name = "sensitivesEditButton";
            this.sensitivesEditButton.Size = new System.Drawing.Size(41, 23);
            this.sensitivesEditButton.TabIndex = 54;
            this.sensitivesEditButton.Tag = "sensitivesEditButton";
            this.sensitivesEditButton.Text = "Edit";
            this.sensitivesEditButton.UseVisualStyleBackColor = true;
            this.sensitivesEditButton.Click += new System.EventHandler(this.EditSaveClick);
            // 
            // sensitivesLabel
            // 
            this.sensitivesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sensitivesLabel.Location = new System.Drawing.Point(542, 108);
            this.sensitivesLabel.Name = "sensitivesLabel";
            this.sensitivesLabel.Size = new System.Drawing.Size(216, 78);
            this.sensitivesLabel.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(542, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 15);
            this.label13.TabIndex = 52;
            this.label13.Text = "Sensitives:";
            // 
            // isSmokingSaveButton
            // 
            this.isSmokingSaveButton.Location = new System.Drawing.Point(402, 75);
            this.isSmokingSaveButton.Name = "isSmokingSaveButton";
            this.isSmokingSaveButton.Size = new System.Drawing.Size(41, 23);
            this.isSmokingSaveButton.TabIndex = 51;
            this.isSmokingSaveButton.Tag = "isSmokingSaveButton";
            this.isSmokingSaveButton.Text = "Save";
            this.isSmokingSaveButton.UseVisualStyleBackColor = true;
            this.isSmokingSaveButton.Click += new System.EventHandler(this.EditSaveClick);
            // 
            // isSmokingEditButton
            // 
            this.isSmokingEditButton.Location = new System.Drawing.Point(355, 75);
            this.isSmokingEditButton.Name = "isSmokingEditButton";
            this.isSmokingEditButton.Size = new System.Drawing.Size(41, 23);
            this.isSmokingEditButton.TabIndex = 50;
            this.isSmokingEditButton.Tag = "isSmokingEditButton";
            this.isSmokingEditButton.Text = "Edit";
            this.isSmokingEditButton.UseVisualStyleBackColor = true;
            this.isSmokingEditButton.Click += new System.EventHandler(this.EditSaveClick);
            // 
            // isSmokingLabel
            // 
            this.isSmokingLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.isSmokingLabel.Location = new System.Drawing.Point(286, 104);
            this.isSmokingLabel.Name = "isSmokingLabel";
            this.isSmokingLabel.Size = new System.Drawing.Size(140, 26);
            this.isSmokingLabel.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(286, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 15);
            this.label12.TabIndex = 48;
            this.label12.Text = "Is smoking";
            // 
            // urineTestSaveButton
            // 
            this.urineTestSaveButton.Location = new System.Drawing.Point(487, 140);
            this.urineTestSaveButton.Name = "urineTestSaveButton";
            this.urineTestSaveButton.Size = new System.Drawing.Size(41, 23);
            this.urineTestSaveButton.TabIndex = 47;
            this.urineTestSaveButton.Tag = "urineTestSaveButton";
            this.urineTestSaveButton.Text = "Save";
            this.urineTestSaveButton.UseVisualStyleBackColor = true;
            this.urineTestSaveButton.Click += new System.EventHandler(this.EditSaveClick);
            // 
            // urineTestEditButton
            // 
            this.urineTestEditButton.Location = new System.Drawing.Point(440, 140);
            this.urineTestEditButton.Name = "urineTestEditButton";
            this.urineTestEditButton.Size = new System.Drawing.Size(41, 23);
            this.urineTestEditButton.TabIndex = 46;
            this.urineTestEditButton.Tag = "urineTestEditButton";
            this.urineTestEditButton.Text = "Edit";
            this.urineTestEditButton.UseVisualStyleBackColor = true;
            this.urineTestEditButton.Click += new System.EventHandler(this.EditSaveClick);
            // 
            // bloodTestSaveBtton
            // 
            this.bloodTestSaveBtton.Location = new System.Drawing.Point(123, 136);
            this.bloodTestSaveBtton.Name = "bloodTestSaveBtton";
            this.bloodTestSaveBtton.Size = new System.Drawing.Size(41, 23);
            this.bloodTestSaveBtton.TabIndex = 45;
            this.bloodTestSaveBtton.Tag = "bloodTestSaveButton";
            this.bloodTestSaveBtton.Text = "Save";
            this.bloodTestSaveBtton.UseVisualStyleBackColor = true;
            this.bloodTestSaveBtton.Click += new System.EventHandler(this.EditSaveClick);
            // 
            // bloodTestEditButton
            // 
            this.bloodTestEditButton.Location = new System.Drawing.Point(76, 136);
            this.bloodTestEditButton.Name = "bloodTestEditButton";
            this.bloodTestEditButton.Size = new System.Drawing.Size(41, 23);
            this.bloodTestEditButton.TabIndex = 44;
            this.bloodTestEditButton.Tag = "bloodTestEditButton";
            this.bloodTestEditButton.Text = "Edit";
            this.bloodTestEditButton.UseVisualStyleBackColor = true;
            this.bloodTestEditButton.Click += new System.EventHandler(this.EditSaveClick);
            // 
            // oxginInBloodSaveButton
            // 
            this.oxginInBloodSaveButton.Location = new System.Drawing.Point(145, 71);
            this.oxginInBloodSaveButton.Name = "oxginInBloodSaveButton";
            this.oxginInBloodSaveButton.Size = new System.Drawing.Size(41, 23);
            this.oxginInBloodSaveButton.TabIndex = 43;
            this.oxginInBloodSaveButton.Tag = "oxginInBloodSaveButton";
            this.oxginInBloodSaveButton.Text = "Save";
            this.oxginInBloodSaveButton.UseVisualStyleBackColor = true;
            this.oxginInBloodSaveButton.Click += new System.EventHandler(this.EditSaveClick);
            // 
            // oxginInBloodEditButton
            // 
            this.oxginInBloodEditButton.Location = new System.Drawing.Point(98, 71);
            this.oxginInBloodEditButton.Name = "oxginInBloodEditButton";
            this.oxginInBloodEditButton.Size = new System.Drawing.Size(41, 23);
            this.oxginInBloodEditButton.TabIndex = 42;
            this.oxginInBloodEditButton.Tag = "oxginInBloodEditButton";
            this.oxginInBloodEditButton.Text = "Edit";
            this.oxginInBloodEditButton.UseVisualStyleBackColor = true;
            this.oxginInBloodEditButton.Click += new System.EventHandler(this.EditSaveClick);
            // 
            // heartbeatSaveButton
            // 
            this.heartbeatSaveButton.Location = new System.Drawing.Point(686, 7);
            this.heartbeatSaveButton.Name = "heartbeatSaveButton";
            this.heartbeatSaveButton.Size = new System.Drawing.Size(41, 23);
            this.heartbeatSaveButton.TabIndex = 41;
            this.heartbeatSaveButton.Tag = "heartbeatSaveButton";
            this.heartbeatSaveButton.Text = "Save";
            this.heartbeatSaveButton.UseVisualStyleBackColor = true;
            this.heartbeatSaveButton.Click += new System.EventHandler(this.EditSaveClick);
            // 
            // heartbeatEditButton
            // 
            this.heartbeatEditButton.Location = new System.Drawing.Point(639, 7);
            this.heartbeatEditButton.Name = "heartbeatEditButton";
            this.heartbeatEditButton.Size = new System.Drawing.Size(41, 23);
            this.heartbeatEditButton.TabIndex = 40;
            this.heartbeatEditButton.Tag = "heartbeatEditButton";
            this.heartbeatEditButton.Text = "Edit";
            this.heartbeatEditButton.UseVisualStyleBackColor = true;
            this.heartbeatEditButton.Click += new System.EventHandler(this.EditSaveClick);
            // 
            // heatSaveButton
            // 
            this.heatSaveButton.Location = new System.Drawing.Point(374, 7);
            this.heatSaveButton.Name = "heatSaveButton";
            this.heatSaveButton.Size = new System.Drawing.Size(41, 23);
            this.heatSaveButton.TabIndex = 39;
            this.heatSaveButton.Tag = "heatSaveButton";
            this.heatSaveButton.Text = "Save";
            this.heatSaveButton.UseVisualStyleBackColor = true;
            this.heatSaveButton.Click += new System.EventHandler(this.EditSaveClick);
            // 
            // heatEditButton
            // 
            this.heatEditButton.Location = new System.Drawing.Point(327, 7);
            this.heatEditButton.Name = "heatEditButton";
            this.heatEditButton.Size = new System.Drawing.Size(41, 23);
            this.heatEditButton.TabIndex = 38;
            this.heatEditButton.Tag = "heatEditButton";
            this.heatEditButton.Text = "Edit";
            this.heatEditButton.UseVisualStyleBackColor = true;
            this.heatEditButton.Click += new System.EventHandler(this.EditSaveClick);
            // 
            // oxginInBloodLabel
            // 
            this.oxginInBloodLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.oxginInBloodLabel.Location = new System.Drawing.Point(7, 97);
            this.oxginInBloodLabel.Name = "oxginInBloodLabel";
            this.oxginInBloodLabel.Size = new System.Drawing.Size(144, 29);
            this.oxginInBloodLabel.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 15);
            this.label11.TabIndex = 36;
            this.label11.Text = "Oxgin in blood:";
            // 
            // heartbeatLabel
            // 
            this.heartbeatLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.heartbeatLabel.Location = new System.Drawing.Point(571, 36);
            this.heartbeatLabel.Name = "heartbeatLabel";
            this.heartbeatLabel.Size = new System.Drawing.Size(140, 26);
            this.heartbeatLabel.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(571, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 15);
            this.label10.TabIndex = 34;
            this.label10.Text = "Heartbeat:";
            // 
            // heatLabel
            // 
            this.heatLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.heatLabel.Location = new System.Drawing.Point(286, 36);
            this.heatLabel.Name = "heatLabel";
            this.heatLabel.Size = new System.Drawing.Size(140, 26);
            this.heatLabel.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 32;
            this.label9.Text = "Heat:";
            // 
            // bloodBressureLabel
            // 
            this.bloodBressureLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bloodBressureLabel.Location = new System.Drawing.Point(7, 33);
            this.bloodBressureLabel.Name = "bloodBressureLabel";
            this.bloodBressureLabel.Size = new System.Drawing.Size(140, 26);
            this.bloodBressureLabel.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Blood pressure:";
            // 
            // urineTestLabel
            // 
            this.urineTestLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.urineTestLabel.Location = new System.Drawing.Point(363, 200);
            this.urineTestLabel.Name = "urineTestLabel";
            this.urineTestLabel.Size = new System.Drawing.Size(404, 167);
            this.urineTestLabel.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "Urine test:";
            // 
            // bloodTestLabel
            // 
            this.bloodTestLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bloodTestLabel.Location = new System.Drawing.Point(3, 200);
            this.bloodTestLabel.Name = "bloodTestLabel";
            this.bloodTestLabel.Size = new System.Drawing.Size(354, 167);
            this.bloodTestLabel.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Blood test:";
            // 
            // NurseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.detailesNursePanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.manuePanel);
            this.Name = "NurseUserControl";
            this.Size = new System.Drawing.Size(970, 608);
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.manuePanel.ResumeLayout(false);
            this.manuePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.detailesNursePanel.ResumeLayout(false);
            this.detailesNursePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView patientsDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bloodPressureSaveButton;
        private System.Windows.Forms.Button bloodPressureEditButton;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Panel manuePanel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button nurseTapButton;
        private System.Windows.Forms.Button secretaryTapButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button sendToDoctorButton;
        private System.Windows.Forms.Button removeButton;
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
        private System.Windows.Forms.Panel detailesNursePanel;
        private System.Windows.Forms.Label urineTestLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label bloodTestLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label bloodBressureLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label oxginInBloodLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label heartbeatLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label heatLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button urineTestSaveButton;
        private System.Windows.Forms.Button urineTestEditButton;
        private System.Windows.Forms.Button bloodTestSaveBtton;
        private System.Windows.Forms.Button bloodTestEditButton;
        private System.Windows.Forms.Button oxginInBloodSaveButton;
        private System.Windows.Forms.Button oxginInBloodEditButton;
        private System.Windows.Forms.Button heartbeatSaveButton;
        private System.Windows.Forms.Button heartbeatEditButton;
        private System.Windows.Forms.Button heatSaveButton;
        private System.Windows.Forms.Button heatEditButton;
        private System.Windows.Forms.Button isSmokingSaveButton;
        private System.Windows.Forms.Button isSmokingEditButton;
        private System.Windows.Forms.Label isSmokingLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button sensitivesSaveButton;
        private System.Windows.Forms.Button sensitivesEditButton;
        private System.Windows.Forms.Label sensitivesLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button backButton;
    }
}
