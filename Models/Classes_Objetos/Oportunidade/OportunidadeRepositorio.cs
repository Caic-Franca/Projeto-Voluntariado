using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Voluntariado.Services;
using Projeto_Voluntariado.Models;
using Projeto_Voluntariado.Models.Classes_Ong;


namespace Projeto_Voluntariado.Models
{
    public class OportunidadeRepositorio
    {
        private DatabaseService _databaseService;
        public OportunidadeRepositorio(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

       // public Oportunidade RealizarLogin(string email, string senha)
      //  {

           // string query = "SELECT * FROM Voluntario WHERE email = @Email AND senha = @Senha";

          //  return new Oportunidade(); // Retorna um novo objeto Voluntario, você pode preencher com os dados do banco de dados

       // }


    }
}
