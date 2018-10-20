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
    //##################################################################################################################################

    //                                  FORMULÁRIO QUE FAZ A EXCLUSÃO DE CADASRO DE ELEIÇÕES

    //##################################################################################################################################

    public partial class frmExclusaoEleicao : Form
    {
        //##########################################  MÉTODOS AO CARREGAMENTO DE FORMULÁRIO  ###########################################

        //----- MÉTODO CONSTRUTOR
        public frmExclusaoEleicao()
        {
            InitializeComponent();
        }

        //----- AO MOSTRAR O FORMULÁRIO
        private void frmExclusaoEleicao_Shown(object sender, EventArgs e)
        {
            preencheDgv();//PREENCHE O DATA GRID VIEW
        }


        //##################################################### VARIÁVEIS ##############################################################

        private int tamanho;//RECEBERÁ A QUANTIDADE DE ELEIÇÕES CADASTRADAS
        private int indice = -1;//RECEBERÁ A POSIÇÃO DO CADASTRO QUE SERÁ EXCLUÍDO

        
        //#############################################  MANIPULAÇÃO DE EXCLUSÕES  #####################################################
        
        //----- BOTÃO EXCLUIR
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(indice >= 0)//SE EXISTIR ELEMENTO SELECIONADO
            {
                frmGerencial.eleicao.removeLista(indice);//ENVIA A POSIÇÃO DO ELEMENTO SELECIONADO PARA EXCLUSÃO
                dgvEleicao.Rows.Clear();//LIMPA TODA O DATA GRID VIEW
                preencheDgv();//PREENCHE O DATA GRID VIEW
                indice = -1;//VOLTA O ÍNDICE AO PADRÃO
            }
            else
            {
                MessageBox.Show("Não existe eleição selecionada para edição!");
            }
        }

        //----- BOTÃO CANCELAR
        private void btnCancela_Click(object sender, EventArgs e)
        {
            frmGerencial.eleicao.setCodEleicao(-1);//VOLTA O CÓDIGO DE ELEIÇÃO PARA O PADRÃO
            this.Close();//FECHA A JANELA
        }

        //----- CLICAR EM CÉLULA DO DATA GRID VIEW
        private void dgvEleicao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (frmGerencial.eleicao.getSituacaoEleicao(dgvEleicao.CurrentRow.Index) == 0)
            {
                indice = dgvEleicao.CurrentRow.Index;//INDICE RECEBE O INDEX DA LINHA SELECIONADA ATUAL
                dgvEleicao.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;//MUDA A COR DO BACKGROUND DA CÉLULA SELECIONADA
                dgvEleicao.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;//MUDA A COR DA FONTE DA CÉLULA SELECIONADA
            }
            else
            {
                MessageBox.Show("Esta eleição já foi iniciada. Impossível fazer a exclusão!");
            }
        }


        //#########################################  MANIPULAÇÃO COM ELEMENTOS DO FORMULÁRIO  ##########################################

        //PREENCHE O DATA GRID VIEW COM DADOS
        public void preencheDgv()
        {
            tamanho = frmGerencial.eleicao.getTamanhoEleicao();//BUSCA A QUANTIDADE DE ELEIÇÕES CADASTRADAS
            if (tamanho > 0)//SE EXISTIREM ELEIÇÕES CADASTRADAS
            {
                for (int i = 0; i < tamanho; i++)
                {
                    string nomeEleicao = frmGerencial.eleicao.getTituloEleicao(i);//BUSCA O TÍTULO DA ELEIÇÃO CADASTRADA
                    string pais = frmGerencial.eleicao.getPais(i).ToString();//BUSCA O PAÍS DA ELEIÇÃO
                    dgvEleicao.Rows.Add(nomeEleicao, pais);//ADICIONA O TÍTULO E O PAÍS DA ELEIÇÃO NO DATA GRID VIEW
                }
            }
        }
    }
}
