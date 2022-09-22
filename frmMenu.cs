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
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            dgvPrincipal.Rows.Clear();
            new PessoaRepository(new AppDBContext()).BuscarTodos().ToList().OrderBy(x => x.Nome).ToList()
                .ForEach(x => dgvPrincipal.Rows
                .Add(x.Id,
                x.Nome, 
                x.CPFCNPJ,
                x.DataNascimentoFundacao > DateTime.MinValue ? x.DataNascimentoFundacao.ToString("dd/MM/yyyy") : "", 
                x.MunicipioComercial + " / " + x.MunicipioResidencial));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Fiscalizacao.DAO.SincronizarBase().Iniciar();
            frmMenu_Load(sender, e);
        }
  

        private void dgvPrincipal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = (sender as DataGridView).Rows[e.RowIndex].Cells[0].Value.ToString();
            new frmCadastros(id).ShowDialog();
        }
    }
}
