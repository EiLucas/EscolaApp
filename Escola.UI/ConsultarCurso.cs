using Escola.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola.UI
{
    public partial class ConsultarCurso : Form
    {
        public ConsultarCurso()
        {
            InitializeComponent();
        }

        private void ConsultarCurso_Load(object sender, EventArgs e)
        {
            dgv1.BackgroundColor = Color.WhiteSmoke;
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            CursoBLL objModelo = new CursoBLL();
            dgv1.DataSource = objModelo.Listar();

            // cabeçalho
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            dgv1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dgv1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
