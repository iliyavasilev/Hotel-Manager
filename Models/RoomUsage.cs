using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Reservation_Manager.Models
{
    public class RoomUsage
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public int GuestId { get; set; }
        public bool IsActive { get; set; }
        public DateTime Date { get; set; }

        public virtual Room Room => new ApplicationDbContext().Rooms.Find(RoomId);
        public virtual Guest Guest => new ApplicationDbContext().Guests.Find(GuestId);
    }
}