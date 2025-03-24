using System.Text.Json;
using BCrypt.Net;

namespace HotelCalifornia
{
    public partial class LoginForm : Form
    {
        private Repository<User> _usersData = new([]);
        private const String PathToFile = "user.json";

        public LoginForm()
        {
            InitializeComponent();
            LoadRoomsFromFile();
        }
        
        private void LoadRoomsFromFile()
        {
            if (!File.Exists(PathToFile) || new FileInfo(PathToFile).Length == 0)
            {
                File.WriteAllText(PathToFile, "[]");
                return;
            }

            var json = File.ReadAllText(PathToFile);
            var rooms = JsonSerializer.Deserialize<List<User>>(json) ?? [];
            _usersData = new Repository<User>(rooms);
        }

      
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            Login();
        }
        
        private User GetNewUser()
        {
            return new User(login_username.Text.Trim(), login_password.Text.Trim(), false, "");
        }

        private void Login()
        {
            var user = GetNewUser();
            var loginUser = _usersData.Read().FirstOrDefault(item => item.Login == user.Login);
            if (loginUser != null && BCrypt.Net.BCrypt.Verify(user.Password, loginUser.Password))
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


        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.ForeColor = Color.Red;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.Black;
        }
    }
}
