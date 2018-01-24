using System;
using System.Windows.Forms;

namespace Exercicio14
{
    public partial class FrmCalcPrecoUnit : Form
    {
        public FrmCalcPrecoUnit()
        {
            InitializeComponent();
        }

        private string ValidaValorProduto(string valor)
        {
            double x;

            if (String.IsNullOrEmpty(valor))
            {
                return "O valor do produto não pode ser vazio.";
            }

            if (!double.TryParse(valor, out double n))
            {
                return "O valor do produto deve ser numérico.";
            }

            if (valor.Contains("."))
            {
                return "Utilize virgula ao invez de ponto no valor do produto.";
            }

            x = double.Parse(valor);
            if (x < 0)
            {
                return "O valor do produto não pode ser menor que zero.";
            }

            return "";
        }
        private string ValidaFatorEmbalagem(string valor)
        {
            int x;

            if (string.IsNullOrEmpty(valor))
            {
                return "O fator de embalagem não pode ser vazio.";
            }

            if (!int.TryParse(valor, out int n))
            {
                return "O fator de embalagem deve ser numérico.";
            }

            x = int.Parse(valor);
            if (x <= 0)
            {
                return "O fator de embalagem deve ser no mínimo 1.";
            }

            return "";
        }
        private string ValidaCasasDecimais(string valor)
        {
            int x;

            if (string.IsNullOrEmpty(valor))
            {
                return "O número de casas decimais não pode ser vazio.";
            }

            if (!int.TryParse(valor, out int n))
            {
                return "O número de casas decimais deve ser numérico.";
            }

            x = int.Parse(valor);
            if (x < 0)
            {
                return "O número de casas decimais não pode ser menor que zero.";
            }

            return "";
        }

        private void CalcularPrecoUnitario(string valorProd, string fatorEmb, string casasDec)
        {
            string resultado = "";
            string alerta = "";
            double valorProduto;
            int fatorEmbalagem;
            int casasDecimais;
            double precoUnitario;

            resultado = ValidaValorProduto(valorProd);
            if (!string.IsNullOrEmpty(resultado))
            {
                alerta += resultado + Environment.NewLine;
            }

            resultado = ValidaFatorEmbalagem(fatorEmb);
            if (!string.IsNullOrEmpty(resultado))
            {
                alerta += resultado + Environment.NewLine;
            }

            resultado = ValidaCasasDecimais(casasDec);
            if (!string.IsNullOrEmpty(resultado))
            {
                alerta += resultado;
            }

            if (!string.IsNullOrEmpty(alerta))
            {
                MessageBox.Show(alerta);
                return;
            }

            valorProduto = double.Parse(valorProd);
            fatorEmbalagem = int.Parse(fatorEmb);
            casasDecimais = int.Parse(casasDec);
            precoUnitario = Math.Round(valorProduto / fatorEmbalagem,casasDecimais);

            txtPrecoUnit.Text = precoUnitario + "";
        }

        private void butCalc_Click(object sender, EventArgs e)
        {
            CalcularPrecoUnitario(txtValorProd.Text, txtFatorEmb.Text, txtCasasDec.Text);
        }
    }
}
