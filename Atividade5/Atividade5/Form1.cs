using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salBruto, NumFilhos;
            if (double.TryParse(MtxtBruto.Text, out salBruto) &&
                double.TryParse(MtxtNumF.Text, out NumFilhos))
            {
                if (salBruto < 1903.98)
                {
                    MtxtAliRpf.Text = "isento";
                    MtxtDescIRPF.Text = "";
                }
                if (salBruto>1903.99 && salBruto<2826.65)
                {
                    MtxtAliRpf.Text = "7,5%";
                    double descontoIRPF = 0.075 * salBruto;
                    string sla = Convert.ToString(descontoIRPF);
                    MtxtDescIRPF.Text = sla;
                }
                if (salBruto>2826.66 && salBruto<3751.05)
                {
                    MtxtAliRpf.Text = "15%";
                    double descontoIRPF = 0.15 * salBruto + 142.80;
                    string x = Convert.ToString(descontoIRPF);
                    MtxtDescIRPF.Text = x;
                }
                if (salBruto>3751.06 && salBruto<4664.68)
                {
                    MtxtAliRpf.Text = "22,5%";
                    double descontoIRPF = 0.225 * salBruto + 142.80+354.80;
                    string w = Convert.ToString(descontoIRPF);
                    MtxtDescIRPF.Text = w;
                }
                if (salBruto>4664.69 )
                {
                    MtxtAliRpf.Text = "27,5%";
                    double descontoIRPF = 869.36 + 142.80+354.80+636.13;
                    string z = Convert.ToString(descontoIRPF);
                    MtxtDescIRPF.Text = z;
                }
                if (salBruto < 1045)
                {
                    MtxtAinss.Text = "7.5%";
                    double descontoINSS = 0.0765 * salBruto;
                    string a = Convert.ToString(descontoINSS);
                    MtxtDescINSS.Text = a;
                }
                if (salBruto>1045.01 && salBruto<2089.60)
                { 
                    MtxtAinss.Text = "%9";
                    double descontoINSS = 0.09 * salBruto;
                    string s = Convert.ToString(descontoINSS);
                    MtxtDescINSS.Text = s;
                }
                if (salBruto>2089.61 && salBruto<3134.41)
                {
                    MtxtAinss.Text = "12%";
                    double descontoINSS = 0.12 * salBruto;
                    string d = Convert.ToString(descontoINSS);
                    MtxtDescINSS.Text = d;
                }
                if (salBruto>3134.41 && salBruto<6101.06)
                {
                    MtxtAinss.Text ="14%";
                    double descontoINSS = 0.14 * salBruto;
                    string f = Convert.ToString(descontoINSS);
                    MtxtDescINSS.Text = f;
                }
                if (salBruto>6101.07)
                {
                    MtxtAinss.Text = "Teto";
                    double descontoINSS = 1220.21;
                    string g = Convert.ToString(descontoINSS);
                    MtxtDescINSS.Text = g;
                }
                if (salBruto < 1045.56)
                {
                    double res = 48.62 * NumFilhos;
                    string h = Convert.ToString(res);
                    MtxtSalFam.Text = h;

                }
                double A1, A2, A3;
                double.TryParse(MtxtDescINSS.Text, out A1);
                double.TryParse(MtxtDescIRPF.Text, out A2);
                double.TryParse(MtxtSalFam.Text, out A3);


                double Saliquido = salBruto - A1 - A2 + A3;
                string y = Convert.ToString(Saliquido);
                MtxtSaliqui.Text = y;
            }
            else
                MessageBox.Show("Dados invalidos");
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
