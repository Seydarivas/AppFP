﻿using System;
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
    public partial class _07 : Form
    {
        public _07()
        {
            InitializeComponent();
            private void btnCalcular_Click(object sender, EventArgs e)
{
           double b = double.Parse(txtBase.Text);
           double h = double.Parse(txtAltura.Text);

                 double area = b * h;
                 double perimetro = 2 * (b + h);

           txtArea.Text = area.ToString("00.00") + "  u2";
           txtPerimetro.Text = perimetro.ToString("00.00") + "  u";

        }
    }
}
