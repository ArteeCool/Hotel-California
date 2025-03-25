namespace HotelCalifornia
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }


        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void close_MouseEnter(Object sender, EventArgs e)
        {
            close.ForeColor = Color.Red;
        }

        private void close_MouseLeave(Object sender, EventArgs e)
        {
            close.ForeColor = Color.Purple;
        }

        Point lastPoint = new Point();
        private void AdminMainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AdminMainForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void admin_logoutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();

                this.Hide();
            }
        }

        private void admin_dashboardBtn_Click(object sender, EventArgs e)
        {
            admin_dashboard adminDashBoard = new admin_dashboard();
            admin_rooms1.Controls.Clear();
            admin_rooms1.Controls.Add(adminDashBoard);
        }

        private void admin_addUserBtn_Click(object sender, EventArgs e)
        {
            admin_addUser adminAddUser = new admin_addUser();
            admin_rooms1.Controls.Clear();
            admin_rooms1.Controls.Add(adminAddUser);
        }

        private void admin_roomsBtn_Click(object sender, EventArgs e)
        {
            admin_rooms adminRooms = new admin_rooms();
            admin_rooms1.Controls.Clear();
            admin_rooms1.Controls.Add(adminRooms);
        }

        private void admin_customersBtn_Click(object sender, EventArgs e)
        {
            admin_customers adminCustomers = new admin_customers();
            admin_rooms1.Controls.Clear();
            admin_rooms1.Controls.Add(adminCustomers);
        }
    }
}
