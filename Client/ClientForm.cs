using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientForm : Form
    {
        private int timer;

        public ClientForm()
        {
            InitializeComponent();
            SetDefaultValues();

            this.timer = new int();
        }

        private void SetDefaultValues()
        {
            lblClientMessage.Text = "De deskundige is de test aan het starten";
        }

        public void ChangeClientMessage()
        {
            if (timer == 0)
            {
                lblClientMessage.Text = "U mag beginnen met fietsen, er is een 2 min lange warmup";
            }
            if (timer == 120)
            {
                lblClientMessage.Text = "Nu begint de test, deze test duurt 4 min" + "\r\n" + "probeer 60 omwentellingen per mininuut aan te houden";
            }
            if (timer == 360)
            {
                lblClientMessage.Text = "De test is afgelopen, nu is er een cooling down, deze duurt 1 min";
            }
        }
    }
}
