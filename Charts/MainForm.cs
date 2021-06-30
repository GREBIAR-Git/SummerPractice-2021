using System;
using System.Drawing;
using System.Windows.Forms;

namespace Сhart
{
    public partial class MainForm : Form
    {

        int centralX, centralY;

        int plusM=1;
        NearestNeighbor nearestNeighbor = new NearestNeighbor();
        
        public MainForm()
        {
            InitializeComponent();
            AreaPaint.Refresh();
            centralX = AreaPaint.Width / 2;
            centralY = AreaPaint.Height / 2;
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
            foreach (Point point in nearestNeighbor.GetPoints())
            {
                Сhart.Paint.DrawPoint(e, Color.Blue, point);
            }
            for (int i = 0; i < nearestNeighbor.GetpointsSorted().Count - 1; i++)
            {
                Сhart.Paint.DrawArrow(e, Color.Black, nearestNeighbor.GetpointsSorted()[i], nearestNeighbor.GetpointsSorted()[i + 1]);
            }
            if (nearestNeighbor.GetpointsSorted().Count > 2)
            {
                Сhart.Paint.DrawArrow(e, Color.Black, nearestNeighbor.GetpointsSorted()[nearestNeighbor.GetpointsSorted().Count - 1], nearestNeighbor.GetpointsSorted()[0]);
                Сhart.Paint.BigRedPoint(e, Color.Red, nearestNeighbor.GetpointsSorted()[0]);
            }
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

            Pen pen = new Pen(Color.Black, 2f);
            if (SelectingFunction.SelectedIndex == 1)
            {
                PointF[] points = new PointF[AreaPaint.Width];
                for (int i = 0; i < points.Length; i++)
                {
                    points[i] = new PointF((i + offSetX) * plusM + centralX, (float)((-Math.Pow(i, additionalParameter) * multiplierI + offSetY) * plusM * CheckSign() + centralY));
                    if (points[i].Y < -10000 || points[i].Y > 10000)
                    {
                        Array.Resize(ref points, i);
                        break;
                    }
                }
                graphics.DrawLines(pen, points);
                for (int i = 0; i < points.Length; i++)
                {
                    points[i] = new PointF((-i + offSetX) * plusM + centralX, (float)((-Math.Pow(i, additionalParameter) * multiplierI + offSetY) * plusM * CheckSign() + centralY));
                    if (points[i].Y < -10000 || points[i].Y > 10000)
                    {
                        Array.Resize(ref points, i);
                        break;
                    }
                }
                graphics.DrawLines(pen, points);
            }
            else if (SelectingFunction.SelectedIndex == 2)
            {
                PointF[] points = new PointF[AreaPaint.Width];
                for (int i = 0; i < points.Length; i++)
                {
                    points[i] = new PointF(((i + offSetX) * plusM + centralX), (float)(-Math.Sqrt(i) * multiplierI + offSetY) * plusM * CheckSign() + centralY);
                    if (points[i].Y < -10000 || points[i].Y > 10000)
                    {
                        Array.Resize(ref points, i);
                        break;
                    }
                }
                graphics.DrawLines(pen, points);
            }
            else if (SelectingFunction.SelectedIndex == 3)
            {
                PointF[] points = new PointF[AreaPaint.Width];
                for (int i = 0; i < points.Length; i++)
                {
                    points[i] = new PointF((i + offSetX) * plusM + centralX, (-(float)Math.Sin(i) * multiplierI + offSetY) * plusM * CheckSign() + centralY);
                    if (points[i].Y < -10000 || points[i].Y > 10000)
                    {
                        Array.Resize(ref points, i);
                        break;
                    }
                }
                graphics.DrawLines(pen, points);
                points = new PointF[AreaPaint.Width];
                for (int i = 0; i < points.Length; i++)
                {
                    points[i] = new PointF((-i + offSetX) * plusM + centralX, (-(float)Math.Sin(-i) * multiplierI + offSetY) * plusM * CheckSign() + centralY);
                    if (points[i].Y < -10000 || points[i].Y > 10000)
                    {
                        Array.Resize(ref points, i);
                        break;
                    }
                }
                graphics.DrawLines(pen, points);
            }
            else if (SelectingFunction.SelectedIndex == 4)
            {
                PointF[] points = new PointF[AreaPaint.Width];
                for (int i = 0; i < points.Length; i++)
                {
                    points[i] = new PointF((i + offSetX) * plusM + centralX, (float)((-Math.Cos(i) * multiplierI + offSetY) * plusM * CheckSign() + centralY));
                    if (points[i].Y < -10000 || points[i].Y > 10000)
                    {
                        Array.Resize(ref points, i);
                        break;
                    }
                }
                graphics.DrawLines(pen, points);
                points = new PointF[AreaPaint.Width];
                for (int i = 0; i < points.Length; i++)
                {
                    points[i] = new PointF((-i + offSetX) * plusM + centralX, (float)((-Math.Cos(-i) * multiplierI + offSetY) * plusM * CheckSign() + centralY));
                    if (points[i].Y < -10000 || points[i].Y > 10000)
                    {
                        Array.Resize(ref points, i);
                        break;
                    }
                }
                graphics.DrawLines(pen, points);
            }
            else if (SelectingFunction.SelectedIndex == 5)
            {
                pen = new Pen(Color.Black, 3f);
                graphics.DrawArc(pen, centralX - 42, centralY - 30, 50, 50, 135, 180);
                graphics.DrawArc(pen, -7 + centralX, centralY - 30, 50, 50, 225, 180);
                graphics.DrawLine(pen, centralX - 35, 12 + centralY, 2 + centralX, 49 + centralY);
                graphics.DrawLine(pen, 36 + centralX, 12 + centralY, centralX - 1, 49 + centralY);
            }
            else if (SelectingFunction.SelectedIndex == 5)
            {
                PointF[] points = new PointF[AreaPaint.Width];
                float o = 0;
                for (int i = 0; i < points.Length; i++)
                {

                    points[i] = new PointF(o * 1000, (float)((Math.Pow(-o, 2 / 3) - Math.Sqrt(Math.Pow(o, 4 / 3) - 4 * o * o + 4)) / 2) * 1000);
                    /*if (points[o].Y < -10000 || points[o].Y > 10000)
                    {
                        break;
                    }*/
                    o += 0.001f;
                }
                graphics.DrawLines(pen, points);
                /*points = new PointF[650];
                for (int i = 0; i < points.Length; i++)
                {
                    points[i] = new PointF(-i + AreaPaint.Width / 2 + offSetX, (-(float)Math.Cos(-i) * multiplierI + offSetY) * CheckSign() + AreaPaint.Height / 2);
                    if (points[i].Y < -10000 || points[i].Y > 10000)
                    {
                        break;
                    }
                }
                graphics.DrawLines(pen, points);*/
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

        private void button3_Click(object sender, EventArgs e)
        {
            viewTable.Visible = !viewTable.Visible;
            AreaPaint.Refresh();
            CentralXChenged();
            AreaPaint.Visible = true;
            CentralYChenged();
            AreaPaint.Refresh();
        }

        private void PercentScrolling_Scroll(object sender, EventArgs e)
        {
            if(PercentScrolling.Value!=0)
            {
                plusM = PercentScrolling.Value * 11;
                AreaPaint.Refresh();
                Percent.Text = "1:" + plusM;
                CentralXChenged();
                CentralYChenged();
            }
            else
            {
                plusM = 1;
                AreaPaint.Refresh();
                Percent.Text = "1:1";
                CentralXChenged();
                CentralYChenged();
            }
        }
    }
}