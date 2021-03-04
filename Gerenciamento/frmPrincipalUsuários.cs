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
    public partial class frmPrincipalUsuários : Form

    {
        clsConexaoBanco objclsStringConexao = new clsConexaoBanco();
        SqlCommand objsqlCommand = new SqlCommand();
        SqlDataReader objsqlDataReader;
        string procurar;

        public frmPrincipalUsuários()
        {
            InitializeComponent();
        }
        private void frmPrincipalUsuários_Load(object sender, EventArgs e)
        {
            preencherDataGridView();
        }

        private void txtProcurarNome_TextChanged(object sender, EventArgs e)
        {
            txtProcurarEmail.Text = "";
            cbProcurarTipo.SelectedIndex = -1;
            procurar = "nome";
            preencherDataGridView();
        }

        private void txtProcurarEmail_TextChanged(object sender, EventArgs e)
        {
            txtProcurarNome.Text = "";
            cbProcurarTipo.SelectedIndex = -1;
            procurar = "email";
            preencherDataGridView();
        }

        private void cbProcurarTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProcurarNome.Text = "";
            txtProcurarEmail.Text = "";
            procurar = "tipo";
            preencherDataGridView();
        }

        private void dgvUsuários_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow objdataGridViewRow = dgvUsuários.SelectedRows[0];
                frmPrincipalCadastro objfrmPrincipalCadastro = new frmPrincipalCadastro();
                objfrmPrincipalCadastro.Show();
                this.Hide();
                objfrmPrincipalCadastro.btnInserir.Enabled = false;
                objfrmPrincipalCadastro.btnAlterar.Enabled = true;
                objfrmPrincipalCadastro.btnExcluir.Enabled = true;
                objfrmPrincipalCadastro.txtId.Enabled = true;
                objfrmPrincipalCadastro.txtId.Text = objdataGridViewRow.Cells[0].Value.ToString();
                objfrmPrincipalCadastro.txtNomeCompleto.Enabled = true;
                objfrmPrincipalCadastro.txtNomeCompleto.Text = objdataGridViewRow.Cells[1].Value.ToString();
                objfrmPrincipalCadastro.txtEmail.Enabled = true;
                objfrmPrincipalCadastro.txtEmail.Text = objdataGridViewRow.Cells[2].Value.ToString();
                objfrmPrincipalCadastro.txtSenha.Enabled = true;
                objfrmPrincipalCadastro.txtSenha.Text = objdataGridViewRow.Cells[3].Value.ToString();
                objfrmPrincipalCadastro.cbTipo.Enabled = true;
                objfrmPrincipalCadastro.cbTipo.Text = objdataGridViewRow.Cells[4].Value.ToString();
                objfrmPrincipalCadastro.mtbTelefone.Enabled = true;
                objfrmPrincipalCadastro.mtbTelefone.Text = objdataGridViewRow.Cells[5].Value.ToString();
                objfrmPrincipalCadastro.mtbData.Enabled = false;
                objfrmPrincipalCadastro.mtbData.Text = objdataGridViewRow.Cells[6].Value.ToString();
                byte[] imageByte = (byte[])objdataGridViewRow.Cells[7].Value;
                MemoryStream objmemoryStream = new MemoryStream(imageByte);
                objfrmPrincipalCadastro.picImagemCadastro.Enabled = true;
                objfrmPrincipalCadastro.picImagemCadastro.Image = Image.FromStream(objmemoryStream);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Encaminhe a mensagem de erro abaixo ao administrador do sitema: \n \n " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            frmPrincipalCadastro objfrmPrincipalCadastro = new frmPrincipalCadastro();
            objfrmPrincipalCadastro.Show();
            this.Close();
        }

        public void preencherDataGridView()
        {
            try
            {
                SqlConnection objsqlConnection = new SqlConnection(objclsStringConexao.caminho);

                objsqlConnection.Open();
                objsqlCommand.Connection = objsqlConnection;

                if (procurar == "nome")
                {
                    objsqlCommand.CommandText = "Select RTRIM (usuarioID), RTRIM (usuario_NomeCompleto), RTRIM (usuario_email), RTRIM (usuario_Senha), RTRIM (usuario_Tipo), RTRIM (usuario_Telefone), RTRIM (usuario_DataCadastro), usuario_Imagem FROM TbUsuarios WHERE usuario_NomeCompleto LIKE '%" + txtProcurarNome.Text + "%' ORDER BY usuario_NomeCompleto";
                }
                else if (procurar == "email")
                {
                    objsqlCommand.CommandText = "Select RTRIM (usuarioID), RTRIM (usuario_NomeCompleto), RTRIM (usuario_email), RTRIM (usuario_Senha), RTRIM (usuario_Tipo), RTRIM (usuario_Telefone), RTRIM (usuario_DataCadastro), usuario_Imagem FROM TbUsuarios WHERE usuario_email LIKE '%" + txtProcurarEmail.Text + "%' ORDER BY usuario_NomeCompleto";
                }
                else if (procurar == "tipo")
                {
                    objsqlCommand.CommandText = "Select RTRIM (usuarioID), RTRIM (usuario_NomeCompleto), RTRIM (usuario_email), RTRIM (usuario_Senha), RTRIM (usuario_Tipo), RTRIM (usuario_Telefone), RTRIM (usuario_DataCadastro), usuario_Imagem FROM TbUsuarios WHERE usuario_Tipo LIKE '" + cbProcurarTipo.Text + "' ORDER BY usuario_NomeCompleto";
                }
                else
                {
                    objsqlCommand.CommandText = "Select RTRIM (usuarioID), RTRIM (usuario_NomeCompleto), RTRIM (usuario_email), RTRIM (usuario_Senha), RTRIM (usuario_Tipo), RTRIM (usuario_Telefone), RTRIM (usuario_DataCadastro), usuario_Imagem FROM TbUsuarios ORDER BY usuario_NomeCompleto";
                }
                
                objsqlDataReader = objsqlCommand.ExecuteReader(CommandBehavior.CloseConnection);

                dgvUsuários.Rows.Clear();

                while (objsqlDataReader.Read() == true)
                {
                    dgvUsuários.Rows.Add(objsqlDataReader[0], objsqlDataReader[1], objsqlDataReader[2], objsqlDataReader[3], objsqlDataReader[4], objsqlDataReader[5], objsqlDataReader[6], objsqlDataReader[7]);
                }

                objsqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Encaminhe a mensagem de erro abaixo ao administrador do sitema: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
