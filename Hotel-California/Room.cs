using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hotel_Management
{
    public class Room
    {
        public Int32 RoomNumber { get; set; }
        public Int32 RoomsCount { get; set; }
        public Int32 RoomCost { get; set; }
        public String RoomPublisher { get; set; }

        [JsonConstructor]
        public Room(Int32 roomNumber, Int32 roomsCount, Int32 roomCost, String roomPublisher)
        {
            RoomNumber = roomNumber;
            RoomsCount = roomsCount;
            RoomCost = roomCost;
            RoomPublisher = roomPublisher;
        }
    }
}