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
    public partial class CadastrarAluno : Form
    {
        public CadastrarAluno()
        {
            InitializeComponent();
        }

        protected void Limpar()
        {
            txtNome.Text =
                txtSobrenome.Text =
                txtCPF.Text =
                txtSenha.Text = 
            txtEndereco.Text = 
            txtTelefone.Text = 
            txtEmail.Text = 
            txtRua.Text = 
            txtBairro.Text = string.Empty;
            rblADM.Checked = false;
            rblAluno.Checked = false;
            txtNome.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            AlunosDTO objCad = new AlunosDTO();

            objCad.Nome = txtNome.Text;
            objCad.Sobrenome = txtSobrenome.Text;
            objCad.CPF = txtCPF.Text;
            objCad.Senha = txtSenha.Text;
            objCad.Endereco = txtEndereco.Text;
            objCad.Telefone = txtTelefone.Text;
            objCad.Email = txtEmail.Text;
            objCad.Rua = txtRua.Text;
            objCad.Bairro = txtBairro.Text;           

            if (rblADM.Checked)
            {
                objCad.DescricaoTipoUsuario = "1";
            }
            else if (rblAluno.Checked)
            {
                objCad.DescricaoTipoUsuario = "2";
            }

            AlunosBLL objCadastra = new AlunosBLL();
            objCadastra.CadastrarAluno(objCad);
            Limpar();

            MessageBox.Show("Usuário " + objCad.Nome + " cadastrado com sucesso!!");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

      
    }
}
