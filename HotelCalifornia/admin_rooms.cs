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
    public partial class admin_rooms : UserControl
    {
        private const String PathToFile = "rooms.json";
        private readonly RoomService _roomService;
        private Int32 _selectedRoomIndex;
        private Boolean _isEditing;

        public admin_rooms()
        {
            InitializeComponent();
            _roomService = new RoomService(new Repository<Room>(new JsonStorage<Room>(PathToFile)));
            InitializeGrid();
            FillRooms();
            MainGrid.CellClick += dataGridView1_CellClick!;
        }

        private void InitializeGrid()
        {
            MainGrid.ColumnCount = 4;
            MainGrid.Columns[0].Name = "Name";
            MainGrid.Columns[1].Name = "Price";
            MainGrid.Columns[2].Name = "Status";
            MainGrid.Columns[3].Name = "Type";
        }

        private void FillRooms()
        {
            MainGrid.Rows.Clear();

            foreach (var room in _roomService.GetAllRooms())
            {
                MainGrid.Rows.Add(
                    room.Name,
                    room.Price + "$",
                    room.Status,
                    room.Type
                );
            }
        }

        private Room? GetRoomInput()
        {
            if (String.IsNullOrWhiteSpace(rooms_roomName.Text) ||
                String.IsNullOrWhiteSpace(rooms_type.Text) ||
                String.IsNullOrWhiteSpace(rooms_status.Text) ||
                String.IsNullOrWhiteSpace(rooms_price.Text))
            {
                MessageBox.Show("All fields must be filled.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (!Int32.TryParse(rooms_price.Text, out int price))
            {
                MessageBox.Show("Invalid price value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return new Room(
                rooms_roomName.Text,
                rooms_type.Text,
                price,
                rooms_status.Text,
                String.Empty
            );
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Пустой обработчик события
        }

        private void rooms_addBtn_Click(object sender, EventArgs e)
        {
            if (_isEditing)
            {
                // Редактирование существующей комнаты
                var updatedRoom = GetRoomInput();
                if (updatedRoom == null) return;

                if (_roomService.EditRoom(_selectedRoomIndex, updatedRoom))
                {
                    _isEditing = false;
                    rooms_addBtn.Text = "Add";
                    ClearFields();
                    FillRooms();
                }
                else
                {
                    MessageBox.Show("Error updating room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Добавление новой комнаты
                var newRoom = GetRoomInput();
                if (newRoom == null) return;

                if (_roomService.AddRoom(newRoom))
                {
                    ClearFields();
                    FillRooms();
                }
                else
                {
                    MessageBox.Show("Error adding room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Пустой обработчик события
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedRoomIndex = e.RowIndex;
        }

        private void rooms_roomName_TextChanged(object sender, EventArgs e)
        {
            // Пустой обработчик события
        }

        private void rooms_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Пустой обработчик события
        }

        private void rooms_price_TextChanged(object sender, EventArgs e)
        {
            // Пустой обработчик события
        }

        private void rooms_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Пустой обработчик события
        }

        private void ClearFields()
        {
            rooms_roomName.Text = "";
            rooms_price.Text = "";
            rooms_type.Text = "";
            rooms_status.Text = "";
        }

        private void rooms_editBtn_Click(object sender, EventArgs e)
        {
            var rooms = _roomService.GetAllRooms();
            if (rooms.Count <= 0 || _selectedRoomIndex < 0 || _selectedRoomIndex >= rooms.Count) return;

            _isEditing = true;
            rooms_addBtn.Text = "Save";

            var selectedRoom = rooms[_selectedRoomIndex];
            rooms_roomName.Text = selectedRoom.Name;
            rooms_price.Text = selectedRoom.Price.ToString();
            rooms_type.Text = selectedRoom.Type;
            rooms_status.Text = selectedRoom.Status;
        }

        private void rooms_deleteBtn_Click(object sender, EventArgs e)
        {
            if (_roomService.DeleteRoom(_selectedRoomIndex))
            {
                FillRooms();
            }
            else
            {
                MessageBox.Show("Error deleting room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rooms_clearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}