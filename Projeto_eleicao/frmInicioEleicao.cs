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
        //----- CONSTRUTOR
        public frmInicioEleicao()
        {
            InitializeComponent();
        }

        //----- RADIO BUTTON INICIAR
        private void rbIniciar_CheckedChanged(object sender, EventArgs e)
        {
            if(rbIniciar.Checked)//SE ESTIVER SELECIONADO
            {
                cbEleicao.Items.Clear();//LIMPA O COMBOBOX
                for (int i = 0; i < frmGerencial.eleicao.getTamanhoEleicao(); i++)
                {
                    if (frmGerencial.eleicao.getSituacaoEleicao(i) == 0)//CHECA SE A ELEIÇÃO NÃO FOI INICIADA
                    {
                        //ADICIONA VALORES NA COMBOBOX
                        cbEleicao.Items.Add((frmGerencial.eleicao.getCodigo(i) + " - " + frmGerencial.eleicao.getTituloEleicao(i) + " - " + frmGerencial.eleicao.getPais(i).ToString()));
                    }
                }
                //----- ALTERA VALORES DO FORMULÁRIO
                btnIniciar.Enabled = true;
                btnContinuar.Enabled = false;
                cbEleicao.Enabled = true;
            }
        }

        //----- RADIO BUTTON ANDAMENTO
        private void rbAndamento_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAndamento.Checked)//SE ESTIVER SELECIONADO
            {
                cbEleicao.Items.Clear();//LIMPA A COMBOBOX
                for (int i = 0; i < frmGerencial.eleicao.getTamanhoEleicao(); i++)
                {
                    if (frmGerencial.eleicao.getSituacaoEleicao(i) == 1)//CHECA SE A ELEIÇÃO JA FOI INICIADA
                    {
                        //ADICIONA ELEMENTOS NA COMBOBOX
                        cbEleicao.Items.Add((frmGerencial.eleicao.getCodigo(i) + " - " + frmGerencial.eleicao.getTituloEleicao(i) + " - " + frmGerencial.eleicao.getPais(i).ToString()));
                    }
                }
                //----- ALTERA VALORES DO FORMULÁRIO
                btnContinuar.Enabled = true;
                btnIniciar.Enabled = false;
                cbEleicao.Enabled = true;
            }
        }

        //----- BOTÃO INICIAR
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string[] eleicao = cbEleicao.SelectedItem.ToString().Split('-');//VARIÁVEL RECEBE A SUBSTRING REFERENTE AO CÓDIGO DA ELEIÇÃO
            for(int i=0;i<frmGerencial.eleicao.getTamanhoEleicao();i++)
            {
                if (int.Parse(eleicao[0].ToString()) == frmGerencial.eleicao.getCodigo(i))//VERIFICA SE O ITEM SELECIONA CORRESPONDE AO CADASTRO NA LISTA
                {
                    if (frmGerencial.eleicao.getDataEleicao(i).ToShortDateString() == DateTime.Now.ToShortDateString())
                    {
                        frmGerencial.eleicao.setCodEleicao(i);
                        frmCodigoSegurancacs codigoSeguranca = new frmCodigoSegurancacs();
                        codigoSeguranca.ShowDialog();
                        cbEleicao.Items.Clear();//LIMPA OS VALORES DO COMBOBOX
                        rbIniciar.Checked = true;//RETORNA OS VALORES PARA A COMBOBOX
                        frmVotacao frmVotacao = new frmVotacao();//ABRE O FORMULÁRIO PARA VOTAÇÃO
                        frmVotacao.ShowDialog();
                    }
                    else
                    {
                        TimeSpan dias = (frmGerencial.eleicao.getDataEleicao(i) - DateTime.Now);
                        MessageBox.Show("impossível iniciar eleição! Restam: " + dias.Days + " dias para poder iniciar!");
                    }
                }
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            string[] eleicao = cbEleicao.SelectedItem.ToString().Split('-');//VARIÁVEL RECEBE A SUBSTRING REFERENTE AO CÓDIGO DA ELEIÇÃO
            for (int i = 0; i < frmGerencial.eleicao.getTamanhoEleicao(); i++)
            {
                if (int.Parse(eleicao[0].ToString()) == frmGerencial.eleicao.getCodigo(i))//VERIFICA SE O ITEM SELECIONA CORRESPONDE AO CADASTRO NA LISTA
                {
                    frmGerencial.eleicao.setCodEleicao(i);
                    frmVotacao frmVotacao = new frmVotacao();//ABRE O FORMULÁRIO PARA VOTAÇÃO
                    frmVotacao.ShowDialog();
                }
            }
        }
    }
}
