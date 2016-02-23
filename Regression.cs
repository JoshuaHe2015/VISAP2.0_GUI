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
    public partial class Regression : Form
    {
        public Regression()
        {
            InitializeComponent();
            Tabulation.RenewColsItems(MainForm.MainDT, comboBox_y);
        }

        private void button_Regression_Click(object sender, EventArgs e)
        {
            string ColNums = textBox_Cols.Text;
            char[] separator = { ',' };
            //string是以逗号分隔的
            string[] AllNum = ColNums.Split(separator);
            //按照逗号分割
            List<int> Cols = new List<int>();
            foreach (string SingleNum in AllNum)
            {
                if (SingleNum != "")
                {
                    Cols.Add(Convert.ToInt32(SingleNum) - 1);
                }
            }

            int[] AllColNums = Cols.ToArray();
            int yCol = Tabulation.FindCol(MainForm.MainDT,comboBox_y.Text);
            List<List<string>> data = new List<List<string>>();
            int RowsCount = MainForm.MainDT.Rows.Count;
            int  InputColsCount = AllColNums.Length;
            //计算总共要录入的列数
            int count = 0;
            //计算实际录入数据数
            List<string>Ydata = new List<string>();
            for (int i = 0; i < InputColsCount; i++)
            {
                data.Add(new List<string>());
            }
                for (int i = 0; i < RowsCount; i++)
                {
                    if (Tabulation.IdentifyNARow(MainForm.MainDT, i, AllColNums))
                    {
                        //确认该行无空格
                        if (MainForm.MainDT.Rows[i][yCol].ToString().Trim() != "")
                        {
                            Ydata.Add(MainForm.MainDT.Rows[i][yCol].ToString().Trim());
                            for (int j = 0; j < InputColsCount; j++)
                            {
                                data[j].Add(MainForm.MainDT.Rows[i][j].ToString());
                                
                            }
                            count++;
                        }
                    }
                }

            if (count > 2)
            {
                BigDecimal[,] IndependentVariables = new BigDecimal[count, InputColsCount + 1];
                //第一列全是1
                for (int i = 0; i < count; i++)
                {
                    IndependentVariables[i, 0] = 1;
                }
                for (int i = 0; i < count; i++)
                {
                    for (int j = 0; j < InputColsCount; j++)
                    {
                        //录入时，BigDecimal数组列数要+1，因为第一列全是1
                        IndependentVariables[i, j + 1] = data[j][i];
                    }
                }
                BigDecimal[,] DependentVariable = new BigDecimal[count,1];
                for (int i = 0; i < count; i++){
                    DependentVariable[i,0]= Ydata[i];
                }
                BigDecimal[,] bhat = Stat.MultiRegBeta(IndependentVariables, DependentVariable);
                StringBuilder Result = new StringBuilder();
                Result.Append(comboBox_y.Text);
                Result.Append(" = ");
                int ColumnNumberCount = 0;
                foreach (BigDecimal EachNum in bhat)
                {
                    if (ColumnNumberCount == 0)
                    {
                        Result.Append(MathV.NumberPolish(EachNum.ToString()));
                        Result.Append(" + ");
                    }
                    else if (ColumnNumberCount == InputColsCount)
                    {
                        Result.Append(MathV.NumberPolish(EachNum.ToString()));
                        Result.Append(" ");
                        Result.Append(MainForm.MainDT.Columns[AllColNums[ColumnNumberCount-1]].ColumnName);
                    }
                    else
                    {
                        Result.Append(MathV.NumberPolish(EachNum.ToString()));
                        Result.Append(" ");
                        Result.Append(MainForm.MainDT.Columns[AllColNums[ColumnNumberCount - 1]].ColumnName);
                        Result.Append(" + ");
                    }
                    ColumnNumberCount++;
                }
                MainForm.S.richTextBox1.AppendText(Result.ToString());
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
