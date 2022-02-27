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

namespace Hospital.Ui
{
    public partial class MainMenuUserControl : UserControl
    {

        #region Events
        public event Action EmployeeLogin;
        public event Action AdminLogin;
        public event Action QueueManagement;
        #endregion

        public MainMenuUserControl()
        {
            InitializeComponent();
        }

        private void MainMenuUserControl_Load(object sender, EventArgs e)
        {
        }

        // Function that handel clicked buttons
        private void CommonClick(object sender, EventArgs e)
        {
            switch (((Button)sender).Tag)
            {
                case "Button Employee Login":
                    EmployeeLogin();
                    break;
                case "Button Queue Management":
                    QueueManagement();
                    break;
            }
        }
    }
}
