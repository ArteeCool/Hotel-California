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
        public String ContactNumber { get; set; }

        [JsonConstructor]
        public Guest(String fullName, String gender, String email, String address, String contactNumber, String id)
        {
            FullName = fullName;
            Gender = gender;
            Email = email;
            Address = address;
            ContactNumber = contactNumber;
            Id = String.IsNullOrEmpty(id) ? Guid.NewGuid().ToString() : id;
        }

        public String GetId()
        {
            return Id;
        }
    }
}
