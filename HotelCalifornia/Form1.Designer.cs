namespace HotelCalifornia;

partial class Form1
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
        AddButton = new System.Windows.Forms.Button();
        EditButton = new System.Windows.Forms.Button();
        RemoveButton = new System.Windows.Forms.Button();
        PublisherBox = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        CostBox = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        RoomsCountBox = new System.Windows.Forms.TextBox();
        RoomNumberBox = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        MainGrid = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)MainGrid).BeginInit();
        SuspendLayout();
        // 
        // AddButton
        // 
        AddButton.Location = new System.Drawing.Point(13, 263);
        AddButton.Name = "AddButton";
        AddButton.Size = new System.Drawing.Size(75, 23);
        AddButton.TabIndex = 0;
        AddButton.Text = "Add";
        AddButton.UseVisualStyleBackColor = true;
        AddButton.Click += AddButton_Click;
        // 
        // EditButton
        // 
        EditButton.Location = new System.Drawing.Point(13, 292);
        EditButton.Name = "EditButton";
        EditButton.Size = new System.Drawing.Size(75, 23);
        EditButton.TabIndex = 1;
        EditButton.Text = "Edit";
        EditButton.UseVisualStyleBackColor = true;
        EditButton.Click += EditButton_Click;
        // 
        // RemoveButton
        // 
        RemoveButton.Location = new System.Drawing.Point(13, 321);
        RemoveButton.Name = "RemoveButton";
        RemoveButton.Size = new System.Drawing.Size(75, 23);
        RemoveButton.TabIndex = 2;
        RemoveButton.Text = "Remove";
        RemoveButton.UseVisualStyleBackColor = true;
        RemoveButton.Click += RemoveButton_Click;
        // 
        // PublisherBox
        // 
        PublisherBox.Location = new System.Drawing.Point(13, 234);
        PublisherBox.Name = "PublisherBox";
        PublisherBox.Size = new System.Drawing.Size(100, 23);
        PublisherBox.TabIndex = 3;
        PublisherBox.TextChanged += textBox1_TextChanged;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(13, 170);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 16);
        label2.TabIndex = 9;
        label2.Text = "Cost";
        // 
        // CostBox
        // 
        CostBox.Location = new System.Drawing.Point(13, 189);
        CostBox.Name = "CostBox";
        CostBox.Size = new System.Drawing.Size(100, 23);
        CostBox.TabIndex = 8;
        CostBox.TextChanged += CostBox_TextChanged;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(13, 125);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 16);
        label3.TabIndex = 11;
        label3.Text = "Rooms count";
        // 
        // RoomsCountBox
        // 
        RoomsCountBox.Location = new System.Drawing.Point(13, 144);
        RoomsCountBox.Name = "RoomsCountBox";
        RoomsCountBox.Size = new System.Drawing.Size(100, 23);
        RoomsCountBox.TabIndex = 10;
        RoomsCountBox.TextChanged += RoomsCountBox_TextChanged;
        // 
        // RoomNumberBox
        // 
        RoomNumberBox.Location = new System.Drawing.Point(13, 99);
        RoomNumberBox.Name = "RoomNumberBox";
        RoomNumberBox.Size = new System.Drawing.Size(100, 23);
        RoomNumberBox.TabIndex = 12;
        RoomNumberBox.TextChanged += RoomNumber_TextChanged;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(13, 80);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 16);
        label1.TabIndex = 13;
        label1.Text = "Room number";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(13, 215);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(100, 16);
        label4.TabIndex = 14;
        label4.Text = "Your name";
        // 
        // MainGrid
        // 
        MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        MainGrid.Location = new System.Drawing.Point(199, 6);
        MainGrid.Name = "MainGrid";
        MainGrid.Size = new System.Drawing.Size(594, 436);
        MainGrid.TabIndex = 15;
        MainGrid.Text = "dataGridView1";
        MainGrid.CellContentClick += MainGrid_CellContentClick;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(MainGrid);
        Controls.Add(label4);
        Controls.Add(label1);
        Controls.Add(RoomNumberBox);
        Controls.Add(label3);
        Controls.Add(RoomsCountBox);
        Controls.Add(label2);
        Controls.Add(CostBox);
        Controls.Add(PublisherBox);
        Controls.Add(RemoveButton);
        Controls.Add(EditButton);
        Controls.Add(AddButton);
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)MainGrid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.DataGridView MainGrid;

    private System.Windows.Forms.Button RemoveButton;

    private System.Windows.Forms.Button EditButton;

    private System.Windows.Forms.Button AddButton;

    private System.Windows.Forms.TextBox PublisherBox;

    private System.Windows.Forms.TextBox CostBox;

    private System.Windows.Forms.TextBox RoomsCountBox;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox RoomNumberBox;

    #endregion
}