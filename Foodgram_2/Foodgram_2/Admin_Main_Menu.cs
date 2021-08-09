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
    public partial class Admin_Main_Menu : Form
    {
        public Admin_Main_Menu()
        {
            InitializeComponent();
            openChildForm(new Admin_Food_Orders());
            button_oders.BackColor = Color.FromArgb(54, 54, 57);
        }
        private void Admin_Main_Menu_Load(object sender, EventArgs e)
        {
            position(button_oders);
        }
        private void position(Button b)
        {
            p1.Location = new Point(b.Location.X, b.Location.Y);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wssg, int wparam, int Iparam);

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Admin_login admin_login = new Admin_login();
            admin_login.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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

        private void button_customers_Click(object sender, EventArgs e)
        {
            position(button_customers);
            openChildForm(new Admin_Customers());
            button_customers.BackColor = Color.FromArgb(54, 54, 57);



            button_oders.BackColor = Color.FromArgb(45, 45, 48);
            button_food_menu.BackColor = Color.FromArgb(45, 45, 48);
            button_income.BackColor = Color.FromArgb(45, 45, 48);
            button_reservation.BackColor = Color.FromArgb(45, 45, 48);
            button_reviews.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void button_food_menu_Click(object sender, EventArgs e)
        {
            position(button_food_menu);
            openChildForm(new Admin_Food_Menu());
            button_food_menu.BackColor = Color.FromArgb(54, 54, 57);





            button_oders.BackColor = Color.FromArgb(45, 45, 48);
            button_income.BackColor = Color.FromArgb(45, 45, 48);
            button_reservation.BackColor = Color.FromArgb(45, 45, 48);
            button_reviews.BackColor = Color.FromArgb(45, 45, 48);
            button_customers.BackColor = Color.FromArgb(45, 45, 48);
        }

        

        private void button_income_Click(object sender, EventArgs e)
        {
            position(button_income);
            openChildForm(new Admin_Income());
            button_income.BackColor = Color.FromArgb(54,54,57);



            button_oders.BackColor = Color.FromArgb(45, 45, 48);
            button_food_menu.BackColor = Color.FromArgb(45, 45, 48);
            button_reservation.BackColor = Color.FromArgb(45, 45, 48);
            button_reviews.BackColor = Color.FromArgb(45, 45, 48);
            button_customers.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void button_reservation_Click(object sender, EventArgs e)
        {
            openChildForm(new Admin_reservation());
            position(button_reservation);
            button_reservation.BackColor = Color.FromArgb(54, 54, 57);




            button_oders.BackColor = Color.FromArgb(45, 45, 48);
            button_food_menu.BackColor = Color.FromArgb(45, 45, 48);
            button_income.BackColor = Color.FromArgb(45, 45, 48);
            button_reviews.BackColor = Color.FromArgb(45, 45, 48);
            button_customers.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void button_reviews_Click(object sender, EventArgs e)
        {
            openChildForm(new Admin_review());
            position(button_reviews);
            button_reviews.BackColor = Color.FromArgb(54, 54, 57);



            button_oders.BackColor = Color.FromArgb(45, 45, 48);
            button_food_menu.BackColor = Color.FromArgb(45, 45, 48);
            button_income.BackColor = Color.FromArgb(45, 45, 48);
            button_reservation.BackColor = Color.FromArgb(45, 45, 48);
            button_customers.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void button_oders_Click(object sender, EventArgs e)
        {
            openChildForm(new Admin_Food_Orders());
            position(button_oders);
            button_oders.BackColor = Color.FromArgb(54, 54, 57);




            button_food_menu.BackColor = Color.FromArgb(45, 45, 48);
            button_income.BackColor = Color.FromArgb(45, 45, 48);
            button_reservation.BackColor = Color.FromArgb(45, 45, 48);
            button_reviews.BackColor = Color.FromArgb(45, 45, 48);
            button_customers.BackColor = Color.FromArgb(45, 45, 48);

        }
    }
}
