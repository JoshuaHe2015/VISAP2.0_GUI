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
    public partial class SetLabels : Form
    {
        public SetLabels()
        {
            InitializeComponent();
        }

        private void button_set_Click(object sender, EventArgs e)
        {
            if (textBox_Main.Text != "")
            {
                EasyGraph.EasyGraphForm.chart_basic.Titles.Clear();
                EasyGraph.EasyGraphForm.chart_basic.Titles.Add(textBox_Main.Text);
            }
            if (textBox_x.Text != "")
                EasyGraph.EasyGraphForm.chart_basic.ChartAreas[0].AxisX.Title = textBox_x.Text;
            if (textBox_y.Text != "")
            EasyGraph.EasyGraphForm.chart_basic.ChartAreas[0].AxisY.Title = textBox_y.Text;
            this.Close();
        }
    }
}
