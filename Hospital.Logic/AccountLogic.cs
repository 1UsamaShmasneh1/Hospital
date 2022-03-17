using Hospital.Entities;
using Hospital.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Logic
{
    // Class that manage accounts in the hospital, get the methods by proxy interface
    public class AccountLogic : IAccountLogic
    {
        private DBContextConnection dBContext;
        Employee employee;
        
        public AccountLogic()
        {
            // Reference to the main opject that have be made by singlton on the HospitalLogic.
            dBContext = DBContextConnection.GetDBContextConnection();
        }

        #region Events
        public event Action ErrorLogin;
        public event Action Logedout;
        #endregion


        public Employee Login(string username, string password)
        {
            bool isLoggedIn = false;
            try
            {
                if (dBContext.IsUsernamePasswordMatch(username, password))
                {
                    employee = dBContext.GetEmployee(username, password);
                    employee.Person = dBContext.GetPersonByEmplyee(employee);
                    employee.Account = dBContext.GetAccountByEmployee(employee);
                    employee.Account.Status = 1;
                    isLoggedIn = true;
                    dBContext.Save();
                }
            }
            catch (InvalidOperationException)
            {
            }
            if (!isLoggedIn)
                OnErrorLogin();
            return employee;
        }

        public void Logout(Employee employee)
        {
            employee.Account.Status = 0;
            dBContext.Save();
            OnLogedout();
        }

        #region On events
        public void OnErrorLogin()
        {
            if (ErrorLogin != null)
                ErrorLogin();
        }

        public void OnLogedout()
        {
            if (Logedout != null)
                Logedout();
        }
        #endregion
    }
}
