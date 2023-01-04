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
    public partial class EditarCurso : Form
    {
        public EditarCurso()
        {
            InitializeComponent();
        }

        private void txtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditarCurso_Load(object sender, EventArgs e)
        {
            gpB1.Visible =
                txtNome_Curso.Enabled=
                txtCarga_Horaria.Enabled = false;
        }

        public void Limpar()
        {
            txtId.Text =
            txtNome_Curso.Text =
                txtCarga_Horaria.Text = string.Empty;
            txtId.Enabled = true;
            gpB1.Visible = false;
            txtId.Focus();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //checando preenchimento do campo Id
            if (txtId.Text == "")
            {
                MessageBox.Show("Digite o Id do usuário!!");
                txtId.Focus();
                return;
            }

            //chamando metodos
            int codigo = Convert.ToInt32(txtId.Text);
            CursoDTO objPesquisa = new CursoDTO();//modelo
            CursoBLL objPesqBLL = new CursoBLL();//metodo
            objPesquisa = objPesqBLL.Seleciona(codigo);

            if (objPesquisa != null)
            {
                //habilitando componentes
                gpB1.Visible = true;
                txtId.Enabled = false;

                txtNome_Curso.Text = objPesquisa.Nome_Curso;
                txtCarga_Horaria.Text = objPesquisa.Carga_Horaria;
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
            txtNome_Curso.Enabled =
            txtCarga_Horaria.Enabled = true;
            txtNome_Curso.Focus();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            CursoDTO objPesquisa = new CursoDTO();//modelo
            CursoBLL objPesqBLL = new CursoBLL();//metodo
            objPesquisa.Cod_Curso = Convert.ToInt32(txtId.Text);
            objPesquisa.Nome_Curso = txtNome_Curso.Text;
            objPesquisa.Carga_Horaria = txtCarga_Horaria.Text;

            objPesqBLL.Editar(objPesquisa);
            MessageBox.Show("O aluno foi editado com sucesso!!");
            Limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Deseja mesmo excluir o Curso?", "ATENÇÃO!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //manipulando o valor escolhido no messagebox
            if (msg == DialogResult.Yes)
            {
                CursoBLL objExcluiBLL = new CursoBLL();//metodo
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
