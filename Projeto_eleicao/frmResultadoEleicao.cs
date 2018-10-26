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

    //                                               FORMULÁRIO QUE LISTA ELEIÇÕES

    //##################################################################################################################################

    public partial class frmResultadoEleicao : Form
    {
        //##########################################  AO CARREGAR O FORMULÁRIO  #########################################################

        //----- MÉTODO CONSTRUTOR
        public frmResultadoEleicao()
        {
            InitializeComponent();
        }

        //----- AO CARREGAR O FORMULÁRIO
        private void frmResultadoEleicao_Shown(object sender, EventArgs e)
        {
            preencheDataGridView(1);
        }

        private int indice = -1;


        //########################################  MÉTODOS QUE FAZ MANIPUALAÇÃO COM ELEMENTOS DO FORMULÁRIO  ###########################
        
        //----- MÉTODO QUE PREENCHE O DATA GRID VIEW
        public void preencheDataGridView(int i)
        {
            dgvEleicao.Rows.Clear();//LIMPA TODOS OS ELEMENTOS DO DATA GRID VIEW
            if (i == 1)//FAZ O CARREGAMENTO DE TODOS DADOS
            {
                for (int j = 0; j < frmGerencial.eleicao.getTamanhoEleicao(); j++)//PERCORRE TODA A LISTA DE ELEIÇÃO
                {
                    int codigo = frmGerencial.eleicao.getCodigo(j);//RECUPERA O CÓDIGO DE ELEIÇÃO
                    string titulo = frmGerencial.eleicao.getTituloEleicao(j);//RECUPERA O TÍTULO DA ELEIÇÃO
                    DateTime data = frmGerencial.eleicao.getDataEleicao(j);//RECUPERA A DATA DA ELEIÇÃO
                    int situacao = frmGerencial.eleicao.getSituacaoEleicao(j);//RECUPERA A SITUAÇÃO DA ELEIÇÃO
                    string stringSituacao;
                    if (situacao == 0)//VERIRIFICA SE APENAS FOI CADASTRADA
                    {
                        stringSituacao = "Cadastrada";
                    }
                    else
                    {
                        if (situacao == 1)//VERIFICA SE A ELEIÇÃO ESTÁ EM ANDAMENTO
                        {
                            stringSituacao = "Em andamento";
                        }
                        else//SENÃO INDICA QUE A ELEIÇÃO FOI ENCERRADA
                        {
                            stringSituacao = "Encerrada";
                        }
                    }
                    dgvEleicao.Rows.Add(codigo.ToString(), titulo, data.ToShortDateString(), stringSituacao);//ADICIONA DADOS NA LINHA DO DATA GRID VIEW

                }
            }
            else
            {
                if (i == 0)//SE O FILTRO FOR FEITO POR SITUAÇÃO
                {
                    for (int j = 0; j < frmGerencial.eleicao.getTamanhoEleicao(); j++)//PERCORRE TODA A LSITA DE ELEIÇÕES
                    {
                        int codigo = frmGerencial.eleicao.getCodigo(j);//RECUPERA O CÓDIGO DE ELEIÇÃO
                        string titulo = frmGerencial.eleicao.getTituloEleicao(j);//RECUPERA O TÍTULO DA ELEIÇÃO
                        DateTime data = frmGerencial.eleicao.getDataEleicao(j);//RECUPERA A DATA DA ELEIÇÃO
                        int situacao = frmGerencial.eleicao.getSituacaoEleicao(j);//RECUPERA A SITUAÇÃO DA ELEIÇÃO
                        string stringSituacao;
                        
                        if (situacao == cbSituacao.SelectedIndex)//VERIFICA SE A SITUAÇÃO DA ELEIÇÃO CORRESPONDE A SELECIONA DA COMBOBOX
                        {
                            if (situacao == 0)//VERIRIFICA SE APENAS FOI CADASTRADA
                            {
                                stringSituacao = "Cadastrada";
                            }
                            else
                            {
                                if (situacao == 1)//VERIFICA SE A ELEIÇÃO ESTÁ EM ANDAMENTO
                                {
                                    stringSituacao = "Em andamento";
                                }
                                else//SENÃO INDICA QUE A ELEIÇÃO FOI ENCERRADA
                                {
                                    stringSituacao = "Encerrada";
                                }
                            }
                            dgvEleicao.Rows.Add(codigo.ToString(), titulo, data.ToShortDateString(), stringSituacao);//ADICIONA DADOS NA LINHA DO DATA GRID VIEW
                        }
                    }
                }
                else
                {
                    if (i == 2)//SE FILTRAR POR DATA
                    {
                        for (int j = 0; j < frmGerencial.eleicao.getTamanhoEleicao(); j++)//PERCORRE TODA A LSITA DE ELEIÇÕES
                        {
                            int codigo = frmGerencial.eleicao.getCodigo(j);//RECUPERA O CÓDIGO DE ELEIÇÃO
                            string titulo = frmGerencial.eleicao.getTituloEleicao(j);//RECUPERA O TÍTULO DA ELEIÇÃO
                            DateTime data = frmGerencial.eleicao.getDataEleicao(j);//RECUPERA A DATA DA ELEIÇÃO
                            int situacao = frmGerencial.eleicao.getSituacaoEleicao(j);//RECUPERA A SITUAÇÃO DA ELEIÇÃO
                            int comparaInicio = DateTime.Compare(data.Date, dtpInicio.Value.Date);//RECEBE A COMPARAÇÃO DE DATA DO INICIO COM A DATA CADASTRADA
                            int comparaFim = DateTime.Compare(data.Date,dtpFim.Value.Date);//RECEBE A COMPARAÇÃO DE DATA DO FIM COM A DATA CADASTRADA
                            if (comparaInicio >= 0 && comparaFim <= 0)//VERIFICA SE A DATA ESTÁ ENTRE O INTERVALO
                            {
                                string stringSituacao;
                                if (situacao == 0)//VERIRIFICA SE APENAS FOI CADASTRADA
                                {
                                    stringSituacao = "Cadastrada";
                                }
                                else
                                {
                                    if (situacao == 1)//VERIFICA SE A ELEIÇÃO ESTÁ EM ANDAMENTO
                                    {
                                        stringSituacao = "Em andamento";
                                    }
                                    else//SENÃO INDICA QUE A ELEIÇÃO FOI ENCERRADA
                                    {
                                        stringSituacao = "Encerrada";
                                    }
                                }
                                dgvEleicao.Rows.Add(codigo.ToString(), titulo, data.ToShortDateString(), stringSituacao);//ADICIONA DADOS NA LINHA DO DATA 
                            }
                        }
                    }
                }
            }
        }


        //#######################################  MÉTODOS DE MANIPULAÇÃO COM DADOS DA ELEIÇÃO  ###########################################

        //----- BOTÃO RESULTADO
        private void btnResultado_Click(object sender, EventArgs e)
        {
            if(indice >=0)//VERIFICA SE ALGUMA ELEIÇÃO FOI SELECIONADA
            { 
                for (int k = 0; k < frmGerencial.eleicao.getTamanhoEleicao(); k++)//PERCORRE A LISTA DE ELEIÇÕES
                {
                    if (int.Parse(dgvEleicao[0, indice].Value.ToString()) == frmGerencial.eleicao.getCodigo(k))//VERIFICA SE O CÓDIGO DA DATA GRID VIEW É IGUAL AO CÓDIGO CADASTRADO
                    {
                        if (dgvEleicao[3, indice].Value.ToString() == "Encerrada")//VERIFICA SE A STIUAÇÃO DA ELEIÇÃO ESTÁ ENCERRADA
                        {
                            frmGerencial.eleicao.setCodEleicao(k);//CONFIGURA O CODELEIÇÃO COM O CÓDIGO DA ELEIÇÃO QUE FOI CLICADA
                            frmCodigoSegurancacs frmCodigoSeg = new frmCodigoSegurancacs();//ABRE A TELA DE VERIFICAÇÃO DE CÓDIGO
                            frmCodigoSeg.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Apenas eleições encerradas podem ter resultados exibidos!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma eleição para ver o resultado!");
            }
        }

        //----- RADIO BUTTON DATA
        private void rbData_CheckedChanged(object sender, EventArgs e)
        {
            if(rbData.Checked)//SE ESTIVER MARCADO O RADIO BUTTON DATA
            {
                indice = -1;//VOLTA POSIÇÃO DE ESCOLHA PARA -1
                cbSituacao.Enabled = false;//TRAVA O COMBOBOX DE SITUAÇÃO
                dtpInicio.Enabled = true;//LIBERA O CAMPO DE DATAS
                dtpFim.Enabled = true;//LIBERA O CAMPO DE DATAS
            }
        }

        //----- RADIO BUTTON DATA
        private void rbSituacao_CheckedChanged(object sender, EventArgs e)
        {
            if(rbSituacao.Checked)//SE ESTIVER MARCADO O RADIO BUTTON DE SITUAÇÃO
            {
                indice = -1;//VOLTA A POSIÇÃO DE ESCOLHA PARA -1
                cbSituacao.Enabled = true;//LIBERA O COMBOBOX DE SITUAÇÃO
                dtpInicio.Enabled = false;//TRAVA O CAMPO DE DATAS
                dtpFim.Enabled = false;//TRAVA O CAMPO DE DATAS
            }
        }

        //----- BOTÃO FILTRAR
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (rbSituacao.Checked)//SE O RADIO BUTTON DE SITUAÇÃO ESTIVER MARCADO
                preencheDataGridView(0);//FAZ O PREENCHIMENTO DE DADOS A PARTIR DA SITUAÇÃO
            else
                preencheDataGridView(2); //FAZ O PREENCHIMENTO DE DADOS A PARTIR DE INTERVALO DE DATAS
        }

        private void dgvEleicao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = dgvEleicao.CurrentRow.Index;//VARIÁVEL QUE RECEBE O INDICE DA LINHA CLICADA
        }
    }
}
