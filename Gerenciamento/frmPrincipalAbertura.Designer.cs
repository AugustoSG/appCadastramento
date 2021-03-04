namespace Gerenciamento
{
    partial class frmAberturaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAberturaPrincipal));
            this.lbSigla = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbVersão = new System.Windows.Forms.Label();
            this.lbCarregamentoModulos = new System.Windows.Forms.Label();
            this.tmTimer = new System.Windows.Forms.Timer(this.components);
            this.pbBarraAbertura = new System.Windows.Forms.ProgressBar();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pbCarregando = new System.Windows.Forms.PictureBox();
            this.pbIconeAbertura = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarregando)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconeAbertura)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSigla
            // 
            this.lbSigla.AutoSize = true;
            this.lbSigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbSigla.Location = new System.Drawing.Point(206, 70);
            this.lbSigla.Name = "lbSigla";
            this.lbSigla.Size = new System.Drawing.Size(94, 31);
            this.lbSigla.TabIndex = 1;
            this.lbSigla.Text = "SIGLA";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbTitulo.Location = new System.Drawing.Point(206, 102);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(112, 31);
            this.lbTitulo.TabIndex = 2;
            this.lbTitulo.Text = "TÍTULO";
            // 
            // lbVersão
            // 
            this.lbVersão.AutoSize = true;
            this.lbVersão.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbVersão.Location = new System.Drawing.Point(209, 133);
            this.lbVersão.Name = "lbVersão";
            this.lbVersão.Size = new System.Drawing.Size(89, 17);
            this.lbVersão.TabIndex = 3;
            this.lbVersão.Text = "Versão 1.0.0";
            // 
            // lbCarregamentoModulos
            // 
            this.lbCarregamentoModulos.AutoSize = true;
            this.lbCarregamentoModulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCarregamentoModulos.Location = new System.Drawing.Point(243, 173);
            this.lbCarregamentoModulos.Name = "lbCarregamentoModulos";
            this.lbCarregamentoModulos.Size = new System.Drawing.Size(184, 17);
            this.lbCarregamentoModulos.TabIndex = 5;
            this.lbCarregamentoModulos.Text = "00% Carregando Módulos...";
            // 
            // tmTimer
            // 
            this.tmTimer.Enabled = true;
            this.tmTimer.Tick += new System.EventHandler(this.tmTimer_Tick);
            // 
            // pbBarraAbertura
            // 
            this.pbBarraAbertura.Location = new System.Drawing.Point(12, 236);
            this.pbBarraAbertura.Name = "pbBarraAbertura";
            this.pbBarraAbertura.Size = new System.Drawing.Size(460, 23);
            this.pbBarraAbertura.TabIndex = 6;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 261);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // pbCarregando
            // 
            this.pbCarregando.Image = global::Gerenciamento.Properties.Resources.Seta2;
            this.pbCarregando.Location = new System.Drawing.Point(209, 166);
            this.pbCarregando.Name = "pbCarregando";
            this.pbCarregando.Size = new System.Drawing.Size(32, 32);
            this.pbCarregando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCarregando.TabIndex = 4;
            this.pbCarregando.TabStop = false;
            // 
            // pbIconeAbertura
            // 
            this.pbIconeAbertura.Image = global::Gerenciamento.Properties.Resources.Edit_Male_User128;
            this.pbIconeAbertura.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbIconeAbertura.InitialImage")));
            this.pbIconeAbertura.Location = new System.Drawing.Point(75, 70);
            this.pbIconeAbertura.Name = "pbIconeAbertura";
            this.pbIconeAbertura.Size = new System.Drawing.Size(128, 128);
            this.pbIconeAbertura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbIconeAbertura.TabIndex = 0;
            this.pbIconeAbertura.TabStop = false;
            // 
            // frmAberturaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pbBarraAbertura);
            this.Controls.Add(this.lbCarregamentoModulos);
            this.Controls.Add(this.pbCarregando);
            this.Controls.Add(this.lbVersão);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.lbSigla);
            this.Controls.Add(this.pbIconeAbertura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAberturaPrincipal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Abertura";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.pbCarregando)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconeAbertura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbIconeAbertura;
        private System.Windows.Forms.Label lbSigla;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbVersão;
        private System.Windows.Forms.PictureBox pbCarregando;
        private System.Windows.Forms.Label lbCarregamentoModulos;
        private System.Windows.Forms.Timer tmTimer;
        private System.Windows.Forms.ProgressBar pbBarraAbertura;
        private System.Windows.Forms.Splitter splitter1;
    }
}

