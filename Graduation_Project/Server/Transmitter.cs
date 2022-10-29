using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Graduation_Project.model
{
    class Transmitter
    {
        private SerialPort serialPort;
        public static bool exit = false;
        public void Start(string portName = "COM4", int baudRate = 9600)
        {
            try
            {
                serialPort = new SerialPort();
                serialPort.PortName = portName;
                serialPort.BaudRate = baudRate;
                serialPort.Open();
                /*
                while (exit == false)
                {
                    string a = serialPort.ReadExisting();
                    Console.WriteLine(a);
                    Thread.Sleep(200);
                }
                */
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
        public void Transmit()
        {
            byte[] buffer;
            serialPort.write();
        }
    }
}
