using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Entities.Models;

namespace Hospital.Logic
{
    public interface IPatientLogic
    {
        public List<Patient> GetPatients();
        public void CreateNewPatient(Person person);
    }
}
