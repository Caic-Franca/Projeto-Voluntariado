using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projeto_Voluntariado.Models
{
    public class Ong
    {
        public int Id { get; set; }
        public string nomeOng { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string confirmSenha { get; set; }
        public string nomeResponsavel { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }
        public string areaAtuacao { get; set; }
        public string descricaoOng { get; set; }
        public string linkSite { get; set; }
        public DateTime DataCadastro { get; set; }


        
        public Ong(int id, string nomeOng, string email, string senha, string confirmSenha, string nomeResponsavel, string cnpj, string endereco, string areaAtuacao, string descricaoOng, string linkSite)
        {
            Id = id;
            this.nomeOng = nomeOng;
            Email = email;
            Senha = senha;
            this.confirmSenha = confirmSenha;
            this.nomeResponsavel = nomeResponsavel;
            Cnpj = cnpj;
            Endereco = endereco;
            this.areaAtuacao = areaAtuacao;
            this.descricaoOng = descricaoOng;
            this.linkSite = linkSite;
        }

        public Ong()
        {
        }

        public static Ong OngFromDataReader(MySqlDataReader dataReader)
        {

            return new Ong
            {
                Id = dataReader.GetInt32("idOng"),
                nomeOng = dataReader["nomeOng"].ToString(),
                Email = dataReader["email"].ToString(),
                nomeResponsavel = dataReader["contatoResponsavel"].ToString(),
                Endereco = dataReader["endereco"].ToString(),
                Cnpj = dataReader["cnpj"].ToString(),
                areaAtuacao = dataReader["atuacao"].ToString(),
                descricaoOng = dataReader["descricao"].ToString(),
                linkSite = dataReader["linkSite"].ToString()

            };
        }
    }
}
