using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        { 
            new Program();
        }

        TcpListener listener;
        private List<Client> clients = new List<Client>();
        private Dictionary<Patient, List<String[]>> patientData = new Dictionary<Patient, List<String[]>>();

        Program()
        {
            // make a host and start host
            listener = new TcpListener(IPAddress.Any, 80);
            listener.Start();

            // begin accepting clients to connect to server
            listener.BeginAcceptTcpClient(new AsyncCallback(OnConnect), null);
            Console.ReadKey();
        }

        private void OnConnect(IAsyncResult ar)
        {
            var newTcpClient = listener.EndAcceptTcpClient(ar);
            Console.WriteLine("New client connected");
            clients.Add(new Client(newTcpClient, this));

            listener.BeginAcceptTcpClient(new AsyncCallback(OnConnect), null);
        }

        public void addPatientData(Patient p, String data)
        {
            foreach(var item in patientData)
            {
                if (item.Key.Equals(p))
                {
                   if ( item.Value.Last().Length < 28 )
                    {
                        item.Value.Last().Append(data);
                    }
                    else
                    {
                        String[] tempData = new String[28];
                        tempData[0] = data;
                        item.Value.Add(tempData);
                    }
                }
                else
                {
                    String[] tempData = new String[28];
                    List<String[]> dataList = new List<string[]>();
                    patientData.Add(p, dataList);
                }
            }
        }
    }
}
