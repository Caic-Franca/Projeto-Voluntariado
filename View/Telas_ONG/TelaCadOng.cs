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


namespace Projeto_Voluntariado.View.telas_Cadastro_ONG
{
    public partial class TelaCadOng : Form
    {
        public TelaCadOng()
        {
            InitializeComponent();
        }

        private void btn_voltar_cadOng_Click(object sender, EventArgs e)
        {
            Home telaHome = new Home();
            telaHome.Show();
            this.Close(); // Fecha a TelaCadOng ao voltar para Home

        }

        private void btn_ConfOngCad_Click(object sender, EventArgs e)
        {
            // Verifica se os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(txtNomeOng.Text) ||
                string.IsNullOrWhiteSpace(txtEmailOng.Text) ||
                string.IsNullOrWhiteSpace(txtSenhaOng.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmSenhaOng.Text) ||
                string.IsNullOrWhiteSpace(txtNomeRespOng.Text) ||
                string.IsNullOrWhiteSpace(txtCnpjOng.Text) ||
                string.IsNullOrWhiteSpace(txtEndOng.Text) ||
                string.IsNullOrWhiteSpace(txtAreaOng.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            // Criação um novo objeto Ong com os dados preenchidos

            try
            {
                Ong ong = new Ong(
                0,
                txtNomeOng.Text,
                txtCnpjOng.Text,
                txtDescOng.Text,
                txtAreaOng.Text,
                txtEndOng.Text,
                txtNomeRespOng.Text,
                txtEmailOng.Text,
                txtSenhaOng.Text,
                txtConfirmSenhaOng.Text,
                txtLinkOng.Text
                );

                //validaçao de email
                if (!txtEmailOng.Text.Contains("@") || !txtEmailOng.Text.Contains(".com"))
                {
                    MessageBox.Show("Email inválido!");
                    return;
                }
                //validação de senha
                if (txtSenhaOng.Text != txtConfirmSenhaOng.Text)
                {
                    MessageBox.Show("As senhas não coincidem!");
                    return;
                }
                if (txtSenhaOng.Text.Length < 6)
                {
                    MessageBox.Show("A senha deve ter pelo menos 6 caracteres!");
                    return;
                }

                //validação de CNPJ
                if (txtCnpjOng.Text.Length != 14)
                {
                    MessageBox.Show("CNPJ inválido! O CNPJ deve ter 14 dígitos.");
                    return;
                }
                ConfirmcadOng telaConfirmCadOng = new ConfirmcadOng();
                telaConfirmCadOng.Show();
                this.Close(); // Fecha a TelaCadOng ao abrir confirmcadOng
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar ONG: " + ex.Message);
            }
        }




    }
}

