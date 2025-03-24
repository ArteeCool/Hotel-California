namespace HotelCalifornia
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void admin_addUser1_Load(object sender, EventArgs e)
        {

        }

        private void admin_addUser1_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

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
