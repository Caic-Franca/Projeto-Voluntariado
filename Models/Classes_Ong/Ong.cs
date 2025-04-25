using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Voluntariado.Models.Classes_Ong
{
    class Ong
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


        // Construtor
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
    }
}
