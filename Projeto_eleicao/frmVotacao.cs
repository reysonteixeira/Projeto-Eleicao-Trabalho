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
    public partial class frmVotacao : Form
    {
        public frmVotacao()
        {
            InitializeComponent();
        }

        public bool nulo = true;
        public int voto;

        //CLIQUE NO BOTAO BRANCO
        private void btnBranco_Click(object sender, EventArgs e)
        {
            voto = -2;
            lblCandidato.Visible = true;
            lblCandidato.Text = "Branco";
            lblPartido.Visible = true;
            lblPartido.Text = "Branco";
            lblConfirma.Visible = true;
            txtVoto.Focus();
        }

        //----- FAZ A BUSCA PARA CONFERIR SE O VOTO FOI COMPUTADO
        public void buscaCandidato()
        {
            frmGerencial.eleicao.restauraEleicao(frmGerencial.eleicao.getCodEleicao());
            for (int i = 0; i < frmGerencial.eleicao.getTamListaCandidatos(); i++)
            {
                if (int.Parse(txtVoto.Text) == frmGerencial.eleicao.getNumPartido(i))
                {
                    lblCandidato.Visible = true;
                    lblCandidato.Text = frmGerencial.eleicao.getNomeCompleto(i);
                    lblPartido.Visible = true;
                    lblPartido.Text = frmGerencial.eleicao.getNomePartido(i);
                    pbCandidato.Load(frmGerencial.eleicao.getFoto(i));
                    lblConfirma.Visible = true;
                    nulo = false;
                    voto = int.Parse(txtVoto.Text);
                }
            }
            if(nulo)
            {
                lblCandidato.Visible = true;
                lblCandidato.Text = "Nulo";
                lblPartido.Visible = true;
                lblPartido.Text = "Nulo";
                lblConfirma.Visible = true;
                voto = -1;
            }
        }

        //----- CONFIRMAÇÃO DO VOTO E REGISTRO DO MESMO
        public void registraVotos()
        {
            frmGerencial.eleicao.registraVotos(voto);
            frmGerencial.eleicao.insereLista(frmGerencial.eleicao.getCodEleicao());
            resetaFormulario();
        }

        //----- LIMPA O FORMULÁRIO APÓS O VOTO
        public void resetaFormulario()
        {
            txtVoto.Text = string.Empty;
            nulo = true;
            pbCandidato.Image = pbCandidato.InitialImage;
            lblCandidato.Visible = false;
            lblPartido.Visible = false;
            lblConfirma.Visible = false;
        }

        //QUANDO CLICAR NO BOTAO 1, MOSTRA O NUMERO NO TEXTBOX
        private void btn1_Click(object sender, EventArgs e)
        {
            txtVoto.Text += '1';
            txtVoto.Focus();
        }
        //QUANDO CLICAR NO BOTAO 2, MOSTRA O NUMERO NO TEXTBOX
        private void btn2_Click(object sender, EventArgs e)
        {
            txtVoto.Text += '2';
            txtVoto.Focus();
        }
        //QUANDO CLICAR NO BOTAO 3, MOSTRA O NUMERO NO TEXTBOX
        private void btn3_Click(object sender, EventArgs e)
        {
            txtVoto.Text += '3';
            txtVoto.Focus();
        }
        //QUANDO CLICAR NO BOTAO 4, MOSTRA O NUMERO NO TEXTBOX
        private void btn4_Click(object sender, EventArgs e)
        {
            txtVoto.Text += '4';
            txtVoto.Focus();
        }
        //QUANDO CLICAR NO BOTAO 5, MOSTRA O NUMERO NO TEXTBOX
        private void btn5_Click(object sender, EventArgs e)
        {
            txtVoto.Text += '5';
            txtVoto.Focus();
        }
        //QUANDO CLICAR NO BOTAO 6, MOSTRA O NUMERO NO TEXTBOX
        private void btn6_Click(object sender, EventArgs e)
        {
            txtVoto.Text += '6';
            txtVoto.Focus();
        }
        //QUANDO CLICAR NO BOTAO 7, MOSTRA O NUMERO NO TEXTBOX
        private void btn7_Click(object sender, EventArgs e)
        {
            txtVoto.Text += '7';
            txtVoto.Focus();
        }
        //QUANDO CLICAR NO BOTAO 8, MOSTRA O NUMERO NO TEXTBOX
        private void btn8_Click(object sender, EventArgs e)
        {
            txtVoto.Text += '8';
            txtVoto.Focus();
        }
        //QUANDO CLICAR NO BOTAO 9, MOSTRA O NUMERO NO TEXTBOX
        private void btn9_Click(object sender, EventArgs e)
        {
            txtVoto.Text += '9';
            txtVoto.Focus();
        }
        //QUANDO CLICAR NO BOTAO 0, MOSTRA O NUMERO NO TEXTBOX
        private void btn0_Click(object sender, EventArgs e)
        {
            txtVoto.Text += '0';
            txtVoto.Focus();
        }
        //METODO QUE EXECUTA O BARULHO DA URNA AO COMPUTAR VOTO
        private void playSimpleSound()
        {
            System.Media.SoundPlayer simpleSound = new System.Media.SoundPlayer(@"../../Sons/Urna.wav");
            simpleSound.Play(); 
        }

        //METODO DE PRESSIONAR TELCA
        private void frmVotacao_KeyDown(object sender, KeyEventArgs e)
        {
            //SE TECLA SHIFT + F8 PRESSIONADAS FECHAR O FORM
            if (e.Shift && e.KeyCode == Keys.F8)
            {
                this.Close();
            }
            //SE TECLA ALT + F4 IMPEDIR O FORM DE FECHAR
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                e.Handled = true;
            }

            //SE A TELCA PRESSIONADO FOR ENTER
            if (e.KeyCode == Keys.Enter)
            {
                pbCandidato.Focus();
                //VERIFICA SE TXTVOTO ESTA VAZIO OU COM ESPACO EM BRANCO
                if (string.IsNullOrEmpty(txtVoto.Text))
                {
                    MessageBox.Show("Digite um Candidato");
                    resetaFormulario();
                    txtVoto.Focus();
                }
                //SE NAO ESTIVER VAZIO OU COM ESPACO EM BRANCO
                if (!string.IsNullOrEmpty(txtVoto.Text))
                {
                    buscaCandidato();
                }               
            }
            //SE A TECLA PRESSIONADA FOR S E CAMPO DE VOTO NAO ESTIVER VAZIO GRAVA VOTO
            if (e.KeyValue == 83 && !string.IsNullOrEmpty(txtVoto.Text))
            {
                registraVotos();
                playSimpleSound();
                resetaFormulario();
                //ABRIR FORM COM TIMER E PROGRESBAR
                frmTempo frmTempo = new frmTempo();
                frmTempo.ShowDialog();
            }
            //SE A TECLA PRESSIONADA FOR N E CAMPO DE VOTO NAO ESTIVER VAZIO RESETA O FORM
            if (e.KeyValue == 78 && !string.IsNullOrEmpty(txtVoto.Text))
            {
                resetaFormulario();
            }
        }

    }
}
