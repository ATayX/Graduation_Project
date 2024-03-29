﻿using System;
using System.Windows.Forms;
using Graduation_Project.Model;
using Graduation_Project.Server;
using System.Threading;

namespace Graduation_Project
{
    public partial class RCWarehouseRobot : Form
    {
        // distance (ultrasonic sesnor) declarations
        int obsticleStopDistance = 35; // cm
        // servo values
        int servo_angle_step = 5; // degrees
        static int xServo_center = 84; // degrees
        static int yServo_center = 90; // degrees

        int xServo_angle = xServo_center;
        int yServo_angle = yServo_center;


        bool backwards = false;

        // speed values
        // UNLOADED default set
        int turn_pwm = 100; // power
        int move_pwm = 150; // power

        int right_wheel = 0; // power
        int left_wheel = 0; // power

        // keyboard control declarations
        bool w = false;
        bool a = false;
        bool s = false;
        bool d = false;
        bool e = false;
        bool q = false;
        bool z = false;
        bool c = false;
        long j_timeStamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        long l_timeStamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        long i_timeStamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        long k_timeStamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        long click_delay = 10; // microseconds

        // obsticle avoidance declarations
        int q_value = 0; // "rightWheel +=", "leftWheel -="
        int e_value = 0; // "rightWheel -=", "leftWheel +="
        int w_value = 0; // "rightWheel +=", "leftWheel +="
        int s_value = 0; // "rightWheel -=", "leftWheel -="
        int a_value = 0; // "rightWheel +="
        int d_value = 0; // "leftWheel +="
        int z_value = 0; // "rightWheel -="
        int c_value = 0; // "leftWheel -="



        Robot myRobot = new Robot();
        UDPReceiver myUDPReceiver = new UDPReceiver();
        UDPTransmitter myUDPTransmitter = new UDPTransmitter();

        public RCWarehouseRobot()
        {
            InitializeComponent();
            // enable unloaded pwm
            unloadedPwmRadioButton.Checked = true;
            // FALSE INFORMATION, NOT UPDATED
            myRobot.left_motor_pwm = 0;
            myRobot.right_motor_pwm = 0;
            // Setup Robot Server capabilities for Transmitter
            myUDPReceiver.robotsArray = new Robot[1];
            myUDPReceiver.robotsArray[0] = myRobot;
            // Starting transmission
            Thread TCPServerThread = new Thread(
                new ThreadStart(TCPServer.Start));
            TCPServerThread.IsBackground = true;
            TCPServerThread.Name = "TCPServerThread";
            TCPServerThread.Start();
            Console.WriteLine("Started thread for TCPServer: " + TCPServerThread.ManagedThreadId.ToString());

            Thread UDPTransmitterThread = new Thread(
                new ThreadStart(myUDPTransmitter.Start));
            UDPTransmitterThread.IsBackground = true;
            UDPTransmitterThread.Name = "UDPTransmitterThread";
            UDPTransmitterThread.Start();
            Console.WriteLine("Started thread for UDPTransmitter: " + UDPTransmitterThread.ManagedThreadId.ToString());

            Thread UDPReceiverThread = new Thread( 
                new ThreadStart(myUDPReceiver.Start));
            UDPReceiverThread.IsBackground = true;
            UDPReceiverThread.Name = "UDPReceiverThread";
            UDPReceiverThread.Start();
            Console.WriteLine("Started thread for UDPReceiver: " + UDPReceiverThread.ManagedThreadId.ToString());

            Controller_toggle.Checked = false;
        }

