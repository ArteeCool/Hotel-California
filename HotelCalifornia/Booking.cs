using System;
using System.Text.Json.Serialization;

namespace HotelCalifornia
{
    public class Booking : IEntity
    {
        public String Id { get; set; }
        public String RoomId { get; set; }
        public String CustomerId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public Decimal TotalPrice { get; set; }

        [JsonConstructor]
        public Booking(String roomId, String customerId, DateTime fromDate, DateTime toDate, Decimal totalPrice, String id)
        {
            RoomId = roomId;
            CustomerId = customerId;
            FromDate = fromDate;
            ToDate = toDate;
            TotalPrice = totalPrice;
            Id = String.IsNullOrEmpty(id) ? Guid.NewGuid().ToString() : id;
        }

        public String GetId()
        {
            return Id;
        }
    }
}
