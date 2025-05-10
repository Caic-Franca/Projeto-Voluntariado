using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
//using MySql.Data.MySqlClient;


namespace Projeto_Voluntariado.Models
{
     public class Oportunidade
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string AreaAtuacao { get; set; }
        public string Localizacao { get; set; }
        public string Modalidade { get; set; }
        public int CargaHorariaSemanal { get; set; }
        public string Requisitos { get; set; }
        public string Beneficios { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Status { get; set; }       
        public string OngResponsavel { get; set; }

        // Construtor
        public Oportunidade(int id, string titulo, string descricao, string areaAtuacao, string localizacao, string modalidade, int cargaHorariaSemanal, string requisitos, string beneficios, DateTime dataPublicacao, string status, string ongResponsavel)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            AreaAtuacao = areaAtuacao;
            Localizacao = localizacao;
            Modalidade = modalidade;
            CargaHorariaSemanal = cargaHorariaSemanal;
            Requisitos = requisitos;
            Beneficios = beneficios;
            DataPublicacao = dataPublicacao;
            Status = status;            
            OngResponsavel = ongResponsavel;
        }
    }


}
