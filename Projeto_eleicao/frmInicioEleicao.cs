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
    public partial class frmInicioEleicao : Form
    {
        public frmInicioEleicao()
        {
            InitializeComponent();
        }

        private void rbIniciar_CheckedChanged(object sender, EventArgs e)
        {
            if(rbIniciar.Checked)
            {
                cbEleicao.Items.Clear();
                for (int i = 0; i < frmGerencial.eleicao.getTamanhoEleicao(); i++)
                {
                    if (frmGerencial.eleicao.getSituacaoEleicao(i) == 0)
                    {
                        cbEleicao.Items.Add((frmGerencial.eleicao.getCodigo(i) + " - " + frmGerencial.eleicao.getTituloEleicao(i) + " - " + frmGerencial.eleicao.getPais(i).ToString()));
                    }
                }
                btnIniciar.Enabled = true;
                btnContinuar.Enabled = false;
                cbEleicao.Enabled = true;
            }
        }

        private void rbAndamento_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAndamento.Checked)
            {
                cbEleicao.Items.Clear();
                for (int i = 0; i < frmGerencial.eleicao.getTamanhoEleicao(); i++)
                {
               
                    if (frmGerencial.eleicao.getSituacaoEleicao(i) == 1)
                    {
                        cbEleicao.Items.Add((frmGerencial.eleicao.getCodigo(i) + " - " + frmGerencial.eleicao.getTituloEleicao(i) + " - " + frmGerencial.eleicao.getPais(i).ToString()));
                    }
                }
                btnContinuar.Enabled = true;
                btnIniciar.Enabled = false;
                cbEleicao.Enabled = true;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string eleicao = cbEleicao.SelectedItem.ToString();
            for(int i=0;i<frmGerencial.eleicao.getTamanhoEleicao();i++)
            {
                if(int.Parse(eleicao[0].ToString()) == frmGerencial.eleicao.getCodigo(i))
                {
                    frmGerencial.eleicao.restauraEleicao(i);
                    frmGerencial.eleicao.setSituacaoEleicao(1);
                    frmGerencial.eleicao.insereLista(i);
                    frmVotacao frmVotacao = new frmVotacao();
                    frmVotacao.ShowDialog();
                }
            }
        }

       
    }
}
