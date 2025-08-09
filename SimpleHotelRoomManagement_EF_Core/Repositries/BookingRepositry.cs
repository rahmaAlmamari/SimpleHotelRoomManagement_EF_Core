using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleHotelRoomManagement_EF_Core.Models;

namespace SimpleHotelRoomManagement_EF_Core.Repositries
{
    public class BookingRepositry
    {
        //to create private field for the DbContext ...
        private readonly HotelDbContext _context;
        //to create constructor to initialize the DbContext ...
        public BookingRepositry(HotelDbContext context)
        {
            _context = context;
        }
        //to GetAllBookings method to retrieve all bookings from the database ...
        public List<Booking> GetAllBookings()
        {
            return _context.Bookings.ToList();
        }
        //to AddBooking method to add a new booking to the database ...
        public void AddBooking(Booking booking)
        {
            _context.Bookings.Add(booking);
            _context.SaveChanges();
        }
    }
}
