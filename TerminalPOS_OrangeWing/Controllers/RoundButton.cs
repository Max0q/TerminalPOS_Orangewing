using System;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace TerminalPOS_Orangewing
{
    public class RoundButton : Control
    {
        public int ButtonRoundRadius { get; set; }
        public Color ButtonBorderColor { get; set; }
        public Color ButtonNoActiveColor { get; set; }
        public Color ButtonPressedColor { get; set; }

        private bool _isPressed;

        public RoundButton()
        {
            ButtonRoundRadius = 30;
            BackColor = Color.Gainsboro;
            ButtonBorderColor = Color.Black;
            ButtonNoActiveColor = Color.Orange;
            ButtonPressedColor = Color.Red;
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
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            var backColor = !Enabled ? ButtonNoActiveColor : (_isPressed ? ButtonPressedColor : BackColor);

            using (var pen = new Pen(ButtonBorderColor, 1))
                e.Graphics.DrawPath(pen, Path);


            using (var brush = new SolidBrush(backColor))
                e.Graphics.FillPath(brush, Path);

            using (var brush = new SolidBrush(ForeColor))
            {
                var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                var rect = ClientRectangle;
                rect.Inflate(-4, -4);
                e.Graphics.DrawString(Text, Font, brush, rect, sf);
            }
        }


        public void UpdateOnPaint()
        {
            Parent.Invalidate(Bounds, false);
            Invalidate();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
        }


        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Parent.Invalidate(Bounds, false);
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _isPressed = false;
            Parent.Invalidate(Bounds, false);
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Parent.Invalidate(Bounds, false);
            Invalidate();
            _isPressed = true;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            Parent.Invalidate(Bounds, false);
            Invalidate();
            _isPressed = false;
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