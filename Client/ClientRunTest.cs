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
        private List<string> bleRMPList;

        private TcpClient client;

        private Patient patient;

        Timer timer = new Timer();

        private static NetworkStream stream;
        private static byte[] buffer = new byte[1024];
        static string totalBuffer = "";
        private ChartValues<ObservableValue> Hearthrate;
        private ChartValues<ObservableValue> RPM;

        public ClientRunTest(Patient patient)
        {
            this.patient = patient;
            this.Hearthrate = new ChartValues<ObservableValue>();
            this.RPM = new ChartValues<ObservableValue>();
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
                Title = "Beats per minute"
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
                    Values = RPM,              
                    PointGeometrySize = 10
                },
                new LineSeries
                {
                    Values = Hearthrate,
                    PointGeometrySize = 10
                },

            };
        }

        private async void getData()
        {
            await bleBikeHandler.DataAsync();
            //bleBikeList.Add(bleBikeHandler.bikeData);
            if (bleBikeHandler.bikeDataRPM != null)
            {
                if (bleRMPList == null) bleRMPList = new List<String>();
                bleRMPList.Add(bleBikeHandler.bikeDataRPM);
            }
            if (bleHeartHandler.heartData != null)
            {
                if (bleHeartList == null) bleHeartList = new List<String>();
                bleHeartList.Add(bleHeartHandler.heartData);
            }
            resistanceChart.Value = bleBikeHandler.percent;
            //resistanceChart.Value = random.Next(0, 100);
            //Send($"Test/BikeData\r\n{bleBikeHandler.bikeData}\r\n\r\n");
            //Send($"Test/BikeDataRPM\r\n{bleBikeHandler.bikeDataRPM}\r\n\r\n");
            //ChatLogListView.Items.Add($"{bleBikeHandler.bikeData}");
            //ChatLogListView.Items.Add($"{bleBikeHandler.bikeDataRPM}");

        }

        private void ConnectServer()
        {
            client = new TcpClient();
            client.Connect("localhost", 80);
            stream = client.GetStream();
            stream.BeginRead(buffer, 0, buffer.Length, new AsyncCallback(OnRead), null);
            Send($"Test/login\r\n{this.patient.name}\r\n{this.patient.age}\r\n{this.patient.weight}\r\n{this.patient.gender}\r\n\r\n");
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
            this.bleHeartHandler.InitBleHeart();
        }

        private async void ConnectBttn_Click(object sender, EventArgs e)
        {
            if (selectBike.SelectedItem != null)
            {
                try { bleHeartHandler.Connect("Decathlon Dual HR", "Heartrate"); } catch (Exception f) { }
                bleBikeHandler.Connect(selectBike.SelectedItem.ToString(), "6e40fec1-b5a3-f393-e0a9-e50e24dcca9e");
                await bleHeartHandler.DataAsync();
                await bleBikeHandler.DataAsync();
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
                    ChatLogListView.Items.Add("Astrand test starting...");
                    int timeleft1 = 120 - time;
                    string totaltimeleft = TimeSpan.FromSeconds(timeleft1).ToString(@"mm\:ss");
                    WarmingUpTimer.Text = $"{totaltimeleft} min";
                    bleBikeHandler.ChangeResistance(30);

                    break;
                case 1:
                    WarmingUpTimer.Text = "00:00 min";
                    
                    int timeleft2 = 360 - time;
                    string totaltimeleft2 = TimeSpan.FromSeconds(timeleft2).ToString(@"mm\:ss");
                    TestTimer.Text = $"{totaltimeleft2} min";

                    if (Convert.ToDouble(bleHeartHandler.heartData) > 140)
                    {
                        bleBikeHandler.ChangeResistance(40);
                    }
                    else if (Convert.ToDouble(bleHeartHandler.heartData) < 110)
                    {
                        bleBikeHandler.ChangeResistance(60);
                    }
                    else
                    {
                        bleBikeHandler.ChangeResistance(50);
                    }

                    break;
                case 2:
                    TestTimer.Text = "00:00 min";
                    int timeleft3 = 420 - time;
                    string totaltimeleft3 = TimeSpan.FromSeconds(timeleft3).ToString(@"mm\:ss");
                    CoolingDownTimer.Text = $"{totaltimeleft3} min";

                    bleBikeHandler.ChangeResistance(20);
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

       
       

        private async void getData()
        {
            await bleBikeHandler.DataAsync();
            //bleBikeList.Add(bleBikeHandler.bikeData);
            bleBikeList.Add(bleBikeHandler.bikeDataRPM);
            if (bleHeartHandler.heartData != null)
            {
                bleHeartList.Add(bleHeartHandler.heartData);
                if (time % 15 == 0)
                {
                    String addedData = $"{bleBikeHandler.bikeData}-{bleBikeHandler.bikeDataRPM}-{bleHeartHandler.heartData}";

                    Send($"Test/BikeData\r\n{this.patient.name}\r\n{this.patient.age}\r\n{this.patient.weight}\r\n{this.patient.gender}\r\n{addedData}\r\n\r\n");
                    
                }

            }
            resistanceChart.Value = bleBikeHandler.percent;
            //resistanceChart.Value = random.Next(0, 100);
            //Send($"Test/BikeData\r\n{bleBikeHandler.bikeData}\r\n\r\n");
            //Send($"Test/BikeDataRPM\r\n{bleBikeHandler.bikeDataRPM}\r\n\r\n");
            //ChatLogListView.Items.Add($"{bleBikeHandler.bikeData}");
            ChatLogListView.Items.Add($"{bleBikeHandler.bikeDataRPM}");

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
            Hearthrate.Add(new ObservableValue(Convert.ToDouble(bleHeartHandler.heartData)));
            RPM.Add(new ObservableValue(Convert.ToDouble(bleBikeHandler.bikeDataRPM)));
        }

        private void resistanceChart_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {
                     
        }

        private double calculateVo2(double workload, double HRss, Patient patient)
        {
            double VO2max = 0;
            if (patient.gender.Equals("Vrouw"))
            {
                VO2max = (0.00193 * workload + 0.326) / (0.769 * HRss - 56.1) * 100;
            }
            else
            {
                VO2max = (0.00212 * workload + 0.299) / (0.769 * HRss - 48.5) * 100;
            }

            if (patient.age >= 30)
            {
                if (patient.age < 35)
                {
                    VO2max *= 1;
                }
                else if (patient.age < 40)
                {
                    VO2max *= 0.87;
                }
                else if (patient.age < 45)
                {
                    VO2max *= 0.83;
                }
                else if (patient.age < 50)
                {
                    VO2max *= 0.78;
                }
                else if (patient.age < 55)
                {
                    VO2max *= 0.75;
                }
                else if (patient.age < 60)
                {
                    VO2max *= 0.71;
                }
                else if (patient.age < 65)
                {
                    VO2max *= 0.68;
                }
                else
                {
                    VO2max *= 0.65;
                }
            }
             
            if (patient.maxheartbeat > 0)
            {
                if (patient.maxheartbeat >= 210)
                {
                    VO2max *= 1.12;
                }
                else if (patient.maxheartbeat >= 200)
                {
                    VO2max *= 1;
                }
                else if (patient.maxheartbeat >= 190)
                {
                    VO2max *= 0.93;
                }
                else if (patient.maxheartbeat >= 180)
                {
                    VO2max *= 0.83;
                }
                else if (patient.maxheartbeat >= 170)
                {
                    VO2max *= 0.75;
                }
                else if (patient.maxheartbeat >= 160)
                {
                    VO2max *= 0.69;
                }
                else if (patient.maxheartbeat >= 150)
                {
                    VO2max *= 10.64;
                }
                else
                {
                    return VO2max;
                }
            }
            return VO2max;
        }
    }
}
