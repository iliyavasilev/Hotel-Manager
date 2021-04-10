using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hotel_Reservation_Manager.Models
{
    public class Guest
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string PhoneNumber { get; set; } //(Да се валидират телефонните номера, за да не превишават дължина от 10 символа;)
        public string Email { get; set; }
        public bool Adult { get; set; } //(булева стойност, съответно лица над 18 г. се считат за възрастни) 

        //[NotMapped]
        //public virtual List<Guest> Guests => new ApplicationDbContext().Guests.ToList();

        public virtual List<RoomUsage> Usages =>
           new ApplicationDbContext().RoomUsages.ToList().Where(x => x.GuestId == Id).ToList();

    }
}