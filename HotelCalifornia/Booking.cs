using System;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
namespace HotelCalifornia
{
    public class Booking : IEntity
    {
        public String Id { get; set; }
        public String RoomId { get; set; }
        public String GuestId { get; set; }
        [Required(ErrorMessage = "Дата заїзду обов'язкова")]
        public DateTime FromDate { get; set; }
        [Required(ErrorMessage = "Дата виїзду обов'язкова")]
        public DateTime ToDate { get; set; }
        public Decimal TotalPrice { get; set; }
        public DateTime BookingDate { get; set; } = DateTime.Now;

        [JsonConstructor]
        public Booking(string roomId, string guestId, DateTime fromDate, DateTime toDate, decimal totalPrice, string id = null)
        {
            Id = string.IsNullOrEmpty(id) ? Guid.NewGuid().ToString() : id;
            RoomId = roomId;
            GuestId = guestId;
            FromDate = fromDate;
            ToDate = toDate;
            TotalPrice = totalPrice;
        }
        public string GetId() => Id;
    }
}
