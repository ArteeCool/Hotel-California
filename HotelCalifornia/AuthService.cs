using System;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace HotelCalifornia
{
    public class AuthService
    {
        private readonly IRepository<User> _usersRepository;

        public AuthService(IRepository<User> usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public (bool Success, string ErrorMessage) Register(User user, string confirmPassword)
        {
            
            if (string.IsNullOrWhiteSpace(user.Login) || user.Login.Length < 6)
                return (false, "Login must be at least 6 characters.");

            if (_usersRepository.Read().Any(item => item.Login.Trim() == user.Login.Trim()))
                return (false, "Current login is taken.");

            if (string.IsNullOrWhiteSpace(user.Password) || user.Password.Length < 6)
                return (false, "Password must be at least 6 characters.");

            if (user.Password != confirmPassword)
                return (false, "Passwords do not match.");
            
            if (user.Login.Length > 50)
                return (false, "Login is too long.");

            // Хеш
            user.Password = BCrypt.Net.BCrypt.EnhancedHashPassword(user.Password);
            _usersRepository.Create(user);
            _usersRepository.Save();

            return (true, string.Empty);
        }


        public (bool Success, User User, string ErrorMessage) Login(string login, string password)
        {
            var loginUser = _usersRepository.Read().FirstOrDefault(item => item.Login == login);

            if (loginUser == null)
                return (false, null, "Wrong login or password");

            if (!BCrypt.Net.BCrypt.EnhancedVerify(password, loginUser.Password))
                return (false, null, "Wrong login or password");

            return (true, loginUser, string.Empty);
        }
    }
}