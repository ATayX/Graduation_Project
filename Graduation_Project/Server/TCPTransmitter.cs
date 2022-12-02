using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Graduation_Project.Model;

namespace Graduation_Project.Server
{
    class TCPTransmitter
    {
        int HostPort = 8000;
        string Host = "192.168.137.14";
        static TcpClient client = new TcpClient();

        NetworkStream ns;

        public static bool exit = false;
        bool hold_comms = false;
        
        public Robot[] robotsArray;
        public byte[] Wheels_Buff = new byte[4];
        
        #region transmitter
        public void start()
        {
            try
            {
                client.Connect(Host, HostPort);
                ns = client.GetStream();

                while (exit == false)
                {
                    byte[] buffer = new byte[1024];
                    // first byte is Message header, second byte is Value header
                    if (client.Available >= 1)
                    {
                        Thread.Sleep(10); // some data is late? The solution worked! some data is late.. Error occured again. increased delay from 5 to 10. 
                        // read/store bytes
                        buffer = new byte[client.Available];
                        ns.Read(buffer, 0, client.Available);
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
                            robotsArray[0].test_update_from_report_message(readData);
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
            }
            catch
            {

            }
        #endregion
        }
        public void Close()
        {
            if (client.Connected) client.Close();
        }

        public void transmit_recieve_confirmation_flag()
        {
            byte my_signal = Convert.ToByte("~");
            byte[] my_bytes = new byte[1];
            my_bytes[0] = my_signal;
            // Do handshake to avoid noise
            ns.Write(my_bytes, 0, 1);
        }
        public void write_wheel_values(int right_wheel, int left_wheel)
        {
            hold_comms = true;
            byte my_signal = Convert.ToByte("W");
            byte[] my_bytes = new byte[1];
            my_bytes[0] = my_signal;
            ns.Write(my_bytes, 0, 1);

            // reset buffer
            Wheels_Buff = new byte[4];
            // right wheel
            if (right_wheel > 0) Wheels_Buff[0] = (byte)right_wheel;
            else if (right_wheel <= 0) Wheels_Buff[1] = (byte)(right_wheel * -1);
            // left wheel
            if (left_wheel > 0) Wheels_Buff[2] = (byte)left_wheel;
            else if (left_wheel <= 0) Wheels_Buff[3] = (byte)(left_wheel * -1);

            ns.Write(Wheels_Buff, 0, 4);
            hold_comms = false;
        }
    }
}
