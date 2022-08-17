using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float valor;
        private void btncal_Click(object sender, EventArgs e)
        {
            valor=float.Parse(txtvalor.Text);
            valor = valor / 5;
            txtprest.Text = valor.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
