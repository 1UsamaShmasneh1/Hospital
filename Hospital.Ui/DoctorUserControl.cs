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
    public partial class DoctorUserControl : UserControl
    {
        #region Propreties
        Employee employee;
        DoctorLogic doctorLogic;
        IAccountLogic accountLogic;
        SecretariatPanel secretariatPanel;
        NursePanel nursePanel;
        MedicationPanel medicationPanel;
        Patient patient;
        TextBox textBox;
        Label label;
        #endregion

        #region Events
        public event Action Logout;
        #endregion

        public DoctorUserControl(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            doctorLogic = new DoctorLogic();
            accountLogic = new AccountLogic();
            secretariatPanel = new SecretariatPanel();
            nursePanel = new NursePanel();
            medicationPanel = new MedicationPanel();

            employeeNameLabel.Text = employee.Person.FirstName + " " + employee.Person.LastName;

            ShowPatientsWaitingToDoctor();

            accountLogic.Logedout += () => OnLogout();
            medicationPanel.Clicked += (sender, e) => CommonClick(sender, e);

            doctorTapButton.Enabled = false;
            diseaseDiagnosisEditButton.Enabled = false;
            diseaseDiagnosisSaveButton.Enabled = false;
            medicalAdviceEditButton.Enabled = false;
            medicalAdviceSaveButton.Enabled = false;
            searchTextBox.Enabled = false;
            removeButton.Enabled = false;
            backButton.Enabled = false;
            medicationButton.Enabled = false;
            nurseTapButton.Enabled = false;
            secretaryTapButton.Enabled = false;
        }

        private void CommonClick(object sender, EventArgs e)
        {
            switch (((Button)sender).Tag)
            {
                case "secretary tap":
                    secretaryTapButton.Enabled = false;
                    nurseTapButton.Enabled = true;
                    doctorTapButton.Enabled = true;
                    doctorPanel.Controls.Add(secretariatPanel);
                    try
                    {
                        doctorPanel.Controls.Remove(doctorDetailsPanel);
                    }
                    catch { }
                    try
                    {
                        doctorPanel.Controls.Remove(nursePanel);
                    }
                    catch { }
                    try
                    {
                        doctorPanel.Controls.Remove(medicationPanel);
                    }
                    catch { }
                    break;
                case "nurse tap":
                    secretaryTapButton.Enabled = true;
                    nurseTapButton.Enabled = false;
                    doctorTapButton.Enabled = true;
                    try
                    {
                        doctorPanel.Controls.Remove(doctorDetailsPanel);
                    }
                    catch { }
                    doctorPanel.Controls.Add(nursePanel);
                    try
                    {
                        doctorPanel.Controls.Remove(secretariatPanel);
                    }
                    catch { }
                    try
                    {
                        doctorPanel.Controls.Remove(medicationPanel);
                    }
                    catch { }
                    break;
                case "doctor tap":
                    secretaryTapButton.Enabled = true;
                    nurseTapButton.Enabled = true;
                    doctorTapButton.Enabled = false;
                    searchTextBox.Enabled = false;
                    doctorPanel.Controls.Add(doctorDetailsPanel);
                    try
                    {
                        doctorPanel.Controls.Remove(secretariatPanel);
                    }
                    catch { }
                    try
                    {
                        doctorPanel.Controls.Remove(nursePanel);
                    }
                    catch { }
                    try
                    {
                        doctorPanel.Controls.Remove(medicationPanel);
                    }                    
                    catch { }
                    ShowPatientsWaitingToDoctor();
                    patientsDataGridView.Enabled = false;
                    break;
                case "remove":
                    diseaseDiagnosisEditButton.Enabled = false;
                    medicalAdviceEditButton.Enabled = false;
                    removeButton.Enabled = false;
                    backButton.Enabled = false;
                    medicationButton.Enabled = false;
                    secretaryTapButton.Enabled = false;
                    nurseTapButton.Enabled = false;
                    refreshButton.Enabled = true;
                    doctorLogic.RemovePatient(patient);
                    Clear();
                    break;
                case "refresh":
                    ShowPatientsWaitingToDoctor();
                    break;
                case "backButton":
                    refreshButton.Enabled = true;
                    diseaseDiagnosisEditButton.Enabled = false;
                    medicalAdviceEditButton.Enabled = false;
                    patientsDataGridView.Enabled = true;
                    secretaryTapButton.Enabled = false;
                    nurseTapButton.Enabled = false;
                    medicationButton.Enabled = false;
                    removeButton.Enabled = false;
                    refreshButton.Enabled = true;
                    backButton.Enabled = false;

                    patient.StatusId = 3;
                    doctorLogic.SetPatientInTreatment(patient, 3);
                    Clear();
                    ShowPatientsWaitingToDoctor();
                    break;
                case "logout":
                    accountLogic.Logout(employee);
                    break;
                case "backMedicationButton":
                    medicationPanel.addMedicationButton.Enabled = false;
                    medicationPanel.removeMedicationButton.Enabled = false;
                    medicationPanel.backMedicationButton.Enabled = false;
                    searchTextBox.Enabled = true;
                    medicationPanel.berDayTextBox.Enabled = false;
                    medicationPanel.berBiteTextBox.Enabled = false;
                    medicationPanel.daysTextBox.Enabled = false;
                    searchTextBox.Enabled = true;
                    patientsDataGridView.Enabled = true;
                    medicationPanel.saveButton.Enabled = true;
                    medicationPanel.medicationTitleLabel.Text = string.Empty;
                    medicationPanel.berBiteTextBox.Text = string.Empty;
                    medicationPanel.berDayTextBox.Text = string.Empty;
                    medicationPanel.daysTextBox.Text = string.Empty;
                    break;
                case "medication tap":
                    secretaryTapButton.Enabled = true;
                    nurseTapButton.Enabled = true;
                    doctorTapButton.Enabled = true;
                    medicationPanel.addMedicationButton.Enabled = false;
                    medicationPanel.removeMedicationButton.Enabled = false;
                    medicationPanel.backMedicationButton.Enabled = false;
                    searchTextBox.Enabled = true;
                    medicationPanel.berDayTextBox.Enabled = false;
                    medicationPanel.berBiteTextBox.Enabled = false;
                    medicationPanel.daysTextBox.Enabled = false;

                    try
                    {
                        doctorPanel.Controls.Remove(doctorDetailsPanel);
                    }
                    catch { }

                    patient.Treatment.TreatmentInfo.DiseaseDiagnosis = diseaseDiagnosisLabel.Text;
                    patient.Treatment.TreatmentInfo.MedicalAdvice = medicalAdviceLabel.Text;

                    doctorPanel.Controls.Add(medicationPanel);
                    try
                    {
                        doctorPanel.Controls.Remove(secretariatPanel);
                    }
                    catch { }

                    try
                    {
                        doctorPanel.Controls.Remove(nursePanel);
                    }
                    catch { }

                    patientsDataGridView.DataSource = doctorLogic.GetMedications(string.Empty);
                    patientsDataGridView.Enabled = true;

                    try
                    {
                        medicationPanel.medicationDataGridView.DataSource = patient.Treatment.TreatmentMedications;
                    }
                    catch { }
                    break;
                case "addMedicationButton":
                    AddMedicatioanToTreatment(medicationPanel.medicationTitleLabel.Text);
                    medicationPanel.medicationTitleLabel.Text = string.Empty;
                    medicationPanel.berBiteTextBox.Text = string.Empty;
                    medicationPanel.berDayTextBox.Text = string.Empty;
                    medicationPanel.daysTextBox.Text = string.Empty;
                    medicationPanel.berBiteTextBox.Enabled = false;
                    medicationPanel.berDayTextBox.Enabled = false;
                    medicationPanel.daysTextBox.Enabled = false;
                    medicationPanel.removeMedicationButton.Enabled = false;
                    medicationPanel.addMedicationButton.Enabled = false;
                    medicationPanel.backMedicationButton.Enabled = false;
                    patientsDataGridView.Enabled = true; ;
                    searchTextBox.Enabled = true;
                    medicationPanel.saveButton.Enabled = true;
                    medicationPanel.medicationDataGridView.DataSource = patient.Treatment.TreatmentMedications
                        .Select(t => new {
                            Medication = t.Medication.MedicationTitle,
                            Ber_Day = t.BerBite,
                            Ber_Bite = t.BerDay,
                            Days = t.Days
                        }).ToList();
                    break;
                case "removeMedicationButton":
                    string medicationTitle = medicationPanel.medicationDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                    Medication medication = doctorLogic.GetMedication(medicationTitle);
                    var relevantMedicationTreatment = patient.Treatment.TreatmentMedications
                        .Where(t => t.MedicationId == medication.MedicationId).First();
                    patient.Treatment.TreatmentMedications.Remove(relevantMedicationTreatment);
                    medicationPanel.medicationDataGridView.DataSource = patient.Treatment.TreatmentMedications
                            .Select(t => new { Medication = medicationTitle, Ber_Day = t.BerDay, Ber_Bite = t.BerBite, Days = t.Days });
                    break;
                case "saveButton":
                    doctorPanel.Controls.Remove(medicationPanel);
                    secretariatPanel = new SecretariatPanel();
                    nursePanel = new NursePanel();
                    medicationPanel = new MedicationPanel();

                    doctorTapButton.Enabled = false;
                    diseaseDiagnosisEditButton.Enabled = false;
                    diseaseDiagnosisSaveButton.Enabled = false;
                    medicalAdviceEditButton.Enabled = false;
                    medicalAdviceSaveButton.Enabled = false;
                    searchTextBox.Enabled = false;
                    removeButton.Enabled = false;
                    backButton.Enabled = false;
                    medicationButton.Enabled = false;
                    nurseTapButton.Enabled = false;
                    secretaryTapButton.Enabled = false;
                    patientsDataGridView.Enabled = true;
                    refreshButton.Enabled = true;

                    doctorLogic.Save(patient);
                    doctorPanel.Controls.Add(doctorDetailsPanel);
                    ShowPatientsWaitingToDoctor();
                    Clear();
                    break;
            }
        }
               
        private void EditSaveClick(object sender, EventArgs e)
        {
            switch (((Button)sender).Tag)
            {
                case "diseaseDiagnosisEditButton":
                    secretaryTapButton.Enabled = false;
                    nurseTapButton.Enabled = false;
                    backButton.Enabled = false;
                    removeButton.Enabled = false;
                    medicationButton.Enabled = false;
                    medicalAdviceEditButton.Enabled = false;
                    diseaseDiagnosisEditButton.Enabled = false;
                    diseaseDiagnosisSaveButton.Enabled = true;
                    Edit(diseaseDiagnosisLabel, "textBox");
                    break;
                case "diseaseDiagnosisSaveButton":
                    secretaryTapButton.Enabled = true;
                    nurseTapButton.Enabled = true;
                    backButton.Enabled = true;
                    removeButton.Enabled = true;
                    medicationButton.Enabled = true;
                    medicalAdviceEditButton.Enabled = true;
                    diseaseDiagnosisEditButton.Enabled = true;
                    diseaseDiagnosisSaveButton.Enabled = false;
                    Save("textBox");
                    break;
                case "medicalAdviceEditButton":
                    secretaryTapButton.Enabled = false;
                    nurseTapButton.Enabled = false;
                    backButton.Enabled = false;
                    removeButton.Enabled = false;
                    medicationButton.Enabled = false;
                    diseaseDiagnosisEditButton.Enabled = false;
                    medicalAdviceEditButton.Enabled = false;
                    medicalAdviceSaveButton.Enabled = true;
                    Edit(medicalAdviceLabel, "textBox");
                    break;
                case "medicalAdviceSaveButton":
                    secretaryTapButton.Enabled = true;
                    nurseTapButton.Enabled = true;
                    backButton.Enabled = true;
                    removeButton.Enabled = true;
                    medicationButton.Enabled = true;
                    diseaseDiagnosisEditButton.Enabled = true;
                    medicalAdviceEditButton.Enabled = true;
                    medicalAdviceSaveButton.Enabled = false;
                    Save("textBox");
                    break;
            }
        }

        private void patientsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!doctorTapButton.Enabled)
            {
                diseaseDiagnosisEditButton.Enabled = true;
                medicalAdviceEditButton.Enabled = true;
                patientsDataGridView.Enabled = false;
                diseaseDiagnosisSaveButton.Enabled = false;
                medicalAdviceSaveButton.Enabled = false;
                backButton.Enabled = true;
                removeButton.Enabled = true;
                medicationButton.Enabled = true;
                secretaryTapButton.Enabled = true;
                nurseTapButton.Enabled = true;
                refreshButton.Enabled = false;

                patient = doctorLogic.GetPatient(patientsDataGridView.CurrentCell.Value.ToString());
                doctorLogic.SetPatientInTreatment(patient, 5);
                firstnameLabel.Text = patient.Person.FirstName;
                lastnameLabel.Text = patient.Person.LastName;
                identityNumberLabel.Text = patient.Person.IdentityNumber;
                dateOfBirthLabel.Text = patient.Person.DateOfBirth.ToString();
                genderLabel.Text = patient.Person.Gender;
                secretariatPanel.reasonOfComingLabel.Text = patient.Treatment.TreatmentInfo.ReasonOfComing;
                secretariatPanel.severityOfDiseaseLabel.Text = patient.SeverityOfDisease.SeverityOfDeseaseTitle;
                nursePanel.bloodBressureLabel.Text = patient.Treatment.TreatmentInfo.BloodPressure;
                nursePanel.heatLabel.Text = patient.Treatment.TreatmentInfo.Heat;
                nursePanel.heartbeatLabel.Text = patient.Treatment.TreatmentInfo.Heartbeat;
                nursePanel.oxginInBloodLabel.Text = patient.Treatment.TreatmentInfo.OxginInBlood;
                nursePanel.sensitivesLabel.Text = patient.Treatment.TreatmentInfo.Sensitive;
                nursePanel.bloodTestLabel.Text = patient.Treatment.TreatmentInfo.BloodTest;
                nursePanel.urineTestLabel.Text = patient.Treatment.TreatmentInfo.UrineTest;
                switch (patient.Treatment.TreatmentInfo.IsSmoking)
                {
                    case 0:
                        nursePanel.isSmokingLabel.Text = "No";
                        break;
                    case 1:
                        nursePanel.isSmokingLabel.Text = "Yes";
                        break;
                }
            }

            if (doctorTapButton.Enabled)
            {
                patientsDataGridView.Enabled = false;
                medicationPanel.backMedicationButton.Enabled = true;
                medicationPanel.removeMedicationButton.Enabled = false;
                medicationPanel.addMedicationButton.Enabled = true;
                medicationPanel.berBiteTextBox.Enabled = true;
                medicationPanel.berDayTextBox.Enabled = true;
                medicationPanel.daysTextBox.Enabled = true;

                medicationPanel.medicationTitleLabel.Text = doctorLogic
                    .GetMedication(patientsDataGridView.CurrentCell.Value.ToString())
                    .MedicationTitle;
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            patientsDataGridView.DataSource = doctorLogic.GetMedications(searchTextBox.Text);
        }

        #region Assistant functions
        //Get lest of the patients who waiting to doctor and show the lest on data grid.
        private void ShowPatientsWaitingToDoctor()
        {
            patientsDataGridView.DataSource = doctorLogic.GetPatientsWaitingToDoctor();
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
                    doctorDetailsPanel.Controls.Remove(label);
                    doctorDetailsPanel.Controls.Add(textBox);
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
                    doctorDetailsPanel.Controls.Remove(textBox);
                    doctorDetailsPanel.Controls.Add(label);
                    break;
            }
        }

        private void AddMedicatioanToTreatment(string med)
        {
            Medication medication = doctorLogic.GetMedication(med);
            TreatmentMedication treatmentMedication = new TreatmentMedication();
            treatmentMedication.TreatmentId = (int)patient.TreatmentId;
            if (medicationPanel.berBiteTextBox.Text == string.Empty)
                medicationPanel.berBiteTextBox.Text = "0";
            if (medicationPanel.berDayTextBox.Text == string.Empty)
                medicationPanel.berDayTextBox.Text = "0";
            if (medicationPanel.daysTextBox.Text == string.Empty)
                medicationPanel.daysTextBox.Text = "0";
            treatmentMedication.BerDay = Convert.ToInt32(medicationPanel.berBiteTextBox.Text);
            treatmentMedication.BerBite = Convert.ToInt32(medicationPanel.berBiteTextBox.Text);
            treatmentMedication.Days = Convert.ToInt32(medicationPanel.daysTextBox.Text);
            treatmentMedication.Medication = medication;
            treatmentMedication.Treatment = patient.Treatment;
            patient.Treatment.TreatmentMedications.Add(treatmentMedication);            
        }

        //Clear all labels
        private void Clear()
        {
            firstnameLabel.Text = string.Empty;
            lastnameLabel.Text = string.Empty;
            identityNumberLabel.Text = string.Empty;
            dateOfBirthLabel.Text = string.Empty;
            genderLabel.Text = string.Empty;
            diseaseDiagnosisLabel.Text = string.Empty;
            medicalAdviceLabel.Text = string.Empty;

            medicationPanel = new MedicationPanel();
            nursePanel = new NursePanel();
            secretariatPanel = new SecretariatPanel();
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
