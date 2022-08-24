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
    public partial class StaffInfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Spider's Web\Documents\Visual Studio 2013\Projects\HotelManagement\HotelManagement\DATABASE FOLDER\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");

        public void populate()
        {
            Con.Open();
            String Myquery = "select * from Staff_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            StaffGridview.DataSource = ds.Tables[0];
            Con.Close();
        }
        public StaffInfo()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Staff_tbl values(" + Staffidtb.Text + ",'" + Staffnametb.Text + "','" + Staffphonetb.Text + "','" + Staffgendercb.Text + "','" + passwordtb.Text + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff Successfully Added");
            Con.Close();
            populate();
        }

        private void StaffGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Staffidtb.Text = StaffGridview.SelectedRows[0].Cells[0].Value.ToString();
            Staffnametb.Text = StaffGridview.SelectedRows[0].Cells[1].Value.ToString();
            Staffphonetb.Text = StaffGridview.SelectedRows[0].Cells[2].Value.ToString();
            Staffgendercb.Text = StaffGridview.SelectedRows[0].Cells[3].Value.ToString();
            passwordtb.Text = StaffGridview.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void StaffInfo_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            populate();
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }


        private void StaffEditBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            String myquery = "UPDATE Staff_tbl set StaffName = '" + Staffnametb.Text + "' , StaffPhone= '" + Staffphonetb.Text + "', Gender= '" + Staffgendercb.Text + "' , StaffPassword = '"+ passwordtb.Text+"'   where StaffId =" + Staffidtb.Text + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff Successfully Edited");
            Con.Close();
            populate();
        }

        private void StaffDeleteBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            String query = "delete from Staff_tbl where StaffId= " + Staffidtb.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff Successfully Deletaed");
            Con.Close();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            String Myquery = "select * from Staff_tbl where StaffName = '" + StaffSearch.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            StaffGridview.DataSource = ds.Tables[0];
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
