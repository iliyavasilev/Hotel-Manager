using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hotel_Reservation_Manager.Models
{
    public class Users
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Lastname { get; set; }
        public string EGN { get; set; }
        public DateTime Date { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool Active { get; set; }
        public string PhoneNumber { get; set; } //(Да се валидират телефонните номера, за да не превишават дължина от 10 символа;)
        public string Email { get; set; }
        public bool Admin { get; set; } 

        //[NotMapped]
        //public virtual List<Guest> Guests => new ApplicationDbContext().Guests.ToList();

        //public virtual List<Reservations> Usages =>
        //   new ApplicationDbContext().RoomUsages.ToList().Where(x => x.GuestId == Id).ToList();

    }
}