using System.Text.Json;
using BCrypt.Net;

namespace HotelCalifornia
{
    public partial class LoginForm : Form
    {
        private string _connectionString = "Data Source=localhost;Initial Catalog=Hotel-California;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        private readonly SqlUsersStorage sqlStorage = new SqlUsersStorage("Data Source=localhost;Initial Catalog=Hotel-California;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        private readonly Repository<User> users;
        private readonly AuthService _authService;

        public LoginForm()
        {
            InitializeComponent();
            users = new Repository<User>(sqlStorage);
            _authService = new AuthService(users);
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

            var bookingRepository = new Repository<Booking>(new SqlBookingStorage(_connectionString));
            var roomRepository = new Repository<Room>(new SQLRoomStorage(_connectionString));
            var guestRepository = new Repository<Guest>(new SqlGuestStorage(_connectionString));

            var bookingService = new BookingService(bookingRepository, roomRepository);
            var guestService = new GuestService(guestRepository);

            if (user.IsAdmin)
            {
                var adminMainForm = new AdminMainForm(bookingService, guestService);
                adminMainForm.Show();
            }
            else
            {
                var staffForm = new staffMainForm(bookingService, guestService);
                staffForm.Show();
            }

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
