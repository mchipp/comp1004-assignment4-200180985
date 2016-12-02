using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp1004_assignment4_200180985
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            // disable the timer
            this.SplashScreenTimer.Enabled = false;

            // instantiate new StartForm
            StartForm startForm = new StartForm();

            // hide this form
            this.Hide();

            // show the new StartForm
            startForm.Show();
        }
    }
}
