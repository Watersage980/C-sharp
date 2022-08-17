using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float n1;
        private void btncheck_Click(object sender, EventArgs e)
        {
            n1=float.Parse(txtn1.Text);
            if (n1>100)
            {
                if(n1<200)
                {
                    txtanswer.Text = "O número está no intervalo de 100 a 200";
                }
                else
                {
                    txtanswer.Text = "O número está fora do intervalo";
                }
            }
            else
            {
                txtanswer.Text = "O número está fora do intervalo";
            }
        }
    }
}
