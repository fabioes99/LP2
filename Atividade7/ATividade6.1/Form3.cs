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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            for (var i = 0; i < rchTxt.Text.Length; i++)
            {
                if (char.IsWhiteSpace(rchTxt.Text[i]))
                {
                    x += 1;

                }
            }
            MessageBox.Show("Tem  " + x.ToString() + "espaços em branco");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string stringona = rchTxt.Text.Trim();
            int comprimento = stringona.Length;
            int pares = 0;
            int contador = 0;
            

            while (contador < comprimento -1)
            {
                if ( char.ToUpper(stringona[contador]) == char.ToUpper(stringona[contador+1]))
                {
                    pares += 1;
                }
                contador += 1;
            


            }

            if (pares == 0)
            {
                MessageBox.Show("nao tem par de letras");
            }
            else
            {
                MessageBox.Show("Ocorre " + pares.ToString() + " pares de letra iguais");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string stringona = rchTxt.Text.Trim();
            int totalR = 0;
            foreach (char letra in stringona)
            {
                if (char.ToUpper(letra) == 'R')
                {
                    totalR += 1;
                }
            }
            MessageBox.Show("Tem  " + totalR.ToString() + " letras R");
        }
    }
}
