using System.Text.Json;
using BCrypt.Net;

namespace HotelCalifornia
{
    public partial class RegistrationForm : Form
    {
        private const String PathToFile = "user.json";
        private Repository<User> _usersData = new(new JsonStorage<User>(PathToFile));
        private readonly AuthService _authService;
        public RegistrationForm()
        {
            InitializeComponent();
            _authService = new AuthService(_usersData);
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
            var user = GetNewUser();
            string confirmPassword = register_confirmPassword.Text.Trim();

            var (success, errorMessage) = _authService.Register(user, confirmPassword);

            if (!success)
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Инициализация репозиториев
            var bookingRepository = new Repository<Booking>(new JsonStorage<Booking>("bookings.json"));
            var roomRepository = new Repository<Room>(new JsonStorage<Room>("rooms.json"));
            var guestRepository = new Repository<Guest>(new JsonStorage<Guest>("guests.json"));

            // Инициализация сервисов
            var bookingService = new BookingService(bookingRepository, roomRepository);
            var guestService = new GuestService(guestRepository);

            // Передача сервисов в конструктор формы
            var staffMainForm = new staffMainForm(bookingService, guestService);
            staffMainForm.Show();
            Hide();
        }

        private User GetNewUser()
        {
            return new User(register_username.Text, register_password.Text.Trim(), false, String.Empty);
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
