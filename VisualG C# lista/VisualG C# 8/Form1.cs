using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float dolar;
        float cota;
        float real;
        private void btnconert_Click(object sender, EventArgs e)
        {
            dolar =float.Parse(txtdolar.Text);
            cota = float.Parse(txtcota.Text);
            real = dolar * cota;
            txtreal.Text = real.ToString();
        }
    }
}
