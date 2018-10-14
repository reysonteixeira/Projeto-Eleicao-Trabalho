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
        //##########################################  MÉTODOS AO CARREGAMENTO DE FORMULÁRIO  ###########################################

        //----- MÉTODO CONSTRUTOR
        public frmAlterarEleicao()
        {
            InitializeComponent();
        }
       
        //----- AO MOSTRAR O FORMULÁRIO
        private void frmAlterarEleicao_Shown(object sender, EventArgs e)
        {
            tamanho = frmGerencial.eleicao.getTamanhoEleicao();//BUSCA A QUANTIDADE DE ELEIÇÕES CADASTRADAS
            if (tamanho > 0)//CASO EXISTA ALGUMA ELEIÇÃO
            {
                for (int i = 0; i < tamanho; i++)
                {
                    string nomeEleicao = frmGerencial.eleicao.getTituloEleicao(i);//BUSCA O TÍTULO DA ELEIÇÃO CADASTRADA
                    string pais = frmGerencial.eleicao.getPais(i).ToString();//BUSCA O PAÍS DA ELEIÇÃO
                    dgvEleicao.Rows.Add(nomeEleicao, pais);//ADICIONA O TÍTULO E O PAÍS DA ELEIÇÃO NO DATA GRID VIEW
                }
            }
        }


        //#################################################  VARIÁVEIS  ################################################################

        int tamanho;//RECEBRÁ A QUANTIDADE DE ELEIÇÕES CADASTRADAS
        int indice = -1;//MARCARÁ O CANDIDATO QUE SERÁ EDITADO


        //#########################################  MANIPULAÇÃO DE EDIÇÕES  ###########################################################

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
                MessageBox.Show("Esta eleição já foi iniciada. Impossível fazer alteração!");
            }
        }

        //----- BOTÃO ALTERAR
        private void btnAlterar_Click(object sender, EventArgs e)
        {          
            if (indice >= 0)//VERIFICA SE ALGUM CANDIDATO FOI SELECIONADO
            {
                frmGerencial.eleicao.setCodEleicao(indice);//ENVIA O CÓDIDO DA ELEIÇÃO QUE SERÁ EDITADA
                this.Close();//FECHA A JANELA
            }
            else
            {
                MessageBox.Show("Não há candidatos selecionados para alteração!");
            }
        }

        //----- BOTÃO CANCELAR
        private void btnCancela_Click(object sender, EventArgs e)
        {
            frmGerencial.eleicao.setCodEleicao(-1);//VOLTA O CÓDIGO DA ELEIÇÃO PARA "-1", REPRESENTANDO QUE NÃO HAVERÁ CANDIDATO EDITADO
            this.Close();//FECHA A JANELA
        }
    }
}
