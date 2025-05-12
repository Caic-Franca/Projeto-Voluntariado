
    using System;
    using System.Windows.Forms;
    using Projeto_Voluntariado.Controller;

    namespace Projeto_Voluntariado.Models.Classes_Objeto
    {
        class OngController
        {
            private OngRepositorio _ongRepositorio; // Corrigido o tipo

            public OngController(OngRepositorio ongRepositorio)
            {
                _ongRepositorio = ongRepositorio;
            }

            public bool InserirOng(Ong ong)
            {
                bool resultadoInsercao = _ongRepositorio.InserirOng(ong);

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




