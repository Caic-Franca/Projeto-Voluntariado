﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Voluntariado.View.telas_Cadastro_ONG
{
    public partial class TelaHomeOng: Form
    {
        public TelaHomeOng()
        {
            InitializeComponent();
        }

        private void btn_VoltarVlt_Click(object sender, EventArgs e)
        {

        }

        private void btn_SairVlt_Click(object sender, EventArgs e)
        {
            Home telaHome = new Home();
            telaHome.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaCriarOpOng telaCriarOpOng = new TelaCriarOpOng();
            telaCriarOpOng.Show();
        }
    }
}
