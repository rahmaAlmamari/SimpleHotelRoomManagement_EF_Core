using SimpleHotelRoomManagement_EF_Core.Models;

namespace SimpleHotelRoomManagement_EF_Core.Services
{
    public interface IRatingServices
    {
        void AddRating(Rating rating);
        void DeleteRating(int id);
        List<Rating> GetAllRatings();
        Rating GetRatingById(int id);
        List<Rating> GetRatingsByGuestId(int guestId);
        List<Rating> GetRatingsByRoomNumber(int roomNumber);
        void UpdateRatingComment(int id, string newComment);
        void UpdateRatingDate(int id, DateTime newDate);
        void UpdateRatingScore(int id, int newScore);
    }
}