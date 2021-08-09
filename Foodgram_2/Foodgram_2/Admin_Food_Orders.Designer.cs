
namespace Foodgram_2
{
    partial class Admin_Food_Orders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1_Menu = new System.Windows.Forms.DataGridView();
            this.Orders_order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orders_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orders_item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orders_item_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orders_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orders_table_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orders_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button_order = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Menu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1_Menu
            // 
            this.dataGridView1_Menu.AllowUserToAddRows = false;
            this.dataGridView1_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1_Menu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1_Menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Menu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Orders_order_id,
            this.Orders_Name,
            this.Orders_item_name,
            this.Orders_item_quantity,
            this.Orders_time,
            this.Orders_table_no,
            this.Orders_phone,
            this.address});
            this.dataGridView1_Menu.Location = new System.Drawing.Point(70, 227);
            this.dataGridView1_Menu.Name = "dataGridView1_Menu";
            this.dataGridView1_Menu.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1_Menu.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1_Menu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_Menu.Size = new System.Drawing.Size(881, 388);
            this.dataGridView1_Menu.TabIndex = 0;
            this.dataGridView1_Menu.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_Menu_CellMouseClick_1);
            // 
            // Orders_order_id
            // 
            this.Orders_order_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Orders_order_id.HeaderText = "Order ID";
            this.Orders_order_id.Name = "Orders_order_id";
            this.Orders_order_id.ReadOnly = true;
            // 
            // Orders_Name
            // 
            this.Orders_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Orders_Name.HeaderText = "Customer Name";
            this.Orders_Name.Name = "Orders_Name";
            this.Orders_Name.ReadOnly = true;
            // 
            // Orders_item_name
            // 
            this.Orders_item_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Orders_item_name.HeaderText = "Item Name";
            this.Orders_item_name.Name = "Orders_item_name";
            this.Orders_item_name.ReadOnly = true;
            // 
            // Orders_item_quantity
            // 
            this.Orders_item_quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Orders_item_quantity.HeaderText = "Quantity";
            this.Orders_item_quantity.Name = "Orders_item_quantity";
            this.Orders_item_quantity.ReadOnly = true;
            // 
            // Orders_time
            // 
            this.Orders_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Orders_time.HeaderText = "Ordered Time";
            this.Orders_time.Name = "Orders_time";
            this.Orders_time.ReadOnly = true;
            // 
            // Orders_table_no
            // 
            this.Orders_table_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Orders_table_no.HeaderText = "Table No.";
            this.Orders_table_no.Name = "Orders_table_no";
            this.Orders_table_no.ReadOnly = true;
            this.Orders_table_no.Visible = false;
            // 
            // Orders_phone
            // 
            this.Orders_phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Orders_phone.HeaderText = "Phone No";
            this.Orders_phone.Name = "Orders_phone";
            this.Orders_phone.ReadOnly = true;
            this.Orders_phone.Visible = false;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(854, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 51);
            this.button1.TabIndex = 59;
            this.button1.Text = "☓";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_order
            // 
            this.button_order.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_order.BackColor = System.Drawing.Color.Lime;
            this.button_order.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_order.ForeColor = System.Drawing.Color.Black;
            this.button_order.Location = new System.Drawing.Point(854, 70);
            this.button_order.Name = "button_order";
            this.button_order.Size = new System.Drawing.Size(97, 51);
            this.button_order.TabIndex = 58;
            this.button_order.Text = "✓";
            this.button_order.UseVisualStyleBackColor = false;
            this.button_order.Click += new System.EventHandler(this.button_order_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(207, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(207, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 29);
            this.label3.TabIndex = 63;
            this.label3.Text = "   ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(68, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 29);
            this.label4.TabIndex = 62;
            this.label4.Text = "Order ID  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(331, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 29);
            this.label5.TabIndex = 64;
            this.label5.Text = "   ";
            this.label5.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(65, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 60;
            this.label1.Text = "Table No :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 30);
            this.panel1.TabIndex = 65;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(150, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Home Deliveries";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 30);
            this.button3.TabIndex = 0;
            this.button3.Text = "Restaurant Orders";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Admin_Food_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_order);
            this.Controls.Add(this.dataGridView1_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Food_Orders";
            this.Text = "Admin_Food_Orders";
            this.Click += new System.EventHandler(this.Admin_Food_Orders_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Menu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1_Menu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_order;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orders_order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orders_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orders_item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orders_item_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orders_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orders_table_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orders_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
    }
}