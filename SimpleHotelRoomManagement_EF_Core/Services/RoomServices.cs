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
    }
}
