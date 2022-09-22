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
    public partial class frmRTeART : Form
    {
        public frmRTeART()
        {
            InitializeComponent();
        }

        private void frmRTeART_Load(object sender, EventArgs e)
        {
            AdicionarDadosFicticiosGridRT();
            AdicionarDadosFicticiosGridART();
        }
        private void AdicionarDadosFicticiosGridRT()
        {
            Pessoa.Text = "João da Silva";
            Contratante.Text = "Luis Da Silva";
            ResponsavelTecnico.Text = "";
            Livro.Text = "ART 1";
            InscricaoCategoria.Text = "12345678";
            ResponsavelTecnico.Text = "João Da Silva";
            
          
        }
        private void AdicionarDadosFicticiosGridART()
        {
            Pessoa.Text = "João da Silva";
            ResponsavelTecnico.Text = "Luis DE Souza";
            Livro.Text = "ART 1";
            InscricaoCategoria.Text = "1234568";
            ResponsavelTecnico.Text = "João Da Silva";
            RegistroConselho.Text = "159159";
            TipoSetorAtuacao.Text = "Quimica";

        }

       

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtProfissionalRT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
