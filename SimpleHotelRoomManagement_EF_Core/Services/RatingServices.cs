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
        //to GetAllRatings method to retrieve all ratings from the database ...
        public List<Rating> GetAllRatings()
        {
            return _RatingRepositry.GetAllRatings();
        }
        //to AddRating method to add a new rating to the database ...
        public void AddRating(Rating rating)
        {
            _RatingRepositry.AddRating(rating);
        }
    }
}
