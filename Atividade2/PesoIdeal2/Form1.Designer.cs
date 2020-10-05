namespace PesoIdeal2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnFem = new System.Windows.Forms.RadioButton();
            this.rbtnMacho = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Peso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.mtxtAltura = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPeso = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnFem);
            this.groupBox1.Controls.Add(this.rbtnMacho);
            this.groupBox1.Location = new System.Drawing.Point(528, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gênero";
            // 
            // rbtnFem
            // 
            this.rbtnFem.AutoSize = true;
            this.rbtnFem.Location = new System.Drawing.Point(17, 65);
            this.rbtnFem.Name = "rbtnFem";
            this.rbtnFem.Size = new System.Drawing.Size(57, 17);
            this.rbtnFem.TabIndex = 1;
            this.rbtnFem.Text = "Fêmea";
            this.rbtnFem.UseVisualStyleBackColor = true;
            // 
            // rbtnMacho
            // 
            this.rbtnMacho.AutoSize = true;
            this.rbtnMacho.Checked = true;
            this.rbtnMacho.Location = new System.Drawing.Point(17, 31);
            this.rbtnMacho.Name = "rbtnMacho";
            this.rbtnMacho.Size = new System.Drawing.Size(58, 17);
            this.rbtnMacho.TabIndex = 0;
            this.rbtnMacho.TabStop = true;
            this.rbtnMacho.Text = "Macho";
            this.rbtnMacho.UseVisualStyleBackColor = true;
            this.rbtnMacho.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Peso
            // 
            this.Peso.AutoSize = true;
            this.Peso.Location = new System.Drawing.Point(296, 82);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(58, 13);
            this.Peso.TabIndex = 1;
            this.Peso.Text = "Peso Atual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Altura";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(389, 186);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // mtxtAltura
            // 
            this.mtxtAltura.Location = new System.Drawing.Point(389, 127);
            this.mtxtAltura.Name = "mtxtAltura";
            this.mtxtAltura.Size = new System.Drawing.Size(100, 20);
            this.mtxtAltura.TabIndex = 6;
            // 
            // mtxtPeso
            // 
            this.mtxtPeso.Location = new System.Drawing.Point(389, 79);
            this.mtxtPeso.Name = "mtxtPeso";
            this.mtxtPeso.Size = new System.Drawing.Size(100, 20);
            this.mtxtPeso.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtxtPeso);
            this.Controls.Add(this.mtxtAltura);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Peso);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnFem;
        private System.Windows.Forms.RadioButton rbtnMacho;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Peso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.MaskedTextBox mtxtAltura;
        private System.Windows.Forms.MaskedTextBox mtxtPeso;
    }
}

