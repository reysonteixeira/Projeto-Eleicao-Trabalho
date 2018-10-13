namespace Projeto_eleicao
{
    partial class frmGerencial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerencial));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastroCandidatos = new System.Windows.Forms.ToolStripMenuItem();
            this.eleiçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarEleiçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encerrarEleiçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEncerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.btnResultados = new System.Windows.Forms.Button();
            this.btnDocumentação = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.iniciarEleiçãoToolStripMenuItem,
            this.encerrarEleiçãoToolStripMenuItem,
            this.resultadosToolStripMenuItem,
            this.documentaçãoToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.tsmEncerrar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastroCandidatos,
            this.eleiçãoToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // tsmCadastroCandidatos
            // 
            this.tsmCadastroCandidatos.Name = "tsmCadastroCandidatos";
            this.tsmCadastroCandidatos.Size = new System.Drawing.Size(134, 22);
            this.tsmCadastroCandidatos.Text = "Candidatos";
            this.tsmCadastroCandidatos.Click += new System.EventHandler(this.tsmCadastroCandidatos_Click);
            // 
            // eleiçãoToolStripMenuItem
            // 
            this.eleiçãoToolStripMenuItem.Name = "eleiçãoToolStripMenuItem";
            this.eleiçãoToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.eleiçãoToolStripMenuItem.Text = "Eleição";
            // 
            // iniciarEleiçãoToolStripMenuItem
            // 
            this.iniciarEleiçãoToolStripMenuItem.Name = "iniciarEleiçãoToolStripMenuItem";
            this.iniciarEleiçãoToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.iniciarEleiçãoToolStripMenuItem.Text = "Iniciar Eleição";
            // 
            // encerrarEleiçãoToolStripMenuItem
            // 
            this.encerrarEleiçãoToolStripMenuItem.Name = "encerrarEleiçãoToolStripMenuItem";
            this.encerrarEleiçãoToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.encerrarEleiçãoToolStripMenuItem.Text = "Encerrar Eleição";
            // 
            // resultadosToolStripMenuItem
            // 
            this.resultadosToolStripMenuItem.Name = "resultadosToolStripMenuItem";
            this.resultadosToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.resultadosToolStripMenuItem.Text = "Resultados";
            // 
            // documentaçãoToolStripMenuItem
            // 
            this.documentaçãoToolStripMenuItem.Name = "documentaçãoToolStripMenuItem";
            this.documentaçãoToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.documentaçãoToolStripMenuItem.Text = "Documentação";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // tsmEncerrar
            // 
            this.tsmEncerrar.Name = "tsmEncerrar";
            this.tsmEncerrar.Size = new System.Drawing.Size(62, 20);
            this.tsmEncerrar.Text = "Encerrar";
            this.tsmEncerrar.Click += new System.EventHandler(this.tsmEncerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_eleicao.Properties.Resources.Mercosul_logo_9424015B48_seeklogo;
            this.pictureBox1.Location = new System.Drawing.Point(573, 417);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Image = global::Projeto_eleicao.Properties.Resources.Sem_Título_78;
            this.btnFechar.Location = new System.Drawing.Point(573, 146);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(133, 107);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Image = global::Projeto_eleicao.Properties.Resources.start;
            this.btnIniciar.Location = new System.Drawing.Point(247, 146);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(133, 107);
            this.btnIniciar.TabIndex = 7;
            this.btnIniciar.Text = "Iniciar Eleição";
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIniciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrar.Image = global::Projeto_eleicao.Properties.Resources.Sem_Título_77;
            this.btnEncerrar.Location = new System.Drawing.Point(247, 285);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(133, 107);
            this.btnEncerrar.TabIndex = 6;
            this.btnEncerrar.Text = "Encerrar Eleição";
            this.btnEncerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEncerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // btnResultados
            // 
            this.btnResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultados.Image = global::Projeto_eleicao.Properties.Resources.Sem_Título_74;
            this.btnResultados.Location = new System.Drawing.Point(79, 285);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(133, 107);
            this.btnResultados.TabIndex = 5;
            this.btnResultados.Text = "Resultados";
            this.btnResultados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnResultados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnResultados.UseVisualStyleBackColor = true;
            this.btnResultados.Click += new System.EventHandler(this.btnResultados_Click);
            // 
            // btnDocumentação
            // 
            this.btnDocumentação.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocumentação.Image = global::Projeto_eleicao.Properties.Resources.Sem_Título_73;
            this.btnDocumentação.Location = new System.Drawing.Point(413, 146);
            this.btnDocumentação.Name = "btnDocumentação";
            this.btnDocumentação.Size = new System.Drawing.Size(133, 107);
            this.btnDocumentação.TabIndex = 4;
            this.btnDocumentação.Text = "Documentação";
            this.btnDocumentação.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDocumentação.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDocumentação.UseVisualStyleBackColor = true;
            this.btnDocumentação.Click += new System.EventHandler(this.btnDocumentação_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.Image = global::Projeto_eleicao.Properties.Resources.Sem_Título_72;
            this.btnSobre.Location = new System.Drawing.Point(413, 285);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(133, 107);
            this.btnSobre.TabIndex = 3;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSobre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = global::Projeto_eleicao.Properties.Resources.Sem_Título_7;
            this.btnCadastrar.Location = new System.Drawing.Point(79, 146);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(133, 107);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmGerencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.btnResultados);
            this.Controls.Add(this.btnDocumentação);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmGerencial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urna Eletrônica Mercosul";
            this.Load += new System.EventHandler(this.frmGerencial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnDocumentação;
        private System.Windows.Forms.Button btnResultados;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarEleiçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encerrarEleiçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmEncerrar;
        public System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastroCandidatos;
        private System.Windows.Forms.ToolStripMenuItem eleiçãoToolStripMenuItem;
    }
}