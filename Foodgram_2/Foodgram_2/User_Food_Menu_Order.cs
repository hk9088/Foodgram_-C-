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
    public partial class User_Food_Menu_Order : Form
    {
        public float user_price;
        static string _username;
        bool x,y;

        public User_Food_Menu_Order()
        {
            InitializeComponent();
            

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5QGE0VB\SQLEXPRESS;Initial Catalog=Foodgram;Integrated Security=True");

        public User_Food_Menu_Order(string i_id, string i_name, string i_table, float i_price, int i_quantity,string uname)
        {
            InitializeComponent();
            text_item_id.Text = i_id;
            text_item_name.Text = i_name;
            text_item_quantity.Text = ""+i_quantity;
            text_table_no.Text = i_table;
            user_price = i_quantity * i_price;
            Price.Text = ""+ user_price + "৳";
            _username = uname;

        }

        private void User_Food_Menu_Order_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_order_Click(object sender, EventArgs e)
        {
            using (User_payment_Bkash xx = new User_payment_Bkash(this.user_price))
            {
                xx.ShowDialog();
                y = xx.yy;
                if(y)
                {
                    order_confirm();
                }
            }
                
            
            this.Hide();
        }
        private void order_confirm()
        {
            if (x)
            {
                var date = DateTime.Now;
                var onlytime = date.ToShortTimeString();
                var onlymonth = DateTime.Now.ToString("MMMM");
                con.Open();
                SqlCommand cmd1 = new SqlCommand("Select Phone_No From Customers Where Username=@Username", con);
                cmd1.CommandType = CommandType.Text;
                cmd1.Parameters.AddWithValue("@Username", _username);
                string phone_no = (string)cmd1.ExecuteScalar();
                con.Close();

                try
                {

                    SqlCommand cmd = new SqlCommand("INSERT INTO Orders Values(@ID,@Name,@Quantity,@Price,@Phone_No,@Time,@Date,@Table,@month,@address)", con);

                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@ID", text_item_id.Text);
                    cmd.Parameters.AddWithValue("@Name", text_item_name.Text);
                    cmd.Parameters.AddWithValue("@Quantity", text_item_quantity.Text);
                    cmd.Parameters.AddWithValue("@Price", user_price);
                    cmd.Parameters.AddWithValue("@Phone_No", phone_no);
                    cmd.Parameters.AddWithValue("@Time", onlytime);
                    cmd.Parameters.AddWithValue("@Date", date);
                    cmd.Parameters.AddWithValue("@Table", text_table_no.Text);
                    cmd.Parameters.AddWithValue("@month", onlymonth);
                    cmd.Parameters.AddWithValue("@address", textBox_address.Text);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();


                }
                catch
                {

                }
            }
            else
            {
                var date = DateTime.Now;
                var onlytime = date.ToShortTimeString();
                var onlymonth = DateTime.Now.ToString("MMMM");
                con.Open();
                SqlCommand cmd1 = new SqlCommand("Select Phone_No From Customers Where Username=@Username", con);
                cmd1.CommandType = CommandType.Text;
                cmd1.Parameters.AddWithValue("@Username", _username);
                string phone_no = (string)cmd1.ExecuteScalar();
                con.Close();

                try
                {

                    SqlCommand cmd = new SqlCommand("INSERT INTO Orders Values(@ID,@Name,@Quantity,@Price,@Phone_No,@Time,@Date,@Table,@month,NULL)", con);

                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@ID", text_item_id.Text);
                    cmd.Parameters.AddWithValue("@Name", text_item_name.Text);
                    cmd.Parameters.AddWithValue("@Quantity", text_item_quantity.Text);
                    cmd.Parameters.AddWithValue("@Price", user_price);
                    cmd.Parameters.AddWithValue("@Phone_No", phone_no);
                    cmd.Parameters.AddWithValue("@Time", onlytime);
                    cmd.Parameters.AddWithValue("@Date", date);
                    cmd.Parameters.AddWithValue("@Table", text_table_no.Text);
                    cmd.Parameters.AddWithValue("@month", onlymonth);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();


                }
                catch
                {

                }
            }
        }

        private void bunifuToggleSwitch1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            
            x = bunifuToggleSwitch1.Checked;
            if (x)
            {
                label_address.Visible = true;
                panel_address.Visible = true;
                textBox_address.Visible = true;

                text_table_no.Visible = false;
                panel1.Visible = false;
                label3.Visible = false;

                con.Open();
                SqlCommand cmd1 = new SqlCommand("Select Address From Customers Where Username=@Username", con);
                cmd1.CommandType = CommandType.Text;
                cmd1.Parameters.AddWithValue("@Username", _username);
                textBox_address.Text = (string)cmd1.ExecuteScalar();
                con.Close();
            }
            else
            {

                text_table_no.Visible = true;
                panel1.Visible = true;
                label3.Visible = true;

                label_address.Visible = false;
                panel_address.Visible = false;
                textBox_address.Visible = false;
            }
            
        }
    }
}
