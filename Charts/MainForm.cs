using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сharts
{
    public partial class MainForm : Form
    {
        List<PointF[]> dopSegments = new List<PointF[]>();
        PointF[] dopPoints = new PointF[0];
        Color colorMainFunctoin, colorAdditionalFunction;
        int centralX, centralY, plusM;
        bool slow, stopSlowDrawing;
        bool tableupdate;
        bool movePoint;
        int slowspeed;
        Point movingPoint;
        int idxPoint;
        bool moveP;

        public MainForm()
        {
            InitializeComponent();
            movePoint = false;
            moveP = false;
            plusM = 1;
            slow = false;
            stopSlowDrawing = true;
            tableupdate = true;
            slowspeed = 10;
            centralX += 100;
            colorMainFunctoin = Color.Black;
            colorAdditionalFunction = Color.Red;
        }

        private void AreaPaint_Paint(object sender, PaintEventArgs e)
        {
            Сharts.Paint.DrawLine(e, Color.Black, new Point(0, 0), new Point(AreaPaint.Width, 0));
            Сharts.Paint.DrawLine(e, Color.Black, new Point(0, AreaPaint.Height - 1), new Point(AreaPaint.Width, AreaPaint.Height - 1));
            Сharts.Paint.DrawLine(e, Color.Black, new Point(0, 0), new Point(0, AreaPaint.Height));
            Сharts.Paint.DrawLine(e, Color.Black, new Point(AreaPaint.Width - 1, 0), new Point(AreaPaint.Width - 1, AreaPaint.Height));
            Сharts.Paint.DrawPoint(e, Color.Brown, new Point(centralX, centralY));
            Сharts.Paint.DrawLine(e, Color.Brown, new Point(centralX, 0), new Point(centralX, AreaPaint.Height));
            Сharts.Paint.DrawLine(e, Color.Brown, new Point(0, centralY), new Point(AreaPaint.Width, centralY));
            if (plusM > 8)
            {
                for (int i = AreaPaint.Width/2; i < AreaPaint.Width; i += plusM)
                {
                    e.Graphics.DrawLine(new Pen(Color.Brown, 1), new Point(i + plusM, 0), new Point(i + plusM, AreaPaint.Height));
                }
                for (int i = AreaPaint.Width / 2; i > -plusM; i -= plusM)
                {
                    e.Graphics.DrawLine(new Pen(Color.Brown, 1), new Point(i + plusM, 0), new Point(i + plusM, AreaPaint.Height));
                }
                for (int f = AreaPaint.Height / 2; f < AreaPaint.Height; f += plusM)
                {
                    e.Graphics.DrawLine(new Pen(Color.Brown, 1), new Point(0, f + plusM), new Point(AreaPaint.Width, f + plusM));
                }
                for (int f = AreaPaint.Height / 2; f > -plusM; f -= plusM)
                {
                    e.Graphics.DrawLine(new Pen(Color.Brown, 1), new Point(0, f + plusM), new Point(AreaPaint.Width, f + plusM));
                }
            }
            PaintChart(e.Graphics);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CentralXChanged();
            CentralYChanged();
            AreaPaint.Refresh();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            ForStopSlow();
            CentralXChanged();
            CentralYChanged();
            AreaPaint.Refresh();
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "GREBIAR |*.grebiar;";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = File.Open(saveFileDialog.FileName, FileMode.Create);
                StreamWriter output = new StreamWriter(fileStream);
                if(!string.IsNullOrEmpty(functionMain.Text))
                {
                    output.Write(functionMain.Text);
                }
                output.Close();
            }
        }

        private void LoadMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "GREBIAR |*.grebiar;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream file = new FileStream(openFileDialog.FileName, FileMode.Open);
                StreamReader reader = new StreamReader(file);
                try
                {
                    string data = reader.ReadToEnd();
                    functionMain.Text = data;
                }
                catch
                {
                    MessageBox.Show("Файл повреждён");
                }
                reader.Close();
            }
            AreaPaint.Refresh();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BottomPanelMenuItem_Click(object sender, EventArgs e)
        {
            BottomPanelMenuItem.Checked = !BottomPanelMenuItem.Checked;
            BottomPanel.Visible = BottomPanelMenuItem.Checked;
            CentralXChanged();
            CentralYChanged();
            ForStopSlow();
            AreaPaint.Refresh();
        }

        private void OpenTable(object sender, EventArgs e)
        {
            TableMenuItem.Checked = !TableMenuItem.Checked;
            viewTable.Visible = TableMenuItem.Checked;
            if (viewTable.Visible)
            {
                openTable.Text = "Закрыть таблицу\nфункции";
            }
            else
            {
                openTable.Text = "Открыть таблицу\nфункции";
            }
            CentralXChanged();
            CentralYChanged();
            ForStopSlow();
            AreaPaint.Refresh();
        }

        private void GraphFunctionMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.AllowFullOpen = false;
            if (color.ShowDialog() == DialogResult.OK)
            {
                colorMainFunctoin = color.Color;
            }
            ForStopSlow();
            AreaPaint.Refresh();
        }

        private void GraphAdditionalFunctionsMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.AllowFullOpen = false;
            if (color.ShowDialog() == DialogResult.OK)
            {
                colorAdditionalFunction = color.Color;
            }
            ForStopSlow();
            AreaPaint.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (plusM > 1)
            {
                ForStopSlow();
                plusM -= 1;
                PercentScrolling.Value = plusM / (11);
                Percent.Text = "1:" + plusM;
                CentralXChanged();
                CentralYChanged();
                AreaPaint.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (plusM < 110)
            {
                ForStopSlow();
                plusM += 1;
                PercentScrolling.Value = plusM / (11);
                Percent.Text = "1:" + plusM;
                CentralXChanged();
                CentralYChanged();
                AreaPaint.Refresh();
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            functionsС.Visible = functionR.Checked;
            tableC.Visible = tableR.Checked;
            if (functionsС.Visible)
            {
                dopSegments = new List<PointF[]>();
                moveP = false;
                tableupdate = false;
                AreaPaint.Refresh();
                tableupdate = true;
                ChartsMenuItem.Visible = false;
                AdditionalMenuItem.Checked = true;
                MainMenuItem.Checked = true;
            }
            else
            {
                ChartsMenuItem.Visible = true;
            }
        }

        private void SlowDrawing_CheckedChanged(object sender, EventArgs e)
        {
            stopSlowDrawing = false;
            slow = SlowDrawing.Checked;
            SpeedSlow.Visible = SlowDrawing.Checked;
            AreaPaint.Refresh();
        }

        private void SpeedSlow_Scroll(object sender, EventArgs e)
        {
            if (SpeedSlow.Value == 0)
            {
                slowspeed = 15;
            }
            else
            {
                slowspeed = SpeedSlow.Value * 15;
            }
        }

        private void AreaPaint_MouseDown(object sender, MouseEventArgs e)
        {
            if(tableR.Checked)
            {
                float coorX = (float)Math.Round((float)(e.X - centralX) / plusM);
                float coorY = (float)Math.Round((float)(centralY - e.Y) / plusM);
                movePoint = true;
                for(int i = 0;i<dopSegments.Count;i++)
                {
                    for (int f = 0; f < dopSegments[i].Length; f++)
                    {
                        if (Math.Round(dopSegments[i][f].X) == coorX && Math.Round(dopSegments[i][f].Y) == coorY)
                        {
                            movingPoint.X = i;
                            movingPoint.Y = f;
                            for(int z =0; z< tableA.RowCount;z++)
                            {
                                if(float.Parse(tableA.Rows[z].Cells[0].Value.ToString())== coorX && float.Parse(tableA.Rows[z].Cells[1].Value.ToString()) == coorY)
                                {
                                    idxPoint = z;
                                    break;
                                }
                            }
                            return;
                        }
                    }
                }
                movePoint = false;
            }
        }

        private void AreaPaint_MouseMove(object sender, MouseEventArgs e)
        {
            float coorX = ((float)(e.X - centralX)) / plusM;
            float coorY = ((float)(centralY - e.Y)) / plusM;
            
            if (movePoint)
            {
                dopSegments[movingPoint.X][movingPoint.Y].X = coorX;
                dopSegments[movingPoint.X][movingPoint.Y].Y = coorY;
                tableupdate = false;
                AreaPaint.Refresh();
                tableupdate = true;
            }
            coorX = (float)Math.Round(coorX, 3);
            coorY = (float)Math.Round(coorY, 3);
            coordinates.Text = "x = " + coorX.ToString() + ";  y = " + coorY.ToString() + ";";

            float sizeСircle = plusM / 5.5f + 30 / plusM;

            if (plusM < 9)
            {
                sizeСircle = 0;
            }
            if (!slow)
            {
                tableupdate = false;
                AreaPaint.Refresh();
                tableupdate = true;
                Graphics graphics = AreaPaint.CreateGraphics();
                graphics.FillEllipse(new SolidBrush(Color.FromArgb(0, 191, 255)), centralX - sizeСircle / 2 + coorX * plusM, centralY - sizeСircle / 2 - coorY * plusM, sizeСircle, sizeСircle);
            }
        }

        private void AreaPaint_MouseUp(object sender, MouseEventArgs e)
        {
            if (movePoint)
            {
                float coorX = ((float)(e.X - centralX)) / plusM;
                float coorY = ((float)(centralY - e.Y)) / plusM;
                coorX = (float)Math.Round(coorX, 0);
                coorY = (float)Math.Round(coorY, 0);
                tableA.Rows[idxPoint].Cells[0].Value = coorX;
                tableA.Rows[idxPoint].Cells[1].Value = coorY;
                dopPoints[idxPoint].X = coorX;
                dopPoints[idxPoint].Y = coorY;
                movePoint = false;
                tableupdate = false;
                AreaPaint.Refresh();
                tableupdate = true;
            }
        }

        private void tableA_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dopSegments.Count; i++)
            {
                for (int f = 0; f < dopSegments[i].Length; f++)
                {
                    if (dopSegments[i][f].X == dopPoints[e.RowIndex].X && dopSegments[i][f].Y == dopPoints[e.RowIndex].Y)
                    {
                        dopSegments[i][f].X = float.Parse(tableA.Rows[e.RowIndex].Cells[0].Value.ToString());
                        dopSegments[i][f].Y = float.Parse(tableA.Rows[e.RowIndex].Cells[1].Value.ToString());
                        dopPoints[e.RowIndex] = dopSegments[i][f];
                        tableupdate = false;
                        AreaPaint.Refresh();
                        tableupdate = true;
                        return;
                    }
                }
            }
            tableupdate = false;
            AreaPaint.Refresh();
            tableupdate = true;
        }

        private void AreaPaint_MouseLeave(object sender, EventArgs e)
        {
            coordinates.Text = "Не в зоны действия";
            if (!slow)
            {
                tableupdate = false;
                AreaPaint.Refresh();
                tableupdate = true;
            }
        }

        private void Limitation_TextChanged(object sender, EventArgs e)
        {
            GeneralRestrictions((TextBox)sender);
            AreaPaint.Refresh();
        }

        private void PercentScrolling_Scroll(object sender, EventArgs e)
        {
            ForStopSlow();
            if (PercentScrolling.Value != 0)
            {
                plusM = PercentScrolling.Value * 11;
                Percent.Text = "1:" + plusM;
                CentralXChanged();
                CentralYChanged();
            }
            else
            {
                plusM = 1;
                Percent.Text = "1:1";
                CentralXChanged();
                CentralYChanged();
            }
            AreaPaint.Refresh();
        }

        private void CentralX_TextChanged(object sender, EventArgs e)
        {
            ForStopSlow();
            CentralXChanged();
        }

        private void CentralY_TextChanged(object sender, EventArgs e)
        {
            ForStopSlow();
            CentralYChanged();
        }

        void CentralXChanged()
        {
            centralX = AreaPaint.Width / 2 - GeneralRestrictions(CentralX) * plusM;
        }

        void CentralYChanged()
        {
            centralY = AreaPaint.Height / 2 + GeneralRestrictions(CentralY) * plusM;
        }

        async void ForStopSlow()
        {
            stopSlowDrawing = true;
            await Task.Delay(slowspeed+100);
            stopSlowDrawing = false;
            AreaPaint.Refresh();
        }

        void PaintChart(Graphics graphics)
        {
            if(!string.IsNullOrEmpty(functionMain.Text))
            {
                int minY = -((AreaPaint.Height) / 2 / plusM + GeneralRestrictions(CentralY)) - 1;
                int limitationDownY;
                if (LimitationDownY.Text != "" && Int32.TryParse(LimitationDownY.Text, out limitationDownY))
                {
                    limitationDownY = -limitationDownY;
                    if (limitationDownY < minY)
                    {
                        limitationDownY = minY;
                    }
                }
                else
                {
                    limitationDownY = minY;
                }
                int limitationUpY = 0;
                int maxY = (AreaPaint.Height) / plusM + minY + 1;
                if (LimitationUpY.Text != "" && Int32.TryParse(LimitationUpY.Text, out limitationUpY))
                {
                    limitationUpY = -limitationUpY;
                    if (limitationUpY > maxY)
                    {
                        limitationUpY = maxY;
                    }
                }
                else
                {
                    limitationUpY = maxY;
                }
                int countAllPoint = 0;
                PointF[] allPoints = new PointF[AreaPaint.Width + plusM + 2];
                PointF[] temporaryPoint = new PointF[AreaPaint.Width + plusM + 2];
                int limitationDownX;
                float x = -(AreaPaint.Width / 2 / plusM - GeneralRestrictions(CentralX)) - 1;
                if (LimitationDownX.Text != "" && Int32.TryParse(LimitationDownX.Text, out limitationDownX))
                {
                    if (limitationDownX > x)
                    {
                        x = limitationDownX;
                    }
                }
                else
                {
                    limitationDownX = (int)x;
                }
                int limitationUpX;
                if (!Int32.TryParse(LimitationUpX.Text, out limitationUpX)&&LimitationUpX.Text == "")
                {
                    limitationUpX = 10000;
                }
                List<PointF[]> segments = new List<PointF[]>();
                Charts.TranslatingExpression translating = new Charts.TranslatingExpression();
                for (int i = 0; i < temporaryPoint.Length; i++)
                {
                    temporaryPoint[i] = new PointF(x, translating.Translating(functionMain.Text, x));
                    RemoveUnnecessary(temporaryPoint[i], ref allPoints, ref countAllPoint, limitationDownY, limitationUpY, segments, x);
                    x += 1 / (float)plusM;
                    if(x> limitationUpX)
                    {
                        break;
                    }
                }
                Array.Resize(ref allPoints, countAllPoint);
                if (countAllPoint > 1)
                {
                    segments.Add(allPoints);
                }
                SpeedDrawing(graphics, segments);
                if(tableupdate)
                {
                    tableCompletion();
                }
                int count = int.Parse(PointsGraph.Text);
                int length = 0;
                foreach(PointF[] points in segments)
                {
                    foreach (PointF point in points)
                    {
                        length++;
                    }
                    length -= 2;
                }
                MaxPoints.Text = (length-4).ToString();
            }
        }

        void RemoveUnnecessary(PointF point, ref PointF[] allPoints, ref int countAllPoint, int limitationDownY, int limitationUpY, List<PointF[]> segments, float x)
        {
            float checkedNumber = (point.Y);
            if (checkedNumber <= limitationUpY && checkedNumber >= limitationDownY)
            {
                if (countAllPoint == 0)
                {
                    Charts.TranslatingExpression translating = new Charts.TranslatingExpression();
                    PointF pointF = new PointF(point.X - (float)1 / (float)plusM, translating.Translating(functionMain.Text, point.X - (float)1 / (float)plusM));
                    if (!float.IsNaN(pointF.X) && !float.IsNaN(pointF.Y) && !float.IsInfinity(pointF.Y))
                    {
                        allPoints[countAllPoint] = pointF;
                        allPoints[countAllPoint].X = allPoints[countAllPoint].X * plusM + centralX;
                        allPoints[countAllPoint].Y = allPoints[countAllPoint].Y * plusM + centralY;
                        countAllPoint++;
                    }
                }
                if (countAllPoint < allPoints.Length)
                {
                    if (!float.IsNaN(point.X) && !float.IsNaN(point.Y) && !float.IsInfinity(point.Y))
                    {
                        allPoints[countAllPoint] = point;
                        allPoints[countAllPoint].X = allPoints[countAllPoint].X * plusM + centralX;
                        allPoints[countAllPoint].Y = allPoints[countAllPoint].Y * plusM + centralY;
                        countAllPoint++;
                    }
                }
            }
            else
            {
                if (countAllPoint > 1)
                {
                    Charts.TranslatingExpression translating = new Charts.TranslatingExpression();
                    PointF pointF = new PointF(x , translating.Translating(functionMain.Text, x));
                    if (!float.IsNaN(pointF.X) && !float.IsNaN(pointF.Y) && !float.IsInfinity(pointF.Y))
                    {
                        if (countAllPoint < allPoints.Length)
                        {
                            allPoints[countAllPoint] = pointF;
                            allPoints[countAllPoint].X = allPoints[countAllPoint].X * plusM + centralX;
                            allPoints[countAllPoint].Y = allPoints[countAllPoint].Y * plusM + centralY;
                            countAllPoint++;
                        }
                    }
                    Array.Resize(ref allPoints, countAllPoint);
                    segments.Add(allPoints);
                }
                allPoints = new PointF[AreaPaint.Width +plusM + 2];
                countAllPoint = 0;
            }
        }

        async void SpeedDrawing(Graphics graphics, List<PointF[]> segments)
        {
            if (segments.Count > 0 && MainMenuItem.Checked)
            {
                Pen pen = new Pen(colorMainFunctoin, 2f);
                if (!slow)
                {
                    foreach (PointF[] points in segments)
                    {
                        if(points.Length>1)
                        {
                            graphics.DrawLines(pen, points);
                        }
                    }
                }
                else
                {
                    foreach (PointF[] points in segments)
                    {
                        for(int i=0;i<points.Length-1;i++)
                        {
                            await Task.Delay(slowspeed);
                            graphics = AreaPaint.CreateGraphics();
                            graphics.DrawLine(pen, points[i], points[i + 1]);
                            if (!stopSlowDrawing)
                            {
                                await Task.Delay(slowspeed);
                                graphics = AreaPaint.CreateGraphics();
                                graphics.DrawLine(pen, points[i], points[i + 1]);
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                }
            }
            if(dopSegments.Count>0 && AdditionalMenuItem.Checked)
            {
                Pen pen = new Pen(colorAdditionalFunction, 2f);
                float sizeСircle = 5 + plusM / 11;
                foreach (PointF[] points in dopSegments)
                {
                    if (points.Length > 1)
                    {
                        for(int i=0;i<points.Length-1;i++)
                        {
                            PointF tempPoints = points[i];
                            tempPoints.X = (tempPoints.X * plusM) + centralX;
                            tempPoints.Y = -(tempPoints.Y * plusM) + centralY;
                            PointF tempPointsNext = points[i+1];
                            tempPointsNext.X = (tempPointsNext.X * plusM) + centralX;
                            tempPointsNext.Y = -(tempPointsNext.Y * plusM) + centralY;
                            graphics.DrawLine(pen, tempPoints, tempPointsNext);
                            graphics.FillEllipse(new SolidBrush(Color.FromArgb(0, 0, 255)), tempPoints.X - sizeСircle / 2, tempPoints.Y - sizeСircle / 2, sizeСircle, sizeСircle);
                        }
                        PointF tempPointsLast = points[points.Length-1];
                        tempPointsLast.X = (tempPointsLast.X * plusM) + centralX;
                        tempPointsLast.Y = -(tempPointsLast.Y * plusM) + centralY;
                        graphics.FillEllipse(new SolidBrush(Color.FromArgb(0, 0, 255)), tempPointsLast.X - sizeСircle / 2, tempPointsLast.Y - sizeСircle / 2, sizeСircle, sizeСircle);
                    }
                }
            }
            else if (moveP&&segments.Count > 0)
            {
                tableA.Rows.Clear();
                int minus = 0;
                int length = 0;
                foreach (PointF[] points in segments)
                {
                    foreach (PointF point in points)
                    {
                        length++;
                    }
                    length -= 2;
                    minus += 2;
                }
                float countP = 0; 
                if(float.TryParse(CountPoints.Text,out countP))
                {
                    if(countP- minus > 0)
                    {
                        countP = ((float)length-3*minus) / (countP- minus);
                    }
                    else
                    {
                        countP = -10;
                    }
                }
                else
                {
                    countP = 1;
                }
                Pen pen = new Pen(colorAdditionalFunction, 2f);
                if (!slow)
                {
                    float sizeСircle = 5 + plusM / 11;
                    foreach (PointF[] points in segments)
                    {
                        if (points.Length > 1)
                        {
                            PointF[] tempPoints = new PointF[points.Length];
                            int countTemp = 0;
                            float f = 2;
                            int lasti=0;
                            for (int i=2; i<points.Length-2; i++)
                            {
                                if(i==(int)(f+countP))
                                {
                                    tempPoints[countTemp] = points[i];
                                    tempPoints[countTemp].X = (float)Math.Round((tempPoints[countTemp].X - centralX) / plusM,3);
                                    tempPoints[countTemp].Y = (float)Math.Round(-(tempPoints[countTemp].Y - centralY) / plusM,3);
                                    tableA.Rows.Add(tempPoints[countTemp].X, tempPoints[countTemp].Y);
                                    countTemp++;
                                    if(AdditionalMenuItem.Checked)
                                    {
                                        graphics.DrawLine(pen, points[lasti], points[i]);
                                        graphics.FillEllipse(new SolidBrush(Color.FromArgb(0, 0, 255)), points[i].X - sizeСircle / 2, points[i].Y - sizeСircle / 2, sizeСircle, sizeСircle);
                                    }
                                    f += countP;
                                    lasti = i;
                                }
                                else if( i == 2 )
                                {
                                    tempPoints[countTemp] = points[i];
                                    tempPoints[countTemp].X = (float)Math.Round((tempPoints[countTemp].X - centralX) / plusM, 3);
                                    tempPoints[countTemp].Y = (float)Math.Round(-(tempPoints[countTemp].Y - centralY) / plusM, 3);
                                    tableA.Rows.Add(tempPoints[countTemp].X, tempPoints[countTemp].Y);
                                    countTemp++;
                                    if (AdditionalMenuItem.Checked)
                                    {
                                        graphics.FillEllipse(new SolidBrush(Color.FromArgb(0, 0, 255)), points[i].X - sizeСircle / 2, points[i].Y - sizeСircle / 2, sizeСircle, sizeСircle);
                                    }
                                    lasti = i;
                                }
                                else if(i == points.Length - 3)
                                {
                                    tempPoints[countTemp] = points[i];
                                    tempPoints[countTemp].X = (float)Math.Round((tempPoints[countTemp].X - centralX) / plusM, 3);
                                    tempPoints[countTemp].Y = (float)Math.Round(-(tempPoints[countTemp].Y - centralY) / plusM, 3);
                                    tableA.Rows.Add(tempPoints[countTemp].X, tempPoints[countTemp].Y);
                                    countTemp++;
                                    if (AdditionalMenuItem.Checked)
                                    {
                                        graphics.DrawLine(pen, points[lasti], points[i]);
                                        graphics.FillEllipse(new SolidBrush(Color.FromArgb(0, 0, 255)), points[i].X - sizeСircle / 2, points[i].Y - sizeСircle / 2, sizeСircle, sizeСircle);
                                    }
                                }
                            }
                            Array.Resize(ref tempPoints, countTemp);
                            dopSegments.Add(tempPoints);
                        }
                    }
                }
            }
        }

        private void nowTable_Click(object sender, DataGridViewCellMouseEventArgs e)
        {
            AreaPaint.Focus();
        }

        private void functionMain_TextChanged(object sender, EventArgs e)
        {
            ForStopSlow();
            if (!string.IsNullOrEmpty(functionMain.Text))
            {
                choice.Visible = true;
            }
            else
            {
                choice.Visible = false;
            }
            AreaPaint.Refresh();
        }

        private void slowMode_Click(object sender, EventArgs e)
        {
            slow = true;
            AreaPaint.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableA.Rows.Clear();
            moveP = true;
            dopSegments = new List<PointF[]>();
            tableupdate = false;
            AreaPaint.Refresh();
            tableupdate = true;
            dopPoints = new PointF[tableA.Rows.Count - 1];
            for (int i = 0; i < tableA.Rows.Count - 1; i++)
            {
                dopPoints[i].X = float.Parse(tableA.Rows[i].Cells[0].Value.ToString());
                dopPoints[i].Y = float.Parse(tableA.Rows[i].Cells[1].Value.ToString());
            }
        }

        private void CountPoints_TextChanged(object sender, EventArgs e)
        {
            int countpoints;
            if (Int32.TryParse(CountPoints.Text, out countpoints))
            {
                if (int.Parse(MaxPoints.Text) < int.Parse(CountPoints.Text))
                {
                    CountPoints.Text = MaxPoints.Text;
                    CountPoints.SelectionStart = CountPoints.TextLength;
                }
            }
        }

        private void MainMenuItem_Click(object sender, EventArgs e)
        {
            MainMenuItem.Checked = !MainMenuItem.Checked;
            tableupdate = false;
            AreaPaint.Refresh();
            tableupdate = true;
        }

        private void AdditionalMenuItem_Click(object sender, EventArgs e)
        {
            AdditionalMenuItem.Checked = !AdditionalMenuItem.Checked;
            tableupdate = false;
            AreaPaint.Refresh();
            tableupdate = true;
        }

        void tableCompletion()
        {
            List<PointF> nowPoints = new List<PointF>();
            nowTable.Rows.Clear();
            int minY = -((AreaPaint.Height) / 2 / plusM + GeneralRestrictions(CentralY)) - 1;
            int limitationDownY;
            if (LimitationDownY.Text != "" && Int32.TryParse(LimitationDownY.Text, out limitationDownY))
            {
                limitationDownY = -limitationDownY;
                if (limitationDownY < minY)
                {
                    limitationDownY = minY;
                }
            }
            else
            {
                limitationDownY = minY;
            }
            int limitationUpY = 0;
            int maxY = (AreaPaint.Height) / plusM + minY + 1;
            if (LimitationUpY.Text != "" && Int32.TryParse(LimitationUpY.Text, out limitationUpY))
            {
                limitationUpY = -limitationUpY;
                if (limitationUpY > maxY)
                {
                    limitationUpY = maxY;
                }
            }
            else
            {
                limitationUpY = maxY;
            }
            int countAllPoint = 0;
            PointF[] allPoints = new PointF[AreaPaint.Width + plusM + 2];
            PointF[] temporaryPoint = new PointF[AreaPaint.Width + plusM + 2];
            int limitationDownX;
            float x1 = -(AreaPaint.Width / 2 / plusM - GeneralRestrictions(CentralX));
            if (LimitationDownX.Text != "" && Int32.TryParse(LimitationDownX.Text, out limitationDownX))
            {
                if (limitationDownX > x1)
                {
                    x1 = limitationDownX;
                }
            }
            else
            {
                limitationDownX = (int)x1;
            }
            int limitationUpX;
            if (!Int32.TryParse(LimitationUpX.Text, out limitationUpX) && LimitationUpX.Text == "")
            {
                limitationUpX = 10000;
            }
            
            float e1 = AreaPaint.Width / plusM + x1;
            List<PointF[]> segments = new List<PointF[]>();
            Charts.TranslatingExpression translating = new Charts.TranslatingExpression();
            for (int i = 0; x1<=e1; i++)
            {
                temporaryPoint[i] = new PointF(x1, translating.Translating(functionMain.Text, x1));
                float checkedNumber = (temporaryPoint[i].Y);
                if (checkedNumber <= limitationUpY && checkedNumber >= limitationDownY)
                {
                    if (countAllPoint < allPoints.Length)
                    {
                        if (!float.IsNaN(temporaryPoint[i].X) && !float.IsNaN(temporaryPoint[i].Y) && !float.IsInfinity(temporaryPoint[i].Y))
                        {
                            allPoints[countAllPoint] = temporaryPoint[i];
                            allPoints[countAllPoint].Y = -allPoints[countAllPoint].Y;
                            countAllPoint++;
                        }
                    }
                }
                else
                {
                    if (countAllPoint > 1)
                    {
                        Array.Resize(ref allPoints, countAllPoint);
                        segments.Add(allPoints);
                    }
                    allPoints = new PointF[AreaPaint.Width + +plusM + 2];
                    countAllPoint = 0;
                }
                x1 += 1;
                if (x1 > limitationUpX)
                {
                    break;
                }
            }
            Array.Resize(ref allPoints, countAllPoint);
            if (countAllPoint > 1)
            {
                segments.Add(allPoints);
            }
            nowTable.SuspendLayout();
            foreach (PointF[] points in segments)
            {
                foreach (PointF point in points)
                {
                    nowTable.Rows.Add(point.X, point.Y);
                }
            }
            nowTable.ResumeLayout();
            PointsGraph.Text = (nowTable.Rows.Count - 1).ToString();
        }

        int GeneralRestrictions(TextBox textBox)
        {
            if (textBox.Text.StartsWith("-"))
            {
                if (textBox.TextLength > 6)
                {
                    textBox.Text = textBox.Text.Remove(6);
                    textBox.SelectionStart = textBox.TextLength;
                }
            }
            else
            {
                if (textBox.TextLength > 5)
                {
                    textBox.Text = textBox.Text.Remove(5);
                    textBox.SelectionStart = textBox.TextLength;
                }
            }
            int inParentheses;
            if (Int32.TryParse(textBox.Text, out inParentheses))
            {
                if (inParentheses > 10000)
                {
                    inParentheses = 10000;
                    textBox.Text = "10000";
                }
                else if (inParentheses < -10000)
                {
                    inParentheses = -10000;
                    textBox.Text = "-10000";
                }
                textBox.SelectionStart = textBox.TextLength;
            }
            else
            {
                if (textBox.Text.StartsWith("-"))
                {

                }
                else
                {
                    inParentheses = 0;
                    textBox.Text = "";
                    textBox.SelectionStart = textBox.TextLength;
                }
            }
            return inParentheses;
        }
    }
}