using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {   
            
            double x1,x2;
            if ((double.TryParse(txtNum1.Text, out x1) && double.TryParse(txtNum2.Text, out x2)))
            {
                double subtrair = x1 - x2;
                txtResultado.Text = subtrair.ToString("N2");
            }
            else
                MessageBox.Show("dados invalidos");
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            double x1, x2;
            if ((double.TryParse(txtNum1.Text, out x1) && double.TryParse(txtNum2.Text, out x2)))
            {
                double soma = x1 + x2;
                txtResultado.Text = soma.ToString("N2");
            }
            else
                MessageBox.Show("dados invalios");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double x1, x2;
            if ((double.TryParse(txtNum1.Text, out x1) && double.TryParse(txtNum2.Text, out x2)))
            {
                double multipli = x1 * x2;
                txtResultado.Text = multipli.ToString("N2");
            }
            else
                MessageBox.Show("dados invalios");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            double x1, x2;
         
                if (double.TryParse(txtNum1.Text, out x1) && double.TryParse(txtNum2.Text, out x2) && x2 != 0 )
                   {
                    double Divisao = x1 / x2;
                    txtResultado.Text = Divisao.ToString("N2");
                   }
               
            else
                MessageBox.Show("dados invalios");
        }
    }
}
