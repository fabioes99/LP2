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
    public partial class ahsla : Form
    {
        public ahsla()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPalavra1_Load(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        { int posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            while (posicao >= 0)
                {
                txtPalavra2.Text = txtPalavra2.Text.Substring(0, posicao) +
                        txtPalavra2.Text.Substring(posicao + txtPalavra1.Text.Length,
                        txtPalavra2.Text.Length - txtPalavra1.Text.Length - posicao);
                          posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);

            }
        }

        private void btnRemover2_Click(object sender, EventArgs e)
        {

            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void btnInverte_Click(object sender, EventArgs e)
        { 
            char[] auxiliar = txtPalavra1.Text.ToCharArray();
            Array.Reverse(auxiliar);

            foreach ( char c in auxiliar)
            {
                txtPalavra2.Text += c;
            }

        }
    }
}
