
namespace HotelCalifornia
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            close = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            login_registerBtn = new RoundedButton();
            panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            login_showPassword = new System.Windows.Forms.CheckBox();
            login_btn = new RoundedButton();
            login_password = new System.Windows.Forms.TextBox();
            password = new System.Windows.Forms.Label();
            login_username = new System.Windows.Forms.TextBox();
            Username = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // close
            // 
            close.AutoSize = true;
            close.Cursor = System.Windows.Forms.Cursors.Hand;
            close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            close.Location = new System.Drawing.Point(636, 9);
            close.Name = "close";
            close.Size = new System.Drawing.Size(17, 17);
            close.TabIndex = 0;
            close.Text = "X";
            close.Click += close_Click;
            close.MouseEnter += close_MouseEnter;
            close.MouseLeave += close_MouseLeave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label5.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)216)), ((int)((byte)59)), ((int)((byte)113)));
            label5.Location = new System.Drawing.Point(78, 219);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(141, 24);
            label5.TabIndex = 9;
            label5.Text = "Hotel California ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label6.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)216)), ((int)((byte)59)), ((int)((byte)113)));
            label6.Location = new System.Drawing.Point(70, 366);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(151, 20);
            label6.TabIndex = 10;
            label6.Text = "Create new account";
            // 
            // login_registerBtn
            // 
            login_registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)242)), ((int)((byte)204)));
            login_registerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            login_registerBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)216)), ((int)((byte)59)), ((int)((byte)113)));
            login_registerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)237)), ((int)((byte)201)), ((int)((byte)175)));
            login_registerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)237)), ((int)((byte)201)), ((int)((byte)175)));
            login_registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            login_registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            login_registerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)216)), ((int)((byte)59)), ((int)((byte)113)));
            login_registerBtn.Location = new System.Drawing.Point(12, 404);
            login_registerBtn.Name = "login_registerBtn";
            login_registerBtn.Size = new System.Drawing.Size(304, 40);
            login_registerBtn.TabIndex = 11;
            login_registerBtn.Text = "Register";
            login_registerBtn.UseVisualStyleBackColor = false;
            login_registerBtn.Click += login_registerBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)242)), ((int)((byte)204)));
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(login_registerBtn);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(333, 456);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(43, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(249, 164);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // login_showPassword
            // 
            login_showPassword.AutoSize = true;
            login_showPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            login_showPassword.Location = new System.Drawing.Point(383, 278);
            login_showPassword.Name = "login_showPassword";
            login_showPassword.Size = new System.Drawing.Size(108, 19);
            login_showPassword.TabIndex = 30;
            login_showPassword.Text = "Show password";
            login_showPassword.UseVisualStyleBackColor = true;
            login_showPassword.CheckedChanged += login_showPassword_CheckedChanged;
            // 
            // login_btn
            // 
            login_btn.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)242)), ((int)((byte)204)));
            login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            login_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)216)), ((int)((byte)59)), ((int)((byte)113)));
            login_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)237)), ((int)((byte)201)), ((int)((byte)175)));
            login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)237)), ((int)((byte)201)), ((int)((byte)175)));
            login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            login_btn.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)216)), ((int)((byte)59)), ((int)((byte)113)));
            login_btn.Location = new System.Drawing.Point(412, 349);
            login_btn.Name = "login_btn";
            login_btn.Size = new System.Drawing.Size(190, 40);
            login_btn.TabIndex = 0;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click_1;
            // 
            // login_password
            // 
            login_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            login_password.Location = new System.Drawing.Point(383, 242);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new System.Drawing.Size(251, 26);
            login_password.TabIndex = 28;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            password.Location = new System.Drawing.Point(383, 218);
            password.Name = "password";
            password.Size = new System.Drawing.Size(61, 15);
            password.TabIndex = 27;
            password.Text = "Password";
            // 
            // login_username
            // 
            login_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            login_username.Location = new System.Drawing.Point(383, 177);
            login_username.Name = "login_username";
            login_username.Size = new System.Drawing.Size(251, 26);
            login_username.TabIndex = 26;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            Username.Location = new System.Drawing.Point(383, 153);
            Username.Name = "Username";
            Username.Size = new System.Drawing.Size(65, 15);
            Username.TabIndex = 25;
            Username.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label2.Location = new System.Drawing.Point(383, 65);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(190, 24);
            label2.TabIndex = 24;
            label2.Text = "Welcome back, User!";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(667, 456);
            Controls.Add(login_showPassword);
            Controls.Add(login_btn);
            Controls.Add(login_password);
            Controls.Add(password);
            Controls.Add(login_username);
            Controls.Add(Username);
            Controls.Add(label2);
            Controls.Add(close);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
