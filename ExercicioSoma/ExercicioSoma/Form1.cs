using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eae
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            int n1, n2;
            n1 = Convert.ToInt32(txbn1.Text);
            n2 = Convert.ToInt32(txbn2.Text);
            int soma = n1 + n2;
            txbresult.Text = soma.ToString();
        }


    }
}
