using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleHotelRoomManagement_EF_Core.Models;
using SimpleHotelRoomManagement_EF_Core.Repositries;

namespace SimpleHotelRoomManagement_EF_Core.Services
{
    public class RoomServices
    {
        //to create private field for the RoomRepositry ...
        private readonly IRoomRepositry _RoomRepositry;
        //to create constructor to initialize the RoomRepositry ...
        public RoomServices(IRoomRepositry roomRepositry)
        {
            _RoomRepositry = roomRepositry;
        }
        //to GetAllRooms method to retrieve all rooms from the database ...
        public List<Room> GetAllRooms()
        {
            return _RoomRepositry.GetAllRooms();
        }
        //to AddRoom method to add a new room to the database ...
        public void AddRoom(Room room)
        {
            _RoomRepositry.AddRoom(room);
        }
        //to GetRoomByNumber method to retrieve a room by its number ...
        public Room GetRoomByNumber(int roomNumber)
        {
            return _RoomRepositry.GetRoomByNumber(roomNumber);
        }
        //to UpdateRoomDailyPrice method to update an existing room's DailyPrice ...
        public void UpdateRoomDailyPrice(int roomNumber, double newDailyPrice)
        {
            _RoomRepositry.UpdateRoomDailyPrice(roomNumber, newDailyPrice);
        }
        //to UpdateRoomAvailability method to update an existing room's availability status ...
        public void UpdateRoomAvailability(int roomNumber, bool isAvailable)
        {
            _RoomRepositry.UpdateRoomAvailability(roomNumber, isAvailable);
        }

    }
}
