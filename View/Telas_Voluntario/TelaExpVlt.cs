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
using Projeto_Voluntariado.Models.Classes_Objetos;
using Projeto_Voluntariado.Services;


namespace Projeto_Voluntariado.View.Telas_Voluntario
{
    public partial class TelaExpVlt: Form
    {
        private Voluntario _voluntario;
        private VoluntarioController voluntarioController;

        public TelaExpVlt(Voluntario voluntario)
        {
            InitializeComponent();
            _voluntario = voluntario;
            voluntarioController = new VoluntarioController(new VoluntarioRepositorio(new DatabaseService()));
        }

        private void btn_VoltVltCad2_Click(object sender, EventArgs e)
        {
            Tela_VltCriar telaVltCriar = new Tela_VltCriar();
            telaVltCriar.Show();

            this.Close(); // Fecha a tela atual
        }
        private void btn_ConcCadVlt_Click(object sender, EventArgs e)
        {

            if (txtInterVlt.Text == "" || txtDispoVlt.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            _voluntario.AreaInteresse = txtInterVlt.Text;
            _voluntario.Experiencia = txtExpVlt.Text;
            _voluntario.Disponibilidade = txtDispoVlt.Text;


            bool resultInsercao = voluntarioController.InserirVoluntario(_voluntario);

            if (resultInsercao)
            {

                // TelaConfirmaCadVlt telaConfirmaCadVlt = new TelaConfirmaCadVlt();                   
                // telaConfirmaCadVlt.Show();


                MessageBox.Show("Parabéns, você criou o cadastro com sucesso!");

                this.Close(); // Fecha a tela atual
                return;

            }
        }
            

        

        private void TelaExpVlt_Load(object sender, EventArgs e)
        {

        }
    }
}
