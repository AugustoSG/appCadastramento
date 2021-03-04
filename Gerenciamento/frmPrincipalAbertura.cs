using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento
{
    public partial class frmAberturaPrincipal : Form
    {
        public frmAberturaPrincipal()
        {
            InitializeComponent();
        }

        private void tmTimer_Tick(object sender, EventArgs e)
        {
            frmPrincipalEntrar objfrmPrincipalEntrar = new frmPrincipalEntrar();

            pbBarraAbertura.Visible = true;

            this.pbBarraAbertura.Value = pbBarraAbertura.Value + 2;

            if (pbBarraAbertura.Value == 10)
            {
                lbCarregamentoModulos.Text = "10% Carregando Módulos.";
                pbCarregando.Image = Properties.Resources.Seta1;
             }
            else if (pbBarraAbertura.Value == 20)
            {
                lbCarregamentoModulos.Text = "20% Carregando Módulos..";
                pbCarregando.Image = Properties.Resources.Seta2;
            }
            else if (pbBarraAbertura.Value == 30)
            {
                lbCarregamentoModulos.Text = "30% Carregando Módulos...";
                pbCarregando.Image = Properties.Resources.Seta1;
            }
            else if (pbBarraAbertura.Value == 40)
            {
                lbCarregamentoModulos.Text = "40% Carregando Módulos.";
                pbCarregando.Image = Properties.Resources.Seta2;
            }
            else if (pbBarraAbertura.Value == 50)
            {
                lbCarregamentoModulos.Text = "50% Carregando Módulos..";
                pbCarregando.Image = Properties.Resources.Seta1;
            }
            else if (pbBarraAbertura.Value == 60)
            {
                lbCarregamentoModulos.Text = "60% Carregando Módulos...";
                pbCarregando.Image = Properties.Resources.Seta2;
            }
            else if (pbBarraAbertura.Value == 70)
            {
                lbCarregamentoModulos.Text = "70% Carregando Módulos.";
                pbCarregando.Image = Properties.Resources.Seta1;
            }
            else if (pbBarraAbertura.Value == 80)
            {
                lbCarregamentoModulos.Text = "80% Carregando Módulos..";
                pbCarregando.Image = Properties.Resources.Seta2;
            }
            else if (pbBarraAbertura.Value == 90)
            {
                lbCarregamentoModulos.Text = "90% Carregando Módulos...";
                pbCarregando.Image = Properties.Resources.Seta1;
            }
            else if (pbBarraAbertura.Value == 100)
            {
                objfrmPrincipalEntrar.Show();
                tmTimer.Enabled = false;
                this.Hide();
            }
        }
    }
}
