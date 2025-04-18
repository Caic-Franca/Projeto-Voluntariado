using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Voluntariado.Models.Classes_Ong;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            Voluntario voluntario = new Voluntario(
            0,
                txtNomeVlt.Text,
                txtEmailVlt.Text, 
                txtSenhaVlt.Text,
                txtConfirmSenhaVlt.Text,
                Convert.ToDateTime(txtNascVlt.Text),
                txtTelVlt.Text,
                txtEndVlt.Text

            );
            TelaExpVlt telaExpVlt = new TelaExpVlt(voluntario);
            telaExpVlt.Show();
        }

      
    }
}
