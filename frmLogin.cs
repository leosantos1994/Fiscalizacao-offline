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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void TelaLogin_Load(object sender, EventArgs e)
        {
            CarregarCredenciais();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (txtUsuario.Text.ToLower() == "adm" && txtSenha.Text == "adm")
            {
                SalvarCredenciais();
                var form = new frmMenu();
                form.Show();
                form.FormClosed += MostrarLogin;

                this.Hide();
            }
            //else
            //{
            //    MessageBox.Show("Usuário ou Senha Incorretos");
            //}

        }
        private void MostrarLogin(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void SalvarCredenciais()
        {
            Properties.Settings.Default.URL = textBox3.Text;
            Properties.Settings.Default.Usuario = txtUsuario.Text;
            Properties.Settings.Default.Senha = txtSenha.Text;
            Properties.Settings.Default.Save();
        }

        private void CarregarCredenciais()
        {
            textBox3.Text = Properties.Settings.Default.URL;
            txtUsuario.Text = Properties.Settings.Default.Usuario;
            txtSenha.Text = Properties.Settings.Default.Senha;
        }
    }
}
