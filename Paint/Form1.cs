using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;
        }
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        int index;
        Color pickedColor = Color.Black;

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            if (index == 3)
            {
                FloodFill(e.Location, p.Color);
            }
            else
            {
                paint = true;
                py = e.Location;
            }
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            btnCor.BackColor = p.Color;
            if (paint)
            {
                if (index != 0)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
            }
            pic.Refresh();
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                p.Color = colorDialog.Color;
            }
        }

        private void brush_Click(object sender, EventArgs e)
        {
            index = 1;
            p.Width = 6;
            Cursor = Cursors.Cross;
        }

        private void pencil_Click(object sender, EventArgs e)
        {
            index = 2;
            p.Width = 2;
            Cursor = Cursors.Cross;
        }

        private void paint_bucket_Click(object sender, EventArgs e)
        {
            index = 3;
            Cursor = Cursors.Cross;
        }

        private void eraser_Click(object sender, EventArgs e)
        {
            index = 4;
            p.Width = 40;
            p.Color = Color.White;
            Cursor = Cursors.SizeAll;
        }

        private void dropper_Click(object sender, EventArgs e)
        {
            index = 5;
            Cursor = Cursors.Cross;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            sfd.FileName = "Sem título";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        private int fullscreen = 0;

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            if (fullscreen == 0)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                fullscreen = 1;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                fullscreen = 0;
            }
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 5)
            {
                pickedColor = bm.GetPixel(e.X, e.Y);
                p.Color = pickedColor;
                pic.Invalidate();
            }
        }

        private void FloodFill(Point start, Color fillColor)
        {
            Color targetColor = bm.GetPixel(start.X, start.Y);
            if (targetColor == fillColor) return;

            Queue<Point> pixels = new Queue<Point>();
            pixels.Enqueue(start);

            while (pixels.Count > 0)
            {
                Point pt = pixels.Dequeue();
                if (bm.GetPixel(pt.X, pt.Y) != targetColor) continue;

                bm.SetPixel(pt.X, pt.Y, fillColor);

                if (pt.X > 0) pixels.Enqueue(new Point(pt.X - 1, pt.Y));
                if (pt.X < bm.Width - 1) pixels.Enqueue(new Point(pt.X + 1, pt.Y));
                if (pt.Y > 0) pixels.Enqueue(new Point(pt.X, pt.Y - 1));
                if (pt.Y < bm.Height - 1) pixels.Enqueue(new Point(pt.X, pt.Y + 1));
            }
            pic.Refresh();
        }
    }
}