using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hotel_Reservation_Manager.Models
{
    public class Users
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public int Id { get; set; }
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Surname is required")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        public string Lastname { get; set; }
        [Required, StringLength(10)]
        public string EGN { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public bool Active { get; set; }
        [Required, StringLength(10)]
        public string PhoneNumber { get; set; } //(Да се валидират телефонните номера, за да не превишават дължина от 10 символа;)
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        public bool Admin { get; set; } 

        //[NotMapped]
        //public virtual List<Guest> Guests => new ApplicationDbContext().Guests.ToList();

        //public virtual List<Reservations> Usages =>
        //   new ApplicationDbContext().RoomUsages.ToList().Where(x => x.GuestId == Id).ToList();

    }
}