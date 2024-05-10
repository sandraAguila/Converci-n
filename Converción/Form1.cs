using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converción
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirKilogramos_Click(object sender, EventArgs e)
        {
            double valor = 0;
            double result = 0;

            valor = Convert.ToDouble(txtValor.Text);
            result = valor / 2.20462262;

            txtResultado.Text = Convert.ToString(result);
        }

        private void btnConvertirLibras_Click(object sender, EventArgs e)
        {
            double valor = 0;
            double result = 0;

            valor = Convert.ToDouble(txtValor.Text);
            result = valor * 2.20462262;

            txtResultado.Text = Convert.ToString(result);
        }

        private void btnConvertirFarenheit_Click(object sender, EventArgs e)
        {
            double valor = 0;
            double result = 0;

            valor = Convert.ToDouble(txtValor.Text);
            result = valor * 1.8 + 32;

            txtResultado.Text = Convert.ToString(result);
        }

        private void btnConvertirCelsius_Click(object sender, EventArgs e)
        {
            double valor = 0;
            double result = 0;

            valor = Convert.ToDouble(txtValor.Text);
            result = (valor -32 ) / 1.8;

            txtResultado.Text = Convert.ToString(result);
        }
    }
}
