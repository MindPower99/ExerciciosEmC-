using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConverterCent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double cent, mili, deci, metros;
            cent = Convert.ToDouble(txtCent.Text);
            mili = cent * 10;
            deci = cent / 10;
            metros = cent / 100;
            txtDeci.Text = deci.ToString();
            txtMili.Text = mili.ToString();
            txtMetros.Text = metros.ToString();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCent.Text = "";
            txtDeci.Text = "";
            txtMetros.Text = "";
            txtMili.Text = "";
        }

    }
}
