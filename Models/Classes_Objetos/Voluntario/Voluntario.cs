using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projeto_Voluntariado.Models
{
    public class Voluntario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string ConfirmarSenha { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string AreaInteresse { get; set; }
        public string Experiencia { get; set; }
        public string Disponibilidade { get; set; }

        // Construtor
        public Voluntario(int id, string nome, string email, string senha, string confirmarSenha, DateTime dataNascimento, string telefone, string endereco)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            ConfirmarSenha = confirmarSenha;
            DataNascimento = dataNascimento;
            Telefone = telefone;            
            Endereco = endereco;            
            
        }

        public Voluntario()
        {
           
        }

        public static Voluntario VoluntarioFromDataReader(MySqlDataReader dataReader)
        {

            return new Voluntario
            {
                Id = dataReader.GetInt32("idvoluntario"),
                Nome = dataReader["nome"].ToString(),
                Email = dataReader["email"].ToString(),
                Telefone = dataReader["telefone"].ToString(),
                Endereco = dataReader["endereco"].ToString(),
                DataNascimento = Convert.ToDateTime(dataReader["dataNascimento"]),

            };

        }

    }
}
