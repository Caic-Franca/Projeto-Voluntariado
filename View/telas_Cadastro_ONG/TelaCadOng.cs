using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Voluntariado.Models.Classes_Ong;


namespace Projeto_Voluntariado.View.telas_Cadastro_ONG
{
    public partial class TelaCadOng: Form
    {       
        public TelaCadOng()
        {
            InitializeComponent();
        }

        private void enun_Nasc_Click(object sender, EventArgs e)
        {

        }

        private void txt_NascVlt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_voltar_cadOng_Click(object sender, EventArgs e)
        {
            Home telaHome = new Home();
            telaHome.Show();

        }

        private void btn_ConfOngCad_Click(object sender, EventArgs e)
        {
            Ong ong = new Ong(
                0,
                txtNomeOng.Text,
                txtCnpjOng.Text,
                txtDescOng.Text,
                txtAreaOng.Text,
                txtEndOng.Text,
                txtNomeRespOng.Text,
                txtEmailOng.Text,
                txtSenhaOng.Text,
                txtConfirmSenhaOng.Text,
                txtLinkOng.Text
            );


            if(txtNomeOng.Text == "" || txtCnpjOng.Text == "" || txtDescOng.Text == "" || txtAreaOng.Text == "" || txtEndOng.Text == "" || txtNomeRespOng.Text == "" || txtEmailOng.Text == "" || txtSenhaOng.Text == "" || txtConfirmSenhaOng.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }


            ConfirmcadOng telaConfirmCadOng = new ConfirmcadOng();
            if (txtSenhaOng.Text != txtConfirmSenhaOng.Text)
            {
                MessageBox.Show("As senhas não coincidem. Tente novamente.");
                return;
            }
            else
            {
                telaConfirmCadOng.Show();
            }
           
        }

        
    }
}
