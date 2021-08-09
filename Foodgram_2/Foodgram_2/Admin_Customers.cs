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
    public partial class Admin_Customers : Form
    {
        
        public Admin_Customers()
        {
            InitializeComponent();
            LoadData();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5QGE0VB\SQLEXPRESS;Initial Catalog=Foodgram;Integrated Security=True");
        

        private void Admin_Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodgramDataSet.Customers' table. You can move, or remove it, as needed.
           
            

        }
        private void LoadData()
        {
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Customers", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1_Customers.Rows.Clear();

            foreach (DataRow row in dtbl.Rows)
            {
                int n = dataGridView1_Customers.Rows.Add();
                dataGridView1_Customers.Rows[n].Cells["dg_sl"].Value = n + 1;
                dataGridView1_Customers.Rows[n].Cells["dg_name"].Value = row["Name"].ToString();
                dataGridView1_Customers.Rows[n].Cells["dg_phone_no"].Value = row["Phone_No"].ToString();
                dataGridView1_Customers.Rows[n].Cells["dg_address"].Value = row["Address"].ToString();
                dataGridView1_Customers.Rows[n].Cells["dg_points"].Value = row["Points"].ToString();

            }
            con.Close();

        }
















    }
}
