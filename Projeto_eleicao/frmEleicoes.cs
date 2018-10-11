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
    public partial class frmEleicoes : Form
    {
        public frmEleicoes()
        {
            InitializeComponent();
        }


        int cod;
  
        public void limpaCampos()
        {
            txtCodigo.Clear();
            txtTituloEleicao.Clear();
            dtpDataEleicao.Value = DateTime.Today;
            cbPaises.SelectedIndex = -1;
            txtCodSeguranca.Clear();
        }

        public void liberaCampos(bool valida)
        {
            txtCodSeguranca.Enabled = valida;
            txtCodigo.Enabled = valida;
            txtTituloEleicao.Enabled = valida;
            dtpDataEleicao.Enabled = valida;
            cbPaises.Enabled = valida;
            cbCandidatos.Enabled = valida;
            dtpDataEleicao.Enabled = valida;
            btnAdicionar.Enabled = valida;
            btnRemover.Enabled = valida;
            btnCancelar.Enabled = valida;
            btnEditar.Enabled = valida;
        }

        public void restauraCampos()
        {
            txtCodigo.Text =frmGerencial.eleicao.getCodigo(cod).ToString();
            txtTituloEleicao.Text = frmGerencial.eleicao.getTituloEleicao(cod);
            dtpDataEleicao.Value = frmGerencial.eleicao.getDataEleicao(cod);
            cbPaises.SelectedIndex = (int)frmGerencial.eleicao.getPais(cod);
            txtCodSeguranca.Text = frmGerencial.eleicao.getCodigoSeguranca(cod);
            frmGerencial.eleicao.setListaCandidato(cod);
        }

     
        public void enviaDados()
        {
            frmGerencial.eleicao.setDataCadastro(DateTime.Today);
            frmGerencial.eleicao.setDataEleicao(dtpDataEleicao.Value);
            frmGerencial.eleicao.setTituloEleicao(txtTituloEleicao.Text);
            frmGerencial.eleicao.setCodigoEleicao(int.Parse(txtCodigo.Text));
            frmGerencial.eleicao.setPais(cbPaises.SelectedIndex);
            frmGerencial.eleicao.setCodigoSeguranca(txtCodSeguranca.Text);
            frmGerencial.eleicao.setSituacaoEleicao(0);
        }

        public void salvarCadastro()
        {
            if (frmGerencial.eleicao.getCodEleicao() == -1)
            {        
                enviaDados();
                frmGerencial.eleicao.insereLista();
                liberaCampos(false);
                limpaCampos();
                MessageBox.Show("Eleição cadastrada com sucesso!");
            }
            else
            { 
                enviaDados();
                frmGerencial.eleicao.insereLista(frmGerencial.eleicao.getCodEleicao());
                
                liberaCampos(false);
                limpaCampos();
                MessageBox.Show("Eleição alterada com sucesso!");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {             
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnNovo.Enabled = true;           
            salvarCadastro();
            frmGerencial.eleicao.limpaLista();
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            liberaCampos(true);
            frmGerencial.eleicao.setCodEleicao(-1);
            cbCandidatos.Items.Clear();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnEditar.Enabled = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        { 
            frmAlterarEleicao alterarEleicao = new frmAlterarEleicao();
            alterarEleicao.ShowDialog();
            cod = frmGerencial.eleicao.getCodEleicao();
            if(cod != -1)
            {
                restauraCampos();
                liberaCampos(true);
                btnNovo.Enabled = false;
                btnExcluir.Enabled = false;
                btnAlterar.Enabled = false;
                btnSalvar.Enabled = true;
            }
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            liberaCampos(false);
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmGerencial.eleicao.setIndice(-1);
            frmCandidatos Candidatos = new frmCandidatos();
            Candidatos.ShowDialog();
            preencheComboBox();
        }

        public void preencheComboBox()
        {
            cbCandidatos.Items.Clear();
           
                for(int i=0;i<frmGerencial.eleicao.getTamListaCandidatos();i++)
                {
                    cbCandidatos.Items.Add(frmGerencial.eleicao.getNomeCompleto(i));
                }
          
            
        }


        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (cbCandidatos.SelectedIndex >= 0)
            {
                frmGerencial.eleicao.removeCandidatoLista(cbCandidatos.SelectedIndex);
                preencheComboBox();
            }
            else
            {
                MessageBox.Show("Nenhuma eleição selecionada!");
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cbCandidatos.SelectedIndex >= 0)
            {
                frmGerencial.eleicao.setIndice(cbCandidatos.SelectedIndex);
                frmCandidatos frmEdicaoCandidatos = new frmCandidatos();
                frmEdicaoCandidatos.ShowDialog();
                preencheComboBox();
            }
            else
            {
                MessageBox.Show("Nenhuma eleição selecionada!");
            }
        }

       
        private void cbCandidatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            frmExclusaoEleicao frmExclusao = new frmExclusaoEleicao();
            frmExclusao.ShowDialog();
        }

        private void txtCodSeguranca_Validated(object sender, EventArgs e)
        {

        }

        private void txtCodSeguranca_Validating(object sender, CancelEventArgs e)
        {
            if (txtCodSeguranca.Text.Length<8)
            {
                e.Cancel = false;
                errorProvider.SetError(txtCodSeguranca, "Senha pequena");
            }
        }
    }
}