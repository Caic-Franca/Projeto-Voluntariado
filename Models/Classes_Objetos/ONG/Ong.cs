using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Projeto_Voluntariado.Models;

namespace Projeto_Voluntariado.Models
{
    public class Ong
    {
        public Ong()
        {
        }

        public Ong(string nomeOng, string email, string senha, string nomeResponsavel, string cnpj, string endereco, string areaAtuacao, string descricaoOng, string linkSite)
        {
            NomeOng = nomeOng;
            Email = email;
            Senha = senha;
            NomeResponsavel = nomeResponsavel;
            Cnpj = cnpj;
            Endereco = endereco;
            AreaAtuacao = areaAtuacao;
            DescricaoOng = descricaoOng;
            LinkSite = linkSite;
        }

        public int Id { get; set; }
        public string NomeOng { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string ConfirmSenha { get; set; }
        public string NomeResponsavel { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }
        public string AreaAtuacao { get; set; }
        public string DescricaoOng { get; set; }
        public string LinkSite { get; set; }


        public static Ong OngFromDataReader(MySqlDataReader dataReader)
        {

            return new Ong
            {
                Id = dataReader.GetInt32("idOng"),
                NomeOng = dataReader["nomeOng"].ToString(),
                Email = dataReader["email"].ToString(),
                NomeResponsavel = dataReader["contatoResponsavel"].ToString(),
                Endereco = dataReader["endereco"].ToString(),
                Cnpj = dataReader["cnpj"].ToString(),
                AreaAtuacao = dataReader["atuacao"].ToString(),
                DescricaoOng = dataReader["descricao"].ToString(),
                LinkSite = dataReader["linkSite"].ToString()

            };
        }
    }
}
