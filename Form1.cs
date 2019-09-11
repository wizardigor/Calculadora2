using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculapdora
{
    public partial class frmCalculadora : Form
    {
        bool ponto = false;
        bool operador = false;
        int tamText2 = 0;
        double acumulador = 0;
        int sinal = 4;

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            if (operador == true)
            {
                txtVisor.Clear();
                operador = false;
                txtVisor.Text += "1";
            }
            else
            {
                txtVisor.Text += "0";
            }
          
        }

        private void BtnUm_Click(object sender, EventArgs e)
        {
            if (operador == true)
            {
                txtVisor.Clear();
                operador = false;
                txtVisor.Text += "1";
            }
            else
            {
                txtVisor.Text += "1";
            }
        }

        private void BtnDois_Click(object sender, EventArgs e)
        {
            if (operador == true)
            {
                txtVisor.Clear();
                operador = false;
                txtVisor.Text += "2";
            }
            else
            {
                txtVisor.Text += "2";
            }
        }

        private void BtnTres_Click(object sender, EventArgs e)
        {
            if (operador == true)
            {
                txtVisor.Clear();
                operador = false;
                txtVisor.Text += "3";
            }
            else
            {
                txtVisor.Text += "3";
            }
        }

        private void BtnQuatro_Click(object sender, EventArgs e)
        {
            if (operador == true)
            {
                txtVisor.Clear();
                operador = false;
                txtVisor.Text += "4";
            }
            else
            {
                txtVisor.Text += "4";
            }
        }

        private void BtnCinco_Click(object sender, EventArgs e)
        {
            if (operador == true)
            {
                txtVisor.Clear();
                operador = false;
                txtVisor.Text += "5";
            }
            else
            {
                txtVisor.Text += "5";
            }
        }

        private void BtnSeis_Click(object sender, EventArgs e)
        {
            if (operador == true)
            {
                txtVisor.Clear();
                operador = false;
                txtVisor.Text += "6";
            }
            else
            {
                txtVisor.Text += "6";
            }
        }

        private void BtnSete_Click(object sender, EventArgs e)
        {
            if (operador == true)
            {
                txtVisor.Clear();
                operador = false;
                txtVisor.Text += "7";
            }
            else
            {
                txtVisor.Text += "7";
            }
        }

        private void BtnOito_Click(object sender, EventArgs e)
        {
            if (operador == true)
            {
                txtVisor.Clear();
                operador = false;
                txtVisor.Text += "8";
            }
            else
            {
                txtVisor.Text += "8";
            }
        }

        private void BtnNove_Click(object sender, EventArgs e)
        {
            if (operador == true)
            {
                txtVisor.Clear();
                operador = false;
                txtVisor.Text += "9";
            }
            else
            {
                txtVisor.Text += "9";
            }
        }

        private void BtnPonto_Click(object sender, EventArgs e)
        {
            if (ponto != true)
            {
                txtVisor.Text += ',';
                ponto = true;
            }
            else
            {
                MessageBox.Show("Você já usou o '.' (PONTO).", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }               
        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            if (txtVisor2.Text == String.Empty && operador == false)
            {
                acumulador = Convert.ToDouble(txtVisor.Text);
                txtVisor2.Text += txtVisor.Text + '+';
                ponto = false;
                operador = true;
                sinal = 0;

                btnSoma.Enabled = false;
                btnSubtracao.Enabled = false;
                btnMultiplicacao.Enabled = false;
                btnDivisao.Enabled = false;
                btnIgual.Enabled = true;

            }
            else if (txtVisor2.Text != String.Empty && operador == false){
                txtVisor2.Text = Convert.ToString(acumulador) + '+';
                ponto = false;
                operador = true;
                sinal = 0;

                btnSoma.Enabled = false;
                btnSubtracao.Enabled = false;
                btnMultiplicacao.Enabled = false;
                btnDivisao.Enabled = false;
                btnIgual.Enabled = true;
            }
            else
            {
                MessageBox.Show("DIGITE ALGUM VALOR E PRESSIONE = (IGUAL).", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }                      
        }

        private void BtnSubtracao_Click(object sender, EventArgs e)
        {
            if (txtVisor2.Text == String.Empty && operador == false)
            {
                acumulador = Convert.ToDouble(txtVisor.Text);
                txtVisor2.Text += txtVisor.Text + '-';
                ponto = false;
                operador = true;
                sinal = 1;

                btnSoma.Enabled = false;
                btnSubtracao.Enabled = false;
                btnMultiplicacao.Enabled = false;
                btnDivisao.Enabled = false;
                btnIgual.Enabled = true;

            }
            else if (txtVisor2.Text != String.Empty && operador == false){
                txtVisor2.Text = Convert.ToString(acumulador) + '-';
                ponto = false;
                operador = true;
                sinal = 1;

                btnSoma.Enabled = false;
                btnSubtracao.Enabled = false;
                btnMultiplicacao.Enabled = false;
                btnDivisao.Enabled = false;
                btnIgual.Enabled = true;
            }
            else
            {
                MessageBox.Show("DIGITE ALGUM VALOR E PRESSIONE = (IGUAL).", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (txtVisor2.Text == String.Empty && operador == false)
            {
                acumulador = Convert.ToDouble(txtVisor.Text);
                txtVisor2.Text += txtVisor.Text + '*';
                ponto = false;
                operador = true;
                sinal = 2;

                btnSoma.Enabled = false;
                btnSubtracao.Enabled = false;
                btnMultiplicacao.Enabled = false;
                btnDivisao.Enabled = false;
                btnIgual.Enabled = true;

            }
            else if (txtVisor2.Text != String.Empty && operador == false){
                txtVisor2.Text = Convert.ToString(acumulador) + '*';
                ponto = false;
                operador = true;
                sinal = 2;

                btnSoma.Enabled = false;
                btnSubtracao.Enabled = false;
                btnMultiplicacao.Enabled = false;
                btnDivisao.Enabled = false;
                btnIgual.Enabled = true;
            }
            else
            {
                MessageBox.Show("DIGITE ALGUM VALOR E PRESSIONE = (IGUAL).", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BtnDivisao_Click(object sender, EventArgs e)
        {
            if (operador == false)
            {
                if(txtVisor2.Text == String.Empty && acumulador != 0)
                {
                    acumulador = Convert.ToDouble(txtVisor.Text);
                    txtVisor2.Text += txtVisor.Text + '/';
                    ponto = false;
                    operador = true;
                    sinal = 3;

                    btnSoma.Enabled = false;
                    btnSubtracao.Enabled = false;
                    btnMultiplicacao.Enabled = false;
                    btnDivisao.Enabled = false;
                    btnIgual.Enabled = true;
                }
                else if (txtVisor2.Text != String.Empty && operador == false){
                    txtVisor2.Text = Convert.ToString(acumulador) + '/';
                    ponto = false;
                    operador = true;
                    sinal = 3;

                    btnSoma.Enabled = false;
                    btnSubtracao.Enabled = false;
                    btnMultiplicacao.Enabled = false;
                    btnDivisao.Enabled = false;
                    btnIgual.Enabled = true;
                }
                else
                {
                    MessageBox.Show("O VALOR DO DIVIDENDO DEVE SER DIFERENTE DE 0 (ZERO).", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("DIGITE ALGUM VALOR E PRESSIONE = (IGUAL) OU Esc PARA UM NOVO CALCULO.", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        { 
                switch (sinal)
                {
                    case 0: //soma
                        acumulador += Convert.ToDouble(txtVisor.Text);
                        txtVisor2.Text += txtVisor.Text + '=' + Convert.ToString(acumulador);
                        ponto = false;
                        operador = false;
                        txtVisor.Clear();

                    btnSoma.Enabled = true;
                    btnSubtracao.Enabled = true;
                    btnMultiplicacao.Enabled = true;
                    btnDivisao.Enabled = true;
                    btnIgual.Enabled = true;
                    btnClear.Enabled = true;
                    break;

                    case 1: //subtração
                        acumulador -= Convert.ToDouble(txtVisor.Text);
                        txtVisor2.Text += txtVisor.Text + '=' + Convert.ToString(acumulador);
                        txtVisor.Clear();
                        ponto = false;
                        operador = false;

                    btnSoma.Enabled = true;
                    btnSubtracao.Enabled = true;
                    btnMultiplicacao.Enabled = true;
                    btnDivisao.Enabled = true;
                    btnIgual.Enabled = true;
                    btnClear.Enabled = true;
                    break;

                    case 2: //multiplicação
                        acumulador *= Convert.ToDouble(txtVisor.Text);
                        txtVisor2.Text += txtVisor.Text + '=' + Convert.ToString(acumulador);
                        txtVisor.Clear();
                        ponto = false;
                        operador = false;

                    btnSoma.Enabled = true;
                    btnSubtracao.Enabled = true;
                    btnMultiplicacao.Enabled = true;
                    btnDivisao.Enabled = true;
                    btnIgual.Enabled = true;
                    btnClear.Enabled = true;
                    break;

                    case 3: //divisão
                        acumulador /= Convert.ToDouble(txtVisor.Text);
                        txtVisor2.Text += txtVisor.Text + '=' + Convert.ToString(acumulador);
                        txtVisor.Clear();
                        ponto = false;
                        operador = false;

                    btnSoma.Enabled = true;
                    btnSubtracao.Enabled = true;
                    btnMultiplicacao.Enabled = true;
                    btnDivisao.Enabled = true;
                    btnIgual.Enabled = true;
                    btnClear.Enabled = true;
                    break;
                }
            
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
                txtVisor.Clear();
                ponto = false;
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtVisor.Clear();
            txtVisor2.Clear();
            acumulador = 0;
            ponto = false;
            operador = false;
            sinal = -1;

            btnSoma.Enabled = true;
            btnSubtracao.Enabled = true;
            btnMultiplicacao.Enabled = true;
            btnDivisao.Enabled = true;
            btnIgual.Enabled = true;
            btnClear.Enabled = true;
        }
    }
}
