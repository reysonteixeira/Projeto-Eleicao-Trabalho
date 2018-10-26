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
    public partial class ViwerPDF : Form
    {   
        //INICIALIZA FORM E CARREGA O ARQUIVO PDF
        public ViwerPDF()
        {
            InitializeComponent();
            axAcroPDF1.LoadFile("../../Docs/MANUAL DE INSTRUÇÕES URNA ELETRÔNICA MERCOSUL.pdf");
        }

        //AO FECHAR FORM ENCERRAR PROCESSO DO ADOBE
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            axAcroPDF1.Dispose();
        }
    }
}
