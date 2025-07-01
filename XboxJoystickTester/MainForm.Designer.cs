namespace XboxJoystickTester
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblConnected;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblLX;
        private System.Windows.Forms.Label lblLY;
        private System.Windows.Forms.Label lblRX;
        private System.Windows.Forms.Label lblRY;
        private System.Windows.Forms.ProgressBar progressLT;
        private System.Windows.Forms.ProgressBar progressRT;
        private System.Windows.Forms.TrackBar trackLeft;
        private System.Windows.Forms.TrackBar trackRight;
        private System.Windows.Forms.Button btnVibrate;
        private System.Windows.Forms.Label lblDPadUp;
        private System.Windows.Forms.Label lblDPadDown;
        private System.Windows.Forms.Label lblDPadLeft;
        private System.Windows.Forms.Label lblDPadRight;
        private System.Windows.Forms.Label lblLB;
        private System.Windows.Forms.Label lblRB;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Panel panelLeftStick;
        private System.Windows.Forms.Panel panelRightStick;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblConnected = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblLX = new System.Windows.Forms.Label();
            this.lblLY = new System.Windows.Forms.Label();
            this.lblRX = new System.Windows.Forms.Label();
            this.lblRY = new System.Windows.Forms.Label();
            this.progressLT = new System.Windows.Forms.ProgressBar();
            this.progressRT = new System.Windows.Forms.ProgressBar();
            this.trackLeft = new System.Windows.Forms.TrackBar();
            this.trackRight = new System.Windows.Forms.TrackBar();
            this.btnVibrate = new System.Windows.Forms.Button();
            this.lblDPadUp = new System.Windows.Forms.Label();
            this.lblDPadDown = new System.Windows.Forms.Label();
            this.lblDPadLeft = new System.Windows.Forms.Label();
            this.lblDPadRight = new System.Windows.Forms.Label();
            this.lblLB = new System.Windows.Forms.Label();
            this.lblRB = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.panelLeftStick = new System.Windows.Forms.Panel();
            this.panelRightStick = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trackLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConnected
            // 
            this.lblConnected.AutoSize = true;
            this.lblConnected.Location = new System.Drawing.Point(12, 9);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(69, 15);
            this.lblConnected.TabIndex = 0;
            this.lblConnected.Text = "No controller";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(12, 33);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(24, 15);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "A:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(12, 48);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(23, 15);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "B:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(12, 63);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(24, 15);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "X:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(12, 78);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(23, 15);
            this.lblY.TabIndex = 4;
            this.lblY.Text = "Y:";
            // 
            // lblLX
            // 
            this.lblLX.AutoSize = true;
            this.lblLX.Location = new System.Drawing.Point(150, 33);
            this.lblLX.Name = "lblLX";
            this.lblLX.Size = new System.Drawing.Size(27, 15);
            this.lblLX.TabIndex = 5;
            this.lblLX.Text = "LX:";
            // 
            // lblLY
            // 
            this.lblLY.AutoSize = true;
            this.lblLY.Location = new System.Drawing.Point(150, 48);
            this.lblLY.Name = "lblLY";
            this.lblLY.Size = new System.Drawing.Size(27, 15);
            this.lblLY.TabIndex = 6;
            this.lblLY.Text = "LY:";
            // 
            // lblRX
            // 
            this.lblRX.AutoSize = true;
            this.lblRX.Location = new System.Drawing.Point(150, 63);
            this.lblRX.Name = "lblRX";
            this.lblRX.Size = new System.Drawing.Size(27, 15);
            this.lblRX.TabIndex = 7;
            this.lblRX.Text = "RX:";
            // 
            // lblRY
            // 
            this.lblRY.AutoSize = true;
            this.lblRY.Location = new System.Drawing.Point(150, 78);
            this.lblRY.Name = "lblRY";
            this.lblRY.Size = new System.Drawing.Size(27, 15);
            this.lblRY.TabIndex = 8;
            this.lblRY.Text = "RY:";
            // 
            // progressLT
            // 
            this.progressLT.Location = new System.Drawing.Point(12, 108);
            this.progressLT.Maximum = 255;
            this.progressLT.Name = "progressLT";
            this.progressLT.Size = new System.Drawing.Size(165, 23);
            this.progressLT.TabIndex = 9;
            // 
            // progressRT
            // 
            this.progressRT.Location = new System.Drawing.Point(12, 137);
            this.progressRT.Maximum = 255;
            this.progressRT.Name = "progressRT";
            this.progressRT.Size = new System.Drawing.Size(165, 23);
            this.progressRT.TabIndex = 10;
            // 
            // trackLeft
            // 
            this.trackLeft.Location = new System.Drawing.Point(12, 176);
            this.trackLeft.Maximum = 100;
            this.trackLeft.Name = "trackLeft";
            this.trackLeft.Size = new System.Drawing.Size(165, 45);
            this.trackLeft.TabIndex = 11;
            // 
            // trackRight
            // 
            this.trackRight.Location = new System.Drawing.Point(183, 176);
            this.trackRight.Maximum = 100;
            this.trackRight.Name = "trackRight";
            this.trackRight.Size = new System.Drawing.Size(165, 45);
            this.trackRight.TabIndex = 12;
            // 
            // btnVibrate
            // 
            this.btnVibrate.Location = new System.Drawing.Point(12, 227);
            this.btnVibrate.Name = "btnVibrate";
            this.btnVibrate.Size = new System.Drawing.Size(75, 23);
            this.btnVibrate.TabIndex = 13;
            this.btnVibrate.Text = "Vibrate";
            this.btnVibrate.UseVisualStyleBackColor = true;
            this.btnVibrate.Click += new System.EventHandler(this.btnVibrate_Click);
            //
            // lblDPadUp
            //
            this.lblDPadUp.AutoSize = false;
            this.lblDPadUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDPadUp.Location = new System.Drawing.Point(12, 255);
            this.lblDPadUp.Name = "lblDPadUp";
            this.lblDPadUp.Size = new System.Drawing.Size(80, 35);
            this.lblDPadUp.TabIndex = 14;
            this.lblDPadUp.Text = "D-Pad Up";
            this.lblDPadUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDPadUp.BackColor = System.Drawing.Color.Gray;
            //
            // lblDPadDown
            //
            this.lblDPadDown.AutoSize = false;
            this.lblDPadDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDPadDown.Location = new System.Drawing.Point(102, 255);
            this.lblDPadDown.Name = "lblDPadDown";
            this.lblDPadDown.Size = new System.Drawing.Size(80, 35);
            this.lblDPadDown.TabIndex = 15;
            this.lblDPadDown.Text = "D-Pad Down";
            this.lblDPadDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDPadDown.BackColor = System.Drawing.Color.Gray;
            //
            // lblDPadLeft
            //
            this.lblDPadLeft.AutoSize = false;
            this.lblDPadLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDPadLeft.Location = new System.Drawing.Point(192, 255);
            this.lblDPadLeft.Name = "lblDPadLeft";
            this.lblDPadLeft.Size = new System.Drawing.Size(80, 35);
            this.lblDPadLeft.TabIndex = 16;
            this.lblDPadLeft.Text = "D-Pad Left";
            this.lblDPadLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDPadLeft.BackColor = System.Drawing.Color.Gray;
            //
            // lblDPadRight
            //
            this.lblDPadRight.AutoSize = false;
            this.lblDPadRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDPadRight.Location = new System.Drawing.Point(282, 255);
            this.lblDPadRight.Name = "lblDPadRight";
            this.lblDPadRight.Size = new System.Drawing.Size(80, 35);
            this.lblDPadRight.TabIndex = 17;
            this.lblDPadRight.Text = "D-Pad Right";
            this.lblDPadRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDPadRight.BackColor = System.Drawing.Color.Gray;
            //
            // lblLB
            //
            this.lblLB.AutoSize = false;
            this.lblLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLB.Location = new System.Drawing.Point(12, 285);
            this.lblLB.Name = "lblLB";
            this.lblLB.Size = new System.Drawing.Size(120, 35);
            this.lblLB.TabIndex = 18;
            this.lblLB.Text = "Left Bumper";
            this.lblLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLB.BackColor = System.Drawing.Color.Gray;
            //
            // lblRB
            //
            this.lblRB.AutoSize = false;
            this.lblRB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRB.Location = new System.Drawing.Point(144, 285);
            this.lblRB.Name = "lblRB";
            this.lblRB.Size = new System.Drawing.Size(120, 35);
            this.lblRB.TabIndex = 19;
            this.lblRB.Text = "Right Bumper";
            this.lblRB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRB.BackColor = System.Drawing.Color.Gray;
            //
            // lblStart
            //
            this.lblStart.AutoSize = false;
            this.lblStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStart.Location = new System.Drawing.Point(276, 285);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(100, 35);
            this.lblStart.TabIndex = 20;
            this.lblStart.Text = "Menu";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStart.BackColor = System.Drawing.Color.Gray;
            //
            // lblBack
            //
            this.lblBack.AutoSize = false;
            this.lblBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBack.Location = new System.Drawing.Point(276, 325);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(100, 35);
            this.lblBack.TabIndex = 21;
            this.lblBack.Text = "View";
            this.lblBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBack.BackColor = System.Drawing.Color.Gray;
            //
            // panelLeftStick
            //
            this.panelLeftStick.Location = new System.Drawing.Point(380, 30);
            this.panelLeftStick.Name = "panelLeftStick";
            this.panelLeftStick.Size = new System.Drawing.Size(180, 180);
            this.panelLeftStick.TabIndex = 22;
            this.panelLeftStick.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeftStick_Paint);
            //
            // panelRightStick
            //
            this.panelRightStick.Location = new System.Drawing.Point(380, 230);
            this.panelRightStick.Name = "panelRightStick";
            this.panelRightStick.Size = new System.Drawing.Size(180, 180);
            this.panelRightStick.TabIndex = 23;
            this.panelRightStick.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRightStick_Paint);
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblRB);
            this.Controls.Add(this.lblLB);
            this.Controls.Add(this.lblDPadRight);
            this.Controls.Add(this.lblDPadLeft);
            this.Controls.Add(this.lblDPadDown);
            this.Controls.Add(this.lblDPadUp);
            this.Controls.Add(this.btnVibrate);
            this.Controls.Add(this.trackRight);
            this.Controls.Add(this.trackLeft);
            this.Controls.Add(this.progressRT);
            this.Controls.Add(this.progressLT);
            this.Controls.Add(this.lblRY);
            this.Controls.Add(this.lblRX);
            this.Controls.Add(this.lblLY);
            this.Controls.Add(this.lblLX);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblConnected);
            this.Controls.Add(this.panelLeftStick);
            this.Controls.Add(this.panelRightStick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Xbox Joystick Tester";
            ((System.ComponentModel.ISupportInitialize)(this.trackLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
