using System;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace Server
{
    class Client
    {
        private string name;

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
                case "Test/login":
                    Console.WriteLine($"{data[1]} logged in");
                    this.name = data[1];
                    addPatient(data[1], data[2], data[3], data[4]);
                    break;
                case "Test/Connected":
                    Console.WriteLine($"{name} is connected to {data[1]}");
                    break;
                case "Test/BikeData":
                    Console.WriteLine($"{data[1]}");
                    break;
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

        private void addPatient(string name, string age, string weight, string gender)
        {
            Patient p = new Patient(name, Convert.ToInt32(age), Convert.ToInt32(weight), gender);
           

        }
    }
}
