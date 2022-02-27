using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Entities.Models;
using Microsoft.Data.SqlClient;

namespace Hospital.Logic
{
    // Class that manage patients in the hospital, get the methods by proxy interface
    public class PatientLogic: IPatientLogic
    {
        private HospitalLogic hospitalLogic;

        public PatientLogic()
        {
            // Reference to the main opject that have be made by singlton on the HospitalLogic.
            this.hospitalLogic = HospitalLogic.GetHospitalLogic();
        }

        public void CreateNewPatient(Person person)
        {
            hospitalLogic.CreateNewPatient(person);
        }

        public List<Patient> GetPatients()
        {
            return hospitalLogic.GetPatients();
        }
    }
}
