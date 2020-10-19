namespace Exercicio_6
{
    partial class frmExercicio4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rchTxt = new System.Windows.Forms.RichTextBox();
            this.btnContaNum = new System.Windows.Forms.Button();
            this.btnPosicao = new System.Windows.Forms.Button();
            this.btnConta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchTxt
            // 
            this.rchTxt.Location = new System.Drawing.Point(188, 3);
            this.rchTxt.Name = "rchTxt";
            this.rchTxt.Size = new System.Drawing.Size(245, 96);
            this.rchTxt.TabIndex = 0;
            this.rchTxt.Text = "";
            // 
            // btnContaNum
            // 
            this.btnContaNum.Location = new System.Drawing.Point(67, 39);
            this.btnContaNum.Name = "btnContaNum";
            this.btnContaNum.Size = new System.Drawing.Size(78, 45);
            this.btnContaNum.TabIndex = 1;
            this.btnContaNum.Text = "Contar numeros";
            this.btnContaNum.UseVisualStyleBackColor = true;
            this.btnContaNum.Click += new System.EventHandler(this.btnContaNum_Click);
            // 
            // btnPosicao
            // 
            this.btnPosicao.Location = new System.Drawing.Point(200, 105);
            this.btnPosicao.Name = "btnPosicao";
            this.btnPosicao.Size = new System.Drawing.Size(204, 35);
            this.btnPosicao.TabIndex = 2;
            this.btnPosicao.Text = "Posicao primeiro branco";
            this.btnPosicao.UseVisualStyleBackColor = true;
            this.btnPosicao.Click += new System.EventHandler(this.btnPosicao_Click);
            // 
            // btnConta
            // 
            this.btnConta.Location = new System.Drawing.Point(459, 39);
            this.btnConta.Name = "btnConta";
            this.btnConta.Size = new System.Drawing.Size(122, 45);
            this.btnConta.TabIndex = 3;
            this.btnConta.Text = "Contar Letras";
            this.btnConta.UseVisualStyleBackColor = true;
            this.btnConta.Click += new System.EventHandler(this.btnConta_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConta);
            this.Controls.Add(this.btnPosicao);
            this.Controls.Add(this.btnContaNum);
            this.Controls.Add(this.rchTxt);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTxt;
        private System.Windows.Forms.Button btnContaNum;
        private System.Windows.Forms.Button btnPosicao;
        private System.Windows.Forms.Button btnConta;
    }
}