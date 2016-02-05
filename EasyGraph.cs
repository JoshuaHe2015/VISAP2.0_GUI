﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
namespace VISAP商科应用
{
    public partial class EasyGraph : Form
    {
        public static EasyGraph EasyGraphForm = null;
        public EasyGraph()
        {
            InitializeComponent();
            EasyGraphForm = this;
        }
        void refresh_Combox()
        {
            comboBox_x.Items.Clear();
            comboBox_y.Items.Clear();
            int ColCounts = dataGridView_subset.ColumnCount;
            for (int i = 0; i < ColCounts; i++)
            {
                comboBox_x.Items.Add(dataGridView_subset.Columns[i].Name);
                comboBox_y.Items.Add(dataGridView_subset.Columns[i].Name);
            }

        }

        private void button_random_Click(object sender, EventArgs e)
        {
            textBox_ColorShow.BackColor = comboBox_x.BackColor;
            textBox_ColorShow.Text = "随机颜色";
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            textBox_ChosenCols.Text = Tabulation.GetGridCols(MainForm.S.dataGridView1);
            
        }

        private void button_changeColor_Click(object sender, EventArgs e)
        {
            ColorDialog ChooseColor = new ColorDialog();
            if (ChooseColor.ShowDialog() == DialogResult.OK)
            {
                textBox_ColorShow.BackColor = ChooseColor.Color;
                textBox_ColorShow.Text = ChooseColor.Color.Name;
            }
        }

        private void button_import_Click(object sender, EventArgs e)
        {
            dataGridView_subset.DataSource = Tabulation.GetSubset(MainForm.S.dataGridView1, textBox_ChosenCols.Text);
            refresh_Combox();
        }

        private void dataGridView_subset_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridView_subset.CurrentCell.RowIndex;
            label_Row.Text = (rowIndex + 1).ToString();
            int columnIndex = dataGridView_subset.CurrentCell.ColumnIndex;
            label_Column.Text = (columnIndex + 1).ToString();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            QuickPlot.QPlot(dataGridView_subset,chart_basic,
                Tabulation.FindCol(dataGridView_subset, comboBox_x.Text),
                Tabulation.FindCol(dataGridView_subset,comboBox_x.Text), 
                textBox_ColorShow,comboBox_type.Text, textBox_Legend.Text);
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isSave = true;
            SaveFileDialog saveImageDialog = new SaveFileDialog();
            saveImageDialog.Title = "图片保存";
            saveImageDialog.Filter = @"jpeg|*.jpg|bmp|*.bmp|gif|*.gif";

            if (saveImageDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveImageDialog.FileName.ToString();

                if (fileName != "" && fileName != null)
                {
                    string fileExtName = fileName.Substring(fileName.LastIndexOf(".") + 1).ToString();

                    System.Drawing.Imaging.ImageFormat imgformat = null;

                    if (fileExtName != "")
                    {
                        switch (fileExtName)
                        {
                            case "jpg":
                                imgformat = System.Drawing.Imaging.ImageFormat.Jpeg;
                                break;
                            case "bmp":
                                imgformat = System.Drawing.Imaging.ImageFormat.Bmp;
                                break;
                            case "gif":
                                imgformat = System.Drawing.Imaging.ImageFormat.Gif;
                                break;
                            default:
                                MessageBox.Show("只能存取为: jpg,bmp,gif 格式");
                                isSave = false;
                                break;
                        }

                    }

                    //默认保存为JPG格式   
                    if (imgformat == null)
                    {
                        imgformat = System.Drawing.Imaging.ImageFormat.Jpeg;
                    }

                    if (isSave)
                    {
                        try
                        {
                            chart_basic.SaveImage(fileName, imgformat);
                            //MessageBox.Show("图片已经成功保存!");   
                        }
                        catch
                        {
                            MessageBox.Show("保存失败,你还没有截取过图片或已经清空图片!");
                        }
                    }

                }

            }   
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                chart_basic.SaveImage(ms, ChartImageFormat.Jpeg);
                Bitmap m = new Bitmap(ms);
                //复制到粘贴板
                Clipboard.SetImage(m);
            }
        }

        private void 清空ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart_basic.Series.Clear();
        }

        private void 设置轴标签ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetLabels LabelForm = new SetLabels();
            LabelForm.ShowDialog();
        }
    }
}