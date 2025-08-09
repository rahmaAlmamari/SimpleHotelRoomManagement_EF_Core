using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleHotelRoomManagement_EF_Core.Models;
using SimpleHotelRoomManagement_EF_Core.Repositries;

namespace SimpleHotelRoomManagement_EF_Core.Services
{
    public class GestServices
    {
        //to create private field for the GuestRepositry ...
        private readonly IGuestRepositry _GuestRepositry;
        //to create constructor to initialize the GuestRepositry ...
        public GestServices(IGuestRepositry guestRepositry)
        {
            _GuestRepositry = guestRepositry;
        }
        //to GetAllGuests method to retrieve all guests from the database ...
        public List<Guest> GetAllGuests()
        {
            return _GuestRepositry.GetAllGuests();
        }
        //to AddGuest method to add a new guest to the database ...
        public void AddGuest(Guest guest)
        {
            _GuestRepositry.AddGuest(guest);
        }
        //to GetGuestById method to retrieve a guest by their ID ...
        public Guest GetGuestById(int id)
        {
            return _GuestRepositry.GetGuestById(id);
        }
        //to UpdateGuestName method to update an existing guest's name ...
        public void UpdateGuestName(int id, string newName)
        {
            _GuestRepositry.UpdateGuestName(id, newName);
        }
        //to UpdateGuestEmail method to update an existing guest's email ...
        public void UpdateGuestEmail(int id, string newEmail)
        {
            _GuestRepositry.UpdateGuestEmail(id, newEmail);
        }

    }
}
