using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cilindro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btbLimpar_Click(object sender, EventArgs e)
        {
            txtVolume.Clear();
            txtRaio.Clear();
            txtAltura.Clear();


        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double x1, x2;
            if ((double.TryParse(txtAltura.Text, out x1) &&
                (double.TryParse(txtRaio.Text, out x2))))
            {
                double calculo = 3.1415 * (x2 * x2) * x1;
                txtVolume.Text = calculo.ToString("N2");
            }
            else
                MessageBox.Show("Dados invalidos");
        }
    }
}
