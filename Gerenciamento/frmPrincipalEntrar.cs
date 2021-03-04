using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento
{
    public partial class frmPrincipalEntrar : Form
    {
        public frmPrincipalEntrar()
        {
            InitializeComponent();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            if (txt_CampoEmail.Text == "")
            {
                MessageBox.Show("Informe o nome do usuário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_CampoEmail.Focus();
                return;
            }
                 
            if (txt_CampoSenha.Text == "")
            {
                MessageBox.Show("Informe a senha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_CampoSenha.Focus();
                return;
            }

            try
            {
                clsConexaoBanco objclsstringConexaoBanco = new clsConexaoBanco();

                SqlConnection objsqlConnection = new SqlConnection(objclsstringConexaoBanco.caminho);
                objsqlConnection.Open();

                SqlCommand objsqlCommand = new SqlCommand("SELECT usuarioID, usuario_NomeCompleto, usuario_email, usuario_Senha, usuario_Tipo FROM tbUsuarios WHERE usuario_email = '" + txt_CampoEmail.Text + "' AND usuario_Senha = '" + txt_CampoSenha.Text + "'", objsqlConnection);

                SqlDataReader objsqlDataReader = objsqlCommand.ExecuteReader();

                if (objsqlDataReader.HasRows)
                {
                    objsqlDataReader.Read();

                    if (objsqlDataReader["usuario_Senha"].ToString() == "senha")
                    {
                        frmTrocarSenha objfrmTrocarSenha = new frmTrocarSenha();
                        objfrmTrocarSenha.ShowDialog();
                        txt_CampoSenha.Clear();
                    }
                                        
                    else {

                        frmPrincipalMenu objfrmPrincipalMenu = new frmPrincipalMenu();
                    
                        if (objsqlDataReader["usuario_Tipo"].ToString() == "Vendedor")
                        {
                            objfrmPrincipalMenu.btnGerenciarUsuarios.Enabled = false;
                        }

                        objfrmPrincipalMenu.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha inválido, tente novamente ou consulte o Administrador do Sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txt_CampoEmail.Clear();
                    txt_CampoSenha.Clear();
                    txt_CampoEmail.Focus();
                }
                if (objsqlConnection.State == ConnectionState.Open)
                {
                    objsqlConnection.Close();
                }
                objsqlConnection.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Encaminhe a mensagem de erro abaixo ao administrador do sitema: \n \n " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Carregar_Click(object sender, EventArgs e)
        {
            frmAberturaPrincipal objfrmAberturaPrincipal = new frmAberturaPrincipal();
            objfrmAberturaPrincipal.Show();
            this.Close();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
