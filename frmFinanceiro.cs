using Fiscalizacao.Models;
using Fiscalizacao.Repository;
using System;
using System.Windows.Forms;

namespace Fiscalizacao
{
    public partial class frmFinanceiro : Form
    {
        FinanceiroRepository financeiroRepository;
        FinanceiroModel model = null;
        public frmFinanceiro(int id)
        {
            financeiroRepository = new FinanceiroRepository(new AppDBContext());
            model = financeiroRepository.BuscarPorId(id);
            InitializeComponent();
        }

        private void frmFinanceiro_Load(object sender, EventArgs e)
        {
            this.CarregarTela(model);
            this.Pessoa.Text = model.Pessoa.Nome;
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

