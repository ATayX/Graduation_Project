using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Graduation_Project.Model;

namespace Graduation_Project.Server
{
    class Transmitter
    {
        private SerialPort serialPort;
        public static bool exit = false;
        public string portName = "COM3"; // default
        public int baudRate = 115200; // default
        bool hold_comms = false;
        public Robot[] robotsArray;

        public byte[] Wheels_Buff = new byte[4];

        public void Start()
        {
            try
            {
                serialPort = new SerialPort();
                serialPort.PortName = portName;
                serialPort.BaudRate = baudRate;
                serialPort.Open();
                // C# establishing connection signal request
                transmit_recieve_confirmation_flag();
                #region reciever
                while (exit == false)
                {
                    byte[] buffer = new byte[1024];
                    // first byte is Message header, second byte is Value header
                    if (serialPort.BytesToRead >= 1)
                    {
                        Thread.Sleep(10); // some data is late? The solution worked! some data is late.. Error occured again. increased delay from 5 to 10. 
                        // read/store bytes
                        buffer = new byte[serialPort.BytesToRead];
                        serialPort.Read(buffer, 0, serialPort.BytesToRead);
                    }

                    // read message
                    string readData = Encoding.Default.GetString(buffer);
                    // use message
                    if (readData != "")
                    {
                        Console.WriteLine(readData);
                        if (readData[0] == '~' && hold_comms == false)
                        {
                            // robot establishing connection signal response
                            transmit_recieve_confirmation_flag();
                        }
                        // prefix condition, R = Report Message
                        else if (readData[0] == 'R' && hold_comms == false) 
                        {
                            // FIX: can only be used for one robot
                            Console.WriteLine(readData);
                            //robotsArray[0].test_update_from_report_message(readData);
                            transmit_recieve_confirmation_flag();
                        }
                        // C = Confirmation
                        else if (readData[0] == 'C')
                        {
                            Console.WriteLine("Arduino: I recieved");
                            hold_comms = false;
                            transmit_recieve_confirmation_flag();
                        }
                    }
                    Thread.Sleep(10);
                }
                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine("Server Error:" + ex.StackTrace);
            }
        }
        public void Close()
        {
            if (serialPort.IsOpen) serialPort.Close();
        }
        
        public void transmit_recieve_confirmation_flag()
        {
            // Do handshake to avoid noise
            serialPort.Write("~");
        }

        public void transmit_instruction(string instruction)
        {
            hold_comms = true; // hold comms is used to prevent interlocking messages
            // Thread.Sleep(10);
            serialPort.Write(instruction);
        }
        public void write_wheel_values(int right_wheel, int left_wheel)
        {
            hold_comms = true;
            serialPort.Write("W");
            // reset buffer
            Wheels_Buff = new byte[4];
            // right wheel
            if (right_wheel > 0) Wheels_Buff[0] = (byte)right_wheel;
            else if (right_wheel <= 0) Wheels_Buff[1] = (byte)(right_wheel * -1);
            // left wheel
            if (left_wheel > 0) Wheels_Buff[2] = (byte)left_wheel;
            else if (left_wheel <= 0) Wheels_Buff[3] = (byte)(left_wheel*-1);

            serialPort.Write(Wheels_Buff, 0, 4);
            hold_comms = false;
        }
        
    }
}
