using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }

        public decimal Valor { get; set; }

        private Operacao OperacaoSelecionada {  get; set; }

        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "+";
        }

        private void btnSubitrair_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "-";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "*";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "/";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txtResultado.Text);
                    break;
            }
            txtResultado.Text = Convert.ToString(Resultado);
            lblOperacao.Text = "=";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
            txtResultado.Text += ",";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains("."))
                txtResultado.Text += ".";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void mFileNovo_Click(object sender, EventArgs e)
        {
            new Thread(() => Application.Run(new Form1())).Start();
        }

        private void mFileSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mFileAbrir_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 f = new Form2();
            f.ShowDialog();
            
        }

        private void mHelpSobreDev_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedro Henrique");
        }

        private void mHelpSobreVer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versão 2.0.0");
        }

        private void comboMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMenu.SelectedIndex == 0)
            {
                menuFile.Text = "File";
                menuHelp.Text = "Help";
            }
            else
            {
                menuFile.Text = "Arquivo";
                menuHelp.Text = "Ajuda";
            }
        }

        private void mPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblOperacao.Text = mPesquisar.Text;
                mPesquisar.Text = "";
            }
        }
    } 
}
