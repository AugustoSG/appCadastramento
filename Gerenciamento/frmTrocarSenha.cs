using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento
{
    public partial class frmTrocarSenha : Form
    {
        public frmTrocarSenha()
        {
            InitializeComponent();

        }           
        
        clsConexaoBanco objclsConexaoBanco = new clsConexaoBanco();
        SqlConnection objsqlConnection = new SqlConnection();
        SqlCommand objsqlCommand = new SqlCommand();
        SqlDataReader objsqlDataReader;
        frmPrincipalEntrar objfrmPrincipalEntrar = new frmPrincipalEntrar();

        private void btn_Trocar_Click(object sender, EventArgs e)

        {
            try
            {
                if (txtNovaSenha.Text == "senha")
                {
                    MessageBox.Show("Senha repetida", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (txtConfirmeSenha.Text != txtNovaSenha.Text)
                {
                    MessageBox.Show("As senha estão diferentes", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    objsqlConnection.ConnectionString = objclsConexaoBanco.caminho;
                    objsqlConnection.Open();
                    objsqlCommand.Connection = objsqlConnection;
                    objsqlCommand.CommandText = "UPDATE TbUsuarios SET usuario_Senha = '" + txtNovaSenha.Text + "' WHERE usuario_email = '" + txtPrimeiroAcessoEmail.Text + "'";
                    objsqlDataReader = objsqlCommand.ExecuteReader();           
                }
                if ((txtNovaSenha.Text != "senha") && (txtConfirmeSenha.Text == txtNovaSenha.Text))
                {
                    MessageBox.Show("Senha alterada com sucesso", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    objsqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
