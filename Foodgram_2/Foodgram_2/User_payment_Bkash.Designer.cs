
namespace Foodgram_2
{
    partial class User_payment_Bkash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_payment_Bkash));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.text_table_no = new System.Windows.Forms.TextBox();
            this.button_order = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(105, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(131, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 1);
            this.panel1.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(60, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 71;
            this.label3.Text = "PIN";
            // 
            // text_table_no
            // 
            this.text_table_no.BackColor = System.Drawing.Color.White;
            this.text_table_no.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_table_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_table_no.ForeColor = System.Drawing.Color.Black;
            this.text_table_no.Location = new System.Drawing.Point(131, 218);
            this.text_table_no.Name = "text_table_no";
            this.text_table_no.PasswordChar = '*';
            this.text_table_no.Size = new System.Drawing.Size(227, 19);
            this.text_table_no.TabIndex = 70;
            // 
            // button_order
            // 
            this.button_order.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_order.BackColor = System.Drawing.Color.Lime;
            this.button_order.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_order.ForeColor = System.Drawing.Color.Black;
            this.button_order.Location = new System.Drawing.Point(183, 284);
            this.button_order.Name = "button_order";
            this.button_order.Size = new System.Drawing.Size(97, 51);
            this.button_order.TabIndex = 73;
            this.button_order.Text = "✓";
            this.button_order.UseVisualStyleBackColor = false;
            this.button_order.Click += new System.EventHandler(this.button_order_Click);
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.ForeColor = System.Drawing.Color.Black;
            this.amount.Location = new System.Drawing.Point(189, 170);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(94, 29);
            this.amount.TabIndex = 75;
            this.amount.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(41, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 74;
            this.label4.Text = "Amount";
            // 
            // User_payment_Bkash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(477, 361);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_order);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_table_no);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "User_payment_Bkash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_payment_Bkash";
            this.Load += new System.EventHandler(this.User_payment_Bkash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_table_no;
        private System.Windows.Forms.Button button_order;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label label4;
    }
}