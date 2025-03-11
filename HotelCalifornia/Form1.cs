using System.Text.Json;

namespace HotelCalifornia;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        
        MainGrid.CellClick += dataGridView1_CellClick;

        Repository<Room> roomRepo = new();
        
        Room room1 = new Room(1, 2, 100, "John Smith");
        Room room2 = new Room(2, 3, 150, "Jenifer Lawrence");
        Room room3 = new Room(3, 1, 200, "John Doe");
        
        roomRepo.Create(room1);
        roomRepo.Create(room2);
        roomRepo.Create(room3);
        
        Console.WriteLine("Rooms:");
        foreach (var room in roomRepo.Read())
        {
            Console.WriteLine(room.RoomNumber);
        }

        room1.RoomNumber = 4;
        roomRepo.Update(room1);

        Console.WriteLine("\nUpdated Rooms:");
        foreach (var room in roomRepo.Read())
        {
            Console.WriteLine(room.RoomNumber);
        }

        roomRepo.Delete(room2);

        Console.WriteLine("\nRooms after deletion:");
        foreach (var room in roomRepo.Read())
        {
            Console.WriteLine(room.RoomNumber);
        }
    }

    private readonly String _pathToFile = "rooms.json";
    private List<Room> _rooms = [];
    private Int32 _selectedRoom;
    private Boolean _isEditing;

    private static void SaveRoomsToFile(List<Room> rooms, String filePath)
    {
        try
        {
            var json = JsonSerializer.Serialize(rooms, new JsonSerializerOptions { WriteIndented = true });
            Console.WriteLine($"Saving to file: {json}");
            File.WriteAllText(filePath, json);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during serialization: {ex.Message}");
        }
    }

    private static List<Room> LoadRoomsFromFile(String filePath)
    {
        if (!File.Exists(filePath) || new FileInfo(filePath).Length == 0)
        {
            File.WriteAllText(filePath, "[]");
            return [];
        }

        string json = File.ReadAllText(filePath);
        Console.WriteLine($"Loaded from file: {json}");
        return JsonSerializer.Deserialize<List<Room>>(json) ?? new List<Room>();
    }

    private void FillRooms()
    {
        MainGrid.Rows.Clear();

        foreach (var room in _rooms)
        {
            MainGrid.Rows.Add(
                room.RoomNumber,
                room.RoomsCount,
                room.RoomCost + "$",
                room.RoomPublisher
            );
        }
    }

    private Room GetRoomInput()
    {
        var room = new Room(Convert.ToInt32(RoomNumberBox.Text), Convert.ToInt32(RoomsCountBox.Text), Convert.ToInt32(CostBox.Text), PublisherBox.Text);
        return room;
    }

    private void ClearTextEntries()
    {
        RoomNumberBox.Text = String.Empty;
        RoomsCountBox.Text = String.Empty;
        CostBox.Text = String.Empty;
        PublisherBox.Text = String.Empty;
    }

    private void dataGridView1_CellClick(Object? sender, DataGridViewCellEventArgs e)
    {
        _selectedRoom = e.RowIndex;
    }
    
    private void Form1_Load(Object sender, EventArgs e)
    {
        MainGrid.ColumnCount = 4;
        MainGrid.Columns[0].Name = "Room Number";
        MainGrid.Columns[1].Name = "Rooms Count";
        MainGrid.Columns[2].Name = "Cost";
        MainGrid.Columns[3].Name = "Publisher";

        _rooms = LoadRoomsFromFile(_pathToFile);
        if (_rooms == null)
        {
            File.WriteAllText(_pathToFile, "[]");
            _rooms = [];
        }
        FillRooms();
    }
    
    private void EditButton_Click(Object sender, EventArgs e)
    {
        _isEditing = true;
        AddButton.Text = "Save";
        RoomNumberBox.Text = _rooms[_selectedRoom].RoomNumber.ToString();
        RoomsCountBox.Text = _rooms[_selectedRoom].RoomsCount.ToString();
        CostBox.Text = _rooms[_selectedRoom].RoomCost.ToString();
        PublisherBox.Text = _rooms[_selectedRoom].RoomPublisher.ToString();
    }

    private void AddButton_Click(Object sender, EventArgs e)
    {
        if (_isEditing)
        {
            _rooms[_selectedRoom] = GetRoomInput();
            ClearTextEntries();
            FillRooms();
            SaveRoomsToFile(_rooms, _pathToFile);
            _isEditing = false;
            AddButton.Text = "Add";
        }
        else
        {
            _rooms.Add(GetRoomInput());
            ClearTextEntries();
            FillRooms();
            SaveRoomsToFile(_rooms, _pathToFile);
        }
    }
    
    private void RemoveButton_Click(Object sender, EventArgs e)
    {
        if (_rooms.Count <= 0) return;
        if (_selectedRoom < 0 || _selectedRoom >= _rooms.Count) return;

        if (!_rooms.Remove(_rooms[_selectedRoom])) return;

        FillRooms();
        SaveRoomsToFile(_rooms, _pathToFile);
    }

    private void RoomNumber_TextChanged(Object sender, EventArgs e)
    {
    }

    private void RoomsCountBox_TextChanged(Object sender, EventArgs e)
    {
    }

    private void CostBox_TextChanged(Object sender, EventArgs e)
    {
    }

    private void textBox1_TextChanged(Object sender, EventArgs e)
    {
    }

    private void MainGrid_CellContentClick(Object sender, DataGridViewCellEventArgs e)
    {
    }
}