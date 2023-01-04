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
    public partial class CadastrarDiciplina : Form
    {
        public CadastrarDiciplina()
        {
            InitializeComponent();
        }

        protected void Limpar()
        {
            txtDisciplina.Text =
                txtHorario_Disciplina.Text = String.Empty;
            txtDisciplina.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            DisciplinaDTO objCad = new DisciplinaDTO();

            objCad.Nome_Disciplina = txtDisciplina.Text;
            objCad.Horario_inicio = txtHorario_Disciplina.Text;
            objCad.Horario_Termino = txtHorario_Termino.Text;
            objCad.DescricaoPeriodo = txtCod_Periodo.Text;

            DisciplinaBLL objCadastra = new DisciplinaBLL();
            objCadastra.Cadastrar(objCad);
            Limpar();

            MessageBox.Show("Disciplina" + objCad.Nome_Disciplina + " cadastrada com sucesso!!");
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
