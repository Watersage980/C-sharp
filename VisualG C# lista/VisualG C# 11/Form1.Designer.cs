namespace WindowsFormsApp11
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
            this.txtcompra = new System.Windows.Forms.TextBox();
            this.txtacre = new System.Windows.Forms.TextBox();
            this.txtvenda = new System.Windows.Forms.TextBox();
            this.btncal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtcompra
            // 
            this.txtcompra.Location = new System.Drawing.Point(211, 39);
            this.txtcompra.Name = "txtcompra";
            this.txtcompra.Size = new System.Drawing.Size(374, 20);
            this.txtcompra.TabIndex = 0;
            // 
            // txtacre
            // 
            this.txtacre.Location = new System.Drawing.Point(211, 134);
            this.txtacre.Name = "txtacre";
            this.txtacre.Size = new System.Drawing.Size(374, 20);
            this.txtacre.TabIndex = 0;
            // 
            // txtvenda
            // 
            this.txtvenda.Location = new System.Drawing.Point(211, 371);
            this.txtvenda.Name = "txtvenda";
            this.txtvenda.Size = new System.Drawing.Size(374, 20);
            this.txtvenda.TabIndex = 0;
            // 
            // btncal
            // 
            this.btncal.Location = new System.Drawing.Point(289, 232);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(220, 67);
            this.btncal.TabIndex = 1;
            this.btncal.Text = "Calcular";
            this.btncal.UseVisualStyleBackColor = true;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insira o valor de compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Insira o acréscimo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "O valor de venda será";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncal);
            this.Controls.Add(this.txtvenda);
            this.Controls.Add(this.txtacre);
            this.Controls.Add(this.txtcompra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcompra;
        private System.Windows.Forms.TextBox txtacre;
        private System.Windows.Forms.TextBox txtvenda;
        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

