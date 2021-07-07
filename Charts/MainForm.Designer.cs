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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AreaPaint = new System.Windows.Forms.PictureBox();
            this.viewTable = new System.Windows.Forms.Panel();
            this.nowTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableC = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.choice = new System.Windows.Forms.Panel();
            this.tableR = new System.Windows.Forms.RadioButton();
            this.functionR = new System.Windows.Forms.RadioButton();
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
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomPanelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GraphFunctionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GraphAdditionalFunctionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AreaPaint)).BeginInit();
            this.viewTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nowTable)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableC)).BeginInit();
            this.choice.SuspendLayout();
            this.functionsС.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PercentScrolling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedSlow)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.AreaPaint, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.viewTable, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1084, 667);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // AreaPaint
            // 
            this.AreaPaint.BackColor = System.Drawing.Color.White;
            this.AreaPaint.Cursor = System.Windows.Forms.Cursors.Cross;
            this.AreaPaint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AreaPaint.Location = new System.Drawing.Point(10, 10);
            this.AreaPaint.Margin = new System.Windows.Forms.Padding(0);
            this.AreaPaint.Name = "AreaPaint";
            this.AreaPaint.Size = new System.Drawing.Size(667, 647);
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
            this.viewTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewTable.Location = new System.Drawing.Point(880, 10);
            this.viewTable.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.viewTable.Name = "viewTable";
            this.viewTable.Size = new System.Drawing.Size(194, 647);
            this.viewTable.TabIndex = 26;
            this.viewTable.Visible = false;
            // 
            // nowTable
            // 
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(189)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(189)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.nowTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.nowTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(205)))), ((int)(((byte)(184)))));
            this.nowTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nowTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.nowTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nowTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.nowTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nowTable.EnableHeadersVisualStyles = false;
            this.nowTable.Location = new System.Drawing.Point(0, 0);
            this.nowTable.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.nowTable.Name = "nowTable";
            this.nowTable.RowHeadersWidth = 20;
            this.nowTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.nowTable.Size = new System.Drawing.Size(192, 645);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableC, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.choice, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.functionsС, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(680, 10);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(197, 647);
            this.tableLayoutPanel2.TabIndex = 27;
            // 
            // tableC
            // 
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(189)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.tableC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle23;
            this.tableC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(205)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.tableC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tableC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableC.EnableHeadersVisualStyles = false;
            this.tableC.Location = new System.Drawing.Point(3, 215);
            this.tableC.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableC.Name = "tableC";
            this.tableC.RowHeadersWidth = 20;
            this.tableC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tableC.Size = new System.Drawing.Size(191, 432);
            this.tableC.TabIndex = 9;
            this.tableC.Visible = false;
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
            // choice
            // 
            this.choice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(205)))), ((int)(((byte)(184)))));
            this.choice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.choice.Controls.Add(this.tableR);
            this.choice.Controls.Add(this.functionR);
            this.choice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.choice.Location = new System.Drawing.Point(3, 0);
            this.choice.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.choice.Name = "choice";
            this.choice.Size = new System.Drawing.Size(191, 43);
            this.choice.TabIndex = 4;
            this.choice.Visible = false;
            // 
            // tableR
            // 
            this.tableR.AutoSize = true;
            this.tableR.Location = new System.Drawing.Point(74, 5);
            this.tableR.Name = "tableR";
            this.tableR.Size = new System.Drawing.Size(112, 30);
            this.tableR.TabIndex = 3;
            this.tableR.Text = "Изменённая \r\nтаблица функции";
            this.tableR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tableR.UseVisualStyleBackColor = true;
            this.tableR.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // functionR
            // 
            this.functionR.AutoSize = true;
            this.functionR.Checked = true;
            this.functionR.Cursor = System.Windows.Forms.Cursors.Default;
            this.functionR.Location = new System.Drawing.Point(1, 12);
            this.functionR.Name = "functionR";
            this.functionR.Size = new System.Drawing.Size(71, 17);
            this.functionR.TabIndex = 2;
            this.functionR.TabStop = true;
            this.functionR.Text = "Функция";
            this.functionR.UseVisualStyleBackColor = true;
            this.functionR.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
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
            this.functionsС.Location = new System.Drawing.Point(3, 49);
            this.functionsС.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.functionsС.Name = "functionsС";
            this.functionsС.Size = new System.Drawing.Size(191, 163);
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
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Charts.Properties.Resources._11;
            this.button2.Location = new System.Drawing.Point(218, 10);
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
            this.button1.Location = new System.Drawing.Point(12, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 50);
            this.button1.TabIndex = 25;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openTable
            // 
            this.openTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.openTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.openTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openTable.Location = new System.Drawing.Point(905, 15);
            this.openTable.Margin = new System.Windows.Forms.Padding(5, 3, 10, 3);
            this.openTable.Name = "openTable";
            this.openTable.Size = new System.Drawing.Size(169, 49);
            this.openTable.TabIndex = 27;
            this.openTable.Text = "Открыть таблицу\r\nфункции";
            this.openTable.UseVisualStyleBackColor = false;
            this.openTable.Click += new System.EventHandler(this.button3_Click);
            // 
            // Percent
            // 
            this.Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percent.Location = new System.Drawing.Point(66, 32);
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
            this.PercentScrolling.Location = new System.Drawing.Point(66, 12);
            this.PercentScrolling.Name = "PercentScrolling";
            this.PercentScrolling.Size = new System.Drawing.Size(149, 30);
            this.PercentScrolling.TabIndex = 10;
            this.PercentScrolling.Scroll += new System.EventHandler(this.PercentScrolling_Scroll);
            // 
            // CentralY
            // 
            this.CentralY.Location = new System.Drawing.Point(344, 46);
            this.CentralY.Name = "CentralY";
            this.CentralY.Size = new System.Drawing.Size(33, 20);
            this.CentralY.TabIndex = 30;
            this.CentralY.TextChanged += new System.EventHandler(this.CentralY_TextChanged);
            // 
            // CentralX
            // 
            this.CentralX.Location = new System.Drawing.Point(305, 46);
            this.CentralX.Name = "CentralX";
            this.CentralX.Size = new System.Drawing.Size(33, 20);
            this.CentralX.TabIndex = 25;
            this.CentralX.TextChanged += new System.EventHandler(this.CentralX_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(315, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "x";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(355, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "y";
            // 
            // CenterO
            // 
            this.CenterO.Location = new System.Drawing.Point(287, 16);
            this.CenterO.Name = "CenterO";
            this.CenterO.Size = new System.Drawing.Size(115, 13);
            this.CenterO.TabIndex = 25;
            this.CenterO.Text = "Центр экрана";
            this.CenterO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SlowDrawing
            // 
            this.SlowDrawing.AutoSize = true;
            this.SlowDrawing.Location = new System.Drawing.Point(420, 14);
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
            this.label14.Location = new System.Drawing.Point(620, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 25);
            this.label14.TabIndex = 35;
            this.label14.Text = "Мышь";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coordinates
            // 
            this.coordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coordinates.Location = new System.Drawing.Point(595, 39);
            this.coordinates.Name = "coordinates";
            this.coordinates.Size = new System.Drawing.Size(161, 20);
            this.coordinates.TabIndex = 36;
            this.coordinates.Text = "Не в зоны действия";
            this.coordinates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(743, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 25);
            this.label15.TabIndex = 37;
            this.label15.Text = "Точек на графике";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PointsGraph
            // 
            this.PointsGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointsGraph.Location = new System.Drawing.Point(762, 39);
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
            this.SpeedSlow.Location = new System.Drawing.Point(420, 37);
            this.SpeedSlow.Name = "SpeedSlow";
            this.SpeedSlow.Size = new System.Drawing.Size(169, 30);
            this.SpeedSlow.TabIndex = 39;
            this.SpeedSlow.Visible = false;
            this.SpeedSlow.Scroll += new System.EventHandler(this.SpeedSlow_Scroll);
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveMenuItem,
            this.LoadMenuItem,
            this.ExitMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileMenuItem.Text = "Файл";
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveMenuItem.Text = "Сохранить";
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // LoadMenuItem
            // 
            this.LoadMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
            this.LoadMenuItem.Name = "LoadMenuItem";
            this.LoadMenuItem.Size = new System.Drawing.Size(180, 22);
            this.LoadMenuItem.Text = "Загрузить";
            this.LoadMenuItem.Click += new System.EventHandler(this.LoadMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitMenuItem.Text = "Выход";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.ViewMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ViewMenuItem
            // 
            this.ViewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BottomPanelMenuItem,
            this.TableMenuItem,
            this.ColorMenuItem});
            this.ViewMenuItem.Name = "ViewMenuItem";
            this.ViewMenuItem.Size = new System.Drawing.Size(39, 20);
            this.ViewMenuItem.Text = "Вид";
            // 
            // BottomPanelMenuItem
            // 
            this.BottomPanelMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
            this.BottomPanelMenuItem.Checked = true;
            this.BottomPanelMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BottomPanelMenuItem.Name = "BottomPanelMenuItem";
            this.BottomPanelMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BottomPanelMenuItem.Text = "Нижняя панель";
            this.BottomPanelMenuItem.Click += new System.EventHandler(this.BottomPanelMenuItem_Click);
            // 
            // TableMenuItem
            // 
            this.TableMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
            this.TableMenuItem.Name = "TableMenuItem";
            this.TableMenuItem.Size = new System.Drawing.Size(180, 22);
            this.TableMenuItem.Text = "Таблица";
            this.TableMenuItem.Click += new System.EventHandler(this.TableMenuItem_Click);
            // 
            // ColorMenuItem
            // 
            this.ColorMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
            this.ColorMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GraphFunctionMenuItem,
            this.GraphAdditionalFunctionsMenuItem});
            this.ColorMenuItem.Name = "ColorMenuItem";
            this.ColorMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ColorMenuItem.Text = "Цвета";
            // 
            // GraphFunctionMenuItem
            // 
            this.GraphFunctionMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
            this.GraphFunctionMenuItem.Name = "GraphFunctionMenuItem";
            this.GraphFunctionMenuItem.Size = new System.Drawing.Size(261, 22);
            this.GraphFunctionMenuItem.Text = "График функции";
            this.GraphFunctionMenuItem.Click += new System.EventHandler(this.GraphFunctionMenuItem_Click);
            // 
            // GraphAdditionalFunctionsMenuItem
            // 
            this.GraphAdditionalFunctionsMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
            this.GraphAdditionalFunctionsMenuItem.Name = "GraphAdditionalFunctionsMenuItem";
            this.GraphAdditionalFunctionsMenuItem.Size = new System.Drawing.Size(261, 22);
            this.GraphAdditionalFunctionsMenuItem.Text = "График корректировкой функции";
            this.GraphAdditionalFunctionsMenuItem.Click += new System.EventHandler(this.GraphAdditionalFunctionsMenuItem_Click);
            // 
            // BottomPanel
            // 
            this.BottomPanel.ColumnCount = 2;
            this.BottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 900F));
            this.BottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottomPanel.Controls.Add(this.panel2, 0, 0);
            this.BottomPanel.Controls.Add(this.openTable, 1, 0);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomPanel.Location = new System.Drawing.Point(0, 667);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.RowCount = 1;
            this.BottomPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.BottomPanel.Size = new System.Drawing.Size(1084, 74);
            this.BottomPanel.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.SpeedSlow);
            this.panel2.Controls.Add(this.PercentScrolling);
            this.panel2.Controls.Add(this.PointsGraph);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.Percent);
            this.panel2.Controls.Add(this.coordinates);
            this.panel2.Controls.Add(this.CentralY);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.CentralX);
            this.panel2.Controls.Add(this.SlowDrawing);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.CenterO);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 80);
            this.panel2.TabIndex = 10;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.BottomPanel, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1084, 741);
            this.tableLayoutPanel4.TabIndex = 42;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1084, 765);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1100, 800);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Charts";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AreaPaint)).EndInit();
            this.viewTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nowTable)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableC)).EndInit();
            this.choice.ResumeLayout(false);
            this.choice.PerformLayout();
            this.functionsС.ResumeLayout(false);
            this.functionsС.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PercentScrolling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedSlow)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
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
        private System.Windows.Forms.Panel choice;
        private System.Windows.Forms.RadioButton tableR;
        private System.Windows.Forms.RadioButton functionR;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel BottomPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView tableC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ToolStripMenuItem ViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BottomPanelMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TableMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GraphFunctionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GraphAdditionalFunctionsMenuItem;
    }
}

