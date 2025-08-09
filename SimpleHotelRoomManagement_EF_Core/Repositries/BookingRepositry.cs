using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleHotelRoomManagement_EF_Core.Models;

namespace SimpleHotelRoomManagement_EF_Core.Repositries
{
    public class BookingRepositry : IBookingRepositry
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
        //to GetBookingById method to retrieve a booking by its ID ...
        public Booking GetBookingById(int id)
        {
            return _context.Bookings.FirstOrDefault(b => b.BookingId == id);
        }
        //to GetBookingsByGuestId method to retrieve bookings by guest ID ...
        public List<Booking> GetBookingsByGuestId(int guestId)
        {
            return _context.Bookings.Where(b => b.GuestId == guestId).ToList();
        }
        //to GetBookingsByRoomNumber method to retrieve bookings by room number ...
        public List<Booking> GetBookingsByRoomNumber(int roomNumber)
        {
            return _context.Bookings.Where(b => b.RoomNumber == roomNumber).ToList();
        }
        //to UpdateBookingCheckInDate method to update a booking's check-in date ...
        public void UpdateBookingCheckInDate(int bookingId, DateTime newCheckInDate)
        {
            var booking = GetBookingById(bookingId);
            if (booking != null)
            {
                booking.CheckInDate = newCheckInDate;
                _context.SaveChanges();
            }
        }
        //to UpdateBookingCheckOutDate method to update a booking's check-out date ...
        public void UpdateBookingCheckOutDate(int bookingId, DateTime newCheckOutDate)
        {
            var booking = GetBookingById(bookingId);
            if (booking != null)
            {
                booking.CheckOutDate = newCheckOutDate;
                _context.SaveChanges();
            }
        }
        //to UpdateBookingTotalPrice method to update a booking's total price ...
        public void UpdateBookingTotalPrice(int bookingId, double newTotalPrice)
        {
            var booking = GetBookingById(bookingId);
            if (booking != null)
            {
                booking.TotalPrice = newTotalPrice;
                _context.SaveChanges();
            }
        }
        //to DeleteBooking method to delete a booking from the database ...
        public void DeleteBooking(int bookingId)
        {
            var booking = GetBookingById(bookingId);
            if (booking != null)
            {
                _context.Bookings.Remove(booking);
                _context.SaveChanges();
            }
        }

    }
}
