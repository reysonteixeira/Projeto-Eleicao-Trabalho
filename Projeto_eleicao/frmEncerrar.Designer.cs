namespace Projeto_eleicao
{
    partial class frmEncerrar
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
            this.cbEleicoes = new System.Windows.Forms.ComboBox();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbEleicoes
            // 
            this.cbEleicoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEleicoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEleicoes.FormattingEnabled = true;
            this.cbEleicoes.Location = new System.Drawing.Point(36, 71);
            this.cbEleicoes.Name = "cbEleicoes";
            this.cbEleicoes.Size = new System.Drawing.Size(351, 28);
            this.cbEleicoes.TabIndex = 0;
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEncerrar.Location = new System.Drawing.Point(278, 132);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(109, 51);
            this.btnEncerrar.TabIndex = 1;
            this.btnEncerrar.Text = "Encerrar";
            this.btnEncerrar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione uma eleição:";
            // 
            // frmEncerrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 214);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.cbEleicoes);
            this.Name = "frmEncerrar";
            this.Text = "Urna Eletrônica - Encerrar Eleição";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEleicoes;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Label label1;
    }
}