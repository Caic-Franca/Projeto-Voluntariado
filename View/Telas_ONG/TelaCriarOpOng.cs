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
using Projeto_Voluntariado.Models.Classes_Objetos;
using Projeto_Voluntariado.Services;

namespace Projeto_Voluntariado.View.telas_Cadastro_ONG
{
    public partial class TelaCriarOpOng : Form
    {
        private OportunidadeController oportunidadeController;

        public TelaCriarOpOng(OportunidadeController oportunidadeController)
        {
            InitializeComponent();
            oportunidadeController = new OportunidadeController(new OportunidadeRepositorio(new DatabaseService()));
            this.oportunidadeController = oportunidadeController;
        }

        private void btn_voltar_cadVlt_Click(object sender, EventArgs e)
        {
            TelaHomeOng telaHomeOng = new TelaHomeOng();
            telaHomeOng.Show();
            this.Close(); // Fecha TelaCriarOpOng ao voltar para TelaHomeOng

        }

        private void btn_confVltCad_Click(object sender, EventArgs e)
        {
            // Verifica se os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(txtTituloVaga.Text) ||
            string.IsNullOrWhiteSpace(txtDescricaoVaga.Text) ||
            string.IsNullOrWhiteSpace(txtAreaAtuacao.Text) ||
            string.IsNullOrWhiteSpace(txtModalidade.Text) ||
            string.IsNullOrWhiteSpace(txtCargaHora.Text) ||
            string.IsNullOrWhiteSpace(txtDataPubli.Text) ||
            string.IsNullOrWhiteSpace(txtStatusOp.Text) ||
            string.IsNullOrWhiteSpace(txtOngResp.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            // Validação da data
            DateTime dataPublicacao;
            if (!DateTime.TryParse(txtDataPubli.Text, out dataPublicacao))
            {
                MessageBox.Show("Data inválida! Use o formato dd/MM/aaaa");
                txtDataPubli.Focus();
                return;
            }

            // Validação da carga horária
            int cargaHoraria;
            if (!int.TryParse(txtCargaHora.Text, out cargaHoraria))
            {
                MessageBox.Show("Carga horária deve ser um número inteiro!");
                txtCargaHora.Focus();
                return;
            }

            try
            {
                Oportunidade oportunidade = new Oportunidade(
                    0,
                    txtTituloVaga.Text,
                    txtDescricaoVaga.Text,
                    txtAreaAtuacao.Text,
                    txtLocalVaga.Text,
                    txtModalidade.Text,
                    cargaHoraria,
                    txtRequisito.Text,
                    txtBeneficio.Text,
                    dataPublicacao,
                    txtStatusOp.Text,
                    txtOngResp.Text);

                //ConfirmcadOng telaConfirmCadOng = new ConfirmcadOng();
                //telaConfirmCadOng.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar oportunidade: {ex.Message}");
            }


        }

        private void TelaCriarOpOng_Load(object sender, EventArgs e)
        {

        }
    }
}