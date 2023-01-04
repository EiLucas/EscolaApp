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
    public partial class CadastrarCurso : Form
    {
        public CadastrarCurso()
        {
            InitializeComponent();
        }
        protected void Limpar()
        {
            txtNome_Curso.Text =
                txtCarga_Horaria.Text = String.Empty;
            txtNome_Curso.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CursoDTO objCad = new CursoDTO();

            objCad.Nome_Curso = txtNome_Curso.Text;
            objCad.Carga_Horaria = txtCarga_Horaria.Text;

            CursoBLL objCadastra = new CursoBLL();
            objCadastra.Cadastrar(objCad);
            Limpar();

            MessageBox.Show("Curso " + objCad.Nome_Curso + " cadastrado com sucesso!!");
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
