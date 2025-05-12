using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PProjeto_Voluntariado.View.Telas_ONG;
using Projeto_Voluntariado.Models;
using Projeto_Voluntariado.Models.Classes_Objetos;
using Projeto_Voluntariado.Services;

namespace Projeto_Voluntariado.View.telas_Cadastro_ONG
{
    public partial class TelaHomeOng: Form
    {
        private OportunidadeController oportunidadeController;
        private int _ongIdLogada;

        public TelaHomeOng()
        {
            InitializeComponent();
            DatabaseService databaseService = new DatabaseService();
            OportunidadeRepositorio oportunidadeRepositorio = new OportunidadeRepositorio(databaseService);
            OportunidadeController oportunidadeController = new OportunidadeController(oportunidadeRepositorio);
        }         

        private void btn_SairVlt_Click(object sender, EventArgs e)
        {
            Home telaHome = new Home();
            telaHome.Show();
            this.Close(); // Fecha TelaHomeOng ao voltar para a Home

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaCriarOpOng telaCriarOpOng = new TelaCriarOpOng();
            telaCriarOpOng.Show();
            this.Close(); // Fecha TelaHomeOng ao abrir TelaCriarOpOng
        }

        private void TelaHomeOng_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            VisualizarOportunidades visualizarOportunidades = new VisualizarOportunidades(oportunidadeController, _ongIdLogada);
            visualizarOportunidades.ShowDialog();
        }
    }
}
