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
    public partial class NurseUserControl : UserControl
    {
        #region Propreties
        Employee employee;
        NurseLogic nurseLogic;
        IAccountLogic accountLogic;
        Patient patient;
        TextBox textBox;
        ComboBox comboBox;
        Label label;
        SecretariatPanel secretariatPanel;
        #endregion

        #region Events
        public event Action Logout;
        #endregion

        public NurseUserControl(Employee employee)
        {
            InitializeComponent();

            this.employee = employee;
            nurseLogic = new NurseLogic();
            accountLogic = new AccountLogic();
            secretariatPanel = new SecretariatPanel();

            employeeNameLabel.Text = employee.Person.FirstName + " " + employee.Person.LastName;

            ShowPatientsWaitingToNurse();

            accountLogic.Logedout += () => OnLogout();

            secretaryTapButton.Enabled = false;
            nurseTapButton.Enabled = false;
            bloodPressureEditButton.Enabled = false;
            bloodPressureSaveButton.Enabled = false;
            heatEditButton.Enabled = false;
            heatSaveButton.Enabled = false;
            heartbeatEditButton.Enabled = false;
            heartbeatSaveButton.Enabled = false;
            oxginInBloodEditButton.Enabled = false;
            oxginInBloodSaveButton.Enabled = false;
            isSmokingEditButton.Enabled = false;
            isSmokingSaveButton.Enabled = false;
            sensitivesEditButton.Enabled = false;
            sensitivesSaveButton.Enabled = false;
            bloodTestEditButton.Enabled = false;
            bloodTestSaveBtton.Enabled = false;
            urineTestEditButton.Enabled = false;
            urineTestSaveButton.Enabled = false;
            sendToDoctorButton.Enabled = false;
            backButton.Enabled = false;
            removeButton.Enabled = false;
        }

        private void CommonClick(object sender, EventArgs e)
        {
            switch (((Button)sender).Tag)
            {
                case "secretary tap":
                    NurseDetailsUnvisible();
                    secretaryTapButton.Enabled = false;
                    nurseTapButton.Enabled = true;
                    detailesNursePanel.Controls.Add(secretariatPanel);
                    break;
                case "nurse tap":
                    NurseDetailsVisible();
                    secretaryTapButton.Enabled = true;
                    nurseTapButton.Enabled = false;
                    detailesNursePanel.Controls.Remove(secretariatPanel);
                    break;
                case "remove":
                    secretaryTapButton.Enabled = false;
                    bloodPressureEditButton.Enabled = false;
                    heatEditButton.Enabled = false;
                    heartbeatEditButton.Enabled = false;
                    oxginInBloodEditButton.Enabled = false;
                    isSmokingEditButton.Enabled = false;
                    sensitivesEditButton.Enabled = false;
                    bloodTestEditButton.Enabled = false;
                    urineTestEditButton.Enabled = false;
                    backButton.Enabled = false;
                    removeButton.Enabled = false;
                    sendToDoctorButton.Enabled = false;
                    patientsDataGridView.Enabled = true;
                    refreshButton.Enabled = true;
                    nurseLogic.RemovePatient(patient);
                    Clear();
                    break;
                case "sendToDoctor":
                    secretaryTapButton.Enabled = false;
                    bloodPressureEditButton.Enabled = false;
                    heatEditButton.Enabled = false;
                    heartbeatEditButton.Enabled = false;
                    oxginInBloodEditButton.Enabled = false;
                    isSmokingEditButton.Enabled = false;
                    sensitivesEditButton.Enabled = false;
                    bloodTestEditButton.Enabled = false;
                    urineTestEditButton.Enabled = false;
                    backButton.Enabled = false;
                    removeButton.Enabled = false;
                    sendToDoctorButton.Enabled = false;
                    patientsDataGridView.Enabled = true;
                    refreshButton.Enabled = true;
                    patient.Treatment.TreatmentInfo.BloodPressure = bloodBressureLabel.Text;
                    patient.Treatment.TreatmentInfo.Heat = heatLabel.Text;
                    patient.Treatment.TreatmentInfo.Heartbeat = heartbeatLabel.Text;
                    patient.Treatment.TreatmentInfo.OxginInBlood = oxginInBloodLabel.Text;
                    patient.Treatment.TreatmentInfo.Sensitive = sensitivesLabel.Text;
                    patient.Treatment.TreatmentInfo.BloodTest = bloodTestLabel.Text;
                    patient.Treatment.TreatmentInfo.UrineTest = urineTestLabel.Text;
                    switch (isSmokingLabel.Text)
                    {
                        case "Yes":
                            patient.Treatment.TreatmentInfo.IsSmoking = 1;
                            break;
                        case "No":
                            patient.Treatment.TreatmentInfo.IsSmoking = 0;
                            break;
                    }
                    nurseLogic.SendToDoctor(patient);
                    Clear();
                    ShowPatientsWaitingToNurse();
                    break;
                case "refresh":
                    ShowPatientsWaitingToNurse();
                    break;
                case "logout":
                    accountLogic.Logout(employee);
                    break;
                case "backButton":
                    secretaryTapButton.Enabled = false;
                    bloodPressureEditButton.Enabled = false;
                    heatEditButton.Enabled = false;
                    heartbeatEditButton.Enabled = false;
                    oxginInBloodEditButton.Enabled = false;
                    isSmokingEditButton.Enabled = false;
                    sensitivesEditButton.Enabled = false;
                    bloodTestEditButton.Enabled = false;
                    urineTestEditButton.Enabled = false;
                    backButton.Enabled = false;
                    removeButton.Enabled = false;
                    sendToDoctorButton.Enabled = false;
                    patientsDataGridView.Enabled = true;
                    refreshButton.Enabled = true;
                    nurseLogic.SetPatientInTreatment(patient);
                    Clear();
                    break;
            }
        }

        private void EditSaveClick(object sender, EventArgs e)
        {
            switch (((Button)sender).Tag)
            {
                case "bloodPressureEditButton":
                    secretaryTapButton.Enabled = false;
                    heatEditButton.Enabled = false;
                    heartbeatEditButton.Enabled = false;
                    oxginInBloodEditButton.Enabled = false;
                    isSmokingEditButton.Enabled = false;
                    sensitivesEditButton.Enabled = false;
                    bloodTestEditButton.Enabled = false;
                    urineTestEditButton.Enabled = false;
                    backButton.Enabled = false;
                    removeButton.Enabled = false;
                    sendToDoctorButton.Enabled = false;
                    bloodPressureEditButton.Enabled = false;
                    bloodPressureSaveButton.Enabled = true;
                    Edit(bloodBressureLabel, "textBox");
                    break;
                case "bloodPressureSaveButton":
                    secretaryTapButton.Enabled = true;
                    heatEditButton.Enabled = true;
                    heartbeatEditButton.Enabled = true;
                    oxginInBloodEditButton.Enabled = true;
                    isSmokingEditButton.Enabled = true;
                    sensitivesEditButton.Enabled = true;
                    bloodTestEditButton.Enabled = true;
                    urineTestEditButton.Enabled = true;
                    backButton.Enabled = true;
                    removeButton.Enabled = true;
                    sendToDoctorButton.Enabled = true;
                    bloodPressureEditButton.Enabled = true;
                    bloodPressureSaveButton.Enabled = false;
                    Save("textBox");
                    break;
                case "heatEditButton":
                    secretaryTapButton.Enabled = false;
                    bloodPressureEditButton.Enabled = false;
                    heartbeatEditButton.Enabled = false;
                    oxginInBloodEditButton.Enabled = false;
                    isSmokingEditButton.Enabled = false;
                    sensitivesEditButton.Enabled = false;
                    bloodTestEditButton.Enabled = false;
                    urineTestEditButton.Enabled = false;
                    backButton.Enabled = false;
                    removeButton.Enabled = false;
                    sendToDoctorButton.Enabled = false;
                    heatEditButton.Enabled = false;
                    heatSaveButton.Enabled = true;
                    Edit(heatLabel, "textBox");
                    break;
                case "heatSaveButton":
                    secretaryTapButton.Enabled = true;
                    bloodPressureEditButton.Enabled = true;
                    heartbeatEditButton.Enabled = true;
                    oxginInBloodEditButton.Enabled = true;
                    isSmokingEditButton.Enabled = true;
                    sensitivesEditButton.Enabled = true;
                    bloodTestEditButton.Enabled = true;
                    urineTestEditButton.Enabled = true;
                    backButton.Enabled = true;
                    removeButton.Enabled = true;
                    sendToDoctorButton.Enabled = true;
                    heatEditButton.Enabled = true;
                    heatSaveButton.Enabled = false;
                    Save("textBox");
                    break;
                case "heartbeatEditButton":
                    secretaryTapButton.Enabled = false;
                    bloodPressureEditButton.Enabled = false;
                    oxginInBloodEditButton.Enabled = false;
                    isSmokingEditButton.Enabled = false;
                    sensitivesEditButton.Enabled = false;
                    bloodTestEditButton.Enabled = false;
                    urineTestEditButton.Enabled = false;
                    backButton.Enabled = false;
                    removeButton.Enabled = false;
                    sendToDoctorButton.Enabled = false;
                    heatEditButton.Enabled = false;
                    heartbeatEditButton.Enabled = false;
                    heartbeatSaveButton.Enabled = true;
                    Edit(heartbeatLabel, "textBox");
                    break;
                case "heartbeatSaveButton":
                    secretaryTapButton.Enabled = true;
                    bloodPressureEditButton.Enabled = true;
                    oxginInBloodEditButton.Enabled = true;
                    isSmokingEditButton.Enabled = true;
                    sensitivesEditButton.Enabled = true;
                    bloodTestEditButton.Enabled = true;
                    urineTestEditButton.Enabled = true;
                    backButton.Enabled = true;
                    removeButton.Enabled = true;
                    sendToDoctorButton.Enabled = true;
                    heatEditButton.Enabled = true;
                    heartbeatEditButton.Enabled = true;
                    heartbeatSaveButton.Enabled = false;
                    Save("textBox");
                    break;
                case "oxginInBloodEditButton":
                    secretaryTapButton.Enabled = false;
                    bloodPressureEditButton.Enabled = false;
                    isSmokingEditButton.Enabled = false;
                    sensitivesEditButton.Enabled = false;
                    bloodTestEditButton.Enabled = false;
                    urineTestEditButton.Enabled = false;
                    backButton.Enabled = false;
                    removeButton.Enabled = false;
                    sendToDoctorButton.Enabled = false;
                    heatEditButton.Enabled = false;
                    heartbeatEditButton.Enabled = false;
                    oxginInBloodEditButton.Enabled = false;
                    oxginInBloodSaveButton.Enabled = true;
                    Edit(oxginInBloodLabel, "textBox");
                    break;
                case "oxginInBloodSaveButton":
                    secretaryTapButton.Enabled = true;
                    bloodPressureEditButton.Enabled = true;
                    isSmokingEditButton.Enabled = true;
                    sensitivesEditButton.Enabled = true;
                    bloodTestEditButton.Enabled = true;
                    urineTestEditButton.Enabled = true;
                    backButton.Enabled = true;
                    removeButton.Enabled = true;
                    sendToDoctorButton.Enabled = true;
                    heatEditButton.Enabled = true;
                    heartbeatEditButton.Enabled = true;
                    oxginInBloodEditButton.Enabled = true;
                    oxginInBloodSaveButton.Enabled = false;
                    Save("textBox");
                    break;
                case "isSmokingEditButton":
                    secretaryTapButton.Enabled = false;
                    bloodPressureEditButton.Enabled = false;
                    sensitivesEditButton.Enabled = false;
                    bloodTestEditButton.Enabled = false;
                    urineTestEditButton.Enabled = false;
                    backButton.Enabled = false;
                    removeButton.Enabled = false;
                    sendToDoctorButton.Enabled = false;
                    heatEditButton.Enabled = false;
                    heartbeatEditButton.Enabled = false;
                    oxginInBloodEditButton.Enabled = false;
                    isSmokingEditButton.Enabled = false;
                    isSmokingSaveButton.Enabled = true;
                    Edit(isSmokingLabel, "comboBox");
                    break;
                case "isSmokingSaveButton":
                    secretaryTapButton.Enabled = true;
                    bloodPressureEditButton.Enabled = true;
                    sensitivesEditButton.Enabled = true;
                    bloodTestEditButton.Enabled = true;
                    urineTestEditButton.Enabled = true;
                    backButton.Enabled = true;
                    removeButton.Enabled = true;
                    sendToDoctorButton.Enabled = true;
                    heatEditButton.Enabled = true;
                    heartbeatEditButton.Enabled = true;
                    oxginInBloodEditButton.Enabled = true;
                    isSmokingEditButton.Enabled = true;
                    isSmokingSaveButton.Enabled = false;
                    Save("comboBox");
                    break;
                case "sensitivesEditButton":
                    secretaryTapButton.Enabled = false;
                    bloodPressureEditButton.Enabled = false;
                    bloodTestEditButton.Enabled = false;
                    urineTestEditButton.Enabled = false;
                    backButton.Enabled = false;
                    removeButton.Enabled = false;
                    sendToDoctorButton.Enabled = false;
                    heatEditButton.Enabled = false;
                    heartbeatEditButton.Enabled = false;
                    oxginInBloodEditButton.Enabled = false;
                    isSmokingEditButton.Enabled = false;
                    sensitivesEditButton.Enabled = false;
                    sensitivesSaveButton.Enabled = true;
                    Edit(sensitivesLabel, "textBox");
                    break;
                case "sensitivesSaveButton":
                    secretaryTapButton.Enabled = true;
                    bloodPressureEditButton.Enabled = true;
                    bloodTestEditButton.Enabled = true;
                    urineTestEditButton.Enabled = true;
                    backButton.Enabled = true;
                    removeButton.Enabled = true;
                    sendToDoctorButton.Enabled = true;
                    heatEditButton.Enabled = true;
                    heartbeatEditButton.Enabled = true;
                    oxginInBloodEditButton.Enabled = true;
                    isSmokingEditButton.Enabled = true;
                    sensitivesEditButton.Enabled = true;
                    sensitivesSaveButton.Enabled = false;
                    Save("textBox");
                    break;
                case "bloodTestEditButton":
                    secretaryTapButton.Enabled = false;
                    bloodPressureEditButton.Enabled = false;
                    urineTestEditButton.Enabled = false;
                    backButton.Enabled = false;
                    removeButton.Enabled = false;
                    sendToDoctorButton.Enabled = false;
                    heatEditButton.Enabled = false;
                    heartbeatEditButton.Enabled = false;
                    oxginInBloodEditButton.Enabled = false;
                    isSmokingEditButton.Enabled = false;
                    sensitivesEditButton.Enabled = false;
                    bloodTestEditButton.Enabled = false;
                    bloodTestSaveBtton.Enabled = true;
                    Edit(bloodTestLabel, "bloodTestComboTextBox");
                    break;
                case "bloodTestSaveButton":
                    secretaryTapButton.Enabled = true;
                    bloodPressureEditButton.Enabled = true;
                    sensitivesEditButton.Enabled = true;
                    urineTestEditButton.Enabled = true;
                    backButton.Enabled = true;
                    removeButton.Enabled = true;
                    sendToDoctorButton.Enabled = true;
                    heatEditButton.Enabled = true;
                    heartbeatEditButton.Enabled = true;
                    oxginInBloodEditButton.Enabled = true;
                    isSmokingEditButton.Enabled = true;
                    bloodTestEditButton.Enabled = true;
                    bloodTestSaveBtton.Enabled = false;
                    Save("comboTextBox");
                    break;                
                case "urineTestEditButton":
                    secretaryTapButton.Enabled = false;
                    bloodPressureEditButton.Enabled = false;
                    bloodTestEditButton.Enabled = false;
                    backButton.Enabled = false;
                    removeButton.Enabled = false;
                    sendToDoctorButton.Enabled = false;
                    heatEditButton.Enabled = false;
                    heartbeatEditButton.Enabled = false;
                    oxginInBloodEditButton.Enabled = false;
                    isSmokingEditButton.Enabled = false;
                    sensitivesEditButton.Enabled = false;
                    urineTestEditButton.Enabled = false;
                    urineTestSaveButton.Enabled = true;
                    Edit(urineTestLabel, "urineTestComboTextBox");
                    break;
                case "urineTestSaveButton":
                    secretaryTapButton.Enabled = true;
                    bloodPressureEditButton.Enabled = true;
                    sensitivesEditButton.Enabled = true;
                    bloodTestEditButton.Enabled = true;
                    backButton.Enabled = true;
                    removeButton.Enabled = true;
                    sendToDoctorButton.Enabled = true;
                    heatEditButton.Enabled = true;
                    heartbeatEditButton.Enabled = true;
                    oxginInBloodEditButton.Enabled = true;
                    isSmokingEditButton.Enabled = true;
                    urineTestEditButton.Enabled = true;
                    urineTestSaveButton.Enabled = false;
                    Save("comboTextBox");
                    break;
            }
        }

        private void patientsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            secretaryTapButton.Enabled = true;
            bloodPressureEditButton.Enabled = true;
            sensitivesEditButton.Enabled = true;
            bloodTestEditButton.Enabled = true;
            backButton.Enabled = true;
            removeButton.Enabled = true;
            sendToDoctorButton.Enabled = true;
            heatEditButton.Enabled = true;
            heartbeatEditButton.Enabled = true;
            oxginInBloodEditButton.Enabled = true;
            isSmokingEditButton.Enabled = true;
            urineTestEditButton.Enabled = true;
            patientsDataGridView.Enabled = false;
            refreshButton.Enabled = false;
            patient = nurseLogic.GetPatient(patientsDataGridView.CurrentCell.Value.ToString());
            nurseLogic.SetPatientInTreatment(patient);
            patient = nurseLogic.GetTreatment(patient);
            firstnameLabel.Text = patient.Person.FirstName;
            lastnameLabel.Text = patient.Person.LastName;
            identityNumberLabel.Text = patient.Person.IdentityNumber;
            dateOfBirthLabel.Text = patient.Person.DateOfBirth.ToString();
            genderLabel.Text = patient.Person.Gender;
            secretariatPanel.SetStringToLable(patient.Treatment.TreatmentInfo.ReasonOfComing, "reasonOfComing");
            secretariatPanel.SetStringToLable(patient.SeverityOfDisease.SeverityOfDeseaseTitle, "severityOfDisease");
        }

        #region Assistant functions
        //Get lest of the patients who waiting to secretary and show the lest on data grid.
        private void ShowPatientsWaitingToNurse()
        {
            patientsDataGridView.DataSource = nurseLogic.GetPatientsWaitingToNurse();
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
                    detailesNursePanel.Controls.Remove(label);
                    detailesNursePanel.Controls.Add(textBox);
                    break;
                case "comboBox":
                    comboBox = new ComboBox();
                    comboBox.Location = label.Location;
                    this.label = label;
                    comboBox.Items.Add("Yes");
                    comboBox.Items.Add("No");
                    detailesNursePanel.Controls.Remove(label);
                    detailesNursePanel.Controls.Add(comboBox);
                    break;
                case "bloodTestComboTextBox":
                    textBox = new TextBox();
                    comboBox = new ComboBox();
                    this.label = label;
                    textBox.Multiline = true;
                    textBox.Location = label.Location;
                    textBox.Size = label.Size;
                    textBox.Text = label.Text;
                    comboBox.Location = new Point(label.Location.X, label.Location.Y - 30);
                    AddValuesToComboBox(comboBox, "bloodTest");
                    detailesNursePanel.Controls.Remove(label);
                    detailesNursePanel.Controls.Add(textBox);
                    detailesNursePanel.Controls.Add(comboBox);
                    comboBox.SelectedValueChanged += new EventHandler(AddToTextBox);                    
                    break;
                case "urineTestComboTextBox":
                    textBox = new TextBox();
                    comboBox = new ComboBox();
                    this.label = label;
                    textBox.Multiline = true;
                    textBox.Location = label.Location;
                    textBox.Size = label.Size;
                    textBox.Text = label.Text;
                    comboBox.Location = new Point(label.Location.X, label.Location.Y - 30);
                    AddValuesToComboBox(comboBox, "urineTest");
                    detailesNursePanel.Controls.Remove(label);
                    detailesNursePanel.Controls.Add(textBox);
                    detailesNursePanel.Controls.Add(comboBox);
                    comboBox.SelectedValueChanged += new EventHandler(AddToTextBox);
                    break;
            }
        }

        private void AddValuesToComboBox(ComboBox comboBox, string testTybe)
        {
            switch (testTybe)
            {
                case "bloodTest":
                    comboBox.Items.Add("WBC - white blood cells");
                    comboBox.Items.Add("RBC - red blood cells");
                    comboBox.Items.Add("HGB - hemoglobin");
                    comboBox.Items.Add("HTC - hematocit");
                    comboBox.Items.Add("MCHC, MCH - mean cellular hemoglobin concentration");
                    comboBox.Items.Add("MCV - mean cellular volume");
                    comboBox.Items.Add("RDW - red cell distribution width");
                    comboBox.Items.Add("PLT - platelets");
                    comboBox.Items.Add("MPV - mean platelet volume");
                    break;
                case "urineTest":
                    comboBox.Items.Add("UrineTest");
                    comboBox.Items.Add("Urine culture");
                    comboBox.Items.Add("Protein Urine 24h");
                    comboBox.Items.Add("Microalbumin/Creatinine");
                    break;
            }
        }

        private void AddToTextBox(object? sender, EventArgs e)
        {
            textBox.Text += ((ComboBox)sender).Text + Environment.NewLine;
            BeginInvoke(new Action(() => comboBox.Text = string.Empty));
        }



        //Change the text box to label after editing the details
        private void Save(string sender)
        {
            switch (sender)
            {
                case "textBox":
                    label.Text = textBox.Text;
                    detailesNursePanel.Controls.Remove(textBox);
                    detailesNursePanel.Controls.Add(label);
                    break;
                case "comboBox":
                    label.Text = comboBox.Text;
                    detailesNursePanel.Controls.Remove(comboBox);
                    detailesNursePanel.Controls.Add(label);
                    break;
                case "comboTextBox":
                    label.Text = textBox.Text;
                    detailesNursePanel.Controls.Remove(comboBox);
                    detailesNursePanel.Controls.Remove(textBox);
                    detailesNursePanel.Controls.Add(label);
                    break;
            }
        }

        //Clear all labels
        private void Clear()
        {
            firstnameLabel.Text = string.Empty;
            lastnameLabel.Text = string.Empty;
            identityNumberLabel.Text = string.Empty;
            dateOfBirthLabel.Text = string.Empty;
            genderLabel.Text = string.Empty;
            secretariatPanel = new SecretariatPanel();
            bloodBressureLabel.Text = string.Empty;
            heatLabel.Text = string.Empty;
            heartbeatLabel.Text = string.Empty;
            oxginInBloodLabel.Text = string.Empty;
            heartbeatLabel.Text = string.Empty;
            heartbeatLabel.Text = string.Empty;
        }

        private void NurseDetailsVisible()
        {
            foreach (var item in this.detailesNursePanel.Controls)
            {
                (item as Control).Visible = true;
            }
        }

        private void NurseDetailsUnvisible()
        {
            foreach (var item in this.detailesNursePanel.Controls)
            {
                (item as Control).Visible = false;
            }
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
