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
     */
    public class HospitalLogic: IPatientLogic, IAccountLogic, ISecretaryLogic, IGeneralLogic, INurseLogic, IDoctorLogic
    {
        private HospitalLogic()
        {
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
            try
            {
                patient.DepartmentId = 1;
                patient.PersonId = person.Id;
                patient.StatusId = 1;
                using (var hosdb = new HospitalDBContext())
                {
                    turn = hosdb.Turns.Where(t => t.Status == 1).First();
                    patient.TurnId = turn.TurnId;
                    turn.Status = 0;
                    hosdb.Patients.Add(patient);
                    hosdb.SaveChanges();
                }
            }
            catch (InvalidOperationException)
            {

            }
        }

        public List<Patient> GetPatients()
        {
            List<Patient> patients = new List<Patient>();
            try
            {
                using(var hospitalDB = new HospitalDBContext())
                {
                    patients = hospitalDB.Patients.ToList();
                }
            }
            catch (InvalidOperationException)
            {

            }
            return patients;
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
            using (var hosDB = new HospitalDBContext())
            {
                try
                {
                    if (hosDB.Employees.Include(e => e.Account)
                        .Where(a => a.Account.Username == username && a.Account.Password == password)
                        .ToList().Count() == 1)
                    {
                        employee = hosDB.Employees.Include(e => e.Account)
                        .Where(a => a.Account.Username == username && a.Account.Password == password).First();
                        employee.Person = hosDB.People.Where(p => p.Id == employee.PersonId).First();
                        employee.Account.Status = 1;
                        hosDB.SaveChanges();
                        isLoggedIn = true;
                    }
                }
                catch (InvalidOperationException)
                {
                }
            }
            if(!isLoggedIn)
                OnErrorLogin();
            return employee;
        }

        public void Logout(Employee employee)
        {
            using(var hosDB = new HospitalDBContext())
            {
                Account account = hosDB.Accounts.Where(a => a.AccountId == employee.AccountId).First();
                account.Status = 0;
                hosDB.SaveChanges();
                OnLogedout();
            }
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
                using (var hospitalDB = new HospitalDBContext())
                {
                    var relevantPatients = hospitalDB.Patients.Where(p => p.StatusId == 1)
                        .Include(p => p.Turn)
                        .Select(p => new {Turns = p.Turn.TurnTitle }).ToList();
                    foreach (var p in relevantPatients)
                    {
                        patients.Add(p);
                    }
                }
            }
            catch (InvalidOperationException)
            {

            }
            return patients;
        }              
        
        public void SendToNurse(Patient patient)
        {
            using(var hosDB = new HospitalDBContext())
            {
                patient.Treatment.TreatmentId = hosDB.Treatments.Count() + 1;
                patient.TreatmentId = patient.Treatment.TreatmentId;
                patient.Treatment.TreatmentInfo.TreatmentInfoId = hosDB.TreatmentInfos.Count() + 1;
                patient.Treatment.TreatmentInfoId = patient.Treatment.TreatmentInfo.TreatmentInfoId;
                
                var relevantPatient = hosDB.Patients.Where(p => p.PatientId == patient.PatientId).First();
                relevantPatient.SeverityOfDiseaseId = patient.SeverityOfDiseaseId;
                relevantPatient.TreatmentId = patient.TreatmentId;
                relevantPatient.StatusId = 2;
                hosDB.Treatments.Add(patient.Treatment);
                hosDB.TreatmentInfos.Add(patient.Treatment.TreatmentInfo);
                hosDB.SaveChanges();
            }
        }
        #endregion

        #region Nurse logic
        public IEnumerable GetPatientsWaitingToNurse()
        {
            var patients = new List<object>();
            try
            {
                using (var hospitalDB = new HospitalDBContext())
                {
                    var relevantPatients = hospitalDB.Patients.Where(p => p.StatusId == 2)
                        .Include(p => p.Turn)
                        .OrderByDescending(p => p.SeverityOfDiseaseId)
                        .Select(p => new { Turn = p.Turn.TurnTitle })
                        .ToList();
                    foreach(var p in relevantPatients)
                    {
                        patients.Add(p);
                    }
                }
            }
            catch (InvalidOperationException)
            {

            }
            return patients;
        }
                
        public void SendToDoctor(Patient patient)
        {
            using(var hosDB = new HospitalDBContext())
            {
                var treatmentInfo = hosDB.TreatmentInfos
                    .Where(t => t.TreatmentInfoId == patient.Treatment.TreatmentInfoId).First();
                treatmentInfo.BloodPressure = patient.Treatment.TreatmentInfo.BloodPressure;
                treatmentInfo.Heat = patient.Treatment.TreatmentInfo.Heat;
                treatmentInfo.Heartbeat = patient.Treatment.TreatmentInfo.Heartbeat;
                treatmentInfo.OxginInBlood = patient.Treatment.TreatmentInfo.OxginInBlood;
                treatmentInfo.Sensitive = patient.Treatment.TreatmentInfo.Sensitive;
                treatmentInfo.BloodTest = patient.Treatment.TreatmentInfo.BloodTest;
                treatmentInfo.UrineTest = patient.Treatment.TreatmentInfo.UrineTest;
                treatmentInfo.IsSmoking = patient.Treatment.TreatmentInfo.IsSmoking;
                var relevantPatient = hosDB.Patients.Where(p => p.PatientId == patient.PatientId).First();
                relevantPatient.StatusId = 3;
                hosDB.SaveChanges();
            }
        }
        #endregion

        #region Doctor logic
        public IEnumerable GetPatientsWaitingToDoctor()
        {
            var patients = new List<object>();
            try
            {
                using (var hospitalDB = new HospitalDBContext())
                {
                    var relevantPatients = hospitalDB.Patients.Where(p => p.StatusId == 3)
                        .Include(p => p.Turn)
                        .OrderByDescending(p => p.SeverityOfDiseaseId)
                        .Select(p => new { Turn = p.Turn.TurnTitle })
                        .ToList();
                    foreach (var p in relevantPatients)
                    {
                        patients.Add(p);
                    }
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
            using (var hospitalDB = new HospitalDBContext())
            {
                medication = hospitalDB.Medications
                    .Where(m => m.MedicationTitle == medicationTitle).First();
            }
            return medication;
        }

        //Function that return lest of the medications from the database by search string.
        public IEnumerable GetMedications(string search)
        {
            var medications = new List<object>();
            if (search == string.Empty)
            {
                using (var hospitalDB = new HospitalDBContext())
                {
                    var relevantMedications = hospitalDB.Medications
                        .Select(m => new {Medication = m.MedicationTitle}).ToList();
                    foreach(var medication in relevantMedications)
                    {
                        medications.Add(medication);
                    }
                }
            }
            else
            {
                using (var hospitalDB = new HospitalDBContext())
                {
                    var relevantMedications = hospitalDB.Medications
                        .Where(m => m.MedicationTitle.Contains(search))
                        .Select(m => new { Medication = m.MedicationTitle }).ToList();
                    foreach (var medication in relevantMedications)
                    {
                        medications.Add(medication);
                    }
                }
            }
            return medications;
        }

        //Function that save`s the patient details after ending treatment with the doctor.
        public void Save(Patient patient)
        {
            using(var hosDB = new HospitalDBContext())
            {
                Patient relevantPatient = hosDB.Patients
                    .Where(p => p.PatientId == patient.PatientId).First();
                relevantPatient.StatusId = 4;
                TreatmentMedication treatmentMedication = new TreatmentMedication();
                var treatmentInfo = hosDB.TreatmentInfos
                    .First(t => t.TreatmentInfoId == patient.Treatment.TreatmentInfoId);
                treatmentInfo.DiseaseDiagnosis = patient.Treatment.TreatmentInfo.DiseaseDiagnosis;
                treatmentInfo.MedicalAdvice = patient.Treatment.TreatmentInfo.MedicalAdvice;
                foreach(var tm in patient.Treatment.TreatmentMedications)
                {
                    treatmentMedication = tm;
                    treatmentMedication.Treatment = null;
                    treatmentMedication.Medication = null;
                    treatmentMedication.MedicationId = tm.MedicationId;
                    hosDB.TreatmentMedications.Add(treatmentMedication);
                }
                (hosDB.Turns.Where(t => t.TurnId == patient.TurnId).First()).Status = 1;
                hosDB.SaveChanges();

            }
        }
        #endregion

        #region General logic
        public Patient GetPatient(string turnTitle)
        {
            int turnId;
            Patient patient;
            using (var hosDB = new HospitalDBContext())
            {
                turnId = hosDB.Turns.Where(t => t.TurnTitle == turnTitle)
                    .Select(t => t.TurnId).First();
                patient = hosDB.Patients.Where(p => p.TurnId == turnId).First();
                patient.Person = hosDB.People.Where(p => p.Id == patient.PersonId).First();
                patient.Turn = hosDB.Turns.Where(t => t.TurnId == turnId).First();
            }
            return patient;
        }

        public void RemovePatient(Patient patient)
        {
            using (var hosDB = new HospitalDBContext())
            {
                var relevantPatient = hosDB.Patients.Where(p => p.PatientId == patient.PatientId).First();
                if(patient.Treatment == null)
                {
                    hosDB.Patients.Remove(relevantPatient);
                }
                else
                {
                    relevantPatient.StatusId = 4;
                }
                (hosDB.Turns.Where(t => t.TurnId == patient.TurnId).First()).Status = 1;
                hosDB.SaveChanges();
            }
        }

        public Patient GetTreatment(Patient patient)
        {
            using (var hospitalDB = new HospitalDBContext())
            {
                patient.Treatment = hospitalDB.Treatments
                    .Where(t => t.TreatmentId == patient.TreatmentId).First();
                patient.Treatment.TreatmentInfo = hospitalDB.TreatmentInfos
                    .Where(tI => tI.TreatmentInfoId == patient.Treatment.TreatmentInfoId).First();
                patient.SeverityOfDisease = hospitalDB.SeverityOfDiseases
                    .Where(s => s.SeverityOfDiseaseId == patient.SeverityOfDiseaseId).First();
            }
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
            using(var hosDB = new HospitalDBContext())
            {
                Patient relevantPatient = hosDB.Patients
                    .Where(t => t.PatientId == patient.PatientId).First();
                if(relevantPatient.StatusId == 5)
                    relevantPatient.StatusId = patient.StatusId;
                else
                    relevantPatient.StatusId = 5;
                hosDB.SaveChanges();
            }
        }
        #endregion

    }
}
