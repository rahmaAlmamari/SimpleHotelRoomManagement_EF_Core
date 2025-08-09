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
    }
}
