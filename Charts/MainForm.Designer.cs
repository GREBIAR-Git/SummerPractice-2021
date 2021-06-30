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
            this.FinalExpression = new System.Windows.Forms.TextBox();
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Percent = new System.Windows.Forms.Label();
            this.PercentScrolling = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CenterO = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AreaPaint)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PercentScrolling)).BeginInit();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.AreaPaint, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 11);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(850, 650);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // AreaPaint
            // 
            this.AreaPaint.BackColor = System.Drawing.Color.White;
            this.AreaPaint.Cursor = System.Windows.Forms.Cursors.Cross;
            this.AreaPaint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AreaPaint.Location = new System.Drawing.Point(0, 0);
            this.AreaPaint.Margin = new System.Windows.Forms.Padding(0);
            this.AreaPaint.Name = "AreaPaint";
            this.AreaPaint.Size = new System.Drawing.Size(650, 653);
            this.AreaPaint.TabIndex = 0;
            this.AreaPaint.TabStop = false;
            this.AreaPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.AreaPaint_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Draw);
            this.groupBox1.Controls.Add(this.FinalExpression);
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
            this.groupBox1.Location = new System.Drawing.Point(653, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 360);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(57, 327);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(79, 23);
            this.Draw.TabIndex = 24;
            this.Draw.Text = "Начертить";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // FinalExpression
            // 
            this.FinalExpression.Enabled = false;
            this.FinalExpression.Location = new System.Drawing.Point(8, 301);
            this.FinalExpression.Name = "FinalExpression";
            this.FinalExpression.Size = new System.Drawing.Size(180, 20);
            this.FinalExpression.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Итоговое выражение";
            // 
            // limitationUpY
            // 
            this.limitationUpY.Location = new System.Drawing.Point(101, 262);
            this.limitationUpY.Name = "limitationUpY";
            this.limitationUpY.Size = new System.Drawing.Size(87, 20);
            this.limitationUpY.TabIndex = 21;
            // 
            // limitationUpX
            // 
            this.limitationUpX.Location = new System.Drawing.Point(8, 262);
            this.limitationUpX.Name = "limitationUpX";
            this.limitationUpX.Size = new System.Drawing.Size(87, 20);
            this.limitationUpX.TabIndex = 20;
            // 
            // limitationDownY
            // 
            this.limitationDownY.Location = new System.Drawing.Point(101, 236);
            this.limitationDownY.Name = "limitationDownY";
            this.limitationDownY.Size = new System.Drawing.Size(87, 20);
            this.limitationDownY.TabIndex = 19;
            // 
            // limitationDownX
            // 
            this.limitationDownX.Location = new System.Drawing.Point(8, 236);
            this.limitationDownX.Name = "limitationDownX";
            this.limitationDownX.Size = new System.Drawing.Size(87, 20);
            this.limitationDownX.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(139, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "x";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ограничения";
            // 
            // multiplier
            // 
            this.multiplier.Location = new System.Drawing.Point(35, 183);
            this.multiplier.Name = "multiplier";
            this.multiplier.Size = new System.Drawing.Size(124, 20);
            this.multiplier.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Множитель";
            // 
            // minus
            // 
            this.minus.AutoSize = true;
            this.minus.Location = new System.Drawing.Point(43, 147);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(105, 17);
            this.minus.TabIndex = 12;
            this.minus.TabStop = true;
            this.minus.Text = "Отрицательный";
            this.minus.UseVisualStyleBackColor = true;
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Checked = true;
            this.plus.Location = new System.Drawing.Point(43, 124);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(108, 17);
            this.plus.TabIndex = 11;
            this.plus.TabStop = true;
            this.plus.Text = "Положительный";
            this.plus.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Тип графика";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "x";
            // 
            // offsetY
            // 
            this.offsetY.Location = new System.Drawing.Point(101, 85);
            this.offsetY.Name = "offsetY";
            this.offsetY.Size = new System.Drawing.Size(87, 20);
            this.offsetY.TabIndex = 7;
            // 
            // offsetX
            // 
            this.offsetX.Location = new System.Drawing.Point(8, 85);
            this.offsetX.Name = "offsetX";
            this.offsetX.Size = new System.Drawing.Size(87, 20);
            this.offsetX.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Смещение по осям";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Степень";
            this.label2.Visible = false;
            // 
            // AdditionalParameter
            // 
            this.AdditionalParameter.Location = new System.Drawing.Point(131, 33);
            this.AdditionalParameter.Name = "AdditionalParameter";
            this.AdditionalParameter.Size = new System.Drawing.Size(63, 20);
            this.AdditionalParameter.TabIndex = 3;
            this.AdditionalParameter.Visible = false;
            // 
            // SelectingFunction
            // 
            this.SelectingFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectingFunction.FormattingEnabled = true;
            this.SelectingFunction.Items.AddRange(new object[] {
            "Не выбрано",
            "x^(Степень)",
            "√x",
            "sin(x)",
            "cos(x)",
            "(x^2+y^2-1)^3 - x^2*y^3=0",
            "Сердечки v2"});
            this.SelectingFunction.Location = new System.Drawing.Point(4, 32);
            this.SelectingFunction.Name = "SelectingFunction";
            this.SelectingFunction.Size = new System.Drawing.Size(121, 21);
            this.SelectingFunction.TabIndex = 2;
            this.SelectingFunction.Text = "Не выбрано";
            this.SelectingFunction.SelectedIndexChanged += new System.EventHandler(this.SelectingFunction_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Функция";
            // 
            // button2
            // 
            this.button2.Image = global::Charts.Properties.Resources._11;
            this.button2.Location = new System.Drawing.Point(220, 667);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 49);
            this.button2.TabIndex = 26;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Charts.Properties.Resources.minus;
            this.button1.Location = new System.Drawing.Point(11, 667);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 50);
            this.button1.TabIndex = 25;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(682, 667);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 49);
            this.button3.TabIndex = 27;
            this.button3.Text = "Открыть таблицу";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Percent
            // 
            this.Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percent.Location = new System.Drawing.Point(65, 687);
            this.Percent.Margin = new System.Windows.Forms.Padding(0);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(149, 43);
            this.Percent.TabIndex = 28;
            this.Percent.Text = "1:1";
            this.Percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PercentScrolling
            // 
            this.PercentScrolling.AutoSize = false;
            this.PercentScrolling.BackColor = System.Drawing.SystemColors.Control;
            this.PercentScrolling.Location = new System.Drawing.Point(65, 667);
            this.PercentScrolling.Name = "PercentScrolling";
            this.PercentScrolling.Size = new System.Drawing.Size(149, 30);
            this.PercentScrolling.TabIndex = 29;
            this.PercentScrolling.Scroll += new System.EventHandler(this.PercentScrolling_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(319, 696);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(33, 20);
            this.textBox1.TabIndex = 30;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(280, 696);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(33, 20);
            this.textBox2.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(292, 680);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "x";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(331, 680);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "y";
            // 
            // CenterO
            // 
            this.CenterO.Location = new System.Drawing.Point(275, 667);
            this.CenterO.Name = "CenterO";
            this.CenterO.Size = new System.Drawing.Size(85, 13);
            this.CenterO.TabIndex = 25;
            this.CenterO.Text = "Центр экрана";
            this.CenterO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(872, 720);
            this.Controls.Add(this.CenterO);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PercentScrolling);
            this.Controls.Add(this.Percent);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Opacity = 0.97D;
            this.Text = "Charts";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AreaPaint)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PercentScrolling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox FinalExpression;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Percent;
        private System.Windows.Forms.TrackBar PercentScrolling;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label CenterO;
    }
}

