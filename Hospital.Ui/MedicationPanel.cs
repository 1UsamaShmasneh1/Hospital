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
    public partial class MedicationPanel : UserControl
    {
        public event Action<object, EventArgs> Clicked;
        public MedicationPanel()
        {
            InitializeComponent();
        }

        private void OnClicked(object sender, EventArgs e)
        {
            if(Clicked != null)
                Clicked(sender, e);
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(((TextBox)sender).Text);
            }
            catch
            {
                ((TextBox)sender).Text = string.Empty;
            }
        }
    }
}
