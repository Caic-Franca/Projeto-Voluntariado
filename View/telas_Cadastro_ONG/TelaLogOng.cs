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
    public partial class TelaLogOng: Form
    {
        public TelaLogOng()
        {
            InitializeComponent();
        }

        private void TelaLogOng_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaHomeOng telaHomeOng = new TelaHomeOng();
            telaHomeOng.Show();

        }
    }
}
