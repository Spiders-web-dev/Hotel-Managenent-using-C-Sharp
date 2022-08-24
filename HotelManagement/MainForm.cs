using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaImageButton5_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            ClientInfo clinfo = new ClientInfo();
            clinfo.Show();
            this.Hide();
        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            StaffInfo stinfo = new StaffInfo();
            stinfo.Show();
            this.Hide();
        }

        private void gunaImageButton3_Click(object sender, EventArgs e)
        {
            RoomInfo rinfo = new RoomInfo();
            rinfo.Show();
            this.Hide();
        }

        private void gunaImageButton4_Click(object sender, EventArgs e)
        {
            Reservation resinfo = new Reservation();
            resinfo.Show();
            this.Hide();
        }

        
       
    }
}
