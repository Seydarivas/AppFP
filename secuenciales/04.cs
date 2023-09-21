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
    public partial class _04 : Form
    {
        public _04()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
         int pies = int.Parse(txtPies.Text);
         int pulgadas = int.Parse(txtPulgadas.Text);

            double mPies = pies * 0.3048;
            double mPulgadas = pulgadas * 0.0254;

            double total = mPies + mPulgadas;

            txtMetros.Text = total.ToString("##.00");
        }
    }
}
