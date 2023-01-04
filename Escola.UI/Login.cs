using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Escola.BLL;
using Escola.DTO;

namespace Escola.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void Limpar()
        {
            txtEmail.Text =
                txtSenha.Text = String.Empty;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                //pegando informação digitada pelo usuario
                string objUser = txtEmail.Text;
                string objSenha = txtSenha.Text;

                //instanciando objeto DTO
                AlunosDTO objModelo = new AlunosDTO();
                AlunosBLL objValida = new AlunosBLL();
                objModelo = objValida.AutenticaAluno(objUser, objSenha);
                if (objModelo != null)
                {
                    switch (objModelo.DescricaoTipoUsuario)
                    {
                        case "1":
                            Session.nomealuno = txtEmail.Text.Trim();
                            MainADM obj = new MainADM();
                            obj.Show();
                            this.Visible = false;
                            break;
                        case "2":
                            Session.nomealuno = txtEmail.Text.Trim();
                            MainUser obj2 = new MainUser();
                            obj2.Show();
                            this.Visible = false;
                            break;

                    }

                }
                else
                {
                    MessageBox.Show("Deu Problema denovo!!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Usuário não existe!! " + ex.Message);
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
