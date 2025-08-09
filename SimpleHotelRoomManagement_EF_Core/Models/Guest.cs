using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHotelRoomManagement_EF_Core.Models
{
    public class Guest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GuestId { get; set; }
        [Required]
        [MaxLength(20)]
        public string GuestName { get; set; }
        [Required]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$")]
        public string GuestEmail { get; set; }
        [Required]
        [RegularExpression(@"^\d{8}$")]
        public string GuestPhoneNumber { get; set; }

        public ICollection<Booking> GuestBooking { get; set; } // Navigation property 
    }
}
