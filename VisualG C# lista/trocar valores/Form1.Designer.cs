namespace WindowsFormsApp6
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.btntroca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(85, 39);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(257, 20);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(85, 108);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(257, 20);
            this.txtB.TabIndex = 0;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(85, 291);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(257, 20);
            this.txtC.TabIndex = 0;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(85, 355);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(257, 20);
            this.txtD.TabIndex = 0;
            // 
            // btntroca
            // 
            this.btntroca.Location = new System.Drawing.Point(138, 178);
            this.btntroca.Name = "btntroca";
            this.btntroca.Size = new System.Drawing.Size(158, 56);
            this.btntroca.TabIndex = 1;
            this.btntroca.Text = "troca";
            this.btntroca.UseVisualStyleBackColor = true;
            this.btntroca.Click += new System.EventHandler(this.btntroca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 450);
            this.Controls.Add(this.btntroca);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Button btntroca;
    }
}

