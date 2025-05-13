using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
namespace HotelCalifornia
{
    public class Room : IEntity
    {
        [Required(ErrorMessage = "Назва кімнати обов'язкова")]
        public string Name { get; set; }

        [Range(0, 1000, ErrorMessage = "Ціна має бути в межах 0–1000")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Тип кімнати обов'язковий")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Статус кімнати обов'язковий")]
        public string Status { get; set; }
        public String Id { get; set; }
        public String ImagePath { get; set; }

        [JsonConstructor]
        public Room(string name, string type, int price, string status, string id, string imagePath = null)
        {
            Name = name;
            Type = type;
            Price = price;
            Status = status;
            Id = string.IsNullOrEmpty(id) ? Guid.NewGuid().ToString() : id;
            ImagePath = imagePath;
        }


       public Room () { }

        public string GetId() => Id;
    }
}

