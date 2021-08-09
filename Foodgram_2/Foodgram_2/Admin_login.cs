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
    public partial class Admin_login : Form
    {
        public Admin_login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wssg, int wparam, int Iparam);

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5QGE0VB\SQLEXPRESS;Initial Catalog=Foodgram;Integrated Security=True");


        private void button_login_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(" Select count(*) From Admins where Name = '" + text_username + "' and Password = '" + text_password + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                Admin_Main_Menu admin_main_menu = new Admin_Main_Menu();
                admin_main_menu.Show();

            }
            else
            {
                MessageBox.Show("Please Enter Correct username and password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Main_Menu main_menu = new Main_Menu();
            main_menu.Show();
            this.Hide();
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
