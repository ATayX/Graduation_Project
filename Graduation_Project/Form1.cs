using System;
using System.Windows.Forms;
using Graduation_Project.Model;
using Graduation_Project.Server;
using System.Threading;

namespace Graduation_Project
{
    public partial class Form1 : Form
    {
        // distance (ultrasonic sesnor) declarations
        int obsticleStopDistance = 35; // cm
        // servo values
        int servo_angle_step = 5; // degrees
        static int xServo_center = 84; // degrees
        static int yServo_center = 99; // degrees

        int xServo_angle = xServo_center;
        int yServo_angle = yServo_center;

        bool backwards = false;

        // speed values
        int turn_speed = 100; // power
        int move_speed = 150; // power

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


        Robot myRobot = new Robot();
        TCPTransmitter myTCPTransmitter = new TCPTransmitter();
        UDPTransmitter myUDPTransmitter = new UDPTransmitter();
        UDPTransmitter2 myUDPTransmitter2 = new UDPTransmitter2();

        public Form1()
        {
            InitializeComponent();
            // FALSE INFORMATION, NOT UPDATED
            myRobot.left_motor_speed = 0;
            myRobot.right_motor_speed = 0;
            // Setup Robot Server capabilities for Transmitter
            myUDPTransmitter.robotsArray = new Robot[1];
            myUDPTransmitter.robotsArray[0] = myRobot;
            // Starting transmission
            Thread thread0 = new Thread(
                new ThreadStart(myTCPTransmitter.Start));
            thread0.IsBackground = true;
            thread0.Start();
            Thread thread = new Thread(
                new ThreadStart(myUDPTransmitter2.Start));
            thread.IsBackground = true;
            thread.Start();
            Thread thread1 = new Thread( 
                new ThreadStart(myUDPTransmitter.Start));
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
                    right_wheel += turn_speed;
                    left_wheel -= turn_speed;
                }
                e = true;
            }
            if (er.KeyCode == Keys.Q)
            {
                if (q == false) // if click is new
                {
                    right_wheel -= turn_speed;
                    left_wheel += turn_speed;
                }
                q = true;
            }
            if (er.KeyCode == Keys.Z)
            {
                if (z == false) // if click is new
                {
                    left_wheel -= turn_speed;
                }
                z = true;
            }
            if (er.KeyCode == Keys.C)
            {
                if (c == false) // if click is new
                {
                    right_wheel -= turn_speed;
                }
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
                    right_wheel -= turn_speed;
                    left_wheel += turn_speed;
                }
                e = false;
            }
            if (er.KeyCode == Keys.Q)
            {
                if (q == true) // if click is new
                {
                    right_wheel += turn_speed;
                    left_wheel -= turn_speed;
                }
                q = false;
            }
            if (er.KeyCode == Keys.Z)
            {
                if (z == true) // if click is new
                {
                    left_wheel += turn_speed;
                }
                z = false;
            }
            if (er.KeyCode == Keys.C)
            {
                if (c == true) // if click is new
                {
                    right_wheel += turn_speed;
                }
                c = false;
            }
        }

        #endregion

        // update values
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Servo scan function, SCANS if active
            if (scanner_mode.Checked) servo_scan_movement();
            // update motor controller labels
            Left_wheel_value.Text = left_wheel.ToString();
            Right_wheel_value.Text = right_wheel.ToString();
            // UPDATING TEXTBOXES
            // display distance value
            distance_textBox.Text = Convert.ToString(myRobot.distance);
            // display servo values
            xServo_angle_textBox.Text = Convert.ToString(myRobot.xServo_angle);
            yServo_angle_textBox.Text = Convert.ToString(myRobot.yServo_angle);
            // display motor values
            right_motor_speed_textBox.Text = Convert.ToString(myRobot.right_motor_speed);
            left_motor_speed_textBox.Text = Convert.ToString(myRobot.left_motor_speed);
            // display distance
            distance_textBox.Text = Convert.ToString(myRobot.distance);
            if (
                (Controller_toggle.Checked
                ||
                scanner_mode.Checked)
                &&
                (myRobot.left_motor_speed != left_wheel
                ||
                myRobot.right_motor_speed != right_wheel
                ||
                myRobot.xServo_angle != xServo_angle
                ||
                myRobot.yServo_angle != yServo_angle) // case any value changed
                ){
                myRobot.write_values(
                    myUDPTransmitter2,
                    right_wheel,
                    left_wheel,
                    xServo_angle,
                    yServo_angle
                );

                if (collisionPreventionToggle.Checked) moving_direction_alertness(); // clossion safety override
            
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
                    myUDPTransmitter2,
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
                    myUDPTransmitter2,
                    right_wheel,
                    left_wheel,
                    Convert.ToInt32(new_xServo_angle_numericUpDown.Value),
                    Convert.ToInt32(new_yServo_angle_numericUpDown.Value)
                );
        }

        private void new_wheel_motors_button_Click(object sender, EventArgs e)
        {
            myRobot.write_values(
                    myUDPTransmitter2,
                    Convert.ToInt32(new_right_motor_speed_numericUpDown.Value),
                    Convert.ToInt32(new_left_motor_speed_numericUpDown.Value),
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
                    myUDPTransmitter2,
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
                    (right_wheel + left_wheel > 0) // case robot is still moving forward
                    )
                {
                    // initiate full stop
                    right_wheel = 0;
                    left_wheel = 0;
                }
            }
            else if (right_wheel < left_wheel)
            {
                xServo_angle = xServo_center + 50; // moving to right side
                if (myRobot.distance <= obsticleStopDistance
                    &&
                    (left_wheel > right_wheel)) // case robot is still moving right
                {
                    // initiate full stop
                    right_wheel = 0;
                    left_wheel = 0;
                }
            }
            else if (right_wheel > left_wheel)
            {
                xServo_angle = xServo_center - 50; // moving to left side
                if (myRobot.distance <= obsticleStopDistance
                    &&
                    (right_wheel > left_wheel)) // case robot is still moving left
                {
                    // initiate full stop
                    right_wheel = 0;
                    left_wheel = 0;
                }
            }
        }
        #endregion
    }
}
