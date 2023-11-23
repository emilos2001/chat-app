using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ChatDemo
{
    class RoundLabel : Control
    {
        private int radius = 15;
        public Label label = new Label();
        private GraphicsPath shape;
        private GraphicsPath innerRect;
        private Color br;
        private Color placeHolderColor;
        private string placeHolderText;
        private bool isPlaceHolder;

        public RoundLabel()
        {
            base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.ResizeRedraw, true);
            this.label.Parent = this;
            this.Controls.Add(this.label);
            label.Font = this.Font;
            this.ForeColor = Color.Black;
            this.br = Color.White;
            label.BackColor = this.br;
            this.label.BorderStyle = BorderStyle.None;
            this.Text = null;
            this.Font = new Font("Sans Serif", 12F);
            this.DoubleBuffered = true;
        }

        private void textBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RemoveTextHolder();
            }
        }

        private void SetTextHolder()
        {
            if (string.IsNullOrWhiteSpace(label.Text) && placeHolderText != "")
            {
                isPlaceHolder = true;
                label.Text = placeHolderText;
                label.ForeColor = placeHolderColor;
            }
        }

        private void RemoveTextHolder()
        {
            if (isPlaceHolder && placeHolderText != "")
            {
                isPlaceHolder = false;
                label.Text = " ";
                label.ForeColor = this.ForeColor;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            this.Text = label.Text;
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            label.Font = this.Font;
            base.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.shape = new MyRectangle((float)base.Width, (float)base.Height, (float)this.radius, 0F, 0F).Path;
            this.innerRect = new MyRectangle(this.Width - 0.5F, this.Height - 0.5F, (float)this.radius, 0.5F, 0.5F).Path;
            if (label.Height >= (this.Height - 1))
            {
                base.Height = label.Height + 2;
            }
            label.Location = new Point(this.radius, (base.Height / 5) - (label.Font.Height / 2));
            label.Width = base.Width - ((int)(this.radius * 1.5));
            e.Graphics.SmoothingMode = ((SmoothingMode)SmoothingMode.HighQuality);
            Bitmap bitmap = new Bitmap(base.Width, base.Height);
            Graphics graphics = Graphics.FromImage((Image)bitmap);
            e.Graphics.DrawPath(Pens.Gray, this.shape);
            using (SolidBrush brush = new SolidBrush(this.br))
            {
                e.Graphics.FillPath((Brush)brush, this.innerRect);
            }
            SetTextHolder();
            base.OnPaint(e);
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Text = label.Text;
        }

        public Color Br
        {
            get => this.br;
            set
            {
                this.br = value;
                if (this.br != Color.Transparent)
                {
                    label.BackColor = this.br;
                }
                base.Invalidate();
            }
        }

        public override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = Color.Transparent;
        }
    }
}
