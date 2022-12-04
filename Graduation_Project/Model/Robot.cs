using System;
using Graduation_Project.Server;

namespace Graduation_Project.Model
{
    class Robot
    {
        public int distance { set; get; }
        public int xServo_angle { set; get; }
        public int yServo_angle { set; get; }
        public int right_motor_speed { set; get; }
        public int left_motor_speed { set; get; }

        
        #region parse functions
        private string parse_value(int val)
        {
            string parsed_value = "";
            // add sign
            if (val < 0) parsed_value += "-";
            else parsed_value += "+";

            string myVal = Convert.ToString(Math.Abs(val));
            // add paddings + value
            parsed_value += padded_3digit(myVal);

            return parsed_value;
        }
        private string padded_3digit(string myVal)
        {
            string padded_val = "";
            for (int i = myVal.Length; i < 3; i++)
            {
                padded_val += "0";
            }
            padded_val += myVal;
            return padded_val;
        }
        #endregion
        public void update_from_report_message(int val1, int val2, int val3, int val4)
        {
            try
            {
                right_motor_speed = val1 - val2;
                left_motor_speed = val3 - val4;
                Console.WriteLine(right_motor_speed.ToString() + left_motor_speed.ToString());

            }
            catch (Exception ex)
            {
                Console.WriteLine("Robot Error: Failed to update robot from report robot arduino message data"
                    + "\nData corruption might occured along the way of transmission\n" + ex.StackTrace);
            }

        }
        public void move_wheels(TCPTransmitter myTCPTransmitter, int new_right_motor_speed, int new_left_motor_speed)
        {
            myTCPTransmitter.write_wheel_values(new_right_motor_speed, new_left_motor_speed);
        }

    }
}
