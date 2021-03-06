﻿using System;
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
    //#################################################################################################################################

    //                                            FORMULÁRIO DE CADASTRO DE ELEIÇÕES

    //#################################################################################################################################

    public partial class frmEleicoes : Form
    {
        //######################################### MÉTODOS AO CARREGAR FORMULÁRIO  ###################################################

        //----- MÉTODO CONSTRUTOR
        public frmEleicoes()
        {
            InitializeComponent();
        }

        //####################################################   VARIÁVEIS   ##########################################################

        int cod;//ARMAZENARÁ O INDICE DA ELEIÇÃO QUE SERÁ EDITADA
  
        //#######################################  MANIPULAÇÃO COM ELEMENTOS DO FORMULÁRIO  ##########################################

        //----- LIMPA OS VALORES CONTIDOS NO FORMULÁRIO
        public void limpaCampos()
        {
            txtCodigo.Clear();
            txtTituloEleicao.Clear();
            dtpDataEleicao.Value = DateTime.Today;
            cbPaises.SelectedIndex = -1;
            txtCodSeguranca.Clear();
        }

        public bool NaoContemLetras(string texto)
        {
            if (texto.Where(c => char.IsLetter(c)).Count() <= 0)
                return true;
            else
                return false;
        }

        public bool NaoContemNumeros(string texto)
        {
            if (texto.Where(c => char.IsNumber(c)).Count() <= 0)
                return true;
            else
                return false;
        }

        //----- HABILITA OU DESABILITA CAMPOS DO FORMULÁRIO PARA ENTRADA DE DADOS
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

        //----- RESTAURA VALORES DA LISTA DE ELEIÇÕES
        public void restauraCampos()// BUSCA PELO ELEMENTO CONTIDO NA POSIÇÃO DA LISTA ENVIADO POR PARAMETRO
        {
                txtCodigo.Text = frmGerencial.eleicao.getCodigo(cod).ToString();
                txtTituloEleicao.Text = frmGerencial.eleicao.getTituloEleicao(cod);
                dtpDataEleicao.Value = frmGerencial.eleicao.getDataEleicao(cod);
                //---- TEMP CAST DO VALOR GUARDADO NO ENUM DE PAISES
                cbPaises.SelectedIndex = (int)frmGerencial.eleicao.getPais(cod);
                txtCodSeguranca.Text = frmGerencial.eleicao.getCodigoSeguranca(cod);
                frmGerencial.eleicao.setListaCandidato(cod);
        }

        //----- FAZ O PREENCHIMENTO DO COMBOBOX DE CANDIDATOS COM OS NOMES DE CANDIDATOS JÁ CADASTRADOS
        public void preencheComboBox()
        {
            //-- LIMPA OS VALORES JÁ PRESENTES NO COMBOBOX
            cbCandidatos.Items.Clear();
            //-- PERCORRE A LISTA DE CANDIDATOS
            for (int i = 0; i < frmGerencial.eleicao.getTamListaCandidatos(); i++)
            {
                cbCandidatos.Items.Add(frmGerencial.eleicao.getNomeCompleto(i));//ADICIONA O ELEMENTO DA POSIÇÃO "I" NO COMBOBOX
            }
        }


        //##########################################   ENVIO DE DADOS PARA A LISTA   ##################################################

        //----- TRANSFERE OS VALORES DO FORMULÁRIO PARA SER SALVO
        public void enviaDados()
        {
            frmGerencial.eleicao.setDataCadastro(DateTime.Today);//PASSADO O DIA ATUAL COMO PARAMETRO
            frmGerencial.eleicao.setDataEleicao(dtpDataEleicao.Value.Date);
            frmGerencial.eleicao.setTituloEleicao(txtTituloEleicao.Text);
            frmGerencial.eleicao.setCodigoEleicao(int.Parse(txtCodigo.Text));
            frmGerencial.eleicao.setPais(cbPaises.SelectedIndex);
            frmGerencial.eleicao.setCodigoSeguranca(txtCodSeguranca.Text);
            frmGerencial.eleicao.setSituacaoEleicao(0);//SITUAÇÃO 0, MOSTRA QUE A ELEIÇÃO NÃO FOI INICIADA
        }

        //----- FAZ A INSERÇÃO DOS VALORES NA LISTA
        public void salvarCadastro()
        {
            if (frmGerencial.eleicao.getCodEleicao() == -1)//-1 REPRESENTA QUE UM NOVO CADASTRO SERÁ INCLUSO
            {        
                enviaDados();
                frmGerencial.eleicao.insereLista();
                liberaCampos(false);
                limpaCampos();
                MessageBox.Show("Eleição cadastrada com sucesso!");
            }
            else// O DADO SERÁ GUARDADO NA POSIÇÃO ENVIADO POR PARAMETRO, MOSTRA QUE O MESMO FAZ PARTE DE UMA EDIÇÃO
            { 
                enviaDados();
                frmGerencial.eleicao.insereLista(frmGerencial.eleicao.getCodEleicao());
                liberaCampos(false);
                limpaCampos();
                MessageBox.Show("Eleição alterada com sucesso!");
            }
        }


        //############################################  MANIPULAÇÃO DE ELEIÇÕES  ######################################################

        //--- BOTÃO SALVAR
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // ----- VERIFICA SE O QUE FOI DIGITADO PELO USUÁRIO EM TODOS OS CAMPOS ATENDE A TODOS OS REQUISITOS ANTES DE SALVAR OS DADOS
            if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtTituloEleicao.Text) || string.IsNullOrEmpty(txtCodSeguranca.Text) || NaoContemLetras(txtCodSeguranca.Text) || NaoContemNumeros(txtCodSeguranca.Text) || txtCodSeguranca.Text.Length < 8 || cbPaises.SelectedIndex == -1)
            {
                MessageBox.Show("Todos os campos devem ser preenchidos corretamente");
            }
            else
            {
                if (frmGerencial.eleicao.getTamListaCandidatos() >= 2)
                {
                    btnSalvar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnAlterar.Enabled = true;
                    btnExcluir.Enabled = true;
                    btnNovo.Enabled = true;
                    salvarCadastro();
                    frmGerencial.eleicao.limpaLista();
                }
                else
                {
                    MessageBox.Show("É necessário cadastrar ao menos 2 candidatos!");
                }
            }
        }

        //--- BOTÃO NOVO
        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmGerencial.eleicao.limpaLista();
            frmGerencial.eleicao.instanciaVotos();
            liberaCampos(true);
            frmGerencial.eleicao.setCodEleicao(-1);
            cbCandidatos.Items.Clear();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnEditar.Enabled = true;
        }

        //--- BOTÃO ALTERAR
        private void btnAlterar_Click(object sender, EventArgs e)
        { 
            frmAlterarEleicao alterarEleicao = new frmAlterarEleicao();
            alterarEleicao.ShowDialog();
            if (frmGerencial.eleicao.getCodEleicao() >= 0)
            {
                cod = frmGerencial.eleicao.getCodEleicao();//COD RECEBE O VALOR DO INDICE APÓS SELEÇÃO DE ELEIÇÃO, SENDO QUE SERÁ UTILIZADO COMO MARCADOR DE POSIÇÃO DE EDIÇÃO
                //-- RESTAURA TODOS VALORES PARA EDIÇÃO
                liberaCampos(true);
                btnNovo.Enabled = false;
                btnExcluir.Enabled = false;
                btnAlterar.Enabled = false;
                btnSalvar.Enabled = true;
                restauraCampos();
                preencheComboBox();
            }
        }

        //--- BOTÃO SAIR
        private void btnSair_Click(object sender, EventArgs e)
        {
            //-- INSTANCIA LISTA DE MODO QUE ZERA CANDIDATOS DA LISTA DE CANDIDATOS
            frmGerencial.eleicao.limpaLista();
            this.Close();//ENCERtA A JANELA ATUAL
        }

        //--- BOTÃO CANCELAR
        private void btnCancelar_Click(object sender, EventArgs e)//LIMPA TODOS CAMPO E OS DESABILITA
        {
            limpaCampos();
            liberaCampos(false);
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            //-- INSTANCIA LISTA DE MODO QUE ZERA CANDIDATOS DA LISTA DE CANDIDATOS
            frmGerencial.eleicao.limpaLista();
        }

        //--- BOTÃO EXCLUIR
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //-- ABRE O FORMULÁRIO PARA EXCLUSÃO DE ELEIÇÃO
            frmExclusaoEleicao frmExclusao = new frmExclusaoEleicao();
            frmExclusao.ShowDialog();
        }


        //#############################################  MANIPULAÇÃO CANDIDATOS  ######################################################

        //--- BOTÃO ADICIONAR
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmGerencial.eleicao.setIndice(-1);
            //-- ABRE O FORMULÁRIO PARA ADIÇÃO DE NOVO CANDIDATO
            frmCandidatos Candidatos = new frmCandidatos();
            Candidatos.ShowDialog();
            //-- FAZ INSERÇÃO DO NOVO CADASTRO DE CANDIDATO NO COMBOBOX DE CANDIDATOS
            preencheComboBox();
        }

        //--- BOTÃO REMOVER
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (cbCandidatos.SelectedIndex >= 0)
            {
                //-- REMOVE O ELEMENTO CORRESPONDENTE A ESCOLHA EM COMBOBOX
                frmGerencial.eleicao.removeCandidatoLista(cbCandidatos.SelectedIndex);
                MessageBox.Show("Candidato excluído com sucesso!");
                //-- ATUALIZA A COMBOBOX DE CANDIDATOS APÓS A EXCLUSÃO DO CANDIDATO
                preencheComboBox();
            }
            else
            {
                MessageBox.Show("Não existe nenhum candidato selecionado!");
            }
        }

        //--- BOTÃO EDITAR
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //-- PASSA O INDICE DO CANDIDATO A SER ALTERADO
            frmGerencial.eleicao.setIndice(cbCandidatos.SelectedIndex);
            //-- FORMULÁRIO DE CANDIDATOS É ABERTO COM INTUITO DE EDIÇÃO
            if (frmGerencial.eleicao.getIndice() >= 0)
            {
                frmCandidatos frmEdicaoCandidatos = new frmCandidatos();
                frmEdicaoCandidatos.ShowDialog();
                //-- ATUALIZAÇÃO DO COMBOBOX APÓS A EDIÇÃO DOS DADOS DO CANDIDATO
                preencheComboBox();
            }
            else
            {
                MessageBox.Show("Não existe nenhum candidato selecionado!");
            }
        }

        // ----- VERIFICA SE A TEXTBOX CÓDIGO DA ELEIÇÃO NÃO ESTÁ VAZIA
        private void txtCodigo_Validated(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "")
            {
                epCE.SetError(txtCodigo, "Insira um código válido para a eleição"); // ----- SE O CAMPO ESTIVER VAZIO, EXIBE UMA MENSAGEM DE ERRO
            }
            else
            {
                epCE.Clear(); // ----- SE O CAMPO ESTIVER PREENCHIDO A MENSAGEM DE ERRO NÃO APARECERÁ
            }
        }

        // ----- VERIFICA SE A TEXTBOX TÍTULO DA ELEIÇÃO NÃO ESTÁ VAZIA
        private void txtTituloEleicao_Validated(object sender, EventArgs e)
        {
            if (txtTituloEleicao.Text.Trim() == "")
            {
                epTE.SetError(txtTituloEleicao, "Insira um título para a eleição"); // ----- SE O CAMPO ESTIVER VAZIO, EXIBE UMA MENSAGEM DE ERRO
            }
            else
            {
                epTE.Clear(); // ----- SE O CAMPO ESTIVER PREENCHIDO A MENSAGEM DE ERRO NÃO APARECERÁ
            }
        }

        // ----- VERIFICA SE A TEXTBOX CÓD. SEGURANÇA NÃO ESTÁ VAZIA
        private void txtCodSeguranca_Validated(object sender, EventArgs e)
        {
            // ----- VERIFICA SE O QUE FOI DIGITADO PELO USUÁRIO ATENDE A TODOS OS REQUISITOS DO CÓDIGO 
            if (txtCodSeguranca.Text.Trim() == "" || NaoContemLetras(txtCodSeguranca.Text) || NaoContemNumeros(txtCodSeguranca.Text) || txtCodSeguranca.Text.Length < 8)
            {
                epCS.SetError(txtCodSeguranca, "Insira um código de segurança válido para a eleição.\nNo mínimo 8 dígitos, contendo letras e números."); // ----- SE O CAMPO ESTIVER VAZIO, EXIBE UMA MENSAGEM DE ERRO
            }
            else
            {
                epCS.Clear(); // ----- SE O CAMPO ESTIVER PREENCHIDO A MENSAGEM DE ERRO NÃO APARECERÁ
            }
        }

        // ----- VERIFICA SE FOI SELECIONADO ALGUM ELEMENTO NA COMBOBOX PAÍS
        private void cbPaises_Validated(object sender, EventArgs e)
        {
            if (cbPaises.SelectedIndex == -1)
            {
                epP.SetError(cbPaises, "Selecione um país para a eleição"); // ----- SE O CAMPO ESTIVER VAZIO, EXIBE UMA MENSAGEM DE ERRO
            }
            else
            {
                epP.Clear(); // ----- SE O CAMPO ESTIVER PREENCHIDO A MENSAGEM DE ERRO NÃO APARECERÁ
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}