using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Voluntariado.Services;
using Projeto_Voluntariado.Models;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Projeto_Voluntariado.Controller.Services;
using Org.BouncyCastle.Asn1.Cmp;
using Projeto_Voluntariado.Models.Classes_Objetos.ONG;


namespace Projeto_Voluntariado.Models
{
    public class OngRepositorio
    {
        private DatabaseService _databaseService;
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
            catch (Exception ex)
            {
            }
            return new Ong(); // Retorna um novo objeto Ong, você pode preencher com os dados do banco de dados
        }
        public bool InserirOng(Ong ong)
        {
            string query = @"INSERT INTO ong (nomeOng, email, senha,cnpj,endereco,atuacao,descricao,linkSite,contatoResponsavel)
                           VALUES (@nomeOng, @Email, @Senha, @Cnpj, @Endereco, @AreaAtuacao, @DescericaoOng, @LinkSite, @ContatoResposvavel)";

            var parameters = new MySqlParameter[] {

                    new MySqlParameter("@NomeOng", ong.nomeOng),
                    new MySqlParameter("@Email", ong.Email),
                    new MySqlParameter("@Senha", ong.Senha),
                    new MySqlParameter("@Cnpj", ong.Cnpj),
                    new MySqlParameter("@Endereco", ong.Endereco),
                    new MySqlParameter("@AreaAtuacao", ong.areaAtuacao),
                    new MySqlParameter("@DescricaoOng", ong.descricaoOng),
                    new MySqlParameter("@LinkSite", ong.linkSite),
                    new MySqlParameter("@Contatoresposavel", ong.nomeResponsavel),
                };
            try
            {
                int linhasGravadas = _databaseService.ExecuteNonQuery(query, parameters);
                return linhasGravadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro na inserção da Ong: {ex}");
            }
        }
    }
}
