using System;
using System.Collections.Generic;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace HotelCalifornia
{
    public class BookingService
    {
        private readonly IRepository<Booking> _bookingRepository;
        private readonly IRepository<Room> _roomRepository;
        public BookingService(IRepository<Booking> bookingRepo, IRepository<Room> roomRepo)
        {
            _bookingRepository = bookingRepo;
            _roomRepository = roomRepo;
        }
        public List<Room> GetAvailableRooms(DateTime from, DateTime to)
        {
            var allRooms = _roomRepository.Read();
            var bookings = _bookingRepository.Read();
            return allRooms.Where(room =>
                !bookings.Any(b =>
                    b.RoomId == room.Id &&
                    !(to <= b.FromDate || from >= b.ToDate)
                )
            ).ToList();

            /* var bookings = _bookingRepository.Read();
        return !bookings.Any(b => 
            b.RoomId == roomId &&
            !(to <= b.FromDate || from >= b.ToDate));*/
        }

        public bool BookRoom(string roomId, string guestId, DateTime fromDate, DateTime toDate)
        {
            var room = _roomRepository.Read().FirstOrDefault(r => r.Id == roomId);
            if (room == null || room.Status == "Occupied")
            {
                MessageBox.Show("Room is not available");
                return false;
            }

            if (!GetAvailableRooms(fromDate, toDate).Any(r => r.Id == roomId))
            {
                MessageBox.Show("Room is booked for selected dates");
                return false;
            }

            decimal totalPrice = CalculateBookingPrice(room.Price, fromDate, toDate);

            var booking = new Booking(
                roomId: roomId,
                guestId: guestId,
                fromDate: fromDate,
                toDate: toDate,
                totalPrice: totalPrice
                );

            _bookingRepository.Create(booking);

            // Updating room status
            room.Status = "Booked";
            _roomRepository.Update(room);

            MessageBox.Show("Booked Succesfully!");
            return true;
        }


        public decimal CalculateBookingPrice(int pricePerNight, DateTime fromDate, DateTime toDate)
        {
            int nights = (toDate.Date - fromDate.Date).Days;
            return nights < 0 ? 0 : nights * pricePerNight;
        }
    }
}