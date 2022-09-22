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
    public partial class frmTramitesProcessuais : Form
    {
        public frmTramitesProcessuais()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTramitesProcessuais_Load(object sender, EventArgs e)
        {

        }
    }
}
