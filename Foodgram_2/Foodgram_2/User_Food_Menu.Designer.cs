
namespace Foodgram_2
{
    partial class User_Food_Menu
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
            this.button_order = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.text_table_no = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.text_item_quantity = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_item_name = new System.Windows.Forms.TextBox();
            this.text_item_id = new System.Windows.Forms.TextBox();
            this.dataGridView1_Menu = new System.Windows.Forms.DataGridView();
            this.Menu_item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menu_item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menu_item_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menu_item_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text_price = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_order
            // 
            this.button_order.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_order.BackColor = System.Drawing.Color.Lime;
            this.button_order.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_order.ForeColor = System.Drawing.Color.Black;
            this.button_order.Location = new System.Drawing.Point(663, 245);
            this.button_order.Name = "button_order";
            this.button_order.Size = new System.Drawing.Size(117, 58);
            this.button_order.TabIndex = 55;
            this.button_order.Text = "Order";
            this.button_order.UseVisualStyleBackColor = false;
            this.button_order.Click += new System.EventHandler(this.button_order_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(181, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 1);
            this.panel1.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(70, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Table";
            // 
            // text_table_no
            // 
            this.text_table_no.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.text_table_no.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_table_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_table_no.ForeColor = System.Drawing.Color.Black;
            this.text_table_no.Location = new System.Drawing.Point(181, 209);
            this.text_table_no.Name = "text_table_no";
            this.text_table_no.Size = new System.Drawing.Size(227, 19);
            this.text_table_no.TabIndex = 50;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(181, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 1);
            this.panel2.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(70, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Item Quantity";
            // 
            // text_item_quantity
            // 
            this.text_item_quantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.text_item_quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_item_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_item_quantity.ForeColor = System.Drawing.Color.Black;
            this.text_item_quantity.Location = new System.Drawing.Point(181, 156);
            this.text_item_quantity.Name = "text_item_quantity";
            this.text_item_quantity.Size = new System.Drawing.Size(227, 19);
            this.text_item_quantity.TabIndex = 47;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(180, 129);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(227, 1);
            this.panel4.TabIndex = 46;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(181, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 1);
            this.panel3.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(70, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Item Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(70, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Item ID";
            // 
            // text_item_name
            // 
            this.text_item_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.text_item_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_item_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_item_name.ForeColor = System.Drawing.Color.Black;
            this.text_item_name.Location = new System.Drawing.Point(181, 101);
            this.text_item_name.Name = "text_item_name";
            this.text_item_name.ReadOnly = true;
            this.text_item_name.Size = new System.Drawing.Size(227, 19);
            this.text_item_name.TabIndex = 42;
            // 
            // text_item_id
            // 
            this.text_item_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.text_item_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_item_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_item_id.ForeColor = System.Drawing.Color.Black;
            this.text_item_id.Location = new System.Drawing.Point(181, 52);
            this.text_item_id.Name = "text_item_id";
            this.text_item_id.ReadOnly = true;
            this.text_item_id.Size = new System.Drawing.Size(227, 19);
            this.text_item_id.TabIndex = 41;
            // 
            // dataGridView1_Menu
            // 
            this.dataGridView1_Menu.AllowUserToAddRows = false;
            this.dataGridView1_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1_Menu.BackgroundColor = System.Drawing.SystemColors.Control;
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
            this.Menu_item_id,
            this.Menu_item_name,
            this.Menu_item_quantity,
            this.Menu_item_price});
            this.dataGridView1_Menu.Location = new System.Drawing.Point(74, 329);
            this.dataGridView1_Menu.Name = "dataGridView1_Menu";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1_Menu.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1_Menu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_Menu.Size = new System.Drawing.Size(881, 388);
            this.dataGridView1_Menu.TabIndex = 40;
            this.dataGridView1_Menu.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_Menu_CellMouseClick);
            // 
            // Menu_item_id
            // 
            this.Menu_item_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Menu_item_id.HeaderText = "ITEM ID";
            this.Menu_item_id.Name = "Menu_item_id";
            this.Menu_item_id.ReadOnly = true;
            // 
            // Menu_item_name
            // 
            this.Menu_item_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Menu_item_name.HeaderText = "NAME";
            this.Menu_item_name.Name = "Menu_item_name";
            this.Menu_item_name.ReadOnly = true;
            // 
            // Menu_item_quantity
            // 
            this.Menu_item_quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Menu_item_quantity.HeaderText = "QUANTITY";
            this.Menu_item_quantity.Name = "Menu_item_quantity";
            this.Menu_item_quantity.ReadOnly = true;
            // 
            // Menu_item_price
            // 
            this.Menu_item_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Menu_item_price.HeaderText = "PRICE";
            this.Menu_item_price.Name = "Menu_item_price";
            this.Menu_item_price.ReadOnly = true;
            // 
            // text_price
            // 
            this.text_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.text_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_price.ForeColor = System.Drawing.Color.Black;
            this.text_price.Location = new System.Drawing.Point(181, 265);
            this.text_price.Name = "text_price";
            this.text_price.Size = new System.Drawing.Size(227, 19);
            this.text_price.TabIndex = 56;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBox1.Location = new System.Drawing.Point(571, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // User_Food_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.text_price);
            this.Controls.Add(this.button_order);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_table_no);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_item_quantity);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_item_name);
            this.Controls.Add(this.text_item_id);
            this.Controls.Add(this.dataGridView1_Menu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User_Food_Menu";
            this.Text = "User_Food_Menu";
            this.Load += new System.EventHandler(this.User_Food_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_order;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_table_no;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_item_quantity;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_item_name;
        private System.Windows.Forms.TextBox text_item_id;
        private System.Windows.Forms.DataGridView dataGridView1_Menu;
        private System.Windows.Forms.TextBox text_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu_item_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu_item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu_item_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu_item_price;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}