using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Entities.Models;

namespace Hospital.Logic
{
    public interface IAccountLogic
    {
        event Action ErrorLogin;
        event Action Logedout;

        Employee Login(string username, string password);

        void Logout(Employee employee);
    }
}
