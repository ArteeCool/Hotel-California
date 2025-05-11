using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HotelCalifornia;

public class User : IEntity
{
    public String Id { get; set; }

    [Required(ErrorMessage = "Login is required.")]
    [MinLength(6, ErrorMessage = "Login must be at least 6 characters.")]
    [MaxLength(15, ErrorMessage = "Login is too long.")]
    public String Login { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [MinLength(6, ErrorMessage = "Password must be at least 6 characters.")]
    [MaxLength(15, ErrorMessage = "Password is too long.")]
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

    public User() { }

    public string GetId() => Id;
}