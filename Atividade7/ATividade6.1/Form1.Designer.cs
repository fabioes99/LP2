namespace ATividade6._1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atividade1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividade2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividade3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividade4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atividade1ToolStripMenuItem,
            this.atividade2ToolStripMenuItem,
            this.atividade3ToolStripMenuItem,
            this.atividade4ToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // atividade1ToolStripMenuItem
            // 
            this.atividade1ToolStripMenuItem.Name = "atividade1ToolStripMenuItem";
            this.atividade1ToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.atividade1ToolStripMenuItem.Text = "Atividade 1";
            this.atividade1ToolStripMenuItem.Click += new System.EventHandler(this.atividade1ToolStripMenuItem_Click);
            // 
            // atividade2ToolStripMenuItem
            // 
            this.atividade2ToolStripMenuItem.Name = "atividade2ToolStripMenuItem";
            this.atividade2ToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.atividade2ToolStripMenuItem.Text = "Atividade 2";
            this.atividade2ToolStripMenuItem.Click += new System.EventHandler(this.atividade2ToolStripMenuItem_Click);
            // 
            // atividade3ToolStripMenuItem
            // 
            this.atividade3ToolStripMenuItem.Name = "atividade3ToolStripMenuItem";
            this.atividade3ToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.atividade3ToolStripMenuItem.Text = "Atividade 3";
            this.atividade3ToolStripMenuItem.Click += new System.EventHandler(this.atividade3ToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // atividade4ToolStripMenuItem
            // 
            this.atividade4ToolStripMenuItem.Name = "atividade4ToolStripMenuItem";
            this.atividade4ToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.atividade4ToolStripMenuItem.Text = "Atividade4";
            this.atividade4ToolStripMenuItem.Click += new System.EventHandler(this.atividade4ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atividade1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividade2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividade3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividade4ToolStripMenuItem;
    }
}

