using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleHotelRoomManagement_EF_Core.Models;

namespace SimpleHotelRoomManagement_EF_Core.Repositries
{
    public class RatingRepositry
    {
        //to create private field for the DbContext ...
        private readonly HotelDbContext _context;
        //to create constructor to initialize the DbContext ...
        public RatingRepositry(HotelDbContext context)
        {
            _context = context;
        }
        //to GetAllRatings method to retrieve all ratings from the database ...
        public List<Rating> GetAllRatings()
        {
            return _context.Ratings.ToList();
        }
        //to AddRating method to add a new rating to the database ...
        public void AddRating(Rating rating)
        {
            _context.Ratings.Add(rating);
            _context.SaveChanges();
        }
        //to GetRatingById method to retrieve a rating by its ID ...
        public Rating GetRatingById(int id)
        {
            return _context.Ratings.FirstOrDefault(r => r.RatingId == id);
        }

    }
}
