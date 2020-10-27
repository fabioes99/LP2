using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATividade6._1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            
            double A = Convert.ToDouble(txtSal.Text);
            double producao = Convert.ToDouble(txtProd.Text);
            double gratificasao = Convert.ToDouble(txtGrat.Text);
 
            double salarioBruto = A + A * (0.05 * producao >= 100 ? 1 :0) + (0.1 * producao >=120 ? 1: 0)+ (0.1 * producao >=150 ? 1:0) + gratificasao;
            MessageBox.Show("Seu salario bruto e de " + salarioBruto.ToString("C2"));
        }
    }
}
