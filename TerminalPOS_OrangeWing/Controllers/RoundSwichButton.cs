using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerminalPOS_Orangewing
{
    public class RoundSwichButton : Control
    {
        public int ButtonRoundRadius { get; set; }
        public Color ButtonBorderColor { get; set; }
        public Color ButtonPressedColor { get; set; }
        public Color ButtonPressedForeColor { get; set; }

        public bool SwichOn;

        public RoundSwichButton()
        {
            ButtonRoundRadius = 30;
            BackColor = Color.Gainsboro;
            ButtonBorderColor = Color.Black;

            ButtonPressedColor = Color.Red;
            ButtonPressedForeColor = Color.White;
            SwichOn = false;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x00000020;
                return createParams;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            var foreColor = SwichOn ? ButtonPressedForeColor : ForeColor;
            var backColor = SwichOn ? ButtonPressedColor : BackColor;

            using (var pen = new Pen(ButtonBorderColor, 1))
                e.Graphics.DrawPath(pen, Path);

            using (var brush = new SolidBrush(backColor))
                e.Graphics.FillPath(brush, Path);

            using (var brush = new SolidBrush(foreColor))
            {
                var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                var rect = ClientRectangle;
                rect.Inflate(-4, -4);
                e.Graphics.DrawString(Text, Font, brush, rect, sf);
            }

            base.OnPaint(e);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Parent.Invalidate(Bounds, false);
            Invalidate();
            SwichOn = !SwichOn;
        }

        public void UpdateOnPaint()
        {
            Parent.Invalidate(Bounds, false);
            Invalidate();
        }

        protected GraphicsPath Path
        {
            get
            {
                var rect = ClientRectangle;
                rect.Inflate(-1, -1);
                return GetRoundedRectangle(rect, ButtonRoundRadius);
            }
        }

        public static GraphicsPath GetRoundedRectangle(Rectangle rect, int d)
        {
            var gp = new GraphicsPath();

            gp.AddArc(rect.X, rect.Y, d, d, 180, 90);
            gp.AddArc(rect.X + rect.Width - d, rect.Y, d, d, 270, 90);
            gp.AddArc(rect.X + rect.Width - d, rect.Y + rect.Height - d, d, d, 0, 90);
            gp.AddArc(rect.X, rect.Y + rect.Height - d, d, d, 90, 90);
            gp.CloseFigure();

            return gp;
        }
    }
}

