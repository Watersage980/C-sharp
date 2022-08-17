using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double n1;
        double n2;
        double n3;
        string opcao;



        private void button1_Click(object sender, EventArgs e)
        {
            txtvisor.Text = "1";
            n1 = int.Parse(txtvisor.Text);

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtvisor.Text = txtvisor.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtvisor.Text = txtvisor.Text + "3";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(n3==1)
            {
                n3 = 0;
                txtvisor.Text = "";
            }
            txtvisor.Text = txtvisor.Text + "1";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (n3 == 1)
            {
                n3 = 0;
                txtvisor.Text = "";
            }
            txtvisor.Text = txtvisor.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (n3 == 1)
            {
                n3 = 0;
                txtvisor.Text = "";
            }
            txtvisor.Text = txtvisor.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (n3 == 1)
            {
                n3 = 0;
                txtvisor.Text = "";
            }
            txtvisor.Text = txtvisor.Text + "6";
        }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            if (n3 == 1)
            {
                n3 = 0;
                txtvisor.Text = "";
            }
            txtvisor.Text = txtvisor.Text + "2";
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            if (n3 == 1)
            {
                n3 = 0;
                txtvisor.Text = "";
            }
            txtvisor.Text = txtvisor.Text + "3";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (n3 == 1)
            {
                n3 = 0;
                txtvisor.Text = "";
            }
            txtvisor.Text = txtvisor.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (n3 == 1)
            {
                n3 = 0;
                txtvisor.Text = "";
            }
            txtvisor.Text = txtvisor.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (n3 == 1)
            {
                n3 = 0;
                txtvisor.Text = "";
            }
            txtvisor.Text = txtvisor.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (n3 == 1)
            {
                n3 = 0;
                txtvisor.Text = "";
            }
            txtvisor.Text = txtvisor.Text + "0";
        }

        private void btndecimal_Click(object sender, EventArgs e)
        {
            txtvisor.Text = txtvisor.Text + ",";
        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            if(txtvisor.Text!="")
            {               
                if(n1!=0)
                {
                    n2=double.Parse(txtvisor.Text);
                    n1 = n1+ n2;
                    txtvisor.Text = "";
                    txtvisor.Text =n1.ToString();
                    n3 = 1;
                }
                else
                {
                    opcao = "soma";
                    n1 = double.Parse(txtvisor.Text);
                    txtvisor.Text = "";
                }
            }         
        }

        private void btnsubtracao_Click(object sender, EventArgs e)
        {
            if (txtvisor.Text != "")
            {
                if (n1 != 0)
                {
                    n2 = double.Parse(txtvisor.Text);
                    n1 = n1 - n2;
                    txtvisor.Text = "";
                    txtvisor.Text = n1.ToString();
                    n3 = 1;
                }
                else
                {
                    opcao = "subtracao";
                    n1 = double.Parse(txtvisor.Text);
                    txtvisor.Text = "";
                }
            }    
        }

        private void btndivisao_Click(object sender, EventArgs e)
        {
            if (txtvisor.Text != "")
            {
                if (n1 != 0)
                {
                    n2 = double.Parse(txtvisor.Text);
                    n1 = n1 / n2;
                    txtvisor.Text = "";
                    txtvisor.Text = n1.ToString();
                    n3 = 1;
                }
                else
                {
                    opcao = "divisao";
                    n1 = double.Parse(txtvisor.Text);
                    txtvisor.Text = "";
                }
            }
        }

        private void btnmultiplicacao_Click(object sender, EventArgs e)
        {
            if (txtvisor.Text != "")
            {                
                if (n1 != 0)
                {
                    n2 = double.Parse(txtvisor.Text);
                    n1 = n1 * n2;
                    txtvisor.Text = "";
                    txtvisor.Text = n1.ToString();
                    n3 = 1;
                }
                else
                {
                    opcao = "multiplicacao";
                    n1 = double.Parse(txtvisor.Text);
                    txtvisor.Text = "";
                }
            }
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            n2 = double.Parse(txtvisor.Text);
            
                if (opcao == "soma")
                {
                
                n1 = n1 + n2; 
                opcao = "";
                txtvisor.Text = n1.ToString();
                                   
                }
                if (opcao == "subtracao")
                {
                n1 = n1 - n2; 
                opcao = "";
                txtvisor.Text = n1.ToString();
                }
                if (opcao == "multiplicacao")
                {
                n1 = n1 * n2;
                opcao = "";
                txtvisor.Text = n1.ToString();
                }
                if (opcao == "divisao")
                {
                n1 = n1 / n2; 
                opcao = "";
                txtvisor.Text = n1.ToString();
                }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            n1 = 0;
            n2 = 0;
            txtvisor.Text = string.Empty;
        }

        private void btnnegativo_Click(object sender, EventArgs e)
        {
            txtvisor.Text = "-";
        }
    }
}
