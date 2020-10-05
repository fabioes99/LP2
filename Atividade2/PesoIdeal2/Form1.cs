using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           
            double altura, peso;
            if (double.TryParse(mtxtAltura.Text, out altura) && double.TryParse(mtxtPeso.Text, out peso))
            {
                if (rbtnFem.Checked)
                {
                    double calculo = ( 62.1* altura) - 44.7;
                    if (peso > Math.Round(calculo))
                        MessageBox.Show("Acima do valor ideal companheira");
                    if (peso < Math.Round(calculo))
                        MessageBox.Show("De frente parece que ta de lado, de lado parece que foi embora.");
                    if (peso == Math.Round(calculo))
                        MessageBox.Show("Na medida,continue assim.");
                }
                else
                {
                    
                    double calculo = (72.7 * altura) - 58;
                    if (peso > Math.Round(calculo))
                        MessageBox.Show("Acima do peso ideal meu consagrado");
                    if (peso < Math.Round(calculo))
                        MessageBox.Show("De frente parece que ta de lado, de lado parece que foi embora.");
                    if (peso == Math.Round(calculo))
                        MessageBox.Show("Na medida,continue assim.");
                }
            }
            else
                MessageBox.Show("dados invalidos");
        }

        private void mtxtPeso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
               
        }
    }
}
