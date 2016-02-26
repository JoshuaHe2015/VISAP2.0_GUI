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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            string[] Items = Tabulation.RenewColsItems(MainForm.MainDT);
            comboBox_Output.Items.AddRange(Items);
            listBox_Vars.Items.AddRange(Items);
        }

        private void button_Cal_Click(object sender, EventArgs e)
        {
            List<int> BlackList = new List<int>();
            double [] ans = (double [])MathV.CalExpression(textBox_expression.Text.Replace("\r\n",""), MainForm.MainDT, ref BlackList);
            int ColNum = 0;
            if (checkBox_NewCol.Checked == true)
            {
                MainForm.MainDT.Columns.Add();
                ColNum = MainForm.MainDT.Columns.Count - 1;
            }
            else
            {
                ColNum = Tabulation.FindCol(MainForm.MainDT, comboBox_Output.Text);
            }
            if (ColNum == -1)
            {
                return;
            }
            int RealData = 0;
            int RowsCount = MainForm.MainDT.Rows.Count;
            for (int i = 0; i < RowsCount;i++){
                if (BlackList.IndexOf(i) == -1)
                {
                    MainForm.MainDT.Rows[i][ColNum] = ans[RealData].ToString();
                    RealData++;
                }
            }
            Tabulation.InitDataSet(MainForm.MainDT, ref MainForm.nMax, ref MainForm.pageCount, ref MainForm.pageCurrent,
                    ref MainForm.nCurrent, MainForm.S.label_CurrentPage, MainForm.S.label_TotalPage,
                    MainForm.S.dataGridView1, MainForm.S.textBox_CurrentPage, MainForm.pageSize);
        }

        private void button_AddVariable_Click(object sender, EventArgs e)
        {
            int ListIndex = listBox_Vars.SelectedIndex + 1;
            int start = textBox_expression.SelectionStart;
            string AddText = "x" + ListIndex.ToString();
            textBox_expression.Text = textBox_expression.Text.Insert(start, AddText);
            textBox_expression.Focus();
            textBox_expression.SelectionStart = start + AddText.Length;
            textBox_expression.SelectionLength = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int start = textBox_expression.SelectionStart;
            textBox_expression.Text = textBox_expression.Text.Insert(start, "1");
            textBox_expression.Focus();
            textBox_expression.SelectionStart = start + 1;
            textBox_expression.SelectionLength = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int start = textBox_expression.SelectionStart;
            textBox_expression.Text = textBox_expression.Text.Insert(start, "2");
            textBox_expression.Focus();
            textBox_expression.SelectionStart = start + 1;
            textBox_expression.SelectionLength = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int start = textBox_expression.SelectionStart;
            textBox_expression.Text = textBox_expression.Text.Insert(start, "3");
            textBox_expression.Focus();
            textBox_expression.SelectionStart = start + 1;
            textBox_expression.SelectionLength = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int start = textBox_expression.SelectionStart;
            textBox_expression.Text = textBox_expression.Text.Insert(start, "4");
            textBox_expression.Focus();
            textBox_expression.SelectionStart = start + 1;
            textBox_expression.SelectionLength = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int start = textBox_expression.SelectionStart;
            textBox_expression.Text = textBox_expression.Text.Insert(start, "5");
            textBox_expression.Focus();
            textBox_expression.SelectionStart = start + 1;
            textBox_expression.SelectionLength = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int start = textBox_expression.SelectionStart;
            textBox_expression.Text = textBox_expression.Text.Insert(start, "6");
            textBox_expression.Focus();
            textBox_expression.SelectionStart = start + 1;
            textBox_expression.SelectionLength = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int start = textBox_expression.SelectionStart;
            textBox_expression.Text = textBox_expression.Text.Insert(start, "7");
            textBox_expression.Focus();
            textBox_expression.SelectionStart = start + 1;
            textBox_expression.SelectionLength = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int start = textBox_expression.SelectionStart;
            textBox_expression.Text = textBox_expression.Text.Insert(start, "8");
            textBox_expression.Focus();
            textBox_expression.SelectionStart = start + 1;
            textBox_expression.SelectionLength = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int start = textBox_expression.SelectionStart;
            textBox_expression.Text = textBox_expression.Text.Insert(start, "9");
            textBox_expression.Focus();
            textBox_expression.SelectionStart = start + 1;
            textBox_expression.SelectionLength = 0;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            int start = textBox_expression.SelectionStart;
            textBox_expression.Text = textBox_expression.Text.Insert(start, "0");
            textBox_expression.Focus();
            textBox_expression.SelectionStart = start + 1;
            textBox_expression.SelectionLength = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int start = textBox_expression.SelectionStart;
            textBox_expression.Text = textBox_expression.Text.Insert(start, ".");
            textBox_expression.Focus();
            textBox_expression.SelectionStart = start + 1;
            textBox_expression.SelectionLength = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox_expression.Clear();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            int start = textBox_expression.SelectionStart;
            textBox_expression.Text = textBox_expression.Text.Insert(start, "+");
            textBox_expression.Focus();
            textBox_expression.SelectionStart = start + 1;
            textBox_expression.SelectionLength = 0;
        }

        private void button_Minus_Click(object sender, EventArgs e)
        {
            int start = textBox_expression.SelectionStart;
            textBox_expression.Text = textBox_expression.Text.Insert(start, "-");
            textBox_expression.Focus();
            textBox_expression.SelectionStart = start + 1;
            textBox_expression.SelectionLength = 0;
        }

        private void button_Multiply_Click(object sender, EventArgs e)
        {
            int start = textBox_expression.SelectionStart;
            textBox_expression.Text = textBox_expression.Text.Insert(start, "*");
            textBox_expression.Focus();
            textBox_expression.SelectionStart = start + 1;
            textBox_expression.SelectionLength = 0;
        }

        private void button_Divide_Click(object sender, EventArgs e)
        {
            int start = textBox_expression.SelectionStart;
            textBox_expression.Text = textBox_expression.Text.Insert(start, "/");
            textBox_expression.Focus();
            textBox_expression.SelectionStart = start +1;
            textBox_expression.SelectionLength = 0;
        }

        private void button_AddFun_Click(object sender, EventArgs e)
        {
            string FunName = comboBox_Functions.Text;
            string FunFormat = "";
            int Adjust = 0;
            //Adjust是为了让光标能落在括号内
            switch (FunName)
            {
                case "开方":
                    FunFormat = "sqrt()";
                    Adjust = -1;
                    break;
                case "乘方":
                    FunFormat = "^";
                    break;
                case "正弦":
                    FunFormat = "sin()";
                    Adjust = -1;
                    break;
                case "余弦":
                    FunFormat = "cos()";
                    Adjust = -1;
                    break;
                case "正切":
                    FunFormat = "tan()";
                    Adjust = -1;
                    break;
            }
            if (FunFormat != "")
            {
                int start = textBox_expression.SelectionStart;
                textBox_expression.Text = textBox_expression.Text.Insert(start, FunFormat);
                textBox_expression.Focus();
                textBox_expression.SelectionStart = start + FunFormat.Length + Adjust;
                textBox_expression.SelectionLength = 0;
            }
        }
    }
}
