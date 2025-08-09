using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleHotelRoomManagement_EF_Core.Models;

namespace SimpleHotelRoomManagement_EF_Core.Repositries
{
    public class RoomRepositry
    {
        //to create private field for the DbContext ...
        private readonly HotelDbContext _context;
        //to create constructor to initialize the DbContext ...
        public RoomRepositry(HotelDbContext context)
        {
            _context = context;
        }
        //to GetAllRooms method to retrieve all rooms from the database ...
        public List<Room> GetAllRooms()
        {
            return _context.Rooms.ToList();
        }
        //to AddRoom method to add a new room to the database ...
        public void AddRoom(Room room)
        {
            _context.Rooms.Add(room);
            _context.SaveChanges();
        }
        //to GetRoomByNumber method to retrieve a room by its number ...
        public Room GetRoomByNumber(int roomNumber)
        {
            return _context.Rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
        }
        //to UpdateRoomDailyPrice method to update an existing room's DailyPrice ...
        public void UpdateRoomDailyPrice(int roomNumber, double newDailyPrice)
        {
            var room = GetRoomByNumber(roomNumber);
            if (room != null)
            {
                room.RoomDailyPrice = newDailyPrice;
                _context.SaveChanges();
            }
        }
        //to UpdateRoomAvailability method to update an existing room's availability status ...
        public void UpdateRoomAvailability(int roomNumber, bool isAvailable)
        {
            var room = GetRoomByNumber(roomNumber);
            if (room != null)
            {
                room.IsAvailable = isAvailable;
                _context.SaveChanges();
            }
        }
        //to DeleteRoom method to delete a room from the database ...
        public void DeleteRoom(int roomNumber)
        {
            var room = GetRoomByNumber(roomNumber);
            if (room != null)
            {
                _context.Rooms.Remove(room);
                _context.SaveChanges();
            }
        }
    }
}
