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
        private System.Windows.Forms.Label lblLeftStickPress;
        private System.Windows.Forms.Label lblRightStickPress;
        private System.Windows.Forms.Label lblCredits;

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
            this.lblLeftStickPress = new System.Windows.Forms.Label();
            this.lblRightStickPress = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConnected
            // 
            this.lblConnected.AutoSize = false;
            this.lblConnected.Location = new System.Drawing.Point(12, 0);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(260, 30);
            this.lblConnected.TabIndex = 0;
            this.lblConnected.Text = "No controller found";
            this.lblConnected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblConnected.BackColor = System.Drawing.Color.Red;
            this.lblConnected.ForeColor = System.Drawing.Color.White;
            // 
            // lblA
            //
            this.lblA.AutoSize = false;
            this.lblA.Location = new System.Drawing.Point(12, 30);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(60, 60);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "A";
            this.lblA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblB
            //
            this.lblB.AutoSize = false;
            this.lblB.Location = new System.Drawing.Point(80, 30);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(60, 60);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "B";
            this.lblB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblX
            //
            this.lblX.AutoSize = false;
            this.lblX.Location = new System.Drawing.Point(148, 30);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(60, 60);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "X";
            this.lblX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblY
            //
            this.lblY.AutoSize = false;
            this.lblY.Location = new System.Drawing.Point(216, 30);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(60, 60);
            this.lblY.TabIndex = 4;
            this.lblY.Text = "Y";
            this.lblY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLX
            //
            this.lblLX.AutoSize = true;
            this.lblLX.Location = new System.Drawing.Point(300, 40);
            this.lblLX.Name = "lblLX";
            this.lblLX.Size = new System.Drawing.Size(36, 25);
            this.lblLX.TabIndex = 5;
            this.lblLX.Text = "LX:";
            // 
            // lblLY
            // 
            this.lblLY.AutoSize = true;
            this.lblLY.Location = new System.Drawing.Point(300, 70);
            this.lblLY.Name = "lblLY";
            this.lblLY.Size = new System.Drawing.Size(36, 25);
            this.lblLY.TabIndex = 6;
            this.lblLY.Text = "LY:";
            // 
            // lblRX
            // 
            this.lblRX.AutoSize = true;
            this.lblRX.Location = new System.Drawing.Point(420, 40);
            this.lblRX.Name = "lblRX";
            this.lblRX.Size = new System.Drawing.Size(36, 25);
            this.lblRX.TabIndex = 7;
            this.lblRX.Text = "RX:";
            // 
            // lblRY
            // 
            this.lblRY.AutoSize = true;
            this.lblRY.Location = new System.Drawing.Point(420, 70);
            this.lblRY.Name = "lblRY";
            this.lblRY.Size = new System.Drawing.Size(36, 25);
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
            this.btnVibrate.Size = new System.Drawing.Size(120, 40);
            this.btnVibrate.TabIndex = 13;
            this.btnVibrate.Text = "Vibrate";
            this.btnVibrate.UseVisualStyleBackColor = true;
            this.btnVibrate.Click += new System.EventHandler(this.btnVibrate_Click);
            //
            // lblDPadUp
            //
            this.lblDPadUp.AutoSize = false;
            this.lblDPadUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDPadUp.Location = new System.Drawing.Point(210, 360);
            this.lblDPadUp.Name = "lblDPadUp";
            this.lblDPadUp.Size = new System.Drawing.Size(60, 60);
            this.lblDPadUp.TabIndex = 14;
            this.lblDPadUp.Text = "D-Pad Up";
            this.lblDPadUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDPadUp.BackColor = System.Drawing.Color.Gray;
            //
            // lblDPadDown
            //
            this.lblDPadDown.AutoSize = false;
            this.lblDPadDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDPadDown.Location = new System.Drawing.Point(210, 480);
            this.lblDPadDown.Name = "lblDPadDown";
            this.lblDPadDown.Size = new System.Drawing.Size(60, 60);
            this.lblDPadDown.TabIndex = 15;
            this.lblDPadDown.Text = "D-Pad Down";
            this.lblDPadDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDPadDown.BackColor = System.Drawing.Color.Gray;
            //
            // lblDPadLeft
            //
            this.lblDPadLeft.AutoSize = false;
            this.lblDPadLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDPadLeft.Location = new System.Drawing.Point(150, 420);
            this.lblDPadLeft.Name = "lblDPadLeft";
            this.lblDPadLeft.Size = new System.Drawing.Size(60, 60);
            this.lblDPadLeft.TabIndex = 16;
            this.lblDPadLeft.Text = "D-Pad Left";
            this.lblDPadLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDPadLeft.BackColor = System.Drawing.Color.Gray;
            //
            // lblDPadRight
            //
            this.lblDPadRight.AutoSize = false;
            this.lblDPadRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDPadRight.Location = new System.Drawing.Point(270, 420);
            this.lblDPadRight.Name = "lblDPadRight";
            this.lblDPadRight.Size = new System.Drawing.Size(60, 60);
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
            this.panelLeftStick.Location = new System.Drawing.Point(600, 40);
            this.panelLeftStick.Name = "panelLeftStick";
            this.panelLeftStick.Size = new System.Drawing.Size(200, 200);
            this.panelLeftStick.TabIndex = 22;
            this.panelLeftStick.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeftStick_Paint);
            //
            // panelRightStick
            //
            this.panelRightStick.Location = new System.Drawing.Point(600, 270);
            this.panelRightStick.Name = "panelRightStick";
            this.panelRightStick.Size = new System.Drawing.Size(200, 200);
            this.panelRightStick.TabIndex = 23;
            this.panelRightStick.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRightStick_Paint);
            //
            // lblLeftStickPress
            //
            this.lblLeftStickPress.AutoSize = false;
            this.lblLeftStickPress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLeftStickPress.Location = new System.Drawing.Point(600, 245);
            this.lblLeftStickPress.Name = "lblLeftStickPress";
            this.lblLeftStickPress.Size = new System.Drawing.Size(200, 30);
            this.lblLeftStickPress.TabIndex = 24;
            this.lblLeftStickPress.Text = "Left Stick";
            this.lblLeftStickPress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLeftStickPress.BackColor = System.Drawing.Color.Gray;
            //
            // lblRightStickPress
            //
            this.lblRightStickPress.AutoSize = false;
            this.lblRightStickPress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRightStickPress.Location = new System.Drawing.Point(600, 475);
            this.lblRightStickPress.Name = "lblRightStickPress";
            this.lblRightStickPress.Size = new System.Drawing.Size(200, 30);
            this.lblRightStickPress.TabIndex = 25;
            this.lblRightStickPress.Text = "Right Stick";
            this.lblRightStickPress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRightStickPress.BackColor = System.Drawing.Color.Gray;
            //
            // lblCredits
            //
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCredits.Location = new System.Drawing.Point(640, 670);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(148, 13);
            this.lblCredits.TabIndex = 26;
            this.lblCredits.Text = "Created by Clovhis";
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Font = new System.Drawing.Font("Segoe UI", 18F);
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
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.lblRightStickPress);
            this.Controls.Add(this.lblLeftStickPress);
            this.Controls.Add(this.lblConnected);
            this.Controls.Add(this.panelLeftStick);
            this.Controls.Add(this.panelRightStick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Jospin Tester by JodlP";
            ((System.ComponentModel.ISupportInitialize)(this.trackLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
