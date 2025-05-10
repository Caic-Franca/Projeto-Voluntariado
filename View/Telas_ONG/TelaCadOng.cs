//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using Projeto_Voluntariado.Models;
//using Projeto_Voluntariado.Models.Classes_Objetos.ONG;
//using Projeto_Voluntariado.Services;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


//namespace Projeto_Voluntariado.View.telas_Cadastro_ONG
//{
//    public partial class TelaCadOng : Form
//    {
//        private readonly OngController _ongController;
//        public TelaCadOng()
//        {
//private void btn_ConfOngCad_Click(object sender, EventArgs e)
//        {

//        }    //        InitializeComponent();
             //        try
             //        {
             //            // Inicializa o controller com as dependências necessárias
             //            var databaseService = new DatabaseService();
             //            var ongRepositorio = new OngRepositorio(databaseService);
             //            _ongController = new OngController(ongRepositorio);
             //        }
             //        catch (Exception ex)
             //        {
             //            MessageBox.Show($"Erro ao inicializar serviços: {ex.Message}");
             //            // Considerar encerrar a aplicação se o controller for essencial
             //            Close();
             //        }
             //    }

//    private void btn_ConfOngCad_Click(object sender, EventArgs e)
//    {
//        try
//        {
//            // Validações de campos obrigatórios
//            if (CamposInvalidos())
//            {
//                MessageBox.Show("Preencha todos os campos obrigatórios!");
//                return;
//            }

//            // Validações específicas
//            if (!ValidarEmail(txtEmailOng.Text))
//            {
//                MessageBox.Show("Email inválido!");
//                return;
//            }

//            if (!ValidarSenha(txtSenhaOng.Text, txtConfirmSenhaOng.Text))
//            {
//                return; // Mensagem já é exibida no método ValidarSenha
//            }

//            if (!ValidarCNPJ(txtCnpjOng.Text))
//            {
//                MessageBox.Show("CNPJ inválido! Deve ter 14 dígitos.");
//                return;
//            }

//            if (txtNomeOng == null || txtEmailOng == null || txtSenhaOng == null || txtConfirmSenhaOng == null ||
//         txtNomeRespOng == null || txtCnpjOng == null || txtEndOng == null || txtAreaOng == null)
//            {
//                MessageBox.Show("Erro: Um ou mais campos não foram inicializados corretamente.");
//                return;
//            }

//            string dadosOng = $"Dados capturados:\n\n" +
//                    $"Nome da ONG: {txtNomeOng?.Text ?? "[NULO]"}\n" +
//                    $"Email: {txtEmailOng?.Text ?? "[NULO]"}\n" +
//                    $"Senha: {txtSenhaOng?.Text ?? "[NULO]"}\n" +
//                    $"Confirmação Senha: {txtConfirmSenhaOng?.Text ?? "[NULO]"}\n" +
//                    $"Responsável: {txtNomeRespOng?.Text ?? "[NULO]"}\n" +
//                    $"CNPJ: {txtCnpjOng?.Text ?? "[NULO]"}\n" +
//                    $"Endereço: {txtEndOng?.Text ?? "[NULO]"}\n" +
//                    $"Área de Atuação: {txtAreaOng?.Text ?? "[NULO]"}\n" +
//                    $"Descrição: {txtDescOng?.Text ?? "[NULO]"}\n" +
//                    $"Site: {txtSite?.Text ?? "[NULO]"}";

//            MessageBox.Show(dadosOng, "Verificação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);



//            var novaOng = new OngCadastro
//            {
//                NomeOng = txtNomeOng.Text,
//                Email = txtEmailOng.Text,
//                Senha = txtSenhaOng.Text,
//                ConfirmSenha = txtConfirmSenhaOng.Text,
//                NomeResponsavel = txtNomeRespOng.Text,
//                Cnpj = txtCnpjOng.Text.Replace(".", "").Replace("-", "").Replace("/", ""),
//                Endereco = txtEndOng.Text,
//                AreaAtuacao = txtAreaOng.Text,
//                DescricaoOng = txtDescOng.Text,
//                LinkSite = txtLinkOng.Text
//            };

