namespace torneio
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
            this.txtjogo = new System.Windows.Forms.TextBox();
            this.txtnp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtparticipantes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btninicio = new System.Windows.Forms.Button();
            this.btninscricao = new System.Windows.Forms.Button();
            this.txtr2 = new System.Windows.Forms.TextBox();
            this.txtr1 = new System.Windows.Forms.TextBox();
            this.btngerar = new System.Windows.Forms.Button();
            this.txtponto2 = new System.Windows.Forms.TextBox();
            this.txtponto1 = new System.Windows.Forms.TextBox();
            this.btnpontuacao = new System.Windows.Forms.Button();
            this.btntrocar = new System.Windows.Forms.Button();
            this.txtvencedor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtjogo
            // 
            this.txtjogo.Location = new System.Drawing.Point(111, 12);
            this.txtjogo.Name = "txtjogo";
            this.txtjogo.Size = new System.Drawing.Size(250, 20);
            this.txtjogo.TabIndex = 0;
            // 
            // txtnp
            // 
            this.txtnp.Location = new System.Drawing.Point(111, 38);
            this.txtnp.Name = "txtnp";
            this.txtnp.Size = new System.Drawing.Size(250, 20);
            this.txtnp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jogos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "N° paticipantes";
            // 
            // txtparticipantes
            // 
            this.txtparticipantes.Location = new System.Drawing.Point(436, 38);
            this.txtparticipantes.Name = "txtparticipantes";
            this.txtparticipantes.Size = new System.Drawing.Size(260, 20);
            this.txtparticipantes.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome dos participantes";
            // 
            // btninicio
            // 
            this.btninicio.Location = new System.Drawing.Point(111, 64);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(250, 57);
            this.btninicio.TabIndex = 4;
            this.btninicio.Text = "Início";
            this.btninicio.UseVisualStyleBackColor = true;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // btninscricao
            // 
            this.btninscricao.Location = new System.Drawing.Point(436, 64);
            this.btninscricao.Name = "btninscricao";
            this.btninscricao.Size = new System.Drawing.Size(259, 56);
            this.btninscricao.TabIndex = 5;
            this.btninscricao.Text = "Inscrição";
            this.btninscricao.UseVisualStyleBackColor = true;
            this.btninscricao.Click += new System.EventHandler(this.btninscricao_Click);
            // 
            // txtr2
            // 
            this.txtr2.Location = new System.Drawing.Point(203, 188);
            this.txtr2.Multiline = true;
            this.txtr2.Name = "txtr2";
            this.txtr2.Size = new System.Drawing.Size(158, 41);
            this.txtr2.TabIndex = 6;
            // 
            // txtr1
            // 
            this.txtr1.Location = new System.Drawing.Point(12, 188);
            this.txtr1.Multiline = true;
            this.txtr1.Name = "txtr1";
            this.txtr1.Size = new System.Drawing.Size(169, 41);
            this.txtr1.TabIndex = 6;
            // 
            // btngerar
            // 
            this.btngerar.Location = new System.Drawing.Point(12, 243);
            this.btngerar.Name = "btngerar";
            this.btngerar.Size = new System.Drawing.Size(349, 56);
            this.btngerar.TabIndex = 7;
            this.btngerar.Text = "Gerar rodada";
            this.btngerar.UseVisualStyleBackColor = true;
            this.btngerar.Click += new System.EventHandler(this.btngerar_Click);
            // 
            // txtponto2
            // 
            this.txtponto2.Location = new System.Drawing.Point(203, 321);
            this.txtponto2.Multiline = true;
            this.txtponto2.Name = "txtponto2";
            this.txtponto2.Size = new System.Drawing.Size(158, 46);
            this.txtponto2.TabIndex = 8;
            // 
            // txtponto1
            // 
            this.txtponto1.Location = new System.Drawing.Point(12, 321);
            this.txtponto1.Multiline = true;
            this.txtponto1.Name = "txtponto1";
            this.txtponto1.Size = new System.Drawing.Size(161, 46);
            this.txtponto1.TabIndex = 8;
            // 
            // btnpontuacao
            // 
            this.btnpontuacao.Location = new System.Drawing.Point(12, 385);
            this.btnpontuacao.Name = "btnpontuacao";
            this.btnpontuacao.Size = new System.Drawing.Size(350, 48);
            this.btnpontuacao.TabIndex = 9;
            this.btnpontuacao.Text = "Pontuação";
            this.btnpontuacao.UseVisualStyleBackColor = true;
            this.btnpontuacao.Click += new System.EventHandler(this.btnpontuacao_Click);
            // 
            // btntrocar
            // 
            this.btntrocar.Location = new System.Drawing.Point(386, 188);
            this.btntrocar.Name = "btntrocar";
            this.btntrocar.Size = new System.Drawing.Size(103, 245);
            this.btntrocar.TabIndex = 10;
            this.btntrocar.Text = "Trocar rodada";
            this.btntrocar.UseVisualStyleBackColor = true;
            this.btntrocar.Click += new System.EventHandler(this.btntrocar_Click);
            // 
            // txtvencedor
            // 
            this.txtvencedor.Location = new System.Drawing.Point(534, 188);
            this.txtvencedor.Multiline = true;
            this.txtvencedor.Name = "txtvencedor";
            this.txtvencedor.Size = new System.Drawing.Size(106, 245);
            this.txtvencedor.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.txtvencedor);
            this.Controls.Add(this.btntrocar);
            this.Controls.Add(this.btnpontuacao);
            this.Controls.Add(this.txtponto1);
            this.Controls.Add(this.txtponto2);
            this.Controls.Add(this.btngerar);
            this.Controls.Add(this.txtr1);
            this.Controls.Add(this.txtr2);
            this.Controls.Add(this.btninscricao);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtparticipantes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnp);
            this.Controls.Add(this.txtjogo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtjogo;
        private System.Windows.Forms.TextBox txtnp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtparticipantes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.Button btninscricao;
        private System.Windows.Forms.TextBox txtr2;
        private System.Windows.Forms.TextBox txtr1;
        private System.Windows.Forms.Button btngerar;
        private System.Windows.Forms.TextBox txtponto2;
        private System.Windows.Forms.TextBox txtponto1;
        private System.Windows.Forms.Button btnpontuacao;
        private System.Windows.Forms.Button btntrocar;
        private System.Windows.Forms.TextBox txtvencedor;
    }
}

