//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Projeto_Voluntariado.Models.Classes_Objetos.ONG
//{
//    class OngController
//    {
//        private readonly OngRepositorio ongRepositorio;
//        public OngController(OngRepositorio ongRepositorio)
//        {
//            ongRepositorio = ongRepositorio ?? throw new ArgumentNullException(nameof(ongRepositorio));
//        }

//        public bool InserirOng(Ong ong)
//        {
//            if (ong == null)
//            {
//                throw new ArgumentNullException(nameof(ong));
//            }

//            try
//            {
//                bool resultadoInsercao = ongRepositorio.InserirOng(ong);

//                if (!resultadoInsercao)
//                {
//                    MessageBox.Show("Erro ao inserir ONG no banco de dados.");
//                    return false;
//                }

//                return true;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show($"Erro ao inserir ONG: {ex.Message}");
//                return false;
//            }

//            //public OngController(OngRepositorio ongRepositorio)
//            //{
//            //    this.ongRepositorio = ongRepositorio;
//            //}

//            //public bool InserirOng(Ong ong)
//            //{


//            //    bool resultadoInsercao = ongRepositorio.InserirOng(ong);

//            //    if (resultadoInsercao)
//            //    {

//            //        MessageBox.Show("Ong criada com sucesso!");
//            //        return true;

//            //    }

//            //    MessageBox.Show("Erro na inserção da Ong");
//            //    return false;

//            //}
//        }
//}
//    }

