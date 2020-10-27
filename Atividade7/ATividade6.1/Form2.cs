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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           double H = 0.0;
            int frase = Convert.ToInt32(txtBox.Text);
            
            for (var i = 1.0; i <= frase ; i++)
            {
                H = (1 / i)+H;
            }
            MessageBox.Show(H.ToString("N2"));
        }
    }
}
