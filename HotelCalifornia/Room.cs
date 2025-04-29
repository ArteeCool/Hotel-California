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
        public Room(string name, string type, int price, string status, string id)
        {
            Name = name;
            Type = type;
            Price = price;
            Status = status;
            Id = string.IsNullOrEmpty(id) ? Guid.NewGuid().ToString() : id;
        }


       public Room () { }

        public string GetId() => Id;
    }
}

