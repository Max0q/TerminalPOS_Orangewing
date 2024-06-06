using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TerminalPOS_Orangewing
{
    public class RoundTextBox : TextBox
    {
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nHeightRect, int nWeightRect);

        private int _radius;

        public RoundTextBox()
        {
            DoubleBuffered = true;
            Radius = 9;
            UpdateRegion();
        }
        public bool ValidInput;

        public int Radius
        {
            get => _radius;
            set
            {
                _radius = value;
                UpdateRegion();
            }
        }

        private void UpdateRegion()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, Width, Height, Radius, Radius));
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateRegion();
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            UpdateRegion();
        }
    }
}
