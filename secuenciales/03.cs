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
    public partial class _03 : Form
    {
        public _03()
        {
            InitializeComponent();
        }

        private void lblTramo2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {


         double tramo1 = double.Parse(txtTramo1.Text);
         double tramo2 = double.Parse(txtTramo2.Text);
         double tramo3 = double.Parse(txtTramo3.Text);

            double mTramo1 = tramo1 * 1000;
            double mTramo2 = tramo2 * 0.3048;
            double mTramo3 = tramo3 * 1609;

            double totalMetros = mTramo1 + mTramo2 + mTramo3;

            double yTramo1 = mTramo1 * 1.09;
            double yTramo2 = mTramo2 * 1.09;
            double yTramo3 = mTramo3 * 1.09;

            double totalYardas = yTramo1 + yTramo2 + yTramo3;

            txtMetros.Text = totalMetros.ToString("##.00");
            txtYardas.Text = totalYardas.ToString("##.00");


        }
    }
}
