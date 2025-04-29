using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace HotelCalifornia
{
    public class SqlBookingStorage : IDataStorage<Booking>
    {
        private readonly string _connectionString;

        public SqlBookingStorage(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Booking entity)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var sql = @"INSERT INTO Bookings (Id, RoomId, GuestId, FromDate, ToDate, TotalPrice, BookingDate)
                        VALUES (@Id, @RoomId, @GuestId, @FromDate, @ToDate, @TotalPrice, @BookingDate)";

            using var command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@Id", entity.Id);
            command.Parameters.AddWithValue("@RoomId", entity.RoomId);
            command.Parameters.AddWithValue("@GuestId", entity.GuestId);
            command.Parameters.AddWithValue("@FromDate", entity.FromDate);
            command.Parameters.AddWithValue("@ToDate", entity.ToDate);
            command.Parameters.AddWithValue("@TotalPrice", entity.TotalPrice);
            command.Parameters.AddWithValue("@BookingDate", entity.BookingDate);

            command.ExecuteNonQuery();
        }

        public void Update(Booking entity)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var sql = @"UPDATE Bookings 
                        SET RoomId = @RoomId, GuestId = @GuestId, FromDate = @FromDate, ToDate = @ToDate, 
                            TotalPrice = @TotalPrice, BookingDate = @BookingDate
                        WHERE Id = @Id";

            using var command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@Id", entity.Id);
            command.Parameters.AddWithValue("@RoomId", entity.RoomId);
            command.Parameters.AddWithValue("@GuestId", entity.GuestId);
            command.Parameters.AddWithValue("@FromDate", entity.FromDate);
            command.Parameters.AddWithValue("@ToDate", entity.ToDate);
            command.Parameters.AddWithValue("@TotalPrice", entity.TotalPrice);
            command.Parameters.AddWithValue("@BookingDate", entity.BookingDate);

            command.ExecuteNonQuery();
        }

        public void Delete(string id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var sql = "DELETE FROM Bookings WHERE Id = @Id";
            using var command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }

        public Booking? GetById(string id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var sql = "SELECT * FROM Bookings WHERE Id = @Id";
            using var command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@Id", id);

            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new Booking(
                    reader.GetString(reader.GetOrdinal("RoomId")),
                    reader.GetString(reader.GetOrdinal("GuestId")),
                    reader.GetDateTime(reader.GetOrdinal("FromDate")),
                    reader.GetDateTime(reader.GetOrdinal("ToDate")),
                    reader.GetDecimal(reader.GetOrdinal("TotalPrice")),
                    reader.GetString(reader.GetOrdinal("Id"))
                )
                {
                    BookingDate = reader.GetDateTime(reader.GetOrdinal("BookingDate"))
                };
            }
            return null;
        }

        public List<Booking> GetAll()
        {
            var bookings = new List<Booking>();

            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var sql = "SELECT * FROM Bookings";
            using var command = new SqlCommand(sql, connection);

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                bookings.Add(new Booking(
                    reader.GetString(reader.GetOrdinal("RoomId")),
                    reader.GetString(reader.GetOrdinal("GuestId")),
                    reader.GetDateTime(reader.GetOrdinal("FromDate")),
                    reader.GetDateTime(reader.GetOrdinal("ToDate")),
                    reader.GetDecimal(reader.GetOrdinal("TotalPrice")),
                    reader.GetString(reader.GetOrdinal("Id"))
                )
                {
                    BookingDate = reader.GetDateTime(reader.GetOrdinal("BookingDate"))
                });
            }

            return bookings;
        }

        public void Save()
        {
        }
    }
}
