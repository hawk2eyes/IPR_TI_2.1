using Avans.TI.BLE;
using ClientGUI.Bluetooth;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientRunTest : Form
    {
        private int time = 0;
        private int state = 0;
        private bool running = false;

        Random random = new Random();

        public BleBikeHandler bleBikeHandler;
        public BleHeartHandler bleHeartHandler;

        private List<string> bleBikeList;
        private List<string> bleHeartList;

        private TcpClient client;

        private Patient patient;

        Timer timer = new Timer();

        private static NetworkStream stream;
        private static byte[] buffer = new byte[1024];
        static string totalBuffer = "";

        public ClientRunTest(Patient patient)
        {
            this.patient = patient;
            InitializeComponent();
            ConnectServer();
            InitializeDeclarations();
            LoadBikes();
        }


        private void ClientRunTest_Load(object sender, EventArgs e)
        {
            resistanceChart.To = 100;
            StartBttn.Enabled = false;

            dataChart.AxisY.Add(new Axis
            {
                Foreground = System.Windows.Media.Brushes.Red,
                Title = "BPM"
            });

            dataChart.AxisY.Add(new Axis
            {
                Foreground = System.Windows.Media.Brushes.DodgerBlue,
                Title = "Rotations per minute",
                Position = AxisPosition.RightTop
            });

            dataChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,10),      
                        new ObservablePoint(4,7),      
                        new ObservablePoint(5,3),     
                        new ObservablePoint(7,6),
                        new ObservablePoint(10,8)
                    },
                    PointGeometrySize = 25
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,2),      
                        new ObservablePoint(2,5),     
                        new ObservablePoint(3,6),    
                        new ObservablePoint(6,8),
                        new ObservablePoint(10,5)
                    },
                    PointGeometrySize = 15
                },

            };
        }

        private async void getData()
        {
            await bleBikeHandler.DataAsync();
            bleBikeList.Add(bleBikeHandler.bikeData);
            //bleHeartList.Add(bleHeartHandler.heartData);
            //resistanceChart.Value = bleBikeHandler.percent;
            resistanceChart.Value = random.Next(0, 100);
            Send($"Test/BikeData\r\n{bleBikeHandler.bikeData}\r\n\r\n");
            ChatLogListView.Items.Add($"{bleBikeHandler.bikeData}");


        }

        private void ConnectServer()
        {
            client = new TcpClient();
            client.Connect("localhost", 80);

            stream = client.GetStream();
            stream.BeginRead(buffer, 0, buffer.Length, new AsyncCallback(OnRead), null);
            Send($"Test/login\r\n{this.patient.name}\r\n\r\n");

        }

        private static void Send(string v)
        {
            stream.Write(System.Text.Encoding.ASCII.GetBytes(v), 0, v.Length);
            stream.Flush();
        }

        private void OnRead(IAsyncResult ar)
        {
            //message received
            Console.WriteLine($"client: {patient.name} got data");
            int receivedBytes = stream.EndRead(ar);
            totalBuffer += System.Text.Encoding.ASCII.GetString(buffer, 0, receivedBytes);

            // from bytes to string
            while (totalBuffer.Contains("\r\n\r\n"))
            {
                string packet = totalBuffer.Substring(0, totalBuffer.IndexOf("\r\n\r\n"));
                totalBuffer = totalBuffer.Substring(totalBuffer.IndexOf("\r\n\r\n") + 4);

                string[] data = Regex.Split(packet, "\r\n");

                HandlePacket(data);
            }

            // begin waiting for next 
            stream.BeginRead(buffer, 0, buffer.Length, new AsyncCallback(OnRead), null);
        }

        private static void HandlePacket(string[] data)
        {
            switch (data[0])
            {
                default:
                    Console.WriteLine("Unknown package");
                    break;
            }

        }

        private async void LoadBikes()
        {
            this.bleBikeList = await this.bleBikeHandler.RetrieveBleBikes("Tacx");
            this.bleBikeList.ForEach(x => selectBike.Items.Add(x));
        }

        private void InitializeDeclarations()
        {
            this.bleBikeHandler = new BleBikeHandler();
            this.bleHeartHandler = new BleHeartHandler();


        }

        private void ConnectBttn_Click(object sender, EventArgs e)
        {
            if (selectBike.SelectedItem != null)
            {
                //bleHeartHandler.Connect("Decathlon Dual HR", "Heartrate");
                bleBikeHandler.Connect(selectBike.SelectedItem.ToString(), "6e40fec1-b5a3-f393-e0a9-e50e24dcca9e"); 
                
                ConnectBttn.Enabled = false;
                selectBike.Enabled = false;
                connectStateLabel.Text = "Verbonden!";
                connectStateLabel.ForeColor = Color.Green;
                splitter1.BackColor = SystemColors.ControlLight;
                connectStateLabel.BackColor = SystemColors.ControlLight;

                StartBttn.Enabled = true;

                Send($"Test/Connected\r\n{selectBike.SelectedItem.ToString()}\r\n\r\n");

            }
            else
            {
                connectStateLabel.Text = "Selecteer een fiets!";

            }
        }

        private void UpdateTimers()
        {
            switch (state)
            {
                case 0:
                    int timeleft1 = 120 - time;
                    string totaltimeleft = TimeSpan.FromSeconds(timeleft1).ToString(@"mm\:ss");
                    WarmingUpTimer.Text = $"{totaltimeleft} min";
                    break;
                case 1:
                    WarmingUpTimer.Text = "00:00 min";
                    int timeleft2 = 360 - time;
                    string totaltimeleft2 = TimeSpan.FromSeconds(timeleft2).ToString(@"mm\:ss");
                    TestTimer.Text = $"{totaltimeleft2} min";

                    break;
                case 2:
                    TestTimer.Text = "00:00 min";
                    int timeleft3 = 420 - time;
                    string totaltimeleft3 = TimeSpan.FromSeconds(timeleft3).ToString(@"mm\:ss");
                    CoolingDownTimer.Text = $"{totaltimeleft3} min";
                    break;
            }
        }

        private void CheckFase()
        {
            int seconds = time;
            if (seconds < 120)
            {
                state = 0;

                getData();
            }
            if (seconds >= 120 && seconds < 360)
            {
                state = 1;
                
                getData();

            }
            if (seconds == 360)
            {
                state = 2;
            }
            if (seconds == 420)
            {
                running = false;
                timer.Stop();
                DoneMessageLabel.Visible = true;
                CoolingDownTimer.Text = "00:00 min";

            }

        }

        private void StartBttn_Click(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            ChatLogListView.Items.Add("Warming up...");
            running = true;
            StartBttn.Enabled = false;

        }

        void timer_Tick(object sender, EventArgs e)
        {
            time++;
            CheckFase();
            UpdateTimers();
        }

    }
}
