using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
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
        public MainForm()
        {
            InitializeComponent();
            AreaPaint.Refresh();
            centralX = AreaPaint.Width / 2;
            centralY = AreaPaint.Height / 2;
            plusM = 1;
            slow = false;
            redrawing = true;
            slowspeed = 10;

            nowTable.BorderStyle = BorderStyle.None;
            nowTable.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(218, 189, 171);
            nowTable.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            nowTable.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            nowTable.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            nowTable.BackgroundColor = Color.FromArgb(239, 205, 184);

            nowTable.EnableHeadersVisualStyles = false;
            nowTable.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(194, 168, 148);
            lastpoint.X = 1000;
            lastpoint.Y = 1000;
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            AreaPaint.Refresh();
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

        private void Draw_Click(object sender, EventArgs e)
        {
            Graphics graphics = AreaPaint.CreateGraphics();
            graphics.Clear(Color.White);
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
            if (radioButton1.Checked)
            {
                functionsС.Visible = true;
                tableC.Visible = false;
            }
            else if (radioButton2.Checked)
            {
                functionsС.Visible = false;
                tableC.Visible = true;
            }
            else
            {
                functionsС.Visible = false;
                tableC.Visible = false;
            }
        }

        private void SlowDrawing_CheckedChanged(object sender, EventArgs e)
        {
            slow = SlowDrawing.Checked;
            if (SlowDrawing.Checked)
            {
                SpeedSlow.Visible = true;
            }
            else
            {
                SpeedSlow.Visible = false;
            }
        }

        private void SpeedSlow_Scroll(object sender, EventArgs e)
        {
            if (SpeedSlow.Value == 0)
            {
                slowspeed = 20;
            }
            else
            {
                slowspeed = SpeedSlow.Value * 20;
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
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length == 5)
            {
                textBox.Text = textBox.Text.Remove(4);
            }
            CentralXChenged();
        }

        private void CentralY_TextChanged(object sender, EventArgs e)
        {
            CentralYChenged();
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
            PointF[] points = new PointF[Math.Abs(min) + max];
            PointF[] pointsDraw = new PointF[Math.Abs(min) + max];
            int ip = 0;
            int o = min;
            for (int i = 0; i < points.Length; i++, o++)
            {
                points[i] = new PointF(o * plusM + centralX, Charts.TranslatingExpression.Translating(textBox1.Text,o) * plusM + centralY);
                EndsGraphMin(ref points, ref i, ref ip, ref pointsDraw);
            }
            EndsGraphMax(ref points, ref ip, ref pointsDraw);
            Array.Resize(ref pointsDraw, ip);
            PointF[] pointsDrawTemp = pointsDraw;
            SpeedDrawing(pointsDraw, graphics);
            nowPoints.Clear();
            nowTable.Rows.Clear();
            tableCompletion(pointsDraw);
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
                pointsDraw[i].X -= 330- byfX;
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
            nowTable.SuspendLayout();
            foreach (PointF point in nowPoints)
            {
                nowTable.Rows.Add(point.X, point.Y);
            }
            nowTable.ResumeLayout();
            PointsGraph.Text = (nowTable.Rows.Count-1).ToString();
        }

        void EndsGraphMin(ref PointF[] points,ref int i,ref int ip, ref PointF[] pointsDraw)
        {
            if (points[i].Y >= 0 && points[i].Y <= AreaPaint.Height)
            {
                if (ip == 0 && i > 0 && !points[i - 1].Y.Equals(float.NaN))
                {
                    pointsDraw[ip] = points[i - 1];
                    ip++;
                }
                pointsDraw[ip] = points[i];
                ip++;
            }
        }

        void EndsGraphMax(ref PointF[] points,ref int ip, ref PointF[] pointsDraw)
        {
            foreach (PointF point in points)
            {

                if (ip>0&&point.X == (pointsDraw[ip - 1].X + 1 * plusM))
                {
                    pointsDraw[ip] = point;
                    ip++;
                    break;
                }
            }
        }

        async void SpeedDrawing(PointF[] pointsDraw, Graphics graphics)
        {
            Pen pen = new Pen(Color.Black, 2f);
            if (pointsDraw.Length > 1)
            {
                if (!slow || redrawing)
                {
                    graphics.DrawLines(pen, pointsDraw);
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

        int LimitationsMax(int limitationUpX,int limitationDownX)
        {
            int lim = limitationUpX+1;
            int def = (AreaPaint.Width) / plusM + 2 + LimitationsMin(limitationDownX);
            if(lim<def)
            {
                return lim;
            }
            else
            {
                return def;
            }
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

        private void button4_Click(object sender, EventArgs e)
        {
            //double f = Math.Pow(341, 0.5);
            //label16.Text=Charts.TranslatingExpression.Translating(textBox1.Text).ToString();
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