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
        public static void QuickSummary(int ColNum){
            string[] Numbers =  Tabulation.ReadVector(MainForm.S.dataGridView1,ColNum).ToArray();
            string ColName = MainForm.S.dataGridView1.Columns[ColNum].Name;
            BigNumber sum = 0;
            BigNumber mean = 0;
            BigNumber Variance = 0;
            BigNumber count = 0;
            BigNumber max = 0;
            BigNumber min = 0;
            BigNumber sum2 = 0;
            //sum2用于计算数字的平方，方便计算方差
            foreach (string Num in Numbers)
            {
                if (Num.Trim() != "")
                {
                    if (Num.Contains("E"))
                    {
                        //检查是否为科学记数法
                        sum += Convert.ToDouble(Num);
                        sum2 += (BigNumber)Convert.ToDouble(Num) * (BigNumber)Convert.ToDouble(Num);
                        count++;
                        if (count == 1)
                        {
                            max = Num;
                            min = Num;
                        }
                        else
                        {
                            if (max < Num)
                            {
                                max = Num;
                            }
                            if (min > Num){
                                min = Num;
                            }
                        }
                    }
                    else
                    {
                        sum += Num;
                        sum2 += (BigNumber)Num * (BigNumber)Num;
                        count++;
                        if (count == 1)
                        {
                            max = Num;
                            min = Num;
                        }
                        else
                        {
                            if (max < Num)
                            {
                                max = Num;
                            }
                            if (min > Num)
                            {
                                min = Num;
                            }
                        }
                    }
                    
                   
                }
            }
            if (count == 0)
            {
                //如果没有获取任何数字
                return;
            }
            else if (count == 1)
            {
                //如果只有一个数字，可以计算均值，但是不可以计算标准差
                mean = sum / count;
                MainForm.S.richTextBox1.AppendText(StrManipulation.PadLeftX(ColName, ' ', 12) + "\t"
                    + StrManipulation.PadLeftX(count.ToString(), ' ', 12) + "\t"
                    + StrManipulation.PadLeftX(MathV.NumberPolish(mean.ToString()), ' ', 12) + "\t"
                    + StrManipulation.PadLeftX("NA", ' ', 12) + "\t"
                    + StrManipulation.PadLeftX(MathV.NumberPolish(min.ToString()), ' ', 12) + "\t"
                    + StrManipulation.PadLeftX(MathV.NumberPolish(max.ToString()), ' ', 12) + "\r\n");
            }
            else
            {
                //开始计算均值和方差
                //方差要乘以调整系数
                mean = sum / count;
                Variance = (sum2 / count - mean * mean) * count / (count - 1);
                if (Variance > 0) { 
                MainForm.S.richTextBox1.AppendText(StrManipulation.PadLeftX(ColName, ' ', 12) + "\t"
                    + StrManipulation.PadLeftX(count.ToString(), ' ', 12) + "\t"
                    + StrManipulation.PadLeftX(MathV.NumberPolish(mean.ToString()), ' ', 12) + "\t"
                    + StrManipulation.PadLeftX(MathV.NumberPolish(MathV.Sqrt(Variance).ToString()), ' ', 12) + "\t"
                    + StrManipulation.PadLeftX(MathV.NumberPolish(min.ToString()), ' ', 12) + "\t"
                    + StrManipulation.PadLeftX(MathV.NumberPolish(max.ToString()), ' ', 12) + "\r\n");
                    }
                else
                {
                    MainForm.S.richTextBox1.AppendText(StrManipulation.PadLeftX(ColName, ' ', 12) + "\t"
                    + StrManipulation.PadLeftX(count.ToString(), ' ', 12) + "\t"
                    + StrManipulation.PadLeftX(MathV.NumberPolish(mean.ToString()), ' ', 12) + "\t"
                    + StrManipulation.PadLeftX("0", ' ', 12) + "\t"
                    + StrManipulation.PadLeftX(MathV.NumberPolish(min.ToString()), ' ', 12) + "\t"
                    + StrManipulation.PadLeftX(MathV.NumberPolish(max.ToString()), ' ', 12) + "\r\n");
                }
            }
        }
        private void button_summary_Click(object sender, EventArgs e)
        {
            string ColNums = textBox_Cols.Text;
            char[] separator = { ',' };
            //string是以逗号分隔的
            string[] AllNum = ColNums.Split(separator);
            //按照逗号分割
            MainForm.S.richTextBox1.AppendText(StrManipulation.PadLeftX("变量名",' ',12)
                + "\t" + StrManipulation.PadLeftX("样本数", ' ', 12)+"\t"+
                StrManipulation.PadLeftX("均值", ' ', 12)+"\t"+
                StrManipulation.PadLeftX("标准差", ' ', 12)+"\t"+
                StrManipulation.PadLeftX("最小值", ' ', 12)+"\t"+
                StrManipulation.PadLeftX("最大值", ' ', 12)+"\r\n");
            foreach (string SingleNum in AllNum)
            {
                if (SingleNum != "")
                {
                    QuickSummary(Convert.ToInt32(SingleNum) - 1);
                }
            }
            MainForm.S.richTextBox1.AppendText("\r\n");
            MainForm.S.richTextBox1.Select();//让RichTextBox获得焦点
            MainForm.S.richTextBox1.Select(MainForm.S.richTextBox1.TextLength,0);//将插入符号置于文本结束处 
            MainForm.S.richTextBox1.ScrollToCaret(); 
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
