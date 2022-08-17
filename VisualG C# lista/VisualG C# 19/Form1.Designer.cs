namespace WindowsFormsApp18
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
            this.btnregistrar = new System.Windows.Forms.Button();
            this.txthomem = new System.Windows.Forms.TextBox();
            this.btncheck = new System.Windows.Forms.Button();
            this.txtmulher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(181, 27);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(403, 20);
            this.txtnome.TabIndex = 0;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(181, 126);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(402, 86);
            this.btnregistrar.TabIndex = 1;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // txthomem
            // 
            this.txthomem.Location = new System.Drawing.Point(181, 353);
            this.txthomem.Name = "txthomem";
            this.txthomem.Size = new System.Drawing.Size(403, 20);
            this.txthomem.TabIndex = 0;
            // 
            // btncheck
            // 
            this.btncheck.Location = new System.Drawing.Point(181, 246);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(402, 79);
            this.btncheck.TabIndex = 2;
            this.btncheck.Text = "Checar";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // txtmulher
            // 
            this.txtmulher.Location = new System.Drawing.Point(181, 401);
            this.txtmulher.Name = "txtmulher";
            this.txtmulher.Size = new System.Drawing.Size(403, 20);
            this.txtmulher.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Feminino";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnM
            // 
            this.btnM.Location = new System.Drawing.Point(181, 68);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(198, 42);
            this.btnM.TabIndex = 6;
            this.btnM.Text = "Masculino";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.txtmulher);
            this.Controls.Add(this.txthomem);
            this.Controls.Add(this.txtnome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.TextBox txthomem;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.TextBox txtmulher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnM;
    }
}

