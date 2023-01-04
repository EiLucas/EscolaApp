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
    public partial class ConsultaTurma : Form
    {
        public ConsultaTurma()
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
            TurmaBLL objModelo = new TurmaBLL();
            dgv1.DataSource = objModelo.Listar();

            // cabeçalho
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            dgv1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dgv1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void ConsultaTurma_Load(object sender, EventArgs e)
        {
            dgv1.BackgroundColor = Color.WhiteSmoke;
        }

        private void pnl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
