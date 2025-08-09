using SimpleHotelRoomManagement_EF_Core.Models;

namespace SimpleHotelRoomManagement_EF_Core.Services
{
    public interface IRoomServices
    {
        void AddRoom(Room room);
        void DeleteRoom(int roomNumber);
        List<Room> GetAllRooms();
        Room GetRoomByNumber(int roomNumber);
        void UpdateRoomAvailability(int roomNumber, bool isAvailable);
        void UpdateRoomDailyPrice(int roomNumber, double newDailyPrice);
    }
}