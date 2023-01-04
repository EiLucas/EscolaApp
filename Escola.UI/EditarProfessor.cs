using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Escola.DTO;
using Escola.BLL;

namespace Escola.UI
{
    public partial class EditarProfessor : Form
    {
        private DialogResult msg;

        public EditarProfessor()
        {
            InitializeComponent();
        }

        private void EditarProfessor_Load(object sender, EventArgs e)
        {
            gpB1.Visible =
               txtNome_Professor.Enabled =
               txtCod_Disciplina.Enabled = false;
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Limpar()
        {
            txtId.Text =
            txtNome_Professor.Text =
                txtCod_Disciplina.Text = string.Empty;
            txtId.Enabled = true;
            gpB1.Visible = false;
            txtId.Focus();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtId.Text);
            ProfessorDTO objPesquisa = new ProfessorDTO();//modelo
            ProfessorBLL objPesqBLL = new ProfessorBLL();//metodo
            objPesquisa = objPesqBLL.Selecionar(codigo);

            if (objPesquisa != null)
            {
                //habilitando componentes
                gpB1.Visible = true;
                txtId.Enabled = false;

                txtNome_Professor.Text = objPesquisa.Nome_Professor;
                txtCod_Disciplina.Text = objPesquisa.Disciplina;
            }
            else
            {
                MessageBox.Show("Não rolou a busca!! ");
                Limpar();
                return;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            //habilitando componentes
            btnConfirmar.Visible = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            gpB1.Visible = true;
            txtNome_Professor.Enabled =
            txtCod_Disciplina.Enabled = true;
            txtNome_Professor.Focus();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ProfessorDTO objPesquisa = new ProfessorDTO();//modelo
            ProfessorBLL objPesqBLL = new ProfessorBLL();//metodo
            objPesquisa.Id_Professor = Convert.ToInt32(txtId.Text);
            objPesquisa.Nome_Professor = txtNome_Professor.Text;
            objPesquisa.Disciplina = txtCod_Disciplina.Text;

            objPesqBLL.Editar(objPesquisa);
            MessageBox.Show("O aluno foi editado com sucesso!!");
            Limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //manipulando o valor escolhido no messagebox
            if (msg == DialogResult.Yes)
            {
                ProfessorBLL objExcluiBLL = new ProfessorBLL();//metodo
                int codigo = Convert.ToInt32(txtId.Text);
                objExcluiBLL.Excluir(codigo);
                Limpar();
            }
            else if (msg == DialogResult.No)
            {
                Limpar();
            }
        }
    }
}
