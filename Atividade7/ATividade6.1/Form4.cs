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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomes = txtBox.Text.Trim() ;
            string[] words = nomes.Split(' ');

            string final = Convert.ToString(words[0] + words[1] + words[2]);
 
            string x = final.Trim();
             
            string s = final.Trim();

            char[] arr = s.ToCharArray(); 
            Array.Reverse(arr);
            s = ""; 
            foreach (char c in arr)
            { s = s + c.ToString(); }
            if ( x == s )
            {
                MessageBox.Show("eh palindromo");
            }
            else
            {
                MessageBox.Show("nao e palindromo");
            }
        }
    }
}
