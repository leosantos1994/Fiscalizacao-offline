using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiscalizacao
{
    public partial class frmFinanceiro : Form
    {
        public frmFinanceiro()
        {
            InitializeComponent();
        }

        private void frmFinanceiro_Load(object sender, EventArgs e)
        {
            AdicionarDadosFicticios();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdicionarDadosFicticios()
        {
            Ano.Text = "2020";
            ValorBruto.Text = "40,00";
            Complemento.Text = "Fundos";
            DataExecucao.Text = "08/09/2022";
            DividaAtiva.Text = "30,00";
            DataOperacao.Text = "07/05/2022";
            ValorLiquido.Text = "25,00";
            Numero.Text = "12345";
            ProtocoloDocumento.Text = "1234-5";
            Parcela.Text = "1/5";
            Processo.Text = "012034";
            Reajustado.Text = "32,00";
            Requerimento.Text = "000001";
            Pessoa.Text = "joão Silva";
            ValorSaldo.Text = "10,00";
            Situacao.Text = "Aberto";
            TipoLancamento.Text = "Entrada";
            DataMovimento.Text = "07/09/2022";

        }

        private void lblComplemento_Click(object sender, EventArgs e)
        {

        }

        private void lblVencimento_Click(object sender, EventArgs e)
        {

        }

        private void txtFinanceiroComplemento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
