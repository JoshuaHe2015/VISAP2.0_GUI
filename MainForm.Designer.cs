namespace VISAP商科应用
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.AddNewRow = new System.Windows.Forms.Button();
            this.AddNewCol = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csv文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.批量导入csvToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelxlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csvcsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据预处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.检测变量类型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.缺失值处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.描述ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.汇总ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.简单图表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.统计推断ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.参数估计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报告ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Row = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Column = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(760, 314);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 392);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(760, 158);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // AddNewRow
            // 
            this.AddNewRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewRow.Location = new System.Drawing.Point(565, 362);
            this.AddNewRow.Name = "AddNewRow";
            this.AddNewRow.Size = new System.Drawing.Size(75, 23);
            this.AddNewRow.TabIndex = 2;
            this.AddNewRow.Text = "添加行";
            this.AddNewRow.UseVisualStyleBackColor = true;
            // 
            // AddNewCol
            // 
            this.AddNewCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewCol.Location = new System.Drawing.Point(662, 362);
            this.AddNewCol.Name = "AddNewCol";
            this.AddNewCol.Size = new System.Drawing.Size(75, 23);
            this.AddNewCol.TabIndex = 3;
            this.AddNewCol.Text = "添加变量";
            this.AddNewCol.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem,
            this.数据预处理ToolStripMenuItem,
            this.描述ToolStripMenuItem,
            this.统计推断ToolStripMenuItem,
            this.报告ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.导入ToolStripMenuItem,
            this.导出ToolStripMenuItem,
            this.关闭ToolStripMenuItem});
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            this.开始ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.开始ToolStripMenuItem.Text = "开始";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.新建ToolStripMenuItem.Text = "新建";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 导入ToolStripMenuItem
            // 
            this.导入ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem,
            this.csv文件ToolStripMenuItem,
            this.批量导入csvToolStripMenuItem1});
            this.导入ToolStripMenuItem.Name = "导入ToolStripMenuItem";
            this.导入ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.导入ToolStripMenuItem.Text = "导入";
            this.导入ToolStripMenuItem.Click += new System.EventHandler(this.导入ToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.excelToolStripMenuItem.Text = "Excel(*.xls,*.xlsx)";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // csv文件ToolStripMenuItem
            // 
            this.csv文件ToolStripMenuItem.Name = "csv文件ToolStripMenuItem";
            this.csv文件ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.csv文件ToolStripMenuItem.Text = "csv(*.csv)";
            this.csv文件ToolStripMenuItem.Click += new System.EventHandler(this.csv文件ToolStripMenuItem_Click);
            // 
            // 批量导入csvToolStripMenuItem1
            // 
            this.批量导入csvToolStripMenuItem1.Name = "批量导入csvToolStripMenuItem1";
            this.批量导入csvToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.批量导入csvToolStripMenuItem1.Text = "批量导入csv";
            this.批量导入csvToolStripMenuItem1.Click += new System.EventHandler(this.批量导入csvToolStripMenuItem1_Click);
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelxlsToolStripMenuItem,
            this.csvcsvToolStripMenuItem});
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.导出ToolStripMenuItem.Text = "导出";
            // 
            // excelxlsToolStripMenuItem
            // 
            this.excelxlsToolStripMenuItem.Name = "excelxlsToolStripMenuItem";
            this.excelxlsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.excelxlsToolStripMenuItem.Text = "Excel(*.xls)";
            this.excelxlsToolStripMenuItem.Click += new System.EventHandler(this.excelxlsToolStripMenuItem_Click);
            // 
            // csvcsvToolStripMenuItem
            // 
            this.csvcsvToolStripMenuItem.Name = "csvcsvToolStripMenuItem";
            this.csvcsvToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.csvcsvToolStripMenuItem.Text = "csv(*.csv)";
            this.csvcsvToolStripMenuItem.Click += new System.EventHandler(this.csvcsvToolStripMenuItem_Click);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关闭ToolStripMenuItem.Text = "关闭";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            // 
            // 数据预处理ToolStripMenuItem
            // 
            this.数据预处理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.检测变量类型ToolStripMenuItem,
            this.缺失值处理ToolStripMenuItem});
            this.数据预处理ToolStripMenuItem.Name = "数据预处理ToolStripMenuItem";
            this.数据预处理ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.数据预处理ToolStripMenuItem.Text = "数据预处理";
            // 
            // 检测变量类型ToolStripMenuItem
            // 
            this.检测变量类型ToolStripMenuItem.Name = "检测变量类型ToolStripMenuItem";
            this.检测变量类型ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.检测变量类型ToolStripMenuItem.Text = "检测变量类型";
            this.检测变量类型ToolStripMenuItem.Click += new System.EventHandler(this.检测变量类型ToolStripMenuItem_Click);
            // 
            // 缺失值处理ToolStripMenuItem
            // 
            this.缺失值处理ToolStripMenuItem.Name = "缺失值处理ToolStripMenuItem";
            this.缺失值处理ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.缺失值处理ToolStripMenuItem.Text = "缺失值处理";
            this.缺失值处理ToolStripMenuItem.Click += new System.EventHandler(this.缺失值处理ToolStripMenuItem_Click);
            // 
            // 描述ToolStripMenuItem
            // 
            this.描述ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.汇总ToolStripMenuItem,
            this.简单图表ToolStripMenuItem});
            this.描述ToolStripMenuItem.Name = "描述ToolStripMenuItem";
            this.描述ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.描述ToolStripMenuItem.Text = "描述";
            // 
            // 汇总ToolStripMenuItem
            // 
            this.汇总ToolStripMenuItem.Name = "汇总ToolStripMenuItem";
            this.汇总ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.汇总ToolStripMenuItem.Text = "快速汇总";
            this.汇总ToolStripMenuItem.Click += new System.EventHandler(this.汇总ToolStripMenuItem_Click);
            // 
            // 简单图表ToolStripMenuItem
            // 
            this.简单图表ToolStripMenuItem.Name = "简单图表ToolStripMenuItem";
            this.简单图表ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.简单图表ToolStripMenuItem.Text = "简单图表";
            this.简单图表ToolStripMenuItem.Click += new System.EventHandler(this.简单图表ToolStripMenuItem_Click);
            // 
            // 统计推断ToolStripMenuItem
            // 
            this.统计推断ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.参数估计ToolStripMenuItem});
            this.统计推断ToolStripMenuItem.Name = "统计推断ToolStripMenuItem";
            this.统计推断ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.统计推断ToolStripMenuItem.Text = "统计推断";
            // 
            // 参数估计ToolStripMenuItem
            // 
            this.参数估计ToolStripMenuItem.Name = "参数估计ToolStripMenuItem";
            this.参数估计ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.参数估计ToolStripMenuItem.Text = "参数估计";
            this.参数估计ToolStripMenuItem.Click += new System.EventHandler(this.参数估计ToolStripMenuItem_Click);
            // 
            // 报告ToolStripMenuItem
            // 
            this.报告ToolStripMenuItem.Name = "报告ToolStripMenuItem";
            this.报告ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.报告ToolStripMenuItem.Text = "报告";
            this.报告ToolStripMenuItem.Click += new System.EventHandler(this.报告ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "行数";
            // 
            // label_Row
            // 
            this.label_Row.AutoSize = true;
            this.label_Row.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Row.Location = new System.Drawing.Point(97, 362);
            this.label_Row.Name = "label_Row";
            this.label_Row.Size = new System.Drawing.Size(19, 20);
            this.label_Row.TabIndex = 6;
            this.label_Row.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(182, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "列数";
            // 
            // label_Column
            // 
            this.label_Column.AutoSize = true;
            this.label_Column.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Column.Location = new System.Drawing.Point(274, 362);
            this.label_Column.Name = "label_Column";
            this.label_Column.Size = new System.Drawing.Size(19, 20);
            this.label_Column.TabIndex = 8;
            this.label_Column.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.label_Column);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Row);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddNewCol);
            this.Controls.Add(this.AddNewRow);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "VISAP2.0";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewRow;
        private System.Windows.Forms.Button AddNewCol;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Row;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Column;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem csv文件ToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem excelxlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem csvcsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 描述ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 汇总ToolStripMenuItem;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem 简单图表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据预处理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 检测变量类型ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 批量导入csvToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 缺失值处理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 统计推断ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 参数估计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 报告ToolStripMenuItem;
    }
}

