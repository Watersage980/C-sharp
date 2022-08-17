namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtsal = new System.Windows.Forms.TextBox();
            this.txtvenda = new System.Windows.Forms.TextBox();
            this.txtcom = new System.Windows.Forms.TextBox();
            this.txtmes = new System.Windows.Forms.TextBox();
            this.btnmes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(226, 35);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(271, 20);
            this.txtnome.TabIndex = 0;
            // 
            // txtsal
            // 
            this.txtsal.Location = new System.Drawing.Point(226, 72);
            this.txtsal.Name = "txtsal";
            this.txtsal.Size = new System.Drawing.Size(271, 20);
            this.txtsal.TabIndex = 0;
            // 
            // txtvenda
            // 
            this.txtvenda.Location = new System.Drawing.Point(226, 109);
            this.txtvenda.Name = "txtvenda";
            this.txtvenda.Size = new System.Drawing.Size(271, 20);
            this.txtvenda.TabIndex = 0;
            // 
            // txtcom
            // 
            this.txtcom.Location = new System.Drawing.Point(226, 145);
            this.txtcom.Name = "txtcom";
            this.txtcom.Size = new System.Drawing.Size(271, 20);
            this.txtcom.TabIndex = 0;
            // 
            // txtmes
            // 
            this.txtmes.Location = new System.Drawing.Point(226, 300);
            this.txtmes.Multiline = true;
            this.txtmes.Name = "txtmes";
            this.txtmes.Size = new System.Drawing.Size(271, 58);
            this.txtmes.TabIndex = 0;
            // 
            // btnmes
            // 
            this.btnmes.Location = new System.Drawing.Point(278, 206);
            this.btnmes.Name = "btnmes";
            this.btnmes.Size = new System.Drawing.Size(168, 53);
            this.btnmes.TabIndex = 1;
            this.btnmes.Text = "cálculo";
            this.btnmes.UseVisualStyleBackColor = true;
            this.btnmes.Click += new System.EventHandler(this.btnmes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "salário fixo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "vendas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "comissão (% em vírgula)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmes);
            this.Controls.Add(this.txtmes);
            this.Controls.Add(this.txtcom);
            this.Controls.Add(this.txtvenda);
            this.Controls.Add(this.txtsal);
            this.Controls.Add(this.txtnome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtsal;
        private System.Windows.Forms.TextBox txtvenda;
        private System.Windows.Forms.TextBox txtcom;
        private System.Windows.Forms.TextBox txtmes;
        private System.Windows.Forms.Button btnmes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

