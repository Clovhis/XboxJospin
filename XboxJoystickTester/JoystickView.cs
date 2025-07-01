using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace XboxJoystickTester
{
    /// <summary>
    /// Custom control that draws a top view representation of an Xbox controller
    /// and updates its visuals according to the provided gamepad state.
    /// </summary>
    public class JoystickView : Control
    {
        private XInput.XINPUT_STATE _state;
        private XInput.ButtonFlags _previousButtons;

        public JoystickView()
        {
            DoubleBuffered = true;
        }

        /// <summary>
        /// Updates the control with the latest gamepad state and triggers a repaint.
        /// Plays a quick click sound whenever a button transition from released
        /// to pressed occurs.
        /// </summary>
        public void UpdateState(XInput.XINPUT_STATE state)
        {
            var currentButtons = (XInput.ButtonFlags)state.Gamepad.wButtons;
            if ((currentButtons & ~_previousButtons) != 0)
            {
                SystemSounds.Beep.Play();
            }
            _previousButtons = currentButtons;

            _state = state;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            DrawController(g);
        }

        private void DrawController(Graphics g)
        {
            // Sizes and positions for the layout
            int stickRadius = 60;
            int innerRadius = 10;
            Point leftStick = new Point(200, 380);
            Point rightStick = new Point(600, 380);
            Point dpad = new Point(200, 220);
            Point buttonA = new Point(630, 250);
            Point buttonB = new Point(670, 210);
            Point buttonX = new Point(590, 210);
            Point buttonY = new Point(630, 170);
            Point lb = new Point(250, 80);
            Point rb = new Point(470, 80);
            Point lt = new Point(250, 40);
            Point rt = new Point(470, 40);
            Point viewBtn = new Point(350, 220);
            Point menuBtn = new Point(430, 220);

            var buttons = (XInput.ButtonFlags)_state.Gamepad.wButtons;

            // Draw triggers
            DrawTrigger(g, lt, _state.Gamepad.bLeftTrigger, buttons.HasFlag(XInput.ButtonFlags.LeftShoulder));
            DrawTrigger(g, rt, _state.Gamepad.bRightTrigger, buttons.HasFlag(XInput.ButtonFlags.RightShoulder));

            // Draw sticks
            DrawStick(g, leftStick, stickRadius, innerRadius, _state.Gamepad.sThumbLX, _state.Gamepad.sThumbLY,
                buttons.HasFlag(XInput.ButtonFlags.LeftThumb), "Stick Izquierdo");
            DrawStick(g, rightStick, stickRadius, innerRadius, _state.Gamepad.sThumbRX, _state.Gamepad.sThumbRY,
                buttons.HasFlag(XInput.ButtonFlags.RightThumb), "Stick Derecho");

            // D-pad
            DrawDPad(g, dpad, buttons);

            // ABXY buttons
            DrawFaceButton(g, buttonA, "A", buttons.HasFlag(XInput.ButtonFlags.A));
            DrawFaceButton(g, buttonB, "B", buttons.HasFlag(XInput.ButtonFlags.B));
            DrawFaceButton(g, buttonX, "X", buttons.HasFlag(XInput.ButtonFlags.X));
            DrawFaceButton(g, buttonY, "Y", buttons.HasFlag(XInput.ButtonFlags.Y));

            // Center buttons
            DrawCenterButton(g, viewBtn, "View", buttons.HasFlag(XInput.ButtonFlags.Back));
            DrawCenterButton(g, menuBtn, "Menu", buttons.HasFlag(XInput.ButtonFlags.Start));
        }

        private void DrawStick(Graphics g, Point center, int radius, int innerRadius, short x, short y, bool pressed, string label)
        {
            Color border = pressed ? Color.Lime : Color.DarkGray;
            using var pen = new Pen(border, 2);
            g.DrawEllipse(pen, center.X - radius, center.Y - radius, radius * 2, radius * 2);

            // small ball indicating position
            float fx = x / 32767f;
            float fy = -y / 32767f; // invert Y to match screen coordinates
            int maxOffset = radius - innerRadius - 2;
            Point pos = new Point(
                center.X + (int)(fx * maxOffset),
                center.Y + (int)(fy * maxOffset));
            g.FillEllipse(Brushes.DimGray, pos.X - innerRadius, pos.Y - innerRadius, innerRadius * 2, innerRadius * 2);

            // label
            SizeF size = g.MeasureString(label, Font);
            g.DrawString(label, Font, Brushes.White, center.X - size.Width / 2, center.Y + radius + 5);
        }

        private void DrawFaceButton(Graphics g, Point center, string text, bool pressed)
        {
            int r = 20;
            using var brush = new SolidBrush(pressed ? Color.GreenYellow : Color.Gray);
            g.FillEllipse(brush, center.X - r, center.Y - r, r * 2, r * 2);
            g.DrawEllipse(Pens.Black, center.X - r, center.Y - r, r * 2, r * 2);
            SizeF size = g.MeasureString(text, Font);
            g.DrawString(text, Font, Brushes.Black, center.X - size.Width / 2, center.Y - size.Height / 2);
        }

        private void DrawCenterButton(Graphics g, Point center, string text, bool pressed)
        {
            int r = 15;
            using var brush = new SolidBrush(pressed ? Color.LightBlue : Color.DarkGray);
            g.FillEllipse(brush, center.X - r, center.Y - r, r * 2, r * 2);
            g.DrawEllipse(Pens.Black, center.X - r, center.Y - r, r * 2, r * 2);
            SizeF size = g.MeasureString(text, Font);
            g.DrawString(text, new Font(Font.FontFamily, 7), Brushes.Black, center.X - size.Width / 2, center.Y - size.Height / 2);
        }

        private void DrawTrigger(Graphics g, Point position, int value, bool pressed)
        {
            int width = 80;
            int height = 12;
            Rectangle outline = new Rectangle(position.X, position.Y, width, height);
            g.DrawRectangle(Pens.Black, outline);
            if (value > 0)
            {
                Rectangle fill = new Rectangle(position.X, position.Y, value * width / 255, height);
                using var brush = new SolidBrush(pressed ? Color.Orange : Color.DarkOrange);
                g.FillRectangle(brush, fill);
            }
        }

        private void DrawDPad(Graphics g, Point center, XInput.ButtonFlags buttons)
        {
            int size = 20;
            using Brush brushUp = new SolidBrush(buttons.HasFlag(XInput.ButtonFlags.DPadUp) ? Color.LightGreen : Color.DarkGray);
            using Brush brushDown = new SolidBrush(buttons.HasFlag(XInput.ButtonFlags.DPadDown) ? Color.LightGreen : Color.DarkGray);
            using Brush brushLeft = new SolidBrush(buttons.HasFlag(XInput.ButtonFlags.DPadLeft) ? Color.LightGreen : Color.DarkGray);
            using Brush brushRight = new SolidBrush(buttons.HasFlag(XInput.ButtonFlags.DPadRight) ? Color.LightGreen : Color.DarkGray);

            g.FillRectangle(brushUp, center.X - size / 2, center.Y - size - 2, size, size);
            g.FillRectangle(brushDown, center.X - size / 2, center.Y + 2, size, size);
            g.FillRectangle(brushLeft, center.X - size - 2, center.Y - size / 2, size, size);
            g.FillRectangle(brushRight, center.X + 2, center.Y - size / 2, size, size);
            g.DrawRectangle(Pens.Black, center.X - size / 2, center.Y - size - 2, size, size);
            g.DrawRectangle(Pens.Black, center.X - size / 2, center.Y + 2, size, size);
            g.DrawRectangle(Pens.Black, center.X - size - 2, center.Y - size / 2, size, size);
            g.DrawRectangle(Pens.Black, center.X + 2, center.Y - size / 2, size, size);
        }
    }
}
