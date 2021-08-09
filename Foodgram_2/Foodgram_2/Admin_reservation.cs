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
    public partial class Admin_reservation : Form
    {
        public Admin_reservation()
        {
            InitializeComponent();
            LoadData();


        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5QGE0VB\SQLEXPRESS;Initial Catalog=Foodgram;Integrated Security=True");


        private void comboBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Admin_reservation_Load(object sender, EventArgs e)
        {
            
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
        private void ClearData()
        {
            text_table_no.Clear();
            text_quantity.Clear();

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Tables_Manage Values(@ID,@Quantity,@Stat,@phone,@name)", con);

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@ID", text_table_no.Text);
                cmd.Parameters.AddWithValue("@Stat", "Unbooked");
                cmd.Parameters.AddWithValue("@Quantity", text_quantity.Text);
                cmd.Parameters.AddWithValue("@phone", "NULL");
                cmd.Parameters.AddWithValue("@name", "NULL");



                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
            }
            catch 
            {
                MessageBox.Show("Table already exits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearData();
            }
            LoadData();

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Tables_Manage WHERE Table_No = @ID", con);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", text_table_no.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearData();
            LoadData();
        }

        private void button_book_Click(object sender, EventArgs e)
        {
            if(text_table_no.Text.Length != 0 && text_quantity.Text.Length !=0  )
            {
                Admin_reservation_book ufmo = new Admin_reservation_book(this.text_table_no.Text, this.text_quantity.Text);
                ufmo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select a Table", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearData();
            }
            LoadData();
        }

        private void button_unbook_Click(object sender, EventArgs e)
        {
            
            if (text_table_no.Text.Length != 0 && text_quantity.Text.Length != 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Tables_Manage set Table_Status = @stat, Phone_No = @Phone_No,Name = @Name where Table_No = @ID", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", text_table_no.Text);
                cmd.Parameters.AddWithValue("@stat", "Unbooked");
                cmd.Parameters.AddWithValue("@Name","NULL");
                cmd.Parameters.AddWithValue("@Phone_No", "NULL");


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                ClearData();
            }
            else
            {
                MessageBox.Show("Select a Table", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearData();
            }
            LoadData();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            text_table_no.Text = dataGridView1.SelectedRows[0].Cells["table_no"].Value.ToString();
            text_quantity.Text = dataGridView1.SelectedRows[0].Cells["table_quantity"].Value.ToString();
        }
    }
}
