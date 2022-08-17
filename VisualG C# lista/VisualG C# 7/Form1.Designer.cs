namespace WindowsFormsApp7
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
            this.txtcelsius = new System.Windows.Forms.TextBox();
            this.btncovert = new System.Windows.Forms.Button();
            this.txtfaren = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtcelsius
            // 
            this.txtcelsius.Location = new System.Drawing.Point(38, 44);
            this.txtcelsius.Name = "txtcelsius";
            this.txtcelsius.Size = new System.Drawing.Size(276, 20);
            this.txtcelsius.TabIndex = 0;
            // 
            // btncovert
            // 
            this.btncovert.Location = new System.Drawing.Point(54, 169);
            this.btncovert.Name = "btncovert";
            this.btncovert.Size = new System.Drawing.Size(233, 80);
            this.btncovert.TabIndex = 1;
            this.btncovert.Text = "converter";
            this.btncovert.UseVisualStyleBackColor = true;
            this.btncovert.Click += new System.EventHandler(this.btncovert_Click);
            // 
            // txtfaren
            // 
            this.txtfaren.Location = new System.Drawing.Point(38, 360);
            this.txtfaren.Name = "txtfaren";
            this.txtfaren.Size = new System.Drawing.Size(276, 20);
            this.txtfaren.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.btncovert);
            this.Controls.Add(this.txtfaren);
            this.Controls.Add(this.txtcelsius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcelsius;
        private System.Windows.Forms.Button btncovert;
        private System.Windows.Forms.TextBox txtfaren;
    }
}

