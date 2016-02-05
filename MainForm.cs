using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISAP商科应用
{
    public partial class MainForm : Form
    {
        public static MainForm S = null;
        public MainForm()
        {
            InitializeComponent();
            S = this;
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Tabulation.NewTable(50, 15);
        }

        private void 导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectExcel SelectForm = new SelectExcel();
            SelectForm.ShowDialog();
        }

        private void csv文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Tabulation.ImportCSV();
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
            
        }

        private void excelxlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tabulation.ExportExcel(dataGridView1);
        }

        private void csvcsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tabulation.ExportCSV(dataGridView1.DataSource as DataTable);
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            label_Row.Text = (rowIndex + 1).ToString();
            int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
            label_Column.Text = (columnIndex + 1).ToString();
        }

        private void 汇总ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Summary SummaryForm = new Summary();
            SummaryForm.Show();
        }
    }
}
