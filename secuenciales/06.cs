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
    public partial class _06 : Form
    {
        public _06()
        {
            InitializeComponent();
        }

        private void _06_Load(object sender, EventArgs e)
        {
           double r = double.Parse(txtRadio.Text);
           double h = double.Parse(txtAltura.Text);

             double area = 2 * 3.14 * r * ( r + h );
             double volumen = 3.14 * Math.Pow(r, 2) * h;

    txtArea.Text = area.ToString("00.00") + "  u2";
    txtVolumen.Text = volumen.ToString("00.00") + "  u3";
        }
    }
}
