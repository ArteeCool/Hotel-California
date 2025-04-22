using System;
using System.Collections.Generic;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Forms;
using HotelCalifornia.Models;

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

        public List<Booking> GetAllBookings()
        {
            return _bookingRepository.GetAll();
        }

        public List<GuestBookingInfo> GetDetailedBookings(IRepository<Guest> guestRepository)
        {
            var bookings = _bookingRepository.GetAll();
            var result = new List<GuestBookingInfo>();

            foreach (var booking in bookings)
            {
                var guest = guestRepository.GetById(booking.GuestId);
                var room = _roomRepository.GetById(booking.RoomId);

                if (guest != null && room != null)
                {
                    result.Add(new GuestBookingInfo
                    {
                        GuestName = guest.FullName,
                        GuestEmail = guest.Email,
                        RoomName = room.Name,
                        RoomType = room.Type,
                        FromDate = booking.FromDate,
                        ToDate = booking.ToDate,
                        TotalPrice = booking.TotalPrice
                    });
                }
            }

            return result;
        }


    }
}