using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double deposito;
        double ganho;
        private void btncalculo_Click(object sender, EventArgs e)
        {
            deposito =float.Parse(txtdepo.Text);
            ganho = deposito * 0.7;
            deposito = deposito + ganho;
            txtfinal.Text=deposito.ToString();
        }
    }
}
