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
    //##################################################################################################################################

    //                                                  FORMULÁRIO GERENCIAL DA ELEIÇÃO

    //##################################################################################################################################

    public partial class frmGerencial : Form
    {
        //################################################  MÉTODOS AO INICIAR FORMULÁRIO  #############################################

        //----- CONSTRUTOR
        public frmGerencial()
        {
            InitializeComponent();
        }

        
        //###################################################  VARIÁVEIS  ##############################################################

        //----- INSTANCIA DE NOVO MEBRO DA CLASSE DE ELEIÇÃO
        public static Eleicao eleicao = new Eleicao();


        //######################################## MÉTODOS COM MANIPULAÇÃO DE ELEMENTOS DO FORMULÁRIO  ######################################

        //----- BOTÃO CADASTRAR
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmEleicoes frmEleicoes = new frmEleicoes();//ABRE O CADASTRO DE ELEIÇÕES
            frmEleicoes.ShowDialog();
        }

        //----- BOTÃO SOBRE
        private void btnSobre_Click(object sender, EventArgs e)
        {
            frmSobre frmAbout = new frmSobre();//ABRE A OPÇÃO SOBRE
            frmAbout.ShowDialog();
        }

        //----- BOTÃO DOCUMENTAÇÃO
        private void btnDocumentação_Click(object sender, EventArgs e)
        {
            ViwerPDF ViwerPDF = new ViwerPDF();//ABRE A DOCUMENTAÇÃO
            ViwerPDF.ShowDialog();
        }

        //----- BOTÃO INICIAR
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            frmInicioEleicao frmIniciaEleicao = new frmInicioEleicao();//ABRE FORMULÁRIO DE INÍCIO DE ELEIÇÃO
            frmIniciaEleicao.ShowDialog();
        }

        //----- BOTÃO RESULTADOS
        private void btnResultados_Click(object sender, EventArgs e)
        {
            frmResultadoEleicao frmResultado = new frmResultadoEleicao();//ABRE A TELA DE RESULTADOS
            frmResultado.ShowDialog();
        }

        //----- BOTÃO ENCERRAR
        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            frmEncerrar frmEncerra = new frmEncerrar();//ENCERRA DETERMINADA ELEIÇÃO
            frmEncerra.ShowDialog();
        }

        //----- BOTÃO FECHAR
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();//FECHA A APLICAÇÃO
        }

        //----- BARRA DE FERRAMENTAS - ENCERRAR
        private void tsmEncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();//FECHA A APLICAÇÃO
        }

        //----- BARRA DE FERRAMENTAS - CADASTRAR
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEleicoes frmEleicoes = new frmEleicoes();//ABRE FORMULÁRIO PARA CADASTRO DE ELEIÇÕES
            frmEleicoes.ShowDialog();
        }

        //----- BARRA DE FERRAMENTAS - INICIAR ELEIÇÃO
        private void iniciarEleiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInicioEleicao frmIniciaEleicao = new frmInicioEleicao();//ABRE TELA DE INICIALIZAÇÃO DE ELEIÇÃO
            frmIniciaEleicao.ShowDialog();
        }

        //----- BARRA DE FERRAMENTAS - ENCERRAR ELEIÇÃO
        private void encerrarEleiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEncerrar frmEncerra = new frmEncerrar();//ABRE TELA DE ENCERRAMENTO DE ELEIÇÃO
            frmEncerra.ShowDialog();
        }

        //----- BARRA DE FERRAMENTAS - RESULTADOS
        private void resultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResultadoEleicao frmResultado = new frmResultadoEleicao();//ABRE FORMULÁRIO DE RESULTADOS
            frmResultado.ShowDialog();
        }

        //----- BARRA DE FERRAMENTAS - SOBRE
        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSobre frmAbout = new frmSobre();//ABRE TELA DO SOBRE
            frmAbout.ShowDialog();
        }

        //----- BARRA DE FERRAMENTAS - DOCUMENTAÇÃO
        private void documentaçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViwerPDF ViwerPDF = new ViwerPDF();//ABRE A DOCUMENTAÇÃO
            ViwerPDF.ShowDialog();
        }
    }
}
