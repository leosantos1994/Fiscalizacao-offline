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
    public partial class frmOcorrencias : Form
    {
        public frmOcorrencias()
        {
            InitializeComponent();
        }

        private void frmOcorrencias_Load(object sender, EventArgs e)
        {
            AdicionarDadosFicticiosGridOcorrencias();
        }
        private void AdicionarDadosFicticiosGridOcorrencias()
        {
            Data.Text = "20/05/2022";
            DataFim.Text = "";
            Classificacao.Text = "";
            OcorrenciaDetalhe.Text = "";
            InscricaoCategoria.Text= "123456";
            Categoria.Text = "QUI";
            ProtocoloLegado.Text = "12345678";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
