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
    public class SecretaryLogic : ISecretaryLogic, IGeneralLogic
    {
        DBContextConnection dBContext;
        Patient patient;

        public SecretaryLogic()
        {
            dBContext = DBContextConnection.GetDBContextConnection();
        }

        public IEnumerable GetPatientsWaitingToSecretary()
        {
            return dBContext.GetPatientsByStatusId(1);
        }

        public Patient GetPatient(string turnTitle)
        {
            Turn turn = dBContext.GetTurnByTurnTitle(turnTitle);
            patient = dBContext.GetPatientByTurnId(turn.TurnId);
            patient.Person = dBContext.GetPersonByPersonId((int)patient.PersonId);
            patient.Turn = turn;
            return patient;
        }

        public void RemovePatient(Patient patient)
        {
            patient.StatusId = 4;
            patient.Turn.Status = 1;
            dBContext.Save();
        }

        public void SendToNurse(Patient patient)
        {
            //var relevantPatient = dBContext.GetPatientByTurnId(patient.Turn.TurnId);
            //relevantPatient.SeverityOfDiseaseId = patient.SeverityOfDiseaseId;
            //relevantPatient.TreatmentId = patient.TreatmentId;
            //relevantPatient.StatusId = 2;
            patient.StatusId = 2;
            dBContext.AddTreatment(patient.Treatment);
            dBContext.AddTreatmentInfo(patient.Treatment.TreatmentInfo);
            patient.TreatmentId = patient.Treatment.TreatmentId;
            patient.Treatment.TreatmentInfoId = patient.Treatment.TreatmentInfo.TreatmentInfoId;
            dBContext.Save();
        }

        public void SetPatientInTreatment(Patient patient, int status)
        {
            patient.StatusId = status;
            dBContext.Save();
        }
    }
}
