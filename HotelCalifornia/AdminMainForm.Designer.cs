namespace HotelCalifornia
{
    partial class AdminMainForm
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
            panel1 = new Panel();
            label11 = new Label();
            label1 = new Label();
            close = new Label();
            panel2 = new Panel();
            admin_addUserBtn = new Button();
            pictureBox1 = new PictureBox();
            admin_logoutBtn = new RoundedButton();
            admin_customersBtn = new Button();
            admin_roomsBtn = new Button();
            admin_dashboardBtn = new Button();
            label5 = new Label();
            panel3 = new Panel();
            admin_rooms1 = new admin_rooms();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            label6 = new Label();
            panel8 = new Panel();
            pictureBox4 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            panel9 = new Panel();
            pictureBox5 = new PictureBox();
            label9 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(237, 201, 175);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1268, 41);
            panel1.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Purple;
            label11.Location = new Point(1168, 9);
            label11.Name = "label11";
            label11.Size = new Size(66, 21);
            label11.TabIndex = 4;
            label11.Text = "Admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 23);
            label1.TabIndex = 2;
            label1.Text = "Hotel California";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Cursor = Cursors.Hand;
            close.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.ForeColor = Color.Purple;
            close.Location = new Point(1240, 8);
            close.Name = "close";
            close.Size = new Size(22, 23);
            close.TabIndex = 1;
            close.Text = "X";
            close.Click += close_Click;
            close.MouseEnter += close_MouseEnter;
            close.MouseLeave += close_MouseLeave;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 242, 204);
            panel2.Controls.Add(admin_addUserBtn);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(admin_logoutBtn);
            panel2.Controls.Add(admin_customersBtn);
            panel2.Controls.Add(admin_roomsBtn);
            panel2.Controls.Add(admin_dashboardBtn);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 714);
            panel2.TabIndex = 1;
            // 
            // admin_addUserBtn
            // 
            admin_addUserBtn.BackColor = Color.FromArgb(255, 242, 204);
            admin_addUserBtn.Cursor = Cursors.Hand;
            admin_addUserBtn.FlatAppearance.BorderColor = SystemColors.GradientInactiveCaption;
            admin_addUserBtn.FlatAppearance.BorderSize = 0;
            admin_addUserBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(237, 201, 175);
            admin_addUserBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 201, 175);
            admin_addUserBtn.FlatStyle = FlatStyle.Flat;
            admin_addUserBtn.Font = new Font("Arial Rounded MT Bold", 13.8F);
            admin_addUserBtn.ForeColor = Color.Purple;
            admin_addUserBtn.Location = new Point(27, 300);
            admin_addUserBtn.Name = "admin_addUserBtn";
            admin_addUserBtn.Size = new Size(182, 37);
            admin_addUserBtn.TabIndex = 19;
            admin_addUserBtn.Text = "Add User";
            admin_addUserBtn.UseVisualStyleBackColor = false;
            admin_addUserBtn.Click += admin_addUserBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.photo_2025_03_15_13_57_30__1___3__removebg_preview;
            pictureBox1.Location = new Point(19, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 149);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // admin_logoutBtn
            // 
            admin_logoutBtn.BackColor = Color.FromArgb(255, 242, 204);
            admin_logoutBtn.Cursor = Cursors.Hand;
            admin_logoutBtn.FlatAppearance.BorderColor = Color.FromArgb(216, 59, 113);
            admin_logoutBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(237, 201, 175);
            admin_logoutBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 201, 175);
            admin_logoutBtn.FlatStyle = FlatStyle.Flat;
            admin_logoutBtn.Font = new Font("Arial Rounded MT Bold", 13.8F);
            admin_logoutBtn.ForeColor = Color.Purple;
            admin_logoutBtn.Location = new Point(27, 653);
            admin_logoutBtn.Name = "admin_logoutBtn";
            admin_logoutBtn.Size = new Size(182, 37);
            admin_logoutBtn.TabIndex = 15;
            admin_logoutBtn.Text = "Logout";
            admin_logoutBtn.UseVisualStyleBackColor = false;
            admin_logoutBtn.Click += admin_logoutBtn_Click;
            // 
            // admin_customersBtn
            // 
            admin_customersBtn.BackColor = Color.FromArgb(255, 242, 204);
            admin_customersBtn.Cursor = Cursors.Hand;
            admin_customersBtn.FlatAppearance.BorderColor = SystemColors.GradientInactiveCaption;
            admin_customersBtn.FlatAppearance.BorderSize = 0;
            admin_customersBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(237, 201, 175);
            admin_customersBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 201, 175);
            admin_customersBtn.FlatStyle = FlatStyle.Flat;
            admin_customersBtn.Font = new Font("Arial Rounded MT Bold", 13.8F);
            admin_customersBtn.ForeColor = Color.Purple;
            admin_customersBtn.Location = new Point(27, 371);
            admin_customersBtn.Name = "admin_customersBtn";
            admin_customersBtn.Size = new Size(182, 37);
            admin_customersBtn.TabIndex = 13;
            admin_customersBtn.Text = "Customers";
            admin_customersBtn.UseVisualStyleBackColor = false;
            admin_customersBtn.Click += admin_customersBtn_Click;
            // 
            // admin_roomsBtn
            // 
            admin_roomsBtn.BackColor = Color.FromArgb(255, 242, 204);
            admin_roomsBtn.Cursor = Cursors.Hand;
            admin_roomsBtn.FlatAppearance.BorderColor = SystemColors.GradientInactiveCaption;
            admin_roomsBtn.FlatAppearance.BorderSize = 0;
            admin_roomsBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(237, 201, 175);
            admin_roomsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 201, 175);
            admin_roomsBtn.FlatStyle = FlatStyle.Flat;
            admin_roomsBtn.Font = new Font("Arial Rounded MT Bold", 13.8F);
            admin_roomsBtn.ForeColor = Color.Purple;
            admin_roomsBtn.Location = new Point(27, 440);
            admin_roomsBtn.Name = "admin_roomsBtn";
            admin_roomsBtn.Size = new Size(182, 37);
            admin_roomsBtn.TabIndex = 12;
            admin_roomsBtn.Text = "Rooms";
            admin_roomsBtn.UseVisualStyleBackColor = false;
            admin_roomsBtn.Click += admin_roomsBtn_Click;
            // 
            // admin_dashboardBtn
            // 
            admin_dashboardBtn.BackColor = Color.FromArgb(255, 242, 204);
            admin_dashboardBtn.Cursor = Cursors.Hand;
            admin_dashboardBtn.FlatAppearance.BorderColor = SystemColors.GradientInactiveCaption;
            admin_dashboardBtn.FlatAppearance.BorderSize = 0;
            admin_dashboardBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(237, 201, 175);
            admin_dashboardBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 201, 175);
            admin_dashboardBtn.FlatStyle = FlatStyle.Flat;
            admin_dashboardBtn.Font = new Font("Arial Rounded MT Bold", 13.8F);
            admin_dashboardBtn.ForeColor = Color.Purple;
            admin_dashboardBtn.Location = new Point(27, 229);
            admin_dashboardBtn.Name = "admin_dashboardBtn";
            admin_dashboardBtn.Size = new Size(182, 37);
            admin_dashboardBtn.TabIndex = 5;
            admin_dashboardBtn.Text = "Dashboard";
            admin_dashboardBtn.UseVisualStyleBackColor = false;
            admin_dashboardBtn.Click += admin_dashboardBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(216, 59, 113);
            label5.Location = new Point(27, 159);
            label5.Name = "label5";
            label5.Size = new Size(182, 27);
            label5.TabIndex = 11;
            label5.Text = "Welcome, User";
            // 
            // panel3
            // 
            panel3.Controls.Add(admin_rooms1);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(250, 41);
            panel3.Name = "panel3";
            panel3.Size = new Size(1018, 714);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint_1;
            // 
            // admin_rooms1
            // 
            admin_rooms1.Location = new Point(0, 0);
            admin_rooms1.Name = "admin_rooms1";
            admin_rooms1.Size = new Size(1018, 714);
            admin_rooms1.TabIndex = 15;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(6, 249);
            panel7.Name = "panel7";
            panel7.Size = new Size(962, 451);
            panel7.TabIndex = 14;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(panel5);
            panel6.Controls.Add(panel4);
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(panel9);
            panel6.Location = new Point(6, 24);
            panel6.Name = "panel6";
            panel6.Size = new Size(962, 199);
            panel6.TabIndex = 13;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 242, 204);
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(25, 29);
            panel5.Name = "panel5";
            panel5.Size = new Size(179, 141);
            panel5.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_hotel_staff_60;
            pictureBox2.Location = new Point(21, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 60);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(21, 105);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 14;
            label2.Text = "Total Staff";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(139, 20);
            label3.Name = "label3";
            label3.Size = new Size(23, 25);
            label3.TabIndex = 15;
            label3.Text = "0";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 242, 204);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(270, 29);
            panel4.Name = "panel4";
            panel4.Size = new Size(179, 141);
            panel4.TabIndex = 7;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_hotel_room_60;
            pictureBox3.Location = new Point(21, 20);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(59, 60);
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Purple;
            label4.Location = new Point(5, 105);
            label4.Name = "label4";
            label4.Size = new Size(158, 25);
            label4.TabIndex = 16;
            label4.Text = "Available Rooms";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Purple;
            label6.Location = new Point(139, 20);
            label6.Name = "label6";
            label6.Size = new Size(23, 25);
            label6.TabIndex = 17;
            label6.Text = "0";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(255, 242, 204);
            panel8.Controls.Add(pictureBox4);
            panel8.Controls.Add(label7);
            panel8.Controls.Add(label8);
            panel8.Location = new Point(513, 29);
            panel8.Name = "panel8";
            panel8.Size = new Size(179, 141);
            panel8.TabIndex = 6;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_income_60;
            pictureBox4.Location = new Point(21, 20);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(59, 60);
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Purple;
            label7.Location = new Point(21, 105);
            label7.Name = "label7";
            label7.Size = new Size(131, 25);
            label7.TabIndex = 18;
            label7.Text = "Today's Profit";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Purple;
            label8.Location = new Point(120, 20);
            label8.Name = "label8";
            label8.Size = new Size(50, 25);
            label8.TabIndex = 19;
            label8.Text = "$0.0";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(255, 242, 204);
            panel9.Controls.Add(pictureBox5);
            panel9.Controls.Add(label9);
            panel9.Controls.Add(label10);
            panel9.Location = new Point(759, 29);
            panel9.Name = "panel9";
            panel9.Size = new Size(179, 141);
            panel9.TabIndex = 5;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.icons8_bag_of_money_60;
            pictureBox5.Location = new Point(21, 20);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(59, 60);
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Purple;
            label9.Location = new Point(21, 105);
            label9.Name = "label9";
            label9.Size = new Size(105, 25);
            label9.TabIndex = 20;
            label9.Text = "Total Profit";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Purple;
            label10.Location = new Point(120, 20);
            label10.Name = "label10";
            label10.Size = new Size(50, 25);
            label10.TabIndex = 21;
            label10.Text = "$0.0";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 755);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMainForm";
            MouseDown += AdminMainForm_MouseDown;
            MouseMove += AdminMainForm_MouseMove;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label close;
        private Label label1;
        private Panel panel2;
        private Label label5;
        private Button admin_dashboardBtn;
        private RoundedButton admin_logoutBtn;
        private Button admin_customersBtn;
        private Button admin_roomsBtn;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Panel panel4;
        private PictureBox pictureBox3;
        private Label label4;
        private Label label6;
        private Panel panel8;
        private PictureBox pictureBox4;
        private Label label7;
        private Label label8;
        private Panel panel9;
        private PictureBox pictureBox5;
        private Label label9;
        private Label label10;
        private Button admin_addUserBtn;
        private Label label11;
        private admin_rooms admin_rooms1;
    }
}