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
        }

        private void GridInscricoes()
        {
            dgvInscricoes.Rows.Clear();
            foreach (var item in model.Inscricao)
            {
                dgvInscricoes.Rows.Add(item.TipoInscricao, item.Situacao, item.DataInicial.ToString("dd/MM/yyyy"), item.DataFinal > DateTime.MinValue ? item.DataFinal.ToString("dd/MM/yyyy") : "");
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
        private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new frmFinanceiro().ShowDialog();
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
    }
}