namespace Сhart
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AreaPaint = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Draw = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.limitationUpY = new System.Windows.Forms.TextBox();
            this.limitationUpX = new System.Windows.Forms.TextBox();
            this.limitationDownY = new System.Windows.Forms.TextBox();
            this.limitationDownX = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.multiplier = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.minus = new System.Windows.Forms.RadioButton();
            this.plus = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.offsetY = new System.Windows.Forms.TextBox();
            this.offsetX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AdditionalParameter = new System.Windows.Forms.TextBox();
            this.SelectingFunction = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AreaPaint)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 367F));
            this.tableLayoutPanel1.Controls.Add(this.AreaPaint, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1242, 663);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // AreaPaint
            // 
            this.AreaPaint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AreaPaint.BackColor = System.Drawing.Color.White;
            this.AreaPaint.Cursor = System.Windows.Forms.Cursors.Cross;
            this.AreaPaint.Location = new System.Drawing.Point(0, 0);
            this.AreaPaint.Margin = new System.Windows.Forms.Padding(0);
            this.AreaPaint.Name = "AreaPaint";
            this.AreaPaint.Size = new System.Drawing.Size(1042, 665);
            this.AreaPaint.TabIndex = 0;
            this.AreaPaint.TabStop = false;
            this.AreaPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.AreaPaint_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Draw);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.limitationUpY);
            this.groupBox1.Controls.Add(this.limitationUpX);
            this.groupBox1.Controls.Add(this.limitationDownY);
            this.groupBox1.Controls.Add(this.limitationDownX);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.multiplier);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.minus);
            this.groupBox1.Controls.Add(this.plus);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.offsetY);
            this.groupBox1.Controls.Add(this.offsetX);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AdditionalParameter);
            this.groupBox1.Controls.Add(this.SelectingFunction);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1916, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(355, 1217);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(114, 884);
            this.Draw.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(150, 42);
            this.Draw.TabIndex = 24;
            this.Draw.Text = "Нарисовать";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(11, 820);
            this.textBox9.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(330, 29);
            this.textBox9.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(88, 774);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(211, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "Итоговое выражение";
            // 
            // limitationUpY
            // 
            this.limitationUpY.Location = new System.Drawing.Point(185, 713);
            this.limitationUpY.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.limitationUpY.Name = "limitationUpY";
            this.limitationUpY.Size = new System.Drawing.Size(156, 29);
            this.limitationUpY.TabIndex = 21;
            // 
            // limitationUpX
            // 
            this.limitationUpX.Location = new System.Drawing.Point(15, 713);
            this.limitationUpX.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.limitationUpX.Name = "limitationUpX";
            this.limitationUpX.Size = new System.Drawing.Size(156, 29);
            this.limitationUpX.TabIndex = 20;
            // 
            // limitationDownY
            // 
            this.limitationDownY.Location = new System.Drawing.Point(185, 665);
            this.limitationDownY.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.limitationDownY.Name = "limitationDownY";
            this.limitationDownY.Size = new System.Drawing.Size(156, 29);
            this.limitationDownY.TabIndex = 19;
            // 
            // limitationDownX
            // 
            this.limitationDownX.Location = new System.Drawing.Point(15, 665);
            this.limitationDownX.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.limitationDownX.Name = "limitationDownX";
            this.limitationDownX.Size = new System.Drawing.Size(156, 29);
            this.limitationDownX.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(242, 635);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(103, 635);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "x";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 587);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ограничения";
            // 
            // multiplier
            // 
            this.multiplier.Location = new System.Drawing.Point(79, 522);
            this.multiplier.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.multiplier.Name = "multiplier";
            this.multiplier.Size = new System.Drawing.Size(224, 29);
            this.multiplier.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 476);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Множитель";
            // 
            // minus
            // 
            this.minus.AutoSize = true;
            this.minus.Location = new System.Drawing.Point(108, 415);
            this.minus.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(189, 29);
            this.minus.TabIndex = 12;
            this.minus.TabStop = true;
            this.minus.Text = "Отрицательный";
            this.minus.UseVisualStyleBackColor = true;
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Checked = true;
            this.plus.Location = new System.Drawing.Point(108, 373);
            this.plus.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(194, 29);
            this.plus.TabIndex = 11;
            this.plus.TabStop = true;
            this.plus.Text = "Положительный";
            this.plus.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 325);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Тип графика";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "x";
            // 
            // offsetY
            // 
            this.offsetY.Location = new System.Drawing.Point(185, 262);
            this.offsetY.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.offsetY.Name = "offsetY";
            this.offsetY.Size = new System.Drawing.Size(156, 29);
            this.offsetY.TabIndex = 7;
            // 
            // offsetX
            // 
            this.offsetX.Location = new System.Drawing.Point(185, 214);
            this.offsetX.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.offsetX.Name = "offsetX";
            this.offsetX.Size = new System.Drawing.Size(156, 29);
            this.offsetX.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "+- по осям";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Степень";
            // 
            // AdditionalParameter
            // 
            this.AdditionalParameter.Location = new System.Drawing.Point(185, 109);
            this.AdditionalParameter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AdditionalParameter.Name = "AdditionalParameter";
            this.AdditionalParameter.Size = new System.Drawing.Size(156, 29);
            this.AdditionalParameter.TabIndex = 3;
            // 
            // SelectingFunction
            // 
            this.SelectingFunction.FormattingEnabled = true;
            this.SelectingFunction.Items.AddRange(new object[] {
            "x^(Степень)",
            "√x",
            "sin(x)",
            "cos(x)",
            "(x^2+y^2-1)^3 - x^2*y^3=0",
            "Сердечки v2"});
            this.SelectingFunction.Location = new System.Drawing.Point(79, 59);
            this.SelectingFunction.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SelectingFunction.Name = "SelectingFunction";
            this.SelectingFunction.Size = new System.Drawing.Size(219, 32);
            this.SelectingFunction.TabIndex = 2;
            this.SelectingFunction.Text = "x^(Степень)";
            this.SelectingFunction.SelectedIndexChanged += new System.EventHandler(this.SelectingFunction_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Функции";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 1007);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 42);
            this.button1.TabIndex = 25;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 1007);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 42);
            this.button2.TabIndex = 26;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(2317, 1265);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(2327, 1275);
            this.Name = "MainForm";
            this.Opacity = 0.97D;
            this.Text = "Charts";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AreaPaint)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox AreaPaint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SelectingFunction;
        private System.Windows.Forms.TextBox offsetY;
        private System.Windows.Forms.TextBox offsetX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AdditionalParameter;
        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox limitationUpY;
        private System.Windows.Forms.TextBox limitationUpX;
        private System.Windows.Forms.TextBox limitationDownY;
        private System.Windows.Forms.TextBox limitationDownX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox multiplier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton minus;
        private System.Windows.Forms.RadioButton plus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

