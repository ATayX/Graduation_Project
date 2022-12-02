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
        int turn_speed = 100;
        int move_speed = 150;

        int right_wheel = 0;
        int left_wheel = 0;

        bool w = false;
        bool a = false;
        bool s = false;
        bool d = false;

        Robot myRobot = new Robot();
        Transmitter myTransmitter = new Transmitter();
        TCPTransmitter myTCPTransmitter = new TCPTransmitter();

        public Form1()
        {
            // FALSE INFORMATION, NOT UPDATED
            myRobot.left_motor_speed = 0;
            myRobot.right_motor_speed = 0;
            //
            InitializeComponent();
            // Setup transmission
            myTransmitter.portName = "COM3";
            myTransmitter.baudRate = 115200;
            // Setup Robot Server capabilities for Transmitter
            myTransmitter.robotsArray = new Robot[1];
            myTransmitter.robotsArray[0] = myRobot;

            // Starting transmission
            Thread thread = new Thread( 
                new ThreadStart(myTransmitter.Start));
            thread.IsBackground = true;
            thread.Start();

            Controller_toggle.Checked = false;
        }

        #region controller_ASWD
        protected override void OnKeyDown(KeyEventArgs e)
        {

            base.OnKeyDown(e);

            if (e.KeyCode == Keys.W)
            {
                if (w == false) // if click is new
                {
                    right_wheel += move_speed;
                    left_wheel += move_speed;
                }
                w = true;
            }
            if (e.KeyCode == Keys.A)
            {
                if (a == false) left_wheel += turn_speed; // if click is new
                a = true;
            }
            if (e.KeyCode == Keys.D)
            {
                if (d == false) right_wheel += turn_speed; // if click is new
                d = true;
            }
            if (e.KeyCode == Keys.S)
            {
                if (s == false) // if click is new
                {
                    right_wheel -= move_speed;
                    left_wheel -= move_speed;
                }
                s = true;
            }
                
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {

            base.OnKeyUp(e);

            if (e.KeyCode == Keys.W)
            {
                if (w)
                {
                    right_wheel -= move_speed;
                    left_wheel -= move_speed;
                }
                w = false;
            }
            if (e.KeyCode == Keys.A)
            {
                if (a) left_wheel -= turn_speed;
                a = false;
            }
            if (e.KeyCode == Keys.D)
            {
                if (d) right_wheel -= turn_speed;
                d = false;
            }
            if (e.KeyCode == Keys.S)
            {
                if (s)
                {
                    right_wheel += move_speed;
                    left_wheel += move_speed;
                }
                s = false;
            }
                
        }

        #endregion

        #region base_functions
        // update values
        private void timer1_Tick(object sender, EventArgs e)
        {
            Left_wheel_value.Text = left_wheel.ToString();
            Right_wheel_value.Text = right_wheel.ToString();

            distance_textBox.Text = Convert.ToString(myRobot.distance);
            xServo_angle_textBox.Text = Convert.ToString(myRobot.xServo_angle);
            yServo_angle_textBox.Text = Convert.ToString(myRobot.yServo_angle);
            right_motor_speed_textBox.Text = Convert.ToString(myRobot.right_motor_speed);
            left_motor_speed_textBox.Text = Convert.ToString(myRobot.left_motor_speed);
            if(Controller_toggle.Checked && 
                (myRobot.left_motor_speed != left_wheel 
                ||
                myRobot.right_motor_speed != right_wheel) 
                ) myRobot.test_move_wheels(
                    myTransmitter,
                    Convert.ToInt32(right_wheel),
                    Convert.ToInt32(left_wheel)
                );
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
            myRobot.test_move_wheels(
                myTransmitter,
                Convert.ToInt32(new_right_motor_speed_numericUpDown.Value),
                Convert.ToInt32(new_left_motor_speed_numericUpDown.Value)
                );
        }
        #endregion

        private void Controller_toggle_CheckedChanged(object sender, EventArgs e)
        {
            if (Controller_toggle.Checked)
            {
                KeyPreview = true;
            }
            else if (Controller_toggle.Checked == false)
            {
                right_wheel = 0;
                left_wheel = 0;
                myRobot.test_move_wheels(
                    myTransmitter,
                    Convert.ToInt32(right_wheel),
                    Convert.ToInt32(left_wheel)
                );
                KeyPreview = false;
            }
        }
    }
}
