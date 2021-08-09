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
using System.IO;

namespace Foodgram_2
{
    
    public partial class User_Food_Menu : Form
    {
        public string uname;
        public User_Food_Menu()
        {
            InitializeComponent();
            
        }
        public User_Food_Menu(string username)
        {
            InitializeComponent();
            uname = username;
            LoadData();

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5QGE0VB\SQLEXPRESS;Initial Catalog=Foodgram;Integrated Security=True");
        private void ClearData()
        {
            
            text_item_quantity.Clear();
        }
        private void LoadData()
        {
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Menu", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1_Menu.Rows.Clear();

            foreach (DataRow row in dtbl.Rows)
            {
                int n = dataGridView1_Menu.Rows.Add();
                dataGridView1_Menu.Rows[n].Cells["Menu_item_id"].Value = row["item_id"].ToString();
                dataGridView1_Menu.Rows[n].Cells["Menu_item_name"].Value = row["item_name"].ToString();
                dataGridView1_Menu.Rows[n].Cells["Menu_item_quantity"].Value = row["item_quantity"].ToString();
                dataGridView1_Menu.Rows[n].Cells["Menu_item_price"].Value = row["item_price"].ToString();

            }
            con.Close();

        }
        private void User_Food_Menu_Load(object sender, EventArgs e)
        {

        }
        private void button_order_Click(object sender, EventArgs e)
        {
            try
            {
                User_Food_Menu_Order ufmo = new User_Food_Menu_Order(this.text_item_id.Text, this.text_item_name.Text, this.text_table_no.Text, float.Parse(text_price.Text), int.Parse(text_item_quantity.Text),uname);
                ufmo.ShowDialog();
            }
            catch(System.FormatException)
            {
                MessageBox.Show("Enter Quantity ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            ClearData();
        }

        private void dataGridView1_Menu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            text_item_id.Text = dataGridView1_Menu.SelectedRows[0].Cells["Menu_item_id"].Value.ToString();
            text_item_name.Text = dataGridView1_Menu.SelectedRows[0].Cells["Menu_item_name"].Value.ToString();
            text_price.Text = dataGridView1_Menu.SelectedRows[0].Cells["Menu_item_price"].Value.ToString();
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand("SELECT item_image FROM Menu WHERE item_id = '" + text_item_id.Text + "'", con));
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                if (dataSet.Tables[0].Rows.Count == 1)
                {
                    Byte[] data = new Byte[0];
                    data = (Byte[])(dataSet.Tables[0].Rows[0]["item_image"]);
                    MemoryStream mem = new MemoryStream(data);
                    pictureBox1.Image = Image.FromStream(mem);
                }
            }
            catch
            {

            }
        }
    }
}
