using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HotelCalifornia
{
    public partial class staff_bookRoom : UserControl
    {
        private const string PathToFile = "rooms.json";
        private readonly RoomService _roomService;
        private readonly BookingService _bookingService;
        private readonly GuestService _guestService;
        private readonly decimal _totalPrice;
        private string _selectedRoomId; //ID вибраної кімнати
        public staff_bookRoom()
        {
            InitializeComponent();
            _roomService = new RoomService(new Repository<Room>(new JsonStorage<Room>(PathToFile)));
            InitializeGrid();
            FillRooms();
        }
        private void InitializeGrid()
        {
            MainGrid.ColumnCount = 5;
            MainGrid.Columns[0].Name = "Name";
            MainGrid.Columns[1].Name = "Price";
            MainGrid.Columns[2].Name = "Status";
            MainGrid.Columns[3].Name = "Type";
            MainGrid.Columns[4].Name = "Id";
        }

        // Заповнення з JSON
        private void FillRooms()
        {
            MainGrid.Rows.Clear();
            var rooms = _roomService.GetAllRooms();

            foreach (var room in rooms)
            {
                MainGrid.Rows.Add(
                    room.Name,
                    room.Price,
                    room.Status,
                    room.Type,
                    room.Id
                );
            }
        }

        private void bookRoom_scheduleNowBtn_Click(object sender, EventArgs e)
        {
            DateTime fromDate = bookRoom_FromDate.Value;
            DateTime toDate = bookRoom_ToDate.Value;

            if (!int.TryParse(bookRoom_roomPrice.Text, out int pricePerNight))
            {
                MessageBox.Show("Error: incorrect room price");
                return;
            }

        //    decimal totalPrice = _bookingService.CalculateBookingPrice(pricePerNight, fromDate, toDate);

            bookRoom_TotalPrice.Text = _totalPrice.ToString();
        }

        private void bookRoom_BookBtn_Click(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(_selectedRoomId))
                {
                    MessageBox.Show("Please select a room first.");
                    return;
                }

                DateTime fromDate = bookRoom_FromDate.Value;
                DateTime toDate = bookRoom_ToDate.Value;

                if (toDate <= fromDate)
                {
                    MessageBox.Show("Error: 'To Date' must be later than 'From Date'.");
                    return;
                }

                var bookingForm = new clientInfo(
                    bookingService: _bookingService,
                    guestService: _guestService,
                    roomId: _selectedRoomId,
                    fromDate: fromDate,
                    toDate: toDate
                    );

            if (bookingForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Booking created successfully!");
                // Можно обновить список комнат
                FillRooms();
            }
        }

        private void MainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) 
            {
                DataGridViewRow row = MainGrid.Rows[e.RowIndex];

                _selectedRoomId = _roomService
                    .GetAllRooms()
                    .FirstOrDefault(r =>
                        r.Name == row.Cells["Name"].Value?.ToString() &&
                        r.Type == row.Cells["Type"].Value?.ToString()
                    )?.Id;

                bookRoom_roomType.Text = row.Cells["Type"].Value?.ToString();
                bookRoom_roomName.Text = row.Cells["Name"].Value?.ToString();
                bookRoom_roomPrice.Text = row.Cells["Price"].Value?.ToString();
                bookRoom_roomStatus.Text = row.Cells["Status"].Value?.ToString();
                bookRoom_TotalPrice.Text = row.Cells["Price"].Value?.ToString();
                //значения фото можеть не быть поэтому проверяем их наличие
                if (MainGrid.Columns.Contains("ImagePath"))
                {
                    string imagePath = row.Cells["ImagePath"].Value?.ToString() ?? "";
                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        bookRoom_ImageView.ImageLocation = imagePath;
                    }
                }
            }
        }
    }
}
