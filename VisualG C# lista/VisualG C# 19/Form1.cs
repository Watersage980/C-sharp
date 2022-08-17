using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //vetores em C# são chamados arrays, então criei 2 arrays unidimensionais
        string[] nome = new string[55];
        string[] sexo = new string[55];
        float contadorH;
        float contadorM;
        int i;
        int o;
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            nome[i] = txtnome.Text;
            i = i + 1;
        }

        

        private void btncheck_Click(object sender, EventArgs e)
        {
            txthomem.Text="O número de homens é " + contadorH.ToString();
            txtmulher.Text="O número de mulheres é " + contadorM.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sexo[o] = "feminino";
            o = o + 1;
            contadorM=contadorM + 1;
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            sexo[o] = "masculino";
            o=o + 1;
            contadorH=contadorH + 1;
        }
    }
}
