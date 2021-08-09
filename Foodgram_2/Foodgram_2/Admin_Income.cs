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
    public partial class Admin_Income : Form
    {
        public Admin_Income()
        {
            InitializeComponent();
            
            daily();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5QGE0VB\SQLEXPRESS;Initial Catalog=Foodgram;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(240, 240, 240);

            button2.BackColor = Color.FromArgb(158, 158, 158);
            panel1.BackColor = Color.FromArgb(158, 158, 158);
            daily();
        }

        

        private void Admin_Income_Load(object sender, EventArgs e)
        {
            

            

        }
        private void daily()
        {
            button1.BackColor = Color.FromArgb(240, 240, 240);

            button2.BackColor = Color.FromArgb(158, 158, 158);
            panel1.BackColor = Color.FromArgb(158, 158, 158);
            dataGridView1.Visible = true;
            chart1.Visible = false;


            LoadData();
            
        }
        private void LoadData()
        {
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Income  ", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.Rows.Clear();

            foreach (DataRow row in dtbl.Rows)
            {
                int n = dataGridView1.Rows.Add();
               
                dataGridView1.Rows[n].Cells["income_date"].Value = row["time_date"].ToString();
                dataGridView1.Rows[n].Cells["income_price"].Value = row["item_price"].ToString();

            }
            con.Close();

            label2.Text = dtbl.Compute("Sum(item_price)", "").ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(240, 240, 240);

            button1.BackColor = Color.FromArgb(158, 158, 158);
            panel1.BackColor = Color.FromArgb(158, 158, 158);

            dataGridView1.Visible = false;
            chart1.Visible = true;

            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter myCommand = new SqlDataAdapter("[gettotal]", con);

            DataSet ds = new DataSet();
            myCommand.Fill(ds);

            DataView source = new DataView(ds.Tables[0]);
            chart1.DataSource = source;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.Series[0].XValueMember = "Month";
            chart1.Series[0].YValueMembers = "Income";

            chart1.DataBind();
            con.Close();

        }
    }
}
