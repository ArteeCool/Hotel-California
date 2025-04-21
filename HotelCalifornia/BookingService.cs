using System;
using System.Collections.Generic;
using System.Linq;
namespace HotelCalifornia
{
    internal class BookingService
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
        }
        public decimal CalculatePrice(Room room, DateTime from, DateTime to)
        {
            if (room == null || from >= to)
                return 0;
            var days = (to - from).Days;
            return room.Price * days;
        }
        public bool BookRoom(string roomId, string customerId, DateTime from, DateTime to)
        {
            if (from >= to) return false;

            var room = _roomRepository.Read().FirstOrDefault(r => r.Id == roomId);
            if (room == null || room.Status == "Occupied")
                return false;

            var availableRooms = GetAvailableRooms(from, to);
            if (!availableRooms.Any(r => r.Id == roomId))
                return false;

            decimal totalPrice = CalculatePrice(room, from, to);

            var booking = new Booking(
                roomId: roomId,
                customerId: customerId,
                fromDate: from,
                toDate: to,
                totalPrice: totalPrice,
                id: null
            );

            _bookingRepository.Create(booking);
            return true;
        }
    }
}