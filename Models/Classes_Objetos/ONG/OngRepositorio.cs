using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Voluntariado.Services;
using Projeto_Voluntariado.Models;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Projeto_Voluntariado.Models.Classes_Ong;
using Projeto_Voluntariado.Controller.Services;


namespace Projeto_Voluntariado.Models
{
    public class OngRepositorio
    {
        private DatabaseService _databaseService;
        public OngRepositorio(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public Ong RealizarLogin(string email, string senha)
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
    }
}
