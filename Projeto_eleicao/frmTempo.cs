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
    //#################################################################################################################################

    //                                          FORMULÁRIO QUE TRAVA O FORMULÁRIO ANTERIOR

    //#################################################################################################################################

    public partial class frmTempo : Form
    {
        //########################################## MÉTODOS AO INICIAR O FORMULÁRIO ##################################################
        
        //----- VARIÁVEIS
        int segundos = 20;

        //----- CONTRUTOR
        public frmTempo()
        {
            InitializeComponent();
            label1.Visible = false;
        }

        //----- AO CARREGAR O FORMULÁRIO
        private void frmTempo_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;//DEFINE O INTERVALO DO TIMER
            timer1.Start();//INICIA O TIMER
        }


        //######################################### MÉTODO DE MANIPULAÇÃO COM FORMULÁRIO ############################################### 

        //----- DESBILITA O FECHAMENTO DO FORMULÁRIO
        private void frmTempo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)//CASO TECLE ALT+F4
            {
                e.Handled = true;
            }
        }

        //----- DISPARO DE TEMPO
        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Visible = true;
            label1.Text = segundos.ToString();//FAZ A CONTAGEM REGRESSIVA
            segundos = segundos - 1;//DECREMENTA O TEMPORIZADOR
            if (progressBar2.Value <= 2000)//VERIFICA A BARRA DE PROGRESSÃO
            {
                progressBar2.Increment(10);//INCREMENTA 1 SEGUNDO A PROGRESS BAR
            }
            if (segundos <= -1)//VERIFICA O TEMPO PARA DESBLOQUEAR A JANELA
            {
                this.Close();
            }
        }
    }
}
