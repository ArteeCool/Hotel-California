using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace HotelCalifornia
{
    public partial class admin_dashboard : UserControl
    {
        private readonly RoomService _roomService;
        private readonly BookingService _bookingService;
        private readonly GuestService _guestService;
        private string _selectedRoomId;
        private readonly string _connectionString = "Data Source=localhost;Initial Catalog=Hotel-California;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public admin_dashboard()
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
            displayTotalStaff();
            displayAvailableRooms();
            displayTodaysProfit();
            displayTotalProfit();
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

        // Можливо треба зробити кнопку закриття форми / кнопку повернення до минулої форми?
        Point lastPoint = new Point();
        private void Admin_Dashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Admin_Dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void MainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void displayTotalStaff()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(_connectionString))
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(*) FROM Users WHERE IsAdmin = 0";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            totalStaff.Text = result.ToString();
                            Console.WriteLine($"Total staff count: {result}");
                        }
                        else
                        {
                            totalStaff.Text = "0";
                            Console.WriteLine("No staff found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving staff count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                totalStaff.Text = "Error";
                Console.WriteLine($"Error: {ex.Message}");
            }
        }


        public void displayAvailableRooms()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(_connectionString))
                {
                    connect.Open();
                    // CONVERT для преобразования TEXT в VARCHAR для сравнения
                    string selectData = "SELECT COUNT(*) FROM Rooms WHERE CONVERT(VARCHAR(MAX), Status) = @status";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Active");
                        object result = cmd.ExecuteScalar();
                        Console.WriteLine($"SQL Query (AvailableRooms): {selectData} с параметром @status = 'Active'");
                        Console.WriteLine($"Raw result: {result ?? "null"}");
                        if (result != null && result != DBNull.Value)
                        {
                            int count = Convert.ToInt32(result);
                            Console.WriteLine($"Setting availableRooms.Text to: {count}");
                            availableRooms.Text = count.ToString();
                            availableRooms.Refresh();
                        }
                        else
                        {
                            Console.WriteLine("No active rooms found (result is null or DBNull).");
                            availableRooms.Text = "0";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving available rooms: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                availableRooms.Text = "Error";
                Console.WriteLine($"Error in displayAvailableRooms: {ex.Message}");
            }
        }



        public void displayTodaysProfit()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(_connectionString))
                {
                    connect.Open();

                    string selectData = "SELECT SUM(TotalPrice) FROM Bookings WHERE @Today BETWEEN FromDate AND ToDate";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@Today", DateTime.Today);

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            todaysProfit.Text = result.ToString(); 
                            Console.WriteLine($"Today's profit: {result}");
                        }
                        else
                        {
                            todaysProfit.Text = "$0.00"; 
                            Console.WriteLine("No profit for today.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving today's profit: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                todaysProfit.Text = "Error";
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public void displayTotalProfit()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(_connectionString))
                {
                    connect.Open();

                    string selectData = "SELECT SUM(TotalPrice) FROM Bookings";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            totalProfit.Text = result.ToString(); 
                            Console.WriteLine($"Total profit: {result}");
                        }
                        else
                        {
                            totalProfit.Text = "$0.00";
                            Console.WriteLine("No total profit found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving total profit: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                totalProfit.Text = "Error";
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
