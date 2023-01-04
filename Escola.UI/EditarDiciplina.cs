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
    public partial class EditarDiciplina : Form
    {
        private DialogResult msg;

        public EditarDiciplina()
        {
            InitializeComponent();
        }

        private void EditarDiciplina_Load(object sender, EventArgs e)
        {
            gpB1.Visible =
              txtNome_Disciplina.Enabled =
              txtHorario_Disciplina.Enabled = false;
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Limpar()
        {
            txtId.Text =
            txtNome_Disciplina.Text =
                txtHorario_Disciplina.Text = string.Empty;
            txtId.Enabled = true;
            gpB1.Visible = false;
            txtId.Focus();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtId.Text);
            DisciplinaDTO objPesquisa = new DisciplinaDTO();//modelo
            DisciplinaBLL objPesqBLL = new DisciplinaBLL();//metodo
            objPesquisa = objPesqBLL.Seleciona(codigo);

            if (objPesquisa != null)
            {
                //habilitando componentes
                gpB1.Visible = true;
                txtId.Enabled = false;

                txtNome_Disciplina.Text = objPesquisa.Nome_Disciplina;
                txtHorario_Disciplina.Text = objPesquisa.Horario_inicio;
                txtHorario_Termino.Text = objPesquisa.Horario_Termino;
                txtCod_Periodo.Text = objPesquisa.DescricaoPeriodo;

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
            txtNome_Disciplina.Enabled =
            txtHorario_Disciplina.Enabled = true;
            txtNome_Disciplina.Focus();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DisciplinaDTO objPesquisa = new DisciplinaDTO();//modelo
            DisciplinaBLL objPesqBLL = new DisciplinaBLL();//metodo
            objPesquisa.Cod_Disciplina = Convert.ToInt32(txtId.Text);
            objPesquisa.Nome_Disciplina = txtNome_Disciplina.Text;
            objPesquisa.Horario_inicio = txtHorario_Disciplina.Text;
            objPesquisa.Horario_Termino = txtHorario_Termino.Text;
            objPesquisa.DescricaoPeriodo = txtCod_Periodo.Text;

            objPesqBLL.Editar(objPesquisa);
            MessageBox.Show("O disciplina foi editado com sucesso!!");
            Limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //manipulando o valor escolhido no messagebox
            if (msg == DialogResult.Yes)
            {
                DisciplinaBLL objExcluiBLL = new DisciplinaBLL();//metodo
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
