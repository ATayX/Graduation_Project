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
using System.Net;

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
        bool e = false;
        bool q = false;

        Robot myRobot = new Robot();
        TCPTransmitter myTCPTransmitter = new TCPTransmitter();
        TCPTransmitter_P2 myTCPTransmitter_P2 = new TCPTransmitter_P2();

        public Form1()
        {
            // FALSE INFORMATION, NOT UPDATED
            myRobot.left_motor_speed = 0;
            myRobot.right_motor_speed = 0;
            //
            InitializeComponent();
            // Setup Robot Server capabilities for Transmitter
            myTCPTransmitter_P2.robotsArray = new Robot[1];
            myTCPTransmitter_P2.robotsArray[0] = myRobot;

            // Starting transmission
            Thread thread = new Thread(
                new ThreadStart(myTCPTransmitter.Start));
            thread.IsBackground = true;
            thread.Start();
            Thread thread1 = new Thread( 
                new ThreadStart(myTCPTransmitter_P2.Start));
            thread1.IsBackground = true;
            thread1.Start();

            Controller_toggle.Checked = false;
        }

        #region controller_ASWD
        protected override void OnKeyDown(KeyEventArgs er)
        {

            base.OnKeyDown(er);

            if (er.KeyCode == Keys.W)
            {
                if (w == false) // if click is new
                {
                    right_wheel += move_speed;
                    left_wheel += move_speed;
                }
                w = true;
            }
            if (er.KeyCode == Keys.A)
            {
                if (a == false) left_wheel += turn_speed; // if click is new
                a = true;
            }
            if (er.KeyCode == Keys.D)
            {
                if (d == false) right_wheel += turn_speed; // if click is new
                d = true;
            }
            if (er.KeyCode == Keys.S)
            {
                if (s == false) // if click is new
                {
                    right_wheel -= move_speed;
                    left_wheel -= move_speed;
                }
                s = true;
            }
            if (er.KeyCode == Keys.E)
            {
                if (e == false) // if click is new
                {
                    right_wheel += move_speed;
                    left_wheel -= move_speed;
                }
                e = true;
            }
            if (er.KeyCode == Keys.Q)
            {
                if (q == false) // if click is new
                {
                    right_wheel += move_speed;
                    left_wheel -= move_speed;
                }
                q = true;
            }

        }

        protected override void OnKeyUp(KeyEventArgs er)
        {

            base.OnKeyUp(er);

            if (er.KeyCode == Keys.W)
            {
                if (w)
                {
                    right_wheel -= move_speed;
                    left_wheel -= move_speed;
                }
                w = false;
            }
            if (er.KeyCode == Keys.A)
            {
                if (a) left_wheel -= turn_speed;
                a = false;
            }
            if (er.KeyCode == Keys.D)
            {
                if (d) right_wheel -= turn_speed;
                d = false;
            }
            if (er.KeyCode == Keys.S)
            {
                if (s)
                {
                    right_wheel += move_speed;
                    left_wheel += move_speed;
                }
                s = false;
            }
            if (er.KeyCode == Keys.E)
            {
                if (e == true) // if click is new
                {
                    right_wheel -= move_speed;
                    left_wheel += move_speed;
                }
                e = false;
            }
            if (er.KeyCode == Keys.Q)
            {
                if (q == true) // if click is new
                {
                    right_wheel -= move_speed;
                    left_wheel += move_speed;
                }
                q = false;
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
                    myTCPTransmitter,
                    Convert.ToInt32(right_wheel),
                    Convert.ToInt32(left_wheel)
                );
        }

        private void new_servo_angles_button_Click(object sender, EventArgs e)
        {
            
        }

        private void new_wheel_motors_button_Click(object sender, EventArgs e)
        {
            myRobot.test_move_wheels(
                myTCPTransmitter,
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
                    myTCPTransmitter,
                    Convert.ToInt32(right_wheel),
                    Convert.ToInt32(left_wheel)
                );
                KeyPreview = false;
            }
        }
    }
}
