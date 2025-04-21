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
    public partial class staff_bookRoom : UserControl
    {
        private const string PathToFile = "rooms.json";
        private readonly RoomService _roomService;
        private int getID = 0; //ID клікнутої кімнати
        public staff_bookRoom()
        {
            InitializeComponent();
            _roomService = new RoomService(new Repository<Room>(new JsonStorage<Room>(PathToFile)));
            InitializeGrid();
            FillRooms();
        }
        private void InitializeGrid()
        {
            MainGrid.ColumnCount = 4;
            MainGrid.Columns[0].Name = "Name";
            MainGrid.Columns[1].Name = "Price";
            MainGrid.Columns[2].Name = "Status";
            MainGrid.Columns[3].Name = "Type";
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
                    room.Type
                );
            }
        }

        private void bookRoom_scheduleNowBtn_Click(object sender, EventArgs e)
        {

        }

        private void bookRoom_BookBtn_Click(object sender, EventArgs e)
        {
            clientInfo clientInfo = new clientInfo();
            clientInfo.ShowDialog();
        }

        private void MainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) 
            {
                DataGridViewRow row = MainGrid.Rows[e.RowIndex];

                if (MainGrid.Columns.Contains("Id"))
                {
                    bookRoom_roomId.Text = row.Cells["Id"].Value?.ToString() ?? "";
                }

                bookRoom_roomType.Text = row.Cells["Type"].Value?.ToString();
                bookRoom_roomName.Text = row.Cells["Name"].Value?.ToString();
                bookRoom_roomPrice.Text = row.Cells["Price"].Value?.ToString();
                bookRoom_roomStatus.Text = row.Cells["Status"].Value?.ToString();
                bookRoom_TotalPrice.Text = row.Cells["Price"].Value?.ToString();
                //значений id и фото можеть не быть поэтому проверяем их наличие
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
