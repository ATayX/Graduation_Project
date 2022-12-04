using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Graduation_Project.Model;

namespace Graduation_Project.Server
{
    class UDPTransmitter2
    {
        public static int HostPort = 9000;
        public static IPAddress HostIP = IPAddress.Parse("192.168.137.14");

        static UdpClient live_feed_client = new UdpClient();
        IPEndPoint ep = new IPEndPoint(HostIP, HostPort);

        public static bool exit = false;

        public Robot[] robotsArray;
        public byte[] Wheels_Buff = new byte[5];

        // FLAGS
        // setup handshake flag
        byte handshake_signal = Convert.ToByte('~');
        byte[] handshake_flag_bytes = new byte[1];

        #region transmitter
        public void Start()
        {

            handshake_flag_bytes[0] = handshake_signal; // setup flag_signal_bytes
            try
            {
                // setup UDP connection
                live_feed_client.Connect(ep); // connect report client

                byte[] buffer; // data buffer
                while (exit == false)
                {
                    live_feed_client.Connect(ep);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Server Error:" + ex.StackTrace);
            }
            #endregion
        }
        
        public void Close()
        {
            if (live_feed_client.Client.Connected) live_feed_client.Close();
        }
        public void write_wheel_values(int right_wheel, int left_wheel)
        {
            // reset buffer
            try
            {
                Wheels_Buff = new byte[6];
                Wheels_Buff[0] = Convert.ToByte('W'); // wheel prefix flag
                                                      // right wheel
                if (right_wheel > 0) Wheels_Buff[1] = (byte)right_wheel;
                else if (right_wheel <= 0) Wheels_Buff[2] = (byte)(right_wheel * -1);
                // left wheel
                if (left_wheel > 0) Wheels_Buff[3] = (byte)left_wheel;
                else if (left_wheel <= 0) Wheels_Buff[4] = (byte)(left_wheel * -1);
                Wheels_Buff[5] = (byte)'E';
                live_feed_client.SendAsync(Wheels_Buff, Wheels_Buff.Length - 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to transmit new wheels value");
            }
        }
    }
}
