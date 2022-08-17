using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float n1;
        private void btnchecar_Click(object sender, EventArgs e)
        {
            n1=float.Parse(txtn1.Text);
            if(n1>=10)
            {
                txtinfo.Text = "É um número maior que dez";
            }
            else
            {
                txtinfo.Text = "É um número menor que dez";
            }
        }
    }
}
