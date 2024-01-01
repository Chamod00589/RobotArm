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
            sp.PortName = "COM12";
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
            if (isManualMode)
            {
                isManualMode = false;
                ManualModeLED.BackColor = Color.FromArgb(220, 255, 220);
            }
            else
            {
                isManualMode = true;
                ManualModeLED.BackColor = Color.Green;
            }
        }

        private void WaterPumpCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (isActiveWaterPump)
            {
                isActiveWaterPump = false;
                WaterPumpLED.BackColor = Color.FromArgb(220, 255, 220);
            }
            else
            {
                isActiveWaterPump = true;
                WaterPumpLED.BackColor = Color.Green;
            }
        }



        private void WashingMotorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (isActiveWashingMotor)
            {
                isActiveWashingMotor = false;
                WashingMotorLED.BackColor = Color.FromArgb(220, 255, 220);
            }
            else
            {
                isActiveWashingMotor = true;
                WashingMotorLED.BackColor = Color.Green;
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
                        // Console.WriteLine(receivedMsg);
                        Console.WriteLine("Key: " + key);
                        Console.WriteLine("Value: " + value);


                        //if (key != "W")
                        //{
                            
                        //    //isActiveWaterPump = false;
                        //    //WaterPumpLED.BackColor = Color.FromArgb(220, 255, 220);
                        //}


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

                        else if (key == "WashingMotorStart")
                        {
                            WaterPumpCheckBox.Checked = true;
                            WashingStartLED.BackColor = Color.Green;
                        }

                        else if (key == "W")
                        {
                            if (int.TryParse(value, out int number))
                            {
                                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = number;
                                axWindowsMediaPlayer1.Ctlcontrols.play();
                                axWindowsMediaPlayer1.Ctlcontrols.pause();

                                WaterPumpCheckBox.Checked = true;
                                //isActiveWaterPump = true;
                                //WaterPumpLED.BackColor = Color.Green;
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

                            WashingCompleteLED.BackColor = Color.Green;
                            WashingStartLED.BackColor = Color.FromArgb(220, 255, 220);

                        }




                        //if (key != "W")
                        //{
                        //    WaterPumpCheckBox.Checked = false;
                        //    isActiveWaterPump = false;
                        //    WaterPumpLED.BackColor = Color.FromArgb(220, 255, 220);
                        //}

                        //if (key == "W")
                        //{
                        //    if (int.TryParse(value, out int number))
                        //    {
                        //        axWindowsMediaPlayer1.Ctlcontrols.currentPosition = number;
                        //        axWindowsMediaPlayer1.Ctlcontrols.play();
                        //        axWindowsMediaPlayer1.Ctlcontrols.pause();

                        //        WaterPumpCheckBox.Checked = true;
                        //        isActiveWaterPump = true;
                        //        WaterPumpLED.BackColor = Color.Green;
                        //    }
                        //    else
                        //    {
                        //        Console.WriteLine("Invalid Number Format");
                        //    }
                        //}
                        //else if (key == "B")
                        //{


                        //}
                        //else if(key == "Button")
                        //{
                        //    isWashingStart = true;
                        //    WashingStartLED.BackColor = Color.Green;
                        //}
                    }
                }

                tboxReceive.Text += indata;
                tboxReceive.ScrollToCaret();


                ////Console.WriteLine(indata);
                //char firstchar;
                ////Single numdata;
                ////Single volts;
                //firstchar = indata[0];

                //Console.WriteLine(indata.Substring(1));

                //switch (firstchar)
                //{
                //    case 'A':
                //        numdata = Convert.ToSingle(indata.Substring(1));
                //        volts = numdata * 5 / 1024;
                //        //progressBar1.Value = Convert.ToInt16(indata.Substring(1));
                //        break;

                //    case 'V':
                //        if (indata.Substring(1) == "on")
                //        {
                //            //panel6.BackColor = panel7.BackColor = panel8.BackColor = Color.Yellow;
                //        }
                //        else
                //        {
                //            //panel6.BackColor = panel7.BackColor = panel8.BackColor = Color.Black;
                //        }
                //        break;
                //}
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
