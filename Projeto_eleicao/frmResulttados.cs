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

    //                                            FORMULÁRIO QUE MOSTRA OS RESULTADOS

    //#################################################################################################################################

    public partial class frmResulttados : Form
    {
        //----- MÉTODO CONSTRUTOR
        public frmResulttados()
        {
            InitializeComponent();
        }

        //----- VARIÁVEIS
        public int[] votos = new int[frmGerencial.eleicao.getTamListaCandidatos()];//RECEBE OS VOTOS DESTINADOS AOS CANDIDATOS
        public float[] porcentagem = new float[frmGerencial.eleicao.getTamListaCandidatos()];//RECEBE A PORCENTAGEM DOS VOTOS
        public bool resultado = false;
        public int brancos =0;
        public int nulos = 0;
        public float porcentagemBrancos;
        public float porcentagemNulos;

        //----- AO MOSTRAR O FORMULÁRIO
        private void frmResulttados_Shown(object sender, EventArgs e)
        {
            frmGerencial.eleicao.restauraEleicao(frmGerencial.eleicao.getCodEleicao());
            preencheLb();
            zeraVotos();
            contaVotos();
            cadastroPorcentagem();
            resultadoFinal();
            lbVotacao.SelectedIndex = 0;
            lblTituloEleicao.Text = frmGerencial.eleicao.getTituloEleicao(frmGerencial.eleicao.getCodEleicao());
            lblTotalEleitores.Text = frmGerencial.eleicao.getQuantiVotos().ToString();
            lblVotosValidos.Text = (frmGerencial.eleicao.getQuantiVotos() - (nulos + brancos)).ToString();
            lblNulos.Text = porcentagemNulos.ToString("N2") + "%";
            lblBrancos.Text = porcentagemBrancos.ToString("N2") + "%";
        }


        //####################################  MÉTODOS QUE FAZ A MANIPULAÇÃO COM ELEMENTOS DO FORMULÁRIO  ####################################

        //----- PREENCHE A LISTA DE CANDIDATOS
        public void preencheLb()
        {
            lbVotacao.Items.Clear();//LIMPA A LISTBOX
            for(int i=0;i<frmGerencial.eleicao.getTamListaCandidatos();i++)//PERCORRE TODA A LISTA DE CANDIDATOS
            {
                lbVotacao.Items.Add(frmGerencial.eleicao.getNomeCompleto(i));//ATRIBUI O NOME DO CANDIDATO
            }
        }

        //----- AO CLICAR EM UM NOME DO LISTBOX, RETORNA OS DADOS DO CANDIDATO
        private void lbVotacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPartido.Text = frmGerencial.eleicao.getNomePartido(lbVotacao.SelectedIndex);
            lblNomeCandidato.Text = frmGerencial.eleicao.getNomeCompleto(lbVotacao.SelectedIndex);
            pbDescricao.Load(frmGerencial.eleicao.getFoto(lbVotacao.SelectedIndex));
            lblVotos.Text = votos[lbVotacao.SelectedIndex].ToString();
            lblPorcentagem.Text = porcentagem[lbVotacao.SelectedIndex].ToString("N2") + "%";
        }


        //####################################### MÉTODOS QUE FAZ A CONTABILIZAÇÃO DOS VOTOS ###########################################
        
        //----- FAZ A CONTAGEM DOS VOTOS
        public void contaVotos()
        {
            //--- VERIFICA VOTOS VÁLIDOS
            for (int j = 0; j < frmGerencial.eleicao.getTamListaCandidatos(); j++)//PERCORRE A LISTA DE CANDIDATOS
            {
                for (int i = 0; i < frmGerencial.eleicao.getQuantiVotos(); i++)//PERCORRE A LISTA DE VOTOS
                {
                    if (frmGerencial.eleicao.getNumPartido(j) == frmGerencial.eleicao.getVotos(i))//VERIFICA SE O VOTO DA LISTA CORRESPONDE AO PARTIDO DO CANDIDATO
                    {
                        votos[j] += 1;//INCREMENTA OS VOTOS
                    }
                }
            }

            //--- VERIFICA VOTOS NÃO VÁLIDOS
            for (int i = 0; i < frmGerencial.eleicao.getQuantiVotos(); i++)//PERCORRE A LISTA DE CANDIDATOS
            {
                if (frmGerencial.eleicao.getVotos(i) == -1)//SE O VOTO FOR = -1, INCREMENTA VOTOS NULOS
                {
                   nulos++;
                }
                else
                {
                    if(frmGerencial.eleicao.getVotos(i) == -2)//SE O VOTO FOR = -2, INCREMENTA OS VOTOS BRANCOS
                    {
                        brancos++;
                    }
                }
            }
        }

        //----- ZERA TODOS VOTOS DOS CANDIDATOS ANTES DA CONTABILIZAÇÃO DOS VOTOS
        public void zeraVotos()
        {
            for (int j = 0; j < frmGerencial.eleicao.getTamListaCandidatos(); j++)//PERCORRE A LISTA DE VOTOS
            {
                votos[j] = 0;//ZERA TODOS VOTOS
            }
        }

        //----- CADASTRA A PORCENTAGEM DOS CANDIDATOS
        public void cadastroPorcentagem()
        {
            float quantidadeVotos;//ARMAZENA A QUANTODADE TOTAL DE VOTOS
            for (int j = 0; j < frmGerencial.eleicao.getTamListaCandidatos(); j++)//PERCORRE A LISTA DE CANDIDATOS
            {
                quantidadeVotos = frmGerencial.eleicao.getQuantiVotos();//ATRIBUI A QUANTIDADE TOTAL DE VOTOS
                porcentagem[j] = votos[j] / quantidadeVotos *100 ;//A PORCENTAGEM NA POSIÇÃO RECEBE A PORCENTAGEM
            }
            quantidadeVotos = frmGerencial.eleicao.getQuantiVotos();
            porcentagemBrancos = brancos / quantidadeVotos * 100;//ATRIBUI A PORCENTAGEM DE VOTOS BRANCOS
            porcentagemNulos = nulos / quantidadeVotos * 100;//ATRIBUI A PORCENTAGEM DOS VOTOS NULOS
        }

        //----- VERIFICA O RESULTADO FINAL
        public void resultadoFinal()
        {
            int posicaoMaior = 0;//RECEBE A POSIÇÃO DO MAIS VOTADO
            int posicaoSegundo = 0;//RECEBE A POSIÇÃO DO SEGUNDO MAIS VOTADO
            for (int i = 0; i< frmGerencial.eleicao.getTamListaCandidatos();i++)//PERCORRE A LISTA DE CANDIDATOS
            {
                if (porcentagem[i] > 50)//SE A PORCENTAGEM FOR MAIOR QUE 50%
                {
                    //RECUPERA OS RESULTADOS DO VENCEDOR
                    resultado = true;
                    pb1Turno.Load(frmGerencial.eleicao.getFoto(i));
                    lblCandidato1Turno.Text = frmGerencial.eleicao.getNomeCompleto(i);
                    lblResultado.Text = "Eleição com vencedor em primeiro turno!";
                    lblCandidato1Turno.Visible = true;
                    pb2Turno1.Visible = false;
                    pb2Turno2.Visible = false;
                }
            }
            if (!resultado)//CASO A ELEIÇÃO NÃO TENHA VENCEDOR 
            {
                pb1Turno.Visible = false;
                pb1Turno.Enabled = false;
                if ((porcentagemBrancos + porcentagemNulos) > 50)//VERIFICA SE A QUANTIDADE DE VOTOS NÃO VÁLIDOS FOR MAIOR QUE 50%
                {
                    lblResultado.Text = "Eleição inválida! Uma nova eleição deve ser feita";
                }
                else//SENÃO
                {
                    float maior = porcentagem.Max();//RECEBE O VALOR DO MAIS VOTADO
                    for (int i = 0; i < frmGerencial.eleicao.getTamListaCandidatos(); i++)//PERCORRE A LISTA DE CANDIDATOS
                    {
                        if (porcentagem[i] == maior)
                        {
                            posicaoMaior = i;//VARIÁVEL DE MARCAÇÃO DA POSIÇÃO DO MAIOR VALOR
                        }
                    }

                    //--- DEFINIÇÃO DA POSIÇÃO E VALORES DOS MAIS VOTADOS
                    if (posicaoMaior != 0)
                    {
                        maior = porcentagem[0];
                        posicaoSegundo = 0;
                    }
                    else
                    {
                        maior = porcentagem[1];
                        posicaoSegundo = 1;
                    }

                    //--- FAZ A BUSCA PELOS 2 MAIS VOTADOS
                    for (int i = 1; i < frmGerencial.eleicao.getTamListaCandidatos(); i++)
                    {
                        if (porcentagem[i] > maior && posicaoMaior != i)//VERIFICA O SEGUNDO MAIS VOTADO
                        {
                            maior = porcentagem[i];
                            posicaoSegundo = i;
                        }
                    }
                    //MANIPULAÇÕES COM ELEMENTOS DO FORMULÁRIO
                    lblResultado.Text = "Eleição deverá ter segundo turno!";
                    pb2Turno1.Load(frmGerencial.eleicao.getFoto(posicaoMaior));
                    pb2Turno2.Load(frmGerencial.eleicao.getFoto(posicaoSegundo));
                    lbl1Cand2Turno.Text = frmGerencial.eleicao.getNomeCompleto(posicaoMaior);
                    lbl2Cand2Turno.Text = frmGerencial.eleicao.getNomeCompleto(posicaoSegundo);
                    lbl2Cand2Turno.Visible = true;
                    lbl1Cand2Turno.Visible = true;
                }
            }
        }
    }
}

