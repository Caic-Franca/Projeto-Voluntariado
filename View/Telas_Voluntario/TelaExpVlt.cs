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
using Projeto_Voluntariado.Models.Classes_Ong;
using Projeto_Voluntariado.View.telas_Cadastro_VLT;

namespace Projeto_Voluntariado.View.telas_VLT
{
    public partial class TelaExpVlt: Form
    {
        private Voluntario _voluntario;
        public TelaExpVlt(Voluntario voluntario)
        {
            InitializeComponent();
            _voluntario = voluntario;
        }

        private void btn_VoltVltCad2_Click(object sender, EventArgs e)
        {
            Tela_VltCriar telaVltCriar = new Tela_VltCriar();
            telaVltCriar.Show();

            this.Close(); // Fecha a tela atual
        }
        private void btn_ConcCadVlt_Click(object sender, EventArgs e)
        {
            _voluntario.AreaInteresse = txtInterVlt.Text;
            _voluntario.Experiencia = txtExpVlt.Text;
            _voluntario.Disponibilidade = txtDispoVlt.Text;

            if (txtInterVlt.Text == "" || txtDispoVlt.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            TelaConfirmaCadVlt telaConfirmaCadVlt = new TelaConfirmaCadVlt();                   
            telaConfirmaCadVlt.Show();

            this.Close(); // Fecha a tela atual         

        }
        
    }
}
