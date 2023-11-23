    using System;
    using System.Windows.Forms;
    using System.Drawing;
    using System.Drawing.Drawing2D;

namespace ChatDemo
{
    public class RoundedButtons : Button
    {
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.White;

        public RoundedButtons()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
        }

        private GraphicsPath getFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath gPath = new GraphicsPath();
            gPath.StartFigure();
            gPath.AddArc(rect.X, rect.Y, radius, radius, 180, 90);//top left
            gPath.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);//top right
            gPath.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);// bottom right
            gPath.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);//bottom left
            gPath.CloseFigure();
            return gPath;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8f, this.Height - 1);
            if (borderRadius > 2)
            {
                using (GraphicsPath pathSurface = getFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = getFigurePath(rectBorder, borderRadius - 1f))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    if (borderSize >= 1)
                    {
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                    }

                }
            }
            else
            {
                this.Region = new Region(rectSurface);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                Invalidate();
            }
        }
    }
}
