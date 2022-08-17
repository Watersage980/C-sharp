namespace WindowsFormsApp12
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
            this.txtfab = new System.Windows.Forms.TextBox();
            this.txtcompra = new System.Windows.Forms.TextBox();
            this.btncal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtfab
            // 
            this.txtfab.Location = new System.Drawing.Point(258, 52);
            this.txtfab.Name = "txtfab";
            this.txtfab.Size = new System.Drawing.Size(287, 20);
            this.txtfab.TabIndex = 0;
            // 
            // txtcompra
            // 
            this.txtcompra.Location = new System.Drawing.Point(258, 289);
            this.txtcompra.Name = "txtcompra";
            this.txtcompra.Size = new System.Drawing.Size(287, 20);
            this.txtcompra.TabIndex = 0;
            // 
            // btncal
            // 
            this.btncal.Location = new System.Drawing.Point(258, 138);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(288, 78);
            this.btncal.TabIndex = 1;
            this.btncal.Text = "Calcular";
            this.btncal.UseVisualStyleBackColor = true;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insira o valor de fábrica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "O valor de compra será";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncal);
            this.Controls.Add(this.txtcompra);
            this.Controls.Add(this.txtfab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfab;
        private System.Windows.Forms.TextBox txtcompra;
        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

