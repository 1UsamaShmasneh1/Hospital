using Hospital.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Entities
{
    public class DBContextConnection : IDisposable
    {
        HospitalDBContext dBContext;

        public DBContextConnection()
        {
            dBContext = new HospitalDBContext();
        }

        #region Singelton defnetion
        private static DBContextConnection dBContextConnection;
        private static readonly object lockObject = new object();

        public static DBContextConnection GetDBContextConnection()
        {
            if (dBContextConnection == null)
            {
                lock (lockObject)
                {
                    dBContextConnection = new DBContextConnection();
                }
            }
            return dBContextConnection;
        }
        #endregion

        public Turn GetAvailebleTurn()
        {
            return dBContext.Turns.Where(t => t.Status == 1).First();
        }

        public Turn GetTurnByTurnTitle(string turnTitle)
        {
            return dBContext.Turns
                .Where(t => t.TurnTitle == turnTitle).First();
        }

        public bool IsUsernamePasswordMatch(string username, string password)
        {
            return dBContext.Employees.Include(e => e.Account)
                    .Where(a => a.Account.Username == username && a.Account.Password == password)
                    .ToList().Count() == 1;
        }

        public Employee GetEmployee(string username, string password)
        {
            return dBContext.Employees.Include(e => e.Account)
                    .Where(a => a.Account.Username == username && a.Account.Password == password).First();
        }

        public SeverityOfDisease GetSeverityOfDisease(Patient patient)
        {
            return dBContext.SeverityOfDiseases.Find(patient.SeverityOfDiseaseId);
        }

        public Person GetPersonByEmplyee(Employee employee)
        {
            return dBContext.People.Where(p => p.Id == employee.PersonId).First();
        }

        public Person GetPersonByPersonId(int personId)
        {
            return dBContext.People.Where(p => p.Id == personId).First();
        }

        public Account GetAccountByEmployee(Employee employee)
        {
            return dBContext.Accounts.Where(a => a.AccountId == employee.AccountId).First();
        }

        public void AddPatient(Patient patient)
        {
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
        }

        public List<Patient> GetPatients()
        {
            return dBContext.Patients.ToList();
        }

        public IEnumerable GetPatientsByStatusId(int statusId)
        {
            var patients = new List<object>();
            try
            {
                var relevantPatients = dBContext.Patients.Where(p => p.StatusId == statusId)
                    .Include(p => p.Turn)
                    .Select(p => new { Turns = p.Turn.TurnTitle }).ToList();
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

        public Patient GetPatientByTurnId(int turnId)
        {
            return dBContext.Patients.Where(p => p.TurnId == turnId).First();
        }

        public void RemovePatient(Patient patient)
        {
            dBContext.Patients.Remove(patient);
        }

        public void AddTreatment(Treatment treatment)
        {
            try
            {
                treatment.TreatmentId = dBContext.Treatments
                    .OrderByDescending(t => t.TreatmentId).ToList()[0].TreatmentId + 1;                
            }
            catch
            {
                treatment.TreatmentId = 0;
            }
            dBContext.Treatments.Add(treatment);
        }

        public Treatment GetTreatmentByTreatmentId(int treatmentId)
        {
            return dBContext.Treatments
                .Where(t => t.TreatmentId == treatmentId).First();
        }

        public void AddTreatmentInfo(TreatmentInfo treatmentInfo)
        {
            try
            {
                treatmentInfo.TreatmentInfoId = dBContext.TreatmentInfos
                    .OrderByDescending(t => t.TreatmentInfoId).ToList()[0].TreatmentInfoId + 1;
            }
            catch
            {
                treatmentInfo.TreatmentInfoId = 0;
            }
            dBContext.TreatmentInfos.Add(treatmentInfo);
        }

        public TreatmentInfo GetTreatmentInfoByTreatmentInfoId(int treatmentInfoId)
        {
            return dBContext.TreatmentInfos
                .Where(t => t.TreatmentInfoId == treatmentInfoId).First();
        }

        public Medication GetMedicationByMedicationTitle(string medicationTitle)
        {
            return dBContext.Medications
                .Where(m => m.MedicationTitle == medicationTitle).First();
        }

        public IEnumerable GetMedicationsBySearch(string search)
        {
            var medications = new List<object>();
            if (search == string.Empty)
            {
                var relevantMedications = dBContext.Medications
                    .Select(m => new { Medication = m.MedicationTitle }).ToList();
                foreach (var medication in relevantMedications)
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

        public void AddTreatmentMedication(TreatmentMedication treatmentMedication)
        {
            try
            {
                treatmentMedication.TreatmentMedicationId = dBContext.TreatmentMedications
                    .OrderByDescending(t => t.TreatmentMedicationId).ToList()[0].TreatmentMedicationId + 1;
            }
            catch
            {
                treatmentMedication.TreatmentMedicationId = 0;
            }
            dBContext.TreatmentMedications.Add(treatmentMedication);
        }

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
