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
    public partial class frmResultadoEleicao : Form
    {
        public frmResultadoEleicao()
        {
            InitializeComponent();
        }

        private void frmResultadoEleicao_Load(object sender, EventArgs e)
        {
            
        }


        public void preencheDataGridView(int i)
        {
            dgvEleicao.Rows.Clear();
            if (i == 1)
            {
                for (int j = 0; j < frmGerencial.eleicao.getTamanhoEleicao(); j++)
                {
                    int codigo = frmGerencial.eleicao.getCodigo(j);
                    string titulo = frmGerencial.eleicao.getTituloEleicao(j); ;
                    DateTime data = frmGerencial.eleicao.getDataEleicao(j);
                    data.ToShortDateString();
                    int situacao = frmGerencial.eleicao.getSituacaoEleicao(j);
                    string stringSituacao;
                    if (situacao == 0)
                    {
                        stringSituacao = "Cadastrada";
                    }
                    else
                    {
                        if (situacao == 1)
                        {
                            stringSituacao = "Em andamento";
                        }
                        else
                        {
                            stringSituacao = "Encerrada";
                        }
                    }
                    dgvEleicao.Rows.Add(codigo.ToString(), titulo, data.ToShortDateString(), stringSituacao);

                }
            }
            else
            {
                if (i == 0)
                {
                    for (int j = 0; j < frmGerencial.eleicao.getTamanhoEleicao(); j++)
                    {
                        int codigo = frmGerencial.eleicao.getCodigo(j);
                        string titulo = frmGerencial.eleicao.getTituloEleicao(j); 
                        DateTime data = frmGerencial.eleicao.getDataEleicao(j);
                        data.ToShortDateString();
                        int situacao = frmGerencial.eleicao.getSituacaoEleicao(j);
                        if (situacao == cbSituacao.SelectedIndex)
                        {
                            string stringSituacao;
                            if (situacao == 0)
                            {
                                stringSituacao = "Cadastrada";
                            }
                            else
                            {
                                if (situacao == 1)
                                {
                                    stringSituacao = "Em andamento";
                                }
                                else
                                {
                                    stringSituacao = "Encerrada";
                                }
                            }
                            dgvEleicao.Rows.Add(codigo.ToString(), titulo, data.ToShortDateString(), stringSituacao);
                        }
                    }
                }
                else
                {
                    if (i == 2)
                    {
                        for (int j = 0; j < frmGerencial.eleicao.getTamanhoEleicao(); j++)
                        {
                            int codigo = frmGerencial.eleicao.getCodigo(j);
                            string titulo = frmGerencial.eleicao.getTituloEleicao(j);
                            DateTime data = frmGerencial.eleicao.getDataEleicao(j);
                            data.ToShortDateString();
                            int situacao = frmGerencial.eleicao.getSituacaoEleicao(j);
                            int comparaInicio = DateTime.Compare(data, dtpInicio.Value);
                            int comparaFim = DateTime.Compare(data, dtpFim.Value);
                            if (comparaInicio >= 0 && comparaFim <= 0)
                            {
                                string stringSituacao;
                                if (situacao == 0)
                                {
                                    stringSituacao = "Cadastrada";
                                }
                                else
                                {
                                    if (situacao == 1)
                                    {
                                        stringSituacao = "Em andamento";
                                    }
                                    else
                                    {
                                        stringSituacao = "Encerrada";

                                    }
                                }
                                dgvEleicao.Rows.Add(codigo, titulo, data.ToShortDateString(), stringSituacao);
                            }
                        }
                    }
                }
            }
        }

        //----- BOTÃO RESULTADO
        private void btnResultado_Click(object sender, EventArgs e)
        {
            int indice = dgvEleicao.CurrentRow.Index;
            for (int k = 0; k < frmGerencial.eleicao.getTamanhoEleicao(); k++)
            {
                if (int.Parse(dgvEleicao[0, indice].Value.ToString()) == frmGerencial.eleicao.getCodigo(k))
                {
                    if (dgvEleicao[3, indice].Value.ToString() == "Encerrada")
                    {
                        frmGerencial.eleicao.setCodEleicao(k);
                        frmResulttados frmVerResultados = new frmResulttados();
                        frmVerResultados.ShowDialog();
                    }
                }         
            }
        }

        private void rbData_CheckedChanged(object sender, EventArgs e)
        {
            if(rbData.Checked)
            {
                cbSituacao.Enabled = false;
                dtpInicio.Enabled = true;
                dtpFim.Enabled = true;
            }
        }

        private void rbSituacao_CheckedChanged(object sender, EventArgs e)
        {
            if(rbSituacao.Checked)
            {
                cbSituacao.Enabled = true;
                dtpInicio.Enabled = false;
                dtpFim.Enabled = false;
            }
        }

       
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (rbSituacao.Checked)
                preencheDataGridView(0);
            else
                preencheDataGridView(2);
        }

        private void frmResultadoEleicao_Shown(object sender, EventArgs e)
        {
            preencheDataGridView(1);
        }
    }
}
