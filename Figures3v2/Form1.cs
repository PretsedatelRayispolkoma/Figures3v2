using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures3v2
{
    public partial class Form1 : Form
    {
        private Bitmap area;
        private Graphics graphics;
        Point point;
        Pen pen;

        public Form1()
        {
            InitializeComponent();
            Text = "Paint";
            area = new Bitmap(drawPanel.Width, drawPanel.Height);
            graphics = Graphics.FromImage(area);
        }

        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(area, new Point(0, 0));
        }

        private void lineButton_CheckedChanged(object sender, EventArgs e)
        {
            if (lineButton.Checked)
            {
                corX1.Enabled = true;
                corY1.Enabled = true;
                corX2.Enabled = true;
                corY2.Enabled = true;
                r1.Enabled = false;
                r2.Enabled = false;
                corX3.Enabled = false;
                corY3.Enabled = false;
            }
            else if (circleButton.Checked)
            {
                corX1.Enabled = true;
                corY1.Enabled = true;
                corX2.Enabled = false;
                corY2.Enabled = false;
                r1.Enabled = true;
                r2.Enabled = true;
                corX3.Enabled = false;
                corY3.Enabled = false;
            }
        }

        private void triangleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (triangleButton.Checked)
            {
                corX1.Enabled = true;
                corY1.Enabled = true;
                corX2.Enabled = true;
                corY2.Enabled = true;
                r1.Enabled = false;
                r2.Enabled = false;
                corX3.Enabled = true;
                corY3.Enabled = true;
            }
            else if (rectangleButton.Checked)
            {
                corX1.Enabled = true;
                corY1.Enabled = true;
                corX2.Enabled = true;
                corY2.Enabled = true;
                r1.Enabled = false;
                r2.Enabled = false;
                corX3.Enabled = false;
                corY3.Enabled = false;
            }
            else
            {
                corX1.Enabled = true;
                corY1.Enabled = true;
                corX2.Enabled = false;
                corY2.Enabled = false;
                r1.Enabled = true;
                r2.Enabled = true;
                corX3.Enabled = false;
                corY3.Enabled = false;
            }
        }

        private void rectangleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rectangleButton.Checked)
            {
                corX1.Enabled = true;
                corY1.Enabled = true;
                corX2.Enabled = true;
                corY2.Enabled = true;
                r1.Enabled = false;
                r2.Enabled = false;
                corX3.Enabled = false;
                corY3.Enabled = false;
            }
            else if (circleButton.Checked)
            {
                corX1.Enabled = true;
                corY1.Enabled = true;
                corX2.Enabled = false;
                corY2.Enabled = false;
                r1.Enabled = true;
                r2.Enabled = true;
                corX3.Enabled = false;
                corY3.Enabled = false;
            }
        }

        int x1; int x2; int x3;
        int y1; int y2; int y3;
        int rad1; int rad2;
        private void createButton_Click(object sender, EventArgs e)
        {
            pen = new Pen(colorDialog1.Color, trackBar1.Value);

            if (lineButton.Checked)
            {
                x1 = int.Parse(corX1.Text);
                y1 = int.Parse(corY1.Text);
                x2 = int.Parse(corX2.Text);
                y2 = int.Parse(corY2.Text);
                graphics.DrawLine(pen, x1, y1, x2, y2);
            }
            else
            {
                if (triangleButton.Checked)
                {
                    x1 = int.Parse(corX1.Text);
                    y1 = int.Parse(corY1.Text);
                    x2 = int.Parse(corX2.Text);
                    y2 = int.Parse(corY2.Text);
                    x3 = int.Parse(corX3.Text);
                    y3 = int.Parse(corY3.Text);
                    graphics.DrawLine(pen, x1, y1, x2, y2);
                    graphics.DrawLine(pen, x2, y2, x3, y3);
                    graphics.DrawLine(pen, x3, y3, x1, y1);
                }
                else
                {
                    if(circleButton.Checked)
                    {
                        x1 = int.Parse(corX1.Text);
                        y1 = int.Parse(corY1.Text);
                        rad1 = int.Parse(r1.Text);
                        rad2 = int.Parse(r2.Text);
                        graphics.DrawEllipse(pen, x1, y1, rad1, rad2);
                    }
                    else
                    {
                        if(rectangleButton.Checked)
                        {
                            x1 = int.Parse(corX1.Text);
                            y1 = int.Parse(corY1.Text);
                            x2 = int.Parse(corX2.Text);
                            y2 = int.Parse(corY2.Text);
                            Point[] P =
                            {
                                new Point(x1 , y1),
                                new Point(x1 , y2),
                                new Point(x2 , y2),
                                new Point(x2 , y1),
                            };
                            graphics.DrawPolygon(pen, P);
                        }
                    }
                }
            }
            drawPanel.Refresh();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();     
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save";
             if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                area.Save(saveFileDialog1.FileName + ".png");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            drawPanel.Refresh();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Load";
            openFileDialog1.ShowDialog();
        }

        private void drawPanel_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                point = e.Location;
                graphics.DrawEllipse(pen, point.X, point.Y, radiusBar.Value, radiusBar.Value);
                drawPanel.Refresh();
            }
            catch(Exception)
            {}
        }

        private void lblRad_Click(object sender, EventArgs e)
        { }
        
        private void trackBar1_Scroll(object sender, EventArgs e)
        {}

        private void controlPanel_Paint(object sender, PaintEventArgs e)
        {}
    }
}

