﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        private String _selectedImagePath = "";

        public admin_rooms()
        {
            InitializeComponent();
            var sqlStorage = new SQLRoomStorage("Data Source=localhost;Initial Catalog=Hotel-California;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            _roomService = new RoomService(new Repository<Room>(sqlStorage));

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

        }

        private void rooms_addBtn_Click(object sender, EventArgs e)
        {
            var room = GetRoomInput();
            if (room == null) return;

            if (!ValidateRoom(room)) return;

            if (!string.IsNullOrEmpty(_selectedImagePath) && File.Exists(_selectedImagePath))
            {
                try
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(_selectedImagePath);
                    string relativePath = Path.Combine("assets", fileName);
                    string fullAssetsPath = Path.Combine(@"C:\Users\Вячеслав\source\repos\ArteeCool\Hotel-California\HotelCalifornia", relativePath);

                    Directory.CreateDirectory(Path.GetDirectoryName(fullAssetsPath)!);
                    File.Copy(_selectedImagePath, fullAssetsPath, true);

                    room.ImagePath = relativePath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error copying file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (_isEditing)
            {
                if (_roomService.EditRoom(_selectedRoomIndex, room))
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
                if (_roomService.AddRoom(room))
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

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedRoomIndex = e.RowIndex;
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

        private void rooms_importBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _selectedImagePath = openFileDialog.FileName;
                    room_pictureBox.Image = Image.FromFile(_selectedImagePath);
                }
            }
        }

        private bool ValidateRoom(Room room)
        {
            var context = new ValidationContext(room);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(room, context, results, true);

            if (!isValid)
            {
                string errorMessages = string.Join("\n", results.Select(r => r.ErrorMessage));
                MessageBox.Show(errorMessages, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return isValid;
        }
    }
}