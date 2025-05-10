using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Voluntariado.Models;
//using Projeto_Voluntariado.Services;
using Projeto_Voluntariado.Models.Classes_Objetos;

namespace Projeto_Voluntariado.View.Telas_Voluntario
{
    public partial class TelaLogSenhaVlt: Form
    {
        //private VoluntarioRepositorio voluntarioRepositorio;
        public TelaLogSenhaVlt()
        {
            InitializeComponent();
            //voluntarioRepositorio = new VoluntarioRepositorio(new DatabaseService());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaSelectVLT telaSelectVLT = new TelaSelectVLT();
            telaSelectVLT.Show();

            this.Close(); // Fecha TelaLogSenhaVlt ao abrir TelaSelectVLT

        }

        private void button1_Click(object sender, EventArgs e)
        {

           //Voluntario voluntario = voluntarioRepositorio.RealizarLogin(txtEmail.Text, txtSenha.Text);

            //if (voluntario.Nome != null)
            //{
            //    MessageBox.Show("Você está logado");
            //    Tela_VltHomepage telaVltHomepage = new Tela_VltHomepage();
            //    telaVltHomepage.Show();
            //    this.Close(); // Fecha TelaLogSenhaVlt ao abrir Tela_VltHomepage  
            //}
            //else {

            //    MessageBox.Show("Erro na autenticação");
            //    return;

            //}




           
        } 

        private void TelaLogSenhaVlt_Load(object sender, EventArgs e)
        {
             

        }
    }
}
