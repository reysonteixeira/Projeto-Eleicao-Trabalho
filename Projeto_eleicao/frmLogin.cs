using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Projeto_eleicao
{
    //##################################################################################################################################

    //                                           FORMULÁRIO QUE FAZ O LOGIN PARA ACESSO

    //##################################################################################################################################

    public partial class frmLogin : Form
    {
        //################################################ MÉTODOS AO CARREGAR FORMULÁRIO #################################################

        //----- MÉTODO CONSTRUTOR
        public frmLogin()
        {
            InitializeComponent();
        }

        //----- MÉTODO RESPONSÁVEL POR LOGIN
        public void Login()
        {
            if (txtUsuario.Text == "admin" && txtSenha.Text == "admin")//SE O LOGIN E SENHA CORRESPONDEREM
            {

                frmGerencial frmGerencial = new frmGerencial();//ABRE A ELEIÇÃO
                frmGerencial.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido");
            }
        }

        private void txtUsuario_Validated(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "")
            {
                epUsuario.SetError(txtUsuario, "Insira um nome de usuário");
            }
            else
            {
                epUsuario.Clear();
            }
        }

        private void txtSenha_Validated(object sender, EventArgs e)
        {
            if (txtSenha.Text.Trim() == "")
            {
                epSenha.SetError(txtSenha, "Insira uma senha");
            }
            else
            {
                epSenha.Clear();
            }
        }

        //----- FAZ A VERIFICAÇÃO SE FOI CLICADO ENTER
        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//CASO TECLE ENTER
            {
                if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtSenha.Text))
                {
                    MessageBox.Show("Os campos Usuário e Senha devem ser preenchidos");
                }
                else
                {
                    Login(); //CHAMA FUNÇÃO QUE FAZ LOGIN
                }
            }
        }

        //----- BOTÃO LOGIN
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Os campos Usuário e Senha devem ser preenchidos");
            }
            else
            {
                Login(); //CHAMA FUNÇÃO QUE FAZ LOGIN
            }
        }
    }
}
