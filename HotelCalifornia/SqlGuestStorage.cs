using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace HotelCalifornia
{
    public class SqlGuestStorage : IDataStorage<Guest>
    {
        private readonly string _connectionString;

        public SqlGuestStorage(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Guest entity)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var sql = @"INSERT INTO Guests (Id, FullName, Gender, Email, Address, Phone) 
                        VALUES (@Id, @FullName, @Gender, @Email, @Address, @Phone)";

            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Id", entity.Id);
            command.Parameters.AddWithValue("@FullName", entity.FullName);
            command.Parameters.AddWithValue("@Gender", entity.Gender);
            command.Parameters.AddWithValue("@Email", entity.Email);
            command.Parameters.AddWithValue("@Address", entity.Address);
            command.Parameters.AddWithValue("@Phone", entity.Phone);

            command.ExecuteNonQuery();
        }

        public void Update(Guest entity)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var sql = @"UPDATE Guests 
                        SET FullName = @FullName, Gender = @Gender, Email = @Email, Address = @Address, Phone = @Phone 
                        WHERE Id = @Id";

            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Id", entity.Id);
            command.Parameters.AddWithValue("@FullName", entity.FullName);
            command.Parameters.AddWithValue("@Gender", entity.Gender);
            command.Parameters.AddWithValue("@Email", entity.Email);
            command.Parameters.AddWithValue("@Address", entity.Address);
            command.Parameters.AddWithValue("@Phone", entity.Phone);

            command.ExecuteNonQuery();
        }

        public void Delete(string id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var sql = "DELETE FROM Guests WHERE Id = @Id";

            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }

        public Guest? GetById(string id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var sql = "SELECT * FROM Guests WHERE Id = @Id";

            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Id", id);

            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new Guest(
                    id: reader.GetString(reader.GetOrdinal("Id")),
                    fullName: reader.GetString(reader.GetOrdinal("FullName")),
                    gender: reader.GetString(reader.GetOrdinal("Gender")),
                    email: reader.GetString(reader.GetOrdinal("Email")),
                    address: reader.GetString(reader.GetOrdinal("Address")),
                    phone: reader.GetString(reader.GetOrdinal("Phone"))
                );
            }

            return null;
        }

        public List<Guest> GetAll()
        {
            var guests = new List<Guest>();

            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var sql = "SELECT * FROM Guests";

            using var command = new SqlCommand(sql, connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                guests.Add(new Guest(
                    id: reader.GetString(reader.GetOrdinal("Id")),
                    fullName: reader.GetString(reader.GetOrdinal("FullName")),
                    gender: reader.GetString(reader.GetOrdinal("Gender")),
                    email: reader.GetString(reader.GetOrdinal("Email")),
                    address: reader.GetString(reader.GetOrdinal("Address")),
                    phone: reader.GetString(reader.GetOrdinal("Phone"))
                ));
            }

            return guests;
        }

        public void Save()
        {
            // No operation needed for SQL
        }
    }
}
