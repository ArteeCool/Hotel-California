using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace HotelCalifornia
{
    public class SQLRoomStorage : IDataStorage<Room>
    {
        private readonly string _connectionString;

        public SQLRoomStorage(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Room entity)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var sql = "INSERT INTO Rooms (Name, Type, Price, Status, Id, ImagePath) VALUES (@Name, @Type, @Price, @Status, @Id, @ImagePath)";
            using var command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@Name", entity.Name);
            command.Parameters.AddWithValue("@Type", entity.Type);
            command.Parameters.AddWithValue("@Price", entity.Price);
            command.Parameters.AddWithValue("@Status", entity.Status);
            command.Parameters.AddWithValue("@Id", entity.Id);
            command.Parameters.AddWithValue("@ImagePath", (object)entity.ImagePath ?? DBNull.Value);

            command.ExecuteNonQuery();
        }

        public void Update(Room entity)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var sql = "UPDATE Rooms SET Name = @Name, Type = @Type, Price = @Price, Status = @Status, ImagePath = @ImagePath WHERE Id = @Id";
            using var command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@Name", entity.Name);
            command.Parameters.AddWithValue("@Type", entity.Type);
            command.Parameters.AddWithValue("@Price", entity.Price);
            command.Parameters.AddWithValue("@Status", entity.Status);
            command.Parameters.AddWithValue("@Id", entity.Id);
            command.Parameters.AddWithValue("@ImagePath", (object)entity.ImagePath ?? DBNull.Value);

            command.ExecuteNonQuery();
        }

        public void Delete(string id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var sql = "DELETE FROM Rooms WHERE Id = @Id";
            using var command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }

        public Room? GetById(string id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var sql = "SELECT * FROM Rooms WHERE Id = @Id";
            using var command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@Id", id);

            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new Room
                {
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Type = reader.GetString(reader.GetOrdinal("Type")),
                    Price = reader.GetInt32(reader.GetOrdinal("Price")),
                    Status = reader.GetString(reader.GetOrdinal("Status")),
                    Id = reader.GetString(reader.GetOrdinal("Id")),
                    ImagePath = reader.IsDBNull(reader.GetOrdinal("ImagePath")) ? null : reader.GetString(reader.GetOrdinal("ImagePath"))
                };
            }
            return null;
        }

        public List<Room> GetAll()
        {
            var rooms = new List<Room>();

            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var sql = "SELECT * FROM Rooms";
            using var command = new SqlCommand(sql, connection);

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                rooms.Add(new Room
                {
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Type = reader.GetString(reader.GetOrdinal("Type")),
                    Price = reader.GetInt32(reader.GetOrdinal("Price")),
                    Status = reader.GetString(reader.GetOrdinal("Status")),
                    Id = reader.GetString(reader.GetOrdinal("Id")),
                    ImagePath = reader.IsDBNull(reader.GetOrdinal("ImagePath")) ? null : reader.GetString(reader.GetOrdinal("ImagePath"))
                });
            }

            return rooms;
        }

        public void Save()
        {
            // No need to do anything in SQL (no caching like JsonStorage)
            // All changes are instant in SQL
        }
    }
}