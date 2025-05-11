using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HotelCalifornia
{
    public partial class staff_bookRoom : UserControl
    {
        private readonly RoomService _roomService;
        private readonly BookingService _bookingService;
        private readonly GuestService _guestService;
        private string _selectedRoomId;
        private readonly string _connectionString = "Data Source=localhost;Initial Catalog=Hotel-California;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        private readonly string _assetsPath = @"C:\Users\Вячеслав\source\repos\ArteeCool\Hotel-California\HotelCalifornia\assets";
        public staff_bookRoom()
        {
            InitializeComponent();

            var sqlStorage = new SQLRoomStorage(_connectionString);
            var roomStorage = new Repository<Room>(sqlStorage);
            _roomService = new RoomService(roomStorage);
            _guestService = new GuestService(new Repository<Guest>(new SqlGuestStorage(_connectionString)));
            var bookingRepository = new Repository<Booking>(new SqlBookingStorage(_connectionString));
            _bookingService = new BookingService(bookingRepository, roomStorage);

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

            MainGrid.Columns.Add("ImagePath", "Image Path");
            MainGrid.Columns["ImagePath"].Visible = false;

            // Настройка отображения изображения
            bookRoom_ImageView.SizeMode = PictureBoxSizeMode.Zoom;
        }

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
                    room.Id,
                    room.ImagePath ?? ""
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

            decimal price = _bookingService.CalculateBookingPrice(pricePerNight, fromDate, toDate);
            bookRoom_TotalPrice.Text = price.ToString();
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
                FillRooms();
            }
        }

        private void MainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var row = MainGrid.Rows[e.RowIndex];

            _selectedRoomId = row.Cells["Id"].Value?.ToString();

            bookRoom_roomId.Text = row.Cells["Id"].Value?.ToString();
            bookRoom_roomType.Text = row.Cells["Type"].Value?.ToString();
            bookRoom_roomName.Text = row.Cells["Name"].Value?.ToString();
            bookRoom_roomPrice.Text = row.Cells["Price"].Value?.ToString();
            bookRoom_roomStatus.Text = row.Cells["Status"].Value?.ToString();
            bookRoom_TotalPrice.Text = row.Cells["Price"].Value?.ToString();

            string imagePath = row.Cells["ImagePath"].Value?.ToString() ?? "";

            if (!string.IsNullOrWhiteSpace(imagePath))
            {
                
                string fullPath = Path.Combine(_assetsPath, Path.GetFileName(imagePath));

                if (File.Exists(fullPath))
                {
                    try
                    {
                        using (var stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                        {
                            bookRoom_ImageView.Image = Image.FromStream(stream);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        bookRoom_ImageView.Image = null;
                    }
                }
                else
                {
                    bookRoom_ImageView.Image = null;
                }
            }
            else
            {
                bookRoom_ImageView.Image = null;
            }
        }
    }
}