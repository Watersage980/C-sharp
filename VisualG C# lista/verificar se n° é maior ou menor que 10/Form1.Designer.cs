namespace WindowsFormsApp13
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
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.btnchecar = new System.Windows.Forms.Button();
            this.txtinfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(173, 44);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(418, 20);
            this.txtn1.TabIndex = 0;
            // 
            // btnchecar
            // 
            this.btnchecar.Location = new System.Drawing.Point(268, 146);
            this.btnchecar.Name = "btnchecar";
            this.btnchecar.Size = new System.Drawing.Size(216, 76);
            this.btnchecar.TabIndex = 1;
            this.btnchecar.Text = "Checar";
            this.btnchecar.UseVisualStyleBackColor = true;
            this.btnchecar.Click += new System.EventHandler(this.btnchecar_Click);
            // 
            // txtinfo
            // 
            this.txtinfo.Location = new System.Drawing.Point(173, 320);
            this.txtinfo.Name = "txtinfo";
            this.txtinfo.Size = new System.Drawing.Size(418, 20);
            this.txtinfo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insira um número";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnchecar);
            this.Controls.Add(this.txtinfo);
            this.Controls.Add(this.txtn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.Button btnchecar;
        private System.Windows.Forms.TextBox txtinfo;
        private System.Windows.Forms.Label label1;
    }
}

