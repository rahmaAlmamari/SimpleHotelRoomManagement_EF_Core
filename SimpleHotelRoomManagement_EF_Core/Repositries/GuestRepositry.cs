using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHotelRoomManagement_EF_Core.Repositries
{
    public class GuestRepositry
    {
        //to create private field for the DbContext ...
        private readonly HotelDbContext _context;
        //to create constructor to initialize the DbContext ...
        public GuestRepositry(HotelDbContext context)
        {
            _context = context;
        }
    }
}
