using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace winform_app_csharp_splash_screen
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void TimeRunning_Tick(object sender, EventArgs e)
        {
            PanelLoadRunning.Width += 2;
            if (PanelLoadRunning.Width >= 700)
            {
                this.Close();
            }
        }
    }
}
