namespace HotelCalifornia
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            register_showPassword = new CheckBox();
            register_btn = new RoundedButton();
            register_password = new TextBox();
            label4 = new Label();
            register_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            close = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            register_signinBtn = new RoundedButton();
            label6 = new Label();
            label5 = new Label();
            register_confirmPassword = new TextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // register_showPassword
            // 
            register_showPassword.AutoSize = true;
            register_showPassword.Cursor = Cursors.Hand;
            register_showPassword.Location = new Point(438, 420);
            register_showPassword.Margin = new Padding(3, 4, 3, 4);
            register_showPassword.Name = "register_showPassword";
            register_showPassword.Size = new Size(134, 24);
            register_showPassword.TabIndex = 21;
            register_showPassword.Text = "Show password";
            register_showPassword.UseVisualStyleBackColor = true;
            register_showPassword.CheckedChanged += register_showPassword_CheckedChanged;
            // 
            // register_btn
            // 
            register_btn.BackColor = Color.FromArgb(255, 242, 204);
            register_btn.Cursor = Cursors.Hand;
            register_btn.FlatAppearance.BorderColor = SystemColors.GradientInactiveCaption;
            register_btn.FlatAppearance.BorderSize = 0;
            register_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(237, 201, 175);
            register_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 201, 175);
            register_btn.FlatStyle = FlatStyle.Flat;
            register_btn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_btn.ForeColor = Color.FromArgb(216, 59, 113);
            register_btn.Location = new Point(472, 488);
            register_btn.Margin = new Padding(3, 4, 3, 4);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(217, 53);
            register_btn.TabIndex = 20;
            register_btn.Text = "Sign up";
            register_btn.UseVisualStyleBackColor = false;
            register_btn.Click += register_btn_Click;
            // 
            // register_password
            // 
            register_password.Cursor = Cursors.IBeam;
            register_password.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            register_password.Location = new Point(438, 284);
            register_password.Margin = new Padding(3, 4, 3, 4);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(286, 30);
            register_password.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(438, 252);
            label4.Name = "label4";
            label4.Size = new Size(75, 18);
            label4.TabIndex = 18;
            label4.Text = "Password";
            // 
            // register_username
            // 
            register_username.Cursor = Cursors.IBeam;
            register_username.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            register_username.Location = new Point(438, 197);
            register_username.Margin = new Padding(3, 4, 3, 4);
            register_username.Name = "register_username";
            register_username.Size = new Size(286, 30);
            register_username.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(438, 165);
            label3.Name = "label3";
            label3.Size = new Size(77, 18);
            label3.TabIndex = 16;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(438, 87);
            label2.Name = "label2";
            label2.Size = new Size(142, 29);
            label2.TabIndex = 15;
            label2.Text = "Registration";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Cursor = Cursors.Hand;
            close.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            close.Location = new Point(726, 12);
            close.Name = "close";
            close.Size = new Size(20, 20);
            close.TabIndex = 13;
            close.Text = "X";
            close.TextAlign = ContentAlignment.MiddleCenter;
            close.Click += close_Click;
            close.MouseEnter += close_MouseEnter;
            close.MouseLeave += close_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 242, 204);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(register_signinBtn);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(381, 608);
            panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(80, 75);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 200);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // register_signinBtn
            // 
            register_signinBtn.BackColor = Color.FromArgb(255, 242, 204);
            register_signinBtn.Cursor = Cursors.Hand;
            register_signinBtn.FlatAppearance.BorderColor = Color.FromArgb(216, 59, 113);
            register_signinBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(237, 201, 175);
            register_signinBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 201, 175);
            register_signinBtn.FlatStyle = FlatStyle.Flat;
            register_signinBtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_signinBtn.ForeColor = Color.FromArgb(216, 59, 113);
            register_signinBtn.Location = new Point(14, 539);
            register_signinBtn.Margin = new Padding(3, 4, 3, 4);
            register_signinBtn.Name = "register_signinBtn";
            register_signinBtn.Size = new Size(347, 53);
            register_signinBtn.TabIndex = 11;
            register_signinBtn.Text = "Sign in";
            register_signinBtn.UseVisualStyleBackColor = false;
            register_signinBtn.Click += register_signinBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(216, 59, 113);
            label6.Location = new Point(80, 488);
            label6.Name = "label6";
            label6.Size = new Size(189, 25);
            label6.TabIndex = 10;
            label6.Text = "Sign in your account";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(216, 59, 113);
            label5.Location = new Point(115, 287);
            label5.Name = "label5";
            label5.Size = new Size(184, 29);
            label5.TabIndex = 9;
            label5.Text = "Hotel California ";
            // 
            // register_confirmPassword
            // 
            register_confirmPassword.Cursor = Cursors.IBeam;
            register_confirmPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            register_confirmPassword.Location = new Point(438, 372);
            register_confirmPassword.Margin = new Padding(3, 4, 3, 4);
            register_confirmPassword.Name = "register_confirmPassword";
            register_confirmPassword.PasswordChar = '*';
            register_confirmPassword.Size = new Size(286, 30);
            register_confirmPassword.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(438, 340);
            label7.Name = "label7";
            label7.Size = new Size(130, 18);
            label7.TabIndex = 22;
            label7.Text = "Confirm password";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(762, 608);
            Controls.Add(close);
            Controls.Add(register_btn);
            Controls.Add(register_confirmPassword);
            Controls.Add(label7);
            Controls.Add(register_showPassword);
            Controls.Add(register_password);
            Controls.Add(label4);
            Controls.Add(register_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrationForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox register_showPassword;
        private RoundedButton register_btn;
        private TextBox register_password;
        private Label label4;
        private System.Windows.Forms.TextBox register_username;
        private Label label3;
        private Label label2;
        private Label close;
        private Panel panel1;
        private RoundedButton register_signinBtn;
        private Label label6;
        private System.Windows.Forms.Label label5;
        private TextBox register_confirmPassword;
        private Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}