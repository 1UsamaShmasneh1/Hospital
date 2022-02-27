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
        private HospitalLogic hospitalLogic;
        
        public AccountLogic()
        {
            // Reference to the main opject that have be made by singlton on the HospitalLogic.
            this.hospitalLogic = HospitalLogic.GetHospitalLogic();

            #region Event handlers
            hospitalLogic.ErrorLogin += () => OnErrorLogin();
            #endregion
        }

        #region Events
        public event Action ErrorLogin;
        public event Action Logedout;
        #endregion


        public Employee Login(string username, string password)
        {
            return hospitalLogic.Login(username, password);
        }

        public void Logout(Employee employee)
        {
            hospitalLogic.Logedout += () => OnLogedout();
            hospitalLogic.Logout(employee);
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
