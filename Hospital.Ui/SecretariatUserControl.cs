using Hospital.Entities.Models;
using Hospital.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.Ui
{
    public partial class SecretariatUserControl : UserControl
    {
        #region Propreties
        Employee employee;
        Patient patient;
        SecretaryLogic secretaryLogic;
        IAccountLogic accountLogic;
        Treatment treatment;
        TextBox textBox;
        ComboBox comboBox;
        Label label;
        #endregion

        #region Events
        public event Action Logout;
        #endregion

        public SecretariatUserControl(Employee employee)
        {
            InitializeComponent();

            this.employee = employee;
            secretaryLogic = new SecretaryLogic();
            accountLogic = new AccountLogic();
            textBox = new TextBox();

            employeeNameLabel.Text = employee.Person.FirstName + " " + employee.Person.LastName;

            ShowPatientsWaitingToSecretary();

            accountLogic.Logedout += () => OnLogout();

            reasonOfComingEditButton.Enabled = false;
            reasonOfComingSaveButton.Enabled = false;
            severityOfDiseaseEditButton.Enabled = false;
            severityOfDiseaseSaveButton.Enabled = false;
            sendToNurseButton.Enabled = false;
            removeButton.Enabled = false;
            backButton.Enabled = false;
        }
                
        private void logoutButton_Click(object sender, EventArgs e)
        {
            accountLogic.Logout(employee);
        }

        private void patientsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            patient = secretaryLogic.GetPatient(patientsDataGridView.CurrentCell.Value.ToString());
            secretaryLogic.SetPatientInTreatment(patient, 5);
            firstnameLabel.Text = patient.Person.FirstName;
            lastnameLabel.Text = patient.Person.LastName;
            identityNumberLabel.Text = patient.Person.IdentityNumber;
            dateOfBirthLabel.Text = patient.Person.DateOfBirth.ToString();
            genderLabel.Text = patient.Person.Gender;
            reasonOfComingEditButton.Enabled = true;
            severityOfDiseaseEditButton.Enabled = true;
            sendToNurseButton.Enabled = true;
            removeButton.Enabled = true;
            backButton.Enabled = true;
            patientsDataGridView.Enabled = false;
            refreshButton.Enabled = false;
        }

        private void reasonOfComingEditButton_Click(object sender, EventArgs e)
        {
            reasonOfComingSaveButton.Enabled = true;
            reasonOfComingEditButton.Enabled = false;
            severityOfDiseaseEditButton.Enabled = false;
            removeButton.Enabled = false;
            sendToNurseButton.Enabled = false;
            backButton.Enabled = false;
            Edit(reasonOfComingLabel, "textBox");
        }

        private void reasonOfComingSaveButton_Click(object sender, EventArgs e)
        {
            reasonOfComingSaveButton.Enabled = false;
            reasonOfComingEditButton.Enabled = true;
            severityOfDiseaseEditButton.Enabled = true;
            removeButton.Enabled = true;
            sendToNurseButton.Enabled = true;
            backButton.Enabled = true;
            Save("textBox");
        }

        private void severityOfDiseaseEditButton_Click(object sender, EventArgs e)
        {
            severityOfDiseaseSaveButton.Enabled = true;
            severityOfDiseaseEditButton.Enabled = false;
            reasonOfComingEditButton.Enabled = false;
            removeButton.Enabled = false;
            sendToNurseButton.Enabled = false;
            backButton.Enabled = false;
            Edit(severityOfDiseaseLabel, "comboBox");
        }

        private void severityOfDiseaseSaveButton_Click(object sender, EventArgs e)
        {
            severityOfDiseaseSaveButton.Enabled = false;
            severityOfDiseaseEditButton.Enabled = true;
            reasonOfComingEditButton.Enabled = true;
            removeButton.Enabled = true;
            sendToNurseButton.Enabled = true;
            backButton.Enabled = true;
            Save("comboBox");
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            reasonOfComingEditButton.Enabled = false;
            severityOfDiseaseEditButton.Enabled = false;
            removeButton.Enabled = false;
            sendToNurseButton.Enabled = false;
            backButton.Enabled = false;
            refreshButton.Enabled = true;
            patientsDataGridView.Enabled = true;
            secretaryLogic.RemovePatient(patient);
            patient = new Patient();
            Clear();
            ShowPatientsWaitingToSecretary();
        }        

        private void sendToNurseButton_Click(object sender, EventArgs e)
        {
            reasonOfComingEditButton.Enabled = false;
            reasonOfComingSaveButton.Enabled = false;
            severityOfDiseaseEditButton.Enabled = false;
            severityOfDiseaseSaveButton.Enabled = false;
            sendToNurseButton.Enabled = false;
            removeButton.Enabled = false;
            backButton.Enabled = false;
            treatment = new Treatment();
            treatment.TreatmentInfo = new TreatmentInfo();
            treatment.MedicalFileId = patient.Person.MedicalFileId;
            treatment.TreatmentDate = DateTime.Now;
            treatment.TreatmentInfo.ReasonOfComing = reasonOfComingLabel.Text;
            patient.Treatment = treatment;
            switch (severityOfDiseaseLabel.Text)
            {
                case "Low":
                    patient.SeverityOfDiseaseId = 1;
                    break;
                case "Medium":
                    patient.SeverityOfDiseaseId = 2;
                    break;
                case "Hight":
                    patient.SeverityOfDiseaseId = 3;
                    break;
                default:
                    patient.SeverityOfDiseaseId = 1;
                    break;
            }
            secretaryLogic.SendToNurse(patient);
            Clear();
            ShowPatientsWaitingToSecretary();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            ShowPatientsWaitingToSecretary();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            patientsDataGridView.Enabled = true;
            reasonOfComingEditButton.Enabled = false;
            reasonOfComingSaveButton.Enabled = false;
            severityOfDiseaseEditButton.Enabled = false;
            severityOfDiseaseSaveButton.Enabled = false;
            sendToNurseButton.Enabled = false;
            removeButton.Enabled = false;
            backButton.Enabled = false;
            refreshButton.Enabled = true;
            secretaryLogic.SetPatientInTreatment(patient, 1);
            Clear();
        }

        #region Assistant functions
        //Get lest of the patients who waiting to secretary and show the lest on data grid.
        private void ShowPatientsWaitingToSecretary()
        {
            patientsDataGridView.DataSource = secretaryLogic.GetPatientsWaitingToSecretary();
        }

        //Change the label to text box to change details in it
        private void Edit(Label label, string sender)
        {
            switch (sender)
            {
                case "textBox":
                    textBox = new TextBox();
                    this.label = label;
                    textBox.Multiline = true;
                    textBox.Location = label.Location;
                    textBox.Size = label.Size;
                    textBox.Text = label.Text;
                    detailsPanel.Controls.Remove(label);
                    detailsPanel.Controls.Add(textBox);
                    break;
                case "comboBox":
                    comboBox = new ComboBox();
                    comboBox.Location = label.Location;
                    this.label = label;
                    comboBox.Items.Add("Low");
                    comboBox.Items.Add("Medium");
                    comboBox.Items.Add("Hight");
                    detailsPanel.Controls.Remove(label);
                    detailsPanel.Controls.Add(comboBox);
                    break;
            }
        }

        //Change the text box to label after editing the details
        private void Save(string sender)
        {
            switch (sender)
            {
                case "textBox":
                    label.Text = textBox.Text;
                    detailsPanel.Controls.Remove(textBox);
                    detailsPanel.Controls.Add(label);
                    break;
                case "comboBox":
                    label.Text = comboBox.Text;
                    detailsPanel.Controls.Remove(comboBox);
                    detailsPanel.Controls.Add(label);
                    break;
            }
        }

        //Clear all labels
        private void Clear()
        {
            firstnameLabel.Text = "";
            lastnameLabel.Text = "";
            identityNumberLabel.Text = "";
            dateOfBirthLabel.Text = "";
            genderLabel.Text = "";
            reasonOfComingLabel.Text = "";
            severityOfDiseaseLabel.Text = "";
        }
        #endregion

        #region On events
        public void OnLogout()
        {
            if (Logout != null)
                Logout();
        }
        #endregion        
    }
}
