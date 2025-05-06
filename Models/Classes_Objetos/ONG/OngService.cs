using Projeto_Voluntariado.Models;
using Projeto_Voluntariado.Services;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Voluntariado.Models.Classes_Ong;

namespace Projeto_Voluntariado.Model
{
    public class ONGRepositorio
    {
        DatabaseService _databaseService;

        public ONGRepositorio(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        //public List<Ong> getAllUser()
        //{

        //    List<Ong> usuarios = new List<Ong>();

        //    try
        //    {

        //       // string query = "SELECT * FROM usuarios JOIN regras on usuarios.idRegra = regras.idregra";
        //       // MySqlDataReader resultadoBanco = _databaseService.ExecuteQuery(query);

        //        while (resultadoBanco.Read())
        //        {
        //            Ong Ong = new Ong();
        //            Ong = Ong.UserFromDataReader(resultadoBanco);


        //            usuarios.Add(Ong);
        //        }
        //        _databaseService.CloseConnection();

        //        return usuarios;

        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Erro ao buscar usuários: " + ex.Message);
        //    }


        //}


        //public bool Register(Usuario usuario, string password)
        //{
        //    try
        //    {
        //        string query = @"INSERT INTO Ong 
        //                        (ID, nome, email, senha, data_cadastro, ativo) 
        //                        VALUES 
        //                        (@nome, @email, @senha_hash, @data_cadastro, @ativo)";

        //        var parameters = new MySqlParameter[]
        //        {
        //            new MySqlParameter("@nome", usuario.Nome),
        //            new MySqlParameter("@email", usuario.Email),
        //            new MySqlParameter("@senha_hash", Criptografia.HashPassword(password)),
        //            new MySqlParameter("@data_cadastro", DateTime.Now),
        //            new MySqlParameter("@ativo", true)
        //        };

        //        int affectedRows = _databaseService.ExecuteNonQuery(query, parameters);
        //        return affectedRows > 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Erro ao registrar usuário: " + ex.Message);
        //    }
        //}
    }
}