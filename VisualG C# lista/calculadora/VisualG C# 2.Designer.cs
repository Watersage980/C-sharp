namespace visualG_em_Csharp
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsoma = new System.Windows.Forms.Button();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnsub = new System.Windows.Forms.Button();
            this.btndivisao = new System.Windows.Forms.Button();
            this.btnmulti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(279, 20);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(302, 20);
            this.txtn1.TabIndex = 0;
            this.txtn1.TextChanged += new System.EventHandler(this.txtn1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "insira um número";
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(279, 110);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(302, 20);
            this.txtn2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "insira um número";
            // 
            // btnsoma
            // 
            this.btnsoma.Location = new System.Drawing.Point(279, 169);
            this.btnsoma.Name = "btnsoma";
            this.btnsoma.Size = new System.Drawing.Size(137, 71);
            this.btnsoma.TabIndex = 2;
            this.btnsoma.Text = "soma";
            this.btnsoma.UseVisualStyleBackColor = true;
            this.btnsoma.Click += new System.EventHandler(this.btnsoma_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(279, 328);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(302, 20);
            this.txtresultado.TabIndex = 0;
            // 
            // btnsub
            // 
            this.btnsub.Location = new System.Drawing.Point(438, 171);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(142, 69);
            this.btnsub.TabIndex = 3;
            this.btnsub.Text = "subtração";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btndivisao
            // 
            this.btndivisao.Location = new System.Drawing.Point(438, 255);
            this.btndivisao.Name = "btndivisao";
            this.btndivisao.Size = new System.Drawing.Size(141, 61);
            this.btndivisao.TabIndex = 4;
            this.btndivisao.Text = "divisão";
            this.btndivisao.UseVisualStyleBackColor = true;
            this.btndivisao.Click += new System.EventHandler(this.btndivisao_Click);
            // 
            // btnmulti
            // 
            this.btnmulti.Location = new System.Drawing.Point(282, 255);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(133, 60);
            this.btnmulti.TabIndex = 5;
            this.btnmulti.Text = "multiplicação";
            this.btnmulti.UseVisualStyleBackColor = true;
            this.btnmulti.Click += new System.EventHandler(this.btnmulti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnmulti);
            this.Controls.Add(this.btndivisao);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnsoma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsoma;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btndivisao;
        private System.Windows.Forms.Button btnmulti;
    }
}

