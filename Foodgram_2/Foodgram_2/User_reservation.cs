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

namespace Foodgram_2
{
    public partial class User_reservation : Form
    {
        public string uname,_phone,Nname;
        public User_reservation()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5QGE0VB\SQLEXPRESS;Initial Catalog=Foodgram;Integrated Security=True");

        public User_reservation(string uname)
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Phone_No From Customers WHERE Username ='" + uname + "'", con);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                _phone = da.GetValue(0).ToString();
            }
            con.Close();
            label6.Text = _phone;
            LoadData();
            button3.BackColor = Color.FromArgb(240, 240, 240);

            button2.BackColor = Color.FromArgb(158, 158, 158);
            panel1.BackColor = Color.FromArgb(158, 158, 158);
        }
        private void LoadData()
        {
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Tables_Manage", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.Rows.Clear();
            foreach (DataRow row in dtbl.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["table_no"].Value = row["Table_No"].ToString();
                dataGridView1.Rows[n].Cells["table_quantity"].Value = row["Table_Quantity"].ToString();
                dataGridView1.Rows[n].Cells["table_status"].Value = row["Table_Status"].ToString();
                dataGridView1.Rows[n].Cells["name"].Value = row["Name"].ToString();
                dataGridView1.Rows[n].Cells["phone"].Value = row["Phone_No"].ToString();

            }

            con.Close();
            
        }
        private void LoadData1()
        {
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Tables_Manage where Phone_No = '"+label6.Text+"'", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.Rows.Clear();
            foreach (DataRow row in dtbl.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["table_no"].Value = row["Table_No"].ToString();
                dataGridView1.Rows[n].Cells["table_quantity"].Value = row["Table_Quantity"].ToString();
                dataGridView1.Rows[n].Cells["table_status"].Value = row["Table_Status"].ToString();
                dataGridView1.Rows[n].Cells["name"].Value = row["Name"].ToString();
                dataGridView1.Rows[n].Cells["phone"].Value = row["Phone_No"].ToString();

            }

            con.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label4.Text == "Unbooked")
            {
             
                    SqlCommand cmd = new SqlCommand("UPDATE Tables_Manage set Table_Status = @status, Phone_No = @phone , Name=(SELECT Name FROM Customers Where Phone_No = @phone) where Table_No = @table", con);

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@status", "Booked");
                    cmd.Parameters.AddWithValue("@phone", label6.Text);
                    cmd.Parameters.AddWithValue("@table", label2.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Booked Successfully", "Booked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
             

            }
            else
            {
                MessageBox.Show("Already Booked", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearData();
            }
            LoadData();
        }
        private void ClearData()
        {
            label2.Text = "";
            label4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(240, 240, 240);

            button2.BackColor = Color.FromArgb(158, 158, 158);
            panel1.BackColor = Color.FromArgb(158, 158, 158);

            LoadData();
            label1.Visible = true;
            
            label3.Visible = true;
            

            button1.Visible = true;
            button1.Enabled = true;
        }

        private void User_reservation_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select Contact From Admins Where Name=@Username", con);
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.AddWithValue("@Username", "admin");
            label7.Text = (string)cmd1.ExecuteScalar();
            con.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells["table_no"].Value.ToString();
            label4.Text = dataGridView1.SelectedRows[0].Cells["table_status"].Value.ToString();

            label2.Visible = true;
            label4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(240, 240, 240);

            button3.BackColor = Color.FromArgb(158, 158, 158);
            panel1.BackColor = Color.FromArgb(158, 158, 158);
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            button1.Visible = false;
            button1.Enabled = false;

            LoadData1();
        }
    }
}
