using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float n1;
        float n2;   
        private void btncheck_Click(object sender, EventArgs e)
        {
            n1=float.Parse(txtn1.Text);
            n2 = float.Parse(txtn2.Text);
            if(n1>n2)
            {
                txtanswer.Text = n1.ToString() + " é o maior número";
            }
            else
            {
                txtanswer.Text = n2.ToString() + " é o maior número";
            }
        }
    }
}
