namespace Gerenciamento
{
    partial class frmPrincipalCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalCadastro));
            this.lbId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.lbNomeCompleto = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lbTipo = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbDataCadastro = new System.Windows.Forms.Label();
            this.picImagemCadastro = new System.Windows.Forms.PictureBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.opnImagemUsuario = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(305, 17);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 13);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(308, 33);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(181, 20);
            this.txtId.TabIndex = 23;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(505, 31);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 6;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(505, 70);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btbNovo_Click);
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(308, 72);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(181, 20);
            this.txtNomeCompleto.TabIndex = 1;
            // 
            // lbNomeCompleto
            // 
            this.lbNomeCompleto.AutoSize = true;
            this.lbNomeCompleto.Location = new System.Drawing.Point(305, 56);
            this.lbNomeCompleto.Name = "lbNomeCompleto";
            this.lbNomeCompleto.Size = new System.Drawing.Size(82, 13);
            this.lbNomeCompleto.TabIndex = 4;
            this.lbNomeCompleto.Text = "Nome Completo";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(505, 109);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 8;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(308, 111);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(305, 95);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 7;
            this.lbEmail.Text = "E-mail";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(505, 148);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(308, 150);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(181, 20);
            this.txtSenha.TabIndex = 3;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(305, 134);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(38, 13);
            this.lbSenha.TabIndex = 10;
            this.lbSenha.Text = "Senha";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(505, 187);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(305, 173);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(28, 13);
            this.lbTipo.TabIndex = 13;
            this.lbTipo.Text = "Tipo";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(505, 226);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 11;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(305, 212);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(49, 13);
            this.lbTelefone.TabIndex = 16;
            this.lbTelefone.Text = "Telefone";
            // 
            // lbDataCadastro
            // 
            this.lbDataCadastro.AutoSize = true;
            this.lbDataCadastro.Location = new System.Drawing.Point(305, 256);
            this.lbDataCadastro.Name = "lbDataCadastro";
            this.lbDataCadastro.Size = new System.Drawing.Size(90, 13);
            this.lbDataCadastro.TabIndex = 19;
            this.lbDataCadastro.Text = "Data do Cadastro";
            // 
            // picImagemCadastro
            // 
            this.picImagemCadastro.ErrorImage = null;
            this.picImagemCadastro.Image = global::Gerenciamento.Properties.Resources.couple256;
            this.picImagemCadastro.Location = new System.Drawing.Point(31, 31);
            this.picImagemCadastro.Name = "picImagemCadastro";
            this.picImagemCadastro.Size = new System.Drawing.Size(259, 247);
            this.picImagemCadastro.TabIndex = 0;
            this.picImagemCadastro.TabStop = false;
            this.picImagemCadastro.Click += new System.EventHandler(this.picImagemCadastro_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Vendedor",
            "Diretor"});
            this.cbTipo.Location = new System.Drawing.Point(308, 189);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(181, 21);
            this.cbTipo.TabIndex = 4;
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(308, 229);
            this.mtbTelefone.Mask = "(99) 00000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(181, 20);
            this.mtbTelefone.TabIndex = 5;
            // 
            // mtbData
            // 
            this.mtbData.Location = new System.Drawing.Point(308, 272);
            this.mtbData.Mask = "00/00/0000 90:00";
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(181, 20);
            this.mtbData.TabIndex = 22;
            this.mtbData.ValidatingType = typeof(System.DateTime);
            // 
            // opnImagemUsuario
            // 
            this.opnImagemUsuario.FileName = "opnImagemUsuario";
            // 
            // frmPrincipalCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(614, 311);
            this.Controls.Add(this.mtbData);
            this.Controls.Add(this.mtbTelefone);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.lbDataCadastro);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.lbNomeCompleto);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.picImagemCadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipalCadastro";
            this.Text = "Gerenciamento de Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.picImagemCadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lbNomeCompleto;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbDataCadastro;
        private System.Windows.Forms.OpenFileDialog opnImagemUsuario;
        public System.Windows.Forms.Button btnInserir;
        public System.Windows.Forms.Button btnAlterar;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TextBox txtNomeCompleto;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtSenha;
        public System.Windows.Forms.ComboBox cbTipo;
        public System.Windows.Forms.MaskedTextBox mtbTelefone;
        public System.Windows.Forms.MaskedTextBox mtbData;
        public System.Windows.Forms.PictureBox picImagemCadastro;
    }
}