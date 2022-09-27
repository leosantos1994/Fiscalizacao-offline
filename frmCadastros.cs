using Fiscalizacao.Models;
using Fiscalizacao.Repository;
using System;
using System.Windows.Forms;

namespace Fiscalizacao
{
    public partial class frmCadastros : Form
    {
        string id = string.Empty;
        PessoaModel model = null;
        public frmCadastros(string id)
        {
            this.id = id;
            model = new PessoaRepository(new AppDBContext()).BuscarPorId(int.Parse(id));
            InitializeComponent();
        }

        private void Cadastros_Load(object sender, EventArgs e)
        {
            this.CarregarTela(model);
            GridInscricoes();
            GridContatos();
            GridFormacao();
            GridFinanceiro();
            GridOcorrencias();
            GridProtocolos();
        }

        private void GridInscricoes()
        {
            dgvInscricoes.Rows.Clear();
            foreach (var item in model.Inscricao)
            {
                dgvInscricoes.Rows.Add(item.TipoInscricao, item.Situacao, item.DataInicial.ToString("dd/MM/yyyy"), item.DataFinal > DateTime.MinValue ? item.DataFinal.ToString("dd/MM/yyyy") : "");
            }
        }

        private void GridContatos()
        {
            dgvOutrosContatos.Rows.Clear();
            foreach (var item in model.OutrosContatos)
            {
                dgvOutrosContatos.Rows.Add(item.Contato, item.TipoContato, item.Complemento, item.Ramal);
            }
        }

        private void GridFormacao()
        {
            dgvFormacao.Rows.Clear();
            foreach (var item in model.Formacao)
            {
                dgvFormacao.Rows.Add(item.Formacao, item.Especialidade);
            }
        }
        private void GridFinanceiro()
        {
            dgvFinanceiro.Rows.Clear();
            foreach (var item in model.Financeiro)
            {
                dgvFinanceiro.Rows.Add(item.Id, item.Situacao, item.Ano, item.TipoLancamento, item.ValorLiquido, item.ValorBruto);
            }
        }
        private void GridOcorrencias()
        {
            dgvOcorrencias.Rows.Clear();
            foreach (var item in model.Ocorrencia)
            {
                dgvOcorrencias.Rows.Add(item.Id, item.Classificacao,
                    item.Data.ToString("dd/MM/yyyy"),
                    item.DataFim > DateTime.MinValue ? item.DataFim.ToString("dd/MM/yyyy") : "");
            }

        }

        private void GridProtocolos()
        {
            dgvProtocolos.Rows.Clear();
            foreach (var item in model.Protocolo)
            {
                dgvProtocolos.Rows.Add(item.Id, item.Protocolo, item.TipoAssunto,
                    item.DataProtocolo.ToString("dd/MM/yyyy"));          
            }

        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        #region EventoClick
        private void dgvProtocolos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           new frmProtocolo().ShowDialog();
        }
        private void dgvProcessos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new frmProcessos().ShowDialog();
        }
        private void dgvFormacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new frmFormacao().ShowDialog();
        }
        private void dgvOcorrencias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new frmOcorrencias().ShowDialog();
        }
        private void dgvRT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new frmRTeART().ShowDialog();
        }
        private void dvgART_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new frmRTeART().ShowDialog();
        }
        #endregion

        private void dgvFinanceiro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = (sender as DataGridView).Rows[e.RowIndex].Cells[0].Value.ToString();
            new frmFinanceiro(int.Parse(id)).ShowDialog();
        }


        private void Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbpEnderecoResidencial_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefoneComercial_Click(object sender, EventArgs e)
        {

        }

        private void lblCorrespondenciaComercial_Click(object sender, EventArgs e)
        {

        }

        private void lblLogradouroComercial_Click(object sender, EventArgs e)
        {

        }

        private void lblEstadoComercial_Click(object sender, EventArgs e)
        {

        }

        private void TelefoneResidencial_TextChanged(object sender, EventArgs e)
        {

        }
    }
}