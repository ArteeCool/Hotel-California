using System;
using System.Collections.Generic;

namespace HotelCalifornia
{
    internal class RoomService
    {
        private readonly IRepository<Room> _repository;

        public RoomService(IRepository<Room> repository)
        {
            _repository = repository;
        }

        public bool AddRoom(Room room)
        {
            if (room == null || string.IsNullOrWhiteSpace(room.Name) || room.Price < 0)
                return false;

            _repository.Create(room);
            _repository.Save();
            return true;
        }

        public bool EditRoom(int index, Room updatedRoom)
        {
            var rooms = _repository.Read();
            if (index < 0 || index >= rooms.Count || updatedRoom == null)
                return false;

            var existing = rooms[index];
            existing.Name = updatedRoom.Name;
            existing.Price = updatedRoom.Price;
            existing.Type = updatedRoom.Type;
            existing.Status = updatedRoom.Status;

            _repository.Save();
            return true;
        }

        public bool DeleteRoom(int index)
        {
            var rooms = _repository.Read();
            if (index < 0 || index >= rooms.Count)
                return false;

            _repository.Delete(rooms[index]);
            _repository.Save();
            return true;
        }

        public List<Room> GetAllRooms()
        {
            return _repository.Read();
        }
    }
}
