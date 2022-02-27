using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.Ui
{
    public partial class SecretariatPanel : UserControl
    {
        public SecretariatPanel()
        {
            InitializeComponent();
        }
        public void SetStringToLable(string str, string type)
        {
            switch (type)
            {
                case "reasonOfComing":
                    reasonOfComingLabel.Text = str;
                    break;
                case "severityOfDisease":
                    severityOfDiseaseLabel.Text = str;
                    break;
            }
        }
    }
}
