using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_eleicao
{
    public partial class frmExclusaoEleicao : Form
    {
        public frmExclusaoEleicao()
        {
            InitializeComponent();
        }

        private int tamanho;
        private int indice = -1;

        private void btnCancela_Click(object sender, EventArgs e)
        {
            frmGerencial.eleicao.setCodEleicao(-1);
            this.Close();
        }

        public void preencheDgv()
        {
            tamanho = frmGerencial.eleicao.getTamanhoEleicao();
            if (tamanho > 0)
            {
                for (int i = 0; i < tamanho; i++)
                {
                    string nomeEleicao = frmGerencial.eleicao.getTituloEleicao(i);
                    string pais = frmGerencial.eleicao.getPais(i).ToString();
                    dgvEleicao.Rows.Add(nomeEleicao, pais);
                }
            }
        }

        private void frmExclusaoEleicao_Shown(object sender, EventArgs e)
        {
            preencheDgv();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(indice >= 0)
            {
                frmGerencial.eleicao.removeLista(indice);
                dgvEleicao.Rows.Clear();
            }
        }

        private void dgvEleicao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = dgvEleicao.CurrentRow.Index;
            dgvEleicao.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            dgvEleicao.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
        }
    }
}
