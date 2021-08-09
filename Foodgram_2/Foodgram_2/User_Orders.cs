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
    public partial class User_Orders : Form
    {
        bool on = true;
        public string uname;
        public User_Orders()
        {
            InitializeComponent();
            
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5QGE0VB\SQLEXPRESS;Initial Catalog=Foodgram;Integrated Security=True");

        private void LoadData()
        {
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Orders WHERE Phone_No = (SELECT Phone_No FROM Customers WHERE Username = '" + uname + "' )", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.Rows.Clear();

            foreach (DataRow row in dtbl.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["Orders_order_id"].Value = row["order_id"].ToString();
                dataGridView1.Rows[n].Cells["Orders_item_name"].Value = row["item_name"].ToString();
                dataGridView1.Rows[n].Cells["Orders_item_quantity"].Value = row["item_quantity"].ToString();
                dataGridView1.Rows[n].Cells["Orders_time"].Value = row["time_hour"].ToString();
                dataGridView1.Rows[n].Cells["Orders_table_no"].Value = row["Table_No"].ToString();
                dataGridView1.Rows[n].Cells["Orders_phone"].Value = row["Phone_No"].ToString();
                dataGridView1.Rows[n].Cells["Orders_price"].Value = row["item_price"].ToString();

                

            }
            con.Close();

        }
        private void LoadData1()
        {
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Income WHERE Phone_No = (SELECT Phone_No FROM Customers WHERE Username = '" + uname + "' )", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.Rows.Clear();

            foreach (DataRow row in dtbl.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["Orders_order_id"].Value = row["order_id"].ToString();
                dataGridView1.Rows[n].Cells["Orders_item_name"].Value = row["item_name"].ToString();
                dataGridView1.Rows[n].Cells["Orders_item_quantity"].Value = row["item_quantity"].ToString();
                dataGridView1.Rows[n].Cells["Orders_time"].Value = row["time_date"].ToString();
                dataGridView1.Rows[n].Cells["Orders_table_no"].Value = row["Table_No"].ToString();
                dataGridView1.Rows[n].Cells["Orders_phone"].Value = row["Phone_No"].ToString();
                dataGridView1.Rows[n].Cells["Orders_price"].Value = row["item_price"].ToString();
                dataGridView1.Sort(dataGridView1.Columns[4],ListSortDirection.Descending);


            }
            con.Close();

        }



        public User_Orders(string username)
        {
            InitializeComponent();
            uname = username;
            loadpendingorder();


        }
        private void loadpendingorder()
        {
            if(on)
            {
                button1.BackColor = Color.FromArgb(240, 240, 240);
            
                button2.BackColor = Color.FromArgb(158,158,158);
                panel1.BackColor = Color.FromArgb(158,158,158);
                LoadData();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadpendingorder();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(240, 240, 240);

            button1.BackColor = Color.FromArgb(158, 158, 158);
            panel1.BackColor = Color.FromArgb(158, 158, 158);
            LoadData1();
        }

        
    }
}
