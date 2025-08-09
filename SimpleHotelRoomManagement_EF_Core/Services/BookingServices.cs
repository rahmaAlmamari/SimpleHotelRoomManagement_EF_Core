using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleHotelRoomManagement_EF_Core.Models;
using SimpleHotelRoomManagement_EF_Core.Repositries;

namespace SimpleHotelRoomManagement_EF_Core.Services
{
    public class BookingServices
    {
        //to create private field for the BookingRepositry ...
        private readonly IBookingRepositry _BookingRepositry;
        //to create constructor to initialize the BookingRepositry ...
        public BookingServices(IBookingRepositry bookingRepositry)
        {
            _BookingRepositry = bookingRepositry;
        }
        //to GetAllBookings method to retrieve all bookings from the database ...
        public List<Booking> GetAllBookings()
        {
            return _BookingRepositry.GetAllBookings();
        }
        //to AddBooking method to add a new booking to the database ...
        public void AddBooking(Booking booking)
        {
            _BookingRepositry.AddBooking(booking);
        }
        //to GetBookingById method to retrieve a booking by its ID ...
        public Booking GetBookingById(int id)
        {
            return _BookingRepositry.GetBookingById(id);
        }
    }
}
