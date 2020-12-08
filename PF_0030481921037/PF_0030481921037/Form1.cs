using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace PF_0030481921037
{
    public partial class frmPrincipal : Form
    {



        public static SqlConnection conexao;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            { // aqui a conexão vai depende da sua máquina da escola ou particular           
                conexao = new SqlConnection("Data Source = DESKTOP-KU9A3J2; Initial Catalog = LP2_; Integrated Security = True");          
                conexao.Open();       
            } catch (SqlException ex)   
            { MessageBox.Show("Erro de banco de dados =/" + ex.Message);     
            } catch (Exception ex)       
                { MessageBox.Show("Outros Erros =/" + ex.Message);       
            } 
            }

        private void cadastroCidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmCidade"];

            if (fc != null)
                fc.Close();

            frmCidade frmC = new frmCidade();
            frmC.MdiParent = this;
            frmC.WindowState = FormWindowState.Maximized;
            frmC.Show();
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
