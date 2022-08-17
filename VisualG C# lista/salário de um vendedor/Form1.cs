using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string nome;
        float n1;
        float n2;   
        float n3;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnmes_Click(object sender, EventArgs e)
        {
            nome=txtnome.Text;
            n1=float.Parse(txtsal.Text);
            n2=float.Parse(txtvenda.Text);
            n3=float.Parse(txtcom.Text);
            n2 = n2 * n3;
            n1 = n1 + n2;
            txtmes.Text = nome + " teve um salário mensal de" + n1;
        }
    }
}
