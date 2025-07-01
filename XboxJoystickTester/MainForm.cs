using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace XboxJoystickTester
{
    public partial class MainForm : Form
    {
        private Timer _timer;
        private XInput.XINPUT_STATE _state;

        public MainForm()
        {
            InitializeComponent();

            _timer = new Timer();
            _timer.Interval = 50; // 20 updates per second
            _timer.Tick += (s, e) => UpdateState();
            _timer.Start();
        }

        private void UpdateState()
        {
            if (XInput.XInputGetState(0, ref _state) == 0)
            {
                lblConnected.Text = "Connected";
                var buttons = (XInput.ButtonFlags)_state.Gamepad.wButtons;
                lblA.Text = (buttons & XInput.ButtonFlags.A) != 0 ? "A: Pressed" : "A: Released";
                lblB.Text = (buttons & XInput.ButtonFlags.B) != 0 ? "B: Pressed" : "B: Released";
                lblX.Text = (buttons & XInput.ButtonFlags.X) != 0 ? "X: Pressed" : "X: Released";
                lblY.Text = (buttons & XInput.ButtonFlags.Y) != 0 ? "Y: Pressed" : "Y: Released";
                lblLX.Text = $"LX: {_state.Gamepad.sThumbLX}";
                lblLY.Text = $"LY: {_state.Gamepad.sThumbLY}";
                lblRX.Text = $"RX: {_state.Gamepad.sThumbRX}";
                lblRY.Text = $"RY: {_state.Gamepad.sThumbRY}";
                progressLT.Value = _state.Gamepad.bLeftTrigger;
                progressRT.Value = _state.Gamepad.bRightTrigger;
            }
            else
            {
                lblConnected.Text = "No controller";
            }
        }

        private void btnVibrate_Click(object sender, EventArgs e)
        {
            ushort leftMotor = (ushort)(trackLeft.Value * 655);
            ushort rightMotor = (ushort)(trackRight.Value * 655);
            var vibration = new XInput.XINPUT_VIBRATION { wLeftMotorSpeed = leftMotor, wRightMotorSpeed = rightMotor };
            XInput.XInputSetState(0, ref vibration);
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
