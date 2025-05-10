//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Projeto_Voluntariado.Services;
//using Projeto_Voluntariado.Models;
//using MySql.Data.MySqlClient;
//using Projeto_Voluntariado.Controller.Services;



//namespace Projeto_Voluntariado.Models.Classes_Objetos
//{
//    class OportunidadeController
//    {
//        private OportunidadeRepositorio oportunidadeRepositorio;

//        public OportunidadeController(OportunidadeRepositorio oportunidadeRepositorio)
//        {
//            this.oportunidadeRepositorio = oportunidadeRepositorio;
//        }

//        public bool InserirOportunidade(Oportunidade oportunidade)
//        {


//            bool resultadoInsercao = oportunidadeRepositorio.InserirOportunidade(oportunidade);

//            if (resultadoInsercao)
//            {
//                MessageBox.Show("Voluntário criado com sucesso!");
//                return true;
//            }

//            MessageBox.Show("Erro na inserção do usuário");
//            return false;


//        }

//    }
//}