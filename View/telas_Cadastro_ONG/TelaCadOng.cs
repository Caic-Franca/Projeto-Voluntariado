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
    public partial class TelaCadOng: Form
    {
        public TelaCadOng()
        {
            InitializeComponent();
        }

        private void enun_Nasc_Click(object sender, EventArgs e)
        {

        }

        private void txt_NascVlt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_voltar_cadOng_Click(object sender, EventArgs e)
        {
            Home telaHome = new Home();
            telaHome.Show();
            this.Close(); // Fecha a TelaCadOng ao voltar para Home

        }

        private void btn_ConfOngCad_Click(object sender, EventArgs e)
        {
            confirmcadOng telaConfirmCadOng = new confirmcadOng();
            telaConfirmCadOng.Show();
            this.Close(); // Fecha a TelaCadOng ao abrir confirmcadOng
        }

        private void TelaCadOng_Load(object sender, EventArgs e)
        {

        }
    }
}
