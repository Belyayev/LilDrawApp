using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LilDrawApp
{
    public partial class LilDrawForm : Form
    {
        public LilDrawForm()
        {
            InitializeComponent();
            SetSize();
        }

        private class ArrayPoints
        {
            private int index = 0;
            private Point[] points;

            public ArrayPoints(int size)
            {
                if(size <= 0) { size = 2; }
                points = new Point[size];
            }

            public void SetPoint(int x, int y)
            {
                if (index >= points.Length)
                {
                    index = 0;
                }
                points[index] = new Point(x, y);
                index++;
            }

            public void ResetPoints()
            {
                index = 0;
            }

            public  int GetCountPoints()
            {
                return index;
            }

            public Point[] GetPoints()
            {
                return points;
            }
        }

        private void fullScreenButton_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            escButton.Visible = true;
            fullScreenButton.Visible = false;
        }

        private void LilDrawForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
                escButton.Visible = false;
                fullScreenButton.Visible = true;
            }
        }

        private void drawingArea_Click(object sender, EventArgs e)
        {

        }

        private bool isMouse = false;
        private ArrayPoints arrayPoints = new ArrayPoints(2);

        Bitmap map = new Bitmap(100, 100);
        Graphics graphics;
        Pen pen = new Pen(Color.Black, 3f);

        private void SetSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            map = new Bitmap(rectangle.Width, rectangle.Height);
            graphics = Graphics.FromImage(map);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void drawingArea_MouseDown(object sender, MouseEventArgs e)
        {
            isMouse = true;

        }

        private void drawingArea_MouseUp(object sender, MouseEventArgs e)
        {
            isMouse = false;
            arrayPoints.ResetPoints();
        }

        private void drawingArea_MouseMove(object sender, MouseEventArgs e)
        {
            if(!isMouse) { return; }
            arrayPoints.SetPoint(e.X, e.Y);
            if(arrayPoints.GetCountPoints() >= 2)
            {
                graphics.DrawLines(pen, arrayPoints.GetPoints());
                drawingArea.Image = map;
                arrayPoints.SetPoint(e.X, e.Y);
            }
        }

        private void colorSelect_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(drawingArea.BackColor);
            drawingArea.Image = map;
        }
        private void buttonXS_Click(object sender, EventArgs e)
        {
            pen.Width = 1;
            BrushSizeButtonReset();
            buttonXS.BackColor = Color.Yellow;
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            pen.Width = 3;
            BrushSizeButtonReset();
            buttonS.BackColor = Color.Yellow;
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            pen.Width = 5;
            BrushSizeButtonReset();
            buttonM.BackColor = Color.Yellow;
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            pen.Width = 8;
            BrushSizeButtonReset();
            buttonL.BackColor = Color.Yellow;
        }

        private void buttonXL_Click(object sender, EventArgs e)
        {
            pen.Width = 14;
            BrushSizeButtonReset();
            buttonXL.BackColor = Color.Yellow;
        }

        private void BrushSizeButtonReset()
        {
            buttonXS.BackColor = Color.White;
            buttonS.BackColor = Color.White;
            buttonM.BackColor = Color.White;
            buttonL.BackColor = Color.White;
            buttonXL.BackColor = Color.White;
        }

    }
}
