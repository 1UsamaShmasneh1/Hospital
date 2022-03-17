using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Entities;
using Hospital.Entities.Models;
using Microsoft.Data.SqlClient;

namespace Hospital.Logic
{
    // Class that manage patients in the hospital, get the methods by proxy interface
    public class PatientLogic: IPatientLogic
    {
        DBContextConnection dBContext;

        public PatientLogic()
        {
            dBContext = DBContextConnection.GetDBContextConnection();
        }

        public void CreateNewPatient(Person person)
        {
            Patient patient = new Patient();
            Turn turn = new Turn();
            patient.DepartmentId = 1;
            patient.PersonId = person.Id;
            patient.StatusId = 1;
            turn = dBContext.GetAvailebleTurn();
            patient.TurnId = turn.TurnId;
            turn.Status = 0;   
            dBContext.AddPatient(patient);
            dBContext.Save();
        }

        public List<Patient> GetPatients()
        {
            return dBContext.GetPatients();
        }
    }
}
