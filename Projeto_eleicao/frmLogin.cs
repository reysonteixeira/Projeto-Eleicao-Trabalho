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
                MessageBox.Show("Usuário ou senha inválidos");
            }
        }

        //----- FAZ A VERIFICAÇÃO SE FOI CLICADO ENTER
        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//CASO TECLE ENTER
            {
                Login();//CHAMA FUNÇÃO QUE FAZ LOGIN
            }
        }

        //----- BOTÃO LOGIN
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();//CHAMA FUNÇÃO QUE FAZ LOGIN
        }
    }
}
