using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace VISAP商科应用
{
    public partial class DirichletPosterior : Form
    {

        static double MaxValue = 0;
        //MaxValue是最大值，用于调整绘图时Y轴的高度
        public DirichletPosterior()
        {
            InitializeComponent();
            comboBox_Parameters.Items.AddRange(Multinomial.Classification);
        }

        private void button_predict_Click(object sender, EventArgs e)
        {
            //string[] ContentLines = Content.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            string[] ContentLines = textBox_successes.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            List<int> Numbers = new List<int>();
            int Temp = 0;
            int Len = 0;
            StringBuilder Information = new StringBuilder();
            Information.Append(StrManipulation.PadLeftX("组编号", ' ', 12));
            Information.Append("\t");
            Information.Append(StrManipulation.PadLeftX("预测概率值", ' ', 12));
            Information.Append("\r\n");
            int GroupTimes = 1;
            foreach (string EachLine in ContentLines)
            {
                Numbers.Clear();
                string[] Strs = EachLine.Split(',');
                foreach (string EachStr in Strs)
                {
                    if (Int32.TryParse(EachStr, out Temp))
                    {
                        Numbers.Add(Temp);
                    }
                }
                Len = Numbers.Count;
                if (Len != Multinomial.Classification.Length)
                {
                    MessageBox.Show("参数个数不正确！");
                }
                else
                {
                    Information.Append("第");
                    Information.Append(GroupTimes.ToString());
                    Information.Append("组");
                    GroupTimes++;
                    Information.Append("\t");
                    Information.Append(MathV.NumberPolish(Stat.DirichletPrediction(Numbers, Multinomial.Alphas)));
                    Information.Append("\r\n");
                }
            }
            MainForm.S.richTextBox1.AppendText(Information.ToString());
            MainForm.S.richTextBox1.Select();//让RichTextBox获得焦点
            MainForm.S.richTextBox1.Select(MainForm.S.richTextBox1.TextLength, 0);//将插入符号置于文本结束处 
            MainForm.S.richTextBox1.ScrollToCaret(); 
        }
        private void DrawBeta(int AlphaIndex, List<int> AlphaList, string Name, int[] CountTimes,int PriorOrPost = 0)
        {
            //PriorOrPost = 0为先验，即减去样本数
            //PriorOrPost = 1为后验
            int InterestAlpha = 0;
            if (PriorOrPost == 0)
            {
                InterestAlpha = AlphaList[AlphaIndex] - CountTimes[AlphaIndex];
            }
            else
            {
                InterestAlpha = AlphaList[AlphaIndex];
            }
            int OtherAlphas = 0;
            if (PriorOrPost == 0)
            {
                OtherAlphas = AlphaList.Sum() - CountTimes.Sum()-InterestAlpha;
            }
            else
            {
                OtherAlphas = AlphaList.Sum() - InterestAlpha;
            }
            if (chart_PosteriorDensity.Series.IndexOf(Name) != -1)
            {
                MessageBox.Show("图上已经存在相应分布，请勿重复添加！");
                return;
            }
            Series series = new Series(Name);
            series.BorderWidth = 3;
            series.ChartType = SeriesChartType.Spline;

            double Temp = 0;
            for (double i = 0.01; i < 1; i = i + 0.05)
            {
                Temp = Stat.BetaPDF(i, InterestAlpha, OtherAlphas);
                if (MaxValue < Temp)
                {
                    MaxValue = Temp;
                }

                series.Points.AddXY(i, Temp);
            }
            chart_PosteriorDensity.Series.Add(series);
            var XAxis = chart_PosteriorDensity.ChartAreas[0].AxisX;
            XAxis.MajorGrid.Enabled = false;
            var YAxis = chart_PosteriorDensity.ChartAreas[0].AxisY;
            YAxis.MajorGrid.Enabled = false;
            XAxis.Maximum = 1;
            XAxis.Minimum = 0;
            YAxis.Maximum = Math.Ceiling(MaxValue);
        }
        private void DrawBinomial(int n, int y, string Name)
        {
            if (chart_PosteriorDensity.Series.IndexOf(Name) != -1)
            {
                MessageBox.Show("图上已经存在相应分布，请勿重复添加！");
                return;
            }
            Series series = new Series(Name);
            series.BorderWidth = 3;
            series.ChartType = SeriesChartType.Spline;
            //double MaxValue = 0;
            double Temp = 0;
            for (double i = 0.01; i < 1; i = i + 0.05)
            {
                Temp = n * Stat.BinomialPDF(i, n, y);
                if (MaxValue < Temp)
                {
                    MaxValue = Temp;
                }

                series.Points.AddXY(i, Temp);
            }
            chart_PosteriorDensity.Series.Add(series);
            var XAxis = chart_PosteriorDensity.ChartAreas[0].AxisX;
            XAxis.MajorGrid.Enabled = false;
            var YAxis = chart_PosteriorDensity.ChartAreas[0].AxisY;
            YAxis.MajorGrid.Enabled = false;
            XAxis.Maximum = 1;
            XAxis.Minimum = 0;
            YAxis.Maximum = Math.Ceiling(MaxValue);
        }
        private void button_Add_Click(object sender, EventArgs e)
        {
            string Para = comboBox_Parameters.Text;
            int Index = Multinomial.Classification.ToList().IndexOf(Para);
            if (Index != -1)
            {
                //找到相应的参数
                string Density = comboBox_Density.Text;
                if (Density == "先验分布")
                {
                    DrawBeta(Index,Multinomial.Alphas,Multinomial.Classification[Index] + "-"+"先验分布",Multinomial.CountTimes,0);
                }
                else if (Density == "似然函数")
                {
                    DrawBinomial(Multinomial.CountTimes.Sum(), Multinomial.CountTimes[Index], Multinomial.Classification[Index] + "-" + "似然函数");
                }
                else if (Density == "后验分布")
                {
                    DrawBeta(Index, Multinomial.Alphas, Multinomial.Classification[Index] + "-" + "后验分布", Multinomial.CountTimes, 1);
                }
                else
                {
                    return;
                }
            }
        }

        private void 清空ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart_PosteriorDensity.Series.Clear();
            MaxValue = 0;
        }

        private void button_Percentile_Click(object sender, EventArgs e)
        {
            char[] separator = { ',' };
            string[] Percentiles = textBox_Percentiles.Text.Split(separator);
            double Temp = 0;
            StringBuilder Str = new StringBuilder();
            int len = Multinomial.Classification.Length;
            foreach (string EachPer in Percentiles)
            {
                if (double.TryParse(EachPer, out Temp))
                {
                    if (Temp > 0 && Temp < 1)
                    {
                        Str.Append(StrManipulation.PadLeftX(Temp.ToString() + "分位数:\r\n", ' ', 12));
                        for (int i = 0; i < len; i++)
                        {
                            Str.Append(StrManipulation.PadLeftX(Multinomial.Classification[i],' ',12));
                            Str.Append("\t");
                            Str.Append(StrManipulation.PadLeftX(MathV.NumberPolish(Stat.BetaUa(1 - Temp, Multinomial.Alphas[i], Multinomial.Alphas.Sum()-Multinomial.Alphas[i]).ToString()), ' ', 12));
                            Str.Append("\r\n");
                        }
                    }
                }
            }
            MainForm.S.richTextBox1.AppendText(Str.ToString());
            MainForm.S.richTextBox1.Select();//让RichTextBox获得焦点
            MainForm.S.richTextBox1.Select(MainForm.S.richTextBox1.TextLength, 0);//将插入符号置于文本结束处 
            MainForm.S.richTextBox1.ScrollToCaret(); 
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuickPlot.DuplicateGraph(chart_PosteriorDensity);
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuickPlot.SaveGraph(chart_PosteriorDensity);
        }
    }
}
