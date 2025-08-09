using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHotelRoomManagement_EF_Core.Models
{
    public class Rating
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RatingId { get; set; }

        public int GuestId { get; set; }
        public int RoomNumber { get; set; }

        [Required]
        [Range(1, 5)] // Assuming a rating scale from 1 to 5
        public int Score { get; set; } // Assuming rating is an integer value (e.g., 1 to 5)

        [Required]
        [MaxLength(500)] // Optional comment, can be up to 500 characters
        public string Comment { get; set; } // Optional comment about the rating

        [Required]
        public DateTime RatingDate { get; set; } // Date when the rating was given
    }
}
