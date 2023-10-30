

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Group_Assignment
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer_splash_Tick(object sender, EventArgs e)
        {
            timer_splash.Start();
            Login log = new Login();
            log.Show();
            this.Close();
        }
    }

}
