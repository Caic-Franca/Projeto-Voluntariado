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
    public class VoluntarioRepositorio
    {
        private DatabaseService _databaseService;
        public VoluntarioRepositorio(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public Voluntario RealizarLogin(string email, string senhaDigitada)
        {

            string query = "SELECT * FROM voluntario WHERE email = @Email";

            var parameters = new MySqlParameter[] {

                    new MySqlParameter("@Email", email)

                };

            try
            {

                Voluntario voluntario = new Voluntario();

                MySqlDataReader dataReaderResposta = _databaseService.ExecuteQuery(query, parameters);

                while (dataReaderResposta.Read())
                {

                    string senhaBanco = dataReaderResposta["senha"].ToString();

                    if (senhaBanco == Criptografia.HashPassword(senhaDigitada))
                    {

                        voluntario = Voluntario.VoluntarioFromDataReader(dataReaderResposta);

                    }

                }

                return voluntario;

            }
            catch (Exception)
            {


            }

            return new Voluntario(); // Retorna um novo objeto Voluntario, você pode preencher com os dados do banco de dados

        }


        public bool InserirVoluntario(Voluntario voluntario)
        {

            string query = @"INSERT INTO voluntario (email, senha, dataNascimento, telefone, endereco, habilidade, interesse, disponibilidade, nome)
                            VALUES (@Email, @Senha, @DataNascimento, @Telefone, @Endereco, @Habilidade, @Interesse, @Disponibilidade, @Nome)";

            var parameters = new MySqlParameter[] {

                    new MySqlParameter("@Email", voluntario.Email),
                    new MySqlParameter("@Senha", Criptografia.HashPassword(voluntario.Senha)),
                    new MySqlParameter("@DataNascimento", voluntario.DataNascimento),
                    new MySqlParameter("@Telefone", voluntario.Telefone),
                    new MySqlParameter("@Endereco", voluntario.Endereco),
                    new MySqlParameter("@Interesse", voluntario.AreaInteresse),
                    new MySqlParameter("@Habilidade", voluntario.Experiencia),
                    new MySqlParameter("@Nome", voluntario.Nome),
                    new MySqlParameter("@Disponibilidade", voluntario.Disponibilidade)

                };

            try
            {

                int linhasGravadas = _databaseService.ExecuteNonQuery(query, parameters);

                return linhasGravadas > 0;


            }
            catch (Exception ex)
            {
                throw new Exception($"Erro na inserção do voluntario: {ex}");
            }


        }


    }
}

