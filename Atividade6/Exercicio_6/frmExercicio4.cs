using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_6
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnContaNum_Click(object sender, EventArgs e)
        { int contador = 0;
            for (var i=0 ; i < rchTxt.Text.Length ; i++)
            {
                if (char.IsNumber(rchTxt.Text[i]))
                    contador++;
            }
            MessageBox.Show("tem isso de numeros " + contador.ToString());
        }

        private void btnPosicao_Click(object sender, EventArgs e)
        {
            
            int x = 0 ;
            for (var i = 0; i < rchTxt.Text.Length; i++)
            {
                if (char.IsWhiteSpace(rchTxt.Text[i]))
                {
                    x=i;
                    break;
                }
            }
            MessageBox.Show("o 1 espaco em branco esta na  " + x+1.ToString() +"posicao");
        }

        private void btnConta_Click(object sender, EventArgs e)
        {
            int contador = 0;
            for (var i = 0; i < rchTxt.Text.Length; i++)
            {
                if (char.IsLetter(rchTxt.Text[i]))
                    contador++;
            }
            MessageBox.Show("tem isso de letras " + contador.ToString());
        }
    }
}
