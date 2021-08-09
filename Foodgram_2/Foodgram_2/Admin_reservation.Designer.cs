
namespace Foodgram_2
{
    partial class Admin_reservation
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.table_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.text_table_no = new System.Windows.Forms.TextBox();
            this.text_quantity = new System.Windows.Forms.TextBox();
            this.button_book = new System.Windows.Forms.Button();
            this.button_unbook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Table No  :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.table_no,
            this.table_quantity,
            this.table_status,
            this.name,
            this.phone});
            this.dataGridView1.Location = new System.Drawing.Point(72, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(881, 388);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // table_no
            // 
            this.table_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.table_no.HeaderText = "Table no";
            this.table_no.Name = "table_no";
            this.table_no.ReadOnly = true;
            // 
            // table_quantity
            // 
            this.table_quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.table_quantity.HeaderText = "Quantity";
            this.table_quantity.Name = "table_quantity";
            this.table_quantity.ReadOnly = true;
            // 
            // table_status
            // 
            this.table_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.table_status.HeaderText = "Status";
            this.table_status.Name = "table_status";
            this.table_status.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phone.HeaderText = "Phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Quantity    :";
            // 
            // button_delete
            // 
            this.button_delete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.Black;
            this.button_delete.Location = new System.Drawing.Point(195, 212);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(89, 40);
            this.button_delete.TabIndex = 42;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.Black;
            this.button_add.Location = new System.Drawing.Point(72, 212);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(89, 40);
            this.button_add.TabIndex = 40;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // text_table_no
            // 
            this.text_table_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_table_no.Location = new System.Drawing.Point(184, 53);
            this.text_table_no.Name = "text_table_no";
            this.text_table_no.Size = new System.Drawing.Size(166, 29);
            this.text_table_no.TabIndex = 43;
            // 
            // text_quantity
            // 
            this.text_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_quantity.Location = new System.Drawing.Point(184, 135);
            this.text_quantity.Name = "text_quantity";
            this.text_quantity.Size = new System.Drawing.Size(166, 29);
            this.text_quantity.TabIndex = 44;
            // 
            // button_book
            // 
            this.button_book.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_book.ForeColor = System.Drawing.Color.Black;
            this.button_book.Location = new System.Drawing.Point(573, 56);
            this.button_book.Name = "button_book";
            this.button_book.Size = new System.Drawing.Size(118, 54);
            this.button_book.TabIndex = 41;
            this.button_book.Text = "Book";
            this.button_book.UseVisualStyleBackColor = true;
            this.button_book.Click += new System.EventHandler(this.button_book_Click);
            // 
            // button_unbook
            // 
            this.button_unbook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_unbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_unbook.ForeColor = System.Drawing.Color.Black;
            this.button_unbook.Location = new System.Drawing.Point(573, 158);
            this.button_unbook.Name = "button_unbook";
            this.button_unbook.Size = new System.Drawing.Size(118, 54);
            this.button_unbook.TabIndex = 45;
            this.button_unbook.Text = "Unbook";
            this.button_unbook.UseVisualStyleBackColor = true;
            this.button_unbook.Click += new System.EventHandler(this.button_unbook_Click);
            // 
            // Admin_reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.button_unbook);
            this.Controls.Add(this.text_quantity);
            this.Controls.Add(this.text_table_no);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_book);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_reservation";
            this.Text = "Admin_reservation";
            this.Load += new System.EventHandler(this.Admin_reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox text_table_no;
        private System.Windows.Forms.TextBox text_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.Button button_book;
        private System.Windows.Forms.Button button_unbook;
    }
}