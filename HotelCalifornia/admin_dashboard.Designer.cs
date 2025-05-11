namespace HotelCalifornia
{
    partial class admin_dashboard
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
            panel7 = new Panel();
            label1 = new Label();
            MainGrid = new DataGridView();
            panel6 = new Panel();
            panel5 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            totalStaff = new Label();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            availableRooms = new Label();
            panel8 = new Panel();
            pictureBox4 = new PictureBox();
            label7 = new Label();
            todaysProfit = new Label();
            panel9 = new Panel();
            pictureBox5 = new PictureBox();
            label9 = new Label();
            totalProfit = new Label();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainGrid).BeginInit();
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
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(label1);
            panel7.Controls.Add(MainGrid);
            panel7.Location = new Point(24, 244);
            panel7.Name = "panel7";
            panel7.Size = new Size(962, 450);
            panel7.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 16);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 26;
            label1.Text = "All Rooms";
            // 
            // MainGrid
            // 
            MainGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MainGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MainGrid.Location = new Point(25, 59);
            MainGrid.Name = "MainGrid";
            MainGrid.RowHeadersWidth = 51;
            MainGrid.Size = new Size(922, 372);
            MainGrid.TabIndex = 27;
            MainGrid.CellContentClick += MainGrid_CellContentClick;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(panel5);
            panel6.Controls.Add(panel4);
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(panel9);
            panel6.Location = new Point(24, 19);
            panel6.Name = "panel6";
            panel6.Size = new Size(962, 199);
            panel6.TabIndex = 15;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 242, 204);
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(totalStaff);
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
            // totalStaff
            // 
            totalStaff.AutoSize = true;
            totalStaff.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalStaff.ForeColor = Color.Purple;
            totalStaff.Location = new Point(139, 20);
            totalStaff.Name = "totalStaff";
            totalStaff.Size = new Size(23, 25);
            totalStaff.TabIndex = 15;
            totalStaff.Text = "0";
            totalStaff.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 242, 204);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(availableRooms);
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
            // availableRooms
            // 
            availableRooms.AutoSize = true;
            availableRooms.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            availableRooms.ForeColor = Color.Purple;
            availableRooms.Location = new Point(139, 20);
            availableRooms.Name = "availableRooms";
            availableRooms.Size = new Size(23, 25);
            availableRooms.TabIndex = 17;
            availableRooms.Text = "0";
            availableRooms.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(255, 242, 204);
            panel8.Controls.Add(pictureBox4);
            panel8.Controls.Add(label7);
            panel8.Controls.Add(todaysProfit);
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
            // todaysProfit
            // 
            todaysProfit.AutoSize = true;
            todaysProfit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            todaysProfit.ForeColor = Color.Purple;
            todaysProfit.Location = new Point(120, 20);
            todaysProfit.Name = "todaysProfit";
            todaysProfit.Size = new Size(50, 25);
            todaysProfit.TabIndex = 19;
            todaysProfit.Text = "$0.0";
            todaysProfit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(255, 242, 204);
            panel9.Controls.Add(pictureBox5);
            panel9.Controls.Add(label9);
            panel9.Controls.Add(totalProfit);
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
            // totalProfit
            // 
            totalProfit.AutoSize = true;
            totalProfit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalProfit.ForeColor = Color.Purple;
            totalProfit.Location = new Point(120, 20);
            totalProfit.Name = "totalProfit";
            totalProfit.Size = new Size(50, 25);
            totalProfit.TabIndex = 21;
            totalProfit.Text = "$0.0";
            totalProfit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // admin_dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel7);
            Controls.Add(panel6);
            Name = "admin_dashboard";
            Size = new Size(1010, 714);
            MouseDown += Admin_Dashboard_MouseDown;
            MouseMove += Admin_Dashboard_MouseMove;
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MainGrid).EndInit();
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

        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private PictureBox pictureBox2;
        private Label label2;
        private Label totalStaff;
        private Panel panel4;
        private PictureBox pictureBox3;
        private Label label4;
        private Label availableRooms;
        private Panel panel8;
        private PictureBox pictureBox4;
        private Label label7;
        private Label todaysProfit;
        private Panel panel9;
        private PictureBox pictureBox5;
        private Label label9;
        private Label totalProfit;
        private DataGridView MainGrid;
        private Label label1;
    }
}
