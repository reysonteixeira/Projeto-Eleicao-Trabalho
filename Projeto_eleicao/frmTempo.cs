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
    public partial class frmTempo : Form
    {
        int segundos = 20;
        public frmTempo()
        {
            InitializeComponent();
            label1.Visible = false;
        }

        private void frmTempo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                e.Handled = true;
            }
        }

        private void frmTempo_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Visible = true;
            //label1.Text = DateTime.Now.ToLongTimeString();
            label1.Text = segundos.ToString();
            segundos = segundos - 1;
            if (progressBar2.Value < 2000)
            {
                progressBar2.Increment(10);                
            }
            if (segundos <= -1)
            {
                this.Close();
            }
        }
    }
}
