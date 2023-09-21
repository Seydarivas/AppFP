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
    public partial class _02 : Form
    {
        public _02()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int metros = int.Parse(txtMetros.Text);

            int centimetros = metros * 100;
            double pulgadas = centimetros / 2.54;
            double pies = pulgadas / 12;
            double yardas = pies / 3;

            txtCentimetros.Text = centimetros.ToString("##.00");
            txtPulgadas.Text = pulgadas.ToString("##.00");
            txtPies.Text = pies.ToString("##.00");
            txtYardas.Text = yardas.ToString("##.00");

        }
    }
}
