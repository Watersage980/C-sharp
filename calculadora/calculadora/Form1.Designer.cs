namespace calculadora
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
            this.txtvisor = new System.Windows.Forms.TextBox();
            this.btnigual = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnmultiplicacao = new System.Windows.Forms.Button();
            this.btndivisao = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnsoma = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btndecimal = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnsubtracao = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnnegativo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtvisor
            // 
            this.txtvisor.Location = new System.Drawing.Point(56, 54);
            this.txtvisor.Multiline = true;
            this.txtvisor.Name = "txtvisor";
            this.txtvisor.Size = new System.Drawing.Size(351, 58);
            this.txtvisor.TabIndex = 21;
            this.txtvisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnigual
            // 
            this.btnigual.Location = new System.Drawing.Point(360, 122);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(47, 309);
            this.btnigual.TabIndex = 20;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = true;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(56, 122);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(56, 60);
            this.btn7.TabIndex = 18;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(132, 122);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(56, 60);
            this.btn8.TabIndex = 17;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(132, 207);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(56, 60);
            this.btn5.TabIndex = 16;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(132, 371);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(56, 60);
            this.btn0.TabIndex = 15;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(132, 292);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(56, 60);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click_1);
            // 
            // btnmultiplicacao
            // 
            this.btnmultiplicacao.Location = new System.Drawing.Point(283, 122);
            this.btnmultiplicacao.Name = "btnmultiplicacao";
            this.btnmultiplicacao.Size = new System.Drawing.Size(57, 60);
            this.btnmultiplicacao.TabIndex = 13;
            this.btnmultiplicacao.Text = "X";
            this.btnmultiplicacao.UseVisualStyleBackColor = true;
            this.btnmultiplicacao.Click += new System.EventHandler(this.btnmultiplicacao_Click);
            // 
            // btndivisao
            // 
            this.btndivisao.Location = new System.Drawing.Point(283, 207);
            this.btndivisao.Name = "btndivisao";
            this.btndivisao.Size = new System.Drawing.Size(57, 60);
            this.btndivisao.TabIndex = 4;
            this.btndivisao.Text = "/";
            this.btndivisao.UseVisualStyleBackColor = true;
            this.btndivisao.Click += new System.EventHandler(this.btndivisao_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(209, 122);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(57, 60);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnsoma
            // 
            this.btnsoma.Location = new System.Drawing.Point(283, 371);
            this.btnsoma.Name = "btnsoma";
            this.btnsoma.Size = new System.Drawing.Size(57, 60);
            this.btnsoma.TabIndex = 10;
            this.btnsoma.Text = "+";
            this.btnsoma.UseVisualStyleBackColor = true;
            this.btnsoma.Click += new System.EventHandler(this.btnsoma_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(209, 207);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(57, 60);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btndecimal
            // 
            this.btndecimal.Location = new System.Drawing.Point(209, 371);
            this.btndecimal.Name = "btndecimal";
            this.btndecimal.Size = new System.Drawing.Size(57, 60);
            this.btndecimal.TabIndex = 8;
            this.btndecimal.Text = ",";
            this.btndecimal.UseVisualStyleBackColor = true;
            this.btndecimal.Click += new System.EventHandler(this.btndecimal_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(54, 210);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(58, 60);
            this.btn4.TabIndex = 7;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnsubtracao
            // 
            this.btnsubtracao.Location = new System.Drawing.Point(283, 292);
            this.btnsubtracao.Name = "btnsubtracao";
            this.btnsubtracao.Size = new System.Drawing.Size(57, 60);
            this.btnsubtracao.TabIndex = 6;
            this.btnsubtracao.Text = "-";
            this.btnsubtracao.UseVisualStyleBackColor = true;
            this.btnsubtracao.Click += new System.EventHandler(this.btnsubtracao_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(54, 371);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(58, 60);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "C";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(209, 292);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(57, 60);
            this.btn3.TabIndex = 19;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click_1);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(54, 292);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(58, 60);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnnegativo
            // 
            this.btnnegativo.Location = new System.Drawing.Point(413, 54);
            this.btnnegativo.Name = "btnnegativo";
            this.btnnegativo.Size = new System.Drawing.Size(44, 57);
            this.btnnegativo.TabIndex = 22;
            this.btnnegativo.Text = "negativo";
            this.btnnegativo.UseVisualStyleBackColor = true;
            this.btnnegativo.Click += new System.EventHandler(this.btnnegativo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 485);
            this.Controls.Add(this.btnnegativo);
            this.Controls.Add(this.txtvisor);
            this.Controls.Add(this.btnigual);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnmultiplicacao);
            this.Controls.Add(this.btndivisao);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnsoma);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btndecimal);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnsubtracao);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "calculadora de batatas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvisor;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnmultiplicacao;
        private System.Windows.Forms.Button btndivisao;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnsoma;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btndecimal;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnsubtracao;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnnegativo;
    }
}

