using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Graduation_Project.Model;

namespace Graduation_Project.Server
{
    class UDPTransmitter
    {
        public static int HostPort = 8000;
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
                send_handshake_flag_signal(); // initiate a handshake

                byte[] buffer; // data buffer
                while (exit == false)
                {
                    buffer = new byte[1024]; // clear buffer
                    if (live_feed_client.Available >= 1) 
                    {
                        Thread.Sleep(50); // some data is late? The solution worked! some data is late.. Error occured again. increased delay from 5 to 10. 
                        buffer = new byte[live_feed_client.Available]; // resize buffer
                        buffer = live_feed_client.Receive(ref ep); // read incoming data into buffer
                    }

                    // read message
                    char received_prefix = Encoding.Default.GetChars(buffer)[0]; // encode byte array into string
                    // use message
                    if (received_prefix != ' ')
                    {
                        Console.WriteLine(Encoding.Default.GetChars(buffer));
                        switch (received_prefix)
                        {
                            case '~': // prefix handshake
                                send_handshake_flag_signal();
                                break;
                            
                            case 'R': // prefix report
                                report_message_handler(buffer);
                                break;

                            case '\0': // no transmission
                                Console.WriteLine("Not connected");
                                send_handshake_flag_signal(); // recover connection
                                break;

                            default:
                                Console.WriteLine("Corrupted transmission!!");
                                send_handshake_flag_signal(); // proceeding transmission
                                break;
                        }
                    }
                    Thread.Sleep(10);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Server Error:" + ex.StackTrace);
            }
            #endregion
        }
        public void report_message_handler(byte[] message_buffer)
        {
            try 
            {
                int val1 = message_buffer[2];
                int val2 = message_buffer[3];
                int val3 = message_buffer[4];
                int val4 = message_buffer[5];
                robotsArray[0].test_update_from_report_message(val1, val2, val3, val4);
            }
            catch(Exception ex)
            {
                Console.WriteLine("DATA CORRUPTION OCCURED: " + Encoding.Default.GetChars(message_buffer) + "\nError: " + ex);
            }
            send_handshake_flag_signal();
        }
        public void Close()
        {
            if (live_feed_client.Client.Connected) live_feed_client.Close();
        }
        public void send_handshake_flag_signal()
        {
            live_feed_client.SendAsync(handshake_flag_bytes, 1);
        }
    }
}
