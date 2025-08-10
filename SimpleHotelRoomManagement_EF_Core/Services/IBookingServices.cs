using SimpleHotelRoomManagement_EF_Core.Models;

namespace SimpleHotelRoomManagement_EF_Core.Services
{
    public interface IBookingServices
    {
        void AddBooking(Guest guest, Room room, DateTime checkIn, DateTime checkOut, double price);
        void DeleteBooking(int bookingId);
        List<Booking> GetAllBookings();
        Booking GetBookingById(int id);
        List<Booking> GetBookingsByGuestId(int guestId);
        List<Booking> GetBookingsByRoomNumber(int roomNumber);
        void UpdateBookingCheckInDate(int bookingId, DateTime newCheckInDate);
        void UpdateBookingCheckOutDate(int bookingId, DateTime newCheckOutDate);
        void UpdateBookingTotalPrice(int bookingId, double newTotalPrice);
    }
}