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
    public partial class frmAlterarEleicao : Form
    {
        public frmAlterarEleicao()
        {
            InitializeComponent();
        }
        int tamanho;
        int indice = -1;

        private void frmAlterarEleicao_Shown(object sender, EventArgs e)
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //SE O ÍNDICE REPRESENTAR UMA POSIÇÃO DE ELEMENTO SELECIONADO DO DATA GRID VIEW
            if (indice >= 0)
            {
                //O CÓDIGO QUE GERENCIA SE O CADASTRO É DE UM NOVO CANDIDATO OU DE UM NOVO CADASTRO RECEBE O 
                //A POSIÇÃO NA LISTA QUE DEVERÁ SER ALTERADO
                frmGerencial.eleicao.setCodEleicao(indice);

                //FECHA A JANELA
                Close();
            }
            else
            {
                MessageBox.Show("Não há candidatos selecionados para alteração!");
            }
        }

        private void dgvEleicao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = dgvEleicao.CurrentRow.Index;
            dgvEleicao.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            dgvEleicao.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            frmGerencial.eleicao.setCodEleicao(-1);
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
