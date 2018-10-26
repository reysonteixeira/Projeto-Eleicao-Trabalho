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

    //                                                     ABRE A DOCUMENTAÇÃO

    //##################################################################################################################################

    public partial class ViwerPDF : Form
    {   
        //----- INICIALIZA FORM E CARREGA O ARQUIVO PDF
        public ViwerPDF()
        {
            InitializeComponent();
            axAcroPDF1.LoadFile("../../Docs/MANUAL DE INSTRUÇÕES URNA ELETRÔNICA MERCOSUL.pdf");//BUSCA ARQUIVO PDF NA BASE LOCAL
        }

        //----- AO FECHAR FORM ENCERRAR PROCESSO DO ADOBE
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);//FECHA CONEXÃO COM O ARQUIVO
            axAcroPDF1.Dispose();//FAZ A LIBERAÇÃO DE RECURSOS DO MÉTODO QUE ABRE O PDF
        }
    }
}
