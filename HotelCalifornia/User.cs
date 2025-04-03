using System.Text.Json.Serialization;

namespace HotelCalifornia;

public class User : IEntity
{
    public String Id { get; set; }
    public String Login { get; set; }
    public String Password { get; set; }
    public Boolean IsAdmin { get; set; }
    
    [JsonConstructor]
    public User(String login, String password, Boolean isAdmin, String id)
    {
        Login = login;
        Password = password;
        Id = String.IsNullOrEmpty(id) ? Guid.NewGuid().ToString() : id;
        IsAdmin = isAdmin;
    }
}