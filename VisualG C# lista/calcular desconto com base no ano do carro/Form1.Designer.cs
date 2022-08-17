namespace WindowsFormsApp19
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
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtano = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtdesconto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcontador = new System.Windows.Forms.TextBox();
            this.txt2000 = new System.Windows.Forms.TextBox();
            this.btncontadores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(208, 43);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(317, 20);
            this.txtpreco.TabIndex = 0;
            // 
            // txtano
            // 
            this.txtano.Location = new System.Drawing.Point(208, 89);
            this.txtano.Name = "txtano";
            this.txtano.Size = new System.Drawing.Size(317, 20);
            this.txtano.TabIndex = 0;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(208, 135);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(317, 149);
            this.btncalcular.TabIndex = 1;
            this.btncalcular.Text = "Calcular desconto";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtdesconto
            // 
            this.txtdesconto.Location = new System.Drawing.Point(208, 315);
            this.txtdesconto.Name = "txtdesconto";
            this.txtdesconto.Size = new System.Drawing.Size(317, 20);
            this.txtdesconto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Preço do veículo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ano do veículo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço com desconto";
            // 
            // txtcontador
            // 
            this.txtcontador.Location = new System.Drawing.Point(208, 401);
            this.txtcontador.Name = "txtcontador";
            this.txtcontador.Size = new System.Drawing.Size(317, 20);
            this.txtcontador.TabIndex = 0;
            // 
            // txt2000
            // 
            this.txt2000.Location = new System.Drawing.Point(208, 359);
            this.txt2000.Name = "txt2000";
            this.txt2000.Size = new System.Drawing.Size(317, 20);
            this.txt2000.TabIndex = 0;
            // 
            // btncontadores
            // 
            this.btncontadores.Location = new System.Drawing.Point(37, 359);
            this.btncontadores.Name = "btncontadores";
            this.btncontadores.Size = new System.Drawing.Size(132, 62);
            this.btncontadores.TabIndex = 5;
            this.btncontadores.Text = "Contadores";
            this.btncontadores.UseVisualStyleBackColor = true;
            this.btncontadores.Click += new System.EventHandler(this.btncontadores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncontadores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txt2000);
            this.Controls.Add(this.txtcontador);
            this.Controls.Add(this.txtdesconto);
            this.Controls.Add(this.txtano);
            this.Controls.Add(this.txtpreco);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.TextBox txtano;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtdesconto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcontador;
        private System.Windows.Forms.TextBox txt2000;
        private System.Windows.Forms.Button btncontadores;
    }
}

