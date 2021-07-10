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
        PointF[] dopPoints = new PointF[0];
        Color colorMainFunctoin;
        Color colorAdditionalFunction;
        int centralX, centralY, plusM;
        bool slow;
        bool stopSlowDrawing;
        bool tableupdate;
        bool movePoint;
        int slowspeed;
        PointF lastpoint = new PointF();
        int movingPoint;
        public MainForm()
        {
            InitializeComponent();
            plusM = 1;
            slow = false;
            stopSlowDrawing = true;
            tableupdate = true;
            slowspeed = 10;
            lastpoint.X = 10000;
            lastpoint.Y = 10000;
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
                    output.Write(functionMain.Text+"&");
                    for(int i =0;i< dopPoints.Length;i++)
                    {
                        output.Write(dopPoints[i].X.ToString() + ";" + dopPoints[i].Y.ToString());
                        if(i+1 < dopPoints.Length)
                        {
                            output.Write("@");
                        }
                    }
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
                    string[] dataFuction = data.Split('&');
                    functionMain.Text = dataFuction[0];
                    string[] pointDopFunc = dataFuction[1].Split('@');
                    dopPoints = new PointF[pointDopFunc.Length];
                    for (int i =0; i< pointDopFunc.Length;i++)
                    {
                        dopPoints[i].X= float.Parse(pointDopFunc[i].Split(';')[0]);
                        dopPoints[i].Y = float.Parse(pointDopFunc[i].Split(';')[1]);
                    }
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
                dopPoints = new PointF[0];
                tableupdate = false;
                AreaPaint.Refresh();
                tableupdate = true;
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
                float coorX = ((float)(e.X - centralX)) / plusM;
                float coorY = ((float)(centralY - e.Y)) / plusM;
                coorX = (float)Math.Round(coorX, 0);
                coorY = (float)Math.Round(coorY, 0);
                movePoint = true;
                int x = (int)coorX;
                int y = (int)coorY;
                for (int i = 0; i < tableA.Rows.Count - 1; i++)
                {
                    if (tableA.Rows[i].Cells[0].Value.ToString() == x.ToString() && tableA.Rows[i].Cells[1].Value.ToString() == y.ToString())
                    {
                        movingPoint = i;
                        return;
                    }
                }
                movePoint = false;
            }
        }

        private void AreaPaint_MouseMove(object sender, MouseEventArgs e)
        {
            float coorX = ((float)(e.X - centralX)) / plusM;
            float coorY = ((float)(centralY - e.Y)) / plusM;
            coorX = (float)Math.Round(coorX, 0);
            coorY = (float)Math.Round(coorY, 0);
            if (movePoint)
            {
                dopPoints[movingPoint].X = coorX;
                dopPoints[movingPoint].Y = -coorY;
                tableupdate = false;
                AreaPaint.Refresh();
                tableupdate = true;
            }
            coordinates.Text = "x = " + coorX.ToString() + ";  y = " + coorY.ToString() + ";";
            if (lastpoint.X == coorX && lastpoint.Y == coorY)
            {
                return;
            }
            lastpoint.X = coorX;
            lastpoint.Y = coorY;

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
                tableA.Rows[movingPoint].Cells[0].Value = coorX;
                tableA.Rows[movingPoint].Cells[1].Value = coorY;
                movePoint = false;
                tableupdate = false;
                AreaPaint.Refresh();
                tableupdate = true;
            }
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
            lastpoint.Y = 10000;
            lastpoint.X = 10000;
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
                    if (-limitationUpY > maxY)
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
                if (allPoints.Length > 1)
                {
                    segments.Add(allPoints);
                }
                SpeedDrawing(graphics, segments);
                if(tableupdate)
                {
                    tableCompletion();
                }
                int count = int.Parse(PointsGraph.Text);
                if(count>0)
                {
                    int countPoints;
                    if(Int32.TryParse(CountPoints.Text, out countPoints))
                    {
                        if(count< countPoints)
                        {
                            CountPoints.Text = count.ToString();
                            countPoints = count;
                        }
                        if(countPoints - 2>0)
                        {
                            int result = (int)Math.Ceiling((float)count / (countPoints));
                            if(result==0)
                            {
                                result = 1;
                            }
                            float sizeСircle = 5 + plusM / 11;
                            if (result > 0)
                            {
                                graphics.FillEllipse(new SolidBrush(Color.Black), centralX - sizeСircle / 2 + float.Parse(nowTable.Rows[0].Cells[0].Value.ToString()) * plusM, centralY - sizeСircle / 2 - float.Parse(nowTable.Rows[0].Cells[1].Value.ToString()) * plusM, sizeСircle, sizeСircle);
                                for (int i = 0; i < nowTable.Rows.Count - 1; i += result)
                                {
                                    graphics.FillEllipse(new SolidBrush(Color.Black), centralX - sizeСircle / 2 + float.Parse(nowTable.Rows[(int)i].Cells[0].Value.ToString()) * plusM, centralY - sizeСircle / 2 - float.Parse(nowTable.Rows[(int)i].Cells[1].Value.ToString()) * plusM, sizeСircle, sizeСircle);
                                }
                                graphics.FillEllipse(new SolidBrush(Color.Black), centralX - sizeСircle / 2 + float.Parse(nowTable.Rows[nowTable.Rows.Count - 2].Cells[0].Value.ToString()) * plusM, centralY - sizeСircle / 2 - float.Parse(nowTable.Rows[nowTable.Rows.Count - 2].Cells[1].Value.ToString()) * plusM, sizeСircle, sizeСircle);
                            }
                        }
                    }
                }
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
                allPoints = new PointF[AreaPaint.Width + +plusM + 2];
                countAllPoint = 0;
            }
        }

        async void SpeedDrawing(Graphics graphics, List<PointF[]> segments)
        {
            if (segments.Count > 0)
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
            if (dopPoints.Length>0)
            {
                PointF[] tempPoints = new PointF[dopPoints.Length];
                int tempCount=0;
                foreach(PointF point in dopPoints)
                {
                    tempPoints[tempCount] = point;
                    tempPoints[tempCount].X = tempPoints[tempCount].X * plusM + centralX;
                    tempPoints[tempCount].Y = tempPoints[tempCount].Y * plusM + centralY;
                    tempCount++;
                }
                if (tempPoints.Length > 1)
                {
                    Pen pen = new Pen(colorAdditionalFunction, 2f);
                    graphics.DrawLines(pen, tempPoints);
                }
                else if (tempPoints.Length == 1)
                {
                    Pen pen = new Pen(colorAdditionalFunction, 2f);
                    graphics.FillEllipse(new SolidBrush(Color.Black), tempPoints[0].X - 3, tempPoints[0].Y - 3, 6, 6);
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

        private void tableA_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dopPoints = new PointF[tableA.Rows.Count - 1];
            for (int i = 0; i < tableA.Rows.Count - 1; i++)
            {
                dopPoints[i].X = float.Parse(tableA.Rows[i].Cells[0].Value.ToString());
                dopPoints[i].Y = -float.Parse(tableA.Rows[i].Cells[1].Value.ToString());
            }
            tableupdate = false;
            AreaPaint.Refresh();
            tableupdate = true;
        }

        private void CountPoints_TextChanged(object sender, EventArgs e)
        {
            AreaPaint.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableA.Rows.Clear();
            for (int i = 0; i < nowTable.Rows.Count - 1; i++)
            {
                tableA.Rows.Add(nowTable.Rows[i].Cells[0].Value, nowTable.Rows[i].Cells[1].Value); ;
            }
            dopPoints = new PointF[tableA.Rows.Count - 1];
            for (int i = 0; i < tableA.Rows.Count - 1; i++)
            {
                dopPoints[i].X = float.Parse(tableA.Rows[i].Cells[0].Value.ToString());
                dopPoints[i].Y = -float.Parse(tableA.Rows[i].Cells[1].Value.ToString());
            }
            tableupdate = false;
            AreaPaint.Refresh();
            tableupdate = true;
        }

        void tableCompletion()
        {
            List<PointF> nowPoints = new List<PointF>();
            nowTable.Rows.Clear();
            int minY = -(AreaPaint.Height / 2 / plusM + GeneralRestrictions(CentralY))-1;
            int limitationDownY;
            if (LimitationUpY.Text != "" && Int32.TryParse(LimitationUpY.Text, out limitationDownY))
            {
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
            int maxY = AreaPaint.Height / plusM + minY+1;
            if (LimitationDownY.Text != "" && Int32.TryParse(LimitationDownY.Text, out limitationUpY))
            {
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
                if(x1==-13)
                {

                }
                temporaryPoint[i] = new PointF(x1, translating.Translating(functionMain.Text, x1));
                float checkedNumber = (temporaryPoint[i].Y);
                if (checkedNumber <= -limitationDownY && checkedNumber >= -limitationUpY)
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