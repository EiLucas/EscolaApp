using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola.DTO;
using Escola.BLL;
using System.Windows.Forms;


namespace Escola.UI
{
    public partial class EditarAluno : Form
    {
        public EditarAluno()
        {
            InitializeComponent();
        }

        private void EditarAluno_Load(object sender, EventArgs e)
        {
            gpB1.Visible =
                txtNome.Enabled =
                txtSobrenome.Enabled=
                txtCpf.Enabled =
                txtSenha.Enabled =
                txtEmail.Enabled=
                txtTelefone.Enabled=
                txtEndereco.Enabled=
                txtRua.Enabled=
                txtBairro.Enabled=
                txtTipoUsuario.Enabled= false;
               
        }
        public void Limpar()
        {
            txtId.Text=
            txtNome.Text =
            txtSobrenome.Text=
                txtCpf.Text =
                txtSenha.Text =
                txtEmail.Text=
                txtTelefone.Text=
                txtEndereco.Text=
                txtRua.Text=
                txtBairro.Text=
                txtTipoUsuario.Text= string.Empty;
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
            AlunosDTO objPesquisa = new AlunosDTO();//modelo
            AlunosBLL objPesqBLL = new AlunosBLL();//metodo
            objPesquisa = objPesqBLL.SelecionaAluno(codigo);

            if (objPesquisa != null)
            {
                //habilitando componentes
                gpB1.Visible = true;
                txtId.Enabled = false;

                txtNome.Text = objPesquisa.Nome;
                txtSobrenome.Text = objPesquisa.Sobrenome;
                txtCpf.Text = objPesquisa.CPF;
                txtSenha.Text = objPesquisa.Senha;
                txtEndereco.Text = objPesquisa.Endereco;
                txtTelefone.Text = objPesquisa.Telefone;
                txtEmail.Text = objPesquisa.Email;                              
                txtRua.Text = objPesquisa.Rua;
                txtBairro.Text = objPesquisa.Bairro;
                txtTipoUsuario.Text = objPesquisa.DescricaoTipoUsuario;
                rbl1.Enabled = false;
                rbl2.Enabled = false;
            }
            else
            {
                MessageBox.Show("Não rolou a busca!! ");
                Limpar();
                return;
            }
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            {
                //habilitando componentes
                btnConfirmar.Visible = true;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                gpB1.Visible = true; 
                    rbl1.Enabled = 
                    rbl2.Enabled = 
                    txtNome.Enabled =
                    txtSobrenome.Enabled =
                    txtCpf.Enabled =
                    txtSenha.Enabled =
                    txtEmail.Enabled=
                    txtTelefone.Enabled=
                    txtEndereco.Enabled=
                    txtRua.Enabled =
                    txtBairro.Enabled=
                    txtTipoUsuario.Enabled= true;
                txtNome.Focus();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            AlunosDTO objPesquisa = new AlunosDTO();//modelo
            AlunosBLL objPesqBLL = new AlunosBLL();//metodo
            objPesquisa.Cod_Aluno = Convert.ToInt32(txtId.Text);
            objPesquisa.Nome= txtNome.Text;
            objPesquisa.Sobrenome= txtSobrenome.Text;
            objPesquisa.CPF = txtCpf.Text;
            objPesquisa.Senha = txtSenha.Text;
            objPesquisa.Endereco = txtEndereco.Text;
            objPesquisa.Telefone = txtTelefone.Text;
            objPesquisa.Email= txtEmail.Text;            
            objPesquisa.Rua = txtRua.Text;
            objPesquisa.Bairro = txtBairro.Text;

            //alertando radio buttons não selecionado
            if ((!rbl1.Checked) && (!rbl2.Checked))
            {
                gpB1.BackColor = Color.Azure;
                MessageBox.Show("Escolha uma opção!!");
                return;
            }

            //atribuindo valor radio buttons
            if (rbl1.Checked)
            {
                objPesquisa.DescricaoTipoUsuario = "1";
            }
            else if (rbl2.Checked)
            {
                objPesquisa.DescricaoTipoUsuario = "2";
            }
            gpB1.BackColor = DefaultBackColor;


            objPesqBLL.EditarAluno(objPesquisa);
            MessageBox.Show("O aluno foi editado com sucesso!!");
            Limpar();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Deseja mesmo excluir o Aluno?", "ATENÇÃO!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //manipulando o valor escolhido no messagebox
            if (msg == DialogResult.Yes)
            {
                AlunosBLL objExcluiBLL = new AlunosBLL();//metodo
                int codigo = Convert.ToInt32(txtId.Text);
                objExcluiBLL.ExcluirAluno(codigo);
                MessageBox.Show("Usuário excluído com sucesso!!");

                Limpar();


            }
            else if (msg == DialogResult.No)
            {
                Limpar();
            }
        }

    }
}
