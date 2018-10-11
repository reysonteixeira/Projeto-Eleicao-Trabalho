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
    public partial class frmGerencial : Form
    {
        
        public frmGerencial()
        {
            InitializeComponent();
        }

  
        public static Eleicao eleicao = new Eleicao();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmEleicoes frmEleicoes = new frmEleicoes();
            frmEleicoes.ShowDialog();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(frmGerencial.cand.getFoto(0));
        }

      

        private void btnDocumentação_Click(object sender, EventArgs e)
        {
            MessageBox.Show(frmGerencial.eleicao.getNomeCompleto());
            //MessageBox.Show(frmGerencial.candidato.getEleicao(0) + " - " + frmGerencial.candidato.getNomeCompleto(0).ToString()); 
            //MessageBox.Show(frmGerencial.cand.getNomeCompleto(0) + " - " + frmGerencial.cand.getEleicao(0).ToString());
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            frmInicioEleicao frmIniciaEleicao = new frmInicioEleicao();
            frmIniciaEleicao.ShowDialog();
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
           MessageBox.Show(frmGerencial.eleicao.Tamanhoeleicao().ToString());
        }

        private void tsmCadastroCandidatos_Click(object sender, EventArgs e)
        {
            
      
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            frmEncerrar frmEncerra = new frmEncerrar();
            frmEncerra.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmEncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmGerencial_Load(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
    }
}