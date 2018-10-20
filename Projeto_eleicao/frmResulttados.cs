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
    public partial class frmResulttados : Form
    {
        public frmResulttados()
        {
            InitializeComponent();
        }
        public int[] votos = new int[frmGerencial.eleicao.getTamListaCandidatos()];
        public float[] porcentagem = new float[frmGerencial.eleicao.getTamListaCandidatos()];
        public bool resultado = false;
        public int brancos =0;
        public int nulos = 0;
        public float porcentagemBrancos;
        public float porcentagemNulos;

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

        public void preencheLb()
        {
            lbVotacao.Items.Clear();
            for(int i=0;i<frmGerencial.eleicao.getTamListaCandidatos();i++)
            {
                lbVotacao.Items.Add(frmGerencial.eleicao.getNomeCompleto(i));
            }
        }

        private void lbVotacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPartido.Text = frmGerencial.eleicao.getNomePartido(lbVotacao.SelectedIndex);
            lblNomeCandidato.Text = frmGerencial.eleicao.getNomeCompleto(lbVotacao.SelectedIndex);
            pbDescricao.Load(frmGerencial.eleicao.getFoto(lbVotacao.SelectedIndex));
            lblVotos.Text = votos[lbVotacao.SelectedIndex].ToString();
            lblPorcentagem.Text = porcentagem[lbVotacao.SelectedIndex].ToString("N2") + "%";
        }

        public void contaVotos()
        {
            for (int j = 0; j < frmGerencial.eleicao.getTamListaCandidatos(); j++)
            {
                for (int i = 0; i < frmGerencial.eleicao.getQuantiVotos(); i++)
                {
                    if (frmGerencial.eleicao.getNumPartido(j) == frmGerencial.eleicao.getVotos(i))
                    {
                        votos[j] += 1;
                    }
                }
            }

            for (int i = 0; i < frmGerencial.eleicao.getQuantiVotos(); i++)
            {
                if (frmGerencial.eleicao.getVotos(i) == -1)
                {
                   nulos++;
                }
                else
                {
                    if(frmGerencial.eleicao.getVotos(i) == -2)
                    {
                        brancos++;
                    }
                }
            }
        }
        public void zeraVotos()
        {
            for (int j = 0; j < frmGerencial.eleicao.getTamListaCandidatos(); j++)
            {
                votos[j] = 0;
            }
        }

        public void cadastroPorcentagem()
        {
            float quantidadeVotos;
            for (int j = 0; j < frmGerencial.eleicao.getTamListaCandidatos(); j++)
            {
                quantidadeVotos = frmGerencial.eleicao.getQuantiVotos();
                porcentagem[j] = votos[j] / quantidadeVotos *100 ;
            }
            quantidadeVotos = frmGerencial.eleicao.getQuantiVotos();
            porcentagemBrancos = brancos / quantidadeVotos * 100;
            porcentagemNulos = nulos / quantidadeVotos * 100;
        }

        public void resultadoFinal()
        {
            int posicaoMaior = 0;
            int posicaoSegundo = 0;
            for (int i = 0; i< frmGerencial.eleicao.getTamListaCandidatos();i++)
            {
                if (porcentagem[i] > 50)
                {
                    resultado = true;
                    pb1Turno.Load(frmGerencial.eleicao.getFoto(i));
                    lblCandidato1Turno.Text = frmGerencial.eleicao.getNomeCompleto(i);
                    lblResultado.Text = "Eleição com vencedor em primeiro turno!";
                    lblCandidato1Turno.Visible = true;
                    pb2Turno1.Visible = false;
                    pb2Turno2.Visible = false;
                }
            }
            if (!resultado)
            {
                pb1Turno.Visible = false;
                pb1Turno.Enabled = false;
                if ((porcentagemBrancos + porcentagemNulos) > 50)
                {
                    lblResultado.Text = "Eleição inválida! Uma nova eleição deve ser feita";
                }
                else
                {
                    float maior = porcentagem.Max();
                    for (int i = 0; i < frmGerencial.eleicao.getTamListaCandidatos(); i++)
                    {
                        if (porcentagem[i] == maior)
                        {
                            posicaoMaior = i;
                        }
                    }

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

                    for (int i = 1; i < frmGerencial.eleicao.getTamListaCandidatos(); i++)
                    {
                        if (porcentagem[i] > maior && posicaoMaior != i)
                        {
                            maior = porcentagem[1];
                            posicaoSegundo = 1;
                        }
                    }
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

