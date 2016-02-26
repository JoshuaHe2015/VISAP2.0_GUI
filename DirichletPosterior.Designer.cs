namespace VISAP商科应用
{
    partial class DirichletPosterior
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.button_predict = new System.Windows.Forms.Button();
            this.textBox_successes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart_PosteriorDensity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox_Parameters = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Density = new System.Windows.Forms.ComboBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Percentile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Percentiles = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart_PosteriorDensity)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_predict
            // 
            this.button_predict.Location = new System.Drawing.Point(289, 329);
            this.button_predict.Name = "button_predict";
            this.button_predict.Size = new System.Drawing.Size(75, 23);
            this.button_predict.TabIndex = 15;
            this.button_predict.Text = "预测报告";
            this.button_predict.UseVisualStyleBackColor = true;
            this.button_predict.Click += new System.EventHandler(this.button_predict_Click);
            // 
            // textBox_successes
            // 
            this.textBox_successes.Location = new System.Drawing.Point(12, 195);
            this.textBox_successes.Multiline = true;
            this.textBox_successes.Name = "textBox_successes";
            this.textBox_successes.Size = new System.Drawing.Size(352, 128);
            this.textBox_successes.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(9, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(368, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "输入想要预测的次数结果(用逗号分隔，每行一组):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(9, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "预测:";
            // 
            // chart_PosteriorDensity
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_PosteriorDensity.ChartAreas.Add(chartArea1);
            this.chart_PosteriorDensity.ContextMenuStrip = this.contextMenuStrip1;
            legend1.Name = "Legend1";
            this.chart_PosteriorDensity.Legends.Add(legend1);
            this.chart_PosteriorDensity.Location = new System.Drawing.Point(386, 14);
            this.chart_PosteriorDensity.Name = "chart_PosteriorDensity";
            this.chart_PosteriorDensity.Size = new System.Drawing.Size(521, 339);
            this.chart_PosteriorDensity.TabIndex = 16;
            this.chart_PosteriorDensity.Text = "chart1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制ToolStripMenuItem,
            this.清空ToolStripMenuItem,
            this.保存ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            // 
            // 清空ToolStripMenuItem
            // 
            this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            this.清空ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.清空ToolStripMenuItem.Text = "清空";
            this.清空ToolStripMenuItem.Click += new System.EventHandler(this.清空ToolStripMenuItem_Click);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // comboBox_Parameters
            // 
            this.comboBox_Parameters.FormattingEnabled = true;
            this.comboBox_Parameters.Location = new System.Drawing.Point(12, 31);
            this.comboBox_Parameters.Name = "comboBox_Parameters";
            this.comboBox_Parameters.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Parameters.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "添加分布:";
            // 
            // comboBox_Density
            // 
            this.comboBox_Density.FormattingEnabled = true;
            this.comboBox_Density.Items.AddRange(new object[] {
            "先验分布",
            "似然函数",
            "后验分布"});
            this.comboBox_Density.Location = new System.Drawing.Point(157, 31);
            this.comboBox_Density.Name = "comboBox_Density";
            this.comboBox_Density.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Density.TabIndex = 19;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(289, 31);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 20;
            this.button_Add.Text = "添加";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Percentile
            // 
            this.button_Percentile.Location = new System.Drawing.Point(289, 94);
            this.button_Percentile.Name = "button_Percentile";
            this.button_Percentile.Size = new System.Drawing.Size(75, 23);
            this.button_Percentile.TabIndex = 24;
            this.button_Percentile.Text = "分位数报告";
            this.button_Percentile.UseVisualStyleBackColor = true;
            this.button_Percentile.Click += new System.EventHandler(this.button_Percentile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "分位数(用逗号分隔):";
            // 
            // textBox_Percentiles
            // 
            this.textBox_Percentiles.Location = new System.Drawing.Point(15, 96);
            this.textBox_Percentiles.Name = "textBox_Percentiles";
            this.textBox_Percentiles.Size = new System.Drawing.Size(263, 21);
            this.textBox_Percentiles.TabIndex = 22;
            this.textBox_Percentiles.Text = "0.05,0.95";
            // 
            // DirichletPosterior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 365);
            this.Controls.Add(this.button_Percentile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Percentiles);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.comboBox_Density);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Parameters);
            this.Controls.Add(this.chart_PosteriorDensity);
            this.Controls.Add(this.button_predict);
            this.Controls.Add(this.textBox_successes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "DirichletPosterior";
            this.Text = "DirichletPosterior";
            ((System.ComponentModel.ISupportInitialize)(this.chart_PosteriorDensity)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_predict;
        private System.Windows.Forms.TextBox textBox_successes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_PosteriorDensity;
        private System.Windows.Forms.ComboBox comboBox_Parameters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Density;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem;
        private System.Windows.Forms.Button button_Percentile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Percentiles;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
    }
}