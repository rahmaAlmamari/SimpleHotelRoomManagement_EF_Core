using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleHotelRoomManagement_EF_Core.Models;
using SimpleHotelRoomManagement_EF_Core.Repositries;

namespace SimpleHotelRoomManagement_EF_Core.Services
{
    public class BookingServices
    {
        //to create private field for the BookingRepositry ...
        private readonly IBookingRepositry _BookingRepositry;
        //to create constructor to initialize the BookingRepositry ...
        public BookingServices(IBookingRepositry bookingRepositry)
        {
            _BookingRepositry = bookingRepositry;
        }
    }
}
