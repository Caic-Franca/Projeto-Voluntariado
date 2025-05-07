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
            this.Close();
        }
        private void btn_confVltCad_Click(object sender, EventArgs e)
        {
            // Verifica se os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(txtNomeVlt.Text) ||
                string.IsNullOrWhiteSpace(txtEmailVlt.Text) ||
                string.IsNullOrWhiteSpace(txtSenhaVlt.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmSenhaVlt.Text) ||
                string.IsNullOrWhiteSpace(txtNascVlt.Text) ||
                string.IsNullOrWhiteSpace(txtTelVlt.Text) ||
                string.IsNullOrWhiteSpace(txtEndVlt.Text))          
             {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            // Criação um novo objeto Voluntario com os dados preenchidos
            Voluntario voluntario = new Voluntario(
         0,
             txtNomeVlt.Text,
             txtEmailVlt.Text,
             txtSenhaVlt.Text,
             txtConfirmSenhaVlt.Text,
             Convert.ToDateTime(txtNascVlt.Text),
             txtTelVlt.Text,
             txtEndVlt.Text );

            //validaçao de email
            if (!txtEmailVlt.Text.Contains("@") || !txtEmailVlt.Text.Contains(".com"))
            {
                MessageBox.Show("Email inválido!");
                return;
            }

            //validação de senha
            if (txtSenhaVlt.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres!");
                return;
            }
            if (txtSenhaVlt.Text != txtConfirmSenhaVlt.Text)
            {
                MessageBox.Show("As senhas não coincidem!");
                return;
            }
            //validação de telefone
            if (txtTelVlt.Text.Length < 11)
            {
                MessageBox.Show("O telefone deve ter pelo menos 11 dígitos!");
                return;
            }
            //validação de data de nascimento
            DateTime dataNascimento;
            if (!DateTime.TryParse(txtNascVlt.Text, out dataNascimento))
            {
                MessageBox.Show("Data de nascimento inválida! \nInsira a data no formato DD/MM/AAA");
                return;
            }
            TelaExpVlt telaExpVlt = new TelaExpVlt(voluntario);
            telaExpVlt.Show();

            this.Close();

        }
                  }
}
