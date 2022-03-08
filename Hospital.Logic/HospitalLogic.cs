using Hospital.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Logic
{
    /*
    1- The HospitalLogic class using to be the main class that manage all the methods.
    2- Using singelton Desine Patteren to refernce all opjects of HospitalLogic to one opject.
    3- Using proxy Desine Patteren to divide the methods to interfaces, on the basis that
    every employee take his part of methods.
    4- Using Repository Patteren to open one connection to database.
     */
    public class HospitalLogic : IDisposable, IPatientLogic, IAccountLogic, ISecretaryLogic, IGeneralLogic, INurseLogic, IDoctorLogic
    {
        HospitalDBContext dBContext;
        private HospitalLogic()
        {
            dBContext = new HospitalDBContext();
        }

        #region Singelton defnetion
        private static HospitalLogic hospitalLogic;
        private static readonly object lockObject = new object();

        public static HospitalLogic GetHospitalLogic()
        {
            if (hospitalLogic == null)
            {
                lock (lockObject)
                {
                    hospitalLogic = new HospitalLogic();
                }
            }
            return hospitalLogic;
        }
        #endregion

        #region Patient Logic
        public void CreateNewPatient(Person person)
        {
            Patient patient = new Patient();
            Turn turn = new Turn();
            patient.DepartmentId = 1;
            patient.PersonId = person.Id;
            patient.StatusId = 1;
            turn = dBContext.Turns.Where(t => t.Status == 1).First();
            patient.TurnId = turn.TurnId;
            turn.Status = 0;
            try
            {
                patient.PatientId = dBContext
                    .Patients.OrderByDescending(p => p.PatientId).ToList()[0].PatientId + 1;
                dBContext.Patients.Add(patient);
            }
            catch
            {
                dBContext.Patients.Add(patient);
            }
            Save();
        }

        public List<Patient> GetPatients()
        {             
            return dBContext.Patients.ToList();
        }
        #endregion

        #region Account Logic
        public event Action ErrorLogin;
        public event Action Logedout;

        /*
         * Function that return employee opject after trying to login,
         * if the login failed error login event will active.
         */
        public Employee Login(string username, string password)
        {
            Employee employee = new Employee();
            bool isLoggedIn = false;
            try
            {
                if (dBContext.Employees.Include(e => e.Account)
                    .Where(a => a.Account.Username == username && a.Account.Password == password)
                    .ToList().Count() == 1)
                {
                    employee = dBContext.Employees.Include(e => e.Account)
                    .Where(a => a.Account.Username == username && a.Account.Password == password).First();
                    employee.Person = dBContext.People.Where(p => p.Id == employee.PersonId).First();
                    employee.Account.Status = 1;
                    isLoggedIn = true;
                }
            }
            catch (InvalidOperationException)
            {
            }
            Save();
            if(!isLoggedIn)
                OnErrorLogin();
            return employee;
        }

        public void Logout(Employee employee)
        {
            Account account = dBContext.Accounts.Where(a => a.AccountId == employee.AccountId).First();
            account.Status = 0;
            Save();
            OnLogedout();
        }

        #region On events for accounts
        public void OnErrorLogin()
        {
            if (ErrorLogin != null)
                ErrorLogin();
        }

        public void OnLogedout()
        {
            if (Logedout != null)
                Logedout();
        }
        #endregion
        #endregion

        #region Secretary logic
        public IEnumerable GetPatientsWaitingToSecretary()
        {
            var patients = new List<object>();
            try
            {
                var relevantPatients = dBContext.Patients.Where(p => p.StatusId == 1)
                    .Include(p => p.Turn)
                    .Select(p => new {Turns = p.Turn.TurnTitle }).ToList();
                foreach (var p in relevantPatients)
                {
                    patients.Add(p);
                }
            }
            catch (InvalidOperationException)
            {

            }
            return patients;
        }              
        
        public void SendToNurse(Patient patient)
        {
            try
            {
                patient.Treatment.TreatmentId = dBContext.Treatments
                    .OrderByDescending(t => t.TreatmentId).ToList()[0].TreatmentId + 1;
                patient.TreatmentId = patient.Treatment.TreatmentId;
            }
            catch
            {
                patient.Treatment.TreatmentId = 0;
            }

            try
            {
                patient.Treatment.TreatmentInfo.TreatmentInfoId = dBContext.TreatmentInfos
                    .OrderByDescending(t => t.TreatmentInfoId).ToList()[0].TreatmentInfoId + 1;
            }
            catch
            {
                patient.Treatment.TreatmentInfo.TreatmentInfoId = 0;
            }
            patient.Treatment.TreatmentInfoId = patient.Treatment.TreatmentInfo.TreatmentInfoId;                
            var relevantPatient = dBContext.Patients.Find(patient.PatientId);
            relevantPatient.SeverityOfDiseaseId = patient.SeverityOfDiseaseId;
            relevantPatient.TreatmentId = patient.TreatmentId;
            relevantPatient.StatusId = 2;
            dBContext.Treatments.Add(patient.Treatment);
            dBContext.TreatmentInfos.Add(patient.Treatment.TreatmentInfo);
            Save();
        }
        #endregion

        #region Nurse logic
        public IEnumerable GetPatientsWaitingToNurse()
        {
            var patients = new List<object>();
            try
            {
                var relevantPatients = dBContext.Patients.Where(p => p.StatusId == 2)
                    .Include(p => p.Turn)
                    .OrderByDescending(p => p.SeverityOfDiseaseId)
                    .Select(p => new { Turn = p.Turn.TurnTitle })
                    .ToList();
                foreach(var p in relevantPatients)
                {
                    patients.Add(p);
                }
            }
            catch (InvalidOperationException)
            {

            }
            return patients;
        }
                
        public void SendToDoctor(Patient patient)
        {
            var treatmentInfo = dBContext.TreatmentInfos
                .Where(t => t.TreatmentInfoId == patient.Treatment.TreatmentInfoId).First();
            treatmentInfo.BloodPressure = patient.Treatment.TreatmentInfo.BloodPressure;
            treatmentInfo.Heat = patient.Treatment.TreatmentInfo.Heat;
            treatmentInfo.Heartbeat = patient.Treatment.TreatmentInfo.Heartbeat;
            treatmentInfo.OxginInBlood = patient.Treatment.TreatmentInfo.OxginInBlood;
            treatmentInfo.Sensitive = patient.Treatment.TreatmentInfo.Sensitive;
            treatmentInfo.BloodTest = patient.Treatment.TreatmentInfo.BloodTest;
            treatmentInfo.UrineTest = patient.Treatment.TreatmentInfo.UrineTest;
            treatmentInfo.IsSmoking = patient.Treatment.TreatmentInfo.IsSmoking;
            var relevantPatient = dBContext.Patients.Find(patient.PatientId);
            relevantPatient.StatusId = 3;
            Save();
        }
        #endregion

        #region Doctor logic
        public IEnumerable GetPatientsWaitingToDoctor()
        {
            var patients = new List<object>();
            try
            {
                var relevantPatients = dBContext.Patients.Where(p => p.StatusId == 3)
                    .Include(p => p.Turn)
                    .OrderByDescending(p => p.SeverityOfDiseaseId)
                    .Select(p => new { Turn = p.Turn.TurnTitle })
                    .ToList();
                foreach (var p in relevantPatients)
                {
                    patients.Add(p);
                }
            }
            catch (InvalidOperationException)
            {

            }
            return patients;
        }

        //Function that return Medication opject by medication name.
        public Medication GetMedication(string medicationTitle)
        {
            Medication medication = new Medication();
            medication = dBContext.Medications
                .Where(m => m.MedicationTitle == medicationTitle).First();
            return medication;
        }

        //Function that return lest of the medications from the database by search string.
        public IEnumerable GetMedications(string search)
        {
            var medications = new List<object>();
            if (search == string.Empty)
            {
                var relevantMedications = dBContext.Medications
                    .Select(m => new {Medication = m.MedicationTitle}).ToList();
                foreach(var medication in relevantMedications)
                {
                    medications.Add(medication);
                }
            }
            else
            {
                var relevantMedications = dBContext.Medications
                    .Where(m => m.MedicationTitle.Contains(search))
                    .Select(m => new { Medication = m.MedicationTitle }).ToList();
                foreach (var medication in relevantMedications)
                {
                    medications.Add(medication);
                }
            }
            return medications;
        }

        //Function that save`s the patient details after ending treatment with the doctor.
        public void Save(Patient patient)
        {
            Patient relevantPatient = dBContext.Patients
                .Where(p => p.PatientId == patient.PatientId).First();
            relevantPatient.StatusId = 4;
            TreatmentMedication treatmentMedication = new TreatmentMedication();
            var treatmentInfo = dBContext.TreatmentInfos
                .First(t => t.TreatmentInfoId == patient.Treatment.TreatmentInfoId);
            treatmentInfo.DiseaseDiagnosis = patient.Treatment.TreatmentInfo.DiseaseDiagnosis;
            treatmentInfo.MedicalAdvice = patient.Treatment.TreatmentInfo.MedicalAdvice;
            for(int i = 0; i < patient.Treatment.TreatmentMedications.Count(); i++)
            {
                treatmentMedication = patient.Treatment.TreatmentMedications.ToList()[i];
                treatmentMedication.Treatment = null;
                treatmentMedication.Medication = null;
                treatmentMedication.MedicationId = patient.Treatment.TreatmentMedications.ToList()[i].MedicationId;
                try
                {
                    treatmentMedication.TreatmentMedicationId = dBContext.TreatmentMedications
                        .OrderByDescending(t => t.TreatmentMedicationId).ToList()[0].TreatmentMedicationId + 1 + i;
                }
                catch
                {
                    treatmentMedication.TreatmentMedicationId = 0;
                }
                dBContext.TreatmentMedications.Add(treatmentMedication);
                
            }            
            dBContext.Turns.Find(patient.TurnId).Status = 1;
            Save();
        }
        #endregion

        #region General logic
        public Patient GetPatient(string turnTitle)
        {
            int turnId;
            Patient patient;
            turnId = dBContext.Turns.Where(t => t.TurnTitle == turnTitle)
                .Select(t => t.TurnId).First();
            patient = dBContext.Patients.Where(p => p.TurnId == turnId).First();
            patient.Person = dBContext.People.Where(p => p.Id == patient.PersonId).First();
            patient.Turn = dBContext.Turns.Where(t => t.TurnId == turnId).First();
            return patient;
        }

        public void RemovePatient(Patient patient)
        {
            var relevantPatient = dBContext.Patients.Where(p => p.PatientId == patient.PatientId).First();
            if(patient.Treatment == null)
            {
                dBContext.Patients.Remove(relevantPatient);
            }
            else
            {
                relevantPatient.StatusId = 4;
            }
            (dBContext.Turns.Where(t => t.TurnId == patient.TurnId).First()).Status = 1;
            Save();
        }

        public Patient GetTreatment(Patient patient)
        {
            patient.Treatment = dBContext.Treatments
                .Where(t => t.TreatmentId == patient.TreatmentId).First();
            patient.Treatment.TreatmentInfo = dBContext.TreatmentInfos
                .Where(tI => tI.TreatmentInfoId == patient.Treatment.TreatmentInfoId).First();
            patient.SeverityOfDisease = dBContext.SeverityOfDiseases
                .Where(s => s.SeverityOfDiseaseId == patient.SeverityOfDiseaseId).First();
            return patient;
        }

        /*
         * Fuction that check`s the status of the patient, if the 
         * status is 5(in treatment) so change it to change the status
         * to the last status by geting it from the patient property,
         * if the status is not 5(not in treatment) so change it to 
         * status 5(to in treatment).
         */
        public void SetPatientInTreatment(Patient patient)
        {
            Patient relevantPatient = dBContext.Patients
                .Where(t => t.PatientId == patient.PatientId).First();
            if(relevantPatient.StatusId == 5)
                relevantPatient.StatusId = patient.StatusId;
            else
                relevantPatient.StatusId = 5;
            Save();
        }
        #endregion

        public void Save()
        {
            dBContext.SaveChanges();
        }
        public void Dispose()
        {
            dBContext.Dispose();
        }

    }
}
