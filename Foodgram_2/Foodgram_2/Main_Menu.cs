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
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wssg, int wparam, int Iparam);

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5QGE0VB\SQLEXPRESS;Initial Catalog=Foodgram;Integrated Security=True");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            Registration_Menu register = new Registration_Menu();
            register.Show();
            this.Hide();
        }

        private void button_admin_Click(object sender, EventArgs e)
        {
            Admin_login admin_login = new Admin_login();
            admin_login.Show();
            this.Hide();
        }
        private void button_login_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Customers where Username ='" + text_username.Text + "' and Password = '" + text_password.Text + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                
                con.Close();
                User_Main_Menu user_main_menu = new User_Main_Menu();
                user_main_menu.username = text_username.Text;
                user_main_menu.Show();
                this.Hide();

            }
            else
            {
                con.Close();
                MessageBox.Show("Please Enter Correct username and password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User_password_reset upr = new User_password_reset();
            upr.ShowDialog();
        }
    }
}
