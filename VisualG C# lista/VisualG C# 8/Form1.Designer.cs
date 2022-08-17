namespace WindowsFormsApp8
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
            this.txtdolar = new System.Windows.Forms.TextBox();
            this.txtcota = new System.Windows.Forms.TextBox();
            this.txtreal = new System.Windows.Forms.TextBox();
            this.btnconert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtdolar
            // 
            this.txtdolar.Location = new System.Drawing.Point(121, 48);
            this.txtdolar.Name = "txtdolar";
            this.txtdolar.Size = new System.Drawing.Size(254, 20);
            this.txtdolar.TabIndex = 0;
            // 
            // txtcota
            // 
            this.txtcota.Location = new System.Drawing.Point(121, 111);
            this.txtcota.Name = "txtcota";
            this.txtcota.Size = new System.Drawing.Size(254, 20);
            this.txtcota.TabIndex = 0;
            // 
            // txtreal
            // 
            this.txtreal.Location = new System.Drawing.Point(121, 331);
            this.txtreal.Name = "txtreal";
            this.txtreal.Size = new System.Drawing.Size(254, 20);
            this.txtreal.TabIndex = 0;
            // 
            // btnconert
            // 
            this.btnconert.Location = new System.Drawing.Point(136, 192);
            this.btnconert.Name = "btnconert";
            this.btnconert.Size = new System.Drawing.Size(216, 77);
            this.btnconert.TabIndex = 1;
            this.btnconert.Text = "Converter";
            this.btnconert.UseVisualStyleBackColor = true;
            this.btnconert.Click += new System.EventHandler(this.btnconert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dólares diponíveis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reais";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnconert);
            this.Controls.Add(this.txtreal);
            this.Controls.Add(this.txtcota);
            this.Controls.Add(this.txtdolar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdolar;
        private System.Windows.Forms.TextBox txtcota;
        private System.Windows.Forms.TextBox txtreal;
        private System.Windows.Forms.Button btnconert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

