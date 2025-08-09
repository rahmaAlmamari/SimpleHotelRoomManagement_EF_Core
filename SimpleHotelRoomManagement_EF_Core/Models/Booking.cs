using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHotelRoomManagement_EF_Core.Models
{
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookingId { get; set; }

        //----------------------------------------------------
        public int RoomNumber { get; set; }

        //----------------------------------------------------
        [ForeignKey("guest")]
        public int GuestId { get; set; } // Foreign key property 
        public Guest guest { get; set; } // Navigation property

        //-------------------------------------------------------
        [Required]
        public DateTime CheckInDate { get; set; }

        //-------------------------------------------------------
        [Required]
        public DateTime CheckOutDate { get; set; }

        //-------------------------------------------------------
        [Required]
        public double TotalPrice { get; set; }

    }
}
