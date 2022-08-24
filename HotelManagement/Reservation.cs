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
    public partial class Reservation : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Spider's Web\Documents\Visual Studio 2013\Projects\HotelManagement\HotelManagement\DATABASE FOLDER\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");
                                               

        public void populate()
        {
            Con.Open();
            String Myquery = "select * from Reservation_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReservationGridview.DataSource = ds.Tables[0];
            Con.Close();
        }
        public Reservation()
        {
            InitializeComponent();
        }

        private void Roomphonetb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Roomnumtb_OnValueChanged(object sender, EventArgs e)
        {

        }
        DateTime today;

        public void fillRoomcombo()
        {
            
            Con.Open();
            string roomstate = "Free";
            SqlCommand cmd = new SqlCommand("select RoomId from Room_tbl where RoomFree= '"+roomstate+"'",Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RoomId", typeof(int));
            dt.Load(rdr);
            Roomcb.ValueMember = "RoomId";
            Roomcb.DataSource = dt;
            Con.Close();
        }

        public void fillClientcombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select ClientName from Client_tbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ClientName", typeof(string));
            dt.Load(rdr);
            Clientcb.ValueMember = "ClientName";
            Clientcb.DataSource = dt;
            Con.Close();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            today = Datein.Value;
            fillRoomcombo();
            fillClientcombo();
            populate();
        }

        private void Datein_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(Datein.Value, today);
            if (res < 0)
                MessageBox.Show("Wrong Date For Reservation");
        }

        private void Dateout_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(Dateout.Value,Datein.Value);
            if (res < 0)
                MessageBox.Show("Wrong Dateout.Check Once More");
        }

        public  void updateroomstate()
        {

           Con.Open();
            string newstate = "Busy";
            String myquery = "UPDATE Room_tbl set RoomFree = '" + newstate  + "' where RoomId =" + Convert.ToInt32 (Roomcb.SelectedValue.ToString()) + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
           // MessageBox.Show("Reservation Successfully Edited");
            Con.Close();
            fillRoomcombo();
           
        }



        public void updateroomstateondelete()
        {

            Con.Open();
            string newstate = "free";
            int roomid = Convert.ToInt32(ReservationGridview.SelectedRows[0].Cells[2].Value.ToString());
            String myquery = "UPDATE Room_tbl set RoomFree = '" + newstate + "' where RoomId =" + roomid + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            // MessageBox.Show("Reservation Successfully Edited");
            Con.Close();
            fillRoomcombo();

        }

        private void AddRoomBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Reservation_tbl values(" + ReserIdtb.Text + ",'" + Clientcb.SelectedValue.ToString() + "','" + Roomcb.SelectedValue.ToString() + "','" + Datein.Value + "','" + Dateout.Text + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Reservation Successfully Added");
            Con.Close();
            updateroomstate();
            populate();
        }

        private void ReservationGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ReserIdtb.Text = ReservationGridview.SelectedRows[0].Cells[0].Value.ToString();


        }

        private void ReservationDeleteBtn_Click(object sender, EventArgs e)
        {
            if (ReserIdtb.Text == "")
            {

                MessageBox.Show("Enter the Reservation to be Deleted");

            }
            else
            {


                Con.Open();
                String query = "delete from Reservation_tbl where ResId= " + ReserIdtb.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation Successfully Deletaed");
                Con.Close();
                updateroomstateondelete();
                populate();
            }
        }

        private void ReservationEditBtn_Click(object sender, EventArgs e)
        {
            if (ReserIdtb.Text == "")
            {

                MessageBox.Show("Empty ResId, Enter the Reservation");

            }
            else
            {
                Con.Open();
                String myquery = "UPDATE Reservation_tbl set Client = '" + Clientcb.SelectedValue.ToString() + "' , Room= '" + Roomcb.SelectedValue.ToString() + "', DateIn= '" + Datein.Value.ToString() + "' , DateOut = '" + Dateout.Value.ToString() + "'   where ResId =" + ReserIdtb.Text + ";";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation Successfully Edited");
                Con.Close();
                updateroomstate();
                updateroomstateondelete();
                populate();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            String Myquery = "select * from Reservation_tbl where ResId = '" + Reservationsearch.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReservationGridview.DataSource = ds.Tables[0];
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
