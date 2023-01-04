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

namespace Escola.UI
{
    public partial class MainUser : Form
    {
        public MainUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Professor_Click(object sender, EventArgs e)
        {
            ConsultaProfessor formnew = new ConsultaProfessor();
            formnew.ShowDialog();

        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void ALUNO_Load(object sender, EventArgs e)
        {
            lblAluno.Text = "Seja bem vindo " + Session.nomealuno + " ao sistema Canopus!! início de sua seção: " + DateTime.Now.ToString();
        }

        private void Turma_Click(object sender, EventArgs e)
        {
            ConsultaTurma formnew = new ConsultaTurma();
            formnew.ShowDialog();
        }

        private void Diciplina_Click(object sender, EventArgs e)
        {
            ConsultarDisciplina formnew = new ConsultarDisciplina();
            formnew.ShowDialog();
        }
    }
}
