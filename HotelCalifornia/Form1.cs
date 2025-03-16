using System.Text.Json;

namespace HotelCalifornia;

public partial class Form1 : Form
{
    private const String PathToFile = "rooms.json";
    private Repository<Room> _roomsRepository = new([]);
    private Int32 _selectedRoom;
    private Boolean _isEditing;

    public Form1()
    {
        InitializeComponent();
        MainGrid.CellClick += dataGridView1_CellClick;
        //Загружает дизайн-форму
        AdminMainForm adminForm = new AdminMainForm();
        adminForm.Show();

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

    private Room? GetRoomInput()
    {
        if (String.IsNullOrWhiteSpace(RoomNumberBox.Text) ||
            String.IsNullOrWhiteSpace(RoomsCountBox.Text) ||
            String.IsNullOrWhiteSpace(CostBox.Text) ||
            String.IsNullOrWhiteSpace(PublisherBox.Text))
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

        var publisher = PublisherBox.Text.Trim();
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

        LoadRoomsFromFile();
        FillRooms();
    }

    private void EditButton_Click(Object sender, EventArgs e)
    {
        _isEditing = true;
        AddButton.Text = "Save";
        var rooms = _roomsRepository.Read();
        RoomNumberBox.Text = rooms[_selectedRoom].RoomNumber.ToString();
        RoomsCountBox.Text = rooms[_selectedRoom].RoomsCount.ToString();
        CostBox.Text = rooms[_selectedRoom].RoomCost.ToString();
        PublisherBox.Text = rooms[_selectedRoom].RoomPublisher;
    }

    private void AddButton_Click(Object sender, EventArgs e)
    {
        if (_isEditing)
        {
            var rooms = _roomsRepository.Read();
            var updatedRoom = GetRoomInput();
            if (updatedRoom == null) return;
            updatedRoom.Id = rooms[_selectedRoom].Id;
            _roomsRepository.Update(updatedRoom);
            _isEditing = false;
            AddButton.Text = "Add";
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

    private void RemoveButton_Click(Object sender, EventArgs e)
    {
        var rooms = _roomsRepository.Read();
        if (rooms.Count <= 0 || _selectedRoom < 0 || _selectedRoom >= rooms.Count) return;

        _roomsRepository.Delete(rooms[_selectedRoom]);
        FillRooms();
        SaveRoomsToFile();
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