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
            register_showPassword = new System.Windows.Forms.CheckBox();
            register_btn = new RoundedButton();
            register_password = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            register_username = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            close = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            register_signinBtn = new RoundedButton();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            register_confirmPassword = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // register_showPassword
            // 
            register_showPassword.AutoSize = true;
            register_showPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            register_showPassword.Location = new System.Drawing.Point(383, 315);
            register_showPassword.Name = "register_showPassword";
            register_showPassword.Size = new System.Drawing.Size(108, 19);
            register_showPassword.TabIndex = 21;
            register_showPassword.Text = "Show password";
            register_showPassword.UseVisualStyleBackColor = true;
            register_showPassword.CheckedChanged += register_showPassword_CheckedChanged;
            // 
            // register_btn
            // 
            register_btn.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)242)), ((int)((byte)204)));
            register_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            register_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            register_btn.FlatAppearance.BorderSize = 0;
            register_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)237)), ((int)((byte)201)), ((int)((byte)175)));
            register_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)237)), ((int)((byte)201)), ((int)((byte)175)));
            register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            register_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            register_btn.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)216)), ((int)((byte)59)), ((int)((byte)113)));
            register_btn.Location = new System.Drawing.Point(413, 366);
            register_btn.Name = "register_btn";
            register_btn.Size = new System.Drawing.Size(190, 40);
            register_btn.TabIndex = 20;
            register_btn.Text = "Sign up";
            register_btn.UseVisualStyleBackColor = false;
            register_btn.Click += register_btn_Click;
            // 
            // register_password
            // 
            register_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            register_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            register_password.Location = new System.Drawing.Point(383, 213);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new System.Drawing.Size(251, 26);
            register_password.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label4.Location = new System.Drawing.Point(383, 189);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(61, 15);
            label4.TabIndex = 18;
            label4.Text = "Password";
            // 
            // register_username
            // 
            register_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            register_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            register_username.Location = new System.Drawing.Point(383, 148);
            register_username.Name = "register_username";
            register_username.Size = new System.Drawing.Size(251, 26);
            register_username.TabIndex = 17;
            register_username.TextChanged += register_username_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label3.Location = new System.Drawing.Point(383, 124);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(65, 15);
            label3.TabIndex = 16;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label2.Location = new System.Drawing.Point(383, 65);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(108, 24);
            label2.TabIndex = 15;
            label2.Text = "Registration";
            label2.Click += label2_Click;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Cursor = System.Windows.Forms.Cursors.Hand;
            close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            close.Location = new System.Drawing.Point(635, 9);
            close.Name = "close";
            close.Size = new System.Drawing.Size(17, 17);
            close.TabIndex = 13;
            close.Text = "X";
            close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            close.Click += close_Click;
            close.MouseEnter += close_MouseEnter;
            close.MouseLeave += close_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)242)), ((int)((byte)204)));
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(register_signinBtn);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(333, 456);
            panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(70, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(200, 150);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // register_signinBtn
            // 
            register_signinBtn.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)242)), ((int)((byte)204)));
            register_signinBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            register_signinBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)216)), ((int)((byte)59)), ((int)((byte)113)));
            register_signinBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)237)), ((int)((byte)201)), ((int)((byte)175)));
            register_signinBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)237)), ((int)((byte)201)), ((int)((byte)175)));
            register_signinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            register_signinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            register_signinBtn.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)216)), ((int)((byte)59)), ((int)((byte)113)));
            register_signinBtn.Location = new System.Drawing.Point(12, 404);
            register_signinBtn.Name = "register_signinBtn";
            register_signinBtn.Size = new System.Drawing.Size(304, 40);
            register_signinBtn.TabIndex = 11;
            register_signinBtn.Text = "Sign in";
            register_signinBtn.UseVisualStyleBackColor = false;
            register_signinBtn.Click += register_signinBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label6.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)216)), ((int)((byte)59)), ((int)((byte)113)));
            label6.Location = new System.Drawing.Point(70, 366);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(152, 20);
            label6.TabIndex = 10;
            label6.Text = "Sign in your account";
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
            // register_confirmPassword
            // 
            register_confirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            register_confirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            register_confirmPassword.Location = new System.Drawing.Point(383, 279);
            register_confirmPassword.Name = "register_confirmPassword";
            register_confirmPassword.PasswordChar = '*';
            register_confirmPassword.Size = new System.Drawing.Size(251, 26);
            register_confirmPassword.TabIndex = 23;
            register_confirmPassword.TextChanged += register_confirmPassword_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label7.Location = new System.Drawing.Point(383, 255);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(106, 15);
            label7.TabIndex = 22;
            label7.Text = "Confirm password";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(667, 456);
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
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "RegistrationForm";
            Load += RegistrationForm_Load;
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
        private Label label5;
        private TextBox register_confirmPassword;
        private Label label7;
        private PictureBox pictureBox1;
    }
}