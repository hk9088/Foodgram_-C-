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
    public partial class Admin_Food_Orders : Form
    {
        bool x = true;
        public Admin_Food_Orders()
        {
            InitializeComponent();
            resoreders();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5QGE0VB\SQLEXPRESS;Initial Catalog=Foodgram;Integrated Security=True");
        private void LoadData()
        {
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT  * FROM Orders,Customers Where Orders.Phone_No=Customers.Phone_No AND order_address IS  NULL", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1_Menu.Rows.Clear();

            foreach (DataRow row in dtbl.Rows)
            {
                int n = dataGridView1_Menu.Rows.Add();
                dataGridView1_Menu.Rows[n].Cells["Orders_order_id"].Value = row["order_id"].ToString();      
                dataGridView1_Menu.Rows[n].Cells["Orders_item_name"].Value = row["item_name"].ToString();
                dataGridView1_Menu.Rows[n].Cells["Orders_item_quantity"].Value = row["item_quantity"].ToString();
                dataGridView1_Menu.Rows[n].Cells["Orders_Name"].Value = row["Name"].ToString();
                dataGridView1_Menu.Rows[n].Cells["Orders_time"].Value = row["time_hour"].ToString();
                dataGridView1_Menu.Rows[n].Cells["Orders_table_no"].Value = row["Table_No"].ToString();
                dataGridView1_Menu.Rows[n].Cells["Orders_phone"].Value = row["Phone_No"].ToString();

            }
            con.Close();
            dataGridView1_Menu.Columns[7].Visible = false;

        }
        private void LoadData1()
        {
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT  * FROM Orders,Customers Where Orders.Phone_No=Customers.Phone_No AND order_address IS NOT NULL", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1_Menu.Rows.Clear();

            foreach (DataRow row in dtbl.Rows)
            {
                int n = dataGridView1_Menu.Rows.Add();
                dataGridView1_Menu.Rows[n].Cells["Orders_order_id"].Value = row["order_id"].ToString();
                dataGridView1_Menu.Rows[n].Cells["Orders_item_name"].Value = row["item_name"].ToString();
                dataGridView1_Menu.Rows[n].Cells["Orders_item_quantity"].Value = row["item_quantity"].ToString();
                dataGridView1_Menu.Rows[n].Cells["Orders_Name"].Value = row["Name"].ToString();
                dataGridView1_Menu.Rows[n].Cells["Orders_time"].Value = row["time_hour"].ToString();
                dataGridView1_Menu.Rows[n].Cells["Orders_table_no"].Value = row["Table_No"].ToString();
                dataGridView1_Menu.Rows[n].Cells["Orders_phone"].Value = row["Phone_No"].ToString();
                dataGridView1_Menu.Rows[n].Cells["address"].Value = row["order_address"].ToString();

            }
            con.Close();
            dataGridView1_Menu.Columns[7].Visible = true;

        }

        private void button_order_Click(object sender, EventArgs e)
        {
            if (Isvalid())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Income(order_id,item_id,item_name,item_quantity,item_price,Phone_No,time_hour,time_date,Table_No,time_month) SELECT order_id,item_id,item_name,item_quantity,item_price,Phone_No,time_hour,time_date,Table_No,time_month FROM Orders Where Orders.order_id = @orderid", con);
                    SqlCommand cmd1 = new SqlCommand("DELETE FROM Orders WHERE order_id = @order", con);
                    SqlCommand cmd2 = new SqlCommand("UPDATE Customers SET Points = ((SELECT Points WHERE Phone_No = @phone) + 10 ) WHERE Phone_No = @phone", con);
                    cmd.CommandType = CommandType.Text;
                    cmd1.CommandType = CommandType.Text;
                    cmd2.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@orderid", label3.Text);
                    cmd1.Parameters.AddWithValue("@order", label3.Text);
                    cmd2.Parameters.AddWithValue("@phone", label5.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Order Completed", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch
                {

                }
                if (x)
                {
                    LoadData();
                }
                else
                {
                    LoadData1();
                }
            }
            label2.Text = "";
            label3.Text = "";
            label5.Text = "";
        }
        private bool Isvalid()
        {
            if (label3.Text == string.Empty)
            {
                MessageBox.Show("Select an order", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("DELETE FROM Orders WHERE order_id = @order", con);
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.AddWithValue("@order", label3.Text);
            con.Open();
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Order Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (x)
            {
                LoadData();
            }
            else
            {
                LoadData1();
            }
        }

        private void dataGridView1_Menu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label2.Text = dataGridView1_Menu.SelectedRows[0].Cells["Orders_table_no"].Value.ToString();
            label2.ForeColor = Color.Black;
            label3.Text = dataGridView1_Menu.SelectedRows[0].Cells["Orders_order_id"].Value.ToString();
            label5.Text = dataGridView1_Menu.SelectedRows[0].Cells["Orders_phone"].Value.ToString();
        }
        private void resoreders()
        {
            button3.BackColor = Color.FromArgb(240, 240, 240);

            button2.BackColor = Color.FromArgb(158, 158, 158);
            panel1.BackColor = Color.FromArgb(158, 158, 158);
            x = true;
            label2.Text = "";
            label3.Text = "";
            label5.Text = "";
            LoadData();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            resoreders();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(240, 240, 240);

            button3.BackColor = Color.FromArgb(158, 158, 158);
            panel1.BackColor = Color.FromArgb(158, 158, 158);
            x = false;
            label2.Text = "";
            label3.Text = "";
            label5.Text = "";
            LoadData1();
            
        }

        private void dataGridView1_Menu_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            label2.Text = dataGridView1_Menu.SelectedRows[0].Cells["Orders_table_no"].Value.ToString();
            label2.ForeColor = Color.Black;
            label3.Text = dataGridView1_Menu.SelectedRows[0].Cells["Orders_order_id"].Value.ToString();
            label5.Text = dataGridView1_Menu.SelectedRows[0].Cells["Orders_phone"].Value.ToString();
        }

        private void Admin_Food_Orders_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            label2.Text = "";
        }
    }
}