        #region controller_ASWD
        protected override void OnKeyDown(KeyEventArgs er)
        {

            base.OnKeyDown(er);
            if (er.KeyCode == Keys.W)
            {
                if (w == false) w_value = move_pwm; // if click is new
                w = true;
            }
            if (er.KeyCode == Keys.A)
            {
                if (a == false) a_value = turn_pwm; // if click is new
                a = true;
            }
            if (er.KeyCode == Keys.D)
            {
                if (d == false) d_value = turn_pwm; // if click is new
                d = true;
            }
            if (er.KeyCode == Keys.S)
            {
                if (s == false) s_value = move_pwm; // if click is new
                s = true;
            }
            if (er.KeyCode == Keys.E)
            {
                if (e == false) e_value = turn_pwm; // if click is new
                e = true;
            }
            if (er.KeyCode == Keys.Q)
            {
                if (q == false) q_value = turn_pwm; // if click is new
                q = true;
            }
            if (er.KeyCode == Keys.Z)
            {
                if (z == false) z_value = turn_pwm; // if click is new
                z = true;
            }
            if (er.KeyCode == Keys.C)
            {
                if (c == false) c_value = turn_pwm; // if click is new
                c = true;
            }
            if (er.KeyCode == Keys.I && DateTimeOffset.Now.ToUnixTimeMilliseconds() >= i_timeStamp + click_delay)
            {
                if(yServo_angle < 180 - servo_angle_step) yServo_angle += servo_angle_step;
                if (collisionPreventionToggle.Checked) moving_direction_alertness(); // clossion safety override
                i_timeStamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            }
            if (er.KeyCode == Keys.K && DateTimeOffset.Now.ToUnixTimeMilliseconds() >= k_timeStamp + click_delay)
            {
                if (yServo_angle > 0 + servo_angle_step) yServo_angle -= servo_angle_step;
                if (collisionPreventionToggle.Checked) moving_direction_alertness(); // clossion safety override
                k_timeStamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            }
            if (er.KeyCode == Keys.J && DateTimeOffset.Now.ToUnixTimeMilliseconds() >= j_timeStamp + click_delay)
            {
                if (xServo_angle < 180 - servo_angle_step) xServo_angle += servo_angle_step;
                if (collisionPreventionToggle.Checked) moving_direction_alertness(); // clossion safety override
                j_timeStamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            }
            if (er.KeyCode == Keys.L && DateTimeOffset.Now.ToUnixTimeMilliseconds() >= l_timeStamp + click_delay)
            {
                if (xServo_angle > 0 + servo_angle_step) xServo_angle -= servo_angle_step;
                if (collisionPreventionToggle.Checked) moving_direction_alertness(); // clossion safety override
                l_timeStamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            }
        }

        protected override void OnKeyUp(KeyEventArgs er)
        {

            base.OnKeyUp(er);

            if (er.KeyCode == Keys.W)
            {
                if (w) w_value = 0;
                w = false;
            }
            if (er.KeyCode == Keys.A)
            {
                if (a) a_value = 0;
                a = false;
            }
            if (er.KeyCode == Keys.D)
            {
                if (d) d_value = 0;
                d = false;
            }
            if (er.KeyCode == Keys.S)
            {
                if (s) s_value = 0;
                s = false;
            }
            if (er.KeyCode == Keys.E)
            {
                if (e == true) e_value = 0;
                e = false;
            }
            if (er.KeyCode == Keys.Q)
            {
                if (q == true) q_value = 0;
                q = false;
            }
            if (er.KeyCode == Keys.Z) 
            {
                if (z == true) z_value = 0;
                z = false;
            }
            if (er.KeyCode == Keys.C)
            {
                if (c == true) c_value = 0;
                c = false;
            }
        }

        #endregion

        // update values
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Servo scan function, SCANS if active
            if (scanner_mode.Checked) servo_scan_movement();
            // UPDATING TEXTBOXES
            // display distance value
            distance_textBox.Text = Convert.ToString(myRobot.distance);
            // display servo values
            xServo_angle_textBox.Text = Convert.ToString(myRobot.xServo_angle);
            yServo_angle_textBox.Text = Convert.ToString(myRobot.yServo_angle);
            // display motor values
            right_motor_pwm_textBox.Text = Convert.ToString(myRobot.right_motor_pwm);
            left_motor_pwm_textBox.Text = Convert.ToString(myRobot.left_motor_pwm);
            // display motor line speed
            right_motor_line_speed_textBox.Text = Convert.ToString(myRobot.right_motor_lines_speed);
            left_motor_line_speed_textBox.Text = Convert.ToString(myRobot.left_motor_lines_speed);
            // display distance
            distance_textBox.Text = Convert.ToString(myRobot.distance);


