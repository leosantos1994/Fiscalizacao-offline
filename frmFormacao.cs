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
    public partial class frmFormacao : Form
    {
        public frmFormacao()
        {
            InitializeComponent();
        }
        private void frmFormacao_Load(object sender, EventArgs e)
        {
            AdicionarDadosFicticiosGridFormacao();
        }
        private void AdicionarDadosFicticiosGridFormacao()
        {
            TipoInscricao.Text = "Principal";
            RegistroConselho.Text = "123456";
            DataInicial.Text = "20/05/2021";
            DataFinal.Text = "20/05/2022";
            DataAcordao.Text = "20/05/2022";
            DataCompromisso.Text = "25/10/2021";
            Livro.Text = "A1";
            Folha.Text = "123";
            Especialidade.Text = "Quimica";
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
