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
        HospitalLogic hospitalLogic;

        public NurseLogic()
        {
            hospitalLogic = HospitalLogic.GetHospitalLogic();
        }

        public Patient GetPatient(string turnTitle)
        {
            return hospitalLogic.GetPatient(turnTitle);
        }

        public void RemovePatient(Patient patient)
        {
            hospitalLogic.RemovePatient(patient);
        }

        public IEnumerable GetPatientsWaitingToNurse()
        {
            return hospitalLogic.GetPatientsWaitingToNurse();
        }

        public void SendToDoctor(Patient patient)
        {
            hospitalLogic.SendToDoctor(patient);
        }

        public Patient GetTreatment(Patient patient)
        {
            return hospitalLogic.GetTreatment(patient);
        }

        public void SetPatientInTreatment(Patient patient)
        {
            hospitalLogic.SetPatientInTreatment(patient);
        }

        public void Save()
        {
            hospitalLogic.Save();
        }
    }
}
