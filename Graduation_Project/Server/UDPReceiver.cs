using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Graduation_Project.Model;
using System.Diagnostics.Eventing.Reader;

namespace Graduation_Project.Server
{
    class UDPReceiver
    {
        public static int HostPort = 61050;
        public static IPAddress HostIP = IPAddress.Parse("192.168.1.222");

        static UdpClient live_feed_client = new UdpClient();
        IPEndPoint ep = new IPEndPoint(HostIP, HostPort);

        public static bool exit = false;

        public Robot[] robotsArray;

        // FLAGS
        // setup handshake flag
        int timeout_counter = 0;
        byte handshake_signal = Convert.ToByte('~');
        byte[] handshake_flag_bytes = new byte[1];

        #region Receiver
        public void Start()
        {
            
            handshake_flag_bytes[0] = handshake_signal; // setup flag_signal_bytes
            try
            {
                // setup UDP connection
                live_feed_client.Connect(ep); // connect report client
                send_handshake_flag_signal(); // initiate a handshake
                byte[] buffer = new byte[1024]; // data buffer
                while (true)
                {
                    //live_feed_client.Connect(ep);
                    Array.Clear(buffer, 0, buffer.Length); // clear buffer
                    if (live_feed_client.Available >= 1) 
                    {
                        // no sleep needed for UDP packets //Thread.Sleep(1); // some data is late? The solution worked! some data is late.. Error occured again. increased delay from 5 to 10. 
                        buffer = new byte[live_feed_client.Available]; // resize buffer
                        buffer = live_feed_client.Receive(ref ep); // read incoming data into buffer
                    }

                    // read message
                    char received_prefix = Encoding.Default.GetChars(buffer)[0]; // encode byte array into string
                    // use message
                    if (received_prefix != ' ')
                    {
                        //Console.WriteLine(Encoding.Default.GetChars(buffer));
                        switch (received_prefix)
                        {
                            case '~': // prefix handshake
                                send_handshake_flag_signal();
                                break;
                            
                            case 'R': // prefix report
                                report_message_handler(buffer);
                                break;

                            case '\0': // no transmission
                                /*
                                if (timeout_counter < 500)
                                    timeout_counter += 1;
                                else
                                    timeout_counter = 0;
                                    send_handshake_flag_signal(); // proceeding transmission
                                */
                                break;

                            default:
                                Console.WriteLine("Corrupted transmission!!");
                                break;
                        }
                    }
                    Thread.Sleep(1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Inbound UDP Error:" + ex.StackTrace);
            }
            #endregion
        }
        public void report_message_handler(byte[] message_buffer)
        {
            try 
            {
                // DC motor values
                int val1 = Convert.ToInt32(message_buffer[2]); // MOTOR 1 Forward
                int val2 = Convert.ToInt32(message_buffer[3]); // MOTOR 1 Reverse
                int val3 = Convert.ToInt32(message_buffer[4]); // MOTOR 2 Forward
                int val4 = Convert.ToInt32(message_buffer[5]); // MOTOR 2 Reverse
                // Servo motors values
                int val5 = Convert.ToInt32(message_buffer[6]); // SERVO 1
                int val6 = Convert.ToInt32(message_buffer[7]); // SERVO 2
                // distance values
                int val7 = Convert.ToInt32(message_buffer[8]); // DISTANCE BYTE1
                int val8 = Convert.ToInt32(message_buffer[9]); // DISTANCE BYTE2

                int val9 = message_buffer[10];
                int val10 = message_buffer[11];
                robotsArray[0].update_from_report_message(val1, val2, val3, val4, val5, val6, val7, val8, val9, val10);
            }
            catch(Exception ex)
            {
                Console.WriteLine("DATA CORRUPTION OCCURED: " + Encoding.Default.GetChars(message_buffer) + "\nError: " + ex);
            }
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
