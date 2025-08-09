using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleHotelRoomManagement_EF_Core.Models;
using SimpleHotelRoomManagement_EF_Core.Repositries;

namespace SimpleHotelRoomManagement_EF_Core.Services
{
    public class RatingServices : IRatingServices
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
        //to GetRatingById method to retrieve a rating by its ID ...
        public Rating GetRatingById(int id)
        {
            return _RatingRepositry.GetRatingById(id);
        }
        //to GetRatingsByGuestId method to retrieve ratings by guest ID ...
        public List<Rating> GetRatingsByGuestId(int guestId)
        {
            return _RatingRepositry.GetRatingsByGuestId(guestId);
        }
        //to GetRatingsByRoomNumber method to retrieve ratings by room number ...
        public List<Rating> GetRatingsByRoomNumber(int roomNumber)
        {
            return _RatingRepositry.GetRatingsByRoomNumber(roomNumber);
        }
        //to UpdateRatingScore method to update an existing rating's score ...
        public void UpdateRatingScore(int id, int newScore)
        {
            _RatingRepositry.UpdateRatingScore(id, newScore);
        }
        //to UpdateRatingComment method to update an existing rating's comment ...
        public void UpdateRatingComment(int id, string newComment)
        {
            _RatingRepositry.UpdateRatingComment(id, newComment);
        }
        //to UpdateRatingDate method to update an existing rating's date ...
        public void UpdateRatingDate(int id, DateTime newDate)
        {
            _RatingRepositry.UpdateRatingDate(id, newDate);
        }
        //to DeleteRating method to delete a rating by its ID ...
        public void DeleteRating(int id)
        {
            _RatingRepositry.DeleteRating(id);
        }
    }
}
