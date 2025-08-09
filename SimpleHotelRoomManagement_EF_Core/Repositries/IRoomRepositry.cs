using SimpleHotelRoomManagement_EF_Core.Models;

namespace SimpleHotelRoomManagement_EF_Core.Repositries
{
    public interface IRoomRepositry
    {
        void AddRoom(Room room);
        void DeleteRoom(int roomNumber);
        List<Room> GetAllRooms();
        Room GetRoomByNumber(int roomNumber);
        void UpdateRoomAvailability(int roomNumber, bool isAvailable);
        void UpdateRoomDailyPrice(int roomNumber, double newDailyPrice);
    }
}