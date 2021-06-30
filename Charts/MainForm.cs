using System;
using System.Drawing;
using System.Windows.Forms;

namespace Сhart
{
    public partial class MainForm : Form
    {
        NearestNeighbor nearestNeighbor = new NearestNeighbor();
        
        public MainForm()
        {
            InitializeComponent();
            AreaPaint.Refresh();
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
            Сhart.Paint.DrawLine(e, Color.Black, new Point(0, AreaPaint.Height - 3), new Point(AreaPaint.Width, AreaPaint.Height - 3));
            Сhart.Paint.DrawLine(e, Color.Black, new Point(0, 0), new Point(0, AreaPaint.Height));
            Сhart.Paint.DrawLine(e, Color.Black, new Point(AreaPaint.Width - 1, 0), new Point(AreaPaint.Width - 1, AreaPaint.Height));
            Сhart.Paint.DrawPoint(e, Color.Brown, new Point(AreaPaint.Width / 2, AreaPaint.Height / 2));
            Сhart.Paint.DrawLine(e, Color.Brown, new Point(AreaPaint.Width/2, 0), new Point(AreaPaint.Width/2, AreaPaint.Height));
            Сhart.Paint.DrawLine(e, Color.Brown, new Point(0, AreaPaint.Height/2), new Point(AreaPaint.Width, AreaPaint.Height/2));
            foreach (Point point in nearestNeighbor.GetPoints())
            {
                Сhart.Paint.DrawPoint(e, Color.Blue, point); 
            }
            for(int i = 0; i < nearestNeighbor.GetpointsSorted().Count-1; i++)
            {
                Сhart.Paint.DrawArrow(e, Color.Black, nearestNeighbor.GetpointsSorted()[i], nearestNeighbor.GetpointsSorted()[i+1]);
            }
            if (nearestNeighbor.GetpointsSorted().Count > 2)
            {
                Сhart.Paint.DrawArrow(e, Color.Black, nearestNeighbor.GetpointsSorted()[nearestNeighbor.GetpointsSorted().Count - 1], nearestNeighbor.GetpointsSorted()[0]);
                Сhart.Paint.BigRedPoint(e, Color.Red, nearestNeighbor.GetpointsSorted()[0]);
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
            if (SelectingFunction.SelectedIndex == 0)
            {
                label2.Text = "Степень";
                AdditionalParameter.Visible = true;
                label2.Visible = true;
            }
            else if (SelectingFunction.SelectedIndex == 1)
            {
                AdditionalParameter.Visible = false;
                label2.Visible = false;
            }
            else if (SelectingFunction.SelectedIndex == 2)
            {
                AdditionalParameter.Visible = false;
                label2.Visible = false;
            }
            else if (SelectingFunction.SelectedIndex == 3)
            {
                AdditionalParameter.Visible = false;
                label2.Visible = false;
            }
            else if (SelectingFunction.SelectedIndex == 4)
            {
                AdditionalParameter.Visible = false;
                label2.Visible = false;
            }
            else if (SelectingFunction.SelectedIndex == 5)
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
            int additionalParameter;
            if (!Int32.TryParse(AdditionalParameter.Text,out additionalParameter))
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
            if (SelectingFunction.SelectedIndex == 0)
            {
                PointF[] points = new PointF[650];
                for (int i = 0; i < points.Length; i++)
                {
                    points[i] = new PointF(i + AreaPaint.Width/2 + offSetX, (float)((-Math.Pow(i, additionalParameter) * multiplierI + offSetY) * CheckSign() + AreaPaint.Height / 2));
                    if (points[i].Y < -10000 || points[i].Y > 10000)
                    {
                        break;
                    }
                }
                graphics.DrawLines(pen, points);
                points = new PointF[650];
                for (int i = 0; i < points.Length; i++)
                {
                    points[i] = new PointF(-i + AreaPaint.Width / 2 + offSetX, (float)((-Math.Pow(i, additionalParameter) * multiplierI + offSetY) * CheckSign() + AreaPaint.Height / 2));
                    if (points[i].Y < -10000 || points[i].Y > 10000)
                    {
                        break;
                    }
                }
                graphics.DrawLines(pen, points);
            }
            else if (SelectingFunction.SelectedIndex == 1)
            {
                PointF[] points = new PointF[650];
                for (int i = 0; i < points.Length; i++)
                {
                    points[i] = new PointF((i + AreaPaint.Width / 2 + offSetX), (float)(-Math.Sqrt(i) * multiplierI + offSetY) * CheckSign() + AreaPaint.Height / 2);
                    if (points[i].Y < -10000 || points[i].Y > 10000)
                    {
                        break;
                    }
                }
                graphics.DrawLines(pen, points);
            }
            else if (SelectingFunction.SelectedIndex == 2)
            {
                PointF[] points = new PointF[650];
                for (int i = 0; i < points.Length; i++)
                {
                    points[i] = new PointF(i + AreaPaint.Width / 2 + offSetX, (-(float)Math.Sin(i) * multiplierI + offSetY) * CheckSign() + AreaPaint.Height / 2);
                    if (points[i].Y < -10000 || points[i].Y > 10000)
                    {
                        break;
                    }
                }
                graphics.DrawLines(pen, points);
                points = new PointF[650];
                for (int i = 0; i < points.Length; i++)
                {
                    points[i] = new PointF(-i + AreaPaint.Width / 2 + offSetX, (-(float)Math.Sin(-i) * multiplierI + offSetY) * CheckSign() + AreaPaint.Height / 2);
                    if (points[i].Y < -10000 || points[i].Y > 10000)
                    {
                        break;
                    }
                }
                graphics.DrawLines(pen, points);
            }
            else if (SelectingFunction.SelectedIndex == 3)
            {
                PointF[] points = new PointF[650];
                for (int i = 0; i < points.Length; i++)
                {
                    points[i] = new PointF(i + AreaPaint.Width / 2 + offSetX, (float)((-Math.Cos(i) * multiplierI + offSetY) * CheckSign() + AreaPaint.Height / 2));
                    if (points[i].Y < -10000 || points[i].Y > 10000)
                    {
                        break;
                    }
                }
                graphics.DrawLines(pen, points);
                points = new PointF[650];
                for (int i = 0; i < points.Length; i++)
                {
                    points[i] = new PointF(-i + AreaPaint.Width / 2 + offSetX, (float)((-Math.Cos(-i) * multiplierI + offSetY) * CheckSign() + AreaPaint.Height / 2));
                    if (points[i].Y < -10000 || points[i].Y > 10000)
                    {
                        break;
                    }
                }
                graphics.DrawLines(pen, points);
            }
            else if (SelectingFunction.SelectedIndex == 4)
            {
                pen = new Pen(Color.Black, 3f);
                graphics.DrawArc(pen, AreaPaint.Width / 2 - 42, AreaPaint.Height / 2 -30, 50 , 50, 135, 180);
                graphics.DrawArc(pen, -7 + AreaPaint.Width / 2, AreaPaint.Height / 2 -30, 50, 50, 225, 180);
                graphics.DrawLine(pen, AreaPaint.Width / 2 - 35, 12 + AreaPaint.Height / 2, 2 + AreaPaint.Width / 2, 49 + AreaPaint.Height/2);
                graphics.DrawLine(pen, 36 + AreaPaint.Width / 2, 12 + AreaPaint.Height / 2,  AreaPaint.Width / 2 - 1, 49 + AreaPaint.Height/2); 
            }
            else if (SelectingFunction.SelectedIndex == 5)
            {
                PointF[] points = new PointF[1500];
                float o=0;
                for (int i = 0; i < points.Length; i++)
                {

                    points[i] = new PointF(o *1000 ,(float)((Math.Pow(-o,2/3)-Math.Sqrt(Math.Pow(o,4/3)-4*o*o+4))/2)*1000);
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
    }
}