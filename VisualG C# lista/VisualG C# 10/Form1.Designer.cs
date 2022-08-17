namespace WindowsFormsApp10
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
            this.btncal = new System.Windows.Forms.Button();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtprest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncal
            // 
            this.btncal.Location = new System.Drawing.Point(246, 176);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(246, 75);
            this.btncal.TabIndex = 0;
            this.btncal.Text = "Prestação";
            this.btncal.UseVisualStyleBackColor = true;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(234, 63);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(276, 20);
            this.txtvalor.TabIndex = 1;
            // 
            // txtprest
            // 
            this.txtprest.Location = new System.Drawing.Point(234, 340);
            this.txtprest.Name = "txtprest";
            this.txtprest.Size = new System.Drawing.Size(276, 20);
            this.txtprest.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "valor a ser pago";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtprest);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.btncal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtprest;
        private System.Windows.Forms.Label label1;
    }
}

