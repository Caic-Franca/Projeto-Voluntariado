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
        private Tela_VltCriar telaAnterior;
        

        public TelaExpVlt(Tela_VltCriar tela)
        {
            InitializeComponent();
            this.telaAnterior = tela;
        }

        private void Btn_VoltVltCad2_Click(object sender, EventArgs e)
        {
            Tela_VltCriar telaVltCriar = new Tela_VltCriar();
            telaVltCriar.Show();
        }

        private void Btn_ConcCadVlt_Click(object sender, EventArgs e)
        {
            TelaConfirmaCadVlt telaConfirmaCadVlt = new TelaConfirmaCadVlt();
            telaConfirmaCadVlt.Show();
            this.Close(); // Fecha TelaExpVlt ao abrir TelaConfirmaCadVlt
        } 

        private void TelaExpVlt_Load(object sender, EventArgs e)
        {
             
        }
    }
}
