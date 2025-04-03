using System.Text.Json;
using BCrypt.Net;

namespace HotelCalifornia
{
    public partial class RegistrationForm : Form
    {
        private const String PathToFile = "user.json";
        private Repository<User> _usersData = new(new JsonStorage<User>(PathToFile));

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_signinBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            this.Hide();
        }

        private void register_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPassword.Checked ? '\0' : '*';
            register_confirmPassword.PasswordChar = register_showPassword.Checked ? '\0' : '*';
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            Register();
        }

        private User GetNewUser()
        {
            return new User(register_username.Text, register_password.Text.Trim(), false, String.Empty);
        }

        private void Register()
        {
            var user = GetNewUser();
    
            var errorMessage = String.Empty;

            if (String.IsNullOrWhiteSpace(user.Login) || user.Login.Length < 6)
                errorMessage = "Login must be at least 6 characters.";
            else if (_usersData.Read().Any(item => item.Login.Trim() == user.Login.Trim()))
                errorMessage = "Current login is taken.";
            else if (String.IsNullOrWhiteSpace(user.Password) || user.Password.Length < 6)
                errorMessage = "Password must be at least 6 characters.";
            else if (user.Password != register_confirmPassword.Text.Trim())
                errorMessage = "Passwords do not match.";
    
            if (!String.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            user.Password = BCrypt.Net.BCrypt.EnhancedHashPassword(register_password.Text.Trim());
            _usersData.Create(user);
            
            var json = JsonSerializer.Serialize(user);
            
            var staffMainForm = new staffMainForm();
            staffMainForm.Show();
            
            _usersData.Save();
    
            Hide();
        }

        
        private void close_MouseEnter(Object sender, EventArgs e)
        {
            close.ForeColor = Color.Red;
        }

        private void close_MouseLeave(Object sender, EventArgs e)
        {
            close.ForeColor = Color.Black;
        }

       
        Point lastPoint = new Point();
        private void RegistrationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void RegistrationForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
