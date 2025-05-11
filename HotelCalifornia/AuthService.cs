using System;
using System.ComponentModel.DataAnnotations;
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
            var context = new ValidationContext(user);
            var results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(user, context, results, true);

            if (!isValid)
            {
                var errors = results.Select(r => r.ErrorMessage).ToArray();
                string fullErrorMessage = string.Join("\n", errors);
                return (false, fullErrorMessage);
            }

            if (_usersRepository.Read().Any(u => u.Login.Trim().ToLowerInvariant() == user.Login.Trim().ToLowerInvariant()))
                return (false, "Current login is taken.");

            if (user.Password != confirmPassword)
                return (false, "Passwords do not match.");

            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            _usersRepository.Create(user);

            return (true, null);
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