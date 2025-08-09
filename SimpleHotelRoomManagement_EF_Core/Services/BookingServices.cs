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
        //to GetBookingsByGuestId method to retrieve bookings by guest ID ...
        public List<Booking> GetBookingsByGuestId(int guestId)
        {
            return _BookingRepositry.GetBookingsByGuestId(guestId);
        }
        //to GetBookingsByRoomNumber method to retrieve bookings by room number ...
        public List<Booking> GetBookingsByRoomNumber(int roomNumber)
        {
            return _BookingRepositry.GetBookingsByRoomNumber(roomNumber);
        }
        //to UpdateBookingCheckInDate method to update a booking's check-in date ...
        public void UpdateBookingCheckInDate(int bookingId, DateTime newCheckInDate)
        {
            _BookingRepositry.UpdateBookingCheckInDate(bookingId, newCheckInDate);
        }
        //to UpdateBookingCheckOutDate method to update a booking's check-out date ...
        public void UpdateBookingCheckOutDate(int bookingId, DateTime newCheckOutDate)
        {
            _BookingRepositry.UpdateBookingCheckOutDate(bookingId, newCheckOutDate);
        }
        //to UpdateBookingTotalPrice method to update a booking's total price ...
        public void UpdateBookingTotalPrice(int bookingId, double newTotalPrice)
        {
            _BookingRepositry.UpdateBookingTotalPrice(bookingId, newTotalPrice);
        }
    }
}
