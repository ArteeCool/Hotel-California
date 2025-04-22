using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCalifornia.Models
{
    public class GuestBookingInfo
    {
        public string GuestName { get; set; }
        public string GuestEmail { get; set; }
        public string RoomName { get; set; }
        public string RoomType { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
