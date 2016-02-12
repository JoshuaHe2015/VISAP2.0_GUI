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
        public RichTextBox rtb = new RichTextBox();
        //建立一个RichTextBox，以便于绑定数据
        public int ReportIsOn = 0;
        //这个开关用于记录Report窗口是否被打开
        //************************************************
        //以下内容是为了数据的分页显示
        public static int pageSize = 1000;     //每页显示行数
        public static int nMax = 0;         //总记录数（最大记录数）
        public static int pageCount = 0;    //页数＝总记录数/每页显示行数
        public static int pageCurrent = 0;   //当前页号
        public static int nCurrent = 0;      //当前记录行
        public static DataTable MainDT = new DataTable();
        //以上内容是为了数据的分页显示
        //************************************************
        public MainForm()
        {
            InitializeComponent();
            S = this;
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainDT.Clear();
            //dataGridView1.DataSource = null;
            MainDT = Tabulation.NewTable(50, 15);
            Tabulation.InitDataSet(MainDT, ref nMax, ref pageCount, ref pageCurrent,
                    ref nCurrent, label_CurrentPage, label_TotalPage,
                    dataGridView1, textBox_CurrentPage, pageSize);
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
                MainDT = dt;
                Tabulation.InitDataSet(MainDT, ref nMax, ref pageCount, ref pageCurrent, 
                    ref nCurrent, label_CurrentPage, label_TotalPage,
                    dataGridView1, textBox_CurrentPage,pageSize);
                //Tabulation.DataType(dataGridView1);
            }
            
        }

        private void excelxlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tabulation.ExportExcel(MainDT);
        }

        private void csvcsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tabulation.ExportCSV(MainDT);
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainDT.Clear();
            dataGridView1.DataSource = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            //label_Row.Text = (rowIndex + 1).ToString();
            label_CurrentPageRow.Text = (rowIndex + 1).ToString();
            label_Row.Text = ((Convert.ToInt32(label_CurrentPage.Text)-1) * pageSize + (rowIndex + 1)).ToString();
            int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
            label_Column.Text = (columnIndex + 1).ToString();
        }

        private void 汇总ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Summary SummaryForm = new Summary();
            SummaryForm.Show();
        }

        private void 简单图表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EasyGraph GraphForm = new EasyGraph();
            GraphForm.Show();
        }

        private void 检测变量类型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tabulation.DataType(dataGridView1);
        }

        private void 批量导入csvToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 批量导入csvToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            dt = Tabulation.BulkImportCSV(); ;
            if (dt != null)
            {
                //dataGridView1.DataSource = dt;
                MainDT = dt;
                Tabulation.InitDataSet(MainDT, ref nMax, ref pageCount, ref pageCurrent,
                    ref nCurrent, label_CurrentPage, label_TotalPage,
                    dataGridView1, textBox_CurrentPage, pageSize);
                //Tabulation.DataType(dataGridView1);
            }
            //Tabulation.DataType(dataGridView1);
        }

        private void 缺失值处理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NAOperation NAOperForm = new NAOperation();
            NAOperForm.Show();
        }

        private void 参数估计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParameterEstimation ParaForm = new ParameterEstimation();
            ParaForm.Show();
        }

        private void 报告ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report ReportForm = new Report();
            ReportForm.Show();
        }

        private void button_PreviousPage_Click(object sender, EventArgs e)
        {
            
            if (pageCurrent - 1 <= 0)
            {
                MessageBox.Show("已经是第一页，请点击“下页”查看！");
                return;
            }
            else
            {
                pageCurrent--;
                nCurrent = pageSize * (pageCurrent - 1);
            }

            Tabulation.LoadData(MainDT, ref pageCurrent, ref pageCount, ref nMax,
              ref pageSize, ref nCurrent, textBox_CurrentPage,
               label_CurrentPage, label_TotalPage, dataGridView1);
        }

        private void button_NextPage_Click(object sender, EventArgs e)
        {
          
                if (pageCurrent + 1 > pageCount)
                {
                    MessageBox.Show("已经是最后一页，请点击“上页”查看！");
                    return;
                }
                else
                {
                       pageCurrent++;
                    nCurrent = pageSize * (pageCurrent - 1);
                }
              Tabulation.LoadData(MainDT, ref pageCurrent, ref pageCount, ref nMax,
              ref pageSize, ref nCurrent, textBox_CurrentPage,
               label_CurrentPage, label_TotalPage, dataGridView1);
            }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int Rows = e.RowIndex;
            int Columns = e.ColumnIndex;
            MainDT.Rows[20 * (pageCurrent - 1) + Rows][Columns] = dataGridView1.Rows[Rows].Cells[Columns].Value;
        }

        private void button_FirstPage_Click(object sender, EventArgs e)
        {
            pageCurrent = 1;
            nCurrent = pageSize * (pageCurrent - 1);
            Tabulation.LoadData(MainDT, ref pageCurrent, ref pageCount, ref nMax,
              ref pageSize, ref nCurrent, textBox_CurrentPage,
               label_CurrentPage, label_TotalPage, dataGridView1);
        }

        private void button_LastPage_Click(object sender, EventArgs e)
        {
            pageCurrent = pageCount;
            nCurrent = pageSize * (pageCurrent - 1);
            Tabulation.LoadData(MainDT, ref pageCurrent, ref pageCount, ref nMax,
              ref pageSize, ref nCurrent, textBox_CurrentPage,
               label_CurrentPage, label_TotalPage, dataGridView1);
        }

        private void button_Skip_Click(object sender, EventArgs e)
        {
            int SkipPage = Convert.ToInt32(textBox_CurrentPage.Text);
            if (SkipPage > 0 && SkipPage <= pageCount){
                pageCurrent = SkipPage;
            nCurrent = pageSize * (pageCurrent - 1);
            Tabulation.LoadData(MainDT, ref pageCurrent, ref pageCount, ref nMax,
              ref pageSize, ref nCurrent, textBox_CurrentPage,
               label_CurrentPage, label_TotalPage, dataGridView1);
            }
        }

        private void 所有内容ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //将所有内容转置
            MainDT = Tabulation.Transposition(MainDT, MainDT,true);
            Tabulation.InitDataSet(MainDT, ref nMax, ref pageCount, ref pageCurrent,
                     ref nCurrent, label_CurrentPage, label_TotalPage,
                     dataGridView1, textBox_CurrentPage, pageSize);
        }

        private void 选中行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //将选中行转置
            MainDT = Tabulation.Transposition(Tabulation.GetChosenTable(MainDT,dataGridView1), MainDT);
            Tabulation.InitDataSet(MainDT, ref nMax, ref pageCount, ref pageCurrent,
                     ref nCurrent, label_CurrentPage, label_TotalPage,
                     dataGridView1, textBox_CurrentPage, pageSize);
        }
        }
    }


