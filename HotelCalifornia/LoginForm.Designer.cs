
namespace HotelCali_Personal_NonGithubVersion
{
    partial class LoginForm
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            close = new Label();
            label5 = new Label();
            label6 = new Label();
            login_registerBtn = new RoundedButton();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            login_showPassword = new CheckBox();
            login_btn = new RoundedButton();
            login_password = new TextBox();
            password = new Label();
            login_username = new TextBox();
            Username = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // close
            // 
            close.AutoSize = true;
            close.Cursor = Cursors.Hand;
            close.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.Location = new Point(636, 9);
            close.Name = "close";
            close.Size = new Size(19, 20);
            close.TabIndex = 0;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(216, 59, 113);
            label5.Location = new Point(78, 219);
            label5.Name = "label5";
            label5.Size = new Size(192, 27);
            label5.TabIndex = 9;
            label5.Text = "Hotel California ";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(216, 59, 113);
            label6.Location = new Point(70, 366);
            label6.Name = "label6";
            label6.Size = new Size(206, 23);
            label6.TabIndex = 10;
            label6.Text = "Create new account";
            label6.Click += label6_Click;
            // 
            // login_registerBtn
            // 
            login_registerBtn.BackColor = Color.FromArgb(255, 242, 204);
            login_registerBtn.Cursor = Cursors.Hand;
            login_registerBtn.FlatAppearance.BorderColor = Color.FromArgb(216, 59, 113);
            login_registerBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(237, 201, 175);
            login_registerBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 201, 175);
            login_registerBtn.FlatStyle = FlatStyle.Flat;
            login_registerBtn.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_registerBtn.ForeColor = Color.FromArgb(216, 59, 113);
            login_registerBtn.Location = new Point(12, 404);
            login_registerBtn.Name = "login_registerBtn";
            login_registerBtn.Size = new Size(304, 40);
            login_registerBtn.TabIndex = 11;
            login_registerBtn.Text = "Register";
            login_registerBtn.UseVisualStyleBackColor = false;
            login_registerBtn.Click += login_registerBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 242, 204);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(login_registerBtn);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 456);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = HotelCalifornia.Properties.Resources.photo_2025_03_15_13_57_30__1___3__removebg_preview;
            pictureBox1.Location = new Point(70, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 150);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // login_showPassword
            // 
            login_showPassword.AutoSize = true;
            login_showPassword.Cursor = Cursors.Hand;
            login_showPassword.Location = new Point(383, 278);
            login_showPassword.Name = "login_showPassword";
            login_showPassword.Size = new Size(134, 24);
            login_showPassword.TabIndex = 30;
            login_showPassword.Text = "Show password";
            login_showPassword.UseVisualStyleBackColor = true;
            login_showPassword.CheckedChanged += login_showPassword_CheckedChanged;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(255, 242, 204);
            login_btn.Cursor = Cursors.Hand;
            login_btn.FlatAppearance.BorderColor = Color.FromArgb(216, 59, 113);
            login_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(237, 201, 175);
            login_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 201, 175);
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.FromArgb(216, 59, 113);
            login_btn.Location = new Point(412, 349);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(190, 40);
            login_btn.TabIndex = 0;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click_1;
            // 
            // login_password
            // 
            login_password.Cursor = Cursors.IBeam;
            login_password.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            login_password.Location = new Point(383, 242);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(251, 30);
            login_password.TabIndex = 28;
            login_password.TextChanged += login_password_TextChanged;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(383, 218);
            password.Name = "password";
            password.Size = new Size(80, 17);
            password.TabIndex = 27;
            password.Text = "Password";
            password.Click += password_Click;
            // 
            // login_username
            // 
            login_username.Cursor = Cursors.IBeam;
            login_username.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            login_username.Location = new Point(383, 177);
            login_username.Name = "login_username";
            login_username.Size = new Size(251, 30);
            login_username.TabIndex = 26;
            login_username.TextChanged += login_username_TextChanged;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.Location = new Point(383, 153);
            Username.Name = "Username";
            Username.Size = new Size(83, 17);
            Username.TabIndex = 25;
            Username.Text = "Username";
            Username.Click += Username_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(383, 65);
            label2.Name = "label2";
            label2.Size = new Size(251, 27);
            label2.TabIndex = 24;
            label2.Text = "Welcome back, User!";
            label2.Click += label2_Click_1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(667, 456);
            Controls.Add(login_showPassword);
            Controls.Add(login_btn);
            Controls.Add(login_password);
            Controls.Add(password);
            Controls.Add(login_username);
            Controls.Add(Username);
            Controls.Add(label2);
            Controls.Add(close);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Label close;
        private Label label5;
        private Label label6;
        private RoundedButton login_registerBtn;
        private Panel panel1;
        private CheckBox login_showPassword;
        private RoundedButton login_btn;
        private TextBox login_password;
        private Label password;
        private TextBox login_username;
        private Label Username;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
