using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleHotelRoomManagement_EF_Core.Models;
using SimpleHotelRoomManagement_EF_Core.Repositries;

namespace SimpleHotelRoomManagement_EF_Core.Services
{
    public class GestServices
    {
        //to create private field for the GuestRepositry ...
        private readonly IGuestRepositry _GuestRepositry;
        //to create constructor to initialize the GuestRepositry ...
        public GestServices(IGuestRepositry guestRepositry)
        {
            _GuestRepositry = guestRepositry;
        }

    }
}
