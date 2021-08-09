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
    public partial class Admin_Food_Menu : Form
    {
        public Admin_Food_Menu()
        {
            InitializeComponent();
            LoadData();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5QGE0VB\SQLEXPRESS;Initial Catalog=Foodgram;Integrated Security=True");





        private void ClearData()
        {
            text_item_id.Clear();
            text_item_name.Clear();
            text_item_price.Clear();
            text_item_quantity.Clear();
        }
        private bool Isvalid()
        {
            if (text_item_name.Text == string.Empty)
            {
                MessageBox.Show("Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (text_item_id.Text == string.Empty)
            {
                MessageBox.Show("ID is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (text_item_price.Text == string.Empty)
            {
                MessageBox.Show("Price is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void Admin_Food_Menu_Load(object sender, EventArgs e)
        {

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

        private void button_add_Click(object sender, EventArgs e)
        {
            if (Isvalid())
            {
                try
                {
                    byte[] images = null;
                    FileStream Stream = new FileStream(imgL, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(Stream);
                    images = brs.ReadBytes((int)Stream.Length);



                    SqlCommand cmd = new SqlCommand("INSERT INTO Menu Values(@ID,@Name,@Quantity,@Price,@image)", con);

                    cmd.CommandType = CommandType.Text;
                    
                    cmd.Parameters.AddWithValue("@ID", text_item_id.Text);
                    cmd.Parameters.AddWithValue("@Name", text_item_name.Text);
                    cmd.Parameters.AddWithValue("@Quantity", text_item_quantity.Text);
                    cmd.Parameters.AddWithValue("@Price", text_item_price.Text);
                    cmd.Parameters.Add(new SqlParameter ("@image",images));



                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("ID already exits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearData();
                }
                catch (System.ArgumentException)
                {
                    MessageBox.Show("Upload an image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                LoadData();

            }

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream Stream = new FileStream(imgL, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Stream);
            images = brs.ReadBytes((int)Stream.Length);

            SqlCommand cmd = new SqlCommand("UPDATE Menu set item_name = @Name,item_price = @Price,item_quantity = @Quantity,item_image = @image where item_id = @ID", con);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Name", text_item_name.Text);
            cmd.Parameters.AddWithValue("@ID", text_item_id.Text);
            cmd.Parameters.AddWithValue("@Price", text_item_price.Text);
            cmd.Parameters.AddWithValue("@Quantity", text_item_quantity.Text);
            cmd.Parameters.Add(new SqlParameter("@image", images));

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearData();
            LoadData();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Menu WHERE item_id = @ID", con);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Name", text_item_name.Text);
            cmd.Parameters.AddWithValue("@ID", text_item_id.Text);
            cmd.Parameters.AddWithValue("@Price", text_item_price.Text);
            cmd.Parameters.AddWithValue("@Quantity", text_item_quantity.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearData();
            LoadData();
        }
        string imgL="";
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|All files(*.*)|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                imgL = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgL;
            }
        }

        private void dataGridView1_Menu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            text_item_id.Text = dataGridView1_Menu.SelectedRows[0].Cells["Menu_item_id"].Value.ToString();
            text_item_name.Text = dataGridView1_Menu.SelectedRows[0].Cells["Menu_item_name"].Value.ToString();
            text_item_quantity.Text = dataGridView1_Menu.SelectedRows[0].Cells["Menu_item_quantity"].Value.ToString();
            text_item_price.Text = dataGridView1_Menu.SelectedRows[0].Cells["Menu_item_price"].Value.ToString();

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
