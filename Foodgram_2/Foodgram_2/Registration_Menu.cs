using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Foodgram_2
{
    public partial class Registration_Menu : Form
    {
        public Registration_Menu()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wssg, int wparam, int Iparam);

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5QGE0VB\SQLEXPRESS;Initial Catalog=Foodgram;Integrated Security=True");



        private void button_register_Click(object sender, EventArgs e)
        {
            if (Isvalid())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Customers Values(@Username,@Name,@Password,@Phone_No,@Address,0,@mail)", con);

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Username", text_username.Text);
                    cmd.Parameters.AddWithValue("@Name", text_name.Text);
                    cmd.Parameters.AddWithValue("@Password", text_password.Text);
                    cmd.Parameters.AddWithValue("@Phone_No", text_phone_no.Text);
                    cmd.Parameters.AddWithValue("@Address", text_address.Text);
                    cmd.Parameters.AddWithValue("@mail", text_email.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Registered Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Already exits try different phone no. or username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearData();
                }

            }
        }

        private void ClearData()
        {
            text_name.Clear();
            text_username.Clear();
            text_password.Clear();
            text_phone_no.Clear();
            text_address.Clear();
            text_email.Clear();
        }

        private bool Isvalid()
        {
            if (text_username.Text == string.Empty)
            {
                MessageBox.Show("Useranme is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (text_name.Text == string.Empty)
            {
                MessageBox.Show("Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (text_email.Text == string.Empty)
            {
                MessageBox.Show("Email is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (text_password.Text == string.Empty)
            {
                MessageBox.Show("Password is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (text_phone_no.Text == string.Empty)
            {
                MessageBox.Show("Phone No. is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main_Menu main_page = new Main_Menu();
            main_page.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Main_Menu main_page = new Main_Menu();
            main_page.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void text_email_TextChanged(object sender, EventArgs e)
        {

        }

    }
}


    
