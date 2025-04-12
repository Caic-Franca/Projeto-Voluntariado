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
    public partial class TelaCriarOpOng: Form
    {
        public TelaCriarOpOng()
        {
            InitializeComponent();
        }

        private void btn_voltar_cadVlt_Click(object sender, EventArgs e)
        {
            TelaHomeOng telaHomeOng = new TelaHomeOng();
            telaHomeOng.Show();
        }

        private void btn_confVltCad_Click(object sender, EventArgs e)
        {
            confirmcadOng telaConfirmCadOng = new confirmcadOng();
            telaConfirmCadOng.Show();

        }
    }
}
