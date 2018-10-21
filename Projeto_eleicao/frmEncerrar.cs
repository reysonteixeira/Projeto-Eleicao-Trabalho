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

    //                                         FORMULÁRIO QUE ENCERRA A ELEIÇÃO SELECIONADA

    //##################################################################################################################################

    public partial class frmEncerrar : Form
    {
        //############################################  MÉTODOS AO CARREGAR O FORMULÁRIO  ##############################################

        //----- MÉTODO CONSTRUTOR
        public frmEncerrar()
        {
            InitializeComponent();
        }

        //----- AO MOSTRAR O FORMULÁRIO
        private void frmEncerrar_Shown(object sender, EventArgs e)
        {
            preencheComboBox();//FAZ O PREENCHIMENTO DO COMBOBOX
        }


        //##########################################  MANIPULAÇÃO DE ELEMENTOS DO FORMULÁRIO  ############################################

        //----- FAZ O PREENCHIMENTO DE COMBOBOX
        public void preencheComboBox()
        {
            for (int i = 0; i < frmGerencial.eleicao.getTamanhoEleicao(); i++) //PERCORRE AS ELEIÇÕES CADASTRADAS
            {
                if (frmGerencial.eleicao.getSituacaoEleicao(i) == 1)//SE O STATUS FOR = 1 (INICIALIZADA)
                {
                    int codigo = frmGerencial.eleicao.getCodigo(i);//VARIÁVEL CODIGO RECEBE O CÓDIGO DA ELEIÇÃO CADASTRADA
                    string titulo = frmGerencial.eleicao.getTituloEleicao(i);//VARIÁVEL TITULO RECEBE O CÓDIGO DA ELEIÇÃO CADASTRADA
                    string pais = frmGerencial.eleicao.getPais(i).ToString();//VARIÁVEL PAÍS RECEBE A CONVERSÃO DA ENUMERAÇÃO DE PAIS PARA STRING
                    cbEleicoes.Items.Add(codigo.ToString() + " - " + titulo + " - " + pais);//ADIÇÃO DE VARIÁVEIS PARA COLUNAS DE DATA GRID VIEW
                }
            }
        }


        //############################################  MANIPULAÇÃO DE DADOS CADASTRADOS  ###############################################
        
        //----- BOTÃO ENCERRAR
        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            if (cbEleicoes.SelectedIndex >= 0)//VERIRICA SE ALGUM ITEM FOI SELECIONADO NO COMBOBOX
            {
                string[] eleicao = cbEleicoes.SelectedItem.ToString().Split('-');//QUEBRA A STRING CONTIDA NA COMBOBOX EM SUBSTRING DE ACRODO COM A APARIÇÃO DO SINAL '-'
                for (int i = 0; i < frmGerencial.eleicao.getTamanhoEleicao(); i++)//PERCORRE TODAS ELEIÇÕES CADASTRADAS
                {
                    if (int.Parse(eleicao[0].ToString()) == frmGerencial.eleicao.getCodigo(i))//CASO O CÓDIGO NA LISTA SEJA IGUAL AO CÓDIDO DA ELEIÇÃO RESCOLHIDA
                    {
                        frmGerencial.eleicao.setCodEleicao(i);
                        frmCodigoSegurancacs frmCodigoSeguranca = new frmCodigoSegurancacs();
                        frmCodigoSeguranca.ShowDialog();
                        cbEleicoes.Items.Clear();//LIMPA A LISTA
                        preencheComboBox();//PREENCHE A LISTA NOVAMENTE
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhuma eleição selecionada para ser finalizada!");
            }
        }
    }
}
