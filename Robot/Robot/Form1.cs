using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace Robot
{
    public partial class Form1 : Form
    {
        //khai bao bien
        Boolean i = false;
        double theta1, theta2, theta3;
        double conv = Math.PI / 180;
        double degree = 180 / Math.PI;
        double d2 = 115, L2 = 162, L3 = 260, dd = 260;

        private void Form1_Load_1(object sender, EventArgs e)
        {
            if (i == false)
            {
                groupBox1.Enabled = false;
                groupBox4.Enabled = false;
            }

            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                PortBox.Items.Add(port);
            }

            FKtheta1.Text = "0";
            FKtheta2.Text = "0";
            FKtheta3.Text = "0";

        }
        //Forward
        private void trackBarTheta1_Scroll(object sender, EventArgs e)
        {
            labeltheta1.Text = trackBarTheta1.Value.ToString();
        }

        private void trackBarTheta2_Scroll(object sender, EventArgs e)
        {
            labeltheta2.Text = trackBarTheta2.Value.ToString();
        }

        private void FKtheta1_TextChanged(object sender, EventArgs e)
        {
            FKtheta1.BackColor = Color.White;
        }

        private void FKtheta2_TextChanged(object sender, EventArgs e)
        {
            FKtheta2.BackColor = Color.White;
        }

        private void FKtheta3_TextChanged(object sender, EventArgs e)
        {
            FKtheta3.BackColor = Color.White;
        }

        private void trackBarTheta3_Scroll(object sender, EventArgs e)
        {
            labeltheta3.Text = trackBarTheta3.Value.ToString();
        }

        double px, py, pz;
        // Send from slide button
        private void SendManToArduino_Click(object sender, EventArgs e)
        {
            theta1 = Convert.ToDouble(trackBarTheta1.Value);
            theta2 = Convert.ToDouble(trackBarTheta2.Value);
            theta3 = Convert.ToDouble(trackBarTheta3.Value);

            px = (L2 * Math.Cos(theta2 * conv) + L3 * Math.Cos(theta3 * conv + theta2 * conv) + d2) * Math.Cos(theta1 * conv);
            py = (L2 * Math.Cos(theta2 * conv) + L3 * Math.Cos(theta3 * conv + theta2 * conv) + d2) * Math.Sin(theta1 * conv);
            pz = dd + L2 * Math.Sin(theta2 * conv) + L3 * Math.Sin(theta3 * conv + theta2 * conv);

/*            px = Math.Round(px, 3);
            py = Math.Round(py, 3);
            pz = Math.Round(pz, 3);*/

            PosFKpx.Text = px.ToString();
            PosFKpy.Text = py.ToString();
            PosFKpz.Text = pz.ToString();

            string data = "a" + trackBarTheta1.Value.ToString() + "b" + trackBarTheta2.Value.ToString() + "c" + trackBarTheta3.Value.ToString();
            SerCOM.Write(data);
        }
        // Send from text button
        private void FKbutton_Click(object sender, EventArgs e)
        {
            try
            {
                theta1 = Convert.ToDouble(FKtheta1.Text);
                theta2 = Convert.ToDouble(FKtheta2.Text);
                theta3 = Convert.ToDouble(FKtheta3.Text);

                if (theta1 >= -90 && theta1 <= 90 && theta2 >= -45 && theta2 <= 90 && theta3 >= -90 && theta3 <= 90)
                {
                    px = (L2 * Math.Cos(theta2 * conv) + L3 * Math.Cos(theta3 * conv + theta2 * conv) + d2) * Math.Cos(theta1 * conv);
                    py = (L2 * Math.Cos(theta2 * conv) + L3 * Math.Cos(theta3 * conv + theta2 * conv) + d2) * Math.Sin(theta1 * conv);
                    pz = dd + L2 * Math.Sin(theta2 * conv) + L3 * Math.Sin(theta3 * conv + theta2 * conv);

/*                    px = Math.Round(px, 3);
                    py = Math.Round(py, 3);
                    pz = Math.Round(pz, 3);*/

                    PosFKpx.Text = px.ToString();
                    PosFKpy.Text = py.ToString();
                    PosFKpz.Text = pz.ToString();

                    string data = "a" + FKtheta1.Text + "b" + FKtheta2.Text + "c" + FKtheta3.Text;
                    SerCOM.Write(data);
                }
                else
                {
                    if (theta1 < -90 || theta1 > 90)
                    {
                        MessageBox.Show("Enter theta 1 angle in range: [-90 :: 90]", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FKtheta1.BackColor = Color.Red;
                    }

                    if (theta2 < -45 || theta2 > 90)
                    {
                        MessageBox.Show("Enter theta 2 angle in range: [-45 :: 90]", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FKtheta2.BackColor = Color.Red;
                    }
                    if (theta3 < -90 || theta3 > 90)
                    {
                        MessageBox.Show("Enter theta 3 angle in range: [-90 :: 90]", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FKtheta3.BackColor = Color.Red;
                    }

                    PosFKpx.Text = "";
                    PosFKpy.Text = "";
                    PosFKpz.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Reset button
        private void button1_Click(object sender, EventArgs e)
        {
            string rst = "r";
            SerCOM.Write(rst);
            FKtheta1.Text = "0";
            FKtheta2.Text = "0";
            FKtheta3.Text = "0";
            trackBarTheta1.Value = 0;
            trackBarTheta2.Value = 0;
            trackBarTheta3.Value = 0;
            labeltheta1.Text = "0";
            labeltheta2.Text = "0";
            labeltheta3.Text = "0";
            PosFKpx.Text = "";
            PosFKpy.Text = "";
            PosFKpz.Text = "";

            IKPx.Text = "";
            IKPy.Text = "";
            IKPz.Text = "";

            AngIKtheta1.Text = "";
            AngIKtheta2.Text = "";
            AngIKtheta3.Text = "";

            Sol1theta1.Text = "0";
            Sol1theta2.Text = "0";
            Sol1theta3.Text = "0";
            Sol2theta1.Text = "0";
            Sol2theta3.Text = "0";
            Sol2theta2.Text = "0";
        }

        private void SendFirstSol_Click(object sender, EventArgs e)
        {
            AngIKtheta1.Text = Sol1theta1.Text;
            AngIKtheta2.Text = Sol1theta2.Text;
            AngIKtheta3.Text = Sol1theta3.Text;

            string data = "a" + AngIKtheta1.Text + "b" + AngIKtheta2.Text + "c" + AngIKtheta2.Text;
            SerCOM.Write(data);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void IntroBtn_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void SendSecondSol_Click(object sender, EventArgs e)
        {
            AngIKtheta1.Text = Sol2theta1.Text;
            AngIKtheta2.Text = Sol2theta2.Text;
            AngIKtheta3.Text = Sol2theta3.Text;

            string data = "a" + AngIKtheta1.Text + "b" + AngIKtheta2.Text + "c" + AngIKtheta2.Text;
            SerCOM.Write(data);
        }
        //Inverse kinematics button
        private void SendInverse_Click(object sender, EventArgs e)
        {
            double Px = Convert.ToDouble(IKPx.Text);
            double Py = Convert.ToDouble(IKPy.Text);
            double Pz = Convert.ToDouble(IKPz.Text);

            //Theta1
            double theta1 = Math.Atan(Py / Px) * degree;

            double xy = Math.Sqrt(Px * Px + Py * Py) - d2;
            if (xy > 422)
            {
                xy = 422;
            }
            double zz = Pz - dd;
            
            //Theta3
            double c3 = (xy * xy + zz * zz - L2 * L2 - L3 * L3) / (2 * L2 * L3);
            
            double s3 = Math.Sqrt(1 - c3 * c3);

            double theta3a = Math.Acos(c3) * degree;
            double theta3b = - theta3a;

            //Theta2
            double tanbeta = (L3 * s3) / (L2 + L3 * c3);
            double tangamma = zz / xy;
            double theta2a = (Math.Atan(tangamma) + Math.Atan(tanbeta)) * degree;
            double theta2b = (Math.Atan(tangamma) - Math.Atan(tanbeta)) * degree;
            
            // Bo nghiem 1
            Sol1theta1.Text = Convert.ToString(Math.Round(theta1, 3));
            Sol1theta2.Text = Convert.ToString(Math.Round(theta2b, 3));
            Sol1theta3.Text = Convert.ToString(Math.Round(theta3a, 3));

            // Bo nghiem 2
            Sol2theta1.Text = Convert.ToString(Math.Round(theta1, 3));
            Sol2theta2.Text = Convert.ToString(Math.Round(theta2a, 3));
            Sol2theta3.Text = Convert.ToString(Math.Round(theta3b, 3));
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void PortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SerCOM.PortName = PortBox.Text;
        }

        private void ConnectArduino_Click(object sender, EventArgs e)
        {
            if (i == false)
            {
                fConnectArduino();
            }
            else
            {
                fDisconnectArduino();
            }
        }

        private void fDisconnectArduino()
        {
            try
            {
                if (SerCOM.IsOpen)
                {
                    SerCOM.Close();
                    PortBox.Enabled = true;
                    ConnectArduino.Text = "Connect";
                    i = false;

                    groupBox1.Enabled = false;
                    groupBox4.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Comport is disconnected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("COM Port is not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void fConnectArduino()
        {
            if (PortBox.Text == "")
            {
                MessageBox.Show("Select COM Port.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (SerCOM.IsOpen)
                    {
                        MessageBox.Show("COM Port is ready to use", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        SerCOM.Open();
                        PortBox.Enabled = false;
                        groupBox1.Enabled = true;
                        groupBox4.Enabled = true;
                        ConnectArduino.Text = "Disconnect";
                        i = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("COM Port is not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
