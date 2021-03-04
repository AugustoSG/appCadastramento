namespace Gerenciamento
{
    partial class frmPrincipalMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalMenu));
            this.btnGerenciarUsuarios = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGerenciarUsuarios
            // 
            this.btnGerenciarUsuarios.Location = new System.Drawing.Point(68, 106);
            this.btnGerenciarUsuarios.Name = "btnGerenciarUsuarios";
            this.btnGerenciarUsuarios.Size = new System.Drawing.Size(80, 50);
            this.btnGerenciarUsuarios.TabIndex = 1;
            this.btnGerenciarUsuarios.Text = "Gerenciar Usuários";
            this.btnGerenciarUsuarios.UseVisualStyleBackColor = true;
            this.btnGerenciarUsuarios.Click += new System.EventHandler(this.btnGerenciarUsuários_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(240, 106);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(80, 50);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(326, 106);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(80, 50);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.Location = new System.Drawing.Point(154, 106);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(80, 50);
            this.btnCalculadora.TabIndex = 4;
            this.btnCalculadora.Text = "Calculadora";
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // frmPrincipalMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btnCalculadora);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerenciarUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipalMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnFechar;
        public System.Windows.Forms.Button btnGerenciarUsuarios;
        public System.Windows.Forms.Button btnCalculadora;
    }
}