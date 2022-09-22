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
    public partial class frmProcessos : Form
    {
        public frmProcessos()
        {
            InitializeComponent();
        }

        private void frmProcessos_Load(object sender, EventArgs e)
        {
            AdicionarDadosFicticiosProcesso();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AdicionarDadosFicticiosProcesso()
        {
            TipoDesignacao.Text = "1234567";
            ProtocoloDocumento.Text = "123456";
            MembroDesignado.Text = "Sidnei Souza";
            Representado.Text = "João Souza";
            Representante.Text = "Aderbal Ramos";
            TipoProcesso.Text = "Cobrança";
            TramiteAtual.Text = "Ativo";
            AdicionarDadosFicticiosGridInfracoes();
            AdicionarDadosFicticiosGridNotificacoes();
            AdicionarDadosFicticiosGridTramites();
        }

        private void AdicionarDadosFicticiosGridInfracoes()
        { 
            dgvProcessosInfracoes.Rows.Clear();

            var listaInfracoes = new List<InfracaoModel>();

            listaInfracoes.Add(new InfracaoModel()
            {
                Ano = 2022,
                Autuado = "João Souza",
                Fiscal ="Amaro Silveira",
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
                dgvProcessosInfracoes.Rows.Add(item.Ano, item.Autuado, item.Fiscal, item.Situacao);
            }
        }



        public class InfracaoModel
        {
            public int Ano { get; set; }
            public string Autuado { get; set; }
            public string Situacao { get; set; }
            public string Fiscal { get; set; }
        }
        private void AdicionarDadosFicticiosGridNotificacoes()
        {
            
            dgvProcessosNotificacoes.Rows.Clear();

            var listaNotificacoes = new List<NotificacaoModel>();

            listaNotificacoes.Add(new NotificacaoModel()
            {
                NumeroDaNotificacao = 0012022,
                DataRecebimento = "08/09/2022",
                PrazoRegularizacao = 2022,
                
            });
            listaNotificacoes.Add(new NotificacaoModel()
            {
                NumeroDaNotificacao = 0012010,
                DataRecebimento = "08/09/2022",
                PrazoRegularizacao = 2010,
            });
            listaNotificacoes.Add(new NotificacaoModel()
            {
                NumeroDaNotificacao = 0011999,
                DataRecebimento = "09/09/1999",
                PrazoRegularizacao = 2000,
            });
            foreach (var item in listaNotificacoes)
            {
                dgvProcessosNotificacoes.Rows.Add(item.NumeroDaNotificacao, item.DataRecebimento, item.PrazoRegularizacao );
            }
        }
        public class NotificacaoModel
        {
            public int NumeroDaNotificacao { get; set; }
            public string DataRecebimento { get; set; }
            public int PrazoRegularizacao { get; set; }
        }
        private void AdicionarDadosFicticiosGridTramites()
        {
            dgvProcessosTramitesProcessuais.Rows.Clear();
            var listaTramites = new List<TramitesModel>();
            listaTramites.Add(new TramitesModel()
            {
                Data = DateTime.Today.ToString(),
                Fase = "Inicial",
                Processo = "1234",

            });
            listaTramites.Add(new TramitesModel()
            {
                Data = DateTime.Today.AddDays(-56).ToString(),
                Fase = "Recurso",
                Processo = "12345",
            });
            listaTramites.Add(new TramitesModel() 
            {
                Data = DateTime.Today.AddDays(-30).ToString(),
                Fase = "Recurso",
                Processo = "123456",
            });
            foreach(var item in listaTramites)
            {
                dgvProcessosTramitesProcessuais.Rows.Add(item.Data, item.Fase, item.Processo); 
            }
        }
        public class TramitesModel
        {
            public string Data { get; set; }
            public string Fase { get; set; }
            public string Processo { get; set; }
        }

        private void dgvProcessosInfracoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new frmInfracoes().ShowDialog();
        }

        private void dgvProcessosNotificacoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new frmNotificacao().ShowDialog();
        }

        private void dgvProcessosTramitesProcessuais_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new frmTramitesProcessuais().ShowDialog();
        }

        private void lblInfracoes_Click(object sender, EventArgs e)
        {

        }
    }
}
