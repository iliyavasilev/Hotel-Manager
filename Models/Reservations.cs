using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hotel_Reservation_Manager.Models
{
    //[Table("Reservations")]
    public class Reservations
    {
        // public int Id { get; set; }
        // public int RoomId { get; set; }
         public int GuestId { get; set; }
        // public bool IsActive { get; set; }
        // public DateTime Date { get; set; }
        [Key]
       // public int Id { get; set; }
       // public int RoomId { get; set; }
       // public string GuestId { get; set; }
        public bool IsActive { get; set; }
        

        [Required(ErrorMessage = "Room number is required")]
        public string RoomId { get; set; }
        public bool AllInclusive { get; set; }
        public bool BreakfastIncluded { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ArrivealDate { get; set; }
        // списък с клиентите, които ще се помещават в стаята 
        // потребител, който е направил резервацията 

        // public virtual Room Room => new ApplicationDbContext().Rooms.Find(RoomId);
        // public virtual Users Guest => new ApplicationDbContext().Guests.Find(GuestId);
    }
}