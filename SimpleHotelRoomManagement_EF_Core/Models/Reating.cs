using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHotelRoomManagement_EF_Core.Models
{
    public class Reating
    {
        public int ReatingId { get; set; }

        public int GuestId { get; set; }
        public int RoomNumber { get; set; }
        public int Score { get; set; } // Assuming rating is an integer value (e.g., 1 to 5)
        public string Comment { get; set; } // Optional comment about the rating
        public DateTime RatingDate { get; set; } // Date when the rating was given
    }
}
