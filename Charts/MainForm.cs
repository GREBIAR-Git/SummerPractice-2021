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
        PointF[] allPoints = new PointF[0];
        PointF[] dopPoints = new PointF[0];
        Color colorMainFunctoin;
        Color colorAdditionalFunction;
        int centralX, centralY, plusM;
        bool slow;
        int slowspeed;
        bool redrawing;
        List<PointF> nowPoints = new List<PointF>();
        PointF lastpoint = new PointF();
        bool load;
        bool stopSlowDrawing;
        public MainForm()
        {
            InitializeComponent();
            plusM = 1;
            load = true;
            slow = false;
            redrawing = true;
            slowspeed = 10;
            lastpoint.X = 10000;
            lastpoint.Y = 10000;
            centralX += 100;
            colorMainFunctoin = Color.Black;
            colorAdditionalFunction = Color.Red;
            stopSlowDrawing = true;
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

        private void BottomPanelMenuItem_Click(object sender, EventArgs e)
        {
            BottomPanelMenuItem.Checked = !BottomPanelMenuItem.Checked;
            BottomPanel.Visible = BottomPanelMenuItem.Checked;
            CentralXChanged();
            CentralYChanged();
            AreaPaint.Refresh();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "GREBIAR |*.grebiar;";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = File.Open(saveFileDialog.FileName, FileMode.Create);
                StreamWriter output = new StreamWriter(fileStream);
                foreach (PointF point in allPoints)
                {
                    output.Write(point.X + ";" + point.Y + "!");
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
                    string[] subs = data.Split('!');
                    allPoints = new PointF[subs.Length - 1];
                    int countAllPoint = 0;
                    for (int i = 0; i < allPoints.Length; i++)
                    {
                        string[] axis = subs[i].Split(';');
                        allPoints[countAllPoint].X = int.Parse(axis[0]);
                        allPoints[countAllPoint].Y = int.Parse(axis[1]);
                        countAllPoint++;
                    }
                }
                catch
                {
                    MessageBox.Show("Файл повреждён");
                }
                reader.Close();
            }
            load = true;
            if (allPoints.Length > 0)
            {
                choice.Visible = true;
            }
            else
            {
                choice.Visible = false;
            }
            AreaPaint.Refresh();
        }

        private void TableMenuItem_Click(object sender, EventArgs e)
        {
            TableMenuItem.Checked = !TableMenuItem.Checked;
            viewTable.Visible = TableMenuItem.Checked;
            if (viewTable.Visible)
            {
                openTable.Text = "Закрыть таблицу";
            }
            else
            {
                openTable.Text = "Открыть таблицу";
            }
            CentralXChanged();
            CentralYChanged();
        }

        private void GraphFunctionMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.AllowFullOpen = false;
            if (color.ShowDialog() == DialogResult.OK)
            {
                colorMainFunctoin = color.Color;
            }
        }

        private void GraphAdditionalFunctionsMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.AllowFullOpen = false;
            if (color.ShowDialog() == DialogResult.OK)
            {
                colorAdditionalFunction = color.Color;
            }
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
            tableA.Rows.Clear();
            for(int i=0;i < nowTable.Rows.Count-1;i++)
            {
                tableA.Rows.Add(nowTable.Rows[i].Cells[0].Value, nowTable.Rows[i].Cells[1].Value); ;
            }
            functionsС.Visible = functionR.Checked;
            tableC.Visible = tableR.Checked;
        }

        private void SlowDrawing_CheckedChanged(object sender, EventArgs e)
        {
            stopSlowDrawing = true;
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

        private void AreaPaint_MouseMove(object sender, MouseEventArgs e)
        {
            float coorX = ((float)(e.X - centralX)) / plusM;
            float coorY = ((float)(centralY - e.Y)) / plusM;
            coorX = (float)Math.Round(coorX, 0);
            coorY = (float)Math.Round(coorY, 0);
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
                redrawing = false;
                AreaPaint.Refresh();
                redrawing = true;
                Graphics graphics = AreaPaint.CreateGraphics();
                graphics.FillEllipse(new SolidBrush(Color.FromArgb(0, 191, 255)), centralX - sizeСircle / 2 + coorX * plusM, centralY - sizeСircle / 2 - coorY * plusM, sizeСircle, sizeСircle);
            }
        }

        private void AreaPaint_MouseLeave(object sender, EventArgs e)
        {
            coordinates.Text = "Не в зоны действия";
            if (!slow)
            {
                redrawing = false;
                AreaPaint.Refresh();
                redrawing = true;
            }
            lastpoint.Y = 10000;
            lastpoint.X = 10000;
        }

        private void Limitation_TextChanged(object sender, EventArgs e)
        {
            GeneralRestrictions((TextBox)sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewTable.Visible = !viewTable.Visible;
            TableMenuItem.Checked = viewTable.Visible;
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

        private void Draw_Click(object sender, EventArgs e)
        {
            if (functionMain.Text != "")
            {
                int limitationDownX;
                if (!Int32.TryParse(LimitationDownX.Text, out limitationDownX))
                {
                    limitationDownX = -10000;
                    LimitationDownX.Text = "-10000";
                }
                int limitationUpX;
                if (!Int32.TryParse(LimitationUpX.Text, out limitationUpX))
                {
                    limitationUpX = 10000;
                    LimitationUpX.Text = "10000";
                }
                int limitationDownY;
                if (!Int32.TryParse(LimitationDownY.Text, out limitationDownY))
                {
                    limitationDownY = -10000;
                    LimitationDownY.Text = "-10000";
                }
                int limitationUpY;
                if (!Int32.TryParse(LimitationUpY.Text, out limitationUpY))
                {
                    limitationUpY = 10000;
                    LimitationUpY.Text = "10000";
                }
                int minX = limitationDownX;
                int maxX = limitationUpX;
                if (Math.Abs(minX) + maxX < 0)
                {
                    return;
                }
                int countAllPoint = 0;
                allPoints = new PointF[Math.Abs(minX) + maxX + 1];
                PointF[] temporaryPoint = new PointF[Math.Abs(minX) + maxX + 1];
                int x = minX;
                for (int i = 0; i < temporaryPoint.Length; i++, x++)
                {
                    temporaryPoint[i] = new PointF(x, Charts.TranslatingExpression.Translating(functionMain.Text, x));
                    RemoveUnnecessary(temporaryPoint[i], ref countAllPoint, limitationDownY, limitationUpY);
                }
                Array.Resize(ref allPoints, countAllPoint);
                load = false;
            }
            else
            {
                if (!load)
                {
                    allPoints = new PointF[0];
                }
            }
            if (!slow)
            {
                stopSlowDrawing = false;
                AreaPaint.Refresh();
            }
            else
            {
                ForStopSlow();
            }
            if (allPoints.Length>0)
            {
                choice.Visible = true;
            }
            else
            {
                choice.Visible = false;
            }
        }

        async void ForStopSlow()
        {
            stopSlowDrawing = true;
            await Task.Delay(slowspeed+10);
            stopSlowDrawing = false;
            AreaPaint.Refresh();
        }

        void RemoveUnnecessary(PointF point,ref int countAllPoint,int limitationDownY,int limitationUpY)
        {
            float checkedNumber = (point.Y);
            if (checkedNumber <= (-limitationDownY) && checkedNumber >=(-limitationUpY))
            {
                allPoints[countAllPoint] = point;
                countAllPoint++;
            }
        }

        void PaintChart(Graphics graphics)
        {
            List<PointF[]> segments = new List<PointF[]>();
            PointF[] pointsDraw = new PointF[allPoints.Length];
            int countPointsDraw = 0;
            for(int i=0;i<allPoints.Length;i++)
            {
                EndsGraphMin(i, ref countPointsDraw, ref pointsDraw);
            }
            EndsGraphMax(ref countPointsDraw, ref pointsDraw);
            Array.Resize(ref pointsDraw, countPointsDraw);
            SeparationSegments(pointsDraw,ref segments);
            SpeedDrawing(pointsDraw, graphics, segments);
            if(redrawing)
            {
                tableCompletion(pointsDraw);
            }
        }

        void SeparationSegments(PointF[] pointsDraw, ref List<PointF[]> segments)
        {
            PointF[] pointFsbyf = new PointF[pointsDraw.Length];
            int idx = 0;
            for (int i = 0; i < pointsDraw.Length - 1; i++)
            {
                if ((int)Math.Round(pointsDraw[i].X / plusM,1) + 1 == (int)Math.Round(pointsDraw[i + 1].X/ plusM,1))
                {
                    pointFsbyf[idx] = pointsDraw[i];
                    idx++;
                }
                else
                {
                    pointFsbyf[idx] = pointsDraw[i];
                    idx++;
                    bool t1 = true;
                    foreach(PointF point in allPoints)
                    {
                        if(point.X == (pointsDraw[i].X-centralX)/plusM + 1)
                        {
                            pointFsbyf[idx].X = (point.X*plusM)+centralX;
                            pointFsbyf[idx].Y = (point.Y * plusM) + centralY;
                            idx++;
                        }
                        if (point.X == (pointFsbyf[0].X - centralX) / plusM - 1)
                        {
                            if (t1)
                            {
                                for (int f = idx; f > 0; f--)
                                {
                                    pointFsbyf[f] = pointFsbyf[f - 1];
                                }
                                pointFsbyf[0].X = (point.X * plusM) + centralX;
                                pointFsbyf[0].Y = (point.Y * plusM) + centralY;
                                idx++;
                                t1 = false;
                            }
                        }
                    }
                    Array.Resize(ref pointFsbyf, idx);
                    if (pointFsbyf.Length > 1)
                    {
                        segments.Add(pointFsbyf);
                    }
                    pointFsbyf = new PointF[pointsDraw.Length];
                    Array.Clear(pointFsbyf, 0, pointFsbyf.Length);
                    idx = 0;
                }
            }
            if (pointsDraw.Length - 1 > 0)
            {
                pointFsbyf[idx] = pointsDraw[pointsDraw.Length - 1];
                idx++;
                if(idx<pointsDraw.Length)
                {
                    foreach (PointF point in allPoints)
                    {
                        if (point.X == (pointFsbyf[0].X - centralX) / plusM - 1)
                        {
                            for (int f = idx; f > 0; f--)
                            {
                                pointFsbyf[f] = pointFsbyf[f - 1];
                            }
                            pointFsbyf[0].X = (point.X * plusM) + centralX;
                            pointFsbyf[0].Y = (point.Y * plusM) + centralY;
                            idx++;
                        }
                    }
                }
            }
            if (pointFsbyf.Length > 0)
            {
                Array.Resize(ref pointFsbyf, idx);
                if (pointFsbyf.Length > 1)
                {
                    segments.Add(pointFsbyf);
                }
            }
        }


        void EndsGraphMin(int i,ref int countPointsDraw, ref PointF[] pointsDraw)
        {
            float checkedNumberX = (allPoints[i].X * plusM + centralX);
            float checkedNumberY = (allPoints[i].Y * plusM + centralY);
            if (checkedNumberY >= 0 && checkedNumberY <= AreaPaint.Height&& checkedNumberX>=0&&checkedNumberX<=AreaPaint.Width)
            {
                if (countPointsDraw == 0 && i > 0 && !allPoints[i - 1].Y.Equals(float.NaN))
                {
                    pointsDraw[countPointsDraw] = allPoints[i - 1];
                    pointsDraw[countPointsDraw].X = pointsDraw[countPointsDraw].X * plusM + centralX;
                    pointsDraw[countPointsDraw].Y = pointsDraw[countPointsDraw].Y * plusM + centralY;
                    countPointsDraw++;
                }
                pointsDraw[countPointsDraw] = allPoints[i];
                pointsDraw[countPointsDraw].X = pointsDraw[countPointsDraw].X * plusM + centralX;
                pointsDraw[countPointsDraw].Y = pointsDraw[countPointsDraw].Y * plusM + centralY;
                countPointsDraw++;
            }
        }

        void EndsGraphMax(ref int countPointsDraw, ref PointF[] pointsDraw)
        {
            foreach (PointF point in allPoints)
            {
                if (countPointsDraw > 0&&point.X == ((pointsDraw[countPointsDraw - 1].X-centralX)/ plusM+1))
                {
                    pointsDraw[countPointsDraw] = point;
                    pointsDraw[countPointsDraw].X = pointsDraw[countPointsDraw].X * plusM + centralX;
                    pointsDraw[countPointsDraw].Y = pointsDraw[countPointsDraw].Y * plusM + centralY;
                    countPointsDraw++;
                    break;
                }
            }
        }

        async void SpeedDrawing(PointF[] pointsDraw, Graphics graphics, List<PointF[]> segments)
        {
            if (pointsDraw.Length > 1)
            {
                Pen pen = new Pen(colorMainFunctoin, 2f);
                if (!slow)
                {
                    foreach (PointF[] points in segments) 
                    graphics.DrawLines(pen, points);
                }
                else
                {
                    foreach (PointF[] points in segments)
                    {
                        for(int i=0;i<points.Length-1;i++)
                        {
                            if(!stopSlowDrawing)
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
            else if(pointsDraw.Length == 1)
            {
                graphics.FillEllipse(new SolidBrush(Color.Black), pointsDraw[0].X - 3, pointsDraw[0].Y - 3, 6, 6);
            }
            if (AdditionalFunctionMenuItem.Checked)
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            dopPoints = new PointF[tableA.Rows.Count - 1];
            for (int i = 0; i < tableA.Rows.Count - 1; i++)
            {
                dopPoints[i].X = float.Parse(tableA.Rows[i].Cells[0].Value.ToString());
                dopPoints[i].Y = -float.Parse(tableA.Rows[i].Cells[1].Value.ToString());
            }
            AreaPaint.Refresh();
        }

        private void AdditionalFunctionMenuItem_Click(object sender, EventArgs e)
        {
            AdditionalFunctionMenuItem.Checked = !AdditionalFunctionMenuItem.Checked;

        }

        void tableCompletion(PointF[] pointsDraw)
        {
            nowPoints.Clear();
            nowTable.Rows.Clear();
            for (int i = 0; i < pointsDraw.Length; i++)
            {
                pointsDraw[i].X = (pointsDraw[i].X - centralX) / plusM;
                float t = (float)Math.Round(pointsDraw[i].X);
                pointsDraw[i].X = pointsDraw[i].X;
                if (pointsDraw[i].X == Math.Round(pointsDraw[i].X))
                {
                    pointsDraw[i].Y = -(pointsDraw[i].Y - centralY) / plusM;
                    if(pointsDraw[i].Y == Math.Round(pointsDraw[i].Y))
                    {
                        if (i > 0 && pointsDraw[i].Y != pointsDraw[i - 1].Y)
                        {
                            nowPoints.Add(pointsDraw[i]);
                        }
                        else if (i == 0)
                        {
                            nowPoints.Add(pointsDraw[i]);
                        }
                    }
                }
            }
            if (nowPoints.Count == 1)
            {
                if (nowPoints[0].X != pointsDraw[pointsDraw.Length - 1].X)
                {
                    nowPoints.Add(pointsDraw[pointsDraw.Length - 1]);
                }
            }
            nowTable.SuspendLayout();
            foreach (PointF point in nowPoints)
            {
                nowTable.Rows.Add(point.X, point.Y);
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