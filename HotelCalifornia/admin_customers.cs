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
    public partial class admin_customers : UserControl
    {
        private readonly BookingService _bookingService;
        private readonly GuestService _guestService;


        public admin_customers(BookingService bookingService, GuestService guestService)
        {
            InitializeComponent();
            _bookingService = bookingService;
            _guestService = guestService;
            ConfigureGrid();
            RefreshGuestList();
        }

        Point lastPoint = new Point();
        private void Admin_Customers_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Admin_Customers_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void ConfigureGrid()
        {
            MainGrid.AutoGenerateColumns = false;
            MainGrid.Columns.Clear();

            // Определяем колонки для GuestBookingInfo
            MainGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "GuestName",
                HeaderText = "Guest Name"
            });
            MainGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "GuestEmail",
                HeaderText = "Guest Email"
            });
            MainGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RoomName",
                HeaderText = "Room Name"
            });
            MainGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RoomType",
                HeaderText = "Room Type"
            });
            MainGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FromDate",
                HeaderText = "From Date",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "d" }
            });
            MainGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ToDate",
                HeaderText = "To Date",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "d" }
            });
            MainGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalPrice",
                HeaderText = "Total Price($)"
            });
        }

        public void LoadBookings()
        {
            var bookings = _bookingService.GetAllBookings();
            MainGrid.DataSource = bookings;
        }

        private void MainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void RefreshGuestList()
        {
            var detailedBookings = _bookingService.GetDetailedBookings(_guestService.GetRepository());
            MainGrid.DataSource = detailedBookings;
        }
    }
}
