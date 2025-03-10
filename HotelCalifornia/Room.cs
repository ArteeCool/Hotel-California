using System.Text.Json.Serialization;

namespace HotelCalifornia
{
    public class Room : IEntity
    {
        public Int32 RoomNumber { get; set; }
        public Int32 RoomsCount { get; set; }
        public Int32 RoomCost { get; set; }
        public String RoomPublisher { get; set; }
        public Int32 Id { get; set; }

        [JsonConstructor]
        public Room(int roomNumber, int roomsCount, int roomCost, string roomPublisher)
        {
            RoomNumber = roomNumber;
            RoomsCount = roomsCount;
            RoomCost = roomCost;
            RoomPublisher = roomPublisher;
        }
    }
}

