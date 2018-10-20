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
    public partial class frmCodigoSegurancacs : Form
    {
        public frmCodigoSegurancacs()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == frmGerencial.eleicao.getCodigoSeguranca(frmGerencial.eleicao.getCodEleicao()))
            {
                if (frmGerencial.eleicao.getSituacaoEleicao(frmGerencial.eleicao.getCodEleicao()) == 0)
                {
                    frmGerencial.eleicao.restauraEleicao(frmGerencial.eleicao.getCodEleicao());//RETORNA OS DADOS DA ELEIÇÃO
                    frmGerencial.eleicao.setSituacaoEleicao(1);//ATUALIZA O VALOR DA SITUAÇÃO DA ELEIÇÃO PARA "1", QUE INDICARÁ QUE ESTÁ APTA A VOTAÇÃO
                    frmGerencial.eleicao.insereLista(frmGerencial.eleicao.getCodEleicao());//SALVA OS DADOS NA LISTA
                    this.Close();
                }
                else
                {
                    if (frmGerencial.eleicao.getSituacaoEleicao(frmGerencial.eleicao.getCodEleicao()) == 1)
                    {
                        frmGerencial.eleicao.restauraEleicao(frmGerencial.eleicao.getCodEleicao());//RETORNA OS DADOS DA ELEIÇÃO
                        frmGerencial.eleicao.setSituacaoEleicao(2);//ATUALIZA O VALOR DA SITUAÇÃO DA ELEIÇÃO PARA "1", QUE INDICARÁ QUE ESTÁ APTA A VOTAÇÃO
                        frmGerencial.eleicao.insereLista(frmGerencial.eleicao.getCodEleicao());//SALVA OS DADOS NA LISTA
                        MessageBox.Show("Eleição encerrada com sucesso!");
                        this.Close();
                    }
                    else
                    {
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
