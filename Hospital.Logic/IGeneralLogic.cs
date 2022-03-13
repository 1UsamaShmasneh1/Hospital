using Hospital.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Logic
{
    //Interface wich have methods that every employee can use it
    public interface IGeneralLogic
    {
        Patient GetPatient(string turnTitle);

        void RemovePatient(Patient patient);

        Patient GetTreatment(Patient patient);

        void SetPatientInTreatment(Patient patient);

        void Save();
    }
}
