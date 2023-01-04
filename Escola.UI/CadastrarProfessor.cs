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
    public partial class CadastrarProfessor : Form
    {
        public CadastrarProfessor()
        {
            InitializeComponent();
        }

        protected void Limpar()
        {
            txtProfessor.Text =
                txtDisciplina.Text = String.Empty;
            txtProfessor.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProfessorDTO objCad = new ProfessorDTO();

            objCad.Nome_Professor = txtProfessor.Text;
            objCad.Disciplina = txtDisciplina.Text;                     

            ProfessorBLL objCadastra = new ProfessorBLL();
            objCadastra.Cadastrar(objCad);
            Limpar();

            MessageBox.Show("Usuário " + objCad.Nome_Professor + " cadastrado com sucesso!!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtProfessor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
