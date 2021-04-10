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
        // public int GuestId { get; set; }
        // public bool IsActive { get; set; }
        // public DateTime Date { get; set; }
        [Key]
        public string RoomNumber { get; set; }
        public bool AllInclusive { get; set; }
        public bool BreakfastIncluded { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime ArrivealDate { get; set; }
        // списък с клиентите, които ще се помещават в стаята 
        // потребител, който е направил резервацията 

        // public virtual Room Room => new ApplicationDbContext().Rooms.Find(RoomId);
        // public virtual Users Guest => new ApplicationDbContext().Guests.Find(GuestId);
    }
}