using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital.Entities.Models;
using Hospital.Logic;
using Hospital.Validations;

namespace Hospital.Ui
{
    public partial class EmployeeLoginUserControl : UserControl
    {
        AccountLogic accountLogic;
        Employee employee;

        #region Events
        public event Action Cancel;
        public event Action<Employee> SuccessLogin;
        public event Action MissingFields;
        public event Action FailLogin;
        #endregion

        public EmployeeLoginUserControl()
        {
            InitializeComponent();
            accountLogic = new AccountLogic();
            employee = new Employee();

            accountLogic.ErrorLogin += () =>
            {
                OnFailLogin();
            };
        }

        // Function that handel clicked buttons
        private void CommonClick(object sender, EventArgs e)
        {
            switch (((Button)sender).Tag)
            {
                case "Button Cancel":
                    OnCancel();
                    break;
                case "Button Login":
                    if(textBoxUsername.Text == "" || textBoxPassword.Text == "")
                        OnMissingFields();
                    else
                    {                        
                        /*
                          Using login method to check validity of the username and password and return
                          the emplyee opject.
                        */
                        employee = accountLogic.Login(textBoxUsername.Text, textBoxPassword.Text);
                        if (employee.Account != null)
                            OnSuccessLogin();
                    }
                    break;
            }
        }

        #region On events
        public void OnSuccessLogin()
        {            
            if (SuccessLogin != null)
                SuccessLogin(employee);
        }

        public void OnFailLogin()
        {
            if (FailLogin != null)
                FailLogin();
        }

        public void OnCancel()
        {
            if (Cancel != null)
                Cancel();
        }

        public void OnMissingFields()
        {
            if (MissingFields != null)
                MissingFields();
        }
        #endregion
    }
}
