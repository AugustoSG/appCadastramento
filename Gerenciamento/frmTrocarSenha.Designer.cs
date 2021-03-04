namespace Gerenciamento
{
    partial class frmTrocarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrocarSenha));
            this.lbPrimeiroAcesso = new System.Windows.Forms.Label();
            this.btn_Trocar = new System.Windows.Forms.Button();
            this.txtPrimeiroAcessoEmail = new System.Windows.Forms.TextBox();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.lbPrimeiroAcessoEmail = new System.Windows.Forms.Label();
            this.lbNovaSenha = new System.Windows.Forms.Label();
            this.lbConfirmeSenha = new System.Windows.Forms.Label();
            this.txtConfirmeSenha = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPrimeiroAcesso
            // 
            this.lbPrimeiroAcesso.AutoSize = true;
            this.lbPrimeiroAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbPrimeiroAcesso.Location = new System.Drawing.Point(128, 40);
            this.lbPrimeiroAcesso.Name = "lbPrimeiroAcesso";
            this.lbPrimeiroAcesso.Size = new System.Drawing.Size(211, 31);
            this.lbPrimeiroAcesso.TabIndex = 0;
            this.lbPrimeiroAcesso.Text = "Primeiro Acesso";
            // 
            // btn_Trocar
            // 
            this.btn_Trocar.Location = new System.Drawing.Point(134, 214);
            this.btn_Trocar.Name = "btn_Trocar";
            this.btn_Trocar.Size = new System.Drawing.Size(75, 23);
            this.btn_Trocar.TabIndex = 4;
            this.btn_Trocar.Text = "Trocar";
            this.btn_Trocar.UseVisualStyleBackColor = true;
            this.btn_Trocar.Click += new System.EventHandler(this.btn_Trocar_Click);
            // 
            // txtPrimeiroAcessoEmail
            // 
            this.txtPrimeiroAcessoEmail.Location = new System.Drawing.Point(134, 102);
            this.txtPrimeiroAcessoEmail.Name = "txtPrimeiroAcessoEmail";
            this.txtPrimeiroAcessoEmail.Size = new System.Drawing.Size(187, 20);
            this.txtPrimeiroAcessoEmail.TabIndex = 1;
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Location = new System.Drawing.Point(134, 145);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.PasswordChar = '*';
            this.txtNovaSenha.Size = new System.Drawing.Size(187, 20);
            this.txtNovaSenha.TabIndex = 2;
            // 
            // lbPrimeiroAcessoEmail
            // 
            this.lbPrimeiroAcessoEmail.AutoSize = true;
            this.lbPrimeiroAcessoEmail.Location = new System.Drawing.Point(131, 86);
            this.lbPrimeiroAcessoEmail.Name = "lbPrimeiroAcessoEmail";
            this.lbPrimeiroAcessoEmail.Size = new System.Drawing.Size(32, 13);
            this.lbPrimeiroAcessoEmail.TabIndex = 4;
            this.lbPrimeiroAcessoEmail.Text = "Email";
            // 
            // lbNovaSenha
            // 
            this.lbNovaSenha.AutoSize = true;
            this.lbNovaSenha.Location = new System.Drawing.Point(131, 129);
            this.lbNovaSenha.Name = "lbNovaSenha";
            this.lbNovaSenha.Size = new System.Drawing.Size(67, 13);
            this.lbNovaSenha.TabIndex = 5;
            this.lbNovaSenha.Text = "Nova Senha";
            // 
            // lbConfirmeSenha
            // 
            this.lbConfirmeSenha.AutoSize = true;
            this.lbConfirmeSenha.Location = new System.Drawing.Point(131, 170);
            this.lbConfirmeSenha.Name = "lbConfirmeSenha";
            this.lbConfirmeSenha.Size = new System.Drawing.Size(99, 13);
            this.lbConfirmeSenha.TabIndex = 7;
            this.lbConfirmeSenha.Text = "Confime sua Senha";
            // 
            // txtConfirmeSenha
            // 
            this.txtConfirmeSenha.Location = new System.Drawing.Point(134, 186);
            this.txtConfirmeSenha.Name = "txtConfirmeSenha";
            this.txtConfirmeSenha.PasswordChar = '*';
            this.txtConfirmeSenha.Size = new System.Drawing.Size(187, 20);
            this.txtConfirmeSenha.TabIndex = 3;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(246, 214);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmTrocarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lbConfirmeSenha);
            this.Controls.Add(this.txtConfirmeSenha);
            this.Controls.Add(this.lbNovaSenha);
            this.Controls.Add(this.lbPrimeiroAcessoEmail);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.txtPrimeiroAcessoEmail);
            this.Controls.Add(this.btn_Trocar);
            this.Controls.Add(this.lbPrimeiroAcesso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTrocarSenha";
            this.Text = "Trocar a Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPrimeiroAcesso;
        private System.Windows.Forms.Button btn_Trocar;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.Label lbPrimeiroAcessoEmail;
        private System.Windows.Forms.Label lbNovaSenha;
        private System.Windows.Forms.Label lbConfirmeSenha;
        private System.Windows.Forms.TextBox txtConfirmeSenha;
        public System.Windows.Forms.TextBox txtPrimeiroAcessoEmail;
        private System.Windows.Forms.Button btnVoltar;
    }
}