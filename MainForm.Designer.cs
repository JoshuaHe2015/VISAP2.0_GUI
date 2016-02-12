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
            this.button_LastPage = new System.Windows.Forms.Button();
            this.button_NextPage = new System.Windows.Forms.Button();
            this.button_PreviousPage = new System.Windows.Forms.Button();
            this.button_FirstPage = new System.Windows.Forms.Button();
            this.button_Skip = new System.Windows.Forms.Button();
            this.textBox_CurrentPage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_CurrentPage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_CurrentPageRow = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_TotalPage = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.转置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.所有内容ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选中行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 422);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(760, 128);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
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
            this.缺失值处理ToolStripMenuItem,
            this.转置ToolStripMenuItem});
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
            this.label_Row.Location = new System.Drawing.Point(88, 362);
            this.label_Row.Name = "label_Row";
            this.label_Row.Size = new System.Drawing.Size(59, 20);
            this.label_Row.TabIndex = 6;
            this.label_Row.Text = "0    ";
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
            this.label_Column.Location = new System.Drawing.Point(297, 362);
            this.label_Column.Name = "label_Column";
            this.label_Column.Size = new System.Drawing.Size(19, 20);
            this.label_Column.TabIndex = 8;
            this.label_Column.Text = "0";
            // 
            // button_LastPage
            // 
            this.button_LastPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_LastPage.Location = new System.Drawing.Point(467, 362);
            this.button_LastPage.Name = "button_LastPage";
            this.button_LastPage.Size = new System.Drawing.Size(70, 23);
            this.button_LastPage.TabIndex = 9;
            this.button_LastPage.Text = "末页";
            this.button_LastPage.UseVisualStyleBackColor = true;
            this.button_LastPage.Click += new System.EventHandler(this.button_LastPage_Click);
            // 
            // button_NextPage
            // 
            this.button_NextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_NextPage.Location = new System.Drawing.Point(467, 391);
            this.button_NextPage.Name = "button_NextPage";
            this.button_NextPage.Size = new System.Drawing.Size(70, 23);
            this.button_NextPage.TabIndex = 10;
            this.button_NextPage.Text = "下页";
            this.button_NextPage.UseVisualStyleBackColor = true;
            this.button_NextPage.Click += new System.EventHandler(this.button_NextPage_Click);
            // 
            // button_PreviousPage
            // 
            this.button_PreviousPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_PreviousPage.Location = new System.Drawing.Point(386, 391);
            this.button_PreviousPage.Name = "button_PreviousPage";
            this.button_PreviousPage.Size = new System.Drawing.Size(70, 23);
            this.button_PreviousPage.TabIndex = 11;
            this.button_PreviousPage.Text = "上页";
            this.button_PreviousPage.UseVisualStyleBackColor = true;
            this.button_PreviousPage.Click += new System.EventHandler(this.button_PreviousPage_Click);
            // 
            // button_FirstPage
            // 
            this.button_FirstPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_FirstPage.Location = new System.Drawing.Point(386, 362);
            this.button_FirstPage.Name = "button_FirstPage";
            this.button_FirstPage.Size = new System.Drawing.Size(70, 23);
            this.button_FirstPage.TabIndex = 12;
            this.button_FirstPage.Text = "首页";
            this.button_FirstPage.UseVisualStyleBackColor = true;
            this.button_FirstPage.Click += new System.EventHandler(this.button_FirstPage_Click);
            // 
            // button_Skip
            // 
            this.button_Skip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Skip.Location = new System.Drawing.Point(702, 362);
            this.button_Skip.Name = "button_Skip";
            this.button_Skip.Size = new System.Drawing.Size(70, 23);
            this.button_Skip.TabIndex = 13;
            this.button_Skip.Text = "跳转";
            this.button_Skip.UseVisualStyleBackColor = true;
            this.button_Skip.Click += new System.EventHandler(this.button_Skip_Click);
            // 
            // textBox_CurrentPage
            // 
            this.textBox_CurrentPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_CurrentPage.Location = new System.Drawing.Point(592, 362);
            this.textBox_CurrentPage.Name = "textBox_CurrentPage";
            this.textBox_CurrentPage.Size = new System.Drawing.Size(70, 21);
            this.textBox_CurrentPage.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(13, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "当前第";
            // 
            // label_CurrentPage
            // 
            this.label_CurrentPage.AutoSize = true;
            this.label_CurrentPage.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_CurrentPage.Location = new System.Drawing.Point(88, 391);
            this.label_CurrentPage.Name = "label_CurrentPage";
            this.label_CurrentPage.Size = new System.Drawing.Size(19, 20);
            this.label_CurrentPage.TabIndex = 16;
            this.label_CurrentPage.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(182, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "当前页行数";
            // 
            // label_CurrentPageRow
            // 
            this.label_CurrentPageRow.AutoSize = true;
            this.label_CurrentPageRow.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_CurrentPageRow.Location = new System.Drawing.Point(297, 391);
            this.label_CurrentPageRow.Name = "label_CurrentPageRow";
            this.label_CurrentPageRow.Size = new System.Drawing.Size(19, 20);
            this.label_CurrentPageRow.TabIndex = 18;
            this.label_CurrentPageRow.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(547, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "第:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(668, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "页";
            // 
            // label_TotalPage
            // 
            this.label_TotalPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_TotalPage.AutoSize = true;
            this.label_TotalPage.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_TotalPage.Location = new System.Drawing.Point(547, 391);
            this.label_TotalPage.Name = "label_TotalPage";
            this.label_TotalPage.Size = new System.Drawing.Size(139, 20);
            this.label_TotalPage.TabIndex = 21;
            this.label_TotalPage.Text = "共0页,每页0行";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(147, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "页";
            // 
            // 转置ToolStripMenuItem
            // 
            this.转置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.所有内容ToolStripMenuItem,
            this.选中行ToolStripMenuItem});
            this.转置ToolStripMenuItem.Name = "转置ToolStripMenuItem";
            this.转置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.转置ToolStripMenuItem.Text = "转置";
            // 
            // 所有内容ToolStripMenuItem
            // 
            this.所有内容ToolStripMenuItem.Name = "所有内容ToolStripMenuItem";
            this.所有内容ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.所有内容ToolStripMenuItem.Text = "所有内容";
            this.所有内容ToolStripMenuItem.Click += new System.EventHandler(this.所有内容ToolStripMenuItem_Click);
            // 
            // 选中行ToolStripMenuItem
            // 
            this.选中行ToolStripMenuItem.Name = "选中行ToolStripMenuItem";
            this.选中行ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.选中行ToolStripMenuItem.Text = "选中行";
            this.选中行ToolStripMenuItem.Click += new System.EventHandler(this.选中行ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label_TotalPage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_CurrentPageRow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_CurrentPage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_CurrentPage);
            this.Controls.Add(this.button_Skip);
            this.Controls.Add(this.button_FirstPage);
            this.Controls.Add(this.button_PreviousPage);
            this.Controls.Add(this.button_NextPage);
            this.Controls.Add(this.button_LastPage);
            this.Controls.Add(this.label_Column);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Row);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Button button_LastPage;
        private System.Windows.Forms.Button button_NextPage;
        private System.Windows.Forms.Button button_PreviousPage;
        private System.Windows.Forms.Button button_FirstPage;
        private System.Windows.Forms.Button button_Skip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_CurrentPageRow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox textBox_CurrentPage;
        public System.Windows.Forms.Label label_CurrentPage;
        public System.Windows.Forms.Label label_TotalPage;
        private System.Windows.Forms.ToolStripMenuItem 转置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 所有内容ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选中行ToolStripMenuItem;
    }
}

