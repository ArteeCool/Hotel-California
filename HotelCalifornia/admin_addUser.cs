using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelCalifornia
{
    public partial class admin_addUser : UserControl
    {
        private const String PathToFile = "rooms.json";
        private Repository<Room> _roomsRepository = new([]);
        private Int32 _selectedRoom;
        private Boolean _isEditing;
        public admin_addUser()
        {
            InitializeComponent();
            MainGrid.CellClick += dataGridView1_CellClick;
            Load += Form1_Load; // Привязка метода к событию загрузки формы
        }

        private void SaveRoomsToFile()
        {
            try
            {
                var json = JsonSerializer.Serialize(_roomsRepository.Read(), new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(PathToFile, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during serialization: {ex.Message}");
            }
        }

        private void LoadRoomsFromFile()
        {
            if (!File.Exists(PathToFile) || new FileInfo(PathToFile).Length == 0)
            {
                File.WriteAllText(PathToFile, "[]");
                return;
            }

            var json = File.ReadAllText(PathToFile);
            var rooms = JsonSerializer.Deserialize<List<Room>>(json) ?? [];
            _roomsRepository = new Repository<Room>(rooms);
        }

        private void Form1_Load(Object sender, EventArgs e)
        {
            InitializeGridColumns();
            LoadRoomsFromFile();
            FillRooms();
        }

        private void InitializeGridColumns()
        {
            MainGrid.ColumnCount = 4;
            MainGrid.Columns[0].Name = "Room Number";
            MainGrid.Columns[1].Name = "Rooms Count";
            MainGrid.Columns[2].Name = "Cost";
            MainGrid.Columns[3].Name = "Publisher";
        }

        private void FillRooms()
        {
            MainGrid.Rows.Clear();

            foreach (var room in _roomsRepository.Read())
            {
                MainGrid.Rows.Add(
                    room.RoomNumber,
                    room.RoomsCount,
                    room.RoomCost + "$",
                    room.RoomPublisher
                );
            }
        }


        private void addUser_clearBtn_Click(object sender, EventArgs e)
        {
            clearFiedls();
        }

        public void clearFiedls()
        {
            addUser_username.Text = "";
            addUser_password.Text = "";
            addUser_role.SelectedIndex = -1;
            addUser_status.SelectedIndex = -1;
        }

        private void addUser_addBtn_Click(object sender, EventArgs e) //Кнопка Add
        {
            if (_isEditing)
            {
                var rooms = _roomsRepository.Read();
                var updatedRoom = GetRoomInput();
                if (updatedRoom == null) return;
                updatedRoom.Id = rooms[_selectedRoom].Id;
                _roomsRepository.Update(updatedRoom);
                _isEditing = false;
                addUser_addBtn.Text = "Add";
            }
            else
            {
                var room = GetRoomInput();
                if (room == null) return;

                _roomsRepository.Create(room);
            }
            ClearTextEntries();
            FillRooms();
            SaveRoomsToFile();
        }

        private void dataGridView1_CellClick(Object? sender, DataGridViewCellEventArgs e)
        {
            _selectedRoom = e.RowIndex;
        }

        private void admin_addUser_Load(object sender, EventArgs e)
        {

        }

        private Room? GetRoomInput()
        {
            if (String.IsNullOrWhiteSpace(RoomNumberBox.Text) ||
                String.IsNullOrWhiteSpace(RoomsCountBox.Text) ||
                String.IsNullOrWhiteSpace(CostBox.Text) ||
                String.IsNullOrWhiteSpace(addUser_username.Text))
            {
                MessageBox.Show("All fields must be filled.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }


            if (!Int32.TryParse(RoomNumberBox.Text, out var roomNumber) ||
                !Int32.TryParse(RoomsCountBox.Text, out var roomCount) ||
                !Int32.TryParse(CostBox.Text, out var cost))
            {
                MessageBox.Show("Room Number, Room Count, and Cost must be valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            var publisher = addUser_username.Text.Trim();
            if (String.IsNullOrEmpty(publisher))
            {
                MessageBox.Show("Publisher field cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return new Room(roomNumber, roomCount, cost, publisher);
        }

        private void ClearTextEntries()
        {
            RoomNumberBox.Text = String.Empty;
            RoomsCountBox.Text = String.Empty;
            CostBox.Text = String.Empty;
            addUser_username.Text = String.Empty;
        }

        private void addUser_editBtn_Click(object sender, EventArgs e)
        {
            var rooms = _roomsRepository.Read();
            if (rooms.Count <= 0 || _selectedRoom < 0 || _selectedRoom >= rooms.Count) return;

            _isEditing = true;
            addUser_addBtn.Text = "Save";
            RoomNumberBox.Text = rooms[_selectedRoom].RoomNumber.ToString();
            RoomsCountBox.Text = rooms[_selectedRoom].RoomsCount.ToString();
            CostBox.Text = rooms[_selectedRoom].RoomCost.ToString();
            addUser_username.Text = rooms[_selectedRoom].RoomPublisher;
        }

        private void addUser_deleteBtn_Click(object sender, EventArgs e)
        {
            var rooms = _roomsRepository.Read();
            if (rooms.Count <= 0 || _selectedRoom < 0 || _selectedRoom >= rooms.Count) return;

            _roomsRepository.Delete(rooms[_selectedRoom]);
            FillRooms();
            SaveRoomsToFile();
        }
    }
}
