namespace VISAP商科应用
{
    partial class Calculator
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
            this.textBox_expression = new System.Windows.Forms.TextBox();
            this.button_Cal = new System.Windows.Forms.Button();
            this.comboBox_Output = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_NewCol = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_Vars = new System.Windows.Forms.ListBox();
            this.button_AddVariable = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button_DecimalPoint = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Functions = new System.Windows.Forms.ComboBox();
            this.button_AddFun = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Minus = new System.Windows.Forms.Button();
            this.button_Multiply = new System.Windows.Forms.Button();
            this.button_Divide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_expression
            // 
            this.textBox_expression.Location = new System.Drawing.Point(114, 12);
            this.textBox_expression.Multiline = true;
            this.textBox_expression.Name = "textBox_expression";
            this.textBox_expression.Size = new System.Drawing.Size(474, 127);
            this.textBox_expression.TabIndex = 0;
            // 
            // button_Cal
            // 
            this.button_Cal.Location = new System.Drawing.Point(513, 266);
            this.button_Cal.Name = "button_Cal";
            this.button_Cal.Size = new System.Drawing.Size(75, 23);
            this.button_Cal.TabIndex = 1;
            this.button_Cal.Text = "计算";
            this.button_Cal.UseVisualStyleBackColor = true;
            this.button_Cal.Click += new System.EventHandler(this.button_Cal_Click);
            // 
            // comboBox_Output
            // 
            this.comboBox_Output.FormattingEnabled = true;
            this.comboBox_Output.Location = new System.Drawing.Point(188, 266);
            this.comboBox_Output.Name = "comboBox_Output";
            this.comboBox_Output.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Output.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(118, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "输出列:";
            // 
            // checkBox_NewCol
            // 
            this.checkBox_NewCol.AutoSize = true;
            this.checkBox_NewCol.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_NewCol.Location = new System.Drawing.Point(325, 267);
            this.checkBox_NewCol.Name = "checkBox_NewCol";
            this.checkBox_NewCol.Size = new System.Drawing.Size(75, 20);
            this.checkBox_NewCol.TabIndex = 4;
            this.checkBox_NewCol.Text = "新增列";
            this.checkBox_NewCol.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "添加变量:";
            // 
            // listBox_Vars
            // 
            this.listBox_Vars.FormattingEnabled = true;
            this.listBox_Vars.ItemHeight = 12;
            this.listBox_Vars.Location = new System.Drawing.Point(12, 31);
            this.listBox_Vars.Name = "listBox_Vars";
            this.listBox_Vars.Size = new System.Drawing.Size(96, 232);
            this.listBox_Vars.TabIndex = 8;
            // 
            // button_AddVariable
            // 
            this.button_AddVariable.Location = new System.Drawing.Point(12, 268);
            this.button_AddVariable.Name = "button_AddVariable";
            this.button_AddVariable.Size = new System.Drawing.Size(75, 23);
            this.button_AddVariable.TabIndex = 9;
            this.button_AddVariable.Text = "添加变量";
            this.button_AddVariable.UseVisualStyleBackColor = true;
            this.button_AddVariable.Click += new System.EventHandler(this.button_AddVariable_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(283, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(121, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(202, 175);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(283, 175);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(121, 204);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 16;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(202, 204);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 17;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(283, 204);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 18;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(121, 233);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 23);
            this.button0.TabIndex = 19;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button_DecimalPoint
            // 
            this.button_DecimalPoint.Location = new System.Drawing.Point(202, 233);
            this.button_DecimalPoint.Name = "button_DecimalPoint";
            this.button_DecimalPoint.Size = new System.Drawing.Size(75, 23);
            this.button_DecimalPoint.TabIndex = 20;
            this.button_DecimalPoint.Text = "小数点";
            this.button_DecimalPoint.UseVisualStyleBackColor = true;
            this.button_DecimalPoint.Click += new System.EventHandler(this.button10_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(283, 233);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 21;
            this.button_Clear.Text = "清空";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button11_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(461, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "函数:";
            // 
            // comboBox_Functions
            // 
            this.comboBox_Functions.FormattingEnabled = true;
            this.comboBox_Functions.Items.AddRange(new object[] {
            "开方",
            "乘方",
            "正弦",
            "余弦",
            "正切"});
            this.comboBox_Functions.Location = new System.Drawing.Point(464, 172);
            this.comboBox_Functions.Name = "comboBox_Functions";
            this.comboBox_Functions.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Functions.TabIndex = 23;
            // 
            // button_AddFun
            // 
            this.button_AddFun.Location = new System.Drawing.Point(510, 198);
            this.button_AddFun.Name = "button_AddFun";
            this.button_AddFun.Size = new System.Drawing.Size(75, 23);
            this.button_AddFun.TabIndex = 24;
            this.button_AddFun.Text = "添加函数";
            this.button_AddFun.UseVisualStyleBackColor = true;
            this.button_AddFun.Click += new System.EventHandler(this.button_AddFun_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(364, 146);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 25;
            this.button_Add.Text = "+";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Minus
            // 
            this.button_Minus.Location = new System.Drawing.Point(364, 175);
            this.button_Minus.Name = "button_Minus";
            this.button_Minus.Size = new System.Drawing.Size(75, 23);
            this.button_Minus.TabIndex = 26;
            this.button_Minus.Text = "-";
            this.button_Minus.UseVisualStyleBackColor = true;
            this.button_Minus.Click += new System.EventHandler(this.button_Minus_Click);
            // 
            // button_Multiply
            // 
            this.button_Multiply.Location = new System.Drawing.Point(364, 204);
            this.button_Multiply.Name = "button_Multiply";
            this.button_Multiply.Size = new System.Drawing.Size(75, 23);
            this.button_Multiply.TabIndex = 27;
            this.button_Multiply.Text = "*";
            this.button_Multiply.UseVisualStyleBackColor = true;
            this.button_Multiply.Click += new System.EventHandler(this.button_Multiply_Click);
            // 
            // button_Divide
            // 
            this.button_Divide.Location = new System.Drawing.Point(364, 233);
            this.button_Divide.Name = "button_Divide";
            this.button_Divide.Size = new System.Drawing.Size(75, 23);
            this.button_Divide.TabIndex = 28;
            this.button_Divide.Text = "/";
            this.button_Divide.UseVisualStyleBackColor = true;
            this.button_Divide.Click += new System.EventHandler(this.button_Divide_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 303);
            this.Controls.Add(this.button_Divide);
            this.Controls.Add(this.button_Multiply);
            this.Controls.Add(this.button_Minus);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_AddFun);
            this.Controls.Add(this.comboBox_Functions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_DecimalPoint);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_AddVariable);
            this.Controls.Add(this.listBox_Vars);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_NewCol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Output);
            this.Controls.Add(this.button_Cal);
            this.Controls.Add(this.textBox_expression);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_expression;
        private System.Windows.Forms.Button button_Cal;
        private System.Windows.Forms.ComboBox comboBox_Output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_NewCol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_Vars;
        private System.Windows.Forms.Button button_AddVariable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button_DecimalPoint;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Functions;
        private System.Windows.Forms.Button button_AddFun;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Minus;
        private System.Windows.Forms.Button button_Multiply;
        private System.Windows.Forms.Button button_Divide;
    }
}