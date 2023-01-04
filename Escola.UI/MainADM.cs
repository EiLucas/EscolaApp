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
    public partial class MainADM : Form
    {
        public MainADM()
        {
            InitializeComponent();
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarProfessor formnew = new CadastrarProfessor();
            formnew.ShowDialog();
        }


        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarAluno formnew = new CadastrarAluno ();
            formnew.ShowDialog();
        }

        private void diciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarDiciplina formnew = new CadastrarDiciplina();
            formnew.ShowDialog();
        }

        private void professorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditarProfessor formnew = new EditarProfessor ();
            formnew.ShowDialog();
        }

        private void alunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditarAluno formnew = new EditarAluno();
            formnew.ShowDialog();
        }

        private void diciplinaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditarDiciplina formnew = new EditarDiciplina();
            formnew.ShowDialog();
        }


        private void professorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultaProfessor formnew = new ConsultaProfessor();
            formnew.ShowDialog();
        }

        private void turmaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultaTurma formnew = new ConsultaTurma();
            formnew.ShowDialog();
        }

        private void alunoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultarAluno formnew = new ConsultarAluno();
            formnew.ShowDialog();
        }

        private void diciplinaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultarDisciplina formnew = new ConsultarDisciplina();
            formnew.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            CadastrarProfessor formnew = new CadastrarProfessor();
            formnew.ShowDialog();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            EditarProfessor formnew = new EditarProfessor();
            formnew.ShowDialog();
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            ConsultaProfessor formnew = new ConsultaProfessor();
            formnew.ShowDialog();
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CadastrarAluno formnew = new CadastrarAluno();
            formnew.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ConsultarAluno formnew = new ConsultarAluno();
            formnew.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            EditarDiciplina formnew = new EditarDiciplina();
            formnew.ShowDialog();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void turmaManhãToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastrarTurma_Manha formnew = new CadastrarTurma_Manha();
            formnew.ShowDialog();
        }

        private void turmaTardeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastrarTurma_Tarde formnew = new CadastrarTurma_Tarde();
            formnew.ShowDialog();
        }

        private void turmaNoiteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastrarTurma_Noite formnew = new CadastrarTurma_Noite();
            formnew.ShowDialog();
        }

        private void cursoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastrarCurso formnew = new CadastrarCurso();
            formnew.ShowDialog();
        }


        private void cursoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EditarCurso formnew = new EditarCurso();
            formnew.ShowDialog();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarCurso formnew = new ConsultarCurso();
            formnew.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            EditarAluno formnew = new EditarAluno();
            formnew.ShowDialog();
        }
    }
}
