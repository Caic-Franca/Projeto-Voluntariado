//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Projeto_Voluntariado.Models;
//using System.Windows.Forms;

//namespace Projeto_Voluntariado.Models.Classes_Objetos.Inscricao
//{
//    class InscricaoController
//    {

//        private InscricaoRepositorio inscricaoRepositorio;

//        public InscricaoController(InscricaoRepositorio inscricaoRepositorio)
//        {
//            this.inscricaoRepositorio = inscricaoRepositorio;
//        }

//        public bool InserirInscricao(Inscricao inscricao)
//        {


//            bool resultadoInsercao = inscricaoRepositorio.InserirInscricao(inscricao);

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
