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
    public partial class CadastrarTurma_Tarde : Form
    {
        public CadastrarTurma_Tarde()
        {
            InitializeComponent();
        }

        protected void Limpar()
        {
            txtAluno.Text =
                txtCod_Aluno.Text = String.Empty;
            txtAluno.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TurmaTardeDTO objCad = new TurmaTardeDTO();

            objCad.Nome_Aluno = txtAluno.Text;
            objCad.Cod_Aluno = txtCod_Aluno.Text;

            TurmaTardeBLL objCadastra = new TurmaTardeBLL();
            objCadastra.Cadastrar(objCad);
            Limpar();

            MessageBox.Show("Turma da Tarde " + objCad.Nome_Aluno + " cadastrado com sucesso!!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
