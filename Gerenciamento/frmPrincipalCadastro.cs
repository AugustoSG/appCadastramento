using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento
{
    public partial class frmPrincipalCadastro : Form

    {
        clsConexaoBanco objclsConexaoBanco = new clsConexaoBanco();
        SqlConnection objsqlConexao = new SqlConnection();
        SqlCommand objsqlCommand = new SqlCommand();
        SqlDataReader objsqlDataReader;

        public frmPrincipalCadastro()
        {
            InitializeComponent();
            LimparDados();
        }

        private void picImagemCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                var imagem = opnImagemUsuario;

                imagem.Filter = ("Image Files | *.png; *.bmp; *.jpg; *.jpeg; *.gif;");
                imagem.FilterIndex = 4;

                opnImagemUsuario.FileName = "";

                if (opnImagemUsuario.ShowDialog() == DialogResult.OK)
                {
                    picImagemCadastro.Image = Image.FromFile(opnImagemUsuario.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            frmPrincipalUsuários objfrmPrincipalUsuários = new frmPrincipalUsuários();

            objfrmPrincipalUsuários.Show();

            this.Hide();
        }

        private void btbNovo_Click(object sender, EventArgs e)
        {
            LimparDados();
            InserirDados();
         
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            frmPrincipalMenu objfrmPrincipalMenu = new frmPrincipalMenu();

            objfrmPrincipalMenu.Show();

            this.Hide();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNomeCompleto.Text == "")
            {
                MessageBox.Show("Informe seu Nome Completo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeCompleto.Focus();
                return;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Informe seu Email.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (txtSenha.Text == "")
            {
                MessageBox.Show("Informe sua Senha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return;
            }
            if (cbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Informe o seu cargo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return;
            }
            if (mtbTelefone.Text == "")
            {
                MessageBox.Show("Informe seu Número de Contato.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return;
            }
            try
            {
                objsqlConexao.ConnectionString = objclsConexaoBanco.caminho;
                objsqlConexao.Open();
                objsqlCommand.Connection = objsqlConexao;
                objsqlCommand.CommandText = "SELECT usuario_email FROM TbUsuarios Where usuario_email = '" + txtEmail.Text + "'";
                objsqlDataReader = objsqlCommand.ExecuteReader();

                if (objsqlDataReader.HasRows)
                {
                    MessageBox.Show("Esse email já existe.\nEscolha outro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    objsqlDataReader.Close();
                    objsqlCommand.CommandText = "INSERT into TbUsuarios (usuario_NomeCompleto, usuario_email, usuario_Senha, usuario_Tipo, usuario_Telefone, usuario_DataCadastro, usuario_Imagem) VALUES ('" + txtNomeCompleto.Text + "','" + txtEmail.Text + "','" + txtSenha.Text + "','" + cbTipo.Text + "','" + mtbTelefone.Text + "','" + System.DateTime.Now + "', @usuario_Imagem)";

                    MemoryStream objMemoryStream = new MemoryStream();
                    picImagemCadastro.Image.Save(objMemoryStream, System.Drawing.Imaging.ImageFormat.Png);
                    objMemoryStream.Seek(0, System.IO.SeekOrigin.Begin);
                    byte[] imagebyte = new byte[objMemoryStream.Length];
                    objMemoryStream.Read(imagebyte, 0, System.Convert.ToInt32(objMemoryStream.Length));

                    SqlParameter objsqlParameterusuario_Imagem = new SqlParameter("@usuario_Imagem", SqlDbType.Image);
                    objsqlParameterusuario_Imagem.Value = imagebyte;
                    objsqlCommand.Parameters.Add(objsqlParameterusuario_Imagem);

                    objsqlCommand.ExecuteReader();
                    objsqlCommand.Parameters.Clear();
                    LimparDados();
                    MessageBox.Show("Usuário cadastrado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (objsqlConexao.State == ConnectionState.Open)
                {
                    objsqlConexao.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                objsqlConexao.ConnectionString = objclsConexaoBanco.caminho;
                objsqlConexao.Open();
                objsqlCommand.Connection = objsqlConexao;
                objsqlCommand.CommandText = "SELECT usuarioID FROM TbUsuarios Where usuarioID <> '" + txtId + "' AND usuario_email = '" + txtEmail.Text + "'";
                objsqlDataReader = objsqlCommand.ExecuteReader();

                if (objsqlDataReader.HasRows)
                {
                    MessageBox.Show("Esse email já existe.\nEscolha outro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    objsqlDataReader.Close();
                    objsqlCommand.CommandText = "UPDATE TbUsuarios SET usuario_NomeCompleto = '" + txtNomeCompleto.Text + "',  usuario_email = '" + txtEmail.Text + "',  usuario_Senha = '" + txtSenha.Text + "',  usuario_Tipo = '" + cbTipo.Text + "', usuario_Telefone = '" + mtbTelefone.Text + "', usuario_Imagem = @usuario_Imagem WHERE usuarioID = '" + txtId.Text + "'";

                    MemoryStream objMemoryStream = new MemoryStream();
                    picImagemCadastro.Image.Save(objMemoryStream, System.Drawing.Imaging.ImageFormat.Png);
                    objMemoryStream.Seek(0, System.IO.SeekOrigin.Begin);
                    byte[] imagebyte = new byte[objMemoryStream.Length];
                    objMemoryStream.Read(imagebyte, 0, System.Convert.ToInt32(objMemoryStream.Length));

                    SqlParameter objsqlParameterusuario_Imagem = new SqlParameter("@usuario_Imagem", SqlDbType.Image);
                    objsqlParameterusuario_Imagem.Value = imagebyte;
                    objsqlCommand.Parameters.Add(objsqlParameterusuario_Imagem);

                    objsqlCommand.ExecuteReader();
                    objsqlCommand.Parameters.Clear();
                    LimparDados();
                    MessageBox.Show("Usuário cadastrado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (objsqlConexao.State == ConnectionState.Open)
                {
                    objsqlConexao.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir esse usuário?", "Confimação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    objsqlConexao.ConnectionString = objclsConexaoBanco.caminho;
                    objsqlConexao.Open();
                    objsqlCommand.Connection = objsqlConexao;
                    objsqlCommand.CommandText = "DELETE FROM TbUsuarios Where usuarioID = '" + txtId.Text + "'";
                    objsqlDataReader = objsqlCommand.ExecuteReader();
                    MessageBox.Show("Usuário excluido com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparDados();

                    if (objsqlConexao.State == ConnectionState.Open)
                    {
                        objsqlConexao.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void LimparDados()
        {
            picImagemCadastro.Image = null;
            picImagemCadastro.Enabled = false;
            txtId.Enabled = false;
            txtId.Text = "";
            txtNomeCompleto.Enabled = false;
            txtNomeCompleto.Text = "";
            txtEmail.Enabled = false;
            txtEmail.Text = "";
            txtSenha.Enabled = false;
            txtSenha.Text = "";
            txtEmail.Text = "";
            cbTipo.SelectedIndex = -1;
            cbTipo.Enabled = false;
            mtbTelefone.Enabled = false;
            mtbTelefone.Text = "";
            mtbData.Enabled = false;
            mtbData.Text = "";
            btnInserir.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            this.AcceptButton = btnNovo;
        }

        private void InserirDados()
        {
            txtNomeCompleto.Enabled = true;
            txtNomeCompleto.Focus();
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
            cbTipo.Enabled = true;
            mtbTelefone.Enabled = true;
            mtbData.Text = System.DateTime.Now.ToString();
            picImagemCadastro.Enabled = true;
            picImagemCadastro.Image = Properties.Resources.couple256;
            btnInserir.Enabled = true;
            this.AcceptButton = btnInserir;
        }
    }
}
