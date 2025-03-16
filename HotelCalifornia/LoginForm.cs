using HotelCalifornia;

namespace HotelCali_Personal_NonGithubVersion
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPassword.Checked ? '\0' : '*';
        }

        private void login_registerBtn_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            regForm.Show();

            this.Hide();
        }

        private void login_btn_Click_1(object sender, EventArgs e)
        {
            AdminMainForm adminMainForm = new AdminMainForm();
            adminMainForm.Show();

            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
