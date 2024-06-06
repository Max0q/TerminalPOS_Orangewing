using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TerminalPOS_Orangewing
{
    public class RoundGroupBox : GroupBox
    {
        public RoundGroupBox()
        {
            DoubleBuffered = true;
            BackColor = Color.FromArgb(238, 238, 238);
            Radious = 9;
        }

        public int Radious { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GroupBoxRenderer.DrawParentBackground(e.Graphics, this.ClientRectangle, this);
            var rect = ClientRectangle;

            using (var path = GetRoundRectagle(this.ClientRectangle, Radious))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                if (this.BackColor != Color.Transparent)
                    using (var brush = new SolidBrush(BackColor))
                        e.Graphics.FillPath(brush, path);
            }
        }

        private GraphicsPath GetRoundRectagle(Rectangle b, int r)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(b.X, b.Y, r, r, 180, 90);
            path.AddArc(b.X + b.Width - r - 1, b.Y, r, r, 270, 90);
            path.AddArc(b.X + b.Width - r - 1, b.Y + b.Height - r - 1, r, r, 0, 90);
            path.AddArc(b.X, b.Y + b.Height - r - 1, r, r, 90, 90);
            path.CloseAllFigures();
            return path;
        }
    }
}
