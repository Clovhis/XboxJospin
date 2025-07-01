using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace XboxJoystickTester
{
    public partial class MainForm : Form
    {
        private Timer _timer;
        private XInput.XINPUT_STATE _state;
        private float _leftX;
        private float _leftY;
        private float _rightX;
        private float _rightY;

        public MainForm()
        {
            InitializeComponent();

            MakeRound(lblA);
            MakeRound(lblB);
            MakeRound(lblX);
            MakeRound(lblY);

            _timer = new Timer();
            _timer.Interval = 50; // 20 updates per second
            _timer.Tick += (s, e) => UpdateState();
            _timer.Start();
        }

        private void UpdateState()
        {
            if (XInput.XInputGetState(0, ref _state) == 0)
            {
                lblConnected.Text = "Xbox controller connected";
                lblConnected.BackColor = Color.Green;
                lblConnected.ForeColor = Color.White;
                var buttons = (XInput.ButtonFlags)_state.Gamepad.wButtons;
                lblA.Text = "A";
                lblB.Text = "B";
                lblX.Text = "X";
                lblY.Text = "Y";
                lblLX.Text = $"LX: {_state.Gamepad.sThumbLX}";
                lblLY.Text = $"LY: {_state.Gamepad.sThumbLY}";
                lblRX.Text = $"RX: {_state.Gamepad.sThumbRX}";
                lblRY.Text = $"RY: {_state.Gamepad.sThumbRY}";
                _leftX = _state.Gamepad.sThumbLX;
                _leftY = _state.Gamepad.sThumbLY;
                _rightX = _state.Gamepad.sThumbRX;
                _rightY = _state.Gamepad.sThumbRY;
                panelLeftStick.Invalidate();
                panelRightStick.Invalidate();
                progressLT.Value = _state.Gamepad.bLeftTrigger;
                progressRT.Value = _state.Gamepad.bRightTrigger;
                var on = Color.Lime;
                var off = Color.Gray;
                lblA.BackColor = (buttons & XInput.ButtonFlags.A) != 0 ? on : off;
                lblB.BackColor = (buttons & XInput.ButtonFlags.B) != 0 ? on : off;
                lblX.BackColor = (buttons & XInput.ButtonFlags.X) != 0 ? on : off;
                lblY.BackColor = (buttons & XInput.ButtonFlags.Y) != 0 ? on : off;
                lblDPadUp.BackColor = (buttons & XInput.ButtonFlags.DPadUp) != 0 ? on : off;
                lblDPadDown.BackColor = (buttons & XInput.ButtonFlags.DPadDown) != 0 ? on : off;
                lblDPadLeft.BackColor = (buttons & XInput.ButtonFlags.DPadLeft) != 0 ? on : off;
                lblDPadRight.BackColor = (buttons & XInput.ButtonFlags.DPadRight) != 0 ? on : off;
                lblLB.BackColor = (buttons & XInput.ButtonFlags.LeftShoulder) != 0 ? on : off;
                lblRB.BackColor = (buttons & XInput.ButtonFlags.RightShoulder) != 0 ? on : off;
                lblStart.BackColor = (buttons & XInput.ButtonFlags.Start) != 0 ? on : off;
                lblBack.BackColor = (buttons & XInput.ButtonFlags.Back) != 0 ? on : off;
            }
            else
            {
                lblConnected.Text = "No controller found";
                lblConnected.BackColor = Color.Red;
                lblConnected.ForeColor = Color.White;
                lblDPadUp.BackColor = lblDPadDown.BackColor = lblDPadLeft.BackColor = lblDPadRight.BackColor =
                    lblLB.BackColor = lblRB.BackColor = lblStart.BackColor = lblBack.BackColor =
                    lblA.BackColor = lblB.BackColor = lblX.BackColor = lblY.BackColor = Color.Gray;
                _leftX = _leftY = _rightX = _rightY = 0;
                panelLeftStick.Invalidate();
                panelRightStick.Invalidate();
            }
        }

        private void btnVibrate_Click(object sender, EventArgs e)
        {
            ushort leftMotor = (ushort)(trackLeft.Value * 655);
            ushort rightMotor = (ushort)(trackRight.Value * 655);
            var vibration = new XInput.XINPUT_VIBRATION { wLeftMotorSpeed = leftMotor, wRightMotorSpeed = rightMotor };
            XInput.XInputSetState(0, ref vibration);
        }

        private void panelLeftStick_Paint(object sender, PaintEventArgs e)
        {
            DrawStick(e.Graphics, panelLeftStick, _leftX, _leftY);
        }

        private void panelRightStick_Paint(object sender, PaintEventArgs e)
        {
            DrawStick(e.Graphics, panelRightStick, _rightX, _rightY);
        }

        private void DrawStick(Graphics g, Panel panel, float x, float y)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            int radius = Math.Min(panel.Width, panel.Height) / 2 - 5;
            int centerX = panel.Width / 2;
            int centerY = panel.Height / 2;
            g.DrawEllipse(Pens.Black, centerX - radius, centerY - radius, radius * 2, radius * 2);
            int ballRadius = 6;
            float nx = Math.Max(-1f, Math.Min(1f, x / 32767f));
            float ny = Math.Max(-1f, Math.Min(1f, y / 32767f));
            int bx = centerX + (int)(nx * (radius - ballRadius));
            int by = centerY - (int)(ny * (radius - ballRadius));
            g.FillEllipse(Brushes.Red, bx - ballRadius, by - ballRadius, ballRadius * 2, ballRadius * 2);
        }

        private void MakeRound(Control ctrl)
        {
            var path = new GraphicsPath();
            path.AddEllipse(0, 0, ctrl.Width, ctrl.Height);
            ctrl.Region = new Region(path);
        }
    }

    public static class XInput
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct XINPUT_STATE
        {
            public uint dwPacketNumber;
            public XINPUT_GAMEPAD Gamepad;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct XINPUT_GAMEPAD
        {
            public ushort wButtons;
            public byte bLeftTrigger;
            public byte bRightTrigger;
            public short sThumbLX;
            public short sThumbLY;
            public short sThumbRX;
            public short sThumbRY;
        }

        [Flags]
        public enum ButtonFlags : ushort
        {
            DPadUp = 0x0001,
            DPadDown = 0x0002,
            DPadLeft = 0x0004,
            DPadRight = 0x0008,
            Start = 0x0010,
            Back = 0x0020,
            LeftThumb = 0x0040,
            RightThumb = 0x0080,
            LeftShoulder = 0x0100,
            RightShoulder = 0x0200,
            A = 0x1000,
            B = 0x2000,
            X = 0x4000,
            Y = 0x8000
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct XINPUT_VIBRATION
        {
            public ushort wLeftMotorSpeed;
            public ushort wRightMotorSpeed;
        }

        [DllImport("xinput1_4.dll", EntryPoint = "XInputGetState")]
        public static extern int XInputGetState(int dwUserIndex, ref XINPUT_STATE pState);

        [DllImport("xinput1_4.dll", EntryPoint = "XInputSetState")]
        public static extern int XInputSetState(int dwUserIndex, ref XINPUT_VIBRATION pVibration);
    }
}
