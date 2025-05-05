using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
namespace HotelCalifornia
{
    public class Room : IEntity
    {
        [Required(ErrorMessage = "Назва кімнати обов'язковий")]
        public String Name { get; set; }
        [Range(0, 10000, ErrorMessage = "Ціна має бути в межах 0–10000")]
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

