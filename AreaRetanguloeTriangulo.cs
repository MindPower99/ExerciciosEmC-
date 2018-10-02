using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AreaRetangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double b, altura,areat,arear;
            b = Convert.ToDouble(txtBase.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            areat = b * altura / 2;
            arear = b * altura;
            txtAreaRetangulo.Text = arear.ToString();
            txtAreaTriangulo.Text = areat.ToString();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAreaTriangulo.Text = "";
            txtAreaRetangulo.Text = "";
        }
    }
}
