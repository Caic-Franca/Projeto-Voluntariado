using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Voluntariado.Services;
using Projeto_Voluntariado.Models;
using MySql.Data.MySqlClient;
using Projeto_Voluntariado.Controller.Services;

namespace Projeto_Voluntariado.Models
{
    public class OngRepositorio

    {
        //private DatabaseService _databaseService;
        private readonly DatabaseService _databaseService;


        public OngRepositorio(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public Ong RealizarLogin(string email, string senhaDigitada)
        {
            string query = "SELECT * FROM ong WHERE email = @Email";

            var parameters = new MySqlParameter[] {
                        new MySqlParameter("@Email", email)
                    };
            try
            {
                Ong ong = new Ong();

                MySqlDataReader dataReaderResposta = _databaseService.ExecuteQuery(query, parameters);

                while (dataReaderResposta.Read())
                {
                    string senhaBanco = dataReaderResposta["senha"].ToString();

                    if (senhaBanco == Criptografia.HashPassword(senhaDigitada))
                    {
                        ong = Ong.OngFromDataReader(dataReaderResposta);
                    }
                }
                return ong;
            }
            catch (Exception)
            {
            }
            return new Ong(); // Retorna um novo objeto Ong, você pode preencher com os dados do banco de dados
        }
        public bool InserirOng(Ong ong)
        {
            // Verifique valores obrigatórios antes de prosseguir
            if (string.IsNullOrEmpty(ong.NomeOng)) throw new ArgumentException("Nome da ONG é obrigatório");
            if (string.IsNullOrEmpty(ong.Email)) throw new ArgumentException("Email é obrigatório");
            // Adicione outras validações conforme necessário

            string query = @"INSERT INTO ong 
                    (nomeOng, email, senha, cnpj, endereco, atuacao, descricao, linkSite, contatoResponsavel)
                    VALUES 
                    (@nomeOng, @email, @senha, @cnpj, @endereco, @atuacao, @descricao, @linkSite, @contatoResponsavel)";

            var parameters = new MySqlParameter[] {
        new MySqlParameter("@nomeOng", ong.NomeOng ?? (object)DBNull.Value),
        new MySqlParameter("@email", ong.Email ?? (object)DBNull.Value),
        new MySqlParameter("@senha", ong.Senha ?? (object)DBNull.Value),
        new MySqlParameter("@cnpj", ong.Cnpj ?? (object)DBNull.Value),
        new MySqlParameter("@endereco", ong.Endereco ?? (object)DBNull.Value),
        new MySqlParameter("@atuacao", ong.AreaAtuacao ?? (object)DBNull.Value),
        new MySqlParameter("@descricao", ong.DescricaoOng ?? (object)DBNull.Value),
        new MySqlParameter("@linkSite", ong.LinkSite ?? (object)DBNull.Value),
        new MySqlParameter("@contatoResponsavel", ong.NomeResponsavel ?? (object)DBNull.Value)
    };

            try
            {
                int linhasGravadas = _databaseService.ExecuteNonQuery(query, parameters);
                return linhasGravadas > 0;
            }
            catch (MySqlException ex)
            {
                // Log específico para erros MySQL
                Console.WriteLine($"Erro MySQL #{ex.Number}: {ex.Message}");
                throw new Exception($"Erro ao inserir ONG: {ex.Message}", ex);
            }
        } }
    }
