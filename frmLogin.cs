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

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.ToLower() == "adm" && txtSenha.Text == "adm")
            {
              var form  = new frmMenu();
                form.Show();
                form.FormClosed += MostrarLogin;

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha Incorretos");
            }

        }
        private void MostrarLogin(object sender, FormClosedEventArgs e)
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
            this.Show();

        }

    }
}
