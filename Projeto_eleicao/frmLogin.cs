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
    public partial class frmLogin : Form
    { 

        public frmLogin()
        {
            InitializeComponent();
        }

        public void Login()
        {
            if (txtUsuario.Text == "admin" && txtSenha.Text == "admin")
            {
               
                frmGerencial frmGerencial = new frmGerencial();
                frmGerencial.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Login();
            }
        }

        private void txtUsuario_Validated(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "")
            {
                epError.SetError(txtUsuario, "Insira um nome de usuário");
                txtUsuario.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtSenha_Validated(object sender, EventArgs e)
        {
            if (txtSenha.Text.Trim() == "")
            {
                epError.SetError(txtSenha, "Insira uma senha");
                txtSenha.Focus();
            }
            else
            {
                epError.Clear();
            }
        }
    }
}
