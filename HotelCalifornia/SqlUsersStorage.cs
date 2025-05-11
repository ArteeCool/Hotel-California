using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace HotelCalifornia
{
    public class SqlUsersStorage : IDataStorage<User>
    {
        private readonly string _connectionString;

        public SqlUsersStorage(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(User entity)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var sql = "INSERT INTO Users (Id, Login, Password, IsAdmin) VALUES (@Id, @Login, @Password, @IsAdmin)";
            using var command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@Id", entity.Id);
            command.Parameters.AddWithValue("@Login", entity.Login);
            command.Parameters.AddWithValue("@Password", entity.Password);
            command.Parameters.AddWithValue("@IsAdmin", entity.IsAdmin);

            command.ExecuteNonQuery();
        }

        public void Update(User entity)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var sql = "UPDATE Users SET Login = @Login, Password = @Password, IsAdmin = @IsAdmin WHERE Id = @Id";
            using var command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@Login", entity.Login);
            command.Parameters.AddWithValue("@Password", entity.Password);
            command.Parameters.AddWithValue("@IsAdmin", entity.IsAdmin);
            command.Parameters.AddWithValue("@Id", entity.Id);

            command.ExecuteNonQuery();
        }

        public void Delete(string id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var sql = "DELETE FROM Users WHERE Id = @Id";
            using var command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }

        public User? GetById(string id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var sql = "SELECT * FROM Users WHERE Id = @Id";
            using var command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@Id", id);

            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new User(
                    reader.GetString(reader.GetOrdinal("Login")),
                    reader.GetString(reader.GetOrdinal("Password")),
                    reader.GetBoolean(reader.GetOrdinal("IsAdmin")) ? true : false,
                    reader.GetString(reader.GetOrdinal("Id"))
                );
            }
            return null;
        }

        public List<User> GetAll()
        {
            var users = new List<User>();

            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var sql = "SELECT * FROM Users";
            using var command = new SqlCommand(sql, connection);

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                users.Add(new User(
                    reader.GetString(reader.GetOrdinal("Login")),
                    reader.GetString(reader.GetOrdinal("Password")),
                    reader.GetBoolean(reader.GetOrdinal("IsAdmin")) ? true : false,
                    reader.GetString(reader.GetOrdinal("Id"))

                ));
            }

            return users;
        }

        public void Save()
        {
            // Nothing needed for SQL
        }
    }
}
