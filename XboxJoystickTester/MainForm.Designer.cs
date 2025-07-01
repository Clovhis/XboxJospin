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
        private JoystickView joystickView;

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
            // joystickView
            //
            this.joystickView = new JoystickView();
            this.joystickView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.joystickView.Location = new System.Drawing.Point(0, 0);
            this.joystickView.Name = "joystickView";
            this.joystickView.Size = new System.Drawing.Size(800, 600);
            this.joystickView.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
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
            this.Controls.Add(this.joystickView);
            this.Controls.Add(this.lblConnected);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Jospin by Clovhis";
            ((System.ComponentModel.ISupportInitialize)(this.trackLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
