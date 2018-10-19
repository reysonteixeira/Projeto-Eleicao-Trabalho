namespace Projeto_eleicao
{
    partial class frmInicioEleicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioEleicao));
            this.cbEleicao = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAndamento = new System.Windows.Forms.RadioButton();
            this.rbIniciar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbEleicao
            // 
            this.cbEleicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEleicao.Enabled = false;
            this.cbEleicao.FormattingEnabled = true;
            this.cbEleicao.Location = new System.Drawing.Point(262, 72);
            this.cbEleicao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEleicao.Name = "cbEleicao";
            this.cbEleicao.Size = new System.Drawing.Size(286, 28);
            this.cbEleicao.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAndamento);
            this.groupBox1.Controls.Add(this.rbIniciar);
            this.groupBox1.Location = new System.Drawing.Point(34, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(192, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Situação";
            // 
            // rbAndamento
            // 
            this.rbAndamento.AutoSize = true;
            this.rbAndamento.Location = new System.Drawing.Point(17, 42);
            this.rbAndamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbAndamento.Name = "rbAndamento";
            this.rbAndamento.Size = new System.Drawing.Size(138, 24);
            this.rbAndamento.TabIndex = 1;
            this.rbAndamento.TabStop = true;
            this.rbAndamento.Text = "Em Andamento";
            this.rbAndamento.UseVisualStyleBackColor = true;
            this.rbAndamento.CheckedChanged += new System.EventHandler(this.rbAndamento_CheckedChanged);
            // 
            // rbIniciar
            // 
            this.rbIniciar.AutoSize = true;
            this.rbIniciar.Location = new System.Drawing.Point(17, 80);
            this.rbIniciar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbIniciar.Name = "rbIniciar";
            this.rbIniciar.Size = new System.Drawing.Size(123, 24);
            this.rbIniciar.TabIndex = 0;
            this.rbIniciar.TabStop = true;
            this.rbIniciar.Text = "Não Iniciadas";
            this.rbIniciar.UseVisualStyleBackColor = true;
            this.rbIniciar.CheckedChanged += new System.EventHandler(this.rbIniciar_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecione uma eleição:";
            // 
            // btnContinuar
            // 
            this.btnContinuar.Enabled = false;
            this.btnContinuar.Image = global::Projeto_eleicao.Properties.Resources.btnVotar;
            this.btnContinuar.Location = new System.Drawing.Point(433, 108);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(115, 62);
            this.btnContinuar.TabIndex = 3;
            this.btnContinuar.Text = "Votação";
            this.btnContinuar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Enabled = false;
            this.btnIniciar.Image = global::Projeto_eleicao.Properties.Resources.btnPlay1;
            this.btnIniciar.Location = new System.Drawing.Point(262, 108);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(115, 62);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar Eleição";
            this.btnIniciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // frmInicioEleicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 251);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbEleicao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmInicioEleicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urna Eletrônica - Iniciar Eleição";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEleicao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAndamento;
        private System.Windows.Forms.RadioButton rbIniciar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Label label1;
    }
}