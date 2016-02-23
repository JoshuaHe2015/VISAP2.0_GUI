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
    public partial class HypothesisTesting : Form
    {
        public static string result = "";
        public HypothesisTesting()
        {
            InitializeComponent();
            Tabulation.RenewColsItems(MainForm.MainDT, comboBox_Cols);
        }

        private void button_StartTesting_Click(object sender, EventArgs e)
        {
            result = Stat.HypothesisTesting(MainForm.MainDT, comboBox_Cols.Text,
                comboBox_Statistics.Text, comboBox_Operation.Text, comboBox_Tail.Text,
                Convert.ToDouble(comboBox_Significance.Text), Convert.ToDouble(textBox_NullHypothesis.Text));
            MainForm.S.richTextBox1.AppendText(result);
            MainForm.S.richTextBox1.Select();//让RichTextBox获得焦点
            MainForm.S.richTextBox1.Select(MainForm.S.richTextBox1.TextLength, 0);//将插入符号置于文本结束处 
            MainForm.S.richTextBox1.ScrollToCaret(); 
        }

        private void comboBox_Statistics_TextChanged(object sender, EventArgs e)
        {
            string Operation = comboBox_Operation.Text;
            if (Operation == "=")
            {
                Operation = "<>";
            }
            else if (Operation == "<=")
            {
                Operation = ">";
            }
            else
            {
                Operation = "<";
            }
            label_Alternative.Text = comboBox_Statistics.Text + " " + Operation + " " + textBox_NullHypothesis.Text;
        }

        private void comboBox_Operation_TextChanged(object sender, EventArgs e)
        {
            string Operation = comboBox_Operation.Text;
            if (Operation == "=")
            {
                Operation = "<>";
            }
            else if (Operation == "<=")
            {
                Operation = ">";
            }
            else
            {
                Operation = "<";
            }
            label_Alternative.Text = comboBox_Statistics.Text + " " + Operation + " " + textBox_NullHypothesis.Text;
        }

        private void textBox_NullHypothesis_TextChanged(object sender, EventArgs e)
        {
            string Operation = comboBox_Operation.Text;
            if (Operation == "=")
            {
                Operation = "<>";
            }
            else if (Operation == "<=")
            {
                Operation =">";
            }
            else
            {
                Operation ="<";
            }
            label_Alternative.Text = comboBox_Statistics.Text + " " + Operation + " " + textBox_NullHypothesis.Text;
        }
    }
}
