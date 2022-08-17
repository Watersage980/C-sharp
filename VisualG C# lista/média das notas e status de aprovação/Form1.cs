using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float n1;
        float n2;
        float n3;
        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnmedia_Click(object sender, EventArgs e)
        {
            if(txtnome1 != null)
            {
                n1 = float.Parse(txtnota11.Text);
                n2 = float.Parse(txtnota21.Text);
                n3 = float.Parse(txtnota31.Text);
                n1 = (n1 + n2 + n3) / 3;
                txtmedia1.Text = n1.ToString();
            }
            if (txtnome2 != null)
            {
                n1 = float.Parse(txtnota12.Text);
                n2 = float.Parse(txtnota22.Text);
                n3 = float.Parse(txtnota32.Text);
                n1 = (n1 + n2 + n3) / 3;
                txtmedia2.Text = n1.ToString();
            }
            if (txtnome3 != null)
            {
                n1 = float.Parse(txtnota13.Text);
                n2 = float.Parse(txtnota23.Text);
                n3 = float.Parse(txtnota33.Text);
                n1 = (n1 + n2 + n3) / 3;
                txtmedia3.Text = n1.ToString();
            }
        }
    }
}
