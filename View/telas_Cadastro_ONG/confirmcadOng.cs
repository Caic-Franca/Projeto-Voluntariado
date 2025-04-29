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
    public partial class confirmcadOng: Form
    {
        public confirmcadOng()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            telaOng_criar telaOng_Criar = new telaOng_criar();
            telaOng_Criar.Show();
            this.Close(); // Fecha a confirmcadOng ao abrir telaOng_criar
        }

        private void confirmcadOng_Load(object sender, EventArgs e)
        {

        }
    }
}
