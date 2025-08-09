using SimpleHotelRoomManagement_EF_Core.Models;

namespace SimpleHotelRoomManagement_EF_Core.Services
{
    public interface IGestServices
    {
        void AddGuest(Guest guest);
        void DeleteGuest(int id);
        List<Guest> GetAllGuests();
        Guest GetGuestById(int id);
        void UpdateGuestEmail(int id, string newEmail);
        void UpdateGuestName(int id, string newName);
        void UpdateGuestPhoneNumber(int id, string newPhoneNumber);
    }
}