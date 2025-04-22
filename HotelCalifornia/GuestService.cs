using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCalifornia
{
    public class GuestService
    {
        private readonly IRepository<Guest> _repository;
    public GuestService(IRepository<Guest> repository)
    {
        _repository = repository;
    }

    //public string CreateGuest(Guest guest)
    //{
    //    _repository.Create(guest);
    //    _repository.Save();//мб не нужно
    //    return guest.Id;
    //}

        public string FindOrCreateGuest(Guest guest)
        {
            var existingGuest = _repository.Read()
                .FirstOrDefault(g => g.Phone == guest.Phone || g.Email == guest.Email);

            if (existingGuest != null)
                return existingGuest.Id;

            _repository.Create(guest);
            _repository.Save();
            return guest.Id;
        }

    }
}
