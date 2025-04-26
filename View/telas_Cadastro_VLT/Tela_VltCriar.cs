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
    public partial class Tela_VltCriar : Form
    {
        public Tela_VltCriar()
        {
            InitializeComponent();
        }

        private void btn_voltar_cadVlt_Click(object sender, EventArgs e)
        {
            TelaSelectVLT telaSelectVLT = new TelaSelectVLT();
            telaSelectVLT.Show();
            this.Close();
        }

        private void btn_confVltCad_Click(object sender, EventArgs e)
        {
            // Validação de campos obrigatórios
            if (string.IsNullOrEmpty(txtNomeVlt.Text) || 
                string.IsNullOrEmpty(txtEmailVlt.Text) || 
                string.IsNullOrEmpty(txtSenhaVlt.Text) || 
                string.IsNullOrEmpty(txtConfirmSenhaVlt.Text) || 
                string.IsNullOrEmpty(txtNascVlt.Text) || 
                string.IsNullOrEmpty(txtTelVlt.Text) || 
                string.IsNullOrEmpty(txtEndVlt.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validação de email
            if (!txtEmailVlt.Text.Contains("@") || !txtEmailVlt.Text.Contains("."))
            {
                MessageBox.Show("Email inválido! Deve conter '@' e '.'", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validação de senha
            if (txtSenhaVlt.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtSenhaVlt.Text != txtConfirmSenhaVlt.Text)
            {
                MessageBox.Show("As senhas não coincidem!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Criação do objeto Voluntario
            Voluntario voluntario = new Voluntario(
                0, // ID provisório
                txtNomeVlt.Text,
                txtEmailVlt.Text,
                txtSenhaVlt.Text,
                txtConfirmSenhaVlt.Text,
                Convert.ToDateTime(txtNascVlt.Text),
                txtTelVlt.Text,
                txtEndVlt.Text
            );

            // Navegação para próxima tela
            TelaExpVlt telaExpVlt = new TelaExpVlt(voluntario);
            telaExpVlt.Show();
            this.Close();
        }

        private void Tela_VltCriar_Load(object sender, EventArgs e)
        {
            // Inicialização da tela (se necessário)
        }
    }
}