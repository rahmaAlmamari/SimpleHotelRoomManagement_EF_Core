using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleHotelRoomManagement_EF_Core.Models;

namespace SimpleHotelRoomManagement_EF_Core.Repositries
{
    public class GuestRepositry
    {
        //to create private field for the DbContext ...
        private readonly HotelDbContext _context;
        //to create constructor to initialize the DbContext ...
        public GuestRepositry(HotelDbContext context)
        {
            _context = context;
        }
        //to GetAllGuests method to retrieve all guests from the database ...
        public List<Guest> GetAllGuests()
        {
            return _context.Guests.ToList();
        }
        //to AddGuest method to add a new guest to the database ...
        public void AddGuest(Guest guest)
        {
            _context.Guests.Add(guest);
            _context.SaveChanges();
        }
        //to GetGuestById method to retrieve a guest by their ID ...
        public Guest GetGuestById(int id)
        {
            return _context.Guests.FirstOrDefault(g => g.GuestId == id);
        }
    }
}
