using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Voluntariado.Models.Classes_Objetos;
using Projeto_Voluntariado.View.telas_Cadastro_ONG;



namespace Projeto_Voluntariado.View.Telas_ONG
{
    public partial class telaOng_criar : Form
    {
        public telaOng_criar()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Home telaHome = new Home();
            telaHome.Show();
            this.Close(); // Fecha telaOng_criar ao voltar para a Home
        }      

        private void button2_Click(object sender, EventArgs e)
        {
            OngTelaDeCacadastro ongTelaDeCacadastro = new OngTelaDeCacadastro();
            ongTelaDeCacadastro.Show();
            this.Close(); // Fecha telaOng_criar ao abrir TelaCadOng

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaLogOng telaLogOng = new TelaLogOng();
            telaLogOng.Show();
            this.Close(); // Fecha telaOng_criar ao abrir TelaHomeOng
        }

        private void telaOng_criar_Load(object sender, EventArgs e)
        {

        }
    }
}
