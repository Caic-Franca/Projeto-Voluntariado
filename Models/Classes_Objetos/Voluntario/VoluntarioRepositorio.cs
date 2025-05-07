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
            catch (Exception ex)
            {

            }

            return new Voluntario(); // Retorna um novo objeto Voluntario, você pode preencher com os dados do banco de dados

        }


        public Voluntario InserirVoluntario(Voluntario voluntario)
        {

            string query = "INSERT INTO voluntario (email, senha, dataNascimento,telefone,endereco,habilidade,interese,disponibilidade,nome ) VALUES ()";

            var parameters = new MySqlParameter[] {

                    new MySqlParameter("@Email", voluntario.Email),
                    new MySqlParameter("@Senha", voluntario.Senha),
                    new MySqlParameter("@DataNascimento", voluntario.DataNascimento),
                    new MySqlParameter("@Telefone", voluntario.Telefone),
                    new MySqlParameter("@Endereco", voluntario.Endereco),
                    new MySqlParameter("@Interese", voluntario.AreaInteresse),
                    new MySqlParameter("@Habilidade", voluntario.Experiencia),
                    new MySqlParameter("@Nome", voluntario.Nome),
                    new MySqlParameter("@Disponibilidade", voluntario.Disponibilidade)

                };

            //    try
            //    {

            //        Voluntario voluntario = new Voluntario();

            //        MySqlDataReader dataReaderResposta = _databaseService.ExecuteNonQuery(query, parameters);

            //        while (dataReaderResposta.Read())
            //        {

            //            string senhaBanco = dataReaderResposta["senha"].ToString();

            //            if (senhaBanco == Criptografia.HashPassword(senhaDigitada))
            //            {

            //                voluntario = Voluntario.VoluntarioFromDataReader(dataReaderResposta);

            //            }

            //        }

            //        return voluntario;

            //    }
            //    catch (Exception ex)
            //    {

            //    }
            //    return new Voluntario(); // Retorna um novo objeto Voluntario, você pode preencher com os dados do banco de dados

            //}


        }
    }
}
