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

namespace Client
{
    public partial class ClientLogin : Form
    {
        private string gender = "";

        public ClientLogin()
        {
            InitializeComponent();
        }

        private void LoginBttn_Click(object sender, EventArgs e)
        {
            //TODO : check correct info
            if ( NameTextBox.Text != "Naam" && NameTextBox.Text != "" && gender != "")
            {
                ClientRunTest runTest = new ClientRunTest(new Patient(NameTextBox.Text,
                                                                    AgeBar.Value,
                                                                    WeightBar.Value,
                                                                    this.gender));
                runTest.Show();
                this.Hide();
            }
            else
            {
                ErrorMessageLabel.Visible = true;
            }
           
        }


        private void AgeBar_Scroll(object sender, EventArgs e)
        {
            AgeLabel.Text = AgeBar.Value.ToString();
        }
        private void WeightBar_Scroll(object sender, EventArgs e)
        {
            WeightLabel.Text = WeightBar.Value.ToString();
        }
        private void MaleBttn_Click(object sender, EventArgs e)
        {
            this.gender = "MALE";
        }
        private void FemaleBttn_Click(object sender, EventArgs e)
        {
            this.gender = "FEMALE";
        }
        private void NameTextBox_Enter(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "Naam")
            {
                NameTextBox.Text = "";

                NameTextBox.ForeColor = Color.Black;
            }
        }
        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "")
            {
                NameTextBox.Text = "Naam";

                NameTextBox.ForeColor = Color.Gray;
            }
        }
    }
}
