using System;
using System.Net.Sockets;
using Graduation_Project.Model;

namespace Graduation_Project.Server
{
    class TCPTransmitter
    {
        public int HostPort = 8080;
        public string HostIP = "192.168.137.14";
        public TcpClient client = new TcpClient();
        // "RCAGV01"
        NetworkStream ns;

        public static bool exit = false;
        
        public Robot[] robotsArray;
        public byte[] Wheels_Buff = new byte[5];
        public bool isExit = false;

        #region transmitter
        public void Start()
        {
            try
            {
                // restablish TCP connection if it was lost
                    Connect();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Server Error:" + ex.StackTrace);
            }
        }
        #endregion
        private void Connect()
        {
            try
            {
                if (client.Connected == false)
                {
                    client.Connect(HostIP, HostPort);
                    ns = client.GetStream();
                    Console.WriteLine("Connection to robot established! ");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("No Connection: Cannot Establish TCP connection and thus UDP will not connect!");
            }
         
        }
        public void Close()
        {
            if (client.Connected)
            {
                client.Close();
                isExit = true;
            }
        }
        public void write_wheel_values(int right_wheel, int left_wheel)
        {
            // reset buffer
            try 
            {

                // client.Connect(HostIP, HostPort);
                if (client.Connected) Console.WriteLine("CAN WRITE");
                
                Wheels_Buff = new byte[6];
                Wheels_Buff[0] = Convert.ToByte('W'); // wheel prefix flag
                                                      // right wheel
                if (right_wheel > 0) Wheels_Buff[1] = (byte)right_wheel;
                else if (right_wheel <= 0) Wheels_Buff[2] = (byte)(right_wheel * -1);
                // left wheel
                if (left_wheel > 0) Wheels_Buff[3] = (byte)left_wheel;
                else if (left_wheel <= 0) Wheels_Buff[4] = (byte)(left_wheel * -1);
                Wheels_Buff[5] = (byte)'E';
                ns.Write(Wheels_Buff, 0, Wheels_Buff.Length-1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to transmit new wheels value");
            }
        }
    }
}
