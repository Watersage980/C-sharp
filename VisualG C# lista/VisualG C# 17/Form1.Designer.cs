namespace WindowsFormsApp16
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
            this.txtinput = new System.Windows.Forms.TextBox();
            this.btncatalog = new System.Windows.Forms.Button();
            this.btncheck = new System.Windows.Forms.Button();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(144, 31);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(331, 20);
            this.txtinput.TabIndex = 0;
            // 
            // btncatalog
            // 
            this.btncatalog.Location = new System.Drawing.Point(235, 126);
            this.btncatalog.Name = "btncatalog";
            this.btncatalog.Size = new System.Drawing.Size(158, 56);
            this.btncatalog.TabIndex = 2;
            this.btncatalog.Text = "Catalogar";
            this.btncatalog.UseVisualStyleBackColor = true;
            this.btncatalog.Click += new System.EventHandler(this.btncatalog_Click);
            // 
            // btncheck
            // 
            this.btncheck.Location = new System.Drawing.Point(235, 235);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(158, 56);
            this.btncheck.TabIndex = 2;
            this.btncheck.Text = "Resultado";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(144, 350);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(331, 20);
            this.txtresult.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informe um número";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.btncatalog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtinput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.Button btncatalog;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Label label1;
    }
}

