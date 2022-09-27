using Fiscalizacao.Repository;
using Fiscalizacao.Models;
using System;
using System.Windows.Forms;

namespace Fiscalizacao
{
    public partial class frmProtocolo : Form
    {
        ProtocoloRepository protocoloRepository;
        ProtocoloModel model = null;

        public frmProtocolo(int id)
        {
            protocoloRepository = new ProtocoloRepository(new AppDBContext());
            model = protocoloRepository.BuscarPorId(id);
            InitializeComponent();
        }


        private void frmProtocolo_Load(object sender, EventArgs e)
        {
            this.CarregarTela(model);

        }
        private void dgvProtocolos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new frmProtocolo().ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public frmProtocolo()
        {
        }

    }
}
