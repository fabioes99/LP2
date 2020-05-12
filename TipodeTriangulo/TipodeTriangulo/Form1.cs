using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipodeTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double xa, xb ,xc  ;

            if ((double.TryParse(txtA.Text, out xa) &&
                (double.TryParse(txtB.Text, out xb) &&
                (double.TryParse(txtC.Text, out xc) &&
                (xa!=0) && (xb!=0) && (xc!=0) 
                ))))
            {
                double calculo1 = Math.Abs(xb - xc) ;
                double calculo2 = Math.Abs(xa - xc);
                double calculo3 = Math.Abs(xb - xa);


                if (((calculo1 < xa) && ((xb + xc) > xa)) &&
                    ((calculo2 < xb) && ((xa + xc) > xb)) &&
                    ((calculo3 < xc) && ((xa + xb) > xc))
                    )
                {
                    if ((xa == xb) && (xa == xc) && (xb==xc))
                        MessageBox.Show("Triangulo equilatero");
                    if((xa!=xb) && (xc!=xa) && (xc!=xb))
                        MessageBox.Show("Triangulo escaleno");
                    if ((xa == xb) || (xa == xc) || (xb==xc))
                        MessageBox.Show("Triangulo isoceles");
                }
                else
                    MessageBox.Show("Numeros fornecidos nao podem formar um triangulo");
            }
            else
                MessageBox.Show("Dados invalidos");
            
              
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
