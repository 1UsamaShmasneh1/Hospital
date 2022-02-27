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
        HospitalLogic hospitalLogic;

        public SecretaryLogic()
        {
            hospitalLogic = HospitalLogic.GetHospitalLogic();
        }

        public IEnumerable GetPatientsWaitingToSecretary()
        {
            return hospitalLogic.GetPatientsWaitingToSecretary();
        }

        public Patient GetPatient(string turnTitle)
        {
            return hospitalLogic.GetPatient(turnTitle);
        }

        public void RemovePatient(Patient patient)
        {
            hospitalLogic.RemovePatient(patient);
        }

        public void SendToNurse(Patient patient)
        {
            hospitalLogic.SendToNurse(patient);
        }

        public Patient GetTreatment(Patient patient)
        {
            throw new NotImplementedException();
        }

        public void SetPatientInTreatment(Patient patient)
        {
            hospitalLogic.SetPatientInTreatment(patient);
        }
    }
}
