namespace Projeto_eleicao
{
    partial class frmExclusaoEleicao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExclusaoEleicao));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEleicao = new System.Windows.Forms.DataGridView();
            this.tituloEleicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisEleicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEleicao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Selecione uma eleição:";
            // 
            // dgvEleicao
            // 
            this.dgvEleicao.AllowUserToAddRows = false;
            this.dgvEleicao.AllowUserToDeleteRows = false;
            this.dgvEleicao.AllowUserToResizeColumns = false;
            this.dgvEleicao.AllowUserToResizeRows = false;
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
            this.dgvEleicao.TabIndex = 7;
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
            // btnCancela
            // 
            this.btnCancela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancela.Image = global::Projeto_eleicao.Properties.Resources.delete2;
            this.btnCancela.Location = new System.Drawing.Point(610, 343);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(126, 46);
            this.btnCancela.TabIndex = 9;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancela.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::Projeto_eleicao.Properties.Resources.document_delete1;
            this.btnExcluir.Location = new System.Drawing.Point(35, 343);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(126, 46);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmExclusaoEleicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvEleicao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExclusaoEleicao";
            this.Text = "Urna Eletrônica - Excluir Eleição";
            this.Shown += new System.EventHandler(this.frmExclusaoEleicao_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEleicao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvEleicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloEleicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisEleicao;
    }
}