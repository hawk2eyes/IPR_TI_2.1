using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor
{
    public partial class SpecialistForm : Form
    {
        private int port;
        private TcpClient client;

        private static NetworkStream stream;
        private static byte[] buffer = new byte[1024];
        static string totalBuffer = "";

        public SpecialistForm()
        {
            InitializeComponent();
            ConnectServer();
        }
        
        private void ConnectServer()
        {
            client = new TcpClient();
            client.Connect("localhost", this.port);

            stream = client.GetStream();
            stream.BeginRead(buffer, 0, buffer.Length, new AsyncCallback(OnRead), null);
            Send($"start\r\n\r\n");
            
        }

        private static void Send(string v)
        {
            stream.Write(System.Text.Encoding.ASCII.GetBytes(v), 0, v.Length);
            stream.Flush();
        }

        private void OnRead(IAsyncResult ar)
        {
            //message received
            Console.WriteLine($"Specialist: got data");
            int receivedBytes = stream.EndRead(ar);
            totalBuffer += System.Text.Encoding.ASCII.GetString(buffer, 0, receivedBytes);

            // from bytes to string
            while (totalBuffer.Contains("\r\n\r\n"))
            {
                string packet = totalBuffer.Substring(0, totalBuffer.IndexOf("\r\n\r\n"));
                totalBuffer = totalBuffer.Substring(totalBuffer.IndexOf("\r\n\r\n") + 4);

                string[] data = Regex.Split(packet, "\r\n");

                handlePacket(data);
            }

            // begin waiting for next 
            stream.BeginRead(buffer, 0, buffer.Length, new AsyncCallback(OnRead), null);
        }

        private async void handlePacket(string[] data)
        {
            switch (data[0])
            {
                default:
                    Console.WriteLine("Unknown package");
                    break;
            }
        }
    }
}
