
namespace Washing_machine
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TimerMeter = new Guna.UI.WinForms.GunaGauge();
            this.label2 = new System.Windows.Forms.Label();
            this.WaterPumpLED = new System.Windows.Forms.Panel();
            this.WashingMotorLED = new System.Windows.Forms.Panel();
            this.WashingCompleteLED = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.WaterPumpCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.WashingMotorCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ManualModeLED = new System.Windows.Forms.Panel();
            this.ManualModeCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WashingStartLED = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxReceive = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.sp = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(102, 107);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(653, 510);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 372);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 430);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 476);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Washing machine";
            // 
            // TimerMeter
            // 
            this.TimerMeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TimerMeter.IdleColor = System.Drawing.Color.Gainsboro;
            this.TimerMeter.Location = new System.Drawing.Point(959, 413);
            this.TimerMeter.Margin = new System.Windows.Forms.Padding(0);
            this.TimerMeter.MaximumColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TimerMeter.MinimumColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TimerMeter.Name = "TimerMeter";
            this.TimerMeter.ShowText = false;
            this.TimerMeter.Size = new System.Drawing.Size(161, 120);
            this.TimerMeter.TabIndex = 5;
            this.TimerMeter.Thickness = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1009, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Timer";
            // 
            // WaterPumpLED
            // 
            this.WaterPumpLED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.WaterPumpLED.Location = new System.Drawing.Point(990, 248);
            this.WaterPumpLED.Name = "WaterPumpLED";
            this.WaterPumpLED.Size = new System.Drawing.Size(34, 34);
            this.WaterPumpLED.TabIndex = 8;
            // 
            // WashingMotorLED
            // 
            this.WashingMotorLED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.WashingMotorLED.Location = new System.Drawing.Point(990, 293);
            this.WashingMotorLED.Name = "WashingMotorLED";
            this.WashingMotorLED.Size = new System.Drawing.Size(34, 34);
            this.WashingMotorLED.TabIndex = 8;
            // 
            // WashingCompleteLED
            // 
            this.WashingCompleteLED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.WashingCompleteLED.Location = new System.Drawing.Point(1032, 573);
            this.WashingCompleteLED.Name = "WashingCompleteLED";
            this.WashingCompleteLED.Size = new System.Drawing.Size(34, 34);
            this.WashingCompleteLED.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(949, 578);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Complete";
            // 
            // WaterPumpCheckBox
            // 
            this.WaterPumpCheckBox.BaseColor = System.Drawing.Color.White;
            this.WaterPumpCheckBox.CheckedOffColor = System.Drawing.Color.Gray;
            this.WaterPumpCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.WaterPumpCheckBox.FillColor = System.Drawing.Color.White;
            this.WaterPumpCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaterPumpCheckBox.Location = new System.Drawing.Point(842, 254);
            this.WaterPumpCheckBox.Name = "WaterPumpCheckBox";
            this.WaterPumpCheckBox.Size = new System.Drawing.Size(123, 22);
            this.WaterPumpCheckBox.TabIndex = 13;
            this.WaterPumpCheckBox.Text = "Water Pump";
            this.WaterPumpCheckBox.CheckedChanged += new System.EventHandler(this.WaterPumpCheckBox_CheckedChanged);
            // 
            // WashingMotorCheckBox
            // 
            this.WashingMotorCheckBox.BaseColor = System.Drawing.Color.White;
            this.WashingMotorCheckBox.CheckedOffColor = System.Drawing.Color.Gray;
            this.WashingMotorCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.WashingMotorCheckBox.FillColor = System.Drawing.Color.White;
            this.WashingMotorCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WashingMotorCheckBox.Location = new System.Drawing.Point(843, 300);
            this.WashingMotorCheckBox.Name = "WashingMotorCheckBox";
            this.WashingMotorCheckBox.Size = new System.Drawing.Size(142, 22);
            this.WashingMotorCheckBox.TabIndex = 14;
            this.WashingMotorCheckBox.Text = "Washing Motor";
            this.WashingMotorCheckBox.CheckedChanged += new System.EventHandler(this.WashingMotorCheckBox_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(79, 569);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(694, 74);
            this.panel5.TabIndex = 15;
            // 
            // ManualModeLED
            // 
            this.ManualModeLED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.ManualModeLED.Location = new System.Drawing.Point(990, 200);
            this.ManualModeLED.Name = "ManualModeLED";
            this.ManualModeLED.Size = new System.Drawing.Size(34, 34);
            this.ManualModeLED.TabIndex = 10;
            // 
            // ManualModeCheckBox
            // 
            this.ManualModeCheckBox.BaseColor = System.Drawing.Color.White;
            this.ManualModeCheckBox.CheckedOffColor = System.Drawing.Color.Gray;
            this.ManualModeCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ManualModeCheckBox.FillColor = System.Drawing.Color.White;
            this.ManualModeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManualModeCheckBox.Location = new System.Drawing.Point(842, 208);
            this.ManualModeCheckBox.Name = "ManualModeCheckBox";
            this.ManualModeCheckBox.Size = new System.Drawing.Size(131, 22);
            this.ManualModeCheckBox.TabIndex = 12;
            this.ManualModeCheckBox.Text = "Manual Mode";
            this.ManualModeCheckBox.CheckedChanged += new System.EventHandler(this.ManualModeCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(812, 541);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Washing";
            // 
            // WashingStartLED
            // 
            this.WashingStartLED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.WashingStartLED.Location = new System.Drawing.Point(904, 573);
            this.WashingStartLED.Name = "WashingStartLED";
            this.WashingStartLED.Size = new System.Drawing.Size(34, 34);
            this.WashingStartLED.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(854, 578);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Start";
            // 
            // tboxReceive
            // 
            this.tboxReceive.Location = new System.Drawing.Point(825, 53);
            this.tboxReceive.Multiline = true;
            this.tboxReceive.Name = "tboxReceive";
            this.tboxReceive.Size = new System.Drawing.Size(272, 107);
            this.tboxReceive.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(959, 369);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // sp
            // 
            this.sp.PortName = "COM7";
            this.sp.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.sp_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 664);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tboxReceive);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.WashingStartLED);
            this.Controls.Add(this.WashingMotorCheckBox);
            this.Controls.Add(this.WaterPumpCheckBox);
            this.Controls.Add(this.ManualModeCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ManualModeLED);
            this.Controls.Add(this.WashingCompleteLED);
            this.Controls.Add(this.WashingMotorLED);
            this.Controls.Add(this.WaterPumpLED);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimerMeter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaGauge TimerMeter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel WaterPumpLED;
        private System.Windows.Forms.Panel WashingMotorLED;
        private System.Windows.Forms.Panel WashingCompleteLED;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaCheckBox WaterPumpCheckBox;
        private Guna.UI.WinForms.GunaCheckBox WashingMotorCheckBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel ManualModeLED;
        private Guna.UI.WinForms.GunaCheckBox ManualModeCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel WashingStartLED;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxReceive;
        private System.Windows.Forms.Button button4;
        private System.IO.Ports.SerialPort sp;
    }
}

