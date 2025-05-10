using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Voluntariado.Models.Classes_Objetos
{
    class VoluntarioController
    {
        private VoluntarioRepositorio voluntarioRepositorio;

        public VoluntarioController(VoluntarioRepositorio voluntarioRepositorio)
        {
            this.voluntarioRepositorio = voluntarioRepositorio;
        }

        public bool InserirVoluntario(Voluntario voluntario) {


           bool resultadoInsercao = voluntarioRepositorio.InserirVoluntario(voluntario);

            if (resultadoInsercao) {

                MessageBox.Show("Voluntário criado com sucesso!");
                return true;

            }

            MessageBox.Show("Erro na inserção do usuário");
            return false;


        }

    }
}
