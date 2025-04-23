using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Voluntariado.View.telas_Cadastro_VLT;

namespace Projeto_Voluntariado.View.telas_VLT
{
    public partial class TelaSelectVLT: Form
    {
        public TelaSelectVLT()
        {
            InitializeComponent();
        }

        private void TelaSelectVLT_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            TelaLogSenhaVlt telaLogSenhaVlt = new TelaLogSenhaVlt();
            telaLogSenhaVlt.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tela_VltCriar tela_vltCriar = new Tela_VltCriar();
            tela_vltCriar.Show();
        }

        private void btn_VltMenuVolta_Click(object sender, EventArgs e)
        {
            Home telaHome = new Home();
            telaHome.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
