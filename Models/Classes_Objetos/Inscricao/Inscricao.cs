using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Voluntariado.Models.Classes_Objetos.Inscricao
{
    class Inscricao
    {
        public Inscricao(int idOportunidade, int idVoluntario)
        {
            IdOportunidade = idOportunidade;
            IdVoluntario = idVoluntario;
        }

        public int IdInscricao { get; set; }
        public int IdOportunidade { get; set; }
        public int IdVoluntario { get; set; }
        
    }
}
