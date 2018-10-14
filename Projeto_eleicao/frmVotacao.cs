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

        private void btn1_Click(object sender, EventArgs e)
        {
            txtVoto.Text += '1';
        }







        private void btnBranco_Click(object sender, EventArgs e)
        {
            voto = -2;
            lblCandidato.Visible = true;
            lblCandidato.Text = "Branco";
            lblPartido.Visible = true;
            lblPartido.Text = "Branco";
            lblConfirma.Visible = true;
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

       
    }
}
