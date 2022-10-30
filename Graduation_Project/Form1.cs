using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Graduation_Project.Model;
using Graduation_Project.Server;
using System.Threading;

namespace Graduation_Project
{
    public partial class Form1 : Form
    {
        Robot myRobot = new Robot();
        Transmitter myTransmitter = new Transmitter();

        public Form1()
        {
            // FALSE INFORMATION, NOT UPDATED
            myRobot.left_motor_speed = 0;
            myRobot.right_motor_speed = 0;
            //
            InitializeComponent();
            // Setup transmission
            myTransmitter.portName = "COM3";
            myTransmitter.baudRate = 19200;
            // Setup Robot Server capabilities for Transmitter
            myTransmitter.robotsArray = new Robot[1];
            myTransmitter.robotsArray[0] = myRobot;

            // Starting transmission
            Thread thread = new Thread( 
                new ThreadStart(myTransmitter.Start));
            thread.IsBackground = true;
            thread.Start();
        }
        // update values
        private void timer1_Tick(object sender, EventArgs e)
        {
            distance_textBox.Text = Convert.ToString(myRobot.distance);
            xServo_angle_textBox.Text = Convert.ToString(myRobot.xServo_angle);
            yServo_angle_textBox.Text = Convert.ToString(myRobot.yServo_angle);
            right_motor_speed_textBox.Text = Convert.ToString(myRobot.right_motor_speed);
            left_motor_speed_textBox.Text = Convert.ToString(myRobot.left_motor_speed);
        }

        private void new_servo_angles_button_Click(object sender, EventArgs e)
        {
            myRobot.move_sensor_pan(
                myTransmitter, 
                Convert.ToInt32(new_xServo_angle_numericUpDown.Value),
                Convert.ToInt32(new_yServo_angle_numericUpDown.Value)
                );
        }

        private void new_wheel_motors_button_Click(object sender, EventArgs e)
        {
            myRobot.move_wheels(
                myTransmitter,
                Convert.ToInt32(new_right_motor_speed_numericUpDown.Value),
                Convert.ToInt32(new_left_motor_speed_numericUpDown.Value)
                );
        }
    }
}
