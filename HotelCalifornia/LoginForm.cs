using System.Text.Json;
using BCrypt.Net;

namespace HotelCalifornia
{
    public partial class LoginForm : Form
    {
        private const String PathToFile = "user.json";
        private Repository<User> _usersData = new(new JsonStorage<User>(PathToFile));
        private readonly AuthService _authService;

        public LoginForm()
        {
            InitializeComponent();
            _authService = new AuthService(_usersData);
        }

        private void close_Click(Object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void login_showPassword_CheckedChanged(Object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPassword.Checked ? '\0' : '*';
        }

        private void login_registerBtn_Click(Object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            regForm.Show();

            this.Hide();
        }

        private void login_btn_Click_1(Object sender, EventArgs e)
        {
            string login = login_username.Text.Trim();
            string password = login_password.Text.Trim();

            var (success, user, errorMessage) = _authService.Login(login, password);

            if (!success)
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (user.IsAdmin)
            {
                var adminMainForm = new AdminMainForm();
                adminMainForm.Show();
            }
            else
            {
                var staffForm = new staffMainForm();
                staffForm.Show();
            }

            Hide();
        }
        /*
        private User GetNewUser()
        {
            return new User(login_username.Text.Trim(), login_password.Text.Trim(), false, "");
        }

        private void Login()
        {
            var user = GetNewUser();
            var loginUser = _usersData.Read().FirstOrDefault(item => item.Login == user.Login);
            if (loginUser != null && BCrypt.Net.BCrypt.EnhancedVerify(user.Password, loginUser.Password))
            {
                if (loginUser.IsAdmin)
                {
                    var adminMainForm = new AdminMainForm();
                    adminMainForm.Show();
                }
                else
                {
                    var staffForm = new staffMainForm();
                    staffForm.Show();
                }

                Hide();
            }
            else
            {
                MessageBox.Show("Wrong login or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */

        private void close_MouseEnter(Object sender, EventArgs e)
        {
            close.ForeColor = Color.Red;
        }

        private void close_MouseLeave(Object sender, EventArgs e)
        {
            close.ForeColor = Color.Black;
        }

        Point lastPoint = new Point();
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
