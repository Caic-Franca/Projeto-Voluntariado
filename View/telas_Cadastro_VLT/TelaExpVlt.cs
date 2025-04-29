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
    public partial class TelaExpVlt: Form
    {
        public TelaExpVlt()
        {
            InitializeComponent();
        }

        private void btn_VoltVltCad2_Click(object sender, EventArgs e)
        {
            Tela_VltCriar telaVltCriar = new Tela_VltCriar();
            telaVltCriar.Show();
            this.Close(); // Fecha a tela atual
        }

        private void btn_ConcCadVlt_Click(object sender, EventArgs e)
        {
            TelaConfirmaCadVlt telaConfirmaCadVlt = new TelaConfirmaCadVlt();
            telaConfirmaCadVlt.Show();
            this.Close(); // Fecha a tela atual
        }

        private void TelaExpVlt_Load(object sender, EventArgs e)
        {

        }
    }
}
