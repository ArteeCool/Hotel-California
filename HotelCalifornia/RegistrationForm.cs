using System.Text.Json;
using BCrypt.Net;

namespace HotelCalifornia
{
    public partial class RegistrationForm : Form
    {
        private Repository<User> _userRepository = new([]);
        private Repository<User> _usersData = new([]);
        private const String PathToFile = "user.json";

        public RegistrationForm()
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
        
        private void SaveToFile()
        {
            try
            {
                var combinedList = _usersData.Read().Concat(_userRepository.Read()).ToList();
                var json = JsonSerializer.Serialize(combinedList, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(PathToFile, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during serialization: {ex.Message}");
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void register_confirmPassword_TextChanged(object sender, EventArgs e)
        {

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

            user.Password = BCrypt.Net.BCrypt.HashPassword(register_password.Text.Trim());
            _userRepository.Create(user);
            SaveToFile();

            var staffMainForm = new staffMainForm();
            staffMainForm.Show();
    
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

        private void register_username_TextChanged(Object sender, EventArgs e)
        {
            
        }
    }
}
