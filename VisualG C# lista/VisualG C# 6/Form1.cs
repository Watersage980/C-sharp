using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float A;
        float B;
        float C;
        private void btntroca_Click(object sender, EventArgs e)
        {
            A=float.Parse(txtA.Text);
            B=float.Parse(txtB.Text);
            C = A;
            A = B;
            B = C;
            txtC.Text = A.ToString();
            txtD.Text = B.ToString();
        }
    }
}
