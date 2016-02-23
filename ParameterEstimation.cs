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
    public partial class ParameterEstimation : Form
    {
        public ParameterEstimation()
        {
            InitializeComponent();
            if (MainForm.S.dataGridView1.DataSource != null)
            {
                textBox_ChosenCols.Text = Tabulation.GetGridCols(MainForm.S.dataGridView1);
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            if (MainForm.S.dataGridView1.DataSource != null)
            {
                textBox_ChosenCols.Text = Tabulation.GetGridCols(MainForm.S.dataGridView1);
            }
        }

        private void textBox_ChosenCols_TextChanged(object sender, EventArgs e)
        {
            textBox_VarNames.Text = Tabulation.GetColsName(MainForm.S.dataGridView1, textBox_ChosenCols.Text);
        }

        private void button_Estimation_Click(object sender, EventArgs e)
        {
            Stat.LoopCI(MainForm.S.dataGridView1,MainForm.S.richTextBox1,
                textBox_ChosenCols.Text,comboBox_Tail.Text,
                comboBox_statistics.Text,Convert.ToDouble(comboBox_ConfidenceLevel.Text));
        }
    }
}
