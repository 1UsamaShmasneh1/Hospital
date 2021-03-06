using Hospital.Entities.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Logic
{
    public interface IDoctorLogic
    {
        IEnumerable GetPatientsWaitingToDoctor();

        Medication GetMedication(string medication);

        IEnumerable GetMedications(string search);

        void Save(Patient patient);
    }
}
