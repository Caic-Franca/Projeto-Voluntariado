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
using Projeto_Voluntariado.View.telas_Cadastro_VLT;

namespace Projeto_Voluntariado.View.telas_VLT
{
    public partial class TelaExpVlt : Form
    {
        private Voluntario _voluntario;
        
        public TelaExpVlt(Voluntario voluntario)
        {
            InitializeComponent();
            _voluntario = voluntario;
        }

        private void Btn_VoltVltCad2_Click(object sender, EventArgs e)
        {
            Tela_VltCriar telaVltCriar = new Tela_VltCriar();
            telaVltCriar.Show();
            this.Close();
        }

        private void Btn_ConcCadVlt_Click(object sender, EventArgs e)
        {
            _voluntario.AreaInteresse = txtInterVlt.Text;
            _voluntario.Experiencia = txtExpVlt.Text;
            _voluntario.Disponibilidade = txtDispoVlt.Text;

            if (string.IsNullOrEmpty(txtInterVlt.Text) || string.IsNullOrEmpty(txtDispoVlt.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            TelaConfirmaCadVlt telaConfirmaCadVlt = new TelaConfirmaCadVlt();                   
            telaConfirmaCadVlt.Show();
            this.Close();
        }

        private void txtInterVlt_TextChanged(object sender, EventArgs e)
        {
            // Evento de mudança de texto (manter se necessário)
        }

        private void TelaExpVlt_Load(object sender, EventArgs e)
        {
            // Código de inicialização da tela
        }
    }
}
