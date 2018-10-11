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
    public partial class frmCandidatos : Form
    {
        public int eleicao;
        public frmCandidatos()
        {
            InitializeComponent();
        }
        

        private void frmCandidatos_Shown(object sender, EventArgs e)
        {
           if (frmGerencial.eleicao.getIndice() != -1)
            {
                LiberaCampos(true);
                btnNovo.Enabled = false;
                restauraDados();
            }
        }

        //--VARIÁVEL AUXILIAR, QUE INDICARÁ A POSIÇÃO DO CADASTRO A SER ALTERADA
        //OU RECUPERADA
        int i;

        //---MÉTODOS DE MANIPULAÇÃO COM DADOS NO FORMULÁRIO
        //######################################################################

        //--FAZ O BL0QUEIO E DESBLOQUEIO DE CAMPOS, RECEBENTO POR PARAMETRO A AÇÃO
        public void LiberaCampos(bool libera)
        {
            btnSalvar.Enabled = libera;
            txtNascimento.Enabled = libera;
            txtNomeAbreviado.Enabled = libera;
            txtNascimento.Enabled = libera;
            txtNomeCompleto.Enabled = libera;
            txtPartidoNome.Enabled = libera;
            txtPartidoNum.Enabled = libera;
            btnSelecionar.Enabled = libera;
        }

        //--FAZ A LIMPEZA DOS CAMPOS DO FORMULÁRIO
        public void LimpaCampos()
        {
            txtNascimento.Text = txtNomeAbreviado.Text = txtNomeCompleto.Text =
            txtPartidoNome.Text = txtPartidoNum.Text = string.Empty;
        }

        public void restauraDados()
        {
            txtNascimento.Text = frmGerencial.eleicao.getNascimento(frmGerencial.eleicao.getIndice());
            txtNomeAbreviado.Text = frmGerencial.eleicao.getNomeAbreviado(frmGerencial.eleicao.getIndice());
            txtNomeCompleto.Text = frmGerencial.eleicao.getNomeCompleto(frmGerencial.eleicao.getIndice());
            txtPartidoNome.Text = frmGerencial.eleicao.getNomePartido(frmGerencial.eleicao.getIndice());
            txtPartidoNum.Text = frmGerencial.eleicao.getNumPartido(frmGerencial.eleicao.getIndice()).ToString();
            pbFoto.Load(frmGerencial.eleicao.getFoto(frmGerencial.eleicao.getIndice()).ToString());
        }
       
    
        public void DesabilitaBotoes()
        {
            btnNovo.Enabled = false;
        }

       
        public void EnviaDados()
        {
            frmGerencial.eleicao.setNascimento(txtNascimento.Text);
            frmGerencial.eleicao.setNomeAbreviado(txtNomeAbreviado.Text);
            frmGerencial.eleicao.setNomeCompleto(txtNomeCompleto.Text);
            frmGerencial.eleicao.setNomePartido(txtPartidoNome.Text);
            frmGerencial.eleicao.setNumPartido(int.Parse(txtPartidoNum.Text));
        }

        //--MÉTODO QUE SALVA OS ATRIBUTOS EM LISTA
        public void salvarCadastro()
        {
            //-SE O CÓDIGO TIVER -1, UM NOVO CADASTRO SERÁ INCLUÍDO
           if (frmGerencial.eleicao.getIndice() == -1)
            {
                EnviaDados();
                //ATRIBUI OS VALORES QUE ESTÃO NA STRUCT CANDIDATOS PARA A LISTA
                frmGerencial.eleicao.insereCandidato();
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            else
            { 
                EnviaDados();
                frmGerencial.eleicao.insereCandidato(frmGerencial.eleicao.getIndice());
                
                MessageBox.Show("Cadastro alterado com sucesso!");
            }
        }

      
        
        private void btnNovo_Click(object sender, EventArgs e)
        {
            LiberaCampos(true);
            frmGerencial.eleicao.setIndice(-1);
            DesabilitaBotoes();
        }

    
     
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvarCadastro();
            
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnSelecionar.Enabled = false;
            LiberaCampos(false);
            pbFoto.Image = pbFoto.InitialImage;
            LimpaCampos();
            frmGerencial.eleicao.setIndice(-1);
            this.Close();
        }

        //--AO CLICLAR NO BOTÃO SAIR
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //--AO CLICAR NO BOTÃO SELECIONAR DA IMAGEM
        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            //-ABRE A CAIXA DE DIALOGO EM BUSCA DO DIRETORIO CONTENDO IMAGEM
            openFileDialog1.ShowDialog();
            if(openFileDialog1.FileName != null)
            {
                //ATRIBUI A IMAGEM SELECIONADA AO CAMPO PICBOX
                pbFoto.Load(openFileDialog1.FileName);
                frmGerencial.eleicao.setFoto(openFileDialog1.FileName);
            }
        }

        private void txtNomeCompleto_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
