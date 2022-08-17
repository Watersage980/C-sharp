using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float idade;
        float p;      
        private void btnverificar_Click(object sender, EventArgs e)
        {
            //usei 74 para corrigir o uso de "p" como contador 
            if(p<=74)
            {
                idade=float.Parse(txtidade.Text);
                if (idade >= 18)
                {
                    txtinfo.Text = "Maior de idade";
                }
                else
                {
                    txtinfo.Text = "Menor de idade";
                }
                p=p+1;
            }
            else
            {
                txtinfo.Text = "Catalogo finalizado";
            }
        }
    }
}
