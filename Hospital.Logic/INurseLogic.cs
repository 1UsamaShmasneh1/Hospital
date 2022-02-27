using Hospital.Entities.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Logic
{
    public interface INurseLogic
    {
        IEnumerable GetPatientsWaitingToNurse();
                
        void SendToDoctor(Patient patient);
    }
}
