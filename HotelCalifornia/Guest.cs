using System;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
namespace HotelCalifornia
{
    public class Guest : IEntity
    {
        public String Id { get; set; }
        [Required(ErrorMessage = "Ім'я є обов'язковим")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Ім'я має містити від 2 до 50 символів")]
        public String FullName { get; set; }
        public String Gender { get; set; }
        [Required(ErrorMessage = "Email є обов'язковим")]
        [EmailAddress(ErrorMessage = "Некоректний формат email")]
        public String Email { get; set; }
        public String Address { get; set; }
        [Phone(ErrorMessage = "Некоректний номер телефону")]
        public String Phone { get; set; }

        [JsonConstructor]
        public Guest(string id, string fullName, string gender,
             string email, string address, string phone)
        {
            FullName = fullName;
            Gender = gender;
            Email = email;
            Address = address;
            Phone = phone;
            Id = String.IsNullOrEmpty(id) ? Guid.NewGuid().ToString() : id;
        }

        public String GetId()
        {
            return Id;
        }
    }
}