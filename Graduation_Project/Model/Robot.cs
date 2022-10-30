using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                string distance_str = report_message.Substring(report_message.IndexOf('D') + 1,
                    report_message.IndexOf('S') - report_message.IndexOf('D'));
                distance = Convert.ToInt32(distance_str);
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
    }
}
