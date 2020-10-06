namespace Atividade5
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.MtxtBruto = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.MtxtDescIRPF = new System.Windows.Forms.MaskedTextBox();
            this.MtxtDescINSS = new System.Windows.Forms.MaskedTextBox();
            this.MtxtSaliqui = new System.Windows.Forms.MaskedTextBox();
            this.MtxtSalFam = new System.Windows.Forms.MaskedTextBox();
            this.MtxtAliRpf = new System.Windows.Forms.MaskedTextBox();
            this.MtxtAinss = new System.Windows.Forms.MaskedTextBox();
            this.MtxtNumF = new System.Windows.Forms.MaskedTextBox();
            this.lblDados = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do funcionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salário Bruto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número de filhos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Desconto IRPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Desconto INSS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Aliquota INSS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Aliquota IRPF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Salário Família";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Salario Liquido";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "Verificar Desconto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(465, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 83);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 50);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(34, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "M";
            this.radioButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "F";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(465, 132);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Casado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // MtxtBruto
            // 
            this.MtxtBruto.Location = new System.Drawing.Point(193, 63);
            this.MtxtBruto.Mask = "00000,00";
            this.MtxtBruto.Name = "MtxtBruto";
            this.MtxtBruto.Size = new System.Drawing.Size(100, 20);
            this.MtxtBruto.TabIndex = 20;
            this.MtxtBruto.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(193, 35);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 21;
            // 
            // MtxtDescIRPF
            // 
            this.MtxtDescIRPF.Location = new System.Drawing.Point(465, 268);
            this.MtxtDescIRPF.Name = "MtxtDescIRPF";
            this.MtxtDescIRPF.ReadOnly = true;
            this.MtxtDescIRPF.Size = new System.Drawing.Size(100, 20);
            this.MtxtDescIRPF.TabIndex = 22;
            // 
            // MtxtDescINSS
            // 
            this.MtxtDescINSS.Location = new System.Drawing.Point(465, 239);
            this.MtxtDescINSS.Name = "MtxtDescINSS";
            this.MtxtDescINSS.ReadOnly = true;
            this.MtxtDescINSS.Size = new System.Drawing.Size(100, 20);
            this.MtxtDescINSS.TabIndex = 23;
            // 
            // MtxtSaliqui
            // 
            this.MtxtSaliqui.Location = new System.Drawing.Point(203, 320);
            this.MtxtSaliqui.Name = "MtxtSaliqui";
            this.MtxtSaliqui.ReadOnly = true;
            this.MtxtSaliqui.Size = new System.Drawing.Size(100, 20);
            this.MtxtSaliqui.TabIndex = 24;
            // 
            // MtxtSalFam
            // 
            this.MtxtSalFam.Location = new System.Drawing.Point(203, 293);
            this.MtxtSalFam.Name = "MtxtSalFam";
            this.MtxtSalFam.ReadOnly = true;
            this.MtxtSalFam.Size = new System.Drawing.Size(100, 20);
            this.MtxtSalFam.TabIndex = 25;
            // 
            // MtxtAliRpf
            // 
            this.MtxtAliRpf.Location = new System.Drawing.Point(203, 264);
            this.MtxtAliRpf.Name = "MtxtAliRpf";
            this.MtxtAliRpf.ReadOnly = true;
            this.MtxtAliRpf.Size = new System.Drawing.Size(100, 20);
            this.MtxtAliRpf.TabIndex = 26;
            // 
            // MtxtAinss
            // 
            this.MtxtAinss.Location = new System.Drawing.Point(203, 239);
            this.MtxtAinss.Name = "MtxtAinss";
            this.MtxtAinss.ReadOnly = true;
            this.MtxtAinss.Size = new System.Drawing.Size(100, 20);
            this.MtxtAinss.TabIndex = 27;
            // 
            // MtxtNumF
            // 
            this.MtxtNumF.Location = new System.Drawing.Point(193, 90);
            this.MtxtNumF.Mask = "00";
            this.MtxtNumF.Name = "MtxtNumF";
            this.MtxtNumF.Size = new System.Drawing.Size(100, 20);
            this.MtxtNumF.TabIndex = 28;
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(82, 194);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(48, 13);
            this.lblDados.TabIndex = 29;
            this.lblDados.Text = "lblDados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.MtxtNumF);
            this.Controls.Add(this.MtxtAinss);
            this.Controls.Add(this.MtxtAliRpf);
            this.Controls.Add(this.MtxtSalFam);
            this.Controls.Add(this.MtxtSaliqui);
            this.Controls.Add(this.MtxtDescINSS);
            this.Controls.Add(this.MtxtDescIRPF);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.MtxtBruto);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "but";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MaskedTextBox MtxtBruto;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox MtxtDescIRPF;
        private System.Windows.Forms.MaskedTextBox MtxtDescINSS;
        private System.Windows.Forms.MaskedTextBox MtxtSaliqui;
        private System.Windows.Forms.MaskedTextBox MtxtSalFam;
        private System.Windows.Forms.MaskedTextBox MtxtAliRpf;
        private System.Windows.Forms.MaskedTextBox MtxtAinss;
        private System.Windows.Forms.MaskedTextBox MtxtNumF;
        private System.Windows.Forms.Label lblDados;
    }
}

