namespace Client
{
    partial class ClientRunTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectBike = new System.Windows.Forms.ComboBox();
            this.ConnectBttn = new System.Windows.Forms.Button();
            this.connectStateLabel = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ChatLogListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.StartBttn = new System.Windows.Forms.Button();
            this.resistanceChart = new LiveCharts.WinForms.SolidGauge();
            this.label2 = new System.Windows.Forms.Label();
            this.dataChart = new LiveCharts.WinForms.CartesianChart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WarmingUpTimer = new System.Windows.Forms.Label();
            this.TestTimer = new System.Windows.Forms.Label();
            this.CoolingDownTimer = new System.Windows.Forms.Label();
            this.DoneMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectBike
            // 
            this.selectBike.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBike.FormattingEnabled = true;
            this.selectBike.Location = new System.Drawing.Point(11, 14);
            this.selectBike.Margin = new System.Windows.Forms.Padding(2);
            this.selectBike.Name = "selectBike";
            this.selectBike.Size = new System.Drawing.Size(176, 24);
            this.selectBike.TabIndex = 7;
            this.selectBike.Text = "Selecteer een fiets";
            // 
            // ConnectBttn
            // 
            this.ConnectBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConnectBttn.Location = new System.Drawing.Point(205, 15);
            this.ConnectBttn.Name = "ConnectBttn";
            this.ConnectBttn.Size = new System.Drawing.Size(85, 23);
            this.ConnectBttn.TabIndex = 8;
            this.ConnectBttn.Text = "Verbinden";
            this.ConnectBttn.UseVisualStyleBackColor = true;
            this.ConnectBttn.Click += new System.EventHandler(this.ConnectBttn_Click);
            // 
            // connectStateLabel
            // 
            this.connectStateLabel.AutoSize = true;
            this.connectStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectStateLabel.ForeColor = System.Drawing.Color.Red;
            this.connectStateLabel.Location = new System.Drawing.Point(296, 14);
            this.connectStateLabel.Name = "connectStateLabel";
            this.connectStateLabel.Size = new System.Drawing.Size(0, 16);
            this.connectStateLabel.TabIndex = 9;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1252, 55);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // ChatLogListView
            // 
            this.ChatLogListView.GridLines = true;
            this.ChatLogListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ChatLogListView.HideSelection = false;
            this.ChatLogListView.Location = new System.Drawing.Point(1039, 61);
            this.ChatLogListView.MultiSelect = false;
            this.ChatLogListView.Name = "ChatLogListView";
            this.ChatLogListView.Size = new System.Drawing.Size(206, 610);
            this.ChatLogListView.TabIndex = 11;
            this.ChatLogListView.UseCompatibleStateImageBehavior = false;
            this.ChatLogListView.View = System.Windows.Forms.View.Tile;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Als de patient op de fiets zit kunt u  de test starten.";
            // 
            // StartBttn
            // 
            this.StartBttn.BackColor = System.Drawing.Color.YellowGreen;
            this.StartBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBttn.Location = new System.Drawing.Point(394, 68);
            this.StartBttn.Name = "StartBttn";
            this.StartBttn.Size = new System.Drawing.Size(103, 26);
            this.StartBttn.TabIndex = 13;
            this.StartBttn.Text = "Start";
            this.StartBttn.UseVisualStyleBackColor = false;
            this.StartBttn.Click += new System.EventHandler(this.StartBttn_Click);
            // 
            // resistanceChart
            // 
            this.resistanceChart.Location = new System.Drawing.Point(32, 447);
            this.resistanceChart.Name = "resistanceChart";
            this.resistanceChart.Size = new System.Drawing.Size(179, 145);
            this.resistanceChart.TabIndex = 18;
            this.resistanceChart.Text = "solidGauge1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 585);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Weerstand ";
            // 
            // dataChart
            // 
            this.dataChart.Location = new System.Drawing.Point(262, 169);
            this.dataChart.Name = "dataChart";
            this.dataChart.Size = new System.Drawing.Size(758, 436);
            this.dataChart.TabIndex = 20;
            this.dataChart.Text = "cartesianChart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Warming up";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Astrand Test";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Cooling down";
            // 
            // WarmingUpTimer
            // 
            this.WarmingUpTimer.AutoSize = true;
            this.WarmingUpTimer.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarmingUpTimer.Location = new System.Drawing.Point(140, 160);
            this.WarmingUpTimer.Name = "WarmingUpTimer";
            this.WarmingUpTimer.Size = new System.Drawing.Size(71, 19);
            this.WarmingUpTimer.TabIndex = 24;
            this.WarmingUpTimer.Text = "02:00 min";
            // 
            // TestTimer
            // 
            this.TestTimer.AutoSize = true;
            this.TestTimer.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestTimer.Location = new System.Drawing.Point(140, 207);
            this.TestTimer.Name = "TestTimer";
            this.TestTimer.Size = new System.Drawing.Size(71, 19);
            this.TestTimer.TabIndex = 25;
            this.TestTimer.Text = "04:00 min";
            // 
            // CoolingDownTimer
            // 
            this.CoolingDownTimer.AutoSize = true;
            this.CoolingDownTimer.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoolingDownTimer.Location = new System.Drawing.Point(140, 257);
            this.CoolingDownTimer.Name = "CoolingDownTimer";
            this.CoolingDownTimer.Size = new System.Drawing.Size(71, 19);
            this.CoolingDownTimer.TabIndex = 26;
            this.CoolingDownTimer.Text = "01:00 min";
            // 
            // DoneMessageLabel
            // 
            this.DoneMessageLabel.AutoSize = true;
            this.DoneMessageLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneMessageLabel.Location = new System.Drawing.Point(16, 302);
            this.DoneMessageLabel.Name = "DoneMessageLabel";
            this.DoneMessageLabel.Size = new System.Drawing.Size(170, 22);
            this.DoneMessageLabel.TabIndex = 27;
            this.DoneMessageLabel.Text = "De test is afgerond.";
            this.DoneMessageLabel.Visible = false;
            // 
            // ClientRunTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1252, 673);
            this.Controls.Add(this.DoneMessageLabel);
            this.Controls.Add(this.CoolingDownTimer);
            this.Controls.Add(this.TestTimer);
            this.Controls.Add(this.WarmingUpTimer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataChart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resistanceChart);
            this.Controls.Add(this.StartBttn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChatLogListView);
            this.Controls.Add(this.connectStateLabel);
            this.Controls.Add(this.ConnectBttn);
            this.Controls.Add(this.selectBike);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ClientRunTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientRunTest";
            this.Load += new System.EventHandler(this.ClientRunTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectBike;
        private System.Windows.Forms.Button ConnectBttn;
        private System.Windows.Forms.Label connectStateLabel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListView ChatLogListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartBttn;
        private LiveCharts.WinForms.SolidGauge resistanceChart;
        private System.Windows.Forms.Label label2;
        private LiveCharts.WinForms.CartesianChart dataChart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label WarmingUpTimer;
        private System.Windows.Forms.Label TestTimer;
        private System.Windows.Forms.Label CoolingDownTimer;
        private System.Windows.Forms.Label DoneMessageLabel;
    }
}