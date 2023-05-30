using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Graduation_Project.Server
{
    class TCPServer
    {
        public static void Start()
        {
            // Set the port number for the TCP server
            int port = 61054;

            // Create a TCP listener
            TcpListener listener = new TcpListener(IPAddress.Any, port);

            try
            {
                // Start listening for client connections
                listener.Start();
                Console.WriteLine("Server started and listening on port {0}", port);

                while (true)
                {
                    // Accept an incoming client connection
                    TcpClient client = listener.AcceptTcpClient();

                    // Handle the client connection in a separate thread
                    ThreadPool.QueueUserWorkItem(HandleClient, client);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
            finally
            {
                // Stop listening and clean up the listener
                listener.Stop();
            }
        }

        static void HandleClient(object clientObj)
        {
            TcpClient client = (TcpClient)clientObj;

            // Get the client's IP address and port number
            IPEndPoint clientEndpoint = (IPEndPoint)client.Client.RemoteEndPoint;
            string clientAddress = clientEndpoint.Address.ToString();
            int clientPort = clientEndpoint.Port;
            Console.WriteLine("Client connected from {0}:{1}", clientAddress, clientPort);
            /*
            try
            {
                // Get the network stream for reading and writing data
                NetworkStream stream = client.GetStream();

                // Read data from the client
                byte[] buffer = new byte[1024];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Received from client ({0}:{1}): {2}", clientAddress, clientPort, dataReceived);

                // Send a response to the client
                string response = "Hello, client!";
                byte[] dataToSend = Encoding.ASCII.GetBytes(response);
                stream.Write(dataToSend, 0, dataToSend.Length);
                Console.WriteLine("Sent to client ({0}:{1}): {2}", clientAddress, clientPort, response);

                // Close the client connection
                client.Close();
                Console.WriteLine("Client connection closed: {0}:{1}", clientAddress, clientPort);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error handling client ({0}:{1}): {2}", clientAddress, clientPort, ex.Message);
            }
            */
        }
    }

}
