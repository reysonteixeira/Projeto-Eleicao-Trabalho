namespace Projeto_eleicao
{
    partial class frmAlterarEleicao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEleicao = new System.Windows.Forms.DataGridView();
            this.tituloEleicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisEleicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEleicao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEleicao
            // 
            this.dgvEleicao.AllowUserToAddRows = false;
            this.dgvEleicao.AllowUserToDeleteRows = false;
            this.dgvEleicao.AllowUserToResizeColumns = false;
            this.dgvEleicao.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEleicao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEleicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEleicao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tituloEleicao,
            this.paisEleicao});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEleicao.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEleicao.Location = new System.Drawing.Point(35, 72);
            this.dgvEleicao.MultiSelect = false;
            this.dgvEleicao.Name = "dgvEleicao";
            this.dgvEleicao.ReadOnly = true;
            this.dgvEleicao.RowHeadersVisible = false;
            this.dgvEleicao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEleicao.Size = new System.Drawing.Size(701, 251);
            this.dgvEleicao.TabIndex = 0;
            this.dgvEleicao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEleicao_CellClick);
            // 
            // tituloEleicao
            // 
            this.tituloEleicao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tituloEleicao.HeaderText = "Título Eleição";
            this.tituloEleicao.Name = "tituloEleicao";
            this.tituloEleicao.ReadOnly = true;
            this.tituloEleicao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // paisEleicao
            // 
            this.paisEleicao.HeaderText = "País";
            this.paisEleicao.Name = "paisEleicao";
            this.paisEleicao.ReadOnly = true;
            this.paisEleicao.Width = 329;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecione uma eleição:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancela.Image = global::Projeto_eleicao.Properties.Resources.delete2;
            this.btnCancela.Location = new System.Drawing.Point(610, 343);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(126, 46);
            this.btnCancela.TabIndex = 5;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancela.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = global::Projeto_eleicao.Properties.Resources.document_edit1;
            this.btnAlterar.Location = new System.Drawing.Point(35, 343);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(126, 46);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // frmAlterarEleicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dgvEleicao);
            this.Name = "frmAlterarEleicao";
            this.Text = "frmAlterarEleicao";
            this.Shown += new System.EventHandler(this.frmAlterarEleicao_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEleicao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEleicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloEleicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisEleicao;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label1;
    }
}