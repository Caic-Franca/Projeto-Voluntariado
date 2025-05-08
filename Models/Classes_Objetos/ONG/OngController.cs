using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Voluntariado.Models;

namespace Projeto_Voluntariado.Models.Classes_Objetos.ONG
{
    class OngController
    {
        private OngRepositorio ongRepositorio;

        public OngController(OngRepositorio ongRepositorio)
        {
            this.ongRepositorio = ongRepositorio;
        }

        public bool InserirOng(Ong ong)
        {


            bool resultadoInsercao = ongRepositorio.InserirOng(ong);

            if (resultadoInsercao)
            {

                MessageBox.Show("Ong criada com sucesso!");
                return true;

            }

            MessageBox.Show("Erro na inserção da Ong");
            return false;

        }
    }
}

