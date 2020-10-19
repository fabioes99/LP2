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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNumero1.Text);
            int num2 = Convert.ToInt32(txtNumero2.Text);
            Random random = new Random();
            double r = random.Next(num1, num2);
            MessageBox.Show(r.ToString());
            
        }
    }
}
