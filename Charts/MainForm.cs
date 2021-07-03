using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сharts
{
    public partial class MainForm : Form
    {
        int centralX, centralY, plusM;
        bool slow;
        int slowspeed;
        bool redrawing;
        List<PointF> nowPoints = new List<PointF>();
        PointF lastpoint = new PointF();
        List<PointF[]> segments = new List<PointF[]>();
        public MainForm()
        {
            InitializeComponent();
            centralX = AreaPaint.Width / 2;
            centralY = AreaPaint.Height / 2;
            plusM = 1;
            slow = false;
            redrawing = true;
            slowspeed = 10;
            lastpoint.X = 1000;
            lastpoint.Y = 1000;

        }

        private void AreaPaint_Paint(object sender, PaintEventArgs e)
        {
            Сharts.Paint.DrawLine(e, Color.Black, new Point(0, 0), new Point(AreaPaint.Width, 0));
            Сharts.Paint.DrawLine(e, Color.Black, new Point(0, AreaPaint.Height - 1), new Point(AreaPaint.Width, AreaPaint.Height - 1));
            Сharts.Paint.DrawLine(e, Color.Black, new Point(0, 0), new Point(0, AreaPaint.Height));
            Сharts.Paint.DrawLine(e, Color.Black, new Point(AreaPaint.Width - 1, 0), new Point(AreaPaint.Width - 1, AreaPaint.Height));
            Сharts.Paint.DrawPoint(e, Color.Brown, new Point(AreaPaint.Width / 2, AreaPaint.Height / 2));
            Сharts.Paint.DrawLine(e, Color.Brown, new Point(AreaPaint.Width / 2, 0), new Point(AreaPaint.Width / 2, AreaPaint.Height));
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
            if(functionMain.TextLength!=0)
            {
                PaintChart(e.Graphics);
            }
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            redrawing = false;
            AreaPaint.Refresh();
            redrawing = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (plusM > 1)
            {
                plusM -= 1;
                PercentScrolling.Value = plusM / (11);
                AreaPaint.Refresh();
                Percent.Text = "1:" + plusM;
                CentralXChenged();
                CentralYChenged();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (plusM < 110)
            {
                plusM += 1;
                PercentScrolling.Value = plusM / (11);
                AreaPaint.Refresh();
                Percent.Text = "1:" + plusM;
                CentralXChenged();
                CentralYChenged();
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            functionsС.Visible = functionR.Checked;
            tableC.Visible = tableR.Checked;
        }

        private void SlowDrawing_CheckedChanged(object sender, EventArgs e)
        {
            slow = SlowDrawing.Checked;
            SpeedSlow.Visible = SlowDrawing.Checked;
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
                AreaPaint.Refresh();
                Graphics graphics = AreaPaint.CreateGraphics();
                graphics.FillEllipse(new SolidBrush(Color.FromArgb(0, 191, 255)), centralX - sizeСircle / 2 + coorX * plusM, centralY - sizeСircle / 2 - coorY * plusM, sizeСircle, sizeСircle);
            }
        }

        private void AreaPaint_MouseLeave(object sender, EventArgs e)
        {
            coordinates.Text = "Не в зоны действия";
            if (!slow)
            {
                AreaPaint.Refresh();
            }
            lastpoint.Y = 1000;
            lastpoint.X = 1000;
        }

        private void Limitation_TextChanged(object sender, EventArgs e)
        {
            GeneralRestrictions((TextBox)sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewTable.Visible = !viewTable.Visible;
            if(viewTable.Visible)
            {
                openTable.Text = "Закрыть таблицу";
            }
            else
            {
                openTable.Text = "Открыть таблицу";
            }
            CentralXChenged();
            CentralYChenged();
        }

        private void PercentScrolling_Scroll(object sender, EventArgs e)
        {
            if (PercentScrolling.Value != 0)
            {
                plusM = PercentScrolling.Value * 11;
                Percent.Text = "1:" + plusM;
                CentralXChenged();
                CentralYChenged();
            }
            else
            {
                plusM = 1;
                Percent.Text = "1:1";
                CentralXChenged();
                CentralYChenged();
            }
        }

        private void CentralX_TextChanged(object sender, EventArgs e)
        {
            CentralXChenged();
        }

        private void CentralY_TextChanged(object sender, EventArgs e)
        {
            CentralYChenged();
        }

        void CentralXChenged()
        {
            centralX = AreaPaint.Width / 2 - GeneralRestrictions(CentralX) * plusM;
            AreaPaint.Refresh();
        }

        void CentralYChenged()
        {

            centralY = AreaPaint.Height / 2 + GeneralRestrictions(CentralY) * plusM;
            AreaPaint.Refresh();
        }

        int LimitationsMin(int limitationDownX)
        {
            int lim = limitationDownX;
            int def = -(centralX / plusM + 1);
            if (lim > def)
            {
                return lim;
            }
            else
            {
                return def;
            }
        }

        int LimitationsMax(int limitationUpX, int limitationDownX)
        {
            int lim = limitationUpX + 1;
            int def = (AreaPaint.Width) / plusM + 2 + LimitationsMin(limitationDownX);
            if (lim < def)
            {
                return lim;
            }
            else
            {
                return def;
            }
        }

        void PaintChart(Graphics graphics)
        {
            int limitationDownX;
            if (!Int32.TryParse(LimitationDownX.Text, out limitationDownX))
            {
                limitationDownX = -1000;
                LimitationDownX.Text = "-1000";
            }
            int limitationUpX;
            if (!Int32.TryParse(LimitationUpX.Text, out limitationUpX))
            {
                limitationUpX = 1000;
                LimitationUpX.Text = "1000";
            }
            int limitationDownY;
            if (!Int32.TryParse(LimitationDownY.Text, out limitationDownY))
            {
                limitationDownY = -1000;
                LimitationDownY.Text = "-1000";
            }
            int limitationUpY;
            if (!Int32.TryParse(LimitationUpY.Text, out limitationUpY))
            {
                limitationUpY = 1000;
                LimitationUpY.Text = "1000";
            }
            int min = LimitationsMin(limitationDownX);
            int max = LimitationsMax(limitationUpX, limitationDownX);
            if(Math.Abs(min) + max<0)
            {
                return;
            }
            PointF[] points = new PointF[Math.Abs(min) + max];
            PointF[] pointsDraw = new PointF[Math.Abs(min) + max];
            int countPointsDraw = 0;
            int x = min;
            for (int i = 0; i < points.Length; i++, x++)
            {
                points[i] = new PointF(x * plusM + centralX, Charts.TranslatingExpression.Translating(functionMain.Text,x) * plusM + centralY);
                EndsGraphMin(ref points, ref i, ref countPointsDraw, ref pointsDraw, limitationDownY, limitationUpY);
            }
            EndsGraphMax(ref points, ref countPointsDraw, ref pointsDraw, limitationDownY, limitationUpY);
            Array.Resize(ref pointsDraw, countPointsDraw);
            SeparationSegments(pointsDraw, Math.Abs(min) + max);
            SpeedDrawing(pointsDraw, graphics);
            nowPoints.Clear();
            nowTable.Rows.Clear();
            tableCompletion(pointsDraw);
        }

        void EndsGraphMin(ref PointF[] points,ref int i,ref int countPointsDraw, ref PointF[] pointsDraw, int limitationDownY, int limitationUpY)
        {
            float z = (float)Math.Round(points[i].Y / plusM);
            float xx = (-limitationDownY + centralY / plusM);
            float ee = (-limitationUpY + centralY / plusM);
            if (points[i].Y >= 0 && points[i].Y <= AreaPaint.Height&& Math.Round(points[i].Y / plusM) <= (-limitationDownY  + centralY/plusM) && Math.Round(points[i].Y / plusM-1) >= (-limitationUpY+ centralY / plusM))
            {
                if (countPointsDraw == 0 && i > 0 && !points[i - 1].Y.Equals(float.NaN))
                {
                    pointsDraw[countPointsDraw] = points[i - 1];
                    countPointsDraw++;
                }
                pointsDraw[countPointsDraw] = points[i];
                countPointsDraw++;
            }
        }

        void EndsGraphMax(ref PointF[] points,ref int countPointsDraw, ref PointF[] pointsDraw, int limitationDownY, int limitationUpY)
        {
            foreach (PointF point in points)
            {
                if (countPointsDraw > 0&&point.X == (pointsDraw[countPointsDraw - 1].X + 1 * plusM)&& Math.Round(point.Y / plusM) <= (-limitationDownY + centralY / plusM) && Math.Round(point.Y / plusM - 1) >= (-limitationUpY + centralY / plusM))
                {
                    pointsDraw[countPointsDraw] = point;
                    countPointsDraw++;
                    break;
                }
            }
        }

        void SeparationSegments(PointF[] pointsDraw,int size)
        {
            segments.Clear();
            PointF[] pointFsbyf = new PointF[size];
            int idx = 0;
            for(int i=0;i< pointsDraw.Length-1;i++)
            {
                if(pointsDraw[i].X/plusM+1==pointsDraw[i+1].X / plusM)
                {
                    pointFsbyf[idx] =  pointsDraw[i];
                    idx++;
                }
                else
                {
                    pointFsbyf[idx] = pointsDraw[i];
                    idx++;
                    Array.Resize(ref pointFsbyf, idx);
                    if(pointFsbyf.Length>1)
                    {
                        segments.Add(pointFsbyf);
                    }
                    pointFsbyf = new PointF[size];
                    Array.Clear(pointFsbyf,0,pointFsbyf.Length);
                    idx = 0;
                }
            }
            if(pointsDraw.Length - 1>0)
            {
                pointFsbyf[idx] = pointsDraw[pointsDraw.Length - 1];
                idx++;
            }
            if (pointFsbyf.Length>0)
            {
                Array.Resize(ref pointFsbyf, idx);
                if (pointFsbyf.Length > 1)
                {
                    segments.Add(pointFsbyf);
                }
            }
        }

        async void SpeedDrawing(PointF[] pointsDraw, Graphics graphics)
        {
            Pen pen = new Pen(Color.Black, 2f);
            if (segments.Count > 0)
            {
                if (!slow || redrawing)
                {
                    foreach(PointF[] points in segments)
                    graphics.DrawLines(pen, points);
                }
                else
                {
                    PointF[] temppointsDraw = new PointF[pointsDraw.Length];
                    Array.Copy(pointsDraw, temppointsDraw, pointsDraw.Length);
                    for (int f = 0; temppointsDraw.Length - 1 > f; f++)
                    {
                        await Task.Delay(slowspeed);
                        graphics = AreaPaint.CreateGraphics();
                        graphics.DrawLine(pen, temppointsDraw[f], temppointsDraw[f + 1]);
                    }
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "GREBIAR |*.grebiar;";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(saveFileDialog.FileName);
            }
        }

        private void LoadMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "GREBIAR |*.grebiar;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog.FileName);
            }
        }

        void tableCompletion(PointF[] pointsDraw)
        {
            int byfX, byfY;

            if (!int.TryParse(CentralX.Text, out byfX))
            {
                byfX = 0;
            }
            if (!int.TryParse(CentralY.Text, out byfY))
            {
                byfY = 0;
            }

            for (int i = 0; i < pointsDraw.Length; i++)
            {
                pointsDraw[i].X -= 330 - byfX;
                pointsDraw[i].X /= plusM;
                pointsDraw[i].X = (float)Math.Round(pointsDraw[i].X, 1);
                pointsDraw[i].X = pointsDraw[i].X;
                pointsDraw[i].Y -= 326 + byfY;
                pointsDraw[i].Y /= plusM;
                pointsDraw[i].Y = (float)Math.Round(pointsDraw[i].Y, 1);
                pointsDraw[i].Y = -pointsDraw[i].Y;
                if (i > 0 && pointsDraw[i].Y != pointsDraw[i - 1].Y)
                {
                    nowPoints.Add(pointsDraw[i]);
                }
                else if (i == 0)
                {
                    nowPoints.Add(pointsDraw[i]);
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
                if (textBox.TextLength > 5)
                {
                    textBox.Text = textBox.Text.Remove(5);
                    textBox.SelectionStart = textBox.TextLength;
                }
            }
            else
            {
                if (textBox.TextLength > 4)
                {
                    textBox.Text = textBox.Text.Remove(4);
                    textBox.SelectionStart = textBox.TextLength;
                }
            }
            int inParentheses;
            if (Int32.TryParse(textBox.Text, out inParentheses))
            {
                if (inParentheses > 1000)
                {
                    inParentheses = 1000;
                    textBox.Text = "1000";
                }
                else if (inParentheses < -1000)
                {
                    inParentheses = -1000;
                    textBox.Text = "-1000";
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