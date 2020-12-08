﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;


namespace PF_0030481921037
{
    public partial class frmCidade : Form
    {
        private BindingSource bnCidade = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsCidade = new DataSet();

       /* meus componentes (grid, textbox,combobox...)
            binding source
            dataset
            datatable --> sqldataadapter (listar)
                |
                |
            sqlconnection
            */
        public frmCidade()
        {
            InitializeComponent();
        }

        private void frmCidade_Load(object sender, EventArgs e)
        {
            try
            {
                Cidade Cid = new Cidade();
                dsCidade.Tables.Add(Cid.Listar()); 
                bnCidade.DataSource = dsCidade.Tables["TBCidade"];
                dgvCidade.DataSource = bnCidade; 

                
                bnvCidade.BindingSource = bnCidade;
                txtID.DataBindings.Add("TEXT", bnCidade, "id_cidade");
                txtCidade.DataBindings.Add("TEXT", bnCidade, "nome_cidade"); 
                cbxUF.DataBindings.Add("SelectedItem", bnCidade, "uf_cidade"); 
                
                // AJUSTAR DROPDOWNSTYLE PARA DropDownList PARA NAO DEIXAR INCLUIR     
            }
                catch (Exception ex)     
            { MessageBox.Show(ex.Message);         
            } 
            }

        private void cbxUF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (tbCidade.SelectedIndex == 0)
            { 
                tbCidade.SelectTab(1); 
            }

            bnCidade.AddNew();
            txtCidade.Enabled = true; 
            cbxUF.Enabled = true; 
            cbxUF.SelectedIndex = 0;
            txtCidade.Focus();

            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            bnNovo.Enabled = false;
            btnExcluir.Enabled = false; 
            btnCancelar.Enabled = true; 
            bInclusao = true;
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // validar os dados
            if (txtCidade.Text == "")    
            { MessageBox.Show("Cidade inválida!");   
            } else        
            { Cidade RegCid = new Cidade();       
                RegCid.Idcidade = Convert.ToInt16(txtID.Text);     
                RegCid.Nomecidade = txtCidade.Text;  
                RegCid.Ufcidade = cbxUF.SelectedItem.ToString(); 
                if (bInclusao)         
                { if (RegCid.Salvar() > 0)      
                    { MessageBox.Show("Cidade adicionada com sucesso!");    
                        btnSalvar.Enabled = false;       
                        txtID.Enabled = false;        
                        txtCidade.Enabled = false;      
                        cbxUF.Enabled = false;        
                        btnSalvar.Enabled = false;       
                        btnAlterar.Enabled = true;        
                        bnNovo.Enabled = true;        
                        btnExcluir.Enabled = true;        
                        btnCancelar.Enabled = false;            
                        bInclusao = false; // recarrega o grid        
                        dsCidade.Tables.Clear();               
                        dsCidade.Tables.Add(RegCid.Listar());    
                        bnCidade.DataSource = dsCidade.Tables["TBCidade"];          
                    } else               
                    { MessageBox.Show("Erro ao gravar cidade!");                     }     
                } else           
                { if (RegCid.Alterar() > 0)             
                    { MessageBox.Show("Cidade alterada com sucesso!");       
                        dsCidade.Tables.Clear();        
                        dsCidade.Tables.Add(RegCid.Listar());            
                        txtID.Enabled = false;                   
                        txtCidade.Enabled = false;              
                        cbxUF.Enabled = false;                 
                        btnSalvar.Enabled = false;                    
                        btnAlterar.Enabled = true; 
                        bnNovo.Enabled = true;
                        btnExcluir.Enabled = true; 
                        btnCancelar.Enabled = false;
        } else                    { MessageBox.Show("Erro ao gravar cidade!");                     }
}             }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbCidade.SelectedIndex == 0)
            { tbCidade.SelectTab(1); }
            txtCidade.Enabled = true; 
            cbxUF.Enabled = true;
            txtCidade.Focus();
            btnSalvar.Enabled = true; 
            btnAlterar.Enabled = false; 
            bnNovo.Enabled = false;
            btnExcluir.Enabled = false; 
            btnCancelar.Enabled = true; 
            bInclusao = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbCidade.SelectedIndex == 0)
            { tbCidade.SelectTab(1); }
            if (MessageBox.Show("Confirma exclusão?", "Yes or No", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            { Cidade RegCid = new Cidade(); 
                RegCid.Idcidade = Convert.ToInt16(txtID.Text); 
                RegCid.Nomecidade = txtCidade.Text;
                RegCid.Ufcidade = cbxUF.SelectedItem.ToString();
                if (RegCid.Excluir() > 0) 
                { MessageBox.Show("Cidade excluída com sucesso!");
                    Cidade R = new Cidade(); 
                    dsCidade.Tables.Clear();
                    dsCidade.Tables.Add(R.Listar());
                    bnCidade.DataSource = dsCidade.Tables["TBCidade"]; 
                } else
                { MessageBox.Show("Erro ao excluir cidade!");
                } 
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnCidade.CancelEdit(); 
            btnSalvar.Enabled = false;
            txtCidade.Enabled = false;
            cbxUF.Enabled = false;
            btnAlterar.Enabled = true;
            bnNovo.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = false;
        }
    }
}
