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
    public partial class Admin_review : Form
    {
        public string  x;
        public int i = 0;
        public Admin_review()
        {
            InitializeComponent();
            LoadData();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5QGE0VB\SQLEXPRESS;Initial Catalog=Foodgram;Integrated Security=True");

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
            sum = Int32.Parse(x);
            bunifuRating2.Value = sum / i;
            i = 0;
            con.Close();
        }
    }
}
