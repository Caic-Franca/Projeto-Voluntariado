using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Voluntariado.View.telas_VLT
{
    public partial class Tela_VltCriar: Form
    {
        public Tela_VltCriar()
        {
            InitializeComponent();
        }
         
        private void btn_voltar_cadVlt_Click(object sender, EventArgs e)
        {
            TelaSelectVLT telaSelectVLT = new TelaSelectVLT();
            telaSelectVLT.Show();
        }

        private void btn_confVltCad_Click(object sender, EventArgs e)
        {
            TelaExpVlt telaExpVlt = new TelaExpVlt(this); // Passa a referência desta tela
            telaExpVlt.Show();
            this.Close(); // Fecha a tela atual
        }

        private void Tela_VltCriar_Load(object sender, EventArgs e)
        {
              
        }
    }
}
