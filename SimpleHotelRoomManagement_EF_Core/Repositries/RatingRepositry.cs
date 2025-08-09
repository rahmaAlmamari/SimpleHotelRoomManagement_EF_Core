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
        //to GetRatingsByGuestId method to retrieve ratings by guest ID ...
        public List<Rating> GetRatingsByGuestId(int guestId)
        {
            return _context.Ratings.Where(r => r.GuestId == guestId).ToList();
        }
        //to GetRatingsByRoomNumber method to retrieve ratings by room number ...
        public List<Rating> GetRatingsByRoomNumber(int roomNumber)
        {
            return _context.Ratings.Where(r => r.RoomNumber == roomNumber).ToList();
        }
        //to UpdateRatingScore method to update an existing rating's score ...
        public void UpdateRatingScore(int id, int newScore)
        {
            var rating = GetRatingById(id);
            if (rating != null)
            {
                rating.Score = newScore;
                _context.SaveChanges();
            }
        }
        //to UpdateRatingComment method to update an existing rating's comment ...
        public void UpdateRatingComment(int id, string newComment)
        {
            var rating = GetRatingById(id);
            if (rating != null)
            {
                rating.Comment = newComment;
                _context.SaveChanges();
            }
        }

    }
}
