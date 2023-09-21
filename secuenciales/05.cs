using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFP.secuenciales
{
    public partial class _05 : Form
    {
        public _05()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double disco = double.Parse(txtGB.Text);

            double mby = disco * 1024;
            double kby = mby * 1024;
            double by = kby * 1024;

            txtMB.Text = mby.ToString("00.00");
            txtKB.Text = kby.ToString("00.00");
            txtBY.Text = by.ToString("00.00");
                
          }
    }
}
