using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сhart
{
    public partial class MainForm : Form
    {
        bool chart;
        int centralX, centralY, plusM;
        bool slow;
        int slowspeed;
        bool redrawing;
        NearestNeighbor nearestNeighbor = new NearestNeighbor();
        List<PointF> nowPoints = new List<PointF>();
        Point lastpoint = new Point();
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
            chart = false;

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

        private void comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            AreaPaint.Refresh();
        }

        private void AreaPaint_Paint(object sender, PaintEventArgs e)
        {
            Сhart.Paint.DrawLine(e, Color.Black, new Point(0, 0), new Point(AreaPaint.Width, 0));
            Сhart.Paint.DrawLine(e, Color.Black, new Point(0, AreaPaint.Height - 1), new Point(AreaPaint.Width, AreaPaint.Height - 1));
            Сhart.Paint.DrawLine(e, Color.Black, new Point(0, 0), new Point(0, AreaPaint.Height));
            Сhart.Paint.DrawLine(e, Color.Black, new Point(AreaPaint.Width - 1, 0), new Point(AreaPaint.Width - 1, AreaPaint.Height));
            Сhart.Paint.DrawPoint(e, Color.Brown, new Point(centralX, centralY));
            Сhart.Paint.DrawLine(e, Color.Brown, new Point(centralX, 0), new Point(centralX, AreaPaint.Height));
            Сhart.Paint.DrawLine(e, Color.Brown, new Point(0, centralY), new Point(AreaPaint.Width, centralY));
            if (plusM > 8)
            {
                for (int i = AreaPaint.Width/2; i < AreaPaint.Width; i += plusM)
                {
                    e.Graphics.DrawLine(new Pen(Color.Brown, 1), new Point(i + plusM, 0), new Point(i + plusM, AreaPaint.Height));
                }
                for (int i = AreaPaint.Width / 2; i > 0-plusM; i -= plusM)
                {
                    e.Graphics.DrawLine(new Pen(Color.Brown, 1), new Point(i + plusM, 0), new Point(i + plusM, AreaPaint.Height));
                }
                for (int f = AreaPaint.Height / 2; f < AreaPaint.Height; f += plusM)
                {
                    e.Graphics.DrawLine(new Pen(Color.Brown, 1), new Point(0, f + plusM), new Point(AreaPaint.Width, f + plusM));
                }
                for (int f = AreaPaint.Height / 2; f > 0-plusM; f -= plusM)
                {
                    e.Graphics.DrawLine(new Pen(Color.Brown, 1), new Point(0, f + plusM), new Point(AreaPaint.Width, f + plusM));
                }
            }
            if(chart)
            {
                PaintChart(e.Graphics);
            }
        }

        int CheckSign()
        {
            if (plus.Checked)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        private void SelectingFunction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SelectingFunction.SelectedIndex == 0)
            {
                chart = false;
                AreaPaint.Refresh();
                nowTable.Rows.Clear();
            }
            else if (SelectingFunction.SelectedIndex == 1)
            {
                label2.Text = "Степень";
                AdditionalParameter.Visible = true;
                label2.Visible = true;
                chart = true;
            }
            else 
            {
                AdditionalParameter.Visible = false;
                label2.Visible = false;
                chart = true;
            }
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

        void PaintChart(Graphics graphics)
        {
            int additionalParameter;
            if (!Int32.TryParse(AdditionalParameter.Text, out additionalParameter))
            {
                additionalParameter = 0;
                AdditionalParameter.Text = "0";
            }
            int offSetX;
            if (!Int32.TryParse(offsetX.Text, out offSetX))
            {
                offSetX = 0;
                offsetX.Text = "0";
            }
            int multiplierI;
            if (!Int32.TryParse(multiplier.Text, out multiplierI))
            {
                multiplierI = 1;
                multiplier.Text = "1";
            }
            int offSetY;
            if (!Int32.TryParse(offsetY.Text, out offSetY))
            {
                offSetY = 0;
                offsetY.Text = "0";
            }
            int limitationDownX;
            if (!Int32.TryParse(LimitationDownX.Text, out limitationDownX))
            {
                limitationDownX = int.MinValue;
                LimitationDownX.Text = "0";
            }
            int limitationUpX;
            if (!Int32.TryParse(LimitationUpX.Text, out limitationUpX))
            {
                limitationUpX = int.MaxValue;
                LimitationUpX.Text = "0";
            }
            int limitationDownY;
            if (!Int32.TryParse(LimitationDownY.Text, out limitationDownY))
            {
                limitationDownY = int.MinValue;
                LimitationDownY.Text = "0";
            }
            int limitationUpY;
            if (!Int32.TryParse(LimitationUpY.Text, out limitationUpY))
            {
                limitationUpY = int.MaxValue;
                LimitationUpY.Text = "0";
            }
            if(SelectingFunction.SelectedIndex == 5)
            {
                Pen pen = new Pen(Color.Black, 3f);
                graphics.DrawArc(pen, centralX - 42, centralY - 30, 50, 50, 135, 180);
                graphics.DrawArc(pen, -7 + centralX, centralY - 30, 50, 50, 225, 180);
                graphics.DrawLine(pen, centralX - 35, 12 + centralY, 2 + centralX, 49 + centralY);
                graphics.DrawLine(pen, 36 + centralX, 12 + centralY, centralX - 1, 49 + centralY);
            }
            else
            {
                int min = LimitationsMin();
                int max = LimitationsMax();
                PointF[] points = new PointF[Math.Abs(min) + max];
                PointF[] pointsDraw = new PointF[Math.Abs(min) + max];
                int ip = 0;
                int o = min;
                for (int i = 0; i < points.Length; i++, o++)
                {
                    if (SelectingFunction.SelectedIndex == 1)
                    {
                        points[i] = new PointF((o + offSetX) * plusM + centralX, (float)((-Math.Pow(o, additionalParameter) * multiplierI + offSetY) * plusM * CheckSign() + centralY));
                    }
                    else if (SelectingFunction.SelectedIndex == 2)
                    {
                        points[i] = new PointF(((o + offSetX) * plusM + centralX), (float)(-Math.Sqrt(o) * multiplierI + offSetY) * plusM * CheckSign() + centralY);
                    }
                    else if (SelectingFunction.SelectedIndex == 3)
                    {
                        points[i] = new PointF((o + offSetX) * plusM + centralX, (-(float)Math.Sin(o) * multiplierI + offSetY) * plusM * CheckSign() + centralY);
                    }
                    else if (SelectingFunction.SelectedIndex == 4)
                    {
                        points[i] = new PointF((o + offSetX) * plusM + centralX, (-(float)Math.Cos(o) * multiplierI + offSetY) * plusM * CheckSign() + centralY);
                    }
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

        int LimitationsMin()
        {
            return -(centralX / plusM + 1) ;
        }
        int LimitationsMax()
        {
            return (AreaPaint.Width) / plusM + 2 + LimitationsMin();
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
            int byf;
            if (Int32.TryParse(CentralX.Text, out byf))
            {
                if(byf>999)
                {
                    CentralX.Text = "999";
                    byf = 999;
                }
                else if (byf < -999)
                {
                    CentralX.Text = "-999";
                    byf = -999;
                }
                centralX = AreaPaint.Width / 2 - byf * plusM;
                AreaPaint.Refresh();
            }
            else
            {
                centralX = AreaPaint.Width / 2;
                AreaPaint.Refresh();
            }
        }

        void CentralYChenged()
        {
            int byf;
            if (Int32.TryParse(CentralY.Text, out byf))
            {
                if (byf > 999)
                {
                    CentralY.Text = "999";
                    byf = 999;
                }
                else if (byf < -999)
                {
                    CentralY.Text = "-999";
                    byf = -999;
                }
                centralY = AreaPaint.Height / 2 + byf * plusM;
                AreaPaint.Refresh();
            }
            else
            {
                centralY = AreaPaint.Height / 2;
                AreaPaint.Refresh();
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                functionsС.Visible = true;
                tableC.Visible = false;
                freeC.Visible = false;
            }
            else if (radioButton2.Checked)
            {
                functionsС.Visible = false ;
                tableC.Visible = true;
                freeC.Visible = false;
            }
            else
            {
                functionsС.Visible = false;
                tableC.Visible = false;
                freeC.Visible = true;
            }
        }

        private void SlowDrawing_CheckedChanged(object sender, EventArgs e)
        {
            slow = SlowDrawing.Checked;
            if (SlowDrawing.Checked)
            {
                Slow1.Visible = true;
                Slow2.Visible = true;
                Slow3.Visible = true;
            }
            else
            {
                Slow1.Visible = false;
                Slow2.Visible = false;
                Slow3.Visible = false;
            }
        }

        private void Slow_CheckedChanged(object sender, EventArgs e)
        {
            if(Slow1.Checked)
            {
                slowspeed = 10;
            }
            else if(Slow2.Checked)
            {
                slowspeed = 100;
            }
            else if (Slow3.Checked)
            {
                slowspeed = 1000;
            }
            else
            {
                slowspeed = 0;
            }
        }

        private void AreaPaint_MouseMove(object sender, MouseEventArgs e)
        {
            int coorX = (e.X - centralX) / plusM;
            int coorY = (centralY - e.Y) / plusM;
            if (lastpoint.X== coorX && lastpoint.Y==coorY)
            {
                return;
            }
            lastpoint.X = coorX;
            lastpoint.Y = coorY;
            float sizeСircle = plusM / 5.5f+30/plusM;
            if(plusM<9)
            {
                sizeСircle = 0;
            }
            AreaPaint.Refresh();
            coordinates.Text = "x = "+coorX.ToString()+";  y = "+ coorY.ToString()+";";
            Graphics graphics = AreaPaint.CreateGraphics();
            graphics.FillEllipse(new SolidBrush(Color.FromArgb(0, 191, 255)), centralX - sizeСircle / 2 + coorX*plusM, centralY - sizeСircle / 2 - coorY*plusM, sizeСircle, sizeСircle);
        }

        private void AreaPaint_MouseLeave(object sender, EventArgs e)
        {
            coordinates.Text = "Не в зоны действия";
            AreaPaint.Refresh();
            lastpoint.Y = 1000;
            lastpoint.X = 1000;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewTable.Visible = !viewTable.Visible;
            CentralXChenged();
            CentralYChenged();
        }

        private void PercentScrolling_Scroll(object sender, EventArgs e)
        {
            if(PercentScrolling.Value!=0)
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
    }
}