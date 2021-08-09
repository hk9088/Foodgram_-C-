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
using System.Net;
using System.Net.Mail;

namespace Foodgram_2
{
    public partial class User_password_reset : Form
    {
        bool y = true;
        string randomcode;
        public static string to;

        public User_password_reset()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5QGE0VB\SQLEXPRESS;Initial Catalog=Foodgram;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {
            if (y)
            {
                textBox2.PasswordChar = '\0';
                y = false;
            }

            else
            {
                textBox2.PasswordChar = '*';
                y = true;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "(New Password)")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.TextAlign = HorizontalAlignment.Left;
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "(New Password)";
                textBox2.ForeColor = Color.FromArgb(169, 169, 169);
                textBox2.TextAlign = HorizontalAlignment.Center;
                textBox2.PasswordChar = '\0';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(" Select * From Customers where Email = '" + text_email.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                string from, pass, messagebody;
                Random rand = new Random();
                randomcode = (rand.Next(999999)).ToString();
                MailMessage message = new MailMessage();
                to = (text_email.Text).ToString();
                from = "fooodgram07@gmail.com";
                pass = "fooodgram07@Food";
                messagebody = "Your reset code is " + randomcode;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messagebody;
                message.Subject = "Password reset Code";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Code Send Successfully");
                    textBox1.Visible = true;
                    label1.Visible = true;
                    panel1.Visible = true;
                    button2.Visible = true;

                    textBox1.Enabled = true;
                    label1.Enabled = true;
                    panel1.Enabled = true;
                    button2.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Mail Doesn't exits", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_email.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(randomcode == (textBox1.Text).ToString())
            {
                MessageBox.Show("Code Verified");
                textBox2.Visible = true;
                button3.Visible = true;
                panel2.Visible = true;
                button4.Visible = true;

                textBox2.Enabled = true;
                button3.Enabled = true;
                panel2.Enabled = true;
                button4.Enabled = true;
            }
            else
            {
                MessageBox.Show("Worng Code","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Customers set Password = @pass  where Phone_No = (Select Phone_No from Customers WHERE Email = '" + to + "' )", con);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Password Changed", "Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            text_email.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
