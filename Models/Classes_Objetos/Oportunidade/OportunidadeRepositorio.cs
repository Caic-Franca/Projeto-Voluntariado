using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Voluntariado.Services;
using Projeto_Voluntariado.Models;
using Projeto_Voluntariado.Models.Classes_Objetos;
using MySql.Data.MySqlClient;
using Projeto_Voluntariado.Controller.Services;
using Projeto_Voluntariado.Models;


namespace Projeto_Voluntariado.Models
{
    public class OportunidadeRepositorio
    {
        private DatabaseService _databaseService;
        public OportunidadeRepositorio(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public bool InserirOportunidade(Oportunidade oportunidade)
        {

            string query = @"INSERT INTO oportunidade (nomeVaga, descricao, atuacaoVaga, localizacao, modalidadeVaga, cargaHoraria, requisitosVaga, beneficios, dataPublicacao, andamentoVaga, idOngResposavel)

                            VALUES (,@nomeVaga, @descricao, @atuacaoVaga, @localizacao, @modalidadeVaga, @cargaHoraria, @requisitosVaga, @beneficios, @dataPublicacao, @andamentoVaga, @idOngResposavel)";

            var parameters = new MySqlParameter[] {

                    new MySqlParameter("@IdOportunidade", oportunidade.Id),
                    new MySqlParameter("@@nomeVaga", oportunidade.Titulo),
                    new MySqlParameter("@descricao", oportunidade.Descricao),
                    new MySqlParameter("@atuacaoVaga", oportunidade.AreaAtuacao),
                    new MySqlParameter("@localizacao", oportunidade.Localizacao),
                    new MySqlParameter("@modalidadeVaga", oportunidade.Modalidade),
                    new MySqlParameter("@cargaHoraria", oportunidade.CargaHorariaSemanal),
                    new MySqlParameter("@requisitosVaga", oportunidade.Requisitos),
                    new MySqlParameter("@beneficios", oportunidade.Beneficios),
                    new MySqlParameter("@dataPublicacao", oportunidade.DataPublicacao),
                    new MySqlParameter("@andamentoVaga", oportunidade.Status),
                    new MySqlParameter("@IdOngResposavel", oportunidade.OngResponsavel)
            };

            try
            {
                int linhasGravadas = _databaseService.ExecuteNonQuery(query, parameters);
                return linhasGravadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro na inserção da Oportunidade: {ex}");
            }
        }
    }
}
