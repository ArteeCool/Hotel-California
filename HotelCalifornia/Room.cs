using System.Text.Json.Serialization;

namespace HotelCalifornia
{
    public class Room : IEntity
    {
        public String Name { get; set; }
        public Int32 Price { get; set; }
        public String Type { get; set; }
        public String Status { get; set; }
        public String Id { get; set; }

        [JsonConstructor]
        public Room(String name, String type, Int32 price, String status, String id)
        {
            Name = name;
            Type = type;
            Price = price;
            Status = status;
            
            Id = String.IsNullOrEmpty(id) ? Guid.NewGuid().ToString() : id;
        }

        public String GetId()
        {
            return Id;
        }
    }
}

