using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnjunção_Click(object sender, EventArgs e)
        {
            string nome;
            string sobrenome;
            string nomeSobrenome;

            nome = txtnome.Text;
            sobrenome = txtsobrenome.Text;
            nomeSobrenome = nome + " " + sobrenome;

            txtnomesobrenome.Text = nomeSobrenome;
        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            int resultado;

            n1 = int.Parse(txtn1.Text);
            n2 = int.Parse(txtn2.Text);
            resultado = n1 + n2;

            txtresultado.Text = resultado.ToString();   
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtnomesobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtn1.Text = txtn1.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtn1.Text = txtn1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtn1.Text = txtn1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtn1.Text = txtn1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtn1.Text = txtn1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtn1.Text = txtn1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtn1.Text = txtn1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtn1.Text = txtn1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtn1.Text = txtn1.Text + "9";
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            txtn1.Text = txtn1.Text + "0";
        }
    }
}
