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
    //#################################################################################################################################

    //                                              FORMULÁRIO QUE ABRE O CÓDIGO DE SEGURANÇA

    //##################################################################################################################################

    public partial class frmCodigoSegurancacs : Form
    {
        //####################################### MÉTODOS AO CARREGAR FORMULÁRIO #######################################################

        //MÉTODO CONSTRUTOR
        public frmCodigoSegurancacs()
        {
            InitializeComponent();
        }


        //##########################################  MÉTODOS QUE MANIPULAM ELEMENTOS DO CADASTRO  #####################################

        //----- BOTÃO OK
        private void btnOk_Click(object sender, EventArgs e)
        {
            //--- VERIFICA SE O CÓDIGO DE SEGURANÇA DA ELEIÇÃO É O MESMO CADASTRADO
            if (txtCodigo.Text == frmGerencial.eleicao.getCodigoSeguranca(frmGerencial.eleicao.getCodEleicao()))
            {
                //--- VERIFICA A SITUAÇÃO DA ELEIÇÃO, CASO NÃO TENHA SIDO INICIADA
                if (frmGerencial.eleicao.getSituacaoEleicao(frmGerencial.eleicao.getCodEleicao()) == 0)
                {
                    frmGerencial.eleicao.restauraEleicao(frmGerencial.eleicao.getCodEleicao());//RETORNA OS DADOS DA ELEIÇÃO
                    frmGerencial.eleicao.setSituacaoEleicao(1);//ATUALIZA O VALOR DA SITUAÇÃO DA ELEIÇÃO PARA "1", QUE INDICARÁ QUE ESTÁ APTA A VOTAÇÃO
                    frmGerencial.eleicao.insereLista(frmGerencial.eleicao.getCodEleicao());//SALVA OS DADOS NA LISTA
                    frmVotacao frmVotacao = new frmVotacao();//ABRE O FORMULÁRIO PARA VOTAÇÃO
                    frmVotacao.ShowDialog();
                    this.Close();
                }
                else//--- SENÃO
                {
                    //--- VERIFICA A SITUAÇÃO DA ELEIÇÃO, CASO TENHA SIDO INICIADA
                    if (frmGerencial.eleicao.getSituacaoEleicao(frmGerencial.eleicao.getCodEleicao()) == 1)
                    {
                        frmGerencial.eleicao.restauraEleicao(frmGerencial.eleicao.getCodEleicao());//RETORNA OS DADOS DA ELEIÇÃO
                        frmGerencial.eleicao.setSituacaoEleicao(2);//ATUALIZA O VALOR DA SITUAÇÃO DA ELEIÇÃO PARA "1", QUE INDICARÁ QUE ESTÁ APTA A VOTAÇÃO
                        frmGerencial.eleicao.insereLista(frmGerencial.eleicao.getCodEleicao());//SALVA OS DADOS NA LISTA
                        MessageBox.Show("Eleição encerrada com sucesso!");
                        this.Close();
                    }
                    else//SENÃO
                    {
                        //--- VERIFICA A SITUAÇÃO DA ELEIÇÃO, CASO TENHA SIDO ENCERRADA 
                        if (frmGerencial.eleicao.getSituacaoEleicao(frmGerencial.eleicao.getCodEleicao()) == 2)
                        {
                            frmResulttados frmVerResultados = new frmResulttados();
                            frmVerResultados.ShowDialog();
                            this.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Código de segurança não confere!");
            }
        }
    }
}
