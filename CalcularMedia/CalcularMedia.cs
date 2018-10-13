using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculoDeMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, n4, media;
            n1 = Convert.ToDouble(txtn1.Text);
            n2 = Convert.ToDouble(txtn2.Text);
            n3 = Convert.ToDouble(txtn3.Text);
            n4 = Convert.ToDouble(txtn4.Text);
            media = (n1 + n2 + n3 + n4) / 4;
            txtmedia.Text = media.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtn1.Text = "";
            txtn2.Text = "";
            txtn3.Text = "";
            txtn4.Text = "";
            txtmedia.Text = "";
        }
    }
}
