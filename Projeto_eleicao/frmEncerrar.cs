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
    public partial class frmEncerrar : Form
    {
        public frmEncerrar()
        {
            InitializeComponent();
        }

        public void preencheComboBox()
        {
            for (int i = 0; i < frmGerencial.eleicao.getTamanhoEleicao(); i++)
            {
                if (frmGerencial.eleicao.getSituacaoEleicao(i) == 1)
                {
                    int codigo = frmGerencial.eleicao.getCodigo(i);
                    string titulo = frmGerencial.eleicao.getTituloEleicao(i);
                    string pais = frmGerencial.eleicao.getPais(i).ToString();
                    cbEleicoes.Items.Add(codigo.ToString() + " - " + titulo + " - " + pais);
                }
            }
        }

        private void frmEncerrar_Shown(object sender, EventArgs e)
        {
            preencheComboBox();
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            string[] eleicao = cbEleicoes.SelectedItem.ToString().Split('-');
            for (int i = 0; i < frmGerencial.eleicao.getTamanhoEleicao(); i++)
            {
                if (int.Parse(eleicao[0].ToString()) == frmGerencial.eleicao.getCodigo(i))
                {
                    frmGerencial.eleicao.restauraEleicao(i);
                    frmGerencial.eleicao.setSituacaoEleicao(2);
                    frmGerencial.eleicao.insereLista(i);
                    cbEleicoes.Items.Clear();
                    preencheComboBox();
                    MessageBox.Show("Eleição encerrada com sucesso!");
                }
            }
        }
    }
}