//            // DEBUG: Exibe todos os atributos do objeto
//            string debugInfo = $"DEBUG - Valores do objeto OngCadastro:\n\n" +
//                             $"ID: {novaOng.Id}\n" +
//                             $"Nome: {novaOng.NomeOng}\n" +
//                             $"Email: {novaOng.Email}\n" +
//                             $"Senha: {novaOng.Senha}\n" +
//                             $"Confirmação Senha: {novaOng.ConfirmSenha}\n" +
//                             $"Responsável: {novaOng.NomeResponsavel}\n" +
//                             $"CNPJ: {novaOng.Cnpj}\n" +
//                             $"Endereço: {novaOng.Endereco}\n" +
//                             $"Área Atuação: {novaOng.AreaAtuacao}\n" +
//                             $"Descrição: {novaOng.DescricaoOng}\n" +
//                             $"Site: {novaOng.LinkSite}";

//            MessageBox.Show(debugInfo, "DEBUG - Valores do Objeto", MessageBoxButtons.OK, MessageBoxIcon.Information);



//            //// Restante do seu código...
//            //var ong = new OngCadastro
//            //{
//            //    NomeOng = txtNomeOng.Text,
//            //    Email = txtEmailOng.Text,
//            //    Senha = txtSenhaOng.Text,
//            //    ConfirmSenha = txtConfirmSenhaOng.Text,
//            //    NomeResponsavel = txtNomeRespOng.Text,
//            //    Cnpj = txtCnpjOng.Text,
//            //    Endereco = txtEndOng.Text,
//            //    AreaAtuacao = txtAreaOng.Text,
//            //    DescricaoOng = txtDescOng.Text,
//            //    LinkSite = txtSite.Text
//            //};


//            //// Cria novo objeto ONG
//            ////var novaOng = CriarOngFromInputs();

//            //// Tenta inserir
//            //bool resultado = _ongController.InserirOng(ong);

//            //if (resultado)
//            //{
//            //    MessageBox.Show("ONG cadastrada com sucesso!");
//            //    this.Close();
//            //}
//        }
//        catch (Exception ex)
//        {
//            MessageBox.Show($"Erro: {ex.Message}");
//            // Logar erro seria ideal aqui
//        }
//    }

//    private bool CamposInvalidos()
//    {
//        return string.IsNullOrWhiteSpace(txtNomeOng.Text) ||
//               string.IsNullOrWhiteSpace(txtEmailOng.Text) ||
//               string.IsNullOrWhiteSpace(txtSenhaOng.Text) ||
//               string.IsNullOrWhiteSpace(txtConfirmSenhaOng.Text) ||
//               string.IsNullOrWhiteSpace(txtNomeRespOng.Text) ||
//               string.IsNullOrWhiteSpace(txtCnpjOng.Text) ||
//               string.IsNullOrWhiteSpace(txtEndOng.Text) ||
//               string.IsNullOrWhiteSpace(txtAreaOng.Text);
//    }

//    private bool ValidarEmail(string email)
//    {
//        return email.Contains("@") && email.Contains(".");
//    }

//    private bool ValidarSenha(string senha, string confirmacao)
//    {
//        if (senha != confirmacao)
//        {
//            MessageBox.Show("As senhas não coincidem!");
//            return false;
//        }

//        if (senha.Length < 6)
//        {
//            MessageBox.Show("A senha deve ter pelo menos 6 caracteres!");
//            return false;
//        }

//        return true;
//    }

//    private bool ValidarCNPJ(string cnpj)
//    {
//        return cnpj.Length == 14 && cnpj.All(char.IsDigit);
//    }

//    public Ong CriarOngFromInputs()
//    {
//        return new Ong
//        {
//            NomeOng = txtNomeOng.Text,
//            Cnpj = txtCnpjOng.Text,
//            DescricaoOng = txtDescOng.Text,
//            AreaAtuacao = txtAreaOng.Text,
//            Endereco = txtEndOng.Text,
//            NomeResponsavel = txtNomeRespOng.Text,
//            Email = txtEmailOng.Text,
//            Senha = txtSenhaOng.Text,
//            LinkSite = txtLinkOng.Text
//        };
//    }

//    private void btn_voltar_cadOng_Click(object sender, EventArgs e)
//    {
//        this.Close();
//    }

//    private void TelaCadOng_Load(object sender, EventArgs e)
//    {

//    }

//    private void label13_Click(object sender, EventArgs e)
//    {

//    }

//    private void TelaCadOng_Load_1(object sender, EventArgs e)
//    {

//    }
//}


//}




