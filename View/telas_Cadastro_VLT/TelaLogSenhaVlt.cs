using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Voluntariado.View.telas_VLT;

namespace Projeto_Voluntariado.View.telas_Cadastro_VLT
{
    public partial class TelaLogSenhaVlt: Form
    {
        public TelaLogSenhaVlt()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaSelectVLT telaSelectVLT = new TelaSelectVLT();
            telaSelectVLT.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tela_VltHomepage telaVltHomepage = new Tela_VltHomepage();
            telaVltHomepage.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
