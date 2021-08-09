using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Foodgram_2
{
    public partial class User_Main_Menu : Form
    {
        public string username;
        public User_Main_Menu()
        {

            InitializeComponent();
            
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void position(Button b)
        {
            p1.Location = new Point(b.Location.X, b.Location.Y);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wssg, int wparam, int Iparam);

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Child_panel.Controls.Add(childForm);
            Child_panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            position(button_menu);
            openChildForm(new User_Food_Menu(this.username));
        }

        private void button_oders_Click(object sender, EventArgs e)
        {
            
            openChildForm(new User_Orders(this.username));
            position(button_orders);
        }

        private void button_reservation_Click(object sender, EventArgs e)
        {
            openChildForm(new User_reservation(this.username));
            position(button_reservation);
        }

        private void button_reviews_Click(object sender, EventArgs e)
        {
            openChildForm(new User_review(this.username));
            position(button_reviews);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void User_Main_Menu_Load(object sender, EventArgs e)
        {
            lb1.Text = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main_Menu main_menu = new Main_Menu();
            main_menu.Show();
            this.Hide();
        }

        private void lb1_Click(object sender, EventArgs e)
        {
            User_profile up = new User_profile(this.username);
            up.ShowDialog();


        }
    }
}
