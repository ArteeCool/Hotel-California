using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;

namespace HotelCalifornia
{
    public class UnitTests
    {
        private readonly Mock<IRepository<Room>> _mockRepo;
        private readonly RoomService _service;

        public UnitTests()
        {
            _mockRepo = new Mock<IRepository<Room>>();
            _service = new RoomService(_mockRepo.Object);
        }

        [Fact]
        public void AddRoom_ValidRoom_ReturnsTrue()
        {
            var room = new Room("Lux", "Double", 200, "Available", "1");

            var result = _service.AddRoom(room);

            Assert.True(result);
            _mockRepo.Verify(r => r.Create(room), Times.Once);
            _mockRepo.Verify(r => r.Save(), Times.Once);
        }

        [Fact]
        public void AddRoom_InvalidRoom_ReturnsFalse()
        {
            var room = new Room("", "Single", -10, "Available", "2");

            var result = _service.AddRoom(room);

            Assert.False(result);
            _mockRepo.Verify(r => r.Create(It.IsAny<Room>()), Times.Never);
            _mockRepo.Verify(r => r.Save(), Times.Never);
        }

        [Fact]
        public void EditRoom_ValidIndex_UpdatesRoom()
        {
            var existingRooms = new List<Room>
        {
            new Room("Old", "Single", 100, "Available", "1")
        };

            var updated = new Room("New", "Double", 150, "Occupied", "1");

            _mockRepo.Setup(r => r.Read()).Returns(existingRooms);

            var result = _service.EditRoom(0, updated);

            Assert.True(result);
            Assert.Equal("New", existingRooms[0].Name);
            Assert.Equal("Double", existingRooms[0].Type);
            Assert.Equal(150, existingRooms[0].Price);
            Assert.Equal("Occupied", existingRooms[0].Status);
            _mockRepo.Verify(r => r.Save(), Times.Once);
        }

        [Fact]
        public void EditRoom_InvalidIndex_ReturnsFalse()
        {
            _mockRepo.Setup(r => r.Read()).Returns(new List<Room>());

            var result = _service.EditRoom(5, new Room());

            Assert.False(result);
            _mockRepo.Verify(r => r.Save(), Times.Never);
        }

        [Fact]
        public void DeleteRoom_ValidIndex_DeletesRoom()
        {
            var roomList = new List<Room> { new Room("Room1", "Single", 100, "Available", "1") };
            _mockRepo.Setup(r => r.Read()).Returns(roomList);

            var result = _service.DeleteRoom(0);

            Assert.True(result);
            _mockRepo.Verify(r => r.Delete(roomList[0]), Times.Once);
            _mockRepo.Verify(r => r.Save(), Times.Once);
        }

        [Fact]
        public void DeleteRoom_InvalidIndex_ReturnsFalse()
        {
            _mockRepo.Setup(r => r.Read()).Returns(new List<Room>());

            var result = _service.DeleteRoom(1);

            Assert.False(result);
            _mockRepo.Verify(r => r.Delete(It.IsAny<Room>()), Times.Never);
            _mockRepo.Verify(r => r.Save(), Times.Never);
        }

        [Fact]
        public void GetRoomPrice_ValidId_ReturnsPrice()
        {
            var roomList = new List<Room>
        {
            new Room("Room1", "Single", 300, "Available", "abc123")
        };
            _mockRepo.Setup(r => r.Read()).Returns(roomList);

            var price = _service.GetRoomPrice("abc123");

            Assert.Equal(300, price);
        }

        [Fact]
        public void GetAllRooms_ReturnsAllRooms()
        {
            var rooms = new List<Room>
        {
            new Room("Room1", "Single", 100, "Available", "1"),
            new Room("Room2", "Double", 200, "Occupied", "2"),
        };
            _mockRepo.Setup(r => r.Read()).Returns(rooms);

            var result = _service.GetAllRooms();

            Assert.Equal(2, result.Count);
            Assert.Contains(result, r => r.Name == "Room1");
            Assert.Contains(result, r => r.Name == "Room2");
        }

    }
}
