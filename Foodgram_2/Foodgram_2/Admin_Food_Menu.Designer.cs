
namespace Foodgram_2
{
    partial class Admin_Food_Menu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1_Menu = new System.Windows.Forms.DataGridView();
            this.Menu_item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menu_item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menu_item_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menu_item_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_item_name = new System.Windows.Forms.TextBox();
            this.text_item_id = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.text_item_price = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.text_item_quantity = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1_Menu
            // 
            this.dataGridView1_Menu.AllowUserToAddRows = false;
            this.dataGridView1_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1_Menu.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1_Menu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1_Menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Menu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Menu_item_id,
            this.Menu_item_name,
            this.Menu_item_quantity,
            this.Menu_item_price});
            this.dataGridView1_Menu.Location = new System.Drawing.Point(70, 300);
            this.dataGridView1_Menu.Name = "dataGridView1_Menu";
            this.dataGridView1_Menu.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1_Menu.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1_Menu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_Menu.Size = new System.Drawing.Size(881, 388);
            this.dataGridView1_Menu.TabIndex = 0;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(176, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(227, 1);
            this.panel4.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(177, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 1);
            this.panel3.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(66, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Item Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(66, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Item ID";
            // 
            // text_item_name
            // 
            this.text_item_name.BackColor = System.Drawing.SystemColors.Control;
            this.text_item_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_item_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_item_name.ForeColor = System.Drawing.Color.Black;
            this.text_item_name.Location = new System.Drawing.Point(177, 72);
            this.text_item_name.Name = "text_item_name";
            this.text_item_name.Size = new System.Drawing.Size(227, 19);
            this.text_item_name.TabIndex = 18;
            // 
            // text_item_id
            // 
            this.text_item_id.BackColor = System.Drawing.SystemColors.Control;
            this.text_item_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_item_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_item_id.ForeColor = System.Drawing.Color.Black;
            this.text_item_id.Location = new System.Drawing.Point(177, 23);
            this.text_item_id.Name = "text_item_id";
            this.text_item_id.Size = new System.Drawing.Size(227, 19);
            this.text_item_id.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(177, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 1);
            this.panel1.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(66, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Price";
            // 
            // text_item_price
            // 
            this.text_item_price.BackColor = System.Drawing.SystemColors.Control;
            this.text_item_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_item_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_item_price.ForeColor = System.Drawing.Color.Black;
            this.text_item_price.Location = new System.Drawing.Point(177, 180);
            this.text_item_price.Name = "text_item_price";
            this.text_item_price.Size = new System.Drawing.Size(227, 19);
            this.text_item_price.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(177, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 1);
            this.panel2.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(66, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Item Quantity";
            // 
            // text_item_quantity
            // 
            this.text_item_quantity.BackColor = System.Drawing.SystemColors.Control;
            this.text_item_quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_item_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_item_quantity.ForeColor = System.Drawing.Color.Black;
            this.text_item_quantity.Location = new System.Drawing.Point(177, 127);
            this.text_item_quantity.Name = "text_item_quantity";
            this.text_item_quantity.Size = new System.Drawing.Size(227, 19);
            this.text_item_quantity.TabIndex = 31;
            // 
            // button_add
            // 
            this.button_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.Black;
            this.button_add.Location = new System.Drawing.Point(299, 241);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(78, 31);
            this.button_add.TabIndex = 37;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_update
            // 
            this.button_update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.Black;
            this.button_update.Location = new System.Drawing.Point(457, 241);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(78, 31);
            this.button_update.TabIndex = 38;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.Black;
            this.button_delete.Location = new System.Drawing.Point(601, 241);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(78, 31);
            this.button_delete.TabIndex = 39;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBox1.Location = new System.Drawing.Point(571, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(796, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "Upload ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin_Food_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_item_price);
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
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Food_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Food_Menu";
            this.Load += new System.EventHandler(this.Admin_Food_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1_Menu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_item_name;
        private System.Windows.Forms.TextBox text_item_id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_item_price;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_item_quantity;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu_item_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu_item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu_item_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu_item_price;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}