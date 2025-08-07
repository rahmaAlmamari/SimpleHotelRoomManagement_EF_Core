using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHotelRoomManagement_EF_Core.Models
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public double RoomDailyPrice { get; set; }

        public bool IsAvailable = true;
    }
}
