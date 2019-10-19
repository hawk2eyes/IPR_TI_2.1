using Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor
{
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();
        }

        public void DoctorForm_Load(object sender, EventArgs e)
        {
            cmbbGender.SelectedIndex = 0;
        }

        private void BtnStartTest_Click(object sender, EventArgs e)
        {
            if (tbAge.Text == "" || tbWeight.Text == "" || tbName.Text == "" || cmbbGender.Text == "")
            {
                lblWrongData.Visible = true;
            }
            else
            {
                ClientForm client = new ClientForm();
                client.Show();
            }
        }
    }
}
