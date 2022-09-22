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
    public partial class frmProtocolo : Form
    {
        public frmProtocolo()
        {
            InitializeComponent();
        }


        private void frmProtocolo_Load(object sender, EventArgs e)
        {
            AdicionarDadosFicticios();
        }
        private void AdicionarDadosFicticios()
        {
            TipoAssunto.Text = "Cobrança";
            DataCadastro.Text = "0101";

            RegistroConselho.Text = "0123456";
            NumeroProcesso.Text = "00123456";
            SolicitacaoServico.Text = "000123456";
            Protocolo.Text = "123456";
            Remetente.Text = "Anderson Souza";
            txtTipoInscricao.Text = "Quimico";
            TipoPedido.Text = "Inscrição";


            ProtocoloModel model = new ProtocoloModel()
            {
                DataCadastro = new DateTime(2022, 09,13),
                NumeroProcesso = "123",
                Protocolo = "123",
                RegistroConselho = "435345",
                Remetente = "Pessoa",
                SolicitacaoServico = "123",
                TipoAssunto = true,
                TipoPedido = "Pedido",
                txtTipoInscricao = "Juridica"
            };

            this.CarregarTela<ProtocoloModel>(model);


        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public class ProtocoloModel
        {
            public bool TipoAssunto { get; set; }
            public DateTime DataCadastro { get; set; }
            public string RegistroConselho { get; set; }
            public string NumeroProcesso { get; set; }
            public string SolicitacaoServico { get; set; }
            public string Protocolo { get; set; }
            public string Remetente { get; set; }
            public string txtTipoInscricao { get; set; }
            public string TipoPedido { get; set; }
        }

        private void lblRemetente_Click(object sender, EventArgs e)
        {

        }

        private void lblOrigem_Click(object sender, EventArgs e)
        {

        }
    }
}
