using Hospital.Entities;
using Hospital.Entities.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Logic
{
    public class DoctorLogic : IDoctorLogic, IGeneralLogic
    {
        DBContextConnection dBContext;

        public DoctorLogic()
        {
            dBContext = DBContextConnection.GetDBContextConnection();
        }

        public IEnumerable GetPatientsWaitingToDoctor()
        {
            return dBContext.GetPatientsByStatusId(3);
        }

        //Function that return Medication opject by medication name.
        public Medication GetMedication(string medicationTitle)
        {            
            return dBContext.GetMedicationByMedicationTitle(medicationTitle);
        }

        //Function that return lest of the medications from the database by search string.
        public IEnumerable GetMedications(string search)
        {
            return dBContext.GetMedicationsBySearch(search);
        }

        //Function that save`s the patient details after ending treatment with the doctor.
        public void Save(Patient patient)
        {
            patient.StatusId = 4;
            TreatmentMedication treatmentMedication = new TreatmentMedication();
            for (int i = 0; i < patient.Treatment.TreatmentMedications.Count(); i++)
            {
                treatmentMedication = patient.Treatment.TreatmentMedications.ToList()[i];
                treatmentMedication.Treatment = null;
                treatmentMedication.Medication = null;
                treatmentMedication.MedicationId = patient.Treatment.TreatmentMedications.ToList()[i].MedicationId;                
                dBContext.AddTreatmentMedication(treatmentMedication);
            }
            patient.Turn.Status = 1;
            dBContext.Save();
        }

        public Patient GetPatient(string turnTitle)
        {
            Patient patient = new Patient();
            Turn turn = new Turn();
            turn = dBContext.GetTurnByTurnTitle(turnTitle);
            patient = dBContext.GetPatientByTurnId(turn.TurnId);
            patient.Turn = turn;
            patient.Person = dBContext.GetPersonByPersonId((int)patient.PersonId);
            patient.Treatment = dBContext.GetTreatmentByTreatmentId((int)patient.TreatmentId);
            patient.Treatment.TreatmentInfo = dBContext.GetTreatmentInfoByTreatmentInfoId((int)patient.Treatment.TreatmentInfoId);
            patient.SeverityOfDisease = dBContext.GetSeverityOfDisease(patient);
            return patient;
        }

        public void RemovePatient(Patient patient)
        {
            dBContext.RemovePatient(patient);
            patient.Turn.Status = 1;
            dBContext.Save();
        }

        public void SetPatientInTreatment(Patient patient, int status)
        {
            patient.StatusId = status;
            dBContext.Save();
        }
    }
}
