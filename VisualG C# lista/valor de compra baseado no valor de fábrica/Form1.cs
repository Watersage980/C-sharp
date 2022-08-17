using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float fabrica;
        double compra;
        private void btncal_Click(object sender, EventArgs e)
        {
            fabrica=float.Parse(txtfab.Text);
            compra = fabrica * 0.45;
            compra = compra + (fabrica * 0.28);
            compra = compra + fabrica;
            txtcompra.Text = compra.ToString();
        }
    }
}
