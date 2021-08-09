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
    public partial class Admin_reservation_book : Form
    {
        public string tno, tq;
        public Admin_reservation_book(string ttno,string ttq)
        {
            InitializeComponent();
            tno = ttno;
            tq = ttq;
            label4.Text = ttno;

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5QGE0VB\SQLEXPRESS;Initial Catalog=Foodgram;Integrated Security=True");

        private void button_order_Click(object sender, EventArgs e)
        {
            

                SqlCommand cmd = new SqlCommand("UPDATE Tables_Manage set Table_No = @ID,Table_Quantity = @Quantity,Table_Status = @stat,Phone_No = @Phone_No,Name = @Name where Table_No = @ID", con);

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@ID", tno);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Quantity", tq );
                cmd.Parameters.AddWithValue("@Phone_No", textBox2.Text);
                cmd.Parameters.AddWithValue("@stat", "Booked");


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Booked Successfully", "Booked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
