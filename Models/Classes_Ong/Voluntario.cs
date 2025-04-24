using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Voluntariado.Models.Classes_Ong
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
    }
}
