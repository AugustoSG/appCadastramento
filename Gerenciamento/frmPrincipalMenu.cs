using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora;

namespace Gerenciamento
{
    public partial class frmPrincipalMenu : Form
    {
        public frmPrincipalMenu()
        {
            InitializeComponent();
        }

        private void btnGerenciarUsuários_Click(object sender, EventArgs e)
        {
            frmPrincipalCadastro objfrmPrincipalCadastro = new frmPrincipalCadastro();

            objfrmPrincipalCadastro.Show();

            this.Hide();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            Calculadora.frm_Padrão objfrm_Padrão = new frm_Padrão();

            objfrm_Padrão.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmPrincipalEntrar objfrmPrincipalEntrar = new frmPrincipalEntrar();

            objfrmPrincipalEntrar.Show();

            this.Hide();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
