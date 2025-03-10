namespace Hotel_Management
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            AddRoom = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            nameTextBox = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            roomCost = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            roomsCount = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            roomNumber = new System.Windows.Forms.TextBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            button1 = new System.Windows.Forms.Button();
            removeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // AddRoom
            // 
            AddRoom.Location = new System.Drawing.Point(12, 194);
            AddRoom.Name = "AddRoom";
            AddRoom.Size = new System.Drawing.Size(98, 40);
            AddRoom.TabIndex = 0;
            AddRoom.Text = "Add";
            AddRoom.UseVisualStyleBackColor = true;
            AddRoom.Click += AddRoom_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(12, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(132, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // nameTextBox
            // 
            nameTextBox.AutoSize = true;
            nameTextBox.Location = new System.Drawing.Point(12, 147);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new System.Drawing.Size(64, 15);
            nameTextBox.TabIndex = 2;
            nameTextBox.Text = "Your name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 100);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "Cost";
            // 
            // roomCost
            // 
            roomCost.Location = new System.Drawing.Point(12, 118);
            roomCost.Name = "roomCost";
            roomCost.Size = new System.Drawing.Size(132, 23);
            roomCost.TabIndex = 3;
            roomCost.TextChanged += roomCost_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 53);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 15);
            label1.TabIndex = 6;
            label1.Text = "Rooms count";
            // 
            // roomsCount
            // 
            roomsCount.Location = new System.Drawing.Point(12, 71);
            roomsCount.Name = "roomsCount";
            roomsCount.Size = new System.Drawing.Size(132, 23);
            roomsCount.TabIndex = 5;
            roomsCount.TextChanged += roomsCount_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(84, 15);
            label3.TabIndex = 8;
            label3.Text = "Room number";
            // 
            // roomNumber
            // 
            roomNumber.Location = new System.Drawing.Point(12, 27);
            roomNumber.Name = "roomNumber";
            roomNumber.Size = new System.Drawing.Size(132, 23);
            roomNumber.TabIndex = 7;
            roomNumber.TextChanged += roomNumber_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(189, 27);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new System.Drawing.Size(1045, 563);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(137, 400);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(8, 8);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            removeButton.Location = new System.Drawing.Point(85, 296);
            removeButton.Name = "removeButton";
            removeButton.Size = new System.Drawing.Size(98, 40);
            removeButton.TabIndex = 11;
            removeButton.Text = "Remove selected";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1302, 782);
            Controls.Add(removeButton);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(roomNumber);
            Controls.Add(label1);
            Controls.Add(roomsCount);
            Controls.Add(label2);
            Controls.Add(roomCost);
            Controls.Add(nameTextBox);
            Controls.Add(textBox1);
            Controls.Add(AddRoom);
            Text = "Hotel Management";
            Load += HotelManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button removeButton;

        #endregion

        private Button AddRoom;
        private TextBox textBox1;
        private Label nameTextBox;
        private Label label2;
        private TextBox roomCost;
        private Label label1;
        private TextBox roomsCount;
        private Label label3;
        private TextBox roomNumber;
        private DataGridView dataGridView1;
    }
}
