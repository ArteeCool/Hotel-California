namespace HotelCalifornia
{
    partial class admin_customers
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
            panel2 = new Panel();
            label3 = new Label();
            MainGrid = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainGrid).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(MainGrid);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(13, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(980, 681);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 16);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 25;
            label3.Text = "All Customers";
            // 
            // MainGrid
            // 
            MainGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MainGrid.Location = new Point(19, 54);
            MainGrid.Name = "MainGrid";
            MainGrid.RowHeadersWidth = 51;
            MainGrid.Size = new Size(944, 607);
            MainGrid.TabIndex = 26;
            MainGrid.CellContentClick += MainGrid_CellContentClick;
            // 
            // admin_customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "admin_customers";
            Size = new Size(1010, 714);
            MouseDown += Admin_Customers_MouseDown;
            MouseMove += Admin_Customers_MouseMove;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MainGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label3;
        private DataGridView MainGrid;
    }
}
