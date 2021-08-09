using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodgram_2
{
    public partial class User_payment_Bkash : Form
    {
        float x;
        public bool yy;
        public User_payment_Bkash(float xx)
        {
            InitializeComponent();
            x = xx;
        }

        private void button_order_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ordered Successfully", "Odered", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            yy = true;
        }

        private void User_payment_Bkash_Load(object sender, EventArgs e)
        {
            amount.Text = x.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            
            
        }
    }
}
