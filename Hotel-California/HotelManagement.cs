using System.Text.Json;

namespace Hotel_Management
{
    public partial class MainMenu : Form
    {
        private String _pathToFile = "rooms.json";
        private List<Room> _rooms = [];
        private Int32 _selectedRoom;

        public void SaveRoomsToFile(List<Room> rooms, String filePath)
        {
            try
            {
                string json = JsonSerializer.Serialize(rooms, new JsonSerializerOptions { WriteIndented = true });
                Console.WriteLine($"Saving to file: {json}");
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during serialization: {ex.Message}");
            }
        }

        public List<Room> LoadRoomsFromFile(String filePath)
        {
            if (!File.Exists(filePath) || new FileInfo(filePath).Length == 0)
            {
                File.WriteAllText(filePath, "[]");
                return new List<Room>();
            }

            string json = File.ReadAllText(filePath);
            Console.WriteLine($"Loaded from file: {json}");
            return JsonSerializer.Deserialize<List<Room>>(json) ?? new List<Room>();
        }

        private void FillRooms()
        {
            dataGridView1.Rows.Clear();

            foreach (var room in _rooms)
            {
                dataGridView1.Rows.Add(
                    room.RoomNumber,
                    room.RoomsCount,
                    room.RoomCost + "$",
                    room.RoomPublisher
                );
            }
        }

        private Room GetRoomInput()
        {
            var room = new Room(Convert.ToInt32(roomNumber.Text), Convert.ToInt32(roomsCount.Text), Convert.ToInt32(roomCost.Text), textBox1.Text);
            return room;
        }

        private void AddRoom_Click(object sender, EventArgs e)
        {
            _rooms.Add(GetRoomInput());
            ClearTextEntries();
            FillRooms();
            SaveRoomsToFile(_rooms, _pathToFile);
        }

        private void ClearTextEntries()
        {
            roomNumber.Text = String.Empty;
            roomsCount.Text = String.Empty;
            roomCost.Text = String.Empty;
            textBox1.Text = String.Empty;
        }

        public MainMenu()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void HotelManagement_Load(Object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Room Number";
            dataGridView1.Columns[1].Name = "Rooms Count";
            dataGridView1.Columns[2].Name = "Cost";
            dataGridView1.Columns[3].Name = "Publisher";

            _rooms = LoadRoomsFromFile(_pathToFile);
            if (_rooms == null)
            {
                File.WriteAllText(_pathToFile, "[]");
                _rooms = [];
            }
            FillRooms();
        }


        private void roomNumber_TextChanged(Object sender, EventArgs e)
        {

        }

        private void roomsCount_TextChanged(Object sender, EventArgs e)
        {

        }

        private void roomCost_TextChanged(Object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(Object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(Object sender, DataGridViewCellEventArgs e)
        {
        }
        
        private void dataGridView1_CellClick(Object? sender, DataGridViewCellEventArgs e)
        {
            _selectedRoom = e.RowIndex;
        }

        private void removeButton_Click(Object sender, EventArgs e)
        {
            if (_rooms.Count <= 0) return;
            if (_selectedRoom < 0 || _selectedRoom >= _rooms.Count) return;
            
            if (!_rooms.Remove(_rooms[_selectedRoom])) return;
            
            
            FillRooms();
            SaveRoomsToFile(_rooms, _pathToFile);
        }
    }
}
