using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Voluntariado.Service;
using Projeto_Voluntariado.Models.Classes_Objetos;
using Projeto_Voluntariado.View.Telas_Voluntario;
using Projeto_Voluntariado.View.Telas_ONG;

namespace Projeto_Voluntariado
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.FormClosing += CloseAppService.CloseApp;
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
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            TelaSelectVLT telaSelectvlt = new TelaSelectVLT();
            telaSelectvlt.Show();
            
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }

       
    }


