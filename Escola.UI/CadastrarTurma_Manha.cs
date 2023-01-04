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
    public partial class CadastrarTurma_Manha : Form
    {
        public CadastrarTurma_Manha()
        {
            InitializeComponent();
        }
        protected void Limpar()
        {
            txtAluno.Text =
                txtCod_Aluno.Text = String.Empty;
            txtAluno.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TurmaManhaDTO objCad = new TurmaManhaDTO();

            objCad.Nome_Aluno = txtAluno.Text;
            objCad.Cod_Aluno = txtCod_Aluno.Text;

            TurmaManhaBLL objCadastra = new TurmaManhaBLL();
            objCadastra.Cadastrar(objCad);
            Limpar();

            MessageBox.Show("Turma da Manhã " + objCad.Nome_Aluno + " cadastrado com sucesso!!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
