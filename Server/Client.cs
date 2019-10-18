using Newtonsoft.Json;
using System;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace Server
{
    class Client
    {
        private TcpClient tcpClient;
        private Program program;
        private NetworkStream stream;

        private byte[] buffer = new byte[1024];

        string totalBuffer = "";

        public string login { get; set; }

        public Client(TcpClient tcpClient, Program program)
        {
            this.tcpClient = tcpClient;
            this.program = program;

            this.stream = tcpClient.GetStream();
            stream.BeginRead(buffer, 0, buffer.Length, new AsyncCallback(OnRead), null);
        }

        private void OnRead(IAsyncResult ar)
        {
            Console.WriteLine("server got data");
            int receivedBytes = stream.EndRead(ar);
            totalBuffer += System.Text.Encoding.ASCII.GetString(buffer, 0, receivedBytes);

            while (totalBuffer.Contains("\r\n\r\n"))
            {
                string packet = totalBuffer.Substring(0, totalBuffer.IndexOf("\r\n\r\n"));
                totalBuffer = totalBuffer.Substring(totalBuffer.IndexOf("\r\n\r\n") + 4);

                string[] data = Regex.Split(packet, "\r\n");
                handlePacket(data);
            }
            stream.BeginRead(buffer, 0, buffer.Length, new AsyncCallback(OnRead), null);
        }

        /*
         * Handling incoming packets from the clients.
         */
        private void handlePacket(string[] data)
        {
            switch (data[0])
            {
                default:
                    Console.WriteLine("Unknown packet");
                    Write("Unknown packet\r\n\r\n");
                    break;
            }
        }

        public void Write(string v)
        {
            stream.Write(System.Text.Encoding.ASCII.GetBytes(v), 0, v.Length);
            stream.Flush();
        }
    }
}
