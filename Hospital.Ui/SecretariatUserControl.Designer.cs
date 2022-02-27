namespace Hospital.Ui
{
    partial class SecretariatUserControl
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
            this.manuePanel = new System.Windows.Forms.Panel();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.sendToNurseButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.severityOfDiseaseSaveButton = new System.Windows.Forms.Button();
            this.severityOfDiseaseEditButton = new System.Windows.Forms.Button();
            this.reasonOfComingSaveButton = new System.Windows.Forms.Button();
            this.reasonOfComingEditButton = new System.Windows.Forms.Button();
            this.severityOfDiseaseLabel = new System.Windows.Forms.Label();
            this.reasonOfComingLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.patientsDataGridView = new System.Windows.Forms.DataGridView();
            this.patientPanel = new System.Windows.Forms.Panel();
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
            this.manuePanel.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).BeginInit();
            this.patientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // manuePanel
            // 
            this.manuePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.manuePanel.Controls.Add(this.employeeNameLabel);
            this.manuePanel.Controls.Add(this.logoutButton);
            this.manuePanel.Location = new System.Drawing.Point(788, 3);
            this.manuePanel.Name = "manuePanel";
            this.manuePanel.Size = new System.Drawing.Size(175, 79);
            this.manuePanel.TabIndex = 3;
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(3, 15);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(38, 15);
            this.employeeNameLabel.TabIndex = 1;
            this.employeeNameLabel.Text = "label1";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(48, 39);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(91, 35);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // detailsPanel
            // 
            this.detailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.detailsPanel.Controls.Add(this.backButton);
            this.detailsPanel.Controls.Add(this.refreshButton);
            this.detailsPanel.Controls.Add(this.sendToNurseButton);
            this.detailsPanel.Controls.Add(this.removeButton);
            this.detailsPanel.Controls.Add(this.severityOfDiseaseSaveButton);
            this.detailsPanel.Controls.Add(this.severityOfDiseaseEditButton);
            this.detailsPanel.Controls.Add(this.reasonOfComingSaveButton);
            this.detailsPanel.Controls.Add(this.reasonOfComingEditButton);
            this.detailsPanel.Controls.Add(this.severityOfDiseaseLabel);
            this.detailsPanel.Controls.Add(this.reasonOfComingLabel);
            this.detailsPanel.Controls.Add(this.label4);
            this.detailsPanel.Controls.Add(this.label3);
            this.detailsPanel.Location = new System.Drawing.Point(3, 167);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(779, 437);
            this.detailsPanel.TabIndex = 4;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(344, 376);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(56, 43);
            this.backButton.TabIndex = 22;
            this.backButton.Tag = "backButton";
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(716, 376);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(56, 43);
            this.refreshButton.TabIndex = 21;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // sendToNurseButton
            // 
            this.sendToNurseButton.Location = new System.Drawing.Point(561, 376);
            this.sendToNurseButton.Name = "sendToNurseButton";
            this.sendToNurseButton.Size = new System.Drawing.Size(149, 43);
            this.sendToNurseButton.TabIndex = 20;
            this.sendToNurseButton.Text = "Send to nurse";
            this.sendToNurseButton.UseVisualStyleBackColor = true;
            this.sendToNurseButton.Click += new System.EventHandler(this.sendToNurseButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(406, 376);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(149, 43);
            this.removeButton.TabIndex = 19;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // severityOfDiseaseSaveButton
            // 
            this.severityOfDiseaseSaveButton.Location = new System.Drawing.Point(254, 312);
            this.severityOfDiseaseSaveButton.Name = "severityOfDiseaseSaveButton";
            this.severityOfDiseaseSaveButton.Size = new System.Drawing.Size(41, 23);
            this.severityOfDiseaseSaveButton.TabIndex = 18;
            this.severityOfDiseaseSaveButton.Text = "Save";
            this.severityOfDiseaseSaveButton.UseVisualStyleBackColor = true;
            this.severityOfDiseaseSaveButton.Click += new System.EventHandler(this.severityOfDiseaseSaveButton_Click);
            // 
            // severityOfDiseaseEditButton
            // 
            this.severityOfDiseaseEditButton.Location = new System.Drawing.Point(207, 312);
            this.severityOfDiseaseEditButton.Name = "severityOfDiseaseEditButton";
            this.severityOfDiseaseEditButton.Size = new System.Drawing.Size(41, 23);
            this.severityOfDiseaseEditButton.TabIndex = 17;
            this.severityOfDiseaseEditButton.Text = "Edit";
            this.severityOfDiseaseEditButton.UseVisualStyleBackColor = true;
            this.severityOfDiseaseEditButton.Click += new System.EventHandler(this.severityOfDiseaseEditButton_Click);
            // 
            // reasonOfComingSaveButton
            // 
            this.reasonOfComingSaveButton.Location = new System.Drawing.Point(242, 18);
            this.reasonOfComingSaveButton.Name = "reasonOfComingSaveButton";
            this.reasonOfComingSaveButton.Size = new System.Drawing.Size(41, 23);
            this.reasonOfComingSaveButton.TabIndex = 16;
            this.reasonOfComingSaveButton.Text = "Save";
            this.reasonOfComingSaveButton.UseVisualStyleBackColor = true;
            this.reasonOfComingSaveButton.Click += new System.EventHandler(this.reasonOfComingSaveButton_Click);
            // 
            // reasonOfComingEditButton
            // 
            this.reasonOfComingEditButton.Location = new System.Drawing.Point(195, 18);
            this.reasonOfComingEditButton.Name = "reasonOfComingEditButton";
            this.reasonOfComingEditButton.Size = new System.Drawing.Size(41, 23);
            this.reasonOfComingEditButton.TabIndex = 15;
            this.reasonOfComingEditButton.Text = "Edit";
            this.reasonOfComingEditButton.UseVisualStyleBackColor = true;
            this.reasonOfComingEditButton.Click += new System.EventHandler(this.reasonOfComingEditButton_Click);
            // 
            // severityOfDiseaseLabel
            // 
            this.severityOfDiseaseLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.severityOfDiseaseLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.severityOfDiseaseLabel.Location = new System.Drawing.Point(40, 335);
            this.severityOfDiseaseLabel.Name = "severityOfDiseaseLabel";
            this.severityOfDiseaseLabel.Size = new System.Drawing.Size(208, 24);
            this.severityOfDiseaseLabel.TabIndex = 14;
            // 
            // reasonOfComingLabel
            // 
            this.reasonOfComingLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reasonOfComingLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reasonOfComingLabel.Location = new System.Drawing.Point(32, 41);
            this.reasonOfComingLabel.Name = "reasonOfComingLabel";
            this.reasonOfComingLabel.Size = new System.Drawing.Size(681, 243);
            this.reasonOfComingLabel.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(32, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Severity of disease:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(32, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Reason of coming:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.patientsDataGridView);
            this.panel1.Location = new System.Drawing.Point(788, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 520);
            this.panel1.TabIndex = 5;
            // 
            // patientsDataGridView
            // 
            this.patientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.patientsDataGridView.Name = "patientsDataGridView";
            this.patientsDataGridView.RowTemplate.Height = 25;
            this.patientsDataGridView.Size = new System.Drawing.Size(170, 515);
            this.patientsDataGridView.TabIndex = 0;
            this.patientsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientsDataGridView_CellContentClick);
            // 
            // patientPanel
            // 
            this.patientPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.patientPanel.Controls.Add(this.genderLabel);
            this.patientPanel.Controls.Add(this.dateOfBirthLabel);
            this.patientPanel.Controls.Add(this.identityNumberLabel);
            this.patientPanel.Controls.Add(this.lastnameLabel);
            this.patientPanel.Controls.Add(this.firstnameLabel);
            this.patientPanel.Controls.Add(this.label2);
            this.patientPanel.Controls.Add(this.label1);
            this.patientPanel.Controls.Add(this.identityNumberLabel1);
            this.patientPanel.Controls.Add(this.lastnameLabel1);
            this.patientPanel.Controls.Add(this.firstnameLabel1);
            this.patientPanel.Location = new System.Drawing.Point(7, 3);
            this.patientPanel.Name = "patientPanel";
            this.patientPanel.Size = new System.Drawing.Size(770, 158);
            this.patientPanel.TabIndex = 6;
            // 
            // genderLabel
            // 
            this.genderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.genderLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genderLabel.Location = new System.Drawing.Point(143, 104);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(106, 24);
            this.genderLabel.TabIndex = 22;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateOfBirthLabel.Location = new System.Drawing.Point(508, 66);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(183, 24);
            this.dateOfBirthLabel.TabIndex = 21;
            // 
            // identityNumberLabel
            // 
            this.identityNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.identityNumberLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.identityNumberLabel.Location = new System.Drawing.Point(221, 68);
            this.identityNumberLabel.Name = "identityNumberLabel";
            this.identityNumberLabel.Size = new System.Drawing.Size(145, 24);
            this.identityNumberLabel.TabIndex = 20;
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lastnameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastnameLabel.Location = new System.Drawing.Point(488, 30);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(220, 24);
            this.lastnameLabel.TabIndex = 19;
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.firstnameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstnameLabel.Location = new System.Drawing.Point(166, 30);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(183, 24);
            this.firstnameLabel.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(58, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Gender:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(380, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Date of birth:";
            // 
            // identityNumberLabel1
            // 
            this.identityNumberLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.identityNumberLabel1.Location = new System.Drawing.Point(58, 64);
            this.identityNumberLabel1.Name = "identityNumberLabel1";
            this.identityNumberLabel1.Size = new System.Drawing.Size(157, 29);
            this.identityNumberLabel1.TabIndex = 15;
            this.identityNumberLabel1.Text = "Identity number:";
            // 
            // lastnameLabel1
            // 
            this.lastnameLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastnameLabel1.Location = new System.Drawing.Point(380, 26);
            this.lastnameLabel1.Name = "lastnameLabel1";
            this.lastnameLabel1.Size = new System.Drawing.Size(102, 29);
            this.lastnameLabel1.TabIndex = 14;
            this.lastnameLabel1.Text = "Lastname:";
            // 
            // firstnameLabel1
            // 
            this.firstnameLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstnameLabel1.Location = new System.Drawing.Point(58, 26);
            this.firstnameLabel1.Name = "firstnameLabel1";
            this.firstnameLabel1.Size = new System.Drawing.Size(102, 29);
            this.firstnameLabel1.TabIndex = 13;
            this.firstnameLabel1.Text = "Firstname:";
            // 
            // SecretariatUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.patientPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.manuePanel);
            this.Name = "SecretariatUserControl";
            this.Size = new System.Drawing.Size(970, 608);
            this.manuePanel.ResumeLayout(false);
            this.manuePanel.PerformLayout();
            this.detailsPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).EndInit();
            this.patientPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel manuePanel;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label severityOfDiseaseLabel;
        private System.Windows.Forms.Label reasonOfComingLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView patientsDataGridView;
        private System.Windows.Forms.Button severityOfDiseaseSaveButton;
        private System.Windows.Forms.Button severityOfDiseaseEditButton;
        private System.Windows.Forms.Button reasonOfComingSaveButton;
        private System.Windows.Forms.Button reasonOfComingEditButton;
        private System.Windows.Forms.Button sendToNurseButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Panel patientPanel;
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
        private System.Windows.Forms.Button backButton;
    }
}
