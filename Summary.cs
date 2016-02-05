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
    public partial class Summary : Form
    {
        public Summary()
        {
            InitializeComponent();
            if (MainForm.S.dataGridView1.DataSource != null)
            {
                textBox_Cols.Text = Tabulation.GetGridCols(MainForm.S.dataGridView1);
            }
        }
        public void QuickSummary(int ColNum){
            string[] Numbers =  Tabulation.ReadVector(MainForm.S.dataGridView1,ColNum).ToArray();

        }
        private void button_summary_Click(object sender, EventArgs e)
        {
            string ColNums = textBox_Cols.Text;
            char[] separator = { ',' };
            //string是以逗号分隔的
            string[] AllNum = ColNums.Split(separator);
            //按照逗号分割
            MainForm.S.richTextBox1.AppendText("");
            //string result = "变量名".PadLeft(9, ' ') + "\t" 
            //+ "样本数".PadLeft(9, ' ') + "\t" 
            //+ "均值".PadLeft(10, ' ') + "\t" 
            //+ "标准差".PadLeft(9, ' ') + "\t" 
            //+ "最小值".PadLeft(9, ' ') + "\t" + "最大值".PadLeft(9, ' ') + "\r\n";
            
            foreach (string SingleNum in AllNum)
            {
                if (SingleNum != "")
                {
                    QuickSummary(Convert.ToInt32(SingleNum) - 1);
                }
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            if (MainForm.S.dataGridView1.DataSource != null)
            {
                textBox_Cols.Text = Tabulation.GetGridCols(MainForm.S.dataGridView1);
            }
        }

        private void textBox_Cols_TextChanged(object sender, EventArgs e)
        {
            textBox_VarNames.Text = Tabulation.GetColsName(MainForm.S.dataGridView1, textBox_Cols.Text);
        }
    }
}
