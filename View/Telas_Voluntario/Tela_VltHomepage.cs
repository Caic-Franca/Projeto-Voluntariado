﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Voluntariado.Models.Classes_Objetos;

namespace Projeto_Voluntariado.View.Telas_Voluntario
{
    public partial class Tela_VltHomepage: Form
    {
        public Tela_VltHomepage()
        { 
            InitializeComponent();
        }
        private void btn_SairVlt_Click(object sender, EventArgs e)
        {
            Home telaHome = new Home();
            telaHome.Show();

            this.Close(); // Fecha Tela_VltHomepage ao voltar para a Home
        }

        private void Tela_VltHomepage_Load(object sender, EventArgs e)
        {

        }

        private void Tela_VltHomepage_Load_1(object sender, EventArgs e)
        {
               
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
