using System.Text.Json.Serialization;

namespace HotelCalifornia
{
    public class Room : IEntity
    {
        public Int32 RoomNumber { get; set; }
        public Int32 RoomsCount { get; set; }
        public Int32 RoomCost { get; set; }
        public String RoomPublisher { get; set; }
        public String Id { get; }

        [JsonConstructor]
        public Room(Int32 roomNumber, Int32 roomsCount, Int32 roomCost, String roomPublisher, String id)
        {
            RoomNumber = roomNumber;
            RoomsCount = roomsCount;
            RoomCost = roomCost;
            RoomPublisher = roomPublisher;
            Id = String.IsNullOrEmpty(id) ? Guid.NewGuid().ToString() : id;
        }

        public String GetId()
        {
            return Id;
        }
    }
}

