using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double preco;
        float ano;
        double desconto;
        float contador2;
        float contador1;
        private void btncalcular_Click(object sender, EventArgs e)
        {
                preco = double.Parse(txtpreco.Text);
                ano = float.Parse(txtano.Text);
                if(ano<=2000)
                {
                    desconto = 0.12;
                    contador1 = contador1 + 1;
                    contador2 = contador2 + 1;
                    preco = preco - (preco * desconto);
                    txtdesconto.Text=preco.ToString();
                }
                else
                {
                desconto = 0.07;
                contador1= contador1 + 1;
                preco = preco - (preco * desconto);
                txtdesconto.Text= preco.ToString();
                }

        }

        private void btncontadores_Click(object sender, EventArgs e)
        {
            txt2000.Text="O número de carros antes do ano 2000 é " + contador2.ToString();
            txtcontador.Text="O número total de carros é " + contador1.ToString();
        }
    }
}
