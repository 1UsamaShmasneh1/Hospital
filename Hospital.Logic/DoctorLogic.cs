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
        HospitalLogic hospitalLogic;

        public DoctorLogic()
        {
            hospitalLogic = HospitalLogic.GetHospitalLogic();
        }

        public Patient GetPatient(string turnTitle)
        {
            return hospitalLogic.GetPatient(turnTitle);
        }

        public Patient GetTreatment(Patient patient)
        {
            return hospitalLogic.GetTreatment(patient);
        }

        public void RemovePatient(Patient patient)
        {
            hospitalLogic.RemovePatient(patient);
        }

        public IEnumerable GetPatientsWaitingToDoctor()
        {
            return hospitalLogic.GetPatientsWaitingToDoctor();
        }

        public Medication GetMedication(string medication)
        {
            return hospitalLogic.GetMedication(medication);
        }

        public IEnumerable GetMedications(string search)
        {
            return hospitalLogic.GetMedications(search);
        }

        public void Save(Patient patient)
        {
            hospitalLogic.Save(patient);
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
