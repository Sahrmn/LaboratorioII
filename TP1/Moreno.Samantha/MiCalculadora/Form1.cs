using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            comboOperador.Text = "";
            lblResultado.Text = "0";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Numero num1 = new Numero(txtNumero1.Text);
            Numero num2 = new Numero(txtNumero2.Text);
            string operador = comboOperador.Text;
            Calculadora calc = new Calculadora();
            lblResultado.Text = calc.Operar(num1, num2, operador).ToString();

        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "0")
            {
                if (lblResultado.Text.Length <  100)
                {
                    double num = double.Parse(lblResultado.Text);
                    lblResultado.Text = Numero.DecimalBinario(num);
                }
            }
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string verificacion = "";
            if (lblResultado.Text != "0")
            {
                string num = lblResultado.Text;
                verificacion = Numero.BinarioDecimal(num);
                if (verificacion == "Valor invalido")
                {
                    MessageBox.Show("Valor Invalido","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                    lblResultado.Text = verificacion;
            }
        }
    }
}
