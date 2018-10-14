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

        private void btn1_Click(object sender, EventArgs e)
        {
            txtVoto.Text += '1';
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            buscaCandidato();
        }


        public void buscaCandidato()
        {
            frmGerencial.eleicao.restauraEleicao(frmGerencial.eleicao.getCodEleicao());
            for (int i = 0; i < frmGerencial.eleicao.getTamListaCandidatos(); i++)
            {
                if (int.Parse(txtVoto.Text) == frmGerencial.eleicao.getNumPartido(i))
                {
                    MessageBox.Show(frmGerencial.eleicao.getFoto(i));
                    lblCandidato.Visible = true;
                    lblCandidato.Text = frmGerencial.eleicao.getNomeCompleto(i);
                    lblPartido.Visible = true;
                    lblPartido.Text = frmGerencial.eleicao.getNomePartido(i);
                    pbCandidato.Load(frmGerencial.eleicao.getFoto(i));
                    lblConfirma.Visible = true;
                }
            }
        }

    }
}