            // sum keys values
            sum_motor_keys_vals();
            // check for collision prevention
            if (
                (Controller_toggle.Checked
                ||
                scanner_mode.Checked)
                &&
                (myRobot.left_motor_pwm != left_wheel
                ||
                myRobot.right_motor_pwm != right_wheel
                ||
                myRobot.xServo_angle != xServo_angle
                ||
                myRobot.yServo_angle != yServo_angle) // case any value changed
                ){
                // write values to robot
                myRobot.write_values(
                    myUDPTransmitter,
                    right_wheel,
                    left_wheel,
                    xServo_angle,
                    yServo_angle
                );
                }
            }
        
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
                myRobot.write_values(
                    myUDPTransmitter,
                    right_wheel,
                    left_wheel,
                    xServo_angle,
                    yServo_angle
                );
                KeyPreview = false;
            }
        }

        #region ClickableButtonsFunctions
        private void new_servo_angles_button_Click(object sender, EventArgs e)
        {
            xServo_angle = Convert.ToInt32(new_xServo_angle_numericUpDown.Value);
            xServo_angle = Convert.ToInt32(new_yServo_angle_numericUpDown.Value);

            if (collisionPreventionToggle.Checked) moving_direction_alertness(); // clossion safety override

            myRobot.write_values(
                    myUDPTransmitter,
                    right_wheel,
                    left_wheel,
                    Convert.ToInt32(new_xServo_angle_numericUpDown.Value),
                    Convert.ToInt32(new_yServo_angle_numericUpDown.Value)
                );
        }

        private void new_wheel_motors_button_Click(object sender, EventArgs e)
        {
            myRobot.write_values(
                    myUDPTransmitter,
                    Convert.ToInt32(new_right_motor_pwm_numericUpDown.Value),
                    Convert.ToInt32(new_left_motor_pwm_numericUpDown.Value),
                    xServo_angle,
                    yServo_angle
                );
        }
        #endregion

        #region scanner_servo
        private void scanner_mode_CheckedChanged(object sender, EventArgs e)
        {
            if (scanner_mode.Checked)
            {
                xServo_angle = xServo_center;
                yServo_angle = yServo_center;
            }
            if (scanner_mode.Checked == false)
            {
                xServo_angle = xServo_center;
                yServo_angle = yServo_center;
            }

            if (collisionPreventionToggle.Checked) moving_direction_alertness(); // clossion safety override

            myRobot.write_values(
                    myUDPTransmitter,
                    right_wheel,
                    left_wheel,
                    xServo_angle,
                    yServo_angle
                );
        }
        private void servo_scan_movement()
        {
            if (backwards)
            {
                if (xServo_angle <= 1) backwards = false;
                xServo_angle -= 1;
            }
            else
            {
                if (xServo_angle >= 179) backwards = true;
                xServo_angle += 1;
            }

            if (collisionPreventionToggle.Checked) moving_direction_alertness(); // clossion safety override
        
        }
        #endregion

        #region collision_prevention
        private void collisionPreventionToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (collisionPreventionToggle.Checked == false)
            {
                xServo_angle = xServo_center;
                yServo_angle = yServo_center;
            }
        }
        private void moving_direction_alertness() // servo pan direction override
        {
            if (right_wheel == left_wheel && left_wheel != 0) // moving stright
            {
                xServo_angle = xServo_center;
                if (myRobot.distance <= obsticleStopDistance
                    &&
                    (w_value + d_value + a_value > 0) // case robot is still moving forward
                    )
                {

                    // initiate partial stop
                    w_value = 0;
                    d_value = 0;
                    a_value = 0;
                }
            }
            else if (right_wheel < left_wheel)
            {
                xServo_angle = xServo_center - 50; // moving to right side
                if (myRobot.distance <= obsticleStopDistance
                    &&
                    // !!robot still can rotate around itself
                    (w_value + d_value > 0)) // case robot is still moving right
                {
                    // iniitiate partial stop
                    w_value = 0;
                    d_value = 0;
                }
            }
            else if (right_wheel > left_wheel)
            {
                xServo_angle = xServo_center + 50; // moving to left side
                if (myRobot.distance <= obsticleStopDistance
                    &&
                    // !!robot still can rotate around itself
                    (w_value + a_value > 0)) // case robot is still moving left
                {
                    // initiate full stop
                    w_value = 0;
                    a_value = 0;
                }
            }
        }
        #endregion
        private void sum_motor_keys_vals()
        {
            right_wheel = - q_value + e_value + w_value - s_value + a_value - z_value; // q w e s a z
            left_wheel = - e_value + q_value + w_value - s_value + d_value - c_value; // q w e s d c 
            if (collisionPreventionToggle.Checked) moving_direction_alertness(); // clossion safety override
            right_wheel = - q_value + e_value + w_value - s_value + a_value - z_value; // q w e s a z
            left_wheel = - e_value + q_value + w_value - s_value + d_value - c_value; // q w e s d c 
            if (right_wheel > 255) right_wheel = 255;
            if (left_wheel > 255) left_wheel = 255;
        }
        #region PWM Control
        private void unloadedPwmRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (unloadedPwmRadioButton.Enabled)
            {
                // UNLOADED PWM SET
                turn_pwm = 100; // power
                move_pwm = 150; // power
            }
        }

        private void loadedPwmRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (loadedPwmRadioButton.Enabled)
            {
                // LOADED 3-6KG PWM SET
                turn_pwm = 180; // power
                move_pwm = 200; // power
            }
        }

        private void superLoadedPwmRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (superLoadedPwmRadioButton.Enabled)
            {
                // LOADED 3-6KG PWM SET
                turn_pwm = 255; // power
                move_pwm = 255; // power
            }
        }
        #endregion
    }
}
