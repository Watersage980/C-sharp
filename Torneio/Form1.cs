using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace torneio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            k = 1;
            p = 1;

        }
        string[] nome = new string[100];
        string jogo;
        int i, k, l, p, o, y;

        private void btntrocar_Click(object sender, EventArgs e)
        {
            p = 1;
            l = i;
        }

        private void btnpontuacao_Click(object sender, EventArgs e)
        {
            y = int.Parse(txtponto1.Text);
            o = int.Parse(txtponto2.Text);
            if (o > y)
            {
                txtvencedor.Text = "O vencedor foi " + nome[l];
                nome[p] = "";
                l = l - 1;
                p = p + 1;
                txtr1.Text = "";
                txtr2.Text = "";
                txtponto1.Text = "";
                txtponto2.Text = "";
            }
            if (y > o)
            {
                txtvencedor.Text = "O vencedor foi " + nome[p];
                nome[l] = "";
                l = l - 1;
                p = p + 1;
                txtr1.Text = "";
                txtr2.Text = "";
                txtponto1.Text = "";
                txtponto2.Text = "";
            }
        }

        private void btngerar_Click(object sender, EventArgs e)
        {
            txtvencedor.Text = "";
            if (p < l)
            {
                if (nome[p] != "")
                {
                    if (nome[l] != "")
                    {
                        txtr1.Text = nome[p];
                        txtr2.Text = nome[l];
                    }
                    if (nome[l] == "")
                    {
                        while (nome[l] == "")
                        {
                            l = l - 1;
                        }
                        if (nome[l] != "")
                        {
                            txtr1.Text = nome[p];
                            txtr2.Text = nome[l];
                        }
                    }
                }
                if (nome[p] == "")
                {
                    while (nome[p] == "")
                    {
                        p = p + 1;
                    }
                    if (nome[l] != "")
                    {
                        txtr1.Text = nome[p];
                        txtr2.Text = nome[l];
                    }
                    if (nome[l] == "")
                    {
                        while (nome[l] == "")
                        {
                            l = l - 1;
                        }
                        if (nome[l] != "")
                        {
                            txtr1.Text = nome[p];
                            txtr2.Text = nome[l];
                        }
                    }
                }
            }
        }

        private void btninscricao_Click(object sender, EventArgs e)
        {
            if (k <= i)
            {
                nome[k] = txtparticipantes.Text;
                txtparticipantes.Text = "";
                k++;
                if (k > i)
                {
                    txtparticipantes.Text = "Finalizado";
                }
            }
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            i = int.Parse(txtnp.Text);
            l = int.Parse(txtnp.Text);
            jogo = txtjogo.Text;
            txtjogo.Text = "";
            txtnp.Text = "";
        }
    }
}
