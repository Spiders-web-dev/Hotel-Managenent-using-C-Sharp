using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelManagement
{
    public partial class RoomInfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Spider's Web\Documents\Visual Studio 2013\Projects\HotelManagement\HotelManagement\DATABASE FOLDER\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");

        public void populate()
        {
            Con.Open();
            String Myquery = "select * from Room_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RoomGridview.DataSource = ds.Tables[0];
            Con.Close();
        }


        public RoomInfo()
        {
            InitializeComponent();
        }

        private void gunaRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddRoomBtn_Click(object sender, EventArgs e)
        {
            string isfree;
            if (Yesradio.Checked == true)
                isfree = "Free";
            else
                isfree = "Busy";

            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Room_tbl values(" + Roomnumtb.Text + ",'" + Roomphonetb.Text + "','" + isfree + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room Successfully Added");
            Con.Close();
            populate();
        }

        private void RoomInfo_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            populate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void RoomGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
    

            Roomnumtb.Text = RoomGridview.SelectedRows[0].Cells[0].Value.ToString();
            Roomphonetb.Text = RoomGridview.SelectedRows[0].Cells[1].Value.ToString();
            
        }

        private void StaffDeleteBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            String query = "delete from Room_tbl where RoomId= " + Roomnumtb.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room Successfully Deletaed");
            Con.Close();
            populate();
        }

       private void StaffEditBtn_Click(object sender, EventArgs e)
        {
            string isfree;
            if (Yesradio.Checked == true)
                isfree = "Free";
            else
                isfree = "Busy";

           Con.Open();
            String myquery = "UPDATE Room_tbl set RoomPhone = '" + Roomphonetb.Text + "' , RoomFree= '" + isfree + "' where RoomId =" + Roomnumtb.Text + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room Successfully Edited");
            Con.Close();
            populate(); 
        }

       private void button4_Click(object sender, EventArgs e)
       {
           Con.Open();
           String Myquery = "select * from Room_tbl where RoomId = '" + RoomSearch.Text + "'";
           SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
           SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
           var ds = new DataSet();
           da.Fill(ds);
           RoomGridview.DataSource = ds.Tables[0];
           Con.Close();
       }

       private void pictureBox2_Click(object sender, EventArgs e)
       {
           populate();
       }

       private void button1_Click(object sender, EventArgs e)
       {
           MainForm mform = new MainForm();
           mform.Show();
           this.Hide();
       }
    }
}
