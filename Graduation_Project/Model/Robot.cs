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

        public void update_from_report_message(string report_message)
        {
            try
            {
                // report message example RD123S90,90
                // "D1233"
                // get ultrasonic distance info
                string distance_str = report_message.Substring(report_message.IndexOf('D') + 1,
                    (report_message.IndexOf('W') - 1) - report_message.IndexOf('D'));
                distance = Convert.ToInt32(distance_str);
                // Get wheel info
                string wheel_report_str = report_message.Substring(report_message.IndexOf('W') + 1,
                    (report_message.IndexOf('S') - 1) - report_message.IndexOf('W'));
                string[] wheel_values = wheel_report_str.Split(',');
                right_motor_speed = Convert.ToInt32(wheel_values[0]);
                left_motor_speed = Convert.ToInt32(wheel_values[1]);
                // Get unltrasonic pan servo info
                string servo_report_str = report_message.Substring(report_message.IndexOf('S') + 1,
                    (report_message.Length - 1) - report_message.IndexOf('S'));
                string[] servo_values = servo_report_str.Split(',');
                xServo_angle = Convert.ToInt32(servo_values[0]);
                yServo_angle = Convert.ToInt32(servo_values[1]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Robot Error: Failed to update robot from report robot arduino message data" 
                    + "\nData corruption might occured along the way of transmission\n" + ex.StackTrace);
            }

        }
        public void move_wheels(USBTransmitter myTransmitter, int new_right_motor_speed, int new_left_motor_speed)
        {
            if ((-255 <= new_right_motor_speed && new_right_motor_speed <= 255) && (-255 <= new_left_motor_speed && new_left_motor_speed <= 255))
            {
                // if less than 0 incriment '-' then add padded absolute of Value
                // adding instruction identifier
                string instruction = "I";
                // adding instruction specifier + values
                instruction += "W" + parse_value(new_right_motor_speed) + 
                    "," + parse_value(new_left_motor_speed) +
                    "S" + padded_3digit(Convert.ToString(xServo_angle)) + 
                    "," + padded_3digit(Convert.ToString(yServo_angle));
                Console.WriteLine(instruction);
                myTransmitter.transmit_instruction(instruction);
            }
        }
        
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
        [Obsolete]
        public void test_update_from_report_message(int val1, int val2, int val3, int val4)
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
        [Obsolete]
        public void test_move_wheels(TCPTransmitter myTCPTransmitter, int new_right_motor_speed, int new_left_motor_speed)
        {
            myTCPTransmitter.write_wheel_values(new_right_motor_speed, new_left_motor_speed);
        }

    }
}
