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
    public partial class User_review : Form
    {
        public string uname,x;
        public int i = 0;
        public User_review(string username)
        {
            InitializeComponent();
            uname = username;
           
            
            
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5QGE0VB\SQLEXPRESS;Initial Catalog=Foodgram;Integrated Security=True");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void User_review_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select Name From Customers Where Username=@Username", con);
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.AddWithValue("@Username", uname);
            label2.Text = (string)cmd1.ExecuteScalar();
            con.Close();
            LoadData();
        }
        private void ClearData()
        {
            bunifuRating1.Clear();
            textBox1.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Reviews Values(@Name,@rating,@comm,(SELECT Phone_No From Customers Where Username='"+ uname +"'))", con);

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Name", label2.Text);
                cmd.Parameters.AddWithValue("@rating", bunifuRating1.Value);
                cmd.Parameters.AddWithValue("@comm", textBox1.Text);



                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
            }
            catch (System.Data.SqlClient.SqlException)
            {
                SqlCommand cmd1 = new SqlCommand("UPDATE Reviews SET Name= @Name, Ratings=@rating, Comment = @comm WHERE Phone_No =(SELECT Phone_No From Customers Where Username='" + uname + "')", con);

                cmd1.CommandType = CommandType.Text;

                cmd1.Parameters.AddWithValue("@Name", label2.Text);
                cmd1.Parameters.AddWithValue("@rating", bunifuRating1.Value);
                cmd1.Parameters.AddWithValue("@comm", textBox1.Text);




                cmd1.ExecuteNonQuery();


                MessageBox.Show("Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ClearData();
            con.Close();
            LoadData();
        }

        private void LoadData()
        {
            int sum = 0;
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Reviews", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.Rows.Clear();

            foreach (DataRow row in dtbl.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["t_Name"].Value = row["Name"].ToString();
                dataGridView1.Rows[n].Cells["t_Ratings"].Value = row["Ratings"].ToString();
                dataGridView1.Rows[n].Cells["t_Comment"].Value = row["Comment"].ToString();
                
                i++;
            }
            
            x = dtbl.Compute("Sum(Ratings)", "").ToString();
            try { 
                sum = Int32.Parse(x);
                bunifuRating2.Value = sum / i;
            }
            catch
            {
                sum = 0;
                bunifuRating2.Value = sum;
            }
            
            i = 0;
            con.Close();
        }
    }
}
