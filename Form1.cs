using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        bool ponto = false;
        double resultado, numero, porcentagem;
        public Form1()
        {
            InitializeComponent();
        }

        private void show_results_Click(object sender, EventArgs e)
        {

        }

        private void show_operations_Click(object sender, EventArgs e)
        {

        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            show_operations.Text += "0";
        }

        private void btn_um_Click(object sender, EventArgs e)
        {
            show_operations.Text += "1";
        }

        private void btn_dois_Click(object sender, EventArgs e)
        {
            show_operations.Text += "2";
        }

        private void btn_tres_Click(object sender, EventArgs e)
        {
            show_operations.Text += "3";
        }

        private void btn_quatro_Click(object sender, EventArgs e)
        {
            show_operations.Text += "4";
        }

        private void btn_cinco_Click(object sender, EventArgs e)
        {
            show_operations.Text += "5";
        }

        private void btn_seis_Click(object sender, EventArgs e)
        {
            show_operations.Text += "6";
        }

        private void btn_sete_Click(object sender, EventArgs e)
        {
            show_operations.Text += "7";
        }

        private void btn_oito_Click(object sender, EventArgs e)
        {
            show_operations.Text += "8";
        }

        private void btn_nove_Click(object sender, EventArgs e)
        {
            show_operations.Text += "9";
        }

        private void btn_ponto_Click(object sender, EventArgs e)
        {
            if (!ponto)
            {
                show_operations.Text += ",";
            }

        }

        private void btn_somar_Click(object sender, EventArgs e)
        {
            show_operations.Text += "+";
        }


        private void btn_subtrair_Click(object sender, EventArgs e)
        {
            show_operations.Text += "-";
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            show_operations.Text += "*";
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            show_operations.Text += "/";
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            List<string> strNumeros = show_operations.Text.Split(new char[] { '+', '-', '*', '/' }).ToList();
            List<char> operacoes = show_operations.Text.Where(c => "+-*/".Contains(c)).ToList();

            resultado = Convert.ToDouble(strNumeros[0]);

            for (int i = 0; i < operacoes.Count; i++)
            {
                numero = Convert.ToDouble(strNumeros[i + 1]);

                switch (operacoes[i])
                {
                    case '+':
                        resultado += numero;
                        break;
                    case '-':
                        resultado -= numero;
                        break;
                    case '*':
                        resultado *= numero;
                        break;
                    case '/':
                        resultado /= numero;
                        break;
                }
            }
            show_results.Text =  show_operations.Text;
            show_operations.Text = resultado.ToString("0.0");
        }

        private void btn_backspace_Click(object sender, EventArgs e)
        {
            if (show_operations.Text.Length > 0)
            {
                show_operations.Text = show_operations.Text.Substring(0, show_operations.Text.Length - 1);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            show_operations.Text = "";
            show_results.Text = "";
        }

        private void btn_porcentagem_Click(object sender, EventArgs e)
        {
            List<string> strNumeros = show_operations.Text.Split(new char[] { '+', '-', '*', '/' }).ToList();
            List<char> operacoes = show_operations.Text.Where(c => "+-*".Contains(c)).ToList();

            resultado = Convert.ToDouble(strNumeros[0]);

            for (int i = 0; i < operacoes.Count; i++)
            {
                numero = Convert.ToDouble(strNumeros[i]);
                porcentagem = Convert.ToDouble(strNumeros[i + 1]);

                switch (operacoes[i])
                {
                    case '+':
                        resultado = ((numero * porcentagem) / 100) + numero;
                        break;
                    case '-':
                        porcentagem = (numero * porcentagem) / 100;
                        resultado = numero - porcentagem;
                        
                        break;
                    case '*':
                        resultado = (numero * porcentagem) / 100;
                        break;
                }

            }
            show_results.Text = show_operations.Text;
            show_operations.Text = resultado.ToString("0.0");
        }
    }
}
