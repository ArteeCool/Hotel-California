using System;
using System.Text.Json.Serialization;

namespace HotelCalifornia
{
    public class Guest : IEntity
    {
        public String Id { get; set; }
        public String FullName { get; set; }
        public String Gender { get; set; }
        public String Email { get; set; }
        public String Address { get; set; }
        public String Phone { get; set; }

        [JsonConstructor]
        public Guest(string fullName, string gender, string email,
             string address, string contactNumber, string id = null)
        {
            FullName = fullName;
            Gender = gender;
            Email = email;
            Address = address;
            Phone = contactNumber;
            Id = String.IsNullOrEmpty(id) ? Guid.NewGuid().ToString() : id;
        }

        public String GetId()
        {
            return Id;
        }
    }
}
