using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Fiscalizacao.frmProcessos;

namespace Fiscalizacao
{
    public partial class frmNotificacao : Form
    {
        public frmNotificacao()
        {
            InitializeComponent();
        }
        private void frmNotificacao_Load(object sender, EventArgs e)
        {
            AdicionarDadosFicticios();
            AdicionarDadosFicticiosGridInfracoes();
        }
        private void AdicionarDadosFicticios()
        {
            DataRecebimento.Text = "08/09/2022";
            DiasPrazoDecorrido.Text = "30";
            NumeroAvisoRecebimento.Text = "07/05/2022";
            NumeroNotificacao.Text = "12345";
            PrazoRegularizacao.Text = "30";
        }
        private void AdicionarDadosFicticiosGridInfracoes()
        {
            dgvInfracao.Rows.Clear();

            var listaInfracoes = new List<InfracaoModel>();

            listaInfracoes.Add(new InfracaoModel()
            {
                Ano = 2022,
                Autuado = "João Souza",
                Fiscal = "Amaro Silveira",
                Situacao = "Concluída"
            });
            listaInfracoes.Add(new InfracaoModel()
            {
                Ano = 1999,
                Autuado = "João Souza",
                Fiscal = "Paulo Silveira",
                Situacao = "Concluída"
            });
            listaInfracoes.Add(new InfracaoModel()
            {
                Ano = 2010,
                Autuado = "João Souza",
                Fiscal = "Marco Silveira",
                Situacao = "Concluída"
            });
            foreach (var item in listaInfracoes)
            {
                dgvInfracao.Rows.Add(item.Ano, item.Autuado, item.Fiscal, item.Situacao);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNotificacoesTabela_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new frmInfracoes().ShowDialog();
        }

      
    }
}
