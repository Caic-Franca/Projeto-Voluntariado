using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Voluntariado.Models.Classes_Objetos;
using Projeto_Voluntariado.Models;
using Projeto_Voluntariado.Services;
using Projeto_Voluntariado.Models.Classes_Objeto;


namespace Projeto_Voluntariado.View.Telas_ONG
{
    public partial class OngTelaDeCacadastro : Form
    {
        private OngController ongController;
        public OngTelaDeCacadastro()
        //
        {
            InitializeComponent();
            ongController = new OngController(new OngRepositorio(new DatabaseService()));

        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {

            // verifica se todo so scampos foram preenchidos
            if (string.IsNullOrWhiteSpace(txtNomeOng.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmaSenha.Text) ||
                string.IsNullOrWhiteSpace(txtNomeResponsavel.Text) ||
                string.IsNullOrWhiteSpace(txtCnpj.Text) ||
                string.IsNullOrWhiteSpace(txtEndereco.Text) ||
                string.IsNullOrWhiteSpace(txtAreaAtuacao.Text)

                )
            {

                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            // validações             
            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains(".com"))
            {
                MessageBox.Show("Email inválido!");
                return;
            }
            if (txtSenha.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres!");
                return;
            }
            if (txtSenha.Text != txtConfirmaSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem!");
                return;
            }
            if (txtCnpj.Text.Length < 14)
            {
                MessageBox.Show("Número de CNPJ invalido \n O CNPJ deve conter 14 digitos.");
                return;
            }

            // criação do objeto ONg com os Dados preenchidos
            Ong novaOng = new Ong(
               txtNomeOng.Text,
               txtEmail.Text,
                txtSenha.Text,
                txtNomeResponsavel.Text,
                txtCnpj.Text,
                txtEndereco.Text,
                txtAreaAtuacao.Text,
                txtBreveDescricao.Text,
                txtLinkSite.Text);

            bool resultInsercao = ongController.InserirOng(novaOng);

            if (resultInsercao)
            {

                MessageBox.Show("Parabéns, você criou o cadastro com sucesso!");
                this.Close(); // Fecha a tela atual

                return;

            }
        }

        private void OngTelaDeCacadastro_Load(object sender, EventArgs e)
        {

        }
    }
}

           




