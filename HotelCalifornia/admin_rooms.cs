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
        private Repository<Room> _roomsRepository = new(new JsonStorage<Room>(PathToFile));
        private Int32 _selectedRoom;
        private Boolean _isEditing;

        public admin_rooms()
        {
            InitializeComponent();
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

            foreach (var room in _roomsRepository.Read())
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

        }

        private void rooms_addBtn_Click(object sender, EventArgs e)
        {
            if (_isEditing)
            {
                var rooms = _roomsRepository.Read();
                if (_selectedRoom < 0 || _selectedRoom >= rooms.Count)
                {
                    MessageBox.Show("Please select a valid room to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(rooms_price.Text, out int price))
                {
                    MessageBox.Show("Invalid price value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var existingRoom = rooms[_selectedRoom];
                existingRoom.Name = rooms_roomName.Text;
                existingRoom.Price = price;
                existingRoom.Type = rooms_type.Text;
                existingRoom.Status = rooms_status.Text;

                _roomsRepository.Save();
                _isEditing = false;
                rooms_addBtn.Text = "Add";
            }
            else
            {
                // Add new room
                var room = GetRoomInput();
                if (room == null) return;

                _roomsRepository.Create(room);
            }
            ClearFiedls();
            FillRooms();
        }

        private void MainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedRoom = e.RowIndex;
        }

        private void rooms_roomName_TextChanged(object sender, EventArgs e)
        {

        }

        private void rooms_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rooms_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void rooms_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClearFiedls()
        {
            rooms_roomName.Text = "";
            rooms_price.Text = "";
            rooms_type.Text = "";
            rooms_status.Text = "";
        }

        private void rooms_editBtn_Click(object sender, EventArgs e)
        {
            var rooms = _roomsRepository.Read();
            if (rooms.Count <= 0 || _selectedRoom < 0 || _selectedRoom >= rooms.Count) return;

            _isEditing = true;
            rooms_addBtn.Text = "Save";
            rooms_roomName.Text = rooms[_selectedRoom].Name.ToString();
            rooms_price.Text = rooms[_selectedRoom].Price.ToString();
            rooms_type.Text = rooms[_selectedRoom].Type.ToString();
            rooms_status.Text = rooms[_selectedRoom].Status;
        }

        private void rooms_deleteBtn_Click(object sender, EventArgs e)
        {
            var rooms = _roomsRepository.Read();
            if (rooms.Count <= 0 || _selectedRoom < 0 || _selectedRoom >= rooms.Count) return;

            _roomsRepository.Delete(rooms[_selectedRoom]);
            FillRooms();
            _roomsRepository.Save();
        }

        private void rooms_clearBtn_Click(object sender, EventArgs e)
        {
            ClearFiedls();
        }
    }
}
