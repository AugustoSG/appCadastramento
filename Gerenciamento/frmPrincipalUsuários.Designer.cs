namespace Gerenciamento
{
    partial class frmPrincipalUsuários
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalUsuários));
            this.lbProcurarNome = new System.Windows.Forms.Label();
            this.txtProcurarNome = new System.Windows.Forms.TextBox();
            this.txtProcurarEmail = new System.Windows.Forms.TextBox();
            this.lbProcurarEmail = new System.Windows.Forms.Label();
            this.lbProcurarTipo = new System.Windows.Forms.Label();
            this.dgvUsuários = new System.Windows.Forms.DataGridView();
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clImagem = new System.Windows.Forms.DataGridViewImageColumn();
            this.loginUsuarioDataSet = new Gerenciamento.LoginUsuarioDataSet();
            this.cbProcurarTipo = new System.Windows.Forms.ComboBox();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.tbUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbUsuariosTableAdapter = new Gerenciamento.LoginUsuarioDataSetTableAdapters.TbUsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuários)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginUsuarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProcurarNome
            // 
            this.lbProcurarNome.AutoSize = true;
            this.lbProcurarNome.Location = new System.Drawing.Point(30, 25);
            this.lbProcurarNome.Name = "lbProcurarNome";
            this.lbProcurarNome.Size = new System.Drawing.Size(94, 13);
            this.lbProcurarNome.TabIndex = 1;
            this.lbProcurarNome.Text = "Procurar por nome";
            // 
            // txtProcurarNome
            // 
            this.txtProcurarNome.Location = new System.Drawing.Point(33, 42);
            this.txtProcurarNome.Name = "txtProcurarNome";
            this.txtProcurarNome.Size = new System.Drawing.Size(153, 20);
            this.txtProcurarNome.TabIndex = 2;
            this.txtProcurarNome.TextChanged += new System.EventHandler(this.txtProcurarNome_TextChanged);
            // 
            // txtProcurarEmail
            // 
            this.txtProcurarEmail.Location = new System.Drawing.Point(279, 42);
            this.txtProcurarEmail.Name = "txtProcurarEmail";
            this.txtProcurarEmail.Size = new System.Drawing.Size(158, 20);
            this.txtProcurarEmail.TabIndex = 4;
            this.txtProcurarEmail.TextChanged += new System.EventHandler(this.txtProcurarEmail_TextChanged);
            // 
            // lbProcurarEmail
            // 
            this.lbProcurarEmail.AutoSize = true;
            this.lbProcurarEmail.Location = new System.Drawing.Point(276, 25);
            this.lbProcurarEmail.Name = "lbProcurarEmail";
            this.lbProcurarEmail.Size = new System.Drawing.Size(95, 13);
            this.lbProcurarEmail.TabIndex = 3;
            this.lbProcurarEmail.Text = "Procurar por e-mail";
            // 
            // lbProcurarTipo
            // 
            this.lbProcurarTipo.AutoSize = true;
            this.lbProcurarTipo.Location = new System.Drawing.Point(503, 25);
            this.lbProcurarTipo.Name = "lbProcurarTipo";
            this.lbProcurarTipo.Size = new System.Drawing.Size(85, 13);
            this.lbProcurarTipo.TabIndex = 5;
            this.lbProcurarTipo.Text = "Procurar por tipo";
            // 
            // dgvUsuários
            // 
            this.dgvUsuários.AllowUserToOrderColumns = true;
            this.dgvUsuários.AllowUserToResizeColumns = false;
            this.dgvUsuários.AllowUserToResizeRows = false;
            this.dgvUsuários.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvUsuários.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuários.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvUsuários.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuários.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvUsuários.ColumnHeadersHeight = 22;
            this.dgvUsuários.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsuários.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clID,
            this.clNome,
            this.clEmail,
            this.clSenha,
            this.clTipo,
            this.clTelefone,
            this.clDataCadastro,
            this.clImagem});
            this.dgvUsuários.EnableHeadersVisualStyles = false;
            this.dgvUsuários.GridColor = System.Drawing.Color.DarkGray;
            this.dgvUsuários.Location = new System.Drawing.Point(33, 80);
            this.dgvUsuários.Name = "dgvUsuários";
            this.dgvUsuários.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvUsuários.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvUsuários.RowHeadersVisible = false;
            this.dgvUsuários.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvUsuários.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuários.Size = new System.Drawing.Size(631, 340);
            this.dgvUsuários.TabIndex = 4;
            this.dgvUsuários.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuários_CellDoubleClick);
            // 
            // clID
            // 
            this.clID.HeaderText = "ID";
            this.clID.Name = "clID";
            this.clID.Visible = false;
            // 
            // clNome
            // 
            this.clNome.HeaderText = "Nome";
            this.clNome.Name = "clNome";
            // 
            // clEmail
            // 
            this.clEmail.HeaderText = "Email";
            this.clEmail.Name = "clEmail";
            // 
            // clSenha
            // 
            this.clSenha.HeaderText = "Senha";
            this.clSenha.Name = "clSenha";
            this.clSenha.Visible = false;
            // 
            // clTipo
            // 
            this.clTipo.HeaderText = "Tipo";
            this.clTipo.Name = "clTipo";
            // 
            // clTelefone
            // 
            this.clTelefone.HeaderText = "Telefone";
            this.clTelefone.Name = "clTelefone";
            // 
            // clDataCadastro
            // 
            this.clDataCadastro.FillWeight = 120F;
            this.clDataCadastro.HeaderText = "Data do Cadastro";
            this.clDataCadastro.Name = "clDataCadastro";
            // 
            // clImagem
            // 
            this.clImagem.HeaderText = "Imagem";
            this.clImagem.Name = "clImagem";
            // 
            // loginUsuarioDataSet
            // 
            this.loginUsuarioDataSet.DataSetName = "LoginUsuarioDataSet";
            this.loginUsuarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbProcurarTipo
            // 
            this.cbProcurarTipo.FormattingEnabled = true;
            this.cbProcurarTipo.Items.AddRange(new object[] {
            "Vendedor",
            "Diretor"});
            this.cbProcurarTipo.Location = new System.Drawing.Point(506, 40);
            this.cbProcurarTipo.Name = "cbProcurarTipo";
            this.cbProcurarTipo.Size = new System.Drawing.Size(158, 21);
            this.cbProcurarTipo.TabIndex = 6;
            this.cbProcurarTipo.SelectedIndexChanged += new System.EventHandler(this.cbProcurarTipo_SelectedIndexChanged);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Location = new System.Drawing.Point(589, 426);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_Fechar.TabIndex = 8;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // tbUsuariosBindingSource
            // 
            this.tbUsuariosBindingSource.DataMember = "TbUsuarios";
            this.tbUsuariosBindingSource.DataSource = this.loginUsuarioDataSet;
            // 
            // tbUsuariosTableAdapter
            // 
            this.tbUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // frmPrincipalUsuários
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(714, 461);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.cbProcurarTipo);
            this.Controls.Add(this.dgvUsuários);
            this.Controls.Add(this.lbProcurarTipo);
            this.Controls.Add(this.txtProcurarEmail);
            this.Controls.Add(this.lbProcurarEmail);
            this.Controls.Add(this.txtProcurarNome);
            this.Controls.Add(this.lbProcurarNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipalUsuários";
            this.Text = "Usuários Cadastrados";
            this.Load += new System.EventHandler(this.frmPrincipalUsuários_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuários)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginUsuarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbProcurarNome;
        private System.Windows.Forms.TextBox txtProcurarNome;
        private System.Windows.Forms.TextBox txtProcurarEmail;
        private System.Windows.Forms.Label lbProcurarEmail;
        private System.Windows.Forms.Label lbProcurarTipo;
        private System.Windows.Forms.DataGridView dgvUsuários;
        private System.Windows.Forms.ComboBox cbProcurarTipo;
        private System.Windows.Forms.Button btn_Fechar;
        private LoginUsuarioDataSet loginUsuarioDataSet;
        private System.Windows.Forms.BindingSource tbUsuariosBindingSource;
        private LoginUsuarioDataSetTableAdapters.TbUsuariosTableAdapter tbUsuariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSenha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDataCadastro;
        private System.Windows.Forms.DataGridViewImageColumn clImagem;
    }
}