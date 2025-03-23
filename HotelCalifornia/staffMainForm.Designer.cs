namespace HotelCalifornia
{
    partial class staffMainForm
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
            label3 = new Label();
            label1 = new Label();
            close = new Label();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            button5 = new RoundedButton();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            panel2 = new Panel();
            staff_bookRoomBtn = new Button();
            pictureBox2 = new PictureBox();
            staff_logoutBtn = new RoundedButton();
            staff_customersBtn = new Button();
            staff_roomsBtn = new Button();
            staff_dashboardBtn = new Button();
            label2 = new Label();
            panel3 = new Panel();
            staff_bookRoom1 = new staff_bookRoom();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(237, 201, 175);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1268, 41);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(1181, 11);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 3;
            label3.Text = "Staff";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(12, 9);
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
            close.Location = new Point(1238, 9);
            close.Name = "close";
            close.Size = new Size(22, 23);
            close.TabIndex = 1;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 242, 204);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = SystemColors.GradientInactiveCaption;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(237, 201, 175);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 201, 175);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Purple;
            button4.Location = new Point(9, 341);
            button4.Name = "button4";
            button4.Size = new Size(182, 37);
            button4.TabIndex = 26;
            button4.Text = "Add User";
            button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.photo_2025_03_15_13_57_30__1___3__removebg_preview;
            pictureBox1.Location = new Point(0, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 150);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 242, 204);
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = Color.FromArgb(216, 59, 113);
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(237, 201, 175);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 201, 175);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Purple;
            button5.Location = new Point(9, 692);
            button5.Name = "button5";
            button5.Size = new Size(182, 37);
            button5.TabIndex = 24;
            button5.Text = "Logout";
            button5.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 242, 204);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = SystemColors.GradientInactiveCaption;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(237, 201, 175);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 201, 175);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Purple;
            button3.Location = new Point(9, 411);
            button3.Name = "button3";
            button3.Size = new Size(182, 37);
            button3.TabIndex = 23;
            button3.Text = "Customers";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 242, 204);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = SystemColors.GradientInactiveCaption;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(237, 201, 175);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 201, 175);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Purple;
            button2.Location = new Point(9, 481);
            button2.Name = "button2";
            button2.Size = new Size(182, 37);
            button2.TabIndex = 22;
            button2.Text = "Rooms";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 242, 204);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = SystemColors.GradientInactiveCaption;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(237, 201, 175);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 201, 175);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Purple;
            button1.Location = new Point(9, 271);
            button1.Name = "button1";
            button1.Size = new Size(182, 37);
            button1.TabIndex = 20;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(216, 59, 113);
            label5.Location = new Point(9, 200);
            label5.Name = "label5";
            label5.Size = new Size(182, 27);
            label5.TabIndex = 21;
            label5.Text = "Welcome, User";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 242, 204);
            panel2.Controls.Add(staff_bookRoomBtn);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(staff_logoutBtn);
            panel2.Controls.Add(staff_customersBtn);
            panel2.Controls.Add(staff_roomsBtn);
            panel2.Controls.Add(staff_dashboardBtn);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 714);
            panel2.TabIndex = 27;
            // 
            // staff_bookRoomBtn
            // 
            staff_bookRoomBtn.BackColor = Color.FromArgb(255, 242, 204);
            staff_bookRoomBtn.Cursor = Cursors.Hand;
            staff_bookRoomBtn.FlatAppearance.BorderColor = SystemColors.GradientInactiveCaption;
            staff_bookRoomBtn.FlatAppearance.BorderSize = 0;
            staff_bookRoomBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(237, 201, 175);
            staff_bookRoomBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 201, 175);
            staff_bookRoomBtn.FlatStyle = FlatStyle.Flat;
            staff_bookRoomBtn.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            staff_bookRoomBtn.ForeColor = Color.Purple;
            staff_bookRoomBtn.Location = new Point(28, 300);
            staff_bookRoomBtn.Name = "staff_bookRoomBtn";
            staff_bookRoomBtn.Size = new Size(182, 37);
            staff_bookRoomBtn.TabIndex = 19;
            staff_bookRoomBtn.Text = "Book Room";
            staff_bookRoomBtn.UseVisualStyleBackColor = false;
            staff_bookRoomBtn.Click += staff_bookRoomBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.photo_2025_03_15_13_57_30__1___3__removebg_preview;
            pictureBox2.Location = new Point(19, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 150);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // staff_logoutBtn
            // 
            staff_logoutBtn.BackColor = Color.FromArgb(255, 242, 204);
            staff_logoutBtn.Cursor = Cursors.Hand;
            staff_logoutBtn.FlatAppearance.BorderColor = Color.FromArgb(216, 59, 113);
            staff_logoutBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(237, 201, 175);
            staff_logoutBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 201, 175);
            staff_logoutBtn.FlatStyle = FlatStyle.Flat;
            staff_logoutBtn.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            staff_logoutBtn.ForeColor = Color.Purple;
            staff_logoutBtn.Location = new Point(28, 651);
            staff_logoutBtn.Name = "staff_logoutBtn";
            staff_logoutBtn.Size = new Size(182, 37);
            staff_logoutBtn.TabIndex = 15;
            staff_logoutBtn.Text = "Logout";
            staff_logoutBtn.UseVisualStyleBackColor = false;
            staff_logoutBtn.Click += staff_logoutBtn_Click;
            // 
            // staff_customersBtn
            // 
            staff_customersBtn.BackColor = Color.FromArgb(255, 242, 204);
            staff_customersBtn.Cursor = Cursors.Hand;
            staff_customersBtn.FlatAppearance.BorderColor = SystemColors.GradientInactiveCaption;
            staff_customersBtn.FlatAppearance.BorderSize = 0;
            staff_customersBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(237, 201, 175);
            staff_customersBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 201, 175);
            staff_customersBtn.FlatStyle = FlatStyle.Flat;
            staff_customersBtn.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            staff_customersBtn.ForeColor = Color.Purple;
            staff_customersBtn.Location = new Point(28, 370);
            staff_customersBtn.Name = "staff_customersBtn";
            staff_customersBtn.Size = new Size(182, 37);
            staff_customersBtn.TabIndex = 13;
            staff_customersBtn.Text = "Customers";
            staff_customersBtn.UseVisualStyleBackColor = false;
            staff_customersBtn.Click += staff_customersBtn_Click;
            // 
            // staff_roomsBtn
            // 
            staff_roomsBtn.BackColor = Color.FromArgb(255, 242, 204);
            staff_roomsBtn.Cursor = Cursors.Hand;
            staff_roomsBtn.FlatAppearance.BorderColor = SystemColors.GradientInactiveCaption;
            staff_roomsBtn.FlatAppearance.BorderSize = 0;
            staff_roomsBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(237, 201, 175);
            staff_roomsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 201, 175);
            staff_roomsBtn.FlatStyle = FlatStyle.Flat;
            staff_roomsBtn.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            staff_roomsBtn.ForeColor = Color.Purple;
            staff_roomsBtn.Location = new Point(19, 440);
            staff_roomsBtn.Name = "staff_roomsBtn";
            staff_roomsBtn.Size = new Size(207, 37);
            staff_roomsBtn.TabIndex = 12;
            staff_roomsBtn.Text = "Available Rooms";
            staff_roomsBtn.UseVisualStyleBackColor = false;
            staff_roomsBtn.Click += staff_roomsBtn_Click;
            // 
            // staff_dashboardBtn
            // 
            staff_dashboardBtn.BackColor = Color.FromArgb(255, 242, 204);
            staff_dashboardBtn.Cursor = Cursors.Hand;
            staff_dashboardBtn.FlatAppearance.BorderColor = SystemColors.GradientInactiveCaption;
            staff_dashboardBtn.FlatAppearance.BorderSize = 0;
            staff_dashboardBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(237, 201, 175);
            staff_dashboardBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 201, 175);
            staff_dashboardBtn.FlatStyle = FlatStyle.Flat;
            staff_dashboardBtn.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            staff_dashboardBtn.ForeColor = Color.Purple;
            staff_dashboardBtn.Location = new Point(28, 230);
            staff_dashboardBtn.Name = "staff_dashboardBtn";
            staff_dashboardBtn.Size = new Size(182, 37);
            staff_dashboardBtn.TabIndex = 5;
            staff_dashboardBtn.Text = "Dashboard";
            staff_dashboardBtn.UseVisualStyleBackColor = false;
            staff_dashboardBtn.Click += staff_dashboardBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(216, 59, 113);
            label2.Location = new Point(28, 159);
            label2.Name = "label2";
            label2.Size = new Size(182, 27);
            label2.TabIndex = 11;
            label2.Text = "Welcome, User";
            // 
            // panel3
            // 
            panel3.Controls.Add(staff_bookRoom1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(250, 41);
            panel3.Name = "panel3";
            panel3.Size = new Size(1018, 714);
            panel3.TabIndex = 28;
            // 
            // staff_bookRoom1
            // 
            staff_bookRoom1.Location = new Point(0, 0);
            staff_bookRoom1.Name = "staff_bookRoom1";
            staff_bookRoom1.Size = new Size(1018, 714);
            staff_bookRoom1.TabIndex = 0;
            // 
            // staffMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 755);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button4);
            Controls.Add(pictureBox1);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "staffMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "staffMainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label close;
        private Button button4;
        private PictureBox pictureBox1;
        private RoundedButton button5;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label5;
        private Panel panel2;
        private Button staff_bookRoomBtn;
        private PictureBox pictureBox2;
        private RoundedButton staff_logoutBtn;
        private Button staff_customersBtn;
        private Button staff_roomsBtn;
        private Button staff_dashboardBtn;
        private Label label2;
        private Panel panel3;
        private staff_bookRoom staff_bookRoom1;
        private Label label3;
    }
}