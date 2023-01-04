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
    public partial class ConsultarAluno : Form
    {
        

        public ConsultarAluno()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            //botao editar
            AlunosBLL objModelo = new AlunosBLL();
            dgv1.DataSource = objModelo.ListarAluno();

            // cabeçalho
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            dgv1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dgv1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void ConsultarAluno_Load(object sender, EventArgs e)
        {
            dgv1.BackgroundColor = Color.WhiteSmoke;
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
