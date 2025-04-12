using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Voluntariado.View.telas_Cadastro_ONG
{
    public partial class telaOng_criar: Form
    {
        public telaOng_criar()
        {
            InitializeComponent();
        }

        private void bnf_VLT_Click(object sender, EventArgs e)
        {

        }

        private void btn_VltCriar_Click(object sender, EventArgs e)
        {

        }

        private void btn_VltLog_Click(object sender, EventArgs e)
        {

        }

        private void qst_VLT_Click(object sender, EventArgs e)
        {

        }

        private void btn_VltMenuVolta_Click(object sender, EventArgs e)
        {

        }

        private void abrt_Vlt_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home telaHome = new Home();
            telaHome.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaCadOng telaCadOng = new TelaCadOng();
            telaCadOng.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaHomeOng telaHomeOng = new TelaHomeOng();
            telaHomeOng.Show();
        }
    }
}
