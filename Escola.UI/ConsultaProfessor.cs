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
using System.IO;
using System.Reflection;
using System.Drawing.Printing;//impressão


namespace Escola.UI
{
    public partial class ConsultaProfessor : Form
    {
        public ConsultaProfessor()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            //botao editar
            ProfessorBLL objModelo = new ProfessorBLL();
            dgv1.DataSource = objModelo.Listar();

            // cabeçalho
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            dgv1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dgv1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void ConsultaProfessor_Load(object sender, EventArgs e)
        {
            dgv1.BackgroundColor = Color.WhiteSmoke;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
