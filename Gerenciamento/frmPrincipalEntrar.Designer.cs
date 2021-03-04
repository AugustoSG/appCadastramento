namespace Gerenciamento
{
    partial class frmPrincipalEntrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalEntrar));
            this.lbDigitarEmail = new System.Windows.Forms.Label();
            this.lbDigitarSenha = new System.Windows.Forms.Label();
            this.txt_CampoEmail = new System.Windows.Forms.TextBox();
            this.txt_CampoSenha = new System.Windows.Forms.TextBox();
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.btn_Carregar = new System.Windows.Forms.Button();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDigitarEmail
            // 
            this.lbDigitarEmail.AutoSize = true;
            this.lbDigitarEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDigitarEmail.Location = new System.Drawing.Point(116, 62);
            this.lbDigitarEmail.Name = "lbDigitarEmail";
            this.lbDigitarEmail.Size = new System.Drawing.Size(92, 17);
            this.lbDigitarEmail.TabIndex = 1;
            this.lbDigitarEmail.Text = "Digitar E-mail";
            // 
            // lbDigitarSenha
            // 
            this.lbDigitarSenha.AutoSize = true;
            this.lbDigitarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDigitarSenha.Location = new System.Drawing.Point(114, 115);
            this.lbDigitarSenha.Name = "lbDigitarSenha";
            this.lbDigitarSenha.Size = new System.Drawing.Size(94, 17);
            this.lbDigitarSenha.TabIndex = 3;
            this.lbDigitarSenha.Text = "Digitar Senha";
            // 
            // txt_CampoEmail
            // 
            this.txt_CampoEmail.Location = new System.Drawing.Point(117, 82);
            this.txt_CampoEmail.Name = "txt_CampoEmail";
            this.txt_CampoEmail.Size = new System.Drawing.Size(237, 20);
            this.txt_CampoEmail.TabIndex = 2;
            // 
            // txt_CampoSenha
            // 
            this.txt_CampoSenha.Location = new System.Drawing.Point(117, 135);
            this.txt_CampoSenha.Name = "txt_CampoSenha";
            this.txt_CampoSenha.PasswordChar = '*';
            this.txt_CampoSenha.Size = new System.Drawing.Size(237, 20);
            this.txt_CampoSenha.TabIndex = 4;
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.Location = new System.Drawing.Point(117, 171);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Entrar.TabIndex = 5;
            this.btn_Entrar.Text = "Entrar";
            this.btn_Entrar.UseVisualStyleBackColor = true;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // btn_Carregar
            // 
            this.btn_Carregar.Location = new System.Drawing.Point(198, 171);
            this.btn_Carregar.Name = "btn_Carregar";
            this.btn_Carregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Carregar.TabIndex = 6;
            this.btn_Carregar.Text = "Carregar";
            this.btn_Carregar.UseVisualStyleBackColor = true;
            this.btn_Carregar.Click += new System.EventHandler(this.btn_Carregar_Click);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Fechar.Location = new System.Drawing.Point(279, 171);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_Fechar.TabIndex = 7;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // frmPrincipalEntrar
            // 
            this.AcceptButton = this.btn_Entrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CancelButton = this.btn_Fechar;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.btn_Carregar);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(this.txt_CampoSenha);
            this.Controls.Add(this.txt_CampoEmail);
            this.Controls.Add(this.lbDigitarSenha);
            this.Controls.Add(this.lbDigitarEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipalEntrar";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDigitarEmail;
        private System.Windows.Forms.Label lbDigitarSenha;
        private System.Windows.Forms.TextBox txt_CampoSenha;
        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.Button btn_Fechar;
        public System.Windows.Forms.Button btn_Carregar;
        public System.Windows.Forms.TextBox txt_CampoEmail;
    }
}