using System;
using System.Linq;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace Projeto_Voluntariado.Models
{
    public class OngCadastro
    {
        // Propriedades (iguais à classe Ong)
        public int Id { get; set; }
        public string NomeOng { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string ConfirmSenha { get; set; }
        public string NomeResponsavel { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }
        public string AreaAtuacao { get; set; }
        public string DescricaoOng { get; set; }
        public string LinkSite { get; set; }

        // Método para criar uma ONG a partir de um DataReader (igual ao seu)
        public static OngCadastro FromDataReader(MySqlDataReader dataReader)
        {
            return new OngCadastro
            {
                Id = dataReader.GetInt32("idOng"),
                NomeOng = dataReader["nomeOng"].ToString(),
                Email = dataReader["email"].ToString(),
                NomeResponsavel = dataReader["contatoResponsavel"].ToString(),
                Endereco = dataReader["endereco"].ToString(),
                Cnpj = dataReader["cnpj"].ToString(),
                AreaAtuacao = dataReader["atuacao"].ToString(),
                DescricaoOng = dataReader["descricao"].ToString(),
                LinkSite = dataReader["linkSite"].ToString()
            };
        }

        // Método para validar os dados antes do cadastro
        public bool ValidarDados(out string mensagemErro)
        {
            mensagemErro = "";

            if (string.IsNullOrWhiteSpace(NomeOng))
                mensagemErro += "Nome da ONG é obrigatório.\n";

            if (string.IsNullOrWhiteSpace(Email) || !ValidarEmail(Email))
                mensagemErro += "E-mail inválido.\n";

            if (string.IsNullOrWhiteSpace(Senha) || Senha.Length < 6)
                mensagemErro += "Senha deve ter pelo menos 6 caracteres.\n";

            if (Senha != ConfirmSenha)
                mensagemErro += "As senhas não coincidem.\n";

            if (string.IsNullOrWhiteSpace(Cnpj) || !ValidarCnpj(Cnpj))
                mensagemErro += "CNPJ inválido (deve ter 14 dígitos).\n";

            return string.IsNullOrEmpty(mensagemErro);
        }

        // Validação de e-mail (simplificada)
        private bool ValidarEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        // Validação de CNPJ (apenas verifica se tem 14 dígitos)
        private bool ValidarCnpj(string cnpj)
        {
            return !string.IsNullOrWhiteSpace(cnpj) && cnpj.Length == 14 && cnpj.All(char.IsDigit);
        }

        // Método para gerar um comando SQL de INSERT (útil para salvar no banco)
        public MySqlCommand GerarComandoInsert()
        {
            string query = @"
                INSERT INTO ongs 
                (nomeOng, email, senha, contatoResponsavel, cnpj, endereco, atuacao, descricao, linkSite) 
                VALUES 
                (@NomeOng, @Email, @Senha, @NomeResponsavel, @Cnpj, @Endereco, @AreaAtuacao, @DescricaoOng, @LinkSite)";

            var cmd = new MySqlCommand(query);
            cmd.Parameters.AddWithValue("@NomeOng", NomeOng);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Senha", Senha);
            cmd.Parameters.AddWithValue("@NomeResponsavel", NomeResponsavel);
            cmd.Parameters.AddWithValue("@Cnpj", Cnpj);
            cmd.Parameters.AddWithValue("@Endereco", Endereco);
            cmd.Parameters.AddWithValue("@AreaAtuacao", AreaAtuacao);
            cmd.Parameters.AddWithValue("@DescricaoOng", DescricaoOng);
            cmd.Parameters.AddWithValue("@LinkSite", LinkSite);

            return cmd;
        }
    }
}