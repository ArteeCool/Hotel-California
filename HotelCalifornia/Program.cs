using Microsoft.Data.SqlClient;

namespace HotelCalifornia;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new LoginForm());
        EnsureTablesExist("Data Source=localhost;Initial Catalog=Hotel-California;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");


    }

    public static void EnsureTablesExist(string connectionString)
    {
        using var connection = new SqlConnection(connectionString);
        connection.Open();

        var sql = @"
-- Таблиця Guests
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Guests' AND TABLE_SCHEMA = 'dbo')
BEGIN
    CREATE TABLE dbo.Guests (
        Id NVARCHAR(50) PRIMARY KEY,
        FullName NVARCHAR(200) NOT NULL,
        Gender NVARCHAR(20) NOT NULL,
        Email NVARCHAR(100) NOT NULL,
        Address NVARCHAR(300) NOT NULL,
        Phone NVARCHAR(20) NOT NULL
    );
END

-- Таблиця Rooms
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Rooms' AND TABLE_SCHEMA = 'dbo')
BEGIN
    CREATE TABLE dbo.Rooms (
        Id NVARCHAR(50) PRIMARY KEY,
        Name NVARCHAR(100) NOT NULL,
        Type NVARCHAR(50) NOT NULL,
        Price INT NOT NULL,
        Status NVARCHAR(50) NOT NULL,
        ImagePath NVARCHAR(MAX) NULL
    );
END

-- Таблиця Users
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Users' AND TABLE_SCHEMA = 'dbo')
BEGIN
    CREATE TABLE dbo.Users (
        Id NVARCHAR(50) PRIMARY KEY,
        Login NVARCHAR(100) NOT NULL,
        Password NVARCHAR(100) NOT NULL,
        IsAdmin BIT NOT NULL
    );
END

-- Таблиця Bookings
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Bookings' AND TABLE_SCHEMA = 'dbo')
BEGIN
    CREATE TABLE dbo.Bookings (
        Id NVARCHAR(50) PRIMARY KEY,
        RoomId NVARCHAR(50) NOT NULL,
        GuestId NVARCHAR(50) NOT NULL,
        FromDate DATETIME NOT NULL,
        ToDate DATETIME NOT NULL,
        TotalPrice DECIMAL(18, 2) NOT NULL,
        BookingDate DATETIME NOT NULL,

        CONSTRAINT FK_Bookings_Rooms FOREIGN KEY (RoomId) REFERENCES dbo.Rooms(Id),
        CONSTRAINT FK_Bookings_Guests FOREIGN KEY (GuestId) REFERENCES dbo.Guests(Id)
    );
END
";

        using var command = new SqlCommand(sql, connection);
        command.ExecuteNonQuery();
    }
}