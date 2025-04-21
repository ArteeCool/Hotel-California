using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelCalifornia
{
    public partial class staffMainForm : Form
    {
        public staffMainForm()
        {
            InitializeComponent();
        }

        private void staff_logoutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();

                this.Hide();
            }
        }

        private void staff_dashboardBtn_Click(object sender, EventArgs e)
        {
            admin_dashboard adminDashBoard = new admin_dashboard();
            staff_bookRoom1.Controls.Clear();
            staff_bookRoom1.Controls.Add(adminDashBoard);
        }

        private void staff_customersBtn_Click(object sender, EventArgs e)
        {
            admin_customers adminCustomers = new admin_customers();
            staff_bookRoom1.Controls.Clear();
            staff_bookRoom1.Controls.Add(adminCustomers);
        }

        private void staff_bookRoomBtn_Click(object sender, EventArgs e)
        {
            staff_bookRoom adminBookRoom = new staff_bookRoom();
            staff_bookRoom1.Controls.Clear();
            staff_bookRoom1.Controls.Add(adminBookRoom);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
