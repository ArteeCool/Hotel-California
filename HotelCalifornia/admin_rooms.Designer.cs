namespace HotelCalifornia
{
    partial class admin_rooms
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label5 = new Label();
            MainGrid = new DataGridView();
            panel2 = new Panel();
            rooms_clearBtn = new RoundedButton();
            rooms_deleteBtn = new RoundedButton();
            rooms_editBtn = new RoundedButton();
            rooms_addBtn = new RoundedButton();
            rooms_importBtn = new RoundedButton();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            rooms_status = new ComboBox();
            label6 = new Label();
            rooms_price = new TextBox();
            label4 = new Label();
            rooms_roomName = new TextBox();
            label3 = new Label();
            rooms_type = new ComboBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainGrid).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(MainGrid);
            panel1.Location = new Point(15, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(973, 387);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 18);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 23;
            label5.Text = "Room's Data";
            // 
            // MainGrid
            // 
            MainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(255, 242, 204);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(216, 59, 113);
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            MainGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            MainGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MainGrid.Location = new Point(24, 57);
            MainGrid.Name = "MainGrid";
            MainGrid.RowHeadersWidth = 51;
            MainGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            MainGrid.Size = new Size(924, 307);
            MainGrid.TabIndex = 22;
            MainGrid.CellContentClick += MainGrid_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(rooms_clearBtn);
            panel2.Controls.Add(rooms_deleteBtn);
            panel2.Controls.Add(rooms_editBtn);
            panel2.Controls.Add(rooms_addBtn);
            panel2.Controls.Add(rooms_importBtn);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(rooms_status);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(rooms_price);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(rooms_roomName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(rooms_type);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(15, 432);
            panel2.Name = "panel2";
            panel2.Size = new Size(973, 267);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // rooms_clearBtn
            // 
            rooms_clearBtn.BackColor = Color.FromArgb(255, 242, 204);
            rooms_clearBtn.Cursor = Cursors.Hand;
            rooms_clearBtn.FlatAppearance.BorderSize = 0;
            rooms_clearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(237, 201, 175);
            rooms_clearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 201, 175);
            rooms_clearBtn.FlatStyle = FlatStyle.Flat;
            rooms_clearBtn.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rooms_clearBtn.ForeColor = Color.Purple;
            rooms_clearBtn.Location = new Point(572, 200);
            rooms_clearBtn.Name = "rooms_clearBtn";
            rooms_clearBtn.Size = new Size(125, 43);
            rooms_clearBtn.TabIndex = 38;
            rooms_clearBtn.Text = "Clear";
            rooms_clearBtn.UseVisualStyleBackColor = false;
            rooms_clearBtn.Click += rooms_clearBtn_Click;
            // 
            // rooms_deleteBtn
            // 
            rooms_deleteBtn.BackColor = Color.FromArgb(255, 242, 204);
            rooms_deleteBtn.Cursor = Cursors.Hand;
            rooms_deleteBtn.FlatAppearance.BorderSize = 0;
            rooms_deleteBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(237, 201, 175);
            rooms_deleteBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 201, 175);
            rooms_deleteBtn.FlatStyle = FlatStyle.Flat;
            rooms_deleteBtn.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rooms_deleteBtn.ForeColor = Color.Purple;
            rooms_deleteBtn.Location = new Point(404, 200);
            rooms_deleteBtn.Name = "rooms_deleteBtn";
            rooms_deleteBtn.Size = new Size(125, 43);
            rooms_deleteBtn.TabIndex = 37;
            rooms_deleteBtn.Text = "Delete";
            rooms_deleteBtn.UseVisualStyleBackColor = false;
            rooms_deleteBtn.Click += rooms_deleteBtn_Click;
            // 
            // rooms_editBtn
            // 
            rooms_editBtn.BackColor = Color.FromArgb(255, 242, 204);
            rooms_editBtn.Cursor = Cursors.Hand;
            rooms_editBtn.FlatAppearance.BorderSize = 0;
            rooms_editBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(237, 201, 175);
            rooms_editBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 201, 175);
            rooms_editBtn.FlatStyle = FlatStyle.Flat;
            rooms_editBtn.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rooms_editBtn.ForeColor = Color.Purple;
            rooms_editBtn.Location = new Point(233, 200);
            rooms_editBtn.Name = "rooms_editBtn";
            rooms_editBtn.Size = new Size(125, 43);
            rooms_editBtn.TabIndex = 36;
            rooms_editBtn.Text = "Edit";
            rooms_editBtn.UseVisualStyleBackColor = false;
            rooms_editBtn.Click += rooms_editBtn_Click;
            // 
            // rooms_addBtn
            // 
            rooms_addBtn.BackColor = Color.FromArgb(255, 242, 204);
            rooms_addBtn.Cursor = Cursors.Hand;
            rooms_addBtn.FlatAppearance.BorderSize = 0;
            rooms_addBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(237, 201, 175);
            rooms_addBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 201, 175);
            rooms_addBtn.FlatStyle = FlatStyle.Flat;
            rooms_addBtn.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rooms_addBtn.ForeColor = Color.Purple;
            rooms_addBtn.Location = new Point(66, 200);
            rooms_addBtn.Name = "rooms_addBtn";
            rooms_addBtn.Size = new Size(125, 43);
            rooms_addBtn.TabIndex = 35;
            rooms_addBtn.Text = "Add";
            rooms_addBtn.UseVisualStyleBackColor = false;
            rooms_addBtn.Click += rooms_addBtn_Click;
            // 
            // rooms_importBtn
            // 
            rooms_importBtn.BackColor = Color.FromArgb(255, 242, 204);
            rooms_importBtn.Cursor = Cursors.Hand;
            rooms_importBtn.FlatAppearance.BorderSize = 0;
            rooms_importBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(237, 201, 175);
            rooms_importBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 201, 175);
            rooms_importBtn.FlatStyle = FlatStyle.Flat;
            rooms_importBtn.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rooms_importBtn.ForeColor = Color.Purple;
            rooms_importBtn.Location = new Point(824, 171);
            rooms_importBtn.Name = "rooms_importBtn";
            rooms_importBtn.Size = new Size(124, 29);
            rooms_importBtn.TabIndex = 3;
            rooms_importBtn.Text = "Import";
            rooms_importBtn.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(824, 36);
            panel3.Name = "panel3";
            panel3.Size = new Size(124, 129);
            panel3.TabIndex = 34;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 129);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // rooms_status
            // 
            rooms_status.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rooms_status.FormattingEnabled = true;
            rooms_status.Items.AddRange(new object[] { "Active", "Inactive", "Occupied" });
            rooms_status.Location = new Point(472, 85);
            rooms_status.Name = "rooms_status";
            rooms_status.Size = new Size(143, 28);
            rooms_status.TabIndex = 33;
            rooms_status.SelectedIndexChanged += rooms_status_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(394, 91);
            label6.Name = "label6";
            label6.Size = new Size(54, 18);
            label6.TabIndex = 32;
            label6.Text = "Status:";
            // 
            // rooms_price
            // 
            rooms_price.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rooms_price.Location = new Point(472, 36);
            rooms_price.Name = "rooms_price";
            rooms_price.Size = new Size(143, 26);
            rooms_price.TabIndex = 30;
            rooms_price.TextChanged += rooms_price_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(375, 42);
            label4.Name = "label4";
            label4.Size = new Size(68, 18);
            label4.TabIndex = 31;
            label4.Text = "Price ($):";
            // 
            // rooms_roomName
            // 
            rooms_roomName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rooms_roomName.Location = new Point(163, 36);
            rooms_roomName.Name = "rooms_roomName";
            rooms_roomName.Size = new Size(143, 26);
            rooms_roomName.TabIndex = 28;
            rooms_roomName.TextChanged += rooms_roomName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 42);
            label3.Name = "label3";
            label3.Size = new Size(98, 18);
            label3.TabIndex = 29;
            label3.Text = "Room Name:";
            // 
            // rooms_type
            // 
            rooms_type.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rooms_type.FormattingEnabled = true;
            rooms_type.Items.AddRange(new object[] { "Single room", "Double room", "Triple room" });
            rooms_type.Location = new Point(163, 85);
            rooms_type.Name = "rooms_type";
            rooms_type.Size = new Size(143, 28);
            rooms_type.TabIndex = 27;
            rooms_type.SelectedIndexChanged += rooms_type_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(98, 91);
            label2.Name = "label2";
            label2.Size = new Size(44, 18);
            label2.TabIndex = 26;
            label2.Text = "Type:";
            // 
            // admin_rooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "admin_rooms";
            Size = new Size(1010, 714);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MainGrid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DataGridView MainGrid;
        private Label label5;
        private ComboBox rooms_status;
        private Label label6;
        private TextBox rooms_price;
        private Label label4;
        private System.Windows.Forms.TextBox rooms_roomName;
        private System.Windows.Forms.Label label3;
        private ComboBox rooms_type;
        private Label label2;
        private RoundedButton rooms_importBtn;
        private Panel panel3;
        private PictureBox pictureBox1;
        private RoundedButton rooms_addBtn;
        private RoundedButton rooms_editBtn;
        private RoundedButton rooms_clearBtn;
        private RoundedButton rooms_deleteBtn;
    }
}
