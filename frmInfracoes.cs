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
    public partial class frmInfracoes : Form
    {
        public frmInfracoes()
        {
            InitializeComponent();
        }
        private void frmInfracoes_Load(object sender, EventArgs e)
        {
            AdicionarDadosFicticios();
        }
        private void AdicionarDadosFicticios()
        {
            Ano.Text = "2022";
            RepresentadoFIS.Text = "João Silva";
            FiscalProcessoFIS.Text = "João Silva";
            MotivoSituacaoProcessoFIS.Text = "Inadimplente";
            PessoaJuridicaProcessoFIS.Text = "João Silva MEI";
            ProcessoFIS.Text = "012345";
            SituacaoProcessoFIS.Text = "Aberto";
            TipoProcessoFIS.Text = "Falta de Registro";
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtInfracoesProcesso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInfracoesAutuado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
