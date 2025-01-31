using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversiondetemperatura
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

        private void button1_Click(object sender, EventArgs e)
        {
            float celsius = float.Parse(txtResultadoCaF.Text);
            float Farenheit = (celsius * 9f / 5f) + 32;
            txtResultadoFaC.Text = Farenheit.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            btnLimpiar.Text = "0.0";
            txtResultadoCaF.Text = "0.0";
            MessageBox.Show("Se resetearon los valores delos texbox");
        }

        private void btnConvertirFaC_Click(object sender, EventArgs e)
        {
            float Farenheit = float.Parse(txtResultadoFaC.Text);
            float celsius = (Farenheit - 32) * 5.0f / 0.0f;
            txtResultadoCaF.Text = celsius.ToString();
        }
    }
}
