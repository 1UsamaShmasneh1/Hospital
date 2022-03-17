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
    public class NurseLogic : IGeneralLogic, INurseLogic
    {
        DBContextConnection dBContext;

        public NurseLogic()
        {
            dBContext  = DBContextConnection.GetDBContextConnection();
        }

        public IEnumerable GetPatientsWaitingToNurse()
        {            
            return dBContext.GetPatientsByStatusId(2);
        }

        public void SendToDoctor(Patient patient)
        {
            //treatmentInfo.BloodPressure = patient.Treatment.TreatmentInfo.BloodPressure;
            //treatmentInfo.Heat = patient.Treatment.TreatmentInfo.Heat;
            //treatmentInfo.Heartbeat = patient.Treatment.TreatmentInfo.Heartbeat;
            //treatmentInfo.OxginInBlood = patient.Treatment.TreatmentInfo.OxginInBlood;
            //treatmentInfo.Sensitive = patient.Treatment.TreatmentInfo.Sensitive;
            //treatmentInfo.BloodTest = patient.Treatment.TreatmentInfo.BloodTest;
            //treatmentInfo.UrineTest = patient.Treatment.TreatmentInfo.UrineTest;
            //treatmentInfo.IsSmoking = patient.Treatment.TreatmentInfo.IsSmoking;
            //var relevantPatient = dBContext.Patients.Find(patient.PatientId);
            patient.StatusId = 3;
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
            patient.StatusId = 4;
            dBContext.Save();
        }
                
        public void SetPatientInTreatment(Patient patient, int status)
        {
            patient.StatusId = status;
            dBContext.Save();
        }
    }
}
