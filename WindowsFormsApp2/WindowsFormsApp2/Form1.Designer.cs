namespace WindowsFormsApp2
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
            this.btnsoma = new System.Windows.Forms.Button();
            this.btnjunção = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtsobrenome = new System.Windows.Forms.TextBox();
            this.txtnomesobrenome = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsoma
            // 
            this.btnsoma.Location = new System.Drawing.Point(478, 231);
            this.btnsoma.Name = "btnsoma";
            this.btnsoma.Size = new System.Drawing.Size(147, 33);
            this.btnsoma.TabIndex = 0;
            this.btnsoma.Text = "soma";
            this.btnsoma.UseVisualStyleBackColor = true;
            this.btnsoma.Click += new System.EventHandler(this.btnoperação_Click);
            // 
            // btnjunção
            // 
            this.btnjunção.Location = new System.Drawing.Point(135, 231);
            this.btnjunção.Name = "btnjunção";
            this.btnjunção.Size = new System.Drawing.Size(109, 32);
            this.btnjunção.TabIndex = 1;
            this.btnjunção.Text = "junção";
            this.btnjunção.UseVisualStyleBackColor = true;
            this.btnjunção.Click += new System.EventHandler(this.btnjunção_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "n1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "n2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "resultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "sobrenome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "nome sobrenome";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(478, 55);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(146, 20);
            this.txtn1.TabIndex = 8;
            this.txtn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(477, 138);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(147, 20);
            this.txtn2.TabIndex = 9;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(477, 312);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(147, 20);
            this.txtresultado.TabIndex = 10;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(135, 55);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(109, 20);
            this.txtnome.TabIndex = 11;
            // 
            // txtsobrenome
            // 
            this.txtsobrenome.Location = new System.Drawing.Point(135, 138);
            this.txtsobrenome.Name = "txtsobrenome";
            this.txtsobrenome.Size = new System.Drawing.Size(109, 20);
            this.txtsobrenome.TabIndex = 12;
            // 
            // txtnomesobrenome
            // 
            this.txtnomesobrenome.Location = new System.Drawing.Point(135, 311);
            this.txtnomesobrenome.Name = "txtnomesobrenome";
            this.txtnomesobrenome.Size = new System.Drawing.Size(109, 20);
            this.txtnomesobrenome.TabIndex = 13;
            this.txtnomesobrenome.TextChanged += new System.EventHandler(this.txtnomesobrenome_TextChanged);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(430, 181);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(19, 29);
            this.btn1.TabIndex = 14;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(455, 181);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(19, 29);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(480, 181);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(19, 29);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(505, 181);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(19, 29);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(530, 181);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(19, 29);
            this.btn5.TabIndex = 14;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(555, 181);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(19, 29);
            this.btn6.TabIndex = 14;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(580, 181);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(19, 29);
            this.btn7.TabIndex = 14;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(605, 181);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(19, 29);
            this.button8.TabIndex = 14;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(630, 181);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(19, 29);
            this.btn9.TabIndex = 14;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(655, 181);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(19, 29);
            this.btn10.TabIndex = 14;
            this.btn10.Text = "0";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtnomesobrenome);
            this.Controls.Add(this.txtsobrenome);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnjunção);
            this.Controls.Add(this.btnsoma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsoma;
        private System.Windows.Forms.Button btnjunção;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtsobrenome;
        private System.Windows.Forms.TextBox txtnomesobrenome;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn10;
    }
}

