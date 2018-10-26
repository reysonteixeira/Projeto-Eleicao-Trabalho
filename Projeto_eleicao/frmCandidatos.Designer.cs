namespace Projeto_eleicao
{
    partial class frmCandidatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCandidatos));
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.txtNomeAbreviado = new System.Windows.Forms.TextBox();
            this.txtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPartidoNome = new System.Windows.Forms.TextBox();
            this.txtPartidoNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.epNC = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNA = new System.Windows.Forms.ErrorProvider(this.components);
            this.epN = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPNum = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPNome = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPNome)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Enabled = false;
            this.txtNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCompleto.Location = new System.Drawing.Point(255, 110);
            this.txtNomeCompleto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(409, 26);
            this.txtNomeCompleto.TabIndex = 1;
            this.txtNomeCompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeCompleto_KeyPress);
            this.txtNomeCompleto.Validated += new System.EventHandler(this.txtNomeCompleto_Validated);
            // 
            // txtNomeAbreviado
            // 
            this.txtNomeAbreviado.Enabled = false;
            this.txtNomeAbreviado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAbreviado.Location = new System.Drawing.Point(255, 173);
            this.txtNomeAbreviado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeAbreviado.Name = "txtNomeAbreviado";
            this.txtNomeAbreviado.Size = new System.Drawing.Size(184, 26);
            this.txtNomeAbreviado.TabIndex = 2;
            this.txtNomeAbreviado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeAbreviado_KeyPress);
            this.txtNomeAbreviado.Validated += new System.EventHandler(this.txtNomeAbreviado_Validated);
            // 
            // txtNascimento
            // 
            this.txtNascimento.Enabled = false;
            this.txtNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNascimento.Location = new System.Drawing.Point(576, 173);
            this.txtNascimento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNascimento.Mask = "00/00/0000";
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(88, 26);
            this.txtNascimento.TabIndex = 3;
            this.txtNascimento.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtNascimento.Validated += new System.EventHandler(this.txtNascimento_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome Completo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome Abreviado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Foto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPartidoNome);
            this.groupBox1.Controls.Add(this.txtPartidoNum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(371, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 113);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Partido";
            // 
            // txtPartidoNome
            // 
            this.txtPartidoNome.Enabled = false;
            this.txtPartidoNome.Location = new System.Drawing.Point(90, 66);
            this.txtPartidoNome.Name = "txtPartidoNome";
            this.txtPartidoNome.Size = new System.Drawing.Size(164, 26);
            this.txtPartidoNome.TabIndex = 1;
            this.txtPartidoNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPartidoNome_KeyPress);
            this.txtPartidoNome.Validated += new System.EventHandler(this.txtPartidoNome_Validated);
            // 
            // txtPartidoNum
            // 
            this.txtPartidoNum.Enabled = false;
            this.txtPartidoNum.Location = new System.Drawing.Point(90, 29);
            this.txtPartidoNum.Name = "txtPartidoNum";
            this.txtPartidoNum.Size = new System.Drawing.Size(60, 26);
            this.txtPartidoNum.TabIndex = 0;
            this.txtPartidoNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPartidoNum_KeyPress);
            this.txtPartidoNum.Validated += new System.EventHandler(this.txtPartidoNum_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Número:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Enabled = false;
            this.btnSelecionar.Location = new System.Drawing.Point(256, 317);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(31, 25);
            this.btnSelecionar.TabIndex = 4;
            this.btnSelecionar.Text = "...";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = global::Projeto_eleicao.Properties.Resources.disk_blue;
            this.btnSalvar.Location = new System.Drawing.Point(277, 25);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(122, 38);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.Image = global::Projeto_eleicao.Properties.Resources.Foto_add;
            this.pbFoto.InitialImage = global::Projeto_eleicao.Properties.Resources.Foto_add;
            this.pbFoto.Location = new System.Drawing.Point(165, 252);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(85, 90);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 7;
            this.pbFoto.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Image = global::Projeto_eleicao.Properties.Resources.exit;
            this.btnSair.Location = new System.Drawing.Point(542, 25);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(122, 38);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::Projeto_eleicao.Properties.Resources.add;
            this.btnNovo.Location = new System.Drawing.Point(128, 25);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(122, 38);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // epNC
            // 
            this.epNC.ContainerControl = this;
            // 
            // epNA
            // 
            this.epNA.ContainerControl = this;
            // 
            // epN
            // 
            this.epN.ContainerControl = this;
            // 
            // epPNum
            // 
            this.epPNum.ContainerControl = this;
            // 
            // epPNome
            // 
            this.epPNome.ContainerControl = this;
            // 
            // frmCandidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 415);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNascimento);
            this.Controls.Add(this.txtNomeAbreviado);
            this.Controls.Add(this.txtNomeCompleto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmCandidatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urna Eletrônica - Cadastro de Candidatos";
            this.Shown += new System.EventHandler(this.frmCandidatos_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPNome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.TextBox txtNomeAbreviado;
        private System.Windows.Forms.MaskedTextBox txtNascimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPartidoNome;
        private System.Windows.Forms.TextBox txtPartidoNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ErrorProvider epNC;
        private System.Windows.Forms.ErrorProvider epNA;
        private System.Windows.Forms.ErrorProvider epN;
        private System.Windows.Forms.ErrorProvider epPNum;
        private System.Windows.Forms.ErrorProvider epPNome;
    }
}