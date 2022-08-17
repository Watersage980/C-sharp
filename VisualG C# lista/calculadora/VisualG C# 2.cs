using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visualG_em_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n1;
        int n2;
        private void btnsoma_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(txtn1.Text);
            n2 = int.Parse(txtn2.Text);
            n1 = n1 + n2;
            txtresultado.Text = n1.ToString();
        }

        private void txtn1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(txtn1.Text);
            n2 = int.Parse(txtn2.Text);
            n1 = n1 - n2;
            txtresultado.Text = n1.ToString();
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(txtn1.Text);
            n2 = int.Parse(txtn2.Text);
            n1 = n1 * n2;
            txtresultado.Text = n1.ToString();
        }

        private void btndivisao_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(txtn1.Text);
            n2 = int.Parse(txtn2.Text);
            n1 = n1 / n2;
            txtresultado.Text = n1.ToString();
        }
    }
}
