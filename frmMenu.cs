using Fiscalizacao.Models;
using Fiscalizacao.Repository;
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
    public partial class frmMenu : Form
    {
        PessoaRepository pessoaRepository;
        public frmMenu()
        {
            pessoaRepository = new PessoaRepository(new AppDBContext());
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            CarregarGrid(pessoaRepository.BuscarTodos());
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                new Fiscalizacao.DAO.SincronizarBase().Iniciar(Properties.Settings.Default.URL, Properties.Settings.Default.Usuario,
                    Properties.Settings.Default.Senha);

                new Fiscalizacao.DAO.SincronizarBase().IniciarMickey(Properties.Settings.Default.URL, Properties.Settings.Default.Usuario,
                   Properties.Settings.Default.Senha);

                frmMenu_Load(sender, e);
            }
            catch(Exception ex) { MessageBox.Show("Não foi possível sincronizar no momento: \n" + ex.Message, "Erro ao tentar sincronizar"); }
        }

        private void dgvPrincipal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = (sender as DataGridView).Rows[e.RowIndex].Cells[0].Value.ToString();
            new frmCadastros(id).ShowDialog();
        }

        private void CarregarGrid(IEnumerable<PessoaModel> pessoas)
        {
            dgvPrincipal.Rows.Clear();

            pessoas.ToList().OrderBy(x => x.Nome).ToList()
                .ForEach(x => dgvPrincipal.Rows
                .Add(x.Id,
                x.Nome,
                x.CPFCNPJ,
                x.RegistroConselho,
                x.MunicipioComercial + " / " + x.MunicipioResidencial));
        }


        private void txtPesquisaNome_TextChanged(object sender, EventArgs e)
        {
            if (CamposPesquisaVazio())
                frmMenu_Load(sender, e);
            else
                CarregarGrid(pessoaRepository.BuscarTodos(x => x.Nome.Contains(txtPesquisaNome.Text)));
        }

        private void txtPesquisaCPF_TextChanged(object sender, EventArgs e)
        {
            if (CamposPesquisaVazio())
                frmMenu_Load(sender, e);
            else
                CarregarGrid(pessoaRepository.BuscarTodos(x => x.CPFCNPJ == txtPesquisaCPF.Text));

        }

        private void txtPesquisaRegistro_TextChanged(object sender, EventArgs e)
        {
            if (CamposPesquisaVazio())
                frmMenu_Load(sender, e);
            else
                CarregarGrid(pessoaRepository.BuscarTodos(x => x.RegistroConselho == txtPesquisaRegistro.Text));
        }

        private void txtPesquisaCidade_TextChanged(object sender, EventArgs e)
        {
            if (CamposPesquisaVazio())
                frmMenu_Load(sender, e);
            else
                CarregarGrid(pessoaRepository.BuscarTodos(x => x.MunicipioComercial.Contains(txtPesquisaCidade.Text) || x.MunicipioComercial.Contains(txtPesquisaCidade.Text)));
        }

        private bool CamposPesquisaVazio()
        {
            return txtPesquisaCidade.Text == "" && txtPesquisaRegistro.Text == "" && txtPesquisaCPF.Text == "" && txtPesquisaNome.Text == "";
        }
    }
}
