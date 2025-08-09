using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleHotelRoomManagement_EF_Core.Models;
using SimpleHotelRoomManagement_EF_Core.Repositries;

namespace SimpleHotelRoomManagement_EF_Core.Services
{
    public class RatingServices
    {
        //to create private field for the RatingRepositry ...
        private readonly IRatingRepositry _RatingRepositry;
        //to create constructor to initialize the RatingRepositry ...
        public RatingServices(IRatingRepositry ratingRepositry)
        {
            _RatingRepositry = ratingRepositry;
        }
    }
}
