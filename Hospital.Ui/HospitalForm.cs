using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital.Entities;
using Hospital.Entities.Models;

namespace Hospital.Ui
{
    public partial class HospitalForm : Form
    {
        #region Propreties
        Timer timer;
        MainMenuUserControl mainMenuUserControl;
        EmployeeLoginUserControl? emploeyeeLoginUserControl;
        QueueManagementUserControl queueManagementUserControl;
        SecretariatUserControl secretariatUserControl;
        NurseUserControl nurseUserControl;
        DoctorUserControl doctorUserControl;
        #endregion

        public HospitalForm()
        {
            InitializeComponent();
        }

        private void HospitalForm_Load(object sender, EventArgs e)
        {

            toolStripStatusLabelMessage.Text = "";

            #region Proprties initializations
            timer = new Timer();
            mainMenuUserControl = new MainMenuUserControl();
            queueManagementUserControl = new QueueManagementUserControl();
            #endregion

                 ShowUserControle<MainMenuUserControl>(mainMenuUserControl);

            #region Events handlers
            //Using timer to show message on tool strip lable and clear it after 5 seconds.
            timer.Interval = 5000;
            timer.Tick += (object o, EventArgs argss) =>
            {
                toolStripStatusLabelMessage.Text = "";
                timer.Stop();
            };

            //Manage EmployeeLoginUserControle events
            mainMenuUserControl.EmployeeLogin += () => EmployeeHandler();                             
            //Manage QueueMAnagamentUserControle events
            mainMenuUserControl.QueueManagement += () => QueueManagementHandler();              
                        
            #endregion

        }

        #region user controls management functions
        //Manage the queue user controle
        private void QueueManagementHandler()
        {
            ShowUserControle<QueueManagementUserControl>(queueManagementUserControl);
            queueManagementUserControl.Exit += () =>
            {
                Clear<QueueManagementUserControl>(queueManagementUserControl);
                ShowUserControle<MainMenuUserControl>(mainMenuUserControl);
            };
            queueManagementUserControl.Successes += str =>
            {
                toolStripStatusLabelMessage.Text = str;
                timer.Start();
            };
            queueManagementUserControl.Failed += str =>
            {
                toolStripStatusLabelMessage.Text = str;
                timer.Start();
            };
        }

        //Manage the employee login user control
        private void EmployeeHandler()
        {
            //Employee user controle proprty initialization
            emploeyeeLoginUserControl = new EmployeeLoginUserControl();

            //Show the employee user control on the main panel
            ShowUserControle<EmployeeLoginUserControl>(emploeyeeLoginUserControl);

            #region Events handlers
            //Cancel login event handler
            emploeyeeLoginUserControl.Cancel += () =>
            {
                emploeyeeLoginUserControl = null;
                ShowUserControle<MainMenuUserControl>(mainMenuUserControl);
            };

            //Handle this event when one of fields is missing
            emploeyeeLoginUserControl.MissingFields += () =>
            {
                toolStripStatusLabelMessage.Text = "Fill the username and the bassword fields";
                Clear<EmployeeLoginUserControl>(emploeyeeLoginUserControl);
                timer.Start();
            };

            //Handle this event when the login failed
            emploeyeeLoginUserControl.FailLogin += () =>
            {
                toolStripStatusLabelMessage.Text = "Username or password is wrong!";
                Clear<EmployeeLoginUserControl>(emploeyeeLoginUserControl);
                timer.Start();
            };

            //Manage the employee by it's job tybe
            emploeyeeLoginUserControl.SuccessLogin += (employee) =>
            {
                switch (employee.JobId)
                {
                    // Secretary
                    case 2:
                        Clear<EmployeeLoginUserControl>(emploeyeeLoginUserControl);
                        SecretariatHandler(employee);
                        break;
                    // Nurse
                    case 3:
                        Clear<EmployeeLoginUserControl>(emploeyeeLoginUserControl);
                        NurseHandler(employee);
                        break;
                    // Doctor
                    case 4:
                        Clear<EmployeeLoginUserControl>(emploeyeeLoginUserControl);
                        DoctorHandler(employee);
                        break;
                }
            };
            #endregion
        }

        //Manage secretariat user control
        private void SecretariatHandler(Employee employee)
        {
            secretariatUserControl = new SecretariatUserControl(employee);

            #region Event handlers
            secretariatUserControl.Logout += () =>
            {
                secretariatUserControl = null;
                ShowUserControle<MainMenuUserControl>(mainMenuUserControl);
            };
            #endregion

            ShowUserControle<SecretariatUserControl>(secretariatUserControl);
        }

        //Manage nurse user control
        private void NurseHandler(Employee employee)
        {
            nurseUserControl = new NurseUserControl(employee);

            #region Event handlers
            nurseUserControl.Logout += () =>
            {
                nurseUserControl = null;
                ShowUserControle<MainMenuUserControl>(mainMenuUserControl);
            };
            #endregion

            ShowUserControle<NurseUserControl>(nurseUserControl);
        }

        //Manage doctor user control
        private void DoctorHandler(Employee employee)
        {
            doctorUserControl = new DoctorUserControl(employee);

            #region Event handlers
            doctorUserControl.Logout += () =>
            {
                doctorUserControl = null;
                ShowUserControle<MainMenuUserControl>(mainMenuUserControl);
            };
            #endregion

            ShowUserControle<DoctorUserControl>(doctorUserControl);
        }
        #endregion 

        #region Assistant functions
        /*Generic function that getting any type heired
        from user control type and shows it in panel.
        */
        private void ShowUserControle<T>(T t) where T : UserControl
        {
            panelHospitalForm.Controls.Clear();
            t.Parent = panelHospitalForm;
            t.Show();
        }

        /*Generic function that getting any type heired
        from user control type and clear all the text boxes
        */
        private void Clear<T>(T t) where T : UserControl
        {
            foreach (Control control in t.Controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
        }
        #endregion
    }
}
