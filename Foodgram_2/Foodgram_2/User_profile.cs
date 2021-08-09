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
    
    public partial class User_profile : Form
    {
        bool x = true, y = true;
        string uname,upass,nname,eemail,aadress,pphone;
        int p;
        public User_profile(string username)
        {
            InitializeComponent();
            uname = username;
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5QGE0VB\SQLEXPRESS;Initial Catalog=Foodgram;Integrated Security=True");

        private void text_table_no_Enter(object sender, EventArgs e)
        {
            if (text_table_no.Text == "(Old Password)")
            {
                text_table_no.Text = "";
                text_table_no.ForeColor = Color.Black;
                text_table_no.TextAlign = HorizontalAlignment.Left;
                text_table_no.PasswordChar = '*';
            }
        }

        private void text_table_no_Leave(object sender, EventArgs e)
        {
            if (text_table_no.Text == "")
            {
                text_table_no.Text = "(Old Password)";
                text_table_no.ForeColor = Color.FromArgb(169,169,169);
                text_table_no.TextAlign = HorizontalAlignment.Center;
                text_table_no.PasswordChar = '\0';
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "(New Password)")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
                textBox1.TextAlign = HorizontalAlignment.Left;
                textBox1.PasswordChar = '*';
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "(New Password)";
                textBox1.ForeColor = Color.FromArgb(169, 169, 169);
                textBox1.TextAlign = HorizontalAlignment.Center;
                textBox1.PasswordChar = '\0';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(x)
            {
                text_table_no.PasswordChar = '\0';
                x = false;
            }
            else
            {
                text_table_no.PasswordChar = '*';
                x = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (y)
            {
                textBox1.PasswordChar = '\0';
                y = false;
            }
           
            else
            {
                textBox1.PasswordChar = '*';
                y = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(upass == text_table_no.Text)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Customers set Password = @pass  where Phone_No = (Select Phone_No from Customers WHERE Username = '" + uname + "' )", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@pass", textBox1.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Password Changed", "Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                text_table_no.Clear();
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Worng password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_table_no.Clear();
                textBox1.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            text_name.ReadOnly = false;
            text_name.Clear();

        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            text_email.ReadOnly = false;
            text_email.Clear();
        }

       

        private void button8_Click(object sender, EventArgs e)
        {
            text_address.ReadOnly = false;
            text_address.Clear();
        }

        private void User_profile_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select Password From Customers Where Username=@Username", con);
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.AddWithValue("@Username", uname);
            upass = (string)cmd1.ExecuteScalar();


            SqlCommand cmd2 = new SqlCommand("Select Name From Customers Where Username=@Username", con);
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.AddWithValue("@Username", uname);
            nname = (string)cmd2.ExecuteScalar();


            SqlCommand cmd3 = new SqlCommand("Select Email From Customers Where Username=@Username", con);
            cmd3.CommandType = CommandType.Text;
            cmd3.Parameters.AddWithValue("@Username", uname);
            eemail = (string)cmd3.ExecuteScalar();


            SqlCommand cmd4 = new SqlCommand("Select Address From Customers Where Username=@Username", con);
            cmd4.CommandType = CommandType.Text;
            cmd4.Parameters.AddWithValue("@Username", uname);
            aadress = (string)cmd4.ExecuteScalar();


            SqlCommand cmd5 = new SqlCommand("Select Phone_No From Customers Where Username=@Username", con);
            cmd5.CommandType = CommandType.Text;
            cmd5.Parameters.AddWithValue("@Username", uname);
            pphone = (string)cmd5.ExecuteScalar();


            SqlCommand cmd6 = new SqlCommand("Select Points From Customers Where Username=@Username", con);
            cmd6.CommandType = CommandType.Text;
            cmd6.Parameters.AddWithValue("@Username", uname);
            p = (int)cmd6.ExecuteScalar();
            label9.Text = p.ToString();


            con.Close();

            text_name.Text = nname;
            text_username.Text = uname;
            text_phone_no.Text = pphone;
            text_email.Text = eemail;
            text_address.Text = aadress;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("UPDATE Customers set Name = @name, Address = @address, Email = @mail  where Phone_No = (Select Phone_No from Customers WHERE Username = '" + uname + "' )", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", text_name.Text);
                cmd.Parameters.AddWithValue("@address", text_address.Text);
                cmd.Parameters.AddWithValue("@mail", text_email.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

            }

       
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
