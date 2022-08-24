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
    public partial class ClientInfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Spider's Web\Documents\Visual Studio 2013\Projects\HotelManagement\HotelManagement\DATABASE FOLDER\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            String Myquery = "select * from Client_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ClientGridview.DataSource = ds.Tables[0];
            Con.Close();
        }
        public ClientInfo()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void ClientInfo_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Client_tbl values("+clientidtb.Text+",'"+clientnametb.Text+"','"+clientphonetb.Text+"','"+clientctrycb.Text+"')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Added");
            Con.Close();
            populate();
        }

        private void ClientGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clientidtb.Text = ClientGridview.SelectedRows[0].Cells[0].Value.ToString();
            clientnametb.Text = ClientGridview.SelectedRows[0].Cells[1].Value.ToString();
            clientphonetb.Text = ClientGridview.SelectedRows[0].Cells[2].Value.ToString();
            clientctrycb.Text = ClientGridview.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            String myquery = "UPDATE Client_tbl set ClientName = '" + clientnametb.Text +"' , ClientPhone= '"+clientphonetb.Text+"', ClientCountry= '"+clientctrycb.Text+"' where ClientId ="+clientidtb.Text+";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Edited");
            Con.Close();
            populate();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            String query = "delete from Client_tbl where ClientId= "+clientidtb.Text+"";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Deletaed");
            Con.Close();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Con.Open();
            String Myquery = "select * from Client_tbl where ClientName = '"+ClientSearch.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ClientGridview.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MainForm mform = new MainForm();
            mform.Show();
            this.Hide();
        }

       
      
    }
}
