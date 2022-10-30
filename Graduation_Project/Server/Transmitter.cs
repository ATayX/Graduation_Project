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
        public int baudRate = 9600; // default
        public Robot[] robotsArray;

        public void Start()
        {
            try
            {
                serialPort = new SerialPort();
                serialPort.PortName = portName;
                serialPort.BaudRate = baudRate;
                serialPort.Open();
                #region reciever
                while (exit == false)
                {
                    byte[] buffer = new byte[1024];
                    // first byte is Message header, second byte is Value header
                    if (serialPort.BytesToRead >= 2)
                    {
                        // read/store bytes
                        buffer = new byte[serialPort.BytesToRead];
                        serialPort.Read(buffer, 0, serialPort.BytesToRead);
                    }

                    // read message
                    string readData = Encoding.Default.GetString(buffer);
                    // use message
                    if (readData != "")
                    {
                        // prefix condition, R = Report Message
                        if (readData[0] == 'R') 
                        {
                            // FIX: can only be used for one robot
                            robotsArray[0].update_from_report_message(readData);
                        }
                    }
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
        /*
        public void Transmit()
        {
            // Do handshake to avoid noise
            byte[] buffer;

            serialPort.write();
        }
        */
    }
}
