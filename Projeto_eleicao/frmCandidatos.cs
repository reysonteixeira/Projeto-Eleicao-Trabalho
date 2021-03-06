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
    //##################################################################################################################################

    //                                           FORMULÁRIO DE CADASTRO DE CANDIDATOS

    //##################################################################################################################################

    public partial class frmCandidatos : Form
    {
        //##########################################  MÉTODOS AO CARREGAMENTO DE FORMULÁRIO  ###########################################

        //----- MÉTODO CONSTRUTOR
        public frmCandidatos()
        {
            InitializeComponent();
        }

        
        //----- MÉTODO AO MOSTRAR O FORMULÁRIO
        private void frmCandidatos_Shown(object sender, EventArgs e)
        {
           if (frmGerencial.eleicao.getIndice() != -1) //FAZ A CHECAGEM SE O CADASTRO É DE NOVO CANDIDATO OU SE TRATA DE EDIÇÃO
            {
                //FAZ O RETORNO DE DADOS CADASTRADOS DO CANDIDATO SELECIONADO PARA EDIÇÃO
                LiberaCampos(true);
                DesabilitaBotoes();
                restauraDados();
            }
        }

        //----- VARIÁVEIS
        string foto = ""; //UTILIZADA EM VALIDAÇÃO DE FOTO


        //###########################################  MANIPULAÇÃO COM DADOS DO FORMULÁRIO  #############################################

        //----- HABILITA OU DESABITA OS BOTÕES E CAMPOS DO FORMULÁRIO
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

        //----- LIMPA DADOS PREENCHIDOS NO FORMULÁRIO
        public void LimpaCampos()
        {
            txtNascimento.Text = txtNomeAbreviado.Text = txtNomeCompleto.Text =
            txtPartidoNome.Text = txtPartidoNum.Text = string.Empty; //TODOS TEXT BOX RECEBEM "STRING VAZIA"
        }
        
        //----- RESTAURA OS DADOS DE ACORDO COM INDICE DE CANDIDATOS CADASTRADOS NA LISTA PARA EDIÇÃO
        public void restauraDados()
        {
            txtNascimento.Text = frmGerencial.eleicao.getNascimento(frmGerencial.eleicao.getIndice());
            txtNomeAbreviado.Text = frmGerencial.eleicao.getNomeAbreviado(frmGerencial.eleicao.getIndice());
            txtNomeCompleto.Text = frmGerencial.eleicao.getNomeCompleto(frmGerencial.eleicao.getIndice());
            txtPartidoNome.Text = frmGerencial.eleicao.getNomePartido(frmGerencial.eleicao.getIndice());
            txtPartidoNum.Text = frmGerencial.eleicao.getNumPartido(frmGerencial.eleicao.getIndice()).ToString();
            pbFoto.Load(frmGerencial.eleicao.getFoto(frmGerencial.eleicao.getIndice()));
            foto = frmGerencial.eleicao.getFoto(frmGerencial.eleicao.getIndice());
        }
       
        //----- DESABILITA O BOTÃO NOVO, QUANDO JÁ TIVER SENDO FEITO UM CADASTRO
        public void DesabilitaBotoes()
        {
            btnNovo.Enabled = false;
        }


        //############################################  ENVIO DE DADOS PARA LISTA  #####################################################

        //----- TRANSFERE DADOS PRESENTES NO FORMULÁRIO PARA A STRUCT
        public void EnviaDados()
        {
            frmGerencial.eleicao.setNascimento(txtNascimento.Text);
            frmGerencial.eleicao.setNomeAbreviado(txtNomeAbreviado.Text);
            frmGerencial.eleicao.setNomeCompleto(txtNomeCompleto.Text);
            frmGerencial.eleicao.setNomePartido(txtPartidoNome.Text);
            frmGerencial.eleicao.setNumPartido(int.Parse(txtPartidoNum.Text));
        }

        //----- MÉTODO QUE SALVA OS ATRIBUTOS EM LISTA
        public void salvarCadastro()
        {
           //--- SE O CÓDIGO FOR "-1" UM NOVO CADASTRO SERÁ INCLUÍDO
           if (frmGerencial.eleicao.getIndice() == -1)
            {
                EnviaDados();//TRANSFERE OS DADOS DO FORMULÁRIO PARA A STRUCT
                foto = string.Empty;
                //ATRIBUI OS VALORES QUE ESTÃO NA STRUCT CANDIDATOS PARA A LISTA
                frmGerencial.eleicao.insereCandidato();
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            else
            {
                frmGerencial.eleicao.setFoto(foto);
                EnviaDados();//TRANSFERE OS DADOS DO FORMULÁRIO PARA A STRUCT
                foto = string.Empty;
                frmGerencial.eleicao.insereCandidato(frmGerencial.eleicao.getIndice());//SALVA OS DADOS EM POSIÇÃO SELECIONADA PELO USUÁRIO
                MessageBox.Show("Cadastro alterado com sucesso!");
            }
        }


        //############################################  MANIPULAÇÃO DE CANDIDATOS  #####################################################

        //--- BOTÃO NOVO
        private void btnNovo_Click(object sender, EventArgs e)
        {
            LiberaCampos(true);
            frmGerencial.eleicao.setIndice(-1);//ENVIA O INDICE QUE CORRESPONDE A NOVO CADASTRO
            DesabilitaBotoes();
        }

        //--- BOTÃO SALVAR
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // ----- VERIFICA SE O QUE FOI DIGITADO PELO USUÁRIO EM TODOS OS CAMPOS ATENDE A TODOS OS REQUISITOS ANTES DE SALVAR OS DADOS
            if (string.IsNullOrEmpty(txtNomeCompleto.Text) || string.IsNullOrEmpty(txtNomeAbreviado.Text) || string.IsNullOrEmpty(txtNascimento.Text) || txtNascimento.Text.Length < 8 || string.IsNullOrEmpty(txtPartidoNum.Text) || string.IsNullOrEmpty(txtPartidoNome.Text) || string.IsNullOrWhiteSpace(foto))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos corretamente");
            }
            else
            {
                salvarCadastro();//MÉTODO QUE ENVIA OS DADOS E OS SALVA EM LISTA
                btnNovo.Enabled = true;
                btnSalvar.Enabled = false;
                btnSelecionar.Enabled = false;
                LiberaCampos(false);
                pbFoto.Image = pbFoto.InitialImage;//O CAMPO DO FORMULÁRIO RECEBE A IMAGEM INICIAL
                foto = "";
                LimpaCampos();
                if (frmGerencial.eleicao.getIndice() >= 0)//SE O CADASTRO FOR UMA ALTERAÇÃO
                {
                    frmGerencial.eleicao.setIndice(-1);
                    this.Close();//FECHA A JANELA
                }
            }
        }

        //--- BOTÃO SELECIONAR (IMAGEM)
        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            //--- ABRE A CAIXA DE DIALOGO EM BUSCA DO DIRETORIO CONTENDO IMAGEM
            openFileDialog1.ShowDialog();
            if(!string.IsNullOrEmpty(openFileDialog1.FileName.ToString()))//--- VALIDA SE O USUÁRIO SELECIONOU ALGUMA IMAGEM
            {
                //--- ATRIBUI A IMAGEM SELECIONADA AO CAMPO PICBOX
                pbFoto.Load(openFileDialog1.FileName);
                foto = openFileDialog1.FileName.ToString();
                frmGerencial.eleicao.setFoto(openFileDialog1.FileName);//ENVIA O DIRETORIO DA IMAGEM PARA SER SALVO
            }
        }

        //--- BOTÃO SAIR
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();//FECHA A JANELA
        }


        //######################################################   VALIDAÇÕES    ########################################################
        
        //----- VERIFICA SE A TEXTBOX NOME COMPLETO NÃO ESTÁ VAZIA
        private void txtNomeCompleto_Validated(object sender, EventArgs e)
        {
            if (txtNomeCompleto.Text.Trim() == "")
            {
                epNC.SetError(txtNomeCompleto, "Insira o nome completo do candidato"); // ----- SE O CAMPO ESTIVER VAZIO, EXIBE UMA MENSAGEM DE ERRO
            }
            else
            {
                epNC.Clear(); // ----- SE O CAMPO ESTIVER PREENCHIDO A MENSAGEM DE ERRO NÃO APARECERÁ
            }
        }

        //----- VERIFICA SE A TEXTBOX NOME ABREVIADO NÃO ESTÁ VAZIA
        private void txtNomeAbreviado_Validated(object sender, EventArgs e)
        {
            if (txtNomeAbreviado.Text.Trim() == "")
            {
                epNA.SetError(txtNomeAbreviado, "Insira o nome abreviado do candidato"); // ----- SE O CAMPO ESTIVER VAZIO, EXIBE UMA MENSAGEM DE ERRO
            }
            else
            {
                epNA.Clear(); // ----- SE O CAMPO ESTIVER PREENCHIDO A MENSAGEM DE ERRO NÃO APARECERÁ
            }
        }

        // ----- VERIFICA SE A MASKEDTEXTBOX DATA DE NASCIMENTO NÃO ESTÁ VAZIA
        private void txtNascimento_Validated(object sender, EventArgs e)
        {
            if (txtNascimento.Text.Trim() == "" || txtNascimento.Text.Length < 8)
            {
                epN.SetError(txtNascimento, "Insira a data de nascimento do candidato"); // ----- SE O CAMPO ESTIVER VAZIO, EXIBE UMA MENSAGEM DE ERRO
            }
            else
            {
                epN.Clear(); // ----- SE O CAMPO ESTIVER PREENCHIDO A MENSAGEM DE ERRO NÃO APARECERÁ
            }
        }

        //----- VERIFICA SE A TEXTBOX NÚMERO DO PARTIDO NÃO ESTÁ VAZIA
        private void txtPartidoNum_Validated(object sender, EventArgs e)
        {
            if (txtPartidoNum.Text.Trim() == "")
            {
                epPNum.SetError(txtPartidoNum, "Insira o número do partido do candidato"); // ----- SE O CAMPO ESTIVER VAZIO, EXIBE UMA MENSAGEM DE ERRO
            }
            else
            {
                epPNum.Clear(); // ----- SE O CAMPO ESTIVER PREENCHIDO A MENSAGEM DE ERRO NÃO APARECERÁ
            }
        }

        //----- VERIFICA SE A TEXTBOX NOME DO PARTIDO NÃO ESTÁ VAZIA
        private void txtPartidoNome_Validated(object sender, EventArgs e)
        {
            if (txtPartidoNome.Text.Trim() == "")
            {
                epPNome.SetError(txtPartidoNome, "Insira o nome do partido do candidato"); // ----- SE O CAMPO ESTIVER VAZIO, EXIBE UMA MENSAGEM DE ERRO
            }
            else
            {
                epPNome.Clear(); // ----- SE O CAMPO ESTIVER PREENCHIDO A MENSAGEM DE ERRO NÃO APARECERÁ
            }
        }

        //----- NÃO DEIXA USUÁRIO DIGITAR TEXTO EM CAMPO DE NUMERICO - NÚMERO DO PARTIDO
        private void txtPartidoNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))//VERIFICA SE O CARACTER DIGITADO ESTÁ DENTRO DOS PERMITIDOS
            {
                e.Handled = true;

            }
        }

        //----- NÃO DEIXA USUÁRIO DIGITAR NÚMERO EM CAMPO DE TEXTO - NOME COMPLETO
        private void txtNomeCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == 32))//VERIFICA SE O CARACTER DIGITADO ESTÁ DENTRO DOS PERMITIDOS
            {
                e.Handled = true;
            }
        }

        //----- NÃO DEIXA USUÁRIO DIGITAR NÚMERO EM CAMPO DE TEXTO - NOME ABREVIADO
        private void txtNomeAbreviado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == 32))//VERIFICA SE O CARACTER DIGITADO ESTÁ DENTRO DOS PERMITIDOS
            {
                e.Handled = true;
            }
        }

        //----- NÃO DEIXA USUÁRIO DIGITAR NÚMERO EM CAMPO DE TEXTO - NOME DO PARTIDO
        private void txtPartidoNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
