using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Voluntariado.View.telas_Cadastro_ONG;
using Projeto_Voluntariado.View.telas_VLT;


namespace Projeto_Voluntariado
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void abertura_Slogan_Click(object sender, EventArgs e)
        {

        }

        private void abertura_Enun_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            telaOng_criar telaselectOng = new telaOng_criar();
            telaselectOng.Show();
            this.Close(); // Fecha a Home ao abrir a telaOng_criar
        }

        private void button1_Click(object sender, EventArgs e)
        {

            TelaSelectVLT telaSelectvlt = new TelaSelectVLT();
            telaSelectvlt.Show();
            this.Close(); // Fecha a Home ao abrir a TelaSelectVLT
        }
        

        private void Home_Load(object sender, EventArgs e)
        {
             
        }

       
    }
}
