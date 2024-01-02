using System;
using System.Drawing;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Washing_machine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sp.BaudRate = 9600;
            sp.PortName = "COM16";
            sp.Open();
        }


























        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Video.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }































        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();

        }



        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = 5; // Seek to 30 seconds
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.Ctlcontrols.pause();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }


        Boolean isManualMode = false;
        Boolean isActiveWaterPump = false;
        Boolean isActiveWashingMotor = false;


        private void ManualModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!ManualModeCheckBox.Checked)
            {
                isManualMode = false;
                ManualModeLED.BackColor = Color.FromArgb(220, 255, 220);
                sp.WriteLine("AutoMode:0");
                ManulModePanel.Visible = false;
            }
            else
            {
                isManualMode = true;
                ManualModeLED.BackColor = Color.Green;
                sp.WriteLine("ManualMode:0");
                ManulModePanel.Visible = true;
            }
        }

        private void WaterPumpCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!WaterPumpCheckBox.Checked)
            {
                isActiveWaterPump = false;
                WaterPumpLED.BackColor = Color.FromArgb(220, 255, 220);
                sp.WriteLine("WaterPump:0");
            }
            else
            {
                isActiveWaterPump = true;
                WaterPumpLED.BackColor = Color.Green;
                sp.WriteLine("WaterPump:1");
            }
        }



        private void WashingMotorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!WashingMotorCheckBox.Checked)
            {
                isActiveWashingMotor = false;
                WashingMotorLED.BackColor = Color.FromArgb(220, 255, 220);
                sp.WriteLine("WashingMotor:0");
            }
            else
            {
                isActiveWashingMotor = true;
                WashingMotorLED.BackColor = Color.Green;
                sp.WriteLine("WashingMotor:1");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        public delegate void d1(string indata);
        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string indata = sp.ReadLine();
            d1 writeit = new d1(Write2Form);
            Invoke(writeit, indata);
        }

        private async void changeColor()
        {
            // Change color to Green
            WashingMotorLED.BackColor = Color.Green;

            // Wait for 1 second
            await Task.Delay(500);

            // Change color to custom color (220, 255, 220)
            WashingMotorLED.BackColor = Color.FromArgb(220, 255, 220);
        }

        Boolean isWashingStart = false;
        public void Write2Form(string indata)
        {
            try
            {

                string receivedMsg = indata;

                if (receivedMsg.Length > 0)
                {
                    int colonIndex = receivedMsg.IndexOf(':');
                    if (colonIndex != -1)
                    {
                        // Colon exists in the string
                        string key = receivedMsg.Substring(0, colonIndex);
                        string value = receivedMsg.Substring(colonIndex + 1);

                        // Uncomment the lines below if you want to print the values to the console
                        Console.WriteLine("Key: " + key);
                        Console.WriteLine("Value: " + value);


                        if (key == "T")
                        {
                            if (int.TryParse(value, out int number))
                            {
                                TimerMeter.Value = number;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Number Format");
                            }
                        }

                     

                        else if (key == "W")
                        {
                            if (int.TryParse(value, out int number))
                            {
                                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = number;
                                WaterLevelProgress.Value = number;
                                axWindowsMediaPlayer1.Ctlcontrols.play();
                                axWindowsMediaPlayer1.Ctlcontrols.pause();

                                WaterPumpCheckBox.Checked = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Number Format");
                            }





                        }
                        else if (key == "Washing")
                        {
                            WashingMotorCheckBox.Checked = true;
                            WaterPumpCheckBox.Checked = false;

                            if (int.TryParse(value, out int number))
                            {
                                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = number;
                                axWindowsMediaPlayer1.Ctlcontrols.play();

                            }
                            else
                            {
                                Console.WriteLine("Invalid Number Format");
                            }
                        }


                        else if (key == "WashingMotorStart")
                        {
                            WaterPumpCheckBox.Checked = true;
                            WashingStartLED.BackColor = Color.Green;
                        }
                        else if (key == "WashingComplete")
                        {
                            WashingMotorCheckBox.Checked = false;
                            WashingStartLED.BackColor = Color.FromArgb(220, 255, 220);
                            WashingCompleteLED.BackColor = Color.Green;
                            WaterLevelProgress.Value = 1;
                        }
                        else if (key == "Reset")
                        {
                            WaterLevelProgress.Value = 1;
                            WaterPumpCheckBox.Checked = false;
                            WashingMotorCheckBox.Checked = false;
                            WashingCompleteLED.BackColor = Color.FromArgb(220, 255, 220);
                            WashingStartLED.BackColor = Color.FromArgb(220, 255, 220);
                        }

                    }
                }

                tboxReceive.Text = indata;
             
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void TimerVTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (ManualModeCheckBox.Checked)
            {
                sp.Write("Timer:");
                sp.WriteLine((TimerVTrackBar.Value).ToString());
            }
        }

        private void WaterLevelVTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (ManualModeCheckBox.Checked)
            {
                sp.Write("WaterLevevl:");
                sp.WriteLine((WaterLevelVTrackBar.Value).ToString());
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            sp.Write("Start:");
            sp.WriteLine("1");
        }
    }
}
