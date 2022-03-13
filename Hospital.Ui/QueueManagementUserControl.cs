using System;
using System.Windows.Forms;
using Hospital.Logic;
using Hospital.Entities.Models;
using Hospital.Validations;

namespace Hospital.Ui
{
    public partial class QueueManagementUserControl : UserControl
    {
        IPatientLogic patientLogic;

        #region Events
        public event Action Exit;
        public event Action<string> Successes;
        public event Action<string> Failed;
        #endregion

        public QueueManagementUserControl()
        {
            InitializeComponent();
            patientLogic = new PatientLogic();
            textBoxIdentityNumber.Enabled = false;
        }

        

        // Function that handel clicked buttons
        private void CommonClick(object sender, EventArgs e)
        {
            switch (((Button)sender).Tag)
            {
                case "0":
                    textBoxIdentityNumber.Text += "0";
                    break;
                case "1":
                    textBoxIdentityNumber.Text += "1";
                    break;
                case "2":
                    textBoxIdentityNumber.Text += "2";
                    break;
                case "3":
                    textBoxIdentityNumber.Text += "3";
                    break;
                case "4":
                    textBoxIdentityNumber.Text += "4";
                    break;
                case "5":
                    textBoxIdentityNumber.Text += "5";
                    break;
                case "6":
                    textBoxIdentityNumber.Text += "6";
                    break;
                case "7":
                    textBoxIdentityNumber.Text += "7";
                    break;
                case "8":
                    textBoxIdentityNumber.Text += "8";
                    break;
                case "9":
                    textBoxIdentityNumber.Text += "9";
                    break;
                case "Ok":
                    Person person = new Person();
                    if (textBoxIdentityNumber.Text.IsExistingId(ref person))
                    {
                        patientLogic.CreateNewPatient(person);
                        OnSuccesses("Welcome");
                    }
                    else
                        OnFailed("Wrong Id");
                    textBoxIdentityNumber.Text = "";
                    break;
                case "Del":
                    textBoxIdentityNumber.Text = RemoveLastChar(textBoxIdentityNumber.Text);
                    break;
                case "X":
                    Exit();
                    break;
            }
        }

        #region Assistant functions
        // Function that removes the last char from text
        private string RemoveLastChar(string text)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;
            return text.Remove(text.Length - 1);
        }
        #endregion

        #region On events
        public void OnExit()
        {
            if (Exit != null)
                Exit();
        }

        public void OnSuccesses(string str)
        {
            if (Successes != null)
                Successes(str);
        }

        public void OnFailed(string str)
        {
            if (Failed != null)
                Failed(str);
        }
        #endregion
    }
}
