using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Voluntariado.Services;
using Projeto_Voluntariado.Models;


namespace Projeto_Voluntariado.Models
{
    public class VoluntarioRepositorio
    {
        private DatabaseService _databaseService;
        public VoluntarioRepositorio(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public Voluntario RealizarLogin(string email, string senha) { 

               string query = "SELECT * FROM Voluntario WHERE email = @Email AND senha = @Senha";

            return new Voluntario(); // Retorna um novo objeto Voluntario, você pode preencher com os dados do banco de dados

        } 


    }
}
