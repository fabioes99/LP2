namespace Exercicio_6
{
    partial class ahsla
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnRemover2 = new System.Windows.Forms.Button();
            this.btnInverte = new System.Windows.Forms.Button();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palavra1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Palvra2";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(43, 164);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(111, 69);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "Remover 1 do 2";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnRemover2
            // 
            this.btnRemover2.Location = new System.Drawing.Point(198, 164);
            this.btnRemover2.Name = "btnRemover2";
            this.btnRemover2.Size = new System.Drawing.Size(114, 69);
            this.btnRemover2.TabIndex = 4;
            this.btnRemover2.Text = "Remover 1 do 2 (replace)";
            this.btnRemover2.UseVisualStyleBackColor = true;
            this.btnRemover2.Click += new System.EventHandler(this.btnRemover2_Click);
            // 
            // btnInverte
            // 
            this.btnInverte.Location = new System.Drawing.Point(357, 164);
            this.btnInverte.Name = "btnInverte";
            this.btnInverte.Size = new System.Drawing.Size(115, 69);
            this.btnInverte.TabIndex = 5;
            this.btnInverte.Text = "Inverte a palavra";
            this.btnInverte.UseVisualStyleBackColor = true;
            this.btnInverte.Click += new System.EventHandler(this.btnInverte_Click);
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(160, 76);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra2.TabIndex = 6;
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(160, 36);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra1.TabIndex = 7;
            // 
            // ahsla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.btnInverte);
            this.Controls.Add(this.btnRemover2);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ahsla";
            this.Text = "Remover";
            this.Load += new System.EventHandler(this.txtPalavra1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnRemover2;
        private System.Windows.Forms.Button btnInverte;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.TextBox txtPalavra1;
    }
}