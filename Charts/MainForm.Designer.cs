namespace Сharts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableR = new System.Windows.Forms.RadioButton();
            this.functionR = new System.Windows.Forms.RadioButton();
            this.tableC = new System.Windows.Forms.Panel();
            this.blockTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functionsС = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Draw = new System.Windows.Forms.Button();
            this.functionMain = new System.Windows.Forms.TextBox();
            this.LimitationUpY = new System.Windows.Forms.TextBox();
            this.LimitationUpX = new System.Windows.Forms.TextBox();
            this.LimitationDownY = new System.Windows.Forms.TextBox();
            this.LimitationDownX = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AreaPaint = new System.Windows.Forms.PictureBox();
            this.viewTable = new System.Windows.Forms.Panel();
            this.nowTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openTable = new System.Windows.Forms.Button();
            this.Percent = new System.Windows.Forms.Label();
            this.PercentScrolling = new System.Windows.Forms.TrackBar();
            this.CentralY = new System.Windows.Forms.TextBox();
            this.CentralX = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CenterO = new System.Windows.Forms.Label();
            this.SlowDrawing = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.coordinates = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.PointsGraph = new System.Windows.Forms.Label();
            this.SpeedSlow = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blockTable)).BeginInit();
            this.functionsС.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AreaPaint)).BeginInit();
            this.viewTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nowTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PercentScrolling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedSlow)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Beige;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AreaPaint, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.viewTable, 2, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 35);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1060, 686);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableC, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.functionsС, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(663, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(194, 680);
            this.tableLayoutPanel2.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(205)))), ((int)(((byte)(184)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableR);
            this.panel1.Controls.Add(this.functionR);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 43);
            this.panel1.TabIndex = 4;
            // 
            // tableR
            // 
            this.tableR.AutoSize = true;
            this.tableR.Location = new System.Drawing.Point(99, 12);
            this.tableR.Name = "tableR";
            this.tableR.Size = new System.Drawing.Size(68, 17);
            this.tableR.TabIndex = 3;
            this.tableR.Text = "Таблица";
            this.tableR.UseVisualStyleBackColor = true;
            this.tableR.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // functionR
            // 
            this.functionR.AutoSize = true;
            this.functionR.Checked = true;
            this.functionR.Cursor = System.Windows.Forms.Cursors.Default;
            this.functionR.Location = new System.Drawing.Point(6, 12);
            this.functionR.Name = "functionR";
            this.functionR.Size = new System.Drawing.Size(71, 17);
            this.functionR.TabIndex = 2;
            this.functionR.TabStop = true;
            this.functionR.Text = "Функции";
            this.functionR.UseVisualStyleBackColor = true;
            this.functionR.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // tableC
            // 
            this.tableC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(205)))), ((int)(((byte)(184)))));
            this.tableC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableC.Controls.Add(this.blockTable);
            this.tableC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableC.Location = new System.Drawing.Point(3, 221);
            this.tableC.Name = "tableC";
            this.tableC.Size = new System.Drawing.Size(188, 458);
            this.tableC.TabIndex = 6;
            this.tableC.Visible = false;
            // 
            // blockTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(189)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.blockTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.blockTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(205)))), ((int)(((byte)(184)))));
            this.blockTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.blockTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.blockTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.blockTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.blockTable.EnableHeadersVisualStyles = false;
            this.blockTable.Location = new System.Drawing.Point(0, 0);
            this.blockTable.Name = "blockTable";
            this.blockTable.RowHeadersWidth = 20;
            this.blockTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.blockTable.Size = new System.Drawing.Size(186, 377);
            this.blockTable.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "X";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 73;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 73;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.HeaderText = "Y";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 73;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 73;
            // 
            // functionsС
            // 
            this.functionsС.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(205)))), ((int)(((byte)(184)))));
            this.functionsС.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.functionsС.Controls.Add(this.label2);
            this.functionsС.Controls.Add(this.Draw);
            this.functionsС.Controls.Add(this.functionMain);
            this.functionsС.Controls.Add(this.LimitationUpY);
            this.functionsС.Controls.Add(this.LimitationUpX);
            this.functionsС.Controls.Add(this.LimitationDownY);
            this.functionsС.Controls.Add(this.LimitationDownX);
            this.functionsС.Controls.Add(this.label10);
            this.functionsС.Controls.Add(this.label9);
            this.functionsС.Controls.Add(this.label8);
            this.functionsС.Controls.Add(this.label1);
            this.functionsС.Dock = System.Windows.Forms.DockStyle.Fill;
            this.functionsС.Location = new System.Drawing.Point(3, 52);
            this.functionsС.Name = "functionsС";
            this.functionsС.Size = new System.Drawing.Size(188, 163);
            this.functionsС.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "y =";
            // 
            // Draw
            // 
            this.Draw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Draw.Location = new System.Drawing.Point(53, 133);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(79, 23);
            this.Draw.TabIndex = 24;
            this.Draw.Text = "Начертить";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // functionMain
            // 
            this.functionMain.Location = new System.Drawing.Point(21, 29);
            this.functionMain.Name = "functionMain";
            this.functionMain.Size = new System.Drawing.Size(162, 20);
            this.functionMain.TabIndex = 24;
            // 
            // LimitationUpY
            // 
            this.LimitationUpY.Location = new System.Drawing.Point(96, 107);
            this.LimitationUpY.Name = "LimitationUpY";
            this.LimitationUpY.Size = new System.Drawing.Size(87, 20);
            this.LimitationUpY.TabIndex = 21;
            this.LimitationUpY.TextChanged += new System.EventHandler(this.Limitation_TextChanged);
            // 
            // LimitationUpX
            // 
            this.LimitationUpX.Location = new System.Drawing.Point(3, 107);
            this.LimitationUpX.Name = "LimitationUpX";
            this.LimitationUpX.Size = new System.Drawing.Size(87, 20);
            this.LimitationUpX.TabIndex = 20;
            this.LimitationUpX.TextChanged += new System.EventHandler(this.Limitation_TextChanged);
            // 
            // LimitationDownY
            // 
            this.LimitationDownY.Location = new System.Drawing.Point(96, 81);
            this.LimitationDownY.Name = "LimitationDownY";
            this.LimitationDownY.Size = new System.Drawing.Size(87, 20);
            this.LimitationDownY.TabIndex = 19;
            this.LimitationDownY.TextChanged += new System.EventHandler(this.Limitation_TextChanged);
            // 
            // LimitationDownX
            // 
            this.LimitationDownX.Location = new System.Drawing.Point(3, 81);
            this.LimitationDownX.Name = "LimitationDownX";
            this.LimitationDownX.Size = new System.Drawing.Size(87, 20);
            this.LimitationDownX.TabIndex = 18;
            this.LimitationDownX.TextChanged += new System.EventHandler(this.Limitation_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(138, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "x";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ограничения";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Функция";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AreaPaint
            // 
            this.AreaPaint.BackColor = System.Drawing.Color.White;
            this.AreaPaint.Cursor = System.Windows.Forms.Cursors.Cross;
            this.AreaPaint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AreaPaint.Location = new System.Drawing.Point(0, 0);
            this.AreaPaint.Margin = new System.Windows.Forms.Padding(0);
            this.AreaPaint.Name = "AreaPaint";
            this.AreaPaint.Size = new System.Drawing.Size(660, 686);
            this.AreaPaint.TabIndex = 0;
            this.AreaPaint.TabStop = false;
            this.AreaPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.AreaPaint_Paint);
            this.AreaPaint.MouseLeave += new System.EventHandler(this.AreaPaint_MouseLeave);
            this.AreaPaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AreaPaint_MouseMove);
            // 
            // viewTable
            // 
            this.viewTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(205)))), ((int)(((byte)(184)))));
            this.viewTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewTable.Controls.Add(this.nowTable);
            this.viewTable.Location = new System.Drawing.Point(863, 3);
            this.viewTable.Name = "viewTable";
            this.viewTable.Size = new System.Drawing.Size(194, 680);
            this.viewTable.TabIndex = 26;
            this.viewTable.Visible = false;
            // 
            // nowTable
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(189)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(189)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.nowTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.nowTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(205)))), ((int)(((byte)(184)))));
            this.nowTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nowTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.nowTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nowTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.nowTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nowTable.EnableHeadersVisualStyles = false;
            this.nowTable.Location = new System.Drawing.Point(0, 0);
            this.nowTable.Name = "nowTable";
            this.nowTable.RowHeadersWidth = 20;
            this.nowTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.nowTable.Size = new System.Drawing.Size(192, 678);
            this.nowTable.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "X";
            this.Column1.MinimumWidth = 76;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 76;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.HeaderText = "Y";
            this.Column2.MinimumWidth = 76;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 76;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Charts.Properties.Resources._11;
            this.button2.Location = new System.Drawing.Point(225, 737);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 49);
            this.button2.TabIndex = 26;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Charts.Properties.Resources.minus;
            this.button1.Location = new System.Drawing.Point(16, 737);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 50);
            this.button1.TabIndex = 25;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openTable
            // 
            this.openTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.openTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openTable.Location = new System.Drawing.Point(897, 738);
            this.openTable.Name = "openTable";
            this.openTable.Size = new System.Drawing.Size(159, 49);
            this.openTable.TabIndex = 27;
            this.openTable.Text = "Открыть таблицу";
            this.openTable.UseVisualStyleBackColor = false;
            this.openTable.Click += new System.EventHandler(this.button3_Click);
            // 
            // Percent
            // 
            this.Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percent.Location = new System.Drawing.Point(70, 757);
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
            this.PercentScrolling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
            this.PercentScrolling.Location = new System.Drawing.Point(70, 737);
            this.PercentScrolling.Name = "PercentScrolling";
            this.PercentScrolling.Size = new System.Drawing.Size(149, 30);
            this.PercentScrolling.TabIndex = 10;
            this.PercentScrolling.Scroll += new System.EventHandler(this.PercentScrolling_Scroll);
            // 
            // CentralY
            // 
            this.CentralY.Location = new System.Drawing.Point(348, 770);
            this.CentralY.Name = "CentralY";
            this.CentralY.Size = new System.Drawing.Size(33, 20);
            this.CentralY.TabIndex = 30;
            this.CentralY.TextChanged += new System.EventHandler(this.CentralY_TextChanged);
            // 
            // CentralX
            // 
            this.CentralX.Location = new System.Drawing.Point(309, 770);
            this.CentralX.Name = "CentralX";
            this.CentralX.Size = new System.Drawing.Size(33, 20);
            this.CentralX.TabIndex = 25;
            this.CentralX.TextChanged += new System.EventHandler(this.CentralX_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(319, 754);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "x";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(359, 754);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "y";
            // 
            // CenterO
            // 
            this.CenterO.Location = new System.Drawing.Point(291, 740);
            this.CenterO.Name = "CenterO";
            this.CenterO.Size = new System.Drawing.Size(115, 13);
            this.CenterO.TabIndex = 25;
            this.CenterO.Text = "Центр экрана";
            this.CenterO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SlowDrawing
            // 
            this.SlowDrawing.AutoSize = true;
            this.SlowDrawing.Location = new System.Drawing.Point(424, 738);
            this.SlowDrawing.Name = "SlowDrawing";
            this.SlowDrawing.Size = new System.Drawing.Size(179, 17);
            this.SlowDrawing.TabIndex = 31;
            this.SlowDrawing.Text = "Медленый режим прорисовки";
            this.SlowDrawing.UseVisualStyleBackColor = true;
            this.SlowDrawing.CheckedChanged += new System.EventHandler(this.SlowDrawing_CheckedChanged);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(628, 738);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 25);
            this.label14.TabIndex = 35;
            this.label14.Text = "Мышь";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coordinates
            // 
            this.coordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coordinates.Location = new System.Drawing.Point(599, 769);
            this.coordinates.Name = "coordinates";
            this.coordinates.Size = new System.Drawing.Size(161, 20);
            this.coordinates.TabIndex = 36;
            this.coordinates.Text = "Не в зоны действия";
            this.coordinates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(747, 734);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 25);
            this.label15.TabIndex = 37;
            this.label15.Text = "Точек на графике";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PointsGraph
            // 
            this.PointsGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointsGraph.Location = new System.Drawing.Point(766, 769);
            this.PointsGraph.Name = "PointsGraph";
            this.PointsGraph.Size = new System.Drawing.Size(103, 20);
            this.PointsGraph.TabIndex = 38;
            this.PointsGraph.Text = "0";
            this.PointsGraph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpeedSlow
            // 
            this.SpeedSlow.AutoSize = false;
            this.SpeedSlow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
            this.SpeedSlow.Location = new System.Drawing.Point(424, 761);
            this.SpeedSlow.Name = "SpeedSlow";
            this.SpeedSlow.Size = new System.Drawing.Size(169, 30);
            this.SpeedSlow.TabIndex = 39;
            this.SpeedSlow.Visible = false;
            this.SpeedSlow.Scroll += new System.EventHandler(this.SpeedSlow_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(205)))), ((int)(((byte)(184)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 24);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveMenuItem,
            this.LoadMenuItem,
            this.ExitMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveMenuItem.Text = "Сохранить";
            // 
            // LoadMenuItem
            // 
            this.LoadMenuItem.Name = "LoadMenuItem";
            this.LoadMenuItem.Size = new System.Drawing.Size(180, 22);
            this.LoadMenuItem.Text = "Загрузить";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitMenuItem.Text = "Выход";
            this.ExitMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1082, 804);
            this.Controls.Add(this.SpeedSlow);
            this.Controls.Add(this.PointsGraph);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.coordinates);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.SlowDrawing);
            this.Controls.Add(this.CenterO);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CentralX);
            this.Controls.Add(this.openTable);
            this.Controls.Add(this.CentralY);
            this.Controls.Add(this.PercentScrolling);
            this.Controls.Add(this.Percent);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Charts";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.blockTable)).EndInit();
            this.functionsС.ResumeLayout(false);
            this.functionsС.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AreaPaint)).EndInit();
            this.viewTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nowTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PercentScrolling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedSlow)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox AreaPaint;
        private System.Windows.Forms.Panel functionsС;
        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.TextBox LimitationUpY;
        private System.Windows.Forms.TextBox LimitationUpX;
        private System.Windows.Forms.TextBox LimitationDownY;
        private System.Windows.Forms.TextBox LimitationDownX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button openTable;
        private System.Windows.Forms.Label Percent;
        private System.Windows.Forms.TrackBar PercentScrolling;
        private System.Windows.Forms.TextBox CentralY;
        private System.Windows.Forms.TextBox CentralX;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label CenterO;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton tableR;
        private System.Windows.Forms.RadioButton functionR;
        private System.Windows.Forms.Panel tableC;
        private System.Windows.Forms.Panel viewTable;
        private System.Windows.Forms.CheckBox SlowDrawing;
        private System.Windows.Forms.DataGridView nowTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label coordinates;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label PointsGraph;
        private System.Windows.Forms.TrackBar SpeedSlow;
        private System.Windows.Forms.TextBox functionMain;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView blockTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
    }
}

