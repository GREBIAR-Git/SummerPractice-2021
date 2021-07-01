using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сhart
{
    public partial class MainForm : Form
    {

        int centralX, centralY, plusM;
        bool slow;
        int slowspeed;
        NearestNeighbor nearestNeighbor = new NearestNeighbor();
        
        public MainForm()
        {
            InitializeComponent();
            AreaPaint.Refresh();
            centralX = AreaPaint.Width / 2;
            centralY = AreaPaint.Height / 2;
            plusM = 1;
            slow = false;
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
            PaintChart(e.Graphics);
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
            if (SelectingFunction.SelectedIndex == 1)
            {
                label2.Text = "Степень";
                AdditionalParameter.Visible = true;
                label2.Visible = true;
            }
            else 
            {
                AdditionalParameter.Visible = false;
                label2.Visible = false;
            }
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            Graphics graphics = AreaPaint.CreateGraphics();
            graphics.Clear(Color.White);
            AreaPaint.Refresh();
            PaintChart(graphics);
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

            if (SelectingFunction.SelectedIndex == 1)
            {
                PointF[] points = new PointF[AreaPaint.Width];
                PointF[] pointsDraw = new PointF[AreaPaint.Width];
                int ip = 0;
                int o = -AreaPaint.Width/2;
                for (int i = 0; i < AreaPaint.Width; i++, o++)
                {
                    points[i] = new PointF((o + offSetX) * plusM + centralX, (float)((-Math.Pow(o, additionalParameter) * multiplierI + offSetY) * plusM * CheckSign() + centralY));
                    EndsGraphMin(ref points, ref i, ref ip, ref pointsDraw);
                }
                EndsGraphMax(ref points, ref ip, ref pointsDraw);
                Array.Resize(ref pointsDraw, ip);
                SpeedDrawing(pointsDraw);
            }
            else if (SelectingFunction.SelectedIndex == 2)
            {
                PointF[] points = new PointF[AreaPaint.Width];
                PointF[] pointsDraw = new PointF[AreaPaint.Width];
                int ip = 0;
                int o = -AreaPaint.Width / 2;
                for (int i = 0; i < AreaPaint.Width; i++, o++)
                {
                    points[i] = new PointF(((i + offSetX) * plusM + centralX), (float)(-Math.Sqrt(i) * multiplierI + offSetY) * plusM * CheckSign() + centralY);
                    EndsGraphMin(ref points, ref i, ref ip, ref pointsDraw);
                }
                EndsGraphMax(ref points, ref ip, ref pointsDraw);
                Array.Resize(ref pointsDraw, ip);
                SpeedDrawing(pointsDraw);
            }
            else if (SelectingFunction.SelectedIndex == 3)
            {
                PointF[] points = new PointF[AreaPaint.Width];
                PointF[] pointsDraw = new PointF[AreaPaint.Width];
                int ip = 0;
                int o = -AreaPaint.Width / 2;
                for (int i = 0; i < AreaPaint.Width; i++, o++)
                {
                    points[i] = new PointF((o + offSetX) * plusM + centralX, (-(float)Math.Sin(o) * multiplierI + offSetY) * plusM * CheckSign() + centralY);
                    EndsGraphMin(ref points, ref i, ref ip, ref pointsDraw);
                }
                EndsGraphMax(ref points, ref ip, ref pointsDraw);
                Array.Resize(ref pointsDraw, ip);
                SpeedDrawing(pointsDraw);
            }
            else if (SelectingFunction.SelectedIndex == 4)
            {
                PointF[] points = new PointF[AreaPaint.Width];
                PointF[] pointsDraw = new PointF[AreaPaint.Width];
                int ip = 0;
                int o = -AreaPaint.Width / 2;
                for (int i = 0; i < AreaPaint.Width; i++, o++)
                {
                    points[i] = new PointF((o + offSetX) * plusM + centralX, (-(float)Math.Cos(o) * multiplierI + offSetY) * plusM * CheckSign() + centralY);
                    EndsGraphMin(ref points, ref i, ref ip, ref pointsDraw);
                }
                EndsGraphMax(ref points, ref ip, ref pointsDraw);
                Array.Resize(ref pointsDraw, ip);
                SpeedDrawing(pointsDraw);
            }
            else if (SelectingFunction.SelectedIndex == 5)
            {
                /*pen = new Pen(Color.Black, 3f);
                graphics.DrawArc(pen, centralX - 42, centralY - 30, 50, 50, 135, 180);
                graphics.DrawArc(pen, -7 + centralX, centralY - 30, 50, 50, 225, 180);
                graphics.DrawLine(pen, centralX - 35, 12 + centralY, 2 + centralX, 49 + centralY);
                graphics.DrawLine(pen, 36 + centralX, 12 + centralY, centralX - 1, 49 + centralY);*/
            }
        }

        void EndsGraphMin(ref PointF[] points,ref int i,ref int ip, ref PointF[] pointsDraw)
        {
            if ((points[i].Y < 0 || points[i].Y > AreaPaint.Height)&&(points[i].X < 0 || points[i].X > AreaPaint.Width))
            {

            }
            else
            {
                if (ip == 0 && i > 0)
                {
                    pointsDraw[ip] = points[i - 1];
                    ip++;
                }
                else
                {
                    pointsDraw[ip] = points[i];
                    ip++;
                }
            }
        }

        void EndsGraphMax(ref PointF[] points,ref int ip, ref PointF[] pointsDraw)
        {
            foreach (PointF point in points)
            {
                if (point.X == (pointsDraw[ip - 1].X + 1 * plusM))
                {
                    pointsDraw[ip] = point;
                    ip++;
                    break;
                }
            }
        }

        async void SpeedDrawing(PointF[] pointsDraw)
        {
            Pen pen = new Pen(Color.Black, 2f);
            Graphics graphics = AreaPaint.CreateGraphics();
            if (!slow)
            {
                graphics.DrawLines(pen, pointsDraw);
            }
            else
            {
                for (int f = 0; pointsDraw.Length - 1 > f; f++)
                {
                    await Task.Delay(slowspeed);
                    graphics = AreaPaint.CreateGraphics();
                    graphics.DrawLine(pen, pointsDraw[f], pointsDraw[f + 1]);
                }
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
            int byf;
            if (Int32.TryParse(CentralX.Text, out byf))
            {
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